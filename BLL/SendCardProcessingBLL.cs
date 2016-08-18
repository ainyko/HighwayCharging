using System;
using System.Collections.Generic;
using System.Text;
using DAL;

namespace BLL
{
    public class SendCardProcessingBLL
    {
        public bool SendCard(string carNum,DateTime arriveTime,string ICcard,string carType,out DateTime sendCardTime )
        {
            bool bRet = true;
            CardRecord cardRecord = new CardRecord();
            sendCardTime = DateTime.MinValue;

            cardRecord.ArrivalTime = arriveTime;
            cardRecord.CarNum = carNum;
            cardRecord.CarType = carType;
            cardRecord.ICCard = ICcard;
            cardRecord.LaneID = GlobalVarBLL.LaneID_all;
            cardRecord.SendCardTime = DateTime.Now;
            sendCardTime = cardRecord.SendCardTime;
            cardRecord.TollStationName = GlobalVarBLL.TollstationName_all;
            SendCardProcessingDal sendCardProcessingDal = new SendCardProcessingDal();
            sendCardProcessingDal.InsertCardRecord(cardRecord);

            return bRet;
        }
    }
}
