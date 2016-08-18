using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Utility;
using System.Threading;//线程
using System.Diagnostics;//process
using System.Data;//DATASET

namespace BLL
{
    public class SystemUserManagerBLL
    {

        //MySQLHelper RecentInfoQuerydb = new MySQLHelper();//推送数据记录


        //bool dbflag = false;

        ////初始化数据库操作
        //public bool InitDatabase()
        //{
        //    bool bRet = false;
        //    if (dbflag == false)
        //    {
        //        //获取数据库配置
        //        string db_ip, db_user, db_passwd, db_name;
        //        int db_port;

        //        //加载数据库配置
        //        RegistryConfigurationBLL netbll = new RegistryConfigurationBLL();
        //        bRet = netbll.GetDatabaseConfigInfo(out db_ip, out db_port, out db_name, out db_user, out db_passwd);//从数据库加载配置
        //        //连接数据库
        //        dbflag = RecentInfoQuerydb.OpenDataBase(db_ip, db_user, db_passwd, db_name);
        //    }
        //    return dbflag;
        //}

        ////关闭数据连接
        //public bool CloseDatabase()
        //{
        //    bool bRet = false;
        //    //退出时关闭数据库操作
        //    bRet = RecentInfoQuerydb.CloseDatabase();
        //    dbflag = false;
        //    return bRet;
        //}

        //查询系统用户数据
        public DataSet GetSystemUserDsInfo()
        {
            DataSet ds = null;

            string[] sqlString = new string[1];

            sqlString[0] = "SELECT ID,userName,passWord, privilege,name,gender,IDCard,state FROM `system` order by id desc  ";

            ds = MySQLHelper.GetDataSet(sqlString[0]);

            return ds;
        }


        //查询系统用户数据
        public DataTable GetSystemUserDtInfo()
        {
            DataTable dt = null;
            string sqlString = "";

            sqlString = "SELECT ID,userName,passWord, privilege,name,gender,IDCard,state FROM `system` order by id desc  ";

            dt = MySQLHelper.GetDataTable(sqlString);

            return dt;
        }
    }
}
