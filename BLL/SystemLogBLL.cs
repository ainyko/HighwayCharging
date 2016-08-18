using System;
using System.Collections.Generic;
using System.Text;
using System.Data;//DATASET
using DAL;

namespace BLL
{
    public class SystemLogBLL
    {

        //��ѯ���µĳ�����Ϣ����
        public DataTable GetSystemLogInfo()
        {
            DataTable dt = null;
            string sqlString = "";

            sqlString = "SELECT * FROM `systemlog` order by id desc  ";

            dt = MySQLHelper.GetDataTable(sqlString);

            return dt;
        }


        //��ѯ���µĳ�����Ϣ����
        public DataTable GetSystemLogInfo(string startTime, string endTime)
        {
            DataTable dt = null;
            string sqlString = "";

            sqlString = string.Format(@"SELECT * FROM `systemlog` where LoginTime  >= '{0}'  and LoginTime  <= '{1}' order by id desc", startTime, endTime);

            dt = MySQLHelper.GetDataTable(sqlString);

            return dt;
        }
    }
}
