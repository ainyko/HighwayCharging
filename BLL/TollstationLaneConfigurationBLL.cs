using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAL;
using Utility;

namespace BLL
{
    public class TollstationLaneConfigurationBLL
    {
        //查询所有收费站车道设置
        public DataTable Query()
        {
            DataTable dt = null;
            string sql = String.Format("SELECT * FROM lane");
            dt = MySQLHelper.GetDataTable(sql);
            return dt;
        }
        //查询所有收费站
        public DataTable Tollstation_Query()
        {
            DataTable dt = null;
            string sql = String.Format("SELECT TollstationID,TollstationName FROM tollstation");
            dt = MySQLHelper.GetDataTable(sql);
            return dt;
        }
        //根据收费站，出入口查询车道
        public DataTable TollstationLane_Query(string TollstationID,string InOutward)
        {
            DataTable dt = null;
            string sql = String.Format("SELECT LaneID FROM lane WHERE TollstationID='{0}' and InOutward='{1}'", TollstationID, InOutward);
            dt = MySQLHelper.GetDataTable(sql);
            return dt;
        }
        //根据收费站，车道编号查询自动/半自动状态和设备状态
        public DataTable TollstationState_Query(string TollstationName, string LaneID)
        {
            DataTable dt = null;
            string sql = String.Format("SELECT AutoSemiauto,EquipmentState FROM lane WHERE TollstationName='{0}' and LaneID='{1}'", TollstationName, LaneID);
            dt = MySQLHelper.GetDataTable(sql);
            return dt;
        }
        //改写车道开通/关闭状态
        public bool Modify_OpenState(string TollstationName, string LaneID, string OpenState)
        {
            bool bRet = true;
            string sql = String.Format("update lane set OpenState='{2}' WHERE TollstationName='{0}' and LaneID='{1}'", TollstationName, LaneID, OpenState);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("DBError: " + sql + "\r\n");//输出到文件
            }
            return bRet;
        }
    }
}
