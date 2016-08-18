//////////////////////////////////////////////////////////////////////////
//���ܣ�
//���ߣ�luyaotang
//���ڣ�2014/10/16
////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;//IComparer
using System.ComponentModel;
using System.Data;
using System.Management;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;

namespace Utility
{
    //ʹ�õ���WINDOWS WMI��ϵͳ����
    //�ؽ����̲������£�
    //ֹͣ WMI ����
    //WMI��ϵͳ�б���Ϊһ��ϵͳ���� winmgmt(��ʾ���ƣ�Windows Management Instrumentation)��Ҫ���� WMI ���ñ��������÷���
    //ע��ϵͳ�е�ɱ�����������ǽ���������ķ����п��ܻ������ڸ÷���ֹͣwinmgmt����ʱ��������ֹͣ��Щ��������
    //�Ƴ�ԭ���Ĵ洢��
    //�����ڿ���̨�����������ͨ�������� Repository Ŀ¼�ķ�ʽ�Ƴ�ԭ���Ĵ���⡣
    //    cd /d %windir%\system32\wbem
    //    rename Repository Rep_bak
    //ִ�� Mofcmp ������±��� wbem Ŀ¼�µ� mof �� mfl �ļ�
    //Mofcomp.exe ��һ������ϵͳ���ߣ����ڱ��� MOF �ļ��������ļ��а�������Ϣ��ӵ� WMI �Ĵ洢���С�
    //�ڿ���̨�����������
    //    cd /d %windir%\system32\wbem
    //    for %i in (*.mof,*.mfl) do Mofcomp %i
    //����ִ�гɹ��󣬴洢�⼴����ؽ���
    //ִ�����ؽ��������������г���WMI ���ûָ����������ˣ�����ɹ����

    /// <summary>
    /// ������
    /// </summary>
    ///<summary>
    public class CMachineCode
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetVolumeInformation(string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, int lpMaximumComponentLength, int lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
        ///��ȡcpu���к�
        ///</summary>
        ///<returns> string </returns>
        public string GetCpuInfo()
        {
            string strID = "";
            try
            {
                ManagementClass mc = new ManagementClass("Win32_Processor");
                ManagementObjectCollection moc = mc.GetInstances();
                
                foreach (ManagementObject mo in moc)
                {
                    strID = mo.Properties["ProcessorId"].Value.ToString();
                    break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("WMI:GetCpuInfo" + ex.ToString() + ex.Data.ToString()+ ex.HelpLink.ToString());
            }
            return strID;
        }

        /// <summary>
        /// ��ȡ����ı��
        /// </summary>
        /// <returns></returns>
        public string GetMainBoardID()
        {
            ManagementClass mc = new ManagementClass("Win32_BaseBoard");
            ManagementObjectCollection moc = mc.GetInstances();
            string strID = null;
            foreach (ManagementObject mo in moc)
            {
                strID = mo.Properties["SerialNumber"].Value.ToString();
                break;
            }
            return strID;
        }

        /// <summary>
        /// ��ȡBIOS���
        /// </summary>
        /// <returns></returns>
        public string GetBiosID()
        {
            ManagementClass mc = new ManagementClass("Win32_BIOS");
            ManagementObjectCollection moc = mc.GetInstances();
            string strID = null;
            foreach (ManagementObject mo in moc)
            {
                strID = mo.Properties["SerialNumber"].Value.ToString();
                break;
            }
            return strID;
        }
        ///<summary>
        ///   ��ȡӲ��ID
        ///</summary>
        ///<returns> string </returns>
        public string GetHDid()
        {
            //ManagementClass mc = new ManagementClass("Win32_PhysicalMedia");
            ////�������ᵽ����Win32_DiskDrive��������Win32_DiskDrive��õ�Ӳ����Ϣ�в�������SerialNumber���ԡ�  
            //ManagementObjectCollection moc = mc.GetInstances();
            //string strID = null;
            //foreach (ManagementObject mo in moc)
            //{
            //    strID = mo.Properties["SerialNumber"].Value.ToString();
            //    break;
            //} 
            //return strID;
            const int MAX_FILENAME_LEN = 256;
            int retVal = 0;
            GetVolumeInformation("c:\\",null,MAX_FILENAME_LEN,ref retVal,0,0,null,MAX_FILENAME_LEN);
            return retVal.ToString("X"); 

        }

        ///<summary>
        ///   ��ȡ����Ӳ����ַ
        ///</summary>
        ///<returns> string </returns>
        public string GetMacAddress()
        {
            string MoAddress = "0000000000";
            using (ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                ManagementObjectCollection moc2 = mc.GetInstances();
                foreach (ManagementObject mo in moc2)
                {
                    if ((bool)mo["IPEnabled"] == true)
                    {
                        MoAddress = mo["MacAddress"].ToString();
                        MoAddress = MoAddress.Replace(":", "");
                    }
                    mo.Dispose();
                }
            }
            
            
            //NetworkInterface[] ntif = NetworkInterface.GetAllNetworkInterfaces();
            //if (ntif.Length > 0)
            //{
            //    string temp = ntif[0].GetPhysicalAddress().ToString();
            //}
            return MoAddress.ToString();
        }
    }
}
