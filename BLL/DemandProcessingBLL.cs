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

        //public string CarNum = "";//车牌
        //public string CarType = "";//车型

        //第一辆车
        public string FirstCarNum;//车牌
        public string FirstCarType;//车型
        public string FirstCarArrTime;//车型
        public bool FirstCarCome = false;

        //出口需求处理
        public bool DemandProcessing(out string CarNum, out  string CarType, out string entranceStation, out  string sendCardTime, string exitStation, string exitLanID)
        {
            bool bRet = true;
            DateTime Now = DateTime.Now;
            DataTable DemandDt = GetDemandExitDtInfo(Now, exitStation, exitLanID);
            CarNum = "";//车牌
            CarType = "";//车型
            entranceStation = "";//入口收费站
            sendCardTime = "";//发卡时间

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

        //进口需求处理
        public bool DemandProcessing(out bool firstCarCome, out string CarNum, out  string CarType)
        {
            bool bRet = true;
            DateTime Now = DateTime.Now;
            DataTable DemandDt = GetDemandEnDtInfo(Now);
            firstCarCome = FirstCarCome;
            CarNum = "";//车牌
            CarType = "";//车型

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
        //查询需求里入口的数据信息
        public DataTable GetDemandEnDtInfo(DateTime arriveTime)
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT * FROM `trafficdemand` where ExpectArrEnTime = '{0}' and CompleteState = '未发卡' and EntranceStation = '{1}'and EntranceLane = '{2}'order by id ASC  ;", arriveTime,GlobalVarBLL.TollstationName_all,GlobalVarBLL.LaneID_all);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }

        //查询需求里的数据信息
        public DataTable GetDemandExitDtInfo(DateTime arrExitTime, string exitStation, string exitLanID)
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT * FROM `trafficdemand` where ExitStation = '{0}'  and ExitLane = '{1}' and ExpectArrExitTime = '{2}' and CompleteState = '已发卡' order by id ASC  ;", exitStation, exitLanID, arrExitTime);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }

        //更新需求里的数据信息
        public bool UpdateDemandInfo(string CarNum)//更新发卡时间
        {
            bool bRet = true;
            DemandGenerationDal demandGenerationDal = new DemandGenerationDal();
            if (!demandGenerationDal.UpdateDemand(CarNum))
            {
                DebugOutput.ProcessMessage("UpdateDemandInfoErro!" + "\r\n");//输出到文件
            }
            return bRet;
        }


        //更新需求里的数据信息
        public bool UpdateDemandStateInfo(string state, string carNum, DateTime expectArrExitTime, DateTime sendCardTime)//更新状态
        {
            bool bRet = true;
            DemandGenerationDal demandGenerationDal = new DemandGenerationDal();
            if (!demandGenerationDal.UpdateDemandState(state, carNum, expectArrExitTime, sendCardTime))
            {
                DebugOutput.ProcessMessage("UpdateDemandStateInfoErro!" + "\r\n");//输出到文件
            }
            return bRet;
        }
        //更新需求里的数据信息
        public bool UpdateDemandStateInfo(string state, string carNum, DateTime expectArrExitTime)//更新状态
        {
            bool bRet = true;
            DemandGenerationDal demandGenerationDal = new DemandGenerationDal();
            if (!demandGenerationDal.UpdateDemandState(state, carNum, expectArrExitTime))
            {
                DebugOutput.ProcessMessage("UpdateDemandStateInfoErro!" + "\r\n");//输出到文件
            }
            return bRet;
        }

        //更新需求里的数据信息
        public bool DeleteDemandInfo()//更新状态
        {
            bool bRet = true;
            DemandGenerationDal demandGenerationDal = new DemandGenerationDal();
            if (!demandGenerationDal.DeleteDemand())
            {
                DebugOutput.ProcessMessage("DeleteDemandInfoErro!" + "\r\n");//输出到文件
            }
            return bRet;
        }

        //改变完成状态
        public bool Modify_CompleteState(string completeState_new, string completeState_old, string sendcardTime)
        {
            bool bRet = true;
            string sql = String.Format("update trafficdemand set CompleteState='{0}' where CompleteState = '{1}' and SendCardTime='{2}' order by id asc ;", completeState_new, completeState_old, sendcardTime);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("DBError: " + sql + "\r\n");//输出到文件
            }
            return bRet;
        }

        //根据发卡时间查询IC卡号
        public DataTable Get_ICcard(string sendcardTime)
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT ICCard FROM cardrecord where SendCardTime = '{0}' order by id ASC;", sendcardTime);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }

        //根据出入口收费站，车型查询费用
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
