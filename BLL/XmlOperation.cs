using System;
using System.Collections.Generic;
using System.Text;
using Utility;
using System.Collections.Specialized;
using System.Xml;//ʹ��APP.CONFIG
using System.Configuration;

namespace BLL
{
    public class XmlOperation
    {
        //����ʱ����xml����
        public bool SaveXmlValue(string DemandInterval, string QueryInterval, string AbnormalInterval)
        {
            bool bRet = true;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(GlobalVarBLL.path + "���ٹ�·�����շ����.exe.config");
                XmlNodeList nodeList = doc.SelectNodes("/configuration/TimeInterval");
                foreach (XmlNode node in nodeList)
                {
                    node.SelectSingleNode("descendant::add[@key='DemandInterval'  ]").Attributes[1].Value = DemandInterval;
                    node.SelectSingleNode("descendant::add[@key='QueryInterval'  ]").Attributes[1].Value = QueryInterval;
                    node.SelectSingleNode("descendant::add[@key='AbnormalInterval'  ]").Attributes[1].Value = AbnormalInterval;

                }

                doc.Save(GlobalVarBLL.path + "���ٹ�·�����շ����.exe.config");

            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex);
                return bRet = false;
            }
            return bRet;
        }

        //��ȡ����ʱ����xml����ֵ
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
                #region ʱ����
                // =============ʱ����=================//
                string szSegName = "TimeInterval/Interval";
                //ˢ�����ý�
                ConfigurationManager.RefreshSection(szSegName);
                //����������Ŀ
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



        //�����豸״̬xml����
        public bool SaveXmlValue(string EquipmentState)
        {
            bool bRet = true;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(GlobalVarBLL.path + "���ٹ�·�����շ����.exe.config");
                XmlNodeList nodeList = doc.SelectNodes("/configuration/Equipment");
                foreach (XmlNode node in nodeList)
                {
                    node.SelectSingleNode("descendant::add[@key='State'  ]").Attributes[1].Value = EquipmentState;
    
                }

                doc.Save(GlobalVarBLL.path + "���ٹ�·�����շ����.exe.config");

            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex);
                return bRet = false;
            }
            return bRet;
        }

        //��ȡ�����豸״̬xml����ֵ
        public bool ReadXmlValue(out string EquipmentState)
        {
            bool bRet = true;

            EquipmentState = "����";


            try
            {
                NameValueCollection nVConfig = new NameValueCollection();

                ConfigurationManager.RefreshSection("//*");
                #region �豸״̬
                // =============�豸״̬=================//
                string szSegName = "Equipment/EquipmentState";
                //ˢ�����ý�
                ConfigurationManager.RefreshSection(szSegName);
                //����������Ŀ
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
