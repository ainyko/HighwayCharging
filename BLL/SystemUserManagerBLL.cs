using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Utility;
using System.Threading;//�߳�
using System.Diagnostics;//process
using System.Data;//DATASET

namespace BLL
{
    public class SystemUserManagerBLL
    {

        //MySQLHelper RecentInfoQuerydb = new MySQLHelper();//�������ݼ�¼


        //bool dbflag = false;

        ////��ʼ�����ݿ����
        //public bool InitDatabase()
        //{
        //    bool bRet = false;
        //    if (dbflag == false)
        //    {
        //        //��ȡ���ݿ�����
        //        string db_ip, db_user, db_passwd, db_name;
        //        int db_port;

        //        //�������ݿ�����
        //        RegistryConfigurationBLL netbll = new RegistryConfigurationBLL();
        //        bRet = netbll.GetDatabaseConfigInfo(out db_ip, out db_port, out db_name, out db_user, out db_passwd);//�����ݿ��������
        //        //�������ݿ�
        //        dbflag = RecentInfoQuerydb.OpenDataBase(db_ip, db_user, db_passwd, db_name);
        //    }
        //    return dbflag;
        //}

        ////�ر���������
        //public bool CloseDatabase()
        //{
        //    bool bRet = false;
        //    //�˳�ʱ�ر����ݿ����
        //    bRet = RecentInfoQuerydb.CloseDatabase();
        //    dbflag = false;
        //    return bRet;
        //}

        //��ѯϵͳ�û�����
        public DataSet GetSystemUserDsInfo()
        {
            DataSet ds = null;

            string[] sqlString = new string[1];

            sqlString[0] = "SELECT ID,userName,passWord, privilege,name,gender,IDCard,state FROM `system` order by id desc  ";

            ds = MySQLHelper.GetDataSet(sqlString[0]);

            return ds;
        }


        //��ѯϵͳ�û�����
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
