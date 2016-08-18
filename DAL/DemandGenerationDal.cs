using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace DAL
{

    public struct Demand
    {
        public string CarNum;//����
        public DateTime ExpectArrEnTime;//Ԥ�Ƶ������ʱ��
        public DateTime ExpectArrExitTime;//Ԥ�Ƶ������ʱ��
        public string EntranceStation;//���վ
        public string ExitStation;//����վ
        public string ExitLane;//���ڳ���
        public string EntranceLane;//��ڳ���
        public DateTime SendCardTime;//����ʱ��
        public string CompleteState;//���״̬
        public string CarType;//����

    }

    public class DemandGenerationDal
    {
        //����������ݿ�
        public bool InsertDemand(Demand demand)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("INSERT INTO `highwaycharging`.`trafficdemand` ( `CarNum`, `CarType`, `ExpectArrEnTime`, `EntranceStation`, `EntranceLane`, `SendCardTime`, `ExitStation`, `ExitLane`, `ExpectArrExitTime`, `CompleteState`) VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');", demand.CarNum, demand.CarType, demand.ExpectArrEnTime, demand.EntranceStation, demand.EntranceLane, demand.SendCardTime, demand.ExitStation, demand.ExitLane, demand.ExpectArrExitTime, demand.CompleteState);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("InsertDemandErro:" + sql + "\r\n");//������ļ�
            }

            return bRet;
        }

        //����������ݿ�
        public bool UpdateDemand(string CarNum)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("update trafficdemand set SendCardTime = now()  where CarNum = {0};", CarNum);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("updateDemandErro:" + sql + "\r\n");//������ļ�
            }

            return bRet;
        }

        //����������ݿ�����״̬
        public bool UpdateDemandState(string state, string carNum, DateTime expectArrExitTime, DateTime sendCardTime)
        {
            bool bRet = true;
            string sql = "";
            if (state == "�ѷ���")
                sql = string.Format("update trafficdemand set CompleteState = '{0}', SendCardTime = '{3}' ,ExpectArrExitTime = '{1}' where CarNum = '{2}';", state, expectArrExitTime, carNum, sendCardTime);
            else if (state == "������")
                sql = string.Format("update trafficdemand set CompleteState = '{0}'  where CarNum = '{1}';", state, carNum);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("updateDemandErro:" + sql + "\r\n");//������ļ�
            }

            return bRet;
        }


        //����������ݿ�����״̬
        public bool UpdateDemandState(string state, string carNum, DateTime expectArrExitTime)
        {
            bool bRet = true;
            string sql = "";
            if (state == "�ѷ���")
                sql = string.Format("update trafficdemand set CompleteState = '{0}', SendCardTime = now() ,ExpectArrExitTime = '{1}' where CarNum = '{2}';", state, expectArrExitTime, carNum);
            else if (state == "������")
                sql = string.Format("update trafficdemand set CompleteState = '{0}'  where CarNum = '{1}';", state, carNum);
            else if (state == "���շ�")
                sql = string.Format("update trafficdemand set CompleteState = '{0}' where ExpectArrExitTime = '{1}' and CarNum = '{2}';", "1", expectArrExitTime, carNum);        
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("updateDemandErro:" + sql + "\r\n");//������ļ�
            }

            return bRet;
        }


        //ɾ���������ݿ�
        public bool DeleteDemand()
        {
            bool bRet = true;
            string sql = "";

            sql = "delete from trafficdemand ;";
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("deleteDemandErro:" + sql + "\r\n");//������ļ�
            }

            return bRet;
        }

    }
}
