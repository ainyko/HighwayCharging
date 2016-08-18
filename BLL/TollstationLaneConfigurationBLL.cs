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
        //��ѯ�����շ�վ��������
        public DataTable Query()
        {
            DataTable dt = null;
            string sql = String.Format("SELECT * FROM lane");
            dt = MySQLHelper.GetDataTable(sql);
            return dt;
        }
        //��ѯ�����շ�վ
        public DataTable Tollstation_Query()
        {
            DataTable dt = null;
            string sql = String.Format("SELECT TollstationID,TollstationName FROM tollstation");
            dt = MySQLHelper.GetDataTable(sql);
            return dt;
        }
        //�����շ�վ������ڲ�ѯ����
        public DataTable TollstationLane_Query(string TollstationID,string InOutward)
        {
            DataTable dt = null;
            string sql = String.Format("SELECT LaneID FROM lane WHERE TollstationID='{0}' and InOutward='{1}'", TollstationID, InOutward);
            dt = MySQLHelper.GetDataTable(sql);
            return dt;
        }
        //�����շ�վ��������Ų�ѯ�Զ�/���Զ�״̬���豸״̬
        public DataTable TollstationState_Query(string TollstationName, string LaneID)
        {
            DataTable dt = null;
            string sql = String.Format("SELECT AutoSemiauto,EquipmentState FROM lane WHERE TollstationName='{0}' and LaneID='{1}'", TollstationName, LaneID);
            dt = MySQLHelper.GetDataTable(sql);
            return dt;
        }
        //��д������ͨ/�ر�״̬
        public bool Modify_OpenState(string TollstationName, string LaneID, string OpenState)
        {
            bool bRet = true;
            string sql = String.Format("update lane set OpenState='{2}' WHERE TollstationName='{0}' and LaneID='{1}'", TollstationName, LaneID, OpenState);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("DBError: " + sql + "\r\n");//������ļ�
            }
            return bRet;
        }
    }
}
