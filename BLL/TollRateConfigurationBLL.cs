using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class TollRateConfigurationBLL
    {
        //��ѯ�����շ�վ���ʱ�
        public DataTable Query()
        {
            DataTable dt = null;
            string sql = String.Format("SELECT * FROM tollrate");
            dt = MySQLHelper.GetDataTable(sql);
            return dt;
        }
    }
}
