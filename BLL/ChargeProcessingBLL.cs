using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;
using Utility;

namespace BLL
{
    public class ChargeProcessingBLL
    {
        //插入收费记录表
        public bool Charging(int SendCardNum, string CarNum, DateTime ArriveEnTime, string EntranceStation, string EntranceLane, DateTime SendCardTime, string ICcard, string EntranceCarType, string ExitCarType, DateTime ArriveExitTime, string ExitStation, string ExitLane, int Cost, string ChargeState, string User, bool IsCheck)
    {
            bool bRet = true;

            ChargeRecord chargeRecord = new ChargeRecord();
            chargeRecord.SendCardNum=SendCardNum;
            chargeRecord.CarNum = CarNum;
            chargeRecord.ArriveEnTime=ArriveEnTime;
            chargeRecord.EntranceStation=EntranceStation;
            chargeRecord.EntranceLane = EntranceLane;
            chargeRecord.SendCardTime=SendCardTime;
            chargeRecord.ICcard=ICcard;
            chargeRecord.EntranceCarType=EntranceCarType;
            chargeRecord.ExitCarType=ExitCarType;
            chargeRecord.ArriveExitTime=ArriveExitTime;
            chargeRecord.ExitStation=ExitStation;
            chargeRecord.ExitLane=ExitLane;
            chargeRecord.Cost=Cost;
            chargeRecord.ChargeState = ChargeState;
            chargeRecord.User=User;
            chargeRecord.IsCheck=IsCheck;

            ChargeProcessingRecordDal chargeProcessingRecordDal = new ChargeProcessingRecordDal();
            chargeProcessingRecordDal.InsertChargeRecord(chargeRecord);
            
            return bRet;
        }
        //根据发卡时间查询对应发卡记录编号
        public DataTable Get_SendCardID(DateTime sendcardtime)
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT ID FROM cardrecord where SendCardTime = '{0}' order by id ASC;", sendcardtime);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }

        //查询收费记录
        public DataTable Query_ChargeRecord()
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT * FROM chargerecord where ExitTollStation='{0}' and ExitLane='{1}' order by id DESC", GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all );
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }

        //未对账记录查询
        public DataTable Query_UnCheck()
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT * FROM chargerecord where IsCheck='false' and ExitTollStation='{0}' and ExitLane='{1}' order by id DESC", GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }

        //插入对账记录
        public bool InsertCheckRecord(string cashier, DateTime checktime, int totalamount, int chargecount, bool ispay)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("INSERT INTO `checkinfo` ( `Cashier`, `CheckTime`, `CheckAmount`,  `ChargeNum`, `IsPay`) VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}');", cashier, checktime, totalamount, chargecount, ispay);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("InsertCardRecordErro:" + sql + "\r\n");//输出到文件
            }

            return bRet;
        }

        //把收费记录表中的“是否对账”改为true
        public bool Change_IsCheck(string id)
        {
            bool bRet = true;
            string sql = String.Format("update chargerecord set IsCheck='true' WHERE ID='{0}'", id );
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("DBError: " + sql + "\r\n");//输出到文件
            }
            return bRet;
        }

        //对账记录查询
        public DataTable Query_Checkinfo()
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT * FROM checkinfo order by id DESC");
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }
    }
}
