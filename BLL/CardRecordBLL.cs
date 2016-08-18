using System;
using System.Collections.Generic;
using System.Text;
using System.Data;//DATASET
using DAL;

namespace BLL
{
    public class CardRecordBLL
    {

        //查询历史发卡情况
        public DataTable GetCardRecordDtInfo()
        {
            DataTable dt = null;
            string sqlString = "";

            sqlString = string.Format("SELECT ID,CarNum,ArrivalTime, TollStationName,LaneID,SendCardTime,ICCard,CarType FROM `cardrecord` where TollStationName = '{0}'and LaneID = '{1}'order by id desc  ;", GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all);

            dt = MySQLHelper.GetDataTable(sqlString);

            return dt;
        }
    }
}
