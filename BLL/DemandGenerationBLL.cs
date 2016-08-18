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
        //1-20�����ڵ������  
        private static int ecllipstimeMS_max = 20;
        private static int ecllipstimeMS_min = 1;
        private static string[] Province = new string[34] { "��", "��", "��", "��", "��", "ԥ", "��", "��", "��", "��", "��", "³", "��", "��", "��", "��", "��", "��", "��", "��", "��", "��", "��", "��", "��", "��", "��", "��", "��", "��", "��", "̨", "��", "��" };
        private static string[] City = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };



        DemandGenerationDal demandGenerationDal = new DemandGenerationDal();

        /// <summary>
        /// �����������
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

                //ʱ����
                ecliptime = RandomFactor.Next((int)ecllipstimeMS_min, (int)ecllipstimeMS_max);
                //Ԥ�Ƶ������ʱ��
                //damand.ExpectArrEnTime = ExpectArrEnTime.AddMinutes(ecliptime); 
                damand.ExpectArrEnTime = ExpectArrEnTime.AddSeconds(5); //������
                //����ʱ��
                damand.SendCardTime = damand.ExpectArrEnTime;//����ʱ�����Ԥ�Ƶ���ʱ��



                //��ڳ���
                damand.EntranceLane = GlobalVarBLL.LaneID_all;

                //���վ
                damand.EntranceStation = GlobalVarBLL.TollstationName_all;

               
                DataTable ExitDt = GetExitDtInfo();//���ڱ�
                if (ExitDt != null && ExitDt.Rows.Count > 0)
                {
                    iExit = RandomFactor.Next(0, ExitDt.Rows.Count);
                    //����վ
                    damand.ExitStation = ExitDt.Rows[iExit][0].ToString();
                    //���ڳ���
                    damand.ExitLane = ExitDt.Rows[iExit][1].ToString();
                }
                else
                {
                    DebugOutput.ProcessMessage("����ڣ�û�п�ͨ��Ӧ�ĳ��ڣ�\r\n");
                    return bRet = false;
                }


                DataTable KmDt = GetKilometersDtInfo(damand.ExitStation);//��̱�
                if (KmDt != null && KmDt.Rows.Count > 0)
                {
                   
                    //ʱ����
                    ecliptime = Convert.ToInt32(Convert.ToInt32(KmDt.Rows[0][0].ToString())/100.00*3600);
                    //Ԥ�Ƶ������ʱ��
                    damand.ExpectArrExitTime = damand.SendCardTime.AddSeconds(ecliptime);//����ʱ��+���/(100km/h)
                }
                else
                {
                    DebugOutput.ProcessMessage("���:" + damand.EntranceStation + " ������:" + damand.ExitStation + " ֮��û����̣�\r\n");
                    exitStation = damand.ExitStation;
                    return bRet = false;
                }
           
             


                iProvince = RandomFactor.Next(0, 34);
                iCity = RandomFactor.Next(0, 26);
                iCarNum = RandomFactor.Next(10000, 99999);

                //����
                damand.CarNum = Province[iProvince] + City[iCity] + " " + iCarNum.ToString();

                iCarType = RandomFactor.Next(1, 8);
                switch (iCarType)
                {
                    //����
                    case 1:
                        damand.CarType = "С�ͻ�����";
                        break;
                    case 2:
                        damand.CarType = "С�ͻ�����";
                        break;
                    case 3:
                        damand.CarType = "�пͻ�����";
                        break;
                    case 4:
                        damand.CarType = "��ͻ�����";
                        break;
                    case 5:
                        damand.CarType = "�ؿͻ�����";
                        break;
                    case 6:
                        damand.CarType = "�ػ�����";
                        break;
                    case 7:
                        damand.CarType = "��������";
                        break;
                    default:
                        break;
                }

                //���״̬
                damand.CompleteState = "δ����";

                demandGenerationDal.InsertDemand(damand);//����������ݿ�
            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage("InitSimulationPara:" + ex.ToString() + "\r\n");
                bRet = false;
            }

            return bRet;

        }

        //��ѯ������������
        public DataTable GetDemandDtInfo()
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT * FROM `trafficdemand` where CompleteState = '������' and EntranceStation = '{0}' and   EntranceLane = '{1}' and  ExpectArrEnTime >= '{2}' order by ExpectArrEnTime asc ;", GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all, GlobalVarBLL.LoginTime);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }

        //��ѯ������������
        public DataTable GetDemandDtInfo_charge()
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT * FROM `trafficdemand` where CompleteState = '���շ�' and ExitStation = '{0}' and   ExitLane = '{1}' and ExpectArrExitTime >= '{2}' order by ExpectArrExitTime asc ;", GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all, GlobalVarBLL.LoginTime);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }

        //��ѯԤ�Ƴ���ʱ������
        public DataTable GetTollDtInfo(string tollState)
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT * FROM `trafficdemand` where CompleteState = '{0}'and ExitStation = '{1}' and   ExitLane = '{2}' and ExpectArrExitTime >= '{3}' order by ExpectArrExitTime asc ;", tollState, GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all, GlobalVarBLL.LoginTime);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }

        //��ѯ��������
        public DataTable GetExitDtInfo()
        {
            DataTable dt = null;
            string sqlString = "";
            sqlString = string.Format("SELECT TollstationName,LaneID FROM `lane` where InOutward = '����' and TollstationName != '{0}' and OpenState = '��ͨ' order by id desc  ;", GlobalVarBLL.TollstationName_all);
            dt = MySQLHelper.GetDataTable(sqlString);
            return dt;
        }


        //��ѯ�������
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
