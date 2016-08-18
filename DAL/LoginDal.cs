using System;
using System.Collections.Generic;
using System.Text;
using MySQLDriverCS;//mysql
using Utility;

namespace DAL
{
    public class LoginDal
    {
        public static string Login(string username, string password, string sql_uri, string sql_database, string sql_user, string sql_psw)
        {
            string temp = "";
            MySQLConnection m_mysqlConn = null;

            string sql = "SELECT * FROM system WHERE USERNAME=" + "'" + username + "'" + "AND PASSWORD=" + "'" + password + "'";

            try
            {
                //实例化连接
                string strConnection = new MySQLConnectionString(sql_uri, sql_database, sql_user, sql_psw).AsString;
                //strConnection += ";Connect Timeout=10";
                m_mysqlConn = new MySQLConnection(strConnection);
                //打开连接
                m_mysqlConn.Open();

                MySQLCommand cmd = new MySQLCommand(sql, m_mysqlConn);

                MySQLDataReader reader = (MySQLDataReader)cmd.ExecuteReader();
               
                if (reader.Read())

                    temp = "1";

                else

                    temp = "0";

            }
            catch (MySQLException ex)
            {
                if (ex.ErrorCode != -2147467259)//连接不上服务器不关注
                {
                    DebugOutput.ProcessMessage(ex);//输出到文件
                }
            }
            return temp;
        }


        public static bool SetLoginLog(string userName)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("insert into systemlog(LoginTime,LoginUser,Action) values ('{0}','{1}','Login');", DateTime.Now, userName);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("LoginErro:" + sql + "\r\n");//输出到文件
            }

            return bRet;
        }

        //插入系统日志
        public static bool SetSystemLog(string userName, string action)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("insert into systemlog(LoginTime,LoginUser,Action) values ('{0}','{1}','{2}');", DateTime.Now, userName, action);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("actionErro:" + sql + "\r\n");//输出到文件
            }

            return bRet;
        }

        public static bool SetLogoutLog(string userName)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("insert into systemlog(LoginTime,LoginUser,Action) values ('{0}','{1}','Logout');", DateTime.Now, userName);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("LogoutErro:" + sql + "\r\n");//输出到文件
            }

            return bRet;
        }

    }
}
