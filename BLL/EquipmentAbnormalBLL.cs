using System;
using System.Collections.Generic;
using System.Text;
using System.Data;//DATASET
using DAL;

namespace BLL
{
    public class EquipmentAbnormalBLL
    {
        //查询最新的车辆信息数据
        public DataTable GetEquipmentAbnormalInfo()
        {
            DataTable dt = null;
            string sqlString = "";

            sqlString = string.Format("SELECT * FROM `equipmentstate` where TollstationName = '{0}'and LaneID = '{1}' order by id desc  ;", GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all);

            dt = MySQLHelper.GetDataTable(sqlString);

            return dt;
        }


    }
}
