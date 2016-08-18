using System;
using System.Collections.Generic;
using System.Text;
using Utility;
using DAL;
using System.Data;//DATASET

namespace BLL
{
    public class DemandGenerationBLL
    {
        //1-20分钟内到达入口  
        private static int ecllipstimeMS_max = 20;
        private static int ecllipstimeMS_min = 1;
        private static string[] Province = new string[34] { "京", "津", "沪", "渝", "冀", "豫", "云", "辽", "黑", "湘", "皖", "鲁", "新", "苏", "浙", "赣", "鄂", "桂", "甘", "晋", "蒙", "陕", "吉", "闽", "贵", "粤", "青", "藏", "川", "宁", "琼", "台", "港", "澳" };
        private static string[] City = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };



        DemandGenerationDal demandGenerationDal = new DemandGenerationDal();

        /// <summary>
        /// 产生随机需求
        /// </summary>
        /// <returns></returns>
        public bool SetSimulationPara(out string exitStation)
        {
            bool bRet = true;
            int iCarType, iProvince, iCity, iCarNum,iExit;
            int ecliptime;
            Random RandomFactor = new Random();
            Demand damand = new Demand();
            DateTime ExpectArrEnTime = DateTime.Now;
            exitStation = "";

            try
            {

                //时间间隔
                ecliptime = RandomFactor.Next((int)ecllipstimeMS_min, (int)ecllipstimeMS_max);
                //预计到达入口时间
                //damand.ExpectArrEnTime = ExpectArrEnTime.AddMinutes(ecliptime); 
                damand.ExpectArrEnTime = ExpectArrEnTime.AddSeconds(5); //测试用
                //发卡时间
                damand.SendCardTime = damand.ExpectArrEnTime;//发卡时间等于预计到达时间



                //入口车道
                damand.EntranceLane = GlobalVarBLL.LaneID_all;

                //入口站
                damand.EntranceStation = GlobalVarBLL.TollstationName_all;

               
                DataTable ExitDt = GetExitDtInfo();//出口表
                if (ExitDt != null && ExitDt.Rows.Count > 0)
                {
                    iExit = RandomFactor.Next(0, ExitDt.Rows.Count);
                    //出口站
                    damand.ExitStation = ExitDt.Rows[iExit][0].ToString();
                    //出口车道
                    damand.ExitLane = ExitDt.Rows[iExit][1].ToString();
                }
                else
                {
                    DebugOutput.ProcessMessage("该入口，没有开通对应的出口！\r\n");
                    return bRet = false;
                }


                DataTable KmDt = GetKilometersDtInfo(damand.ExitStation);//里程表
                if (KmDt != null && KmDt.Rows.Count > 0)
                {
                   
                    //时间间隔
                    ecliptime = Convert.ToInt32(Convert.ToInt32(KmDt.Rows[0][0].ToString())/100.00*3600);
                    //预计到达出口时间
                    damand.ExpectArrExitTime = damand.SendCardTime.AddSeconds(ecliptime);//发卡时间+里程/(100km/h)
                }
                else
                {
                    DebugOutput.ProcessMessage("入口:" + damand.EntranceStation + " 到出口:" + damand.ExitStation + " 之间没有里程！\r\n");
                    exitStation = damand.ExitStation;
                    return bRet = false;
                }
           
             


                iProvince = RandomFactor.Next(0, 34);
                iCity = RandomFactor.Next(0, 26);
                iCarNum = RandomFactor.Next(10000, 99999);

                //车牌
                damand.CarNum = Province[iProvince] + City[iCity] + " " + iCarNum.ToString();

                iCarType = RandomFactor.Next(1, 8);
                switch (iCarType)
                {
                    //车型
                    case 1:
                        damand.CarType = "小客货Ⅰ型";
                        break;
                    case 2:
                        damand.CarType = "小客货Ⅱ型";
                        break;
                    case 3:
                        damand.CarType = "中客货Ⅲ型";
                        break;
                    case 4:
                        damand.CarType = "大客货Ⅳ型";
                        break;
                    case 5:
                        damand.CarType = "特客货Ⅴ型";
                        break;
                    case 6:
                        damand.CarType = "特货Ⅵ型";
                        break;
                    case 7:
                        damand.CarType = "超货Ⅶ型";
                        break;
                    default:
                        break;
                }

                //完成状态
                damand.CompleteState = "未发卡";

                demandGenerationDal.InsertDemand(damand);//需求插入数据库
            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage("InitSimulationPara:" + ex.ToString() + "\r\n");
                bRet = false;
            }

            return bRet;

        }

        //查询进口需求数据
        public DataTable GetDemandDtInfo()
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT * FROM `trafficdemand` where CompleteState = '待发卡' and EntranceStation = '{0}' and   EntranceLane = '{1}' and  ExpectArrEnTime >= '{2}' order by ExpectArrEnTime asc ;", GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all, GlobalVarBLL.LoginTime);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }

        //查询出口需求数据
        public DataTable GetDemandDtInfo_charge()
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT * FROM `trafficdemand` where CompleteState = '待收费' and ExitStation = '{0}' and   ExitLane = '{1}' and ExpectArrExitTime >= '{2}' order by ExpectArrExitTime asc ;", GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all, GlobalVarBLL.LoginTime);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }

        //查询预计出口时间数据
        public DataTable GetTollDtInfo(string tollState)
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT * FROM `trafficdemand` where CompleteState = '{0}'and ExitStation = '{1}' and   ExitLane = '{2}' and ExpectArrExitTime >= '{3}' order by ExpectArrExitTime asc ;", tollState, GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all, GlobalVarBLL.LoginTime);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }

        //查询出口数据
        public DataTable GetExitDtInfo()
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT TollstationName,LaneID FROM `lane` where InOutward = '出口' and TollstationName != '{0}' and OpenState = '开通' order by id desc  ;", GlobalVarBLL.TollstationName_all);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }


        //查询里程数据
        public DataTable GetKilometersDtInfo(string exitStation)
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT Kilometers FROM `tollrate` where StartStation1Name = '{0}' and StartStation2Name = '{1}'  order by id desc  ;", GlobalVarBLL.TollstationName_all, exitStation);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }
    }
}
