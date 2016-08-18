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
        /// �޸��û�����
        /// </summary>
        /// <param name="userName">�û���</param>
        /// <param name="pwd">����</param>
        /// <returns>�Ƿ��޸ĳɹ�</returns>
        public bool ModifyPwd(string userName, string pwd)
        {
            return userDal.ModifyPwd(userName, pwd);
        }

        /// <summary>
        /// ɾ���û�
        /// </summary>
        /// <param name="userName">�û���</param>
        /// <returns>�Ƿ�ɹ�</returns>
        public bool delUser(string userName)
        {

            bool bRet = false;

            bRet = userDal.delUser(userName);

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


            bRet = userDal.addUser(user, password, role, privilege, name, gender, IDCard, state);

            return bRet;
        }
    }
}
