//////////////////////////////////////////////////////////////////////////
//���ܣ�
//���ߣ�luyaotang
//���ڣ�2014/02/10
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
    /// ϵͳ����
    /// </summary>
    public class CSystemError
    {
        static string rootDir = AppDomain.CurrentDomain.BaseDirectory;//GetStorageCard() + "\\";//
        //ϵͳ�ռ�·��
        const int MAX_LOGFILE_SIZE = 2 * 1024 * 1024;//����ļ� ��С
        const int MAX_LOGFILE_NUM = 10;//���10���ļ�
        private static DateTime uptime = System.DateTime.Now;
        private string newfilePath = String.Format("{0}SystemLog-{1}.txt", rootDir, uptime.ToString("yyyyMMdd-HHmmss"));
        private string filePath = String.Format("{0}SystemLog.txt", rootDir);

        /// <summary>
        /// ��ȡSD��·��
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
        /// ������Ϣ����
        /// </summary>
        /// <param name="errorMessage"></param>
        public void AddErrorMessage(string errorMessage)
        {
            if (errorMessage.EndsWith("\r\n") == false)
                errorMessage += "\r\n";//���뻻�з���

            string errorString = String.Format("[{0}] : {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), errorMessage);

            try
            {
                //�ļ�����ʱ�и��ļ�
                if (File.Exists(filePath))
                {
                    FileInfo fileinfo = new FileInfo(filePath);//����ļ���С
                    if (fileinfo.Length > MAX_LOGFILE_SIZE)//3M
                    {
                        //ɾ��������ļ�
                        RemoveExtLogFiles(MAX_LOGFILE_NUM);
                        //�¿��ļ�
                        uptime = System.DateTime.Now;
                        newfilePath = String.Format("{0}SystemLog-{1}.txt", rootDir, uptime.ToString("yyyyMMdd-HHmmss"));
                        File.Move(filePath, newfilePath);//������
                    }
                }
                //д���ļ�
                FileStream fs;
                StreamWriter sw;
                if (!File.Exists(filePath))//�ж��ļ��Ƿ���ڣ���������Ҫ����
                {
                    fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);//����д���ļ� 
                    sw = new StreamWriter(fs);

                    sw.Write(errorString);//��ʼд��ֵ

                    sw.Close();
                    fs.Close();
                }
                else
                {
                    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);//׷�ӵ��ļ�β��
                    sw = new StreamWriter(fs);

                    sw.Write(errorString);//��ʼд��ֵ

                    sw.Close();//�ر�д����
                    fs.Close();//�ر��ļ���

                }//end if(!File.Exists(filePath))
            }
            catch
            {
                return;
            }
        }

        private void RemoveExtLogFiles(int numLeave)//Ҫ���ҵ��ļ��к��ļ�����
        {
            string FoldPath = rootDir;//Ӧ�ó����Ŀ¼
            string filter = "SystemLog-*.txt"; //�ļ����˸�ʽ
            int removecount = 0, filescount = 0;
            DirectoryInfo folderinfo = new DirectoryInfo(FoldPath);

            FileInfo[] filelist = folderinfo.GetFiles(filter);//�о��ļ� 
            filescount = filelist.Length;//��Ŀ
            if (filescount > numLeave)
            {
                removecount = filescount - numLeave;//��Ҫ�Ƴ�����
                foreach (FileInfo nextfile in filelist)
                {
                    if (removecount-- > 0)
                    {
                        nextfile.Delete();//ɾ���ļ�
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
    /// ������Ϣ���������
    /// </summary>
    public class DebugOutput
    {
        public static CSystemError debugFile = new CSystemError();//��־��¼
        public static void ProcessMessage(string msg)
        {
            //���������̨
            Console.Write(msg);
            //������ļ�
            debugFile.AddErrorMessage(msg);
        }

        public static void ProcessMessage(Exception ex)
        {
            string msg = ex.ToString();
            //���������̨
            Console.Write(msg);
            //������ļ�
            debugFile.AddErrorMessage(msg);
        }

        /// <summary>
        /// ��ʽ���������
        /// </summary>
        /// <param name="ch">�ֽ�����</param>
        /// <param name="len">Ҫ�󳤶�</param>
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