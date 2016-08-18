using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace DAL
{

    public struct Demand
    {
        public string CarNum;//车牌
        public DateTime ExpectArrEnTime;//预计到达入口时间
        public DateTime ExpectArrExitTime;//预计到达出口时间
        public string EntranceStation;//入口站
        public string ExitStation;//出口站
        public string ExitLane;//出口车道
        public string EntranceLane;//入口车道
        public DateTime SendCardTime;//发卡时间
        public string CompleteState;//完成状态
        public string CarType;//车型

    }

    public class DemandGenerationDal
    {
        //需求插入数据库
        public bool InsertDemand(Demand demand)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("INSERT INTO `highwaycharging`.`trafficdemand` ( `CarNum`, `CarType`, `ExpectArrEnTime`, `EntranceStation`, `EntranceLane`, `SendCardTime`, `ExitStation`, `ExitLane`, `ExpectArrExitTime`, `CompleteState`) VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');", demand.CarNum, demand.CarType, demand.ExpectArrEnTime, demand.EntranceStation, demand.EntranceLane, demand.SendCardTime, demand.ExitStation, demand.ExitLane, demand.ExpectArrExitTime, demand.CompleteState);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("InsertDemandErro:" + sql + "\r\n");//输出到文件
            }

            return bRet;
        }

        //需求更新数据库
        public bool UpdateDemand(string CarNum)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("update trafficdemand set SendCardTime = now()  where CarNum = {0};", CarNum);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("updateDemandErro:" + sql + "\r\n");//输出到文件
            }

            return bRet;
        }

        //需求更新数据库需求状态
        public bool UpdateDemandState(string state, string carNum, DateTime expectArrExitTime, DateTime sendCardTime)
        {
            bool bRet = true;
            string sql = "";
            if (state == "已发卡")
                sql = string.Format("update trafficdemand set CompleteState = '{0}', SendCardTime = '{3}' ,ExpectArrExitTime = '{1}' where CarNum = '{2}';", state, expectArrExitTime, carNum, sendCardTime);
            else if (state == "待发卡")
                sql = string.Format("update trafficdemand set CompleteState = '{0}'  where CarNum = '{1}';", state, carNum);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("updateDemandErro:" + sql + "\r\n");//输出到文件
            }

            return bRet;
        }


        //需求更新数据库需求状态
        public bool UpdateDemandState(string state, string carNum, DateTime expectArrExitTime)
        {
            bool bRet = true;
            string sql = "";
            if (state == "已发卡")
                sql = string.Format("update trafficdemand set CompleteState = '{0}', SendCardTime = now() ,ExpectArrExitTime = '{1}' where CarNum = '{2}';", state, expectArrExitTime, carNum);
            else if (state == "待发卡")
                sql = string.Format("update trafficdemand set CompleteState = '{0}'  where CarNum = '{1}';", state, carNum);
            else if (state == "待收费")
                sql = string.Format("update trafficdemand set CompleteState = '{0}' where ExpectArrExitTime = '{1}' and CarNum = '{2}';", "1", expectArrExitTime, carNum);        
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("updateDemandErro:" + sql + "\r\n");//输出到文件
            }

            return bRet;
        }


        //删除需求数据库
        public bool DeleteDemand()
        {
            bool bRet = true;
            string sql = "";

            sql = "delete from trafficdemand ;";
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("deleteDemandErro:" + sql + "\r\n");//输出到文件
            }

            return bRet;
        }

    }
}
