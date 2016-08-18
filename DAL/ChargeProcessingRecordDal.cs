using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace DAL
{
    public struct ChargeRecord
    {
        public int SendCardNum;//��Ӧ������¼���
        public string CarNum;//����
        public DateTime ArriveEnTime;//��վʱ��
        public string EntranceStation;//����շ�վ
        public string EntranceLane;//��ڳ���
        public DateTime SendCardTime;//����ʱ��
        public string ICcard;//IC������
        public string EntranceCarType;//��ڳ���
        public string ExitCarType;//���ڳ���
        public DateTime ArriveExitTime;//��վ����ʱ��
        public string ExitStation;//�����շ�վ
        public string ExitLane;//���ڳ���
        public int Cost;//����
        public string ChargeState;//�շ�״̬����������ѡ��ӷѣ�
        public string User;//����Ա
        public bool IsCheck;//�Ƿ����
    }

    public class ChargeProcessingRecordDal
    {
        //������¼�������ݿ�
        public bool InsertChargeRecord(ChargeRecord chargeRecord)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("INSERT INTO `chargerecord` ( `CardRecordID`, `CarNum`, `EntranceStationTime`,  `EntranceTollStation`, `EntranceLane`, `CardTime`,`ICCardID`,`EntranceCarType`, `ExitCarType`,`ExitStationTime`, `ExitTollStation`, `ExitLane`,`Cost`,`ChargeState`, `Operator`, `IsCheck`) VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}','{7}', '{8}', '{9}', '{10}', '{11}', '{12}','{13}', '{14}','{15}');", chargeRecord.SendCardNum, chargeRecord.CarNum, chargeRecord.ArriveEnTime, chargeRecord.EntranceStation, chargeRecord.EntranceLane, chargeRecord.SendCardTime, chargeRecord.ICcard, chargeRecord.EntranceCarType, chargeRecord.ExitCarType, chargeRecord.ArriveExitTime, chargeRecord.ExitStation, chargeRecord.ExitLane, chargeRecord.Cost, chargeRecord.ChargeState, chargeRecord.User, chargeRecord.IsCheck);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("InsertCardRecordErro:" + sql + "\r\n");//������ļ�
            }

            return bRet;
        }
    }
}
