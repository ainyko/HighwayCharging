using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Utility;

namespace BLL
{
    //�쳣����
    public class ExceptionOptBLL
    {
        private ExceptionOptDal exceptionOptDal = new ExceptionOptDal();
        //����ά��
        public bool  Maintenance(int ID)
        {
            bool bRet = false;

            bRet = exceptionOptDal.Maintenance(ID);

            return bRet;
 
        }

        //�����ϴ�
        public bool ErrorReporting(int ID)
        {
            bool bRet = false;

            bRet = exceptionOptDal.ErrorReporting(ID);

            return bRet;
        }



        //����ά��
        public bool Maintenance(string AbnormalTime, string TollStationName, string LaneID, string AbnormalState)
        {
            bool bRet = false;

            bRet = exceptionOptDal.Maintenance(AbnormalTime, TollStationName, LaneID, AbnormalState);

            return bRet;

        }

        //�����ϴ�
        public bool ErrorReporting(string AbnormalTime, string TollStationName, string LaneID, string AbnormalState)
        {
            bool bRet = false;

            bRet = exceptionOptDal.ErrorReporting(AbnormalTime, TollStationName, LaneID, AbnormalState);

            return bRet;
        }


        //��ά��
        public bool NoMaintenance(string AbnormalTime, string TollStationName, string LaneID, string AbnormalState)
        {
            bool bRet = false;

            bRet = exceptionOptDal.NoMaintenance(AbnormalTime, TollStationName, LaneID, AbnormalState);

            return bRet;

        }

        //�����ϴ�
        public bool ErrorNoReporting(string AbnormalTime, string TollStationName, string LaneID, string AbnormalState)
        {
            bool bRet = false;

            bRet = exceptionOptDal.ErrorNoReporting(AbnormalTime, TollStationName, LaneID, AbnormalState);

            return bRet;
        }
       
    }
}
