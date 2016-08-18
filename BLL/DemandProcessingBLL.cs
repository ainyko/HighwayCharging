using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;//DATASET
using Utility;

namespace BLL
{
    public class DemandProcessingBLL
    {

        //public string CarNum = "";//����
        //public string CarType = "";//����

        //��һ����
        public string FirstCarNum;//����
        public string FirstCarType;//����
        public string FirstCarArrTime;//����
        public bool FirstCarCome = false;

        //����������
        public bool DemandProcessing(out string CarNum, out  string CarType, out string entranceStation, out  string sendCardTime, string exitStation, string exitLanID)
        {
            bool bRet = true;
            DateTime Now = DateTime.Now;
            DataTable DemandDt = GetDemandExitDtInfo(Now, exitStation, exitLanID);
            CarNum = "";//����
            CarType = "";//����
            entranceStation = "";//����շ�վ
            sendCardTime = "";//����ʱ��

            if (DemandDt != null && DemandDt.Rows.Count > 0)
            {
              
                CarNum = DemandDt.Rows[0][1].ToString();
                CarType = DemandDt.Rows[0][2].ToString();
                entranceStation = DemandDt.Rows[0][4].ToString();
                sendCardTime = DemandDt.Rows[0][6].ToString();
            }
            else
            {
                return bRet = false;
            }

            return bRet;
        }

        //����������
        public bool DemandProcessing(out bool firstCarCome, out string CarNum, out  string CarType)
        {
            bool bRet = true;
            DateTime Now = DateTime.Now;
            DataTable DemandDt = GetDemandEnDtInfo(Now);
            firstCarCome = FirstCarCome;
            CarNum = "";//����
            CarType = "";//����

            if (DemandDt != null && DemandDt.Rows.Count > 0)
            {
                if (!FirstCarCome)
                {
                    FirstCarCome = true;

                    FirstCarNum = DemandDt.Rows[0][1].ToString();
                    FirstCarType = DemandDt.Rows[0][2].ToString();
                    FirstCarArrTime = DateTime.Now.ToString();
                }
                CarNum = DemandDt.Rows[0][1].ToString();
                CarType = DemandDt.Rows[0][2].ToString();
            }
            else
            {
                return bRet = false;
            }

            return bRet;
        }
        //��ѯ��������ڵ�������Ϣ
        public DataTable GetDemandEnDtInfo(DateTime arriveTime)
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT * FROM `trafficdemand` where ExpectArrEnTime = '{0}' and CompleteState = 'δ����' and EntranceStation = '{1}'and EntranceLane = '{2}'order by id ASC  ;", arriveTime,GlobalVarBLL.TollstationName_all,GlobalVarBLL.LaneID_all);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }

        //��ѯ�������������Ϣ
        public DataTable GetDemandExitDtInfo(DateTime arrExitTime, string exitStation, string exitLanID)
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT * FROM `trafficdemand` where ExitStation = '{0}'  and ExitLane = '{1}' and ExpectArrExitTime = '{2}' and CompleteState = '�ѷ���' order by id ASC  ;", exitStation, exitLanID, arrExitTime);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }

        //�����������������Ϣ
        public bool UpdateDemandInfo(string CarNum)//���·���ʱ��
        {
            bool bRet = true;
            DemandGenerationDal demandGenerationDal = new DemandGenerationDal();
            if (!demandGenerationDal.UpdateDemand(CarNum))
            {
                DebugOutput.ProcessMessage("UpdateDemandInfoErro!" + "\r\n");//������ļ�
            }
            return bRet;
        }


        //�����������������Ϣ
        public bool UpdateDemandStateInfo(string state, string carNum, DateTime expectArrExitTime, DateTime sendCardTime)//����״̬
        {
            bool bRet = true;
            DemandGenerationDal demandGenerationDal = new DemandGenerationDal();
            if (!demandGenerationDal.UpdateDemandState(state, carNum, expectArrExitTime, sendCardTime))
            {
                DebugOutput.ProcessMessage("UpdateDemandStateInfoErro!" + "\r\n");//������ļ�
            }
            return bRet;
        }
        //�����������������Ϣ
        public bool UpdateDemandStateInfo(string state, string carNum, DateTime expectArrExitTime)//����״̬
        {
            bool bRet = true;
            DemandGenerationDal demandGenerationDal = new DemandGenerationDal();
            if (!demandGenerationDal.UpdateDemandState(state, carNum, expectArrExitTime))
            {
                DebugOutput.ProcessMessage("UpdateDemandStateInfoErro!" + "\r\n");//������ļ�
            }
            return bRet;
        }

        //�����������������Ϣ
        public bool DeleteDemandInfo()//����״̬
        {
            bool bRet = true;
            DemandGenerationDal demandGenerationDal = new DemandGenerationDal();
            if (!demandGenerationDal.DeleteDemand())
            {
                DebugOutput.ProcessMessage("DeleteDemandInfoErro!" + "\r\n");//������ļ�
            }
            return bRet;
        }

        //�ı����״̬
        public bool Modify_CompleteState(string completeState_new, string completeState_old, string sendcardTime)
        {
            bool bRet = true;
            string sql = String.Format("update trafficdemand set CompleteState='{0}' where CompleteState = '{1}' and SendCardTime='{2}' order by id asc ;", completeState_new, completeState_old, sendcardTime);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("DBError: " + sql + "\r\n");//������ļ�
            }
            return bRet;
        }

        //���ݷ���ʱ���ѯIC����
        public DataTable Get_ICcard(string sendcardTime)
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT ICCard FROM cardrecord where SendCardTime = '{0}' order by id ASC;", sendcardTime);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }

        //���ݳ�����շ�վ�����Ͳ�ѯ����
        public DataTable Get_Rate(string StartStation1Name, string StartStation2Name, string CarType)
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT Rate FROM tollrate where StartStation1Name = '{0}'  and StartStation2Name = '{1}' and CarType = '{2}' order by id ASC  ;", StartStation1Name, StartStation2Name, CarType);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }
    }
}
