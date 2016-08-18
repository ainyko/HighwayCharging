using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace DAL
{
    public class UserDal
    {
        //用户逻辑管理类
        public static string userName;
        public static string psaaWord;


        public static bool Setuser(string username, string password)
        {
            userName = username;//内部赋值
            psaaWord = password;//内部赋值
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
        /// 修改用户密码
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns>是否修改成功</returns>
        public bool ModifyPwd(string userName, string pwd)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("update system set PassWord = '{1}'where userName='{0}'", userName, pwd);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("ModifyPwdErro:" + sql + "\r\n");//输出到文件
            }

            return bRet;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>是否成功</returns>
        public bool delUser(string userName)
        {

            bool bRet = true;
            string sql = "";

            sql = string.Format("delete from system where userName='{0}'", userName);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("delUserErro:" + sql + "\r\n");//输出到文件
            }

            return bRet;
        }

        /// <summary>
        /// 增加用户
        /// </summary>
        /// <param name="user">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="role">角色</param>
        /// <param name="privilege">权限</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="IDCard">身份证</param>
        /// <param name="state">状态</param>
        /// <returns>是否成功</returns>
        public bool addUser(string user, string password, string role, string privilege, string name, string gender, string IDCard, string state)
        {
            bool bRet = true;
            string sql = "";

            sql = string.Format("insert into system(UserName,PassWord,UserType,privilege,name,gender,IDCard,state) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');", user, password, role, privilege, name, gender, IDCard, state);
            if (MySQLHelper.ExecuteNonQuery(sql) == false)
            {
                bRet = false;
                DebugOutput.ProcessMessage("AddUserErro:" + sql + "\r\n");//输出到文件
            }

            return bRet;
        }

    }
}
