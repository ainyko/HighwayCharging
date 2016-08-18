using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using MySQLDriverCS;//mysql
using System.IO;//文件操作
using System.Threading;//互斥锁
using Utility;

//modified by luyaotang,2013-05-29
//c++ code style

namespace DAL
{
    //数据库操作互斥锁
    //class DatabaseshareRes
    //{
    //    public int count = 0;
    //    public Mutex mutex = new Mutex();
    //}

    public class MySQLHelper
    {
        public static bool SQLConnectedFlag = false;//连接标志
        public static string sql_uri = "127.0.0.1";
        public static int sql_port = 3306;
        public static string sql_user = "";
        public static string sql_psw = "";
        public static string sql_database = "";
        public static MySQLConnection m_mysqlConn = null;
        //private DatabaseshareRes dbRes = new DatabaseshareRes();//创建互斥锁
        private static readonly object OptLock = new object();

        //设置连接属性
        public static void SetConnectInfo(string uri, string user, string psw, string database)
        {
            sql_uri = uri;
            sql_user = user;
            sql_psw = psw;
            sql_database = database;
        }

        /// <summary>
        /// 连接字符串
        /// </summary>
        public static bool OpenDataBase()
        {
            //申请

            string bDir = AppDomain.CurrentDomain.BaseDirectory;
            if (SQLConnectedFlag == false)
            {//未连接
                string dllfile = bDir + "libmySQL.dll";
                //检查DLL文件
                if (File.Exists(dllfile) == false)
                {
                    DebugOutput.ProcessMessage("missing " + dllfile);//输出到文件
                    return false;
                }
                try
                {
                    //实例化连接
                    string strConnection = new MySQLConnectionString(sql_uri, sql_database, sql_user, sql_psw).AsString;
                    //strConnection += ";Connect Timeout=10";
                    m_mysqlConn = new MySQLConnection(strConnection);
                    //打开连接
                    m_mysqlConn.Open();
                    MySQLCommand commn = new MySQLCommand("set names gbk", m_mysqlConn);//设置编码
                    commn.ExecuteNonQuery();
                    //commn = new MySQLCommand("set autocommit = 0 ", m_mysqlConn);//禁用自动提交
                    //commn.ExecuteNonQuery();
                    SQLConnectedFlag = true;
                }
                catch (MySQLException ex)
                {
                    if (ex.ErrorCode != -2147467259)//连接不上服务器不关注
                    {
                        DebugOutput.ProcessMessage(ex);//输出到文件
                    }
                    SQLConnectedFlag = false;
                }
            }
            return SQLConnectedFlag;
        }

        /// <summary>
        /// 连接字符串
        /// </summary>
        public static  bool OpenDataBase(string uri, string user, string psw, string database)
        {
            //申请
            //set connetct info
            SetConnectInfo(uri, user, psw, database);
            //
            string bDir = AppDomain.CurrentDomain.BaseDirectory;
            if (SQLConnectedFlag == false)
            {//未连接
                string dllfile = bDir + "libmySQL.dll";
                //检查DLL文件
                if (File.Exists(dllfile) == false)
                {
                    DebugOutput.ProcessMessage("missing " + dllfile);//输出到文件
                    return false;
                }
                try
                {
                    //实例化连接
                    string strConnection = new MySQLConnectionString(sql_uri, sql_database, sql_user, sql_psw).AsString;
                    //strConnection += ";Connect Timeout=10";
                    m_mysqlConn = new MySQLConnection(strConnection);
                    //打开连接
                    m_mysqlConn.Open();
                    MySQLCommand commn = new MySQLCommand("set names gbk", m_mysqlConn);//设置编码
                    commn.ExecuteNonQuery();
                    SQLConnectedFlag = true;
                }
                catch (MySQLException ex)
                {
                    if (ex.ErrorCode != -2147467259)//连接不上服务器不关注
                    {
                        DebugOutput.ProcessMessage(ex);//输出到文件
                    }
                }
            }
            return SQLConnectedFlag;
        }

        //关闭数据库
        public static bool CloseDatabase()
        {
            bool ret = true;
            lock (OptLock)
            {
                if (SQLConnectedFlag == true)
                {
                    SQLConnectedFlag = false;
                    try
                    {
                        if (m_mysqlConn != null)
                        {
                            m_mysqlConn.Close();
                            //m_mysqlConn.Dispose();
                        }
                        m_mysqlConn = null;
                        ret = true;

                    }
                    catch (MySQLException ex)
                    {
                        DebugOutput.ProcessMessage(ex);//输出到文件
                        m_mysqlConn = null;
                    }

                }
            }
            return ret;
        }

        /// <summary>
        /// 执行SQL语句（增删改）
        /// </summary>
        /// <param name="sqlString">sql语句</param>
        /// <returns>受影响的行数</returns>
        public static bool ExecuteNonQuery(string sqlString)
        {
            bool bRet = true;
            //受影响的行数
            int affectCout = -1;
            string ee = "";
            lock (OptLock)
            {
                //连接数据库
                OpenDataBase();
                bool ret = SQLConnectedFlag;// OpenDataBase();//打开数据库
                if (ret == true)
                {
                    try
                    {

                        using (MySQLCommand cmd = new MySQLCommand(sqlString, m_mysqlConn))
                        {//执行SQL语句
                            affectCout = cmd.ExecuteNonQuery();
                        }

                    }
                    catch (MySQLException ex)
                    {//执行失败！统一抛出异常
                        ee = ex.ToString();
                        affectCout = -1;
                        bRet = false;
                        DebugOutput.ProcessMessage(String.Format("Exec sql:{0} error!\r\n", sqlString));
                    }

                }
                //连接已经断开，无效
                if (ee.Contains("gone away") == true)
                {
                    DebugOutput.ProcessMessage(ee.ToString());//输出到文件
                    CloseDatabase();
                    //m_mysqlConn.Close();
                    //SQLConnectedFlag = false;
                    //m_mysqlConn = null;
                }
            }
            return bRet;// affectCout;
        }

        /// <summary>
        /// 执行事务
        /// </summary>
        /// <param name="sqlArray">sql集</param>
        /// <returns>是否执行成功</returns>
        public static bool ExecuteNonQuery(string[] sqlArray)
        {
            //受影响的行数
            int affectCout = 0;
            string ee = "";
            bool ret = false;
            string sqlString = "";
            try
            {

                for (int i = 0; i < sqlArray.Length; i++)
                {
                    sqlString = sqlArray[i];
                    if (sqlString == null || sqlString == "")
                        continue;
                    //连接数据库
                    OpenDataBase();
                    ret = SQLConnectedFlag;// OpenDataBase();//打开数据库
                    lock (OptLock)
                    {
                        if (ret == true)
                        {
                            using (MySQLCommand cmd = new MySQLCommand(sqlString, m_mysqlConn))
                            {//执行SQL语句
                                affectCout += cmd.ExecuteNonQuery();
                                ret = true;
                            }
                        }
                    }
                }
            }
            catch (MySQLException ex)
            {//执行失败！统一抛出异常
                ee = ex.ToString();
                ret = false;
                DebugOutput.ProcessMessage(String.Format("Exec sql:{0} error!\r\n", sqlString));
            }
            //连接已经断开，无效
            if (ee.Contains("gone away") == true)
            {
                DebugOutput.ProcessMessage(ee.ToString());//输出到文件
                //m_mysqlConn.Close();
                //SQLConnectedFlag = false;
                //m_mysqlConn = null;
                CloseDatabase();
            }
            return ret;
        }

        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="sql">执行的SQL语句</param>
        /// <returns>null-数据库操作失败，table[0]=null,无数据</returns>
        public static DataSet GetDataSet(string sql)
        {
            DataSet ds = null;
            int affcount = 0;
            string ee = "";
            lock (OptLock)
            {
                //连接数据库
                OpenDataBase();
                bool ret = SQLConnectedFlag;//OpenDataBase();//打开数据库
                if (ret == true)
                {
                    try
                    {

                        ds = new DataSet();
                        using (MySQLDataAdapter da = new MySQLDataAdapter(sql, m_mysqlConn))
                        {
                            ds = new DataSet();
                            affcount = da.Fill(ds);
                            da.Dispose();
                        }

                    }
                    catch (MySQLException ex)
                    {  //执行失败！统一抛出异常
                        DebugOutput.ProcessMessage(String.Format("Exec sql:{0} error!\r\n", sql));
                        ee = "GetDataSet:" + ex.ToString();
                    }
                }
                //连接已经断开，无效
                if (ee.Contains("gone away") == true)
                {
                    DebugOutput.ProcessMessage(ee.ToString());//输出到文件
                    CloseDatabase();
                    //m_mysqlConn.Close();
                    //SQLConnectedFlag = false;
                    //m_mysqlConn = null;
                }
            }
            return ds;
        }


        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="sql">执行的SQL语句</param>
        /// <returns>null-数据库操作失败，table[0]=null,无数据</returns>
        public static DataTable GetDataTable(string sql)
        {
            DataTable dt = null;
            int affcount = 0;
            string ee = "";
            lock (OptLock)
            {
                //连接数据库
                OpenDataBase();
                bool ret = SQLConnectedFlag;//OpenDataBase();//打开数据库
                if (ret == true)
                {
                    try
                    {

                        dt = new DataTable();
                        using (MySQLDataAdapter da = new MySQLDataAdapter(sql, m_mysqlConn))
                        {
                            dt = new DataTable();
                            affcount = da.Fill(dt);
                            da.Dispose();
                        }

                    }
                    catch (MySQLException ex)
                    {  //执行失败！统一抛出异常
                        DebugOutput.ProcessMessage(String.Format("Exec sql:{0} error!\r\n", sql));
                        ee = "GetDataTable:" + ex.ToString();
                    }
                }
                //连接已经断开，无效
                if (ee.Contains("gone away") == true)
                {
                    DebugOutput.ProcessMessage(ee.ToString());//输出到文件
                    CloseDatabase();
                    //m_mysqlConn.Close();
                    //SQLConnectedFlag = false;
                    //m_mysqlConn = null;
                }
            }
            return dt;
        }

        /// <summary>
        /// 获取数据库的状态
        /// </summary>
        /// <returns>数据库的打开状态</returns>
        public static bool GetDataBaseStatus()
        {
            return SQLConnectedFlag;
        }


        /// <summary>
        /// 检查内部数据库是否损坏并尝试修复 
        /// </summary>
        /// <returns></returns>
        public static bool CheckAndFixTables()
        {
            bool bRet = true;
            DataSet ds1 = GetDataSet("show tables");
            if (ds1 != null && ds1.Tables.Count > 0 && ds1.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    string tbname = ds1.Tables[0].Rows[i][0].ToString();
                    //检查该表
                    DataSet ds2 = GetDataSet("check table " + tbname);
                    if (ds2 != null && ds2.Tables.Count > 0 && ds2.Tables[0].Rows.Count > 0)
                    {
                        if (ds2.Tables[0].Rows[0]["Msg_text"].ToString().Contains("OK") == false)
                        {
                            //修复表
                            bRet &= ExecuteNonQuery("REPAIR TABLE " + tbname);
                            DebugOutput.ProcessMessage("try to fix table:" + tbname);
                        }
                    }
                }
            }
            return bRet;
        }
    }
}
