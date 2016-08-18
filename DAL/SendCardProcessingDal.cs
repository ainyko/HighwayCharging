using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace DAL
{
    public struct CardRecord
    {
        public string CarNum;//����
        public DateTime ArrivalTime;//�������ʱ��
        public string TollStationName;//���վ
        public string LaneID;//��ڳ���
        public DateTime SendCardTime;//����ʱ��
        public string ICCard;//IC����
        public string CarType;//����

    }

    public class SendCardProcessingDal
    {

        //������¼�������ݿ�
        public bool InsertCardRecord(CardRecord cardRecord)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("INSERT INTO `highwaycharging`.`cardrecord` ( `CarNum`, `ArrivalTime`, `TollStationName`, `LaneID`, `SendCardTime`, `ICCard`, `CarType`) VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');", cardRecord.CarNum, cardRecord.ArrivalTime, cardRecord.TollStationName, cardRecord.LaneID, cardRecord.SendCardTime, cardRecord.ICCard, cardRecord.CarType);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("InsertCardRecordErro:" + sql + "\r\n");//������ļ�
            }

            return bRet;
        }

    }
}
