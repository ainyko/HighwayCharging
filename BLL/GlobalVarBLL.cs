using System;
using System.Collections.Generic;
using System.Text;
using Utility;
using System.Configuration;
using System.Collections.Specialized;//ʹ��APP.CONFIG

namespace BLL
{

    public static class GlobalVarBLL
    {
        public static string path = AppDomain.CurrentDomain.BaseDirectory;//��װĿ¼·��

        //����ʱ����
        public static int DemandIntervalTime = 500;
        //��������ʱ����
        public static int QueryIntervalTime = 500;
        //�쳣ʱ����
        public static int AbnormalIntervalTime = 500;

        public static DateTime LoginTime = DateTime.MinValue; //��¼ʱ���ʼ��
        public static bool LoginFlag = false; //��¼״̬��ʼ��
        //public static string LoginUser = string.Empty; //��¼�û���ʼ��


        public static string TollstationName_all = string.Empty;
        public static string Inoutward_all = string.Empty;
        public static string LaneID_all = string.Empty;
        /// <summary>
        /// ��ʼ��
        /// </summary>
        /// <returns></returns>
        public static bool InitGlobalVar()
        {
            bool bRet = true;
            try
            {
                NameValueCollection NvMngConfig = new NameValueCollection();

                //=======    2.1 ��������������  ==========
                string szSegName = "TimeInterval/Interval";
                //ˢ�����ý�
                ConfigurationManager.RefreshSection(szSegName);
                //����������Ŀ
                NvMngConfig = (NameValueCollection)ConfigurationManager.GetSection(szSegName);
                // �����ϸ������
                if (NvMngConfig != null)
                {
                    //����ʱ����
                    DemandIntervalTime = Convert.ToInt32(NvMngConfig["DemandInterval"]);
                    //��������ʱ����
                    QueryIntervalTime = Convert.ToInt32(NvMngConfig["QueryInterval"]);
                    //�쳣ʱ����
                    AbnormalIntervalTime = Convert.ToInt32(NvMngConfig["AbnormalInterval"]);

                }

            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex);
            }
            return bRet;
        }

    }


}
