using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32; //��ע������һ��Ҫ������������ռ�
using Utility;

namespace BLL
{
    public class RegistryConfigurationBLL
    {
        //��ע����ȡ���ݿ��������Ϣ
        public bool GetDatabaseConfigInfo(out string ipaddr, out int port, out string dbname, out string user, out string passwd)
        {
            bool ret = false;
            string RegPath;
            //��ʼ������ֵ
            ipaddr = "127.0.0.1";
            port = 3306;
            dbname = "HighWayCharging";
            user = "root";
            passwd = "elec230";
            //��ע������ֵ
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
                    DebugOutput.ProcessMessage("GetDatabaseConfigInfo:" + ex.ToString());//������ļ�
                }
                dbkey.Close(); //�ر�ע���
            }
            return ret;
        }

        //�������ݿ����Ϣ
        public bool SetDatabaseConfigInfo(string ipaddr, int port, string dbname, string user, string passwd)
        {
            bool ret = false;
            string RegPath;
            //������Ϣд��ע���
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
                    DebugOutput.ProcessMessage("SetDatabaseConfigInfo:" + ex.ToString());//������ļ�
                }
                dbkey.Close(); //�ر�ע���
            }
            return ret;
        }

        //��ע����ȡ�û�����
        public bool GetUserConfigInfo(out string user, out string passwd)
        {
            bool ret = false;
            string RegPath;
            //��ʼ������ֵ
            user = "root";
            passwd = "admin";
            //��ע������ֵ
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
                    DebugOutput.ProcessMessage("GetUserConfigInfo:" + ex.ToString());//������ļ�
                }
                dbkey.Close(); //�ر�ע���
            }
            return ret;
        }

        //����ע������Ϣ
        public bool SetUserConfigInfo(string user, string passwd)
        {
            bool ret = false;
            string RegPath;
            //������Ϣд��ע���
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
                    DebugOutput.ProcessMessage("SetUserConfigInfo:" + ex.ToString());//������ļ�
                }
                dbkey.Close(); //�ر�ע���
            }
            return ret;
        }

    }
}
