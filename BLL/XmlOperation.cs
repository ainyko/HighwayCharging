using System;
using System.Collections.Generic;
using System.Text;
using Utility;
using System.Collections.Specialized;
using System.Xml;//使用APP.CONFIG
using System.Configuration;

namespace BLL
{
    public class XmlOperation
    {
        //保存时间间隔xml配置
        public bool SaveXmlValue(string DemandInterval, string QueryInterval, string AbnormalInterval)
        {
            bool bRet = true;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(GlobalVarBLL.path + "高速公路车道收费软件.exe.config");
                XmlNodeList nodeList = doc.SelectNodes("/configuration/TimeInterval");
                foreach (XmlNode node in nodeList)
                {
                    node.SelectSingleNode("descendant::add[@key='DemandInterval'  ]").Attributes[1].Value = DemandInterval;
                    node.SelectSingleNode("descendant::add[@key='QueryInterval'  ]").Attributes[1].Value = QueryInterval;
                    node.SelectSingleNode("descendant::add[@key='AbnormalInterval'  ]").Attributes[1].Value = AbnormalInterval;

                }

                doc.Save(GlobalVarBLL.path + "高速公路车道收费软件.exe.config");

            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex);
                return bRet = false;
            }
            return bRet;
        }

        //读取设置时间间隔xml配置值
        public bool ReadXmlValue(out string DemandInterval, out string QueryInterval, out string AbnormalInterval)
        {
            bool bRet = true;

            DemandInterval = "500";
            QueryInterval = "500";
            AbnormalInterval = "500";

            try
            {
                NameValueCollection nVConfig = new NameValueCollection();

                ConfigurationManager.RefreshSection("//*");
                #region 时间间隔
                // =============时间间隔=================//
                string szSegName = "TimeInterval/Interval";
                //刷新配置节
                ConfigurationManager.RefreshSection(szSegName);
                //加载配置项目
                nVConfig = (NameValueCollection)ConfigurationManager.GetSection(szSegName);
                if (nVConfig != null)
                {
                    DemandInterval = Convert.ToUInt32(nVConfig["DemandInterval"]).ToString();
                    QueryInterval = Convert.ToUInt32(nVConfig["QueryInterval"]).ToString();
                    AbnormalInterval = Convert.ToUInt32(nVConfig["AbnormalInterval"]).ToString();


                }
                #endregion

            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex);
                return bRet = false;
            }
            return bRet;
        }



        //保存设备状态xml配置
        public bool SaveXmlValue(string EquipmentState)
        {
            bool bRet = true;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(GlobalVarBLL.path + "高速公路车道收费软件.exe.config");
                XmlNodeList nodeList = doc.SelectNodes("/configuration/Equipment");
                foreach (XmlNode node in nodeList)
                {
                    node.SelectSingleNode("descendant::add[@key='State'  ]").Attributes[1].Value = EquipmentState;
    
                }

                doc.Save(GlobalVarBLL.path + "高速公路车道收费软件.exe.config");

            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex);
                return bRet = false;
            }
            return bRet;
        }

        //读取设置设备状态xml配置值
        public bool ReadXmlValue(out string EquipmentState)
        {
            bool bRet = true;

            EquipmentState = "正常";


            try
            {
                NameValueCollection nVConfig = new NameValueCollection();

                ConfigurationManager.RefreshSection("//*");
                #region 设备状态
                // =============设备状态=================//
                string szSegName = "Equipment/EquipmentState";
                //刷新配置节
                ConfigurationManager.RefreshSection(szSegName);
                //加载配置项目
                nVConfig = (NameValueCollection)ConfigurationManager.GetSection(szSegName);
                if (nVConfig != null)
                {
                    EquipmentState = Convert.ToString(nVConfig["State"]);

                }
                #endregion

            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex);
                return bRet = false;
            }
            return bRet;
        }
    }
}
