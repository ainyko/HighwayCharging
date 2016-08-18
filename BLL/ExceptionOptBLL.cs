using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Utility;

namespace BLL
{
    //异常处理
    public class ExceptionOptBLL
    {
        private ExceptionOptDal exceptionOptDal = new ExceptionOptDal();
        //简易维护
        public bool  Maintenance(int ID)
        {
            bool bRet = false;

            bRet = exceptionOptDal.Maintenance(ID);

            return bRet;
 
        }

        //错误上传
        public bool ErrorReporting(int ID)
        {
            bool bRet = false;

            bRet = exceptionOptDal.ErrorReporting(ID);

            return bRet;
        }



        //简易维护
        public bool Maintenance(string AbnormalTime, string TollStationName, string LaneID, string AbnormalState)
        {
            bool bRet = false;

            bRet = exceptionOptDal.Maintenance(AbnormalTime, TollStationName, LaneID, AbnormalState);

            return bRet;

        }

        //错误上传
        public bool ErrorReporting(string AbnormalTime, string TollStationName, string LaneID, string AbnormalState)
        {
            bool bRet = false;

            bRet = exceptionOptDal.ErrorReporting(AbnormalTime, TollStationName, LaneID, AbnormalState);

            return bRet;
        }


        //不维护
        public bool NoMaintenance(string AbnormalTime, string TollStationName, string LaneID, string AbnormalState)
        {
            bool bRet = false;

            bRet = exceptionOptDal.NoMaintenance(AbnormalTime, TollStationName, LaneID, AbnormalState);

            return bRet;

        }

        //错误不上传
        public bool ErrorNoReporting(string AbnormalTime, string TollStationName, string LaneID, string AbnormalState)
        {
            bool bRet = false;

            bRet = exceptionOptDal.ErrorNoReporting(AbnormalTime, TollStationName, LaneID, AbnormalState);

            return bRet;
        }
       
    }
}
