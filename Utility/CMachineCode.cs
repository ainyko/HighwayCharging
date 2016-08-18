//////////////////////////////////////////////////////////////////////////
//功能：
//作者：luyaotang
//日期：2014/10/16
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
    //使用到了WINDOWS WMI的系统服务
    //重建过程操作如下：
    //停止 WMI 服务
    //WMI在系统中表现为一个系统服务 winmgmt(显示名称：Windows Management Instrumentation)，要进行 WMI 调用必须启动该服务。
    //注：系统中的杀毒软件、防火墙或者其它的服务有可能会依赖于该服务，停止winmgmt服务时，必须先停止这些依赖服务。
    //移除原来的存储库
    //可以在控制台输入以下命令，通过重命名 Repository 目录的方式移除原来的储存库。
    //    cd /d %windir%\system32\wbem
    //    rename Repository Rep_bak
    //执行 Mofcmp 命令，重新编译 wbem 目录下的 mof 和 mfl 文件
    //Mofcomp.exe 是一个操作系统工具，用于编译 MOF 文件，并将文件中包含的信息添加到 WMI 的存储库中。
    //在控制台输入以下命令：
    //    cd /d %windir%\system32\wbem
    //    for %i in (*.mof,*.mfl) do Mofcomp %i
    //命令执行成功后，存储库即完成重建。
    //执行完重建操作后，重新运行程序，WMI 调用恢复正常，至此，问题成功解决

    /// <summary>
    /// 机器码
    /// </summary>
    ///<summary>
    public class CMachineCode
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetVolumeInformation(string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, int lpMaximumComponentLength, int lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
        ///获取cpu序列号
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
        /// 获取主板的编号
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
        /// 获取BIOS编号
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
        ///   获取硬盘ID
        ///</summary>
        ///<returns> string </returns>
        public string GetHDid()
        {
            //ManagementClass mc = new ManagementClass("Win32_PhysicalMedia");
            ////网上有提到，用Win32_DiskDrive，但是用Win32_DiskDrive获得的硬盘信息中并不包含SerialNumber属性。  
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
        ///   获取网卡硬件地址
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
