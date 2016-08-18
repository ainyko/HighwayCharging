using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace DAL
{
    public class UserDal
    {
        //�û��߼�������
        public static string userName;
        public static string psaaWord;


        public static bool Setuser(string username, string password)
        {
            userName = username;//�ڲ���ֵ
            psaaWord = password;//�ڲ���ֵ
            return true;
        }

        public static string GetUserName()
        {
            return userName;
        }

        public static string GetPassWord()
        {
            return psaaWord;
        }

        /// <summary>
        /// �޸��û�����
        /// </summary>
        /// <param name="userName">�û���</param>
        /// <param name="pwd">����</param>
        /// <returns>�Ƿ��޸ĳɹ�</returns>
        public bool ModifyPwd(string userName, string pwd)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("update system set PassWord = '{1}'where userName='{0}'", userName, pwd);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("ModifyPwdErro:" + sql + "\r\n");//������ļ�
            }

            return bRet;
        }

        /// <summary>
        /// ɾ���û�
        /// </summary>
        /// <param name="userName">�û���</param>
        /// <returns>�Ƿ�ɹ�</returns>
        public bool delUser(string userName)
        {

            bool bRet = true;
            string sql = "";

            sql = string.Format("delete from system where userName='{0}'", userName);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("delUserErro:" + sql + "\r\n");//������ļ�
            }

            return bRet;
        }

        /// <summary>
        /// �����û�
        /// </summary>
        /// <param name="user">�û���</param>
        /// <param name="password">����</param>
        /// <param name="role">��ɫ</param>
        /// <param name="privilege">Ȩ��</param>
        /// <param name="name">����</param>
        /// <param name="gender">�Ա�</param>
        /// <param name="IDCard">���֤</param>
        /// <param name="state">״̬</param>
        /// <returns>�Ƿ�ɹ�</returns>
        public bool addUser(string user, string password, string role, string privilege, string name, string gender, string IDCard, string state)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("insert into system(UserName,PassWord,UserType,privilege,name,gender,IDCard,state) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');", user, password, role, privilege, name, gender, IDCard, state);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("AddUserErro:" + sql + "\r\n");//������ļ�
            }

            return bRet;
        }

    }
}
