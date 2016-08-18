using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Utility;
using DAL;
using System.Data;

namespace BLL
{
    public class EntranceExitConfigurationBll
    {
        //��ѯ�����շ�վ
        public DataTable Query()
        {
            DataTable dt = null;
            string sql = String.Format("SELECT * FROM tollstation");
            dt=MySQLHelper.GetDataTable(sql);
            return dt;
        }
        //�����������շ�վ
        public bool Add_TollStation(string TollstationID,string TollstationName,string EntranceLane,string ExitLane,string UpstreamID,string UpstreamName,string DownstreamID,string DownstreamName)
        {
            bool bRet = true;
            string sql = String.Format("insert into tollstation(TollstationID, TollstationName, EntranceLane, ExitLane, UpstreamID, UpstreamName,DownstreamID, DownstreamName) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", TollstationID, TollstationName, EntranceLane, ExitLane, UpstreamID, UpstreamName, DownstreamID, DownstreamName);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("DBError: " + sql + "\r\n");//������ļ�
            }
            return bRet;
        }
        //�޸Ľ������շ�վ
        public bool Modify_TollStation(string ID, string TollstationName, string EntranceLane, string ExitLane, string UpstreamID, string UpstreamName, string DownstreamID,string DownstreamName)
        {
            bool bRet = true;
            string sql = String.Format("update tollstation set TollstationName='{1}',EntranceLane='{2}',ExitLane='{3}',UpstreamID='{4}',UpstreamName='{5}',DownstreamID='{6}',DownstreamName='{7}' WHERE ID='{0}'", ID, TollstationName, EntranceLane, ExitLane, UpstreamID, UpstreamName, DownstreamID, DownstreamName);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("DBError: " + sql + "\r\n");//������ļ�
            }
            return bRet;
        }
        //ɾ���������շ�վ
        public bool Delet_TollStation(string ID)
        {
            bool bRet = true;
            string sql = String.Format("DELETE FROM tollstation WHERE ID={0}",ID);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("DBError: " + sql + "\r\n");//������ļ�
            }
            return bRet;
        }
    }
}
