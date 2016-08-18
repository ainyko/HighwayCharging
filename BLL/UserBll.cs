using System;
using DAL;

namespace BLL
{
    public class UserBll
    {
        private UserDal userDal;
        public UserBll()
        {
            userDal = new UserDal();
        }

        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns>是否修改成功</returns>
        public bool ModifyPwd(string userName, string pwd)
        {
            return userDal.ModifyPwd(userName, pwd);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>是否成功</returns>
        public bool delUser(string userName)
        {

            bool bRet = false;

            bRet = userDal.delUser(userName);

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


            bRet = userDal.addUser(user, password, role, privilege, name, gender, IDCard, state);

            return bRet;
        }
    }
}
