using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class TollRateConfigurationBLL
    {
        //查询所有收费站费率表
        public DataTable Query()
        {
            DataTable dt = null;
            string sql = String.Format("SELECT * FROM tollrate");
            dt = MySQLHelper.GetDataTable(sql);
            return dt;
        }
    }
}
