using System;
using System.Collections.Generic;
using System.Text;
using Utility;
using System.Configuration;
using System.Collections.Specialized;//使用APP.CONFIG

namespace BLL
{

    public static class GlobalVarBLL
    {
        public static string path = AppDomain.CurrentDomain.BaseDirectory;//安装目录路径

        //需求时间间隔
        public static int DemandIntervalTime = 500;
        //车辆到达时间间隔
        public static int QueryIntervalTime = 500;
        //异常时间间隔
        public static int AbnormalIntervalTime = 500;

        public static DateTime LoginTime = DateTime.MinValue; //登录时间初始化
        public static bool LoginFlag = false; //登录状态初始化
        //public static string LoginUser = string.Empty; //登录用户初始化


        public static string TollstationName_all = string.Empty;
        public static string Inoutward_all = string.Empty;
        public static string LaneID_all = string.Empty;
        /// <summary>
        /// 初始化
        /// </summary>
        /// <returns></returns>
        public static bool InitGlobalVar()
        {
            bool bRet = true;
            try
            {
                NameValueCollection NvMngConfig = new NameValueCollection();

                //=======    2.1 本地网络服务相关  ==========
                string szSegName = "TimeInterval/Interval";
                //刷新配置节
                ConfigurationManager.RefreshSection(szSegName);
                //加载配置项目
                NvMngConfig = (NameValueCollection)ConfigurationManager.GetSection(szSegName);
                // 获得详细配置项
                if (NvMngConfig != null)
                {
                    //需求时间间隔
                    DemandIntervalTime = Convert.ToInt32(NvMngConfig["DemandInterval"]);
                    //车辆到达时间间隔
                    QueryIntervalTime = Convert.ToInt32(NvMngConfig["QueryInterval"]);
                    //异常时间间隔
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
