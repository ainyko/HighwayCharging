using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Utility;

namespace BLL
{
    public class LoginBLL
    {

        public static string Login(string username, string password, string db_ip, string db_name, string db_user, string db_passwd)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("�û��������벻��Ϊ�գ�");
            }
            UserDal.Setuser(username.Trim(), password.Trim());    

            return  LoginDal.Login(username.Trim(), password.Trim(), db_ip, db_name, db_user, db_passwd);
        }




    }
}
