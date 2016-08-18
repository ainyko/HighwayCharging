using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32; //对注册表操作一定要引用这个命名空间
using Utility;

namespace BLL
{
    public class RegistryConfigurationBLL
    {
        //从注册表获取数据库的配置信息
        public bool GetDatabaseConfigInfo(out string ipaddr, out int port, out string dbname, out string user, out string passwd)
        {
            bool ret = false;
            string RegPath;
            //初始化返回值
            ipaddr = "127.0.0.1";
            port = 3306;
            dbname = "HighWayCharging";
            user = "root";
            passwd = "elec230";
            //从注册表加载值
            RegPath = String.Format("Software\\gztranstar\\HighWayCharging\\mysql");

            RegistryKey dbkey;

            dbkey = Registry.CurrentUser.OpenSubKey(RegPath, true);
            if (dbkey != null)
            {
                try
                {
                    string szValue;
                    int nValue;
                    szValue = Convert.ToString(dbkey.GetValue("ipaddr")); if (szValue != "") ipaddr = szValue;
                    nValue = Convert.ToInt32(dbkey.GetValue("port")); if (nValue != 0) port = nValue;
                    szValue = Convert.ToString(dbkey.GetValue("dbname")); if (szValue != "") dbname = szValue;
                    szValue = Convert.ToString(dbkey.GetValue("user")); if (szValue != "") user = szValue;
                    szValue = Convert.ToString(dbkey.GetValue("passwd"));
                    //if (szValue != "")
                    passwd = szValue;
                    ret = true;
                }
                catch (Exception ex)
                {
                    DebugOutput.ProcessMessage("GetDatabaseConfigInfo:" + ex.ToString());//输出到文件
                }
                dbkey.Close(); //关闭注册表
            }
            return ret;
        }

        //设置数据库的信息
        public bool SetDatabaseConfigInfo(string ipaddr, int port, string dbname, string user, string passwd)
        {
            bool ret = false;
            string RegPath;
            //设置信息写入注册表
            RegistryKey dbkey;

            RegPath = String.Format("Software\\gztranstar\\HighWayCharging\\mysql");

            dbkey = Registry.CurrentUser.CreateSubKey(RegPath);
            if (dbkey != null)
            {
                try
                {
                    dbkey.SetValue("ipaddr", ipaddr);
                    dbkey.SetValue("port", port);
                    dbkey.SetValue("dbname", dbname);
                    dbkey.SetValue("user", user);
                    dbkey.SetValue("passwd", passwd);
                    ret = true;
                }
                catch (Exception ex)
                {
                    DebugOutput.ProcessMessage("SetDatabaseConfigInfo:" + ex.ToString());//输出到文件
                }
                dbkey.Close(); //关闭注册表
            }
            return ret;
        }

        //从注册表获取用户密码
        public bool GetUserConfigInfo(out string user, out string passwd)
        {
            bool ret = false;
            string RegPath;
            //初始化返回值
            user = "root";
            passwd = "admin";
            //从注册表加载值
            RegPath = String.Format("Software\\gztranstar\\HighWayCharging\\user");

            RegistryKey dbkey;

            dbkey = Registry.CurrentUser.OpenSubKey(RegPath, true);
            if (dbkey != null)
            {
                try
                {
                    string szValue;
                    szValue = Convert.ToString(dbkey.GetValue("user")); 
                    user = szValue;
                    szValue = Convert.ToString(dbkey.GetValue("passwd"));
                    //if (szValue != "")
                    passwd = szValue;
                    ret = true;
                }
                catch (Exception ex)
                {
                    DebugOutput.ProcessMessage("GetUserConfigInfo:" + ex.ToString());//输出到文件
                }
                dbkey.Close(); //关闭注册表
            }
            return ret;
        }

        //设置注册表的信息
        public bool SetUserConfigInfo(string user, string passwd)
        {
            bool ret = false;
            string RegPath;
            //设置信息写入注册表
            RegistryKey dbkey;

            RegPath = String.Format("Software\\gztranstar\\HighWayCharging\\user");

            dbkey = Registry.CurrentUser.CreateSubKey(RegPath);
            if (dbkey != null)
            {
                try
                {
                    dbkey.SetValue("user", user);
                    dbkey.SetValue("passwd", passwd);
                    ret = true;
                }
                catch (Exception ex)
                {
                    DebugOutput.ProcessMessage("SetUserConfigInfo:" + ex.ToString());//输出到文件
                }
                dbkey.Close(); //关闭注册表
            }
            return ret;
        }

    }
}
