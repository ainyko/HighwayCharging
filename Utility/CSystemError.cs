//////////////////////////////////////////////////////////////////////////
//功能：
//作者：luyaotang
//日期：2014/02/10
////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;//IComparer
using System.ComponentModel;
using System.Data;

namespace Utility
{

    /// <summary>
    /// 系统错误
    /// </summary>
    public class CSystemError
    {
        static string rootDir = AppDomain.CurrentDomain.BaseDirectory;//GetStorageCard() + "\\";//
        //系统日记路径
        const int MAX_LOGFILE_SIZE = 2 * 1024 * 1024;//最大文件 大小
        const int MAX_LOGFILE_NUM = 10;//最多10个文件
        private static DateTime uptime = System.DateTime.Now;
        private string newfilePath = String.Format("{0}SystemLog-{1}.txt", rootDir, uptime.ToString("yyyyMMdd-HHmmss"));
        private string filePath = String.Format("{0}SystemLog.txt", rootDir);

        /// <summary>
        /// 获取SD卡路径
        /// </summary>
        /// <returns></returns>
        public static string GetStorageCard()
        {
            string firstCard = "";
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo("\\");
            System.IO.FileSystemInfo[] fsi = di.GetFileSystemInfos();
            for (int x = 0; x < fsi.Length; x++)
            {
                if ((fsi[x].Attributes & System.IO.FileAttributes.Temporary) == System.IO.FileAttributes.Temporary)
                {
                    //if so, return the path
                    firstCard = fsi[x].FullName;
                }
            }
            return firstCard;
        }

        /// <summary>
        /// 错误消息处理
        /// </summary>
        /// <param name="errorMessage"></param>
        public void AddErrorMessage(string errorMessage)
        {
            if (errorMessage.EndsWith("\r\n") == false)
                errorMessage += "\r\n";//加入换行符号

            string errorString = String.Format("[{0}] : {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), errorMessage);

            try
            {
                //文件过大时切割文件
                if (File.Exists(filePath))
                {
                    FileInfo fileinfo = new FileInfo(filePath);//检测文件大小
                    if (fileinfo.Length > MAX_LOGFILE_SIZE)//3M
                    {
                        //删除多余的文件
                        RemoveExtLogFiles(MAX_LOGFILE_NUM);
                        //新开文件
                        uptime = System.DateTime.Now;
                        newfilePath = String.Format("{0}SystemLog-{1}.txt", rootDir, uptime.ToString("yyyyMMdd-HHmmss"));
                        File.Move(filePath, newfilePath);//重命名
                    }
                }
                //写入文件
                FileStream fs;
                StreamWriter sw;
                if (!File.Exists(filePath))//判断文件是否存在，不存在则要创建
                {
                    fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);//创建写入文件 
                    sw = new StreamWriter(fs);

                    sw.Write(errorString);//开始写入值

                    sw.Close();
                    fs.Close();
                }
                else
                {
                    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);//追加到文件尾部
                    sw = new StreamWriter(fs);

                    sw.Write(errorString);//开始写入值

                    sw.Close();//关闭写入流
                    fs.Close();//关闭文件流

                }//end if(!File.Exists(filePath))
            }
            catch
            {
                return;
            }
        }

        private void RemoveExtLogFiles(int numLeave)//要查找的文件夹和文件类型
        {
            string FoldPath = rootDir;//应用程序的目录
            string filter = "SystemLog-*.txt"; //文件过滤格式
            int removecount = 0, filescount = 0;
            DirectoryInfo folderinfo = new DirectoryInfo(FoldPath);

            FileInfo[] filelist = folderinfo.GetFiles(filter);//列举文件 
            filescount = filelist.Length;//数目
            if (filescount > numLeave)
            {
                removecount = filescount - numLeave;//需要移除数量
                foreach (FileInfo nextfile in filelist)
                {
                    if (removecount-- > 0)
                    {
                        nextfile.Delete();//删除文件
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }

    /// <summary>
    /// 错误信息的输出处理
    /// </summary>
    public class DebugOutput
    {
        public static CSystemError debugFile = new CSystemError();//日志记录
        public static void ProcessMessage(string msg)
        {
            //输出到控制台
            Console.Write(msg);
            //输出到文件
            debugFile.AddErrorMessage(msg);
        }

        public static void ProcessMessage(Exception ex)
        {
            string msg = ex.ToString();
            //输出到控制台
            Console.Write(msg);
            //输出到文件
            debugFile.AddErrorMessage(msg);
        }

        /// <summary>
        /// 格式化输出数组
        /// </summary>
        /// <param name="ch">字节数组</param>
        /// <param name="len">要求长度</param>
        public static void PrintBytes(byte[] ch, int len)
        {
            if (len > ch.Length)
                len = ch.Length;
            for (int i = 0; i < len; i++)
            {
                Console.Write(String.Format("{0:x2} ",ch[i]));
            }
            Console.Write("\r\n");
        }
    }
}
