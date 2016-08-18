using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace DAL
{
    public struct ChargeRecord
    {
        public int SendCardNum;//对应发卡记录编号
        public string CarNum;//车牌
        public DateTime ArriveEnTime;//入站时间
        public string EntranceStation;//入口收费站
        public string EntranceLane;//入口车道
        public DateTime SendCardTime;//发卡时间
        public string ICcard;//IC卡卡号
        public string EntranceCarType;//入口车型
        public string ExitCarType;//出口车型
        public DateTime ArriveExitTime;//出站到达时间
        public string ExitStation;//出口收费站
        public string ExitLane;//出口车道
        public int Cost;//费用
        public string ChargeState;//收费状态（正常、免费、逃费）
        public string User;//操作员
        public bool IsCheck;//是否对账
    }

    public class ChargeProcessingRecordDal
    {
        //发卡记录插入数据库
        public bool InsertChargeRecord(ChargeRecord chargeRecord)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("INSERT INTO `chargerecord` ( `CardRecordID`, `CarNum`, `EntranceStationTime`,  `EntranceTollStation`, `EntranceLane`, `CardTime`,`ICCardID`,`EntranceCarType`, `ExitCarType`,`ExitStationTime`, `ExitTollStation`, `ExitLane`,`Cost`,`ChargeState`, `Operator`, `IsCheck`) VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}','{7}', '{8}', '{9}', '{10}', '{11}', '{12}','{13}', '{14}','{15}');", chargeRecord.SendCardNum, chargeRecord.CarNum, chargeRecord.ArriveEnTime, chargeRecord.EntranceStation, chargeRecord.EntranceLane, chargeRecord.SendCardTime, chargeRecord.ICcard, chargeRecord.EntranceCarType, chargeRecord.ExitCarType, chargeRecord.ArriveExitTime, chargeRecord.ExitStation, chargeRecord.ExitLane, chargeRecord.Cost, chargeRecord.ChargeState, chargeRecord.User, chargeRecord.IsCheck);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("InsertCardRecordErro:" + sql + "\r\n");//输出到文件
            }

            return bRet;
        }
    }
}
