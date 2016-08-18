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
        private static readonly object synctrafficRoot = new object();//������
        //private static Thread hDataBaseSave;//���ݿⱣ���߳�
        //private static bool hDataBaseSaveIsAlive;//���ݿ��ʶ
        //private static bool hDataBaseEnable;//�߳�ʹ��

        private static string db_ip, db_user, db_passwd, db_name;//���ݿ����
        private static int db_port;
        private static NetServerMySQLOpt serverdbOpt = new NetServerMySQLOpt();//���ݿ����

        public delegate void ProcessMessageUI(string msg);//��Ϣ֪ͨ
        public static event ProcessMessageUI ProcessMessageUIEvent = null;


        //���������̨�ػ�����
        public static bool StartDataBaseConnection()
        {
            bool bRet1 = true;
            string msg = "";

            RegistryConfigurationBLL dataBaseSettingbll = new RegistryConfigurationBLL();
            //�����ݿ��������
            bRet1 &= dataBaseSettingbll.GetDatabaseConfigInfo(out db_ip, out db_port, out db_name, out db_user, out db_passwd);
            //�����ݿ�
            MySQLHelper.SetConnectInfo(db_ip, db_user, db_passwd, db_name);//����mysql����
            bRet1 &= MySQLHelper.OpenDataBase();

            //hDataBaseEnable = true;
            //hDataBaseSave = new Thread(SaveGeoInfoToDB);
            //hDataBaseSave.IsBackground = true;  //��̨����
            //hDataBaseSave.Start();
            if (bRet1 == true)
            {
                //��鼰�޸���
                Thread chkDBThread = new Thread(CheckAndFixTablesThread);
                chkDBThread.IsBackground = true;
                chkDBThread.Start();
                msg += String.Format("���ݿ�:{0}�����ɹ���", db_name);
            }
               
            else
                msg += String.Format("���ݿ�:{0} ����ʧ�ܣ�", db_name);

            DebugOutput.ProcessMessage(msg);//������ļ�
            //����UI������Ϣ
            if (ProcessMessageUIEvent != null)
                ProcessMessageUIEvent(msg);

            return bRet1;


        }

        //���������̨�ػ�����
        public static void StartDBConnection()
        {
            bool bRet1 = true;
            string msg = "";

            RegistryConfigurationBLL dataBaseSettingbll = new RegistryConfigurationBLL();
            //�����ݿ��������
            bRet1 &= dataBaseSettingbll.GetDatabaseConfigInfo(out db_ip, out db_port, out db_name, out db_user, out db_passwd);
            //�����ݿ�
            MySQLHelper.SetConnectInfo(db_ip, db_user, db_passwd, db_name);//����mysql����
            bRet1 &= MySQLHelper.OpenDataBase();

            //hDataBaseEnable = true;
            //hDataBaseSave = new Thread(SaveGeoInfoToDB);
            //hDataBaseSave.IsBackground = true;  //��̨����
            //hDataBaseSave.Start();
            if (bRet1 == true)
            {
                //��鼰�޸���
                Thread chkDBThread = new Thread(CheckAndFixTablesThread);
                chkDBThread.IsBackground = true;
                chkDBThread.Start();
                msg += String.Format("���ݿ�:{0}�����ɹ���", db_name);
            }

            else
                msg += String.Format("���ݿ�:{0} ����ʧ�ܣ�", db_name);

            DebugOutput.ProcessMessage(msg);//������ļ�
            //����UI������Ϣ
            if (ProcessMessageUIEvent != null)
                ProcessMessageUIEvent(msg);


        }


        /// <summary>
        /// ����ڲ����ݿ��Ƿ��𻵲������޸� 
        /// </summary>
        /// <returns></returns>
        public static void CheckAndFixTablesThread()
        {

            MySQLHelper.CheckAndFixTables();
            return;

        }

    }
}
