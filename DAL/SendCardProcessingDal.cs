using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace DAL
{
    public struct CardRecord
    {
        public string CarNum;//车牌
        public DateTime ArrivalTime;//到达入口时间
        public string TollStationName;//入口站
        public string LaneID;//入口车道
        public DateTime SendCardTime;//发卡时间
        public string ICCard;//IC卡号
        public string CarType;//车型

    }

    public class SendCardProcessingDal
    {

        //发卡记录插入数据库
        public bool InsertCardRecord(CardRecord cardRecord)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("INSERT INTO `highwaycharging`.`cardrecord` ( `CarNum`, `ArrivalTime`, `TollStationName`, `LaneID`, `SendCardTime`, `ICCard`, `CarType`) VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');", cardRecord.CarNum, cardRecord.ArrivalTime, cardRecord.TollStationName, cardRecord.LaneID, cardRecord.SendCardTime, cardRecord.ICCard, cardRecord.CarType);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("InsertCardRecordErro:" + sql + "\r\n");//输出到文件
            }

            return bRet;
        }

    }
}
