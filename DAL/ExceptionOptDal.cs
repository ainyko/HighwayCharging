using System;
using System.Collections.Generic;
using System.Text;
using MySQLDriverCS;//mysql
using Utility;

namespace DAL
{
    public class ExceptionOptDal
    {
        //�쳣����
        public bool Maintenance(int ID)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("update equipmentstate set restoring = '��',reporting = '��',RestoreTime = now() ,reportor = '{0}' where id = {1};", UserDal.userName, ID);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("MaintenanceErro:" + sql + "\r\n");//������ļ�
            }

            return bRet;
        }


        //�����ϴ�
        public bool ErrorReporting(int ID)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("update equipmentstate set restoring = '��',reporting = '��',ReportTime = now() ,reportor = '{0}' where id = {1};", UserDal.userName, ID);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("ErrorReportingErro:" + sql + "\r\n");//������ļ�
            }

            return bRet;
        }



        //�쳣����
        public bool Maintenance(string AbnormalTime, string TollStationName, string LaneID, string AbnormalState)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("insert into  equipmentstate(AbnormalTime,TollStationName,LaneID,AbnormalState,reportor,reporting,restoring,RestoreTime) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}') ON DUPLICATE KEY UPDATE AbnormalTime ='{0}' ,TollStationName='{1}',LaneID='{2}',AbnormalState='{3}',reportor='{4}',reporting='{5}',restoring='{6}',RestoreTime='{7}'; ", AbnormalTime, TollStationName, LaneID, AbnormalState, UserDal.userName, '��', '��', DateTime.Now);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("MaintenanceErro:" + sql + "\r\n");//������ļ�
            }

            return bRet;
        }


        //�����ϴ�
        public bool ErrorReporting(string AbnormalTime, string TollStationName, string LaneID, string AbnormalState)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("insert into  equipmentstate(AbnormalTime,TollStationName,LaneID,AbnormalState,reportor,reporting,ReportTime,restoring) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')ON DUPLICATE KEY UPDATE AbnormalTime ='{0}' ,TollStationName='{1}',LaneID='{2}',AbnormalState='{3}',reportor='{4}',reporting='{5}',ReportTime='{6}',restoring='{7}' ; ", AbnormalTime, TollStationName, LaneID, AbnormalState, UserDal.userName, '��', DateTime.Now, '��');
            {
                bRet = false;
                DebugOutput.ProcessMessage("ErrorReportingErro:" + sql + "\r\n");//������ļ�
            }

            return bRet;
        }



        //�쳣������
        public bool NoMaintenance(string AbnormalTime, string TollStationName, string LaneID, string AbnormalState)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("insert into  equipmentstate(AbnormalTime,TollStationName,LaneID,AbnormalState,reporting,restoring) values ('{0}','{1}','{2}','{3}','{4}','{5}')ON DUPLICATE KEY UPDATE AbnormalTime ='{0}' ,TollStationName='{1}',LaneID='{2}',AbnormalState='{3}',reporting='{4}',restoring='{5}' ; ", AbnormalTime, TollStationName, LaneID, AbnormalState, '��', '��');
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("MaintenanceErro:" + sql + "\r\n");//������ļ�
            }

            return bRet;
        }


        //�����ϴ�
        public bool ErrorNoReporting(string AbnormalTime, string TollStationName, string LaneID, string AbnormalState)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("insert into  equipmentstate(AbnormalTime,TollStationName,LaneID,AbnormalState,reporting,restoring) values ('{0}','{1}','{2}','{3}','{4}','{5}') ON DUPLICATE KEY UPDATE AbnormalTime ='{0}' ,TollStationName='{1}',LaneID='{2}',AbnormalState='{3}',reporting='{4}',restoring='{5}' ; ", AbnormalTime, TollStationName, LaneID, AbnormalState, '��', '��');
            {
                bRet = false;
                DebugOutput.ProcessMessage("ErrorReportingErro:" + sql + "\r\n");//������ļ�
            }

            return bRet;
        }
    }
}
