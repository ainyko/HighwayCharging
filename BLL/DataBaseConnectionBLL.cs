using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Utility;
using DAL;

namespace BLL
{
    public static class DataBaseConnectionBLL
    {
        private static readonly object synctrafficRoot = new object();//互斥锁
        //private static Thread hDataBaseSave;//数据库保存线程
        //private static bool hDataBaseSaveIsAlive;//数据库标识
        //private static bool hDataBaseEnable;//线程使能

        private static string db_ip, db_user, db_passwd, db_name;//数据库参数
        private static int db_port;
        private static NetServerMySQLOpt serverdbOpt = new NetServerMySQLOpt();//数据库操作

        public delegate void ProcessMessageUI(string msg);//消息通知
        public static event ProcessMessageUI ProcessMessageUIEvent = null;


        //开启网络后台守护进程
        public static bool StartDataBaseConnection()
        {
            bool bRet1 = true;
            string msg = "";

            RegistryConfigurationBLL dataBaseSettingbll = new RegistryConfigurationBLL();
            //从数据库加载配置
            bRet1 &= dataBaseSettingbll.GetDatabaseConfigInfo(out db_ip, out db_port, out db_name, out db_user, out db_passwd);
            //打开数据库
            MySQLHelper.SetConnectInfo(db_ip, db_user, db_passwd, db_name);//设置mysql配置
            bRet1 &= MySQLHelper.OpenDataBase();

            //hDataBaseEnable = true;
            //hDataBaseSave = new Thread(SaveGeoInfoToDB);
            //hDataBaseSave.IsBackground = true;  //后台运行
            //hDataBaseSave.Start();
            if (bRet1 == true)
            {
                //检查及修复表
                Thread chkDBThread = new Thread(CheckAndFixTablesThread);
                chkDBThread.IsBackground = true;
                chkDBThread.Start();
                msg += String.Format("数据库:{0}启动成功！", db_name);
            }
               
            else
                msg += String.Format("数据库:{0} 启动失败！", db_name);

            DebugOutput.ProcessMessage(msg);//输出到文件
            //向上UI推送消息
            if (ProcessMessageUIEvent != null)
                ProcessMessageUIEvent(msg);

            return bRet1;


        }

        //开启网络后台守护进程
        public static void StartDBConnection()
        {
            bool bRet1 = true;
            string msg = "";

            RegistryConfigurationBLL dataBaseSettingbll = new RegistryConfigurationBLL();
            //从数据库加载配置
            bRet1 &= dataBaseSettingbll.GetDatabaseConfigInfo(out db_ip, out db_port, out db_name, out db_user, out db_passwd);
            //打开数据库
            MySQLHelper.SetConnectInfo(db_ip, db_user, db_passwd, db_name);//设置mysql配置
            bRet1 &= MySQLHelper.OpenDataBase();

            //hDataBaseEnable = true;
            //hDataBaseSave = new Thread(SaveGeoInfoToDB);
            //hDataBaseSave.IsBackground = true;  //后台运行
            //hDataBaseSave.Start();
            if (bRet1 == true)
            {
                //检查及修复表
                Thread chkDBThread = new Thread(CheckAndFixTablesThread);
                chkDBThread.IsBackground = true;
                chkDBThread.Start();
                msg += String.Format("数据库:{0}启动成功！", db_name);
            }

            else
                msg += String.Format("数据库:{0} 启动失败！", db_name);

            DebugOutput.ProcessMessage(msg);//输出到文件
            //向上UI推送消息
            if (ProcessMessageUIEvent != null)
                ProcessMessageUIEvent(msg);


        }


        /// <summary>
        /// 检查内部数据库是否损坏并尝试修复 
        /// </summary>
        /// <returns></returns>
        public static void CheckAndFixTablesThread()
        {

            MySQLHelper.CheckAndFixTables();
            return;

        }

    }
}
