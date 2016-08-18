using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;

namespace HighWayCharging
{
    public partial class ModifyPasswordUI : Form
    {
        //用户管理类
        private UserBll userBll;      
        //当前被选用户
        private string currentUser;
        //用户密码
        private string pwd;

        public ModifyPasswordUI(string userName, string passWord)
        {
            InitializeComponent();            
            currentUser = userName;
            pwd = passWord;
            userBll = new UserBll();
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 确认修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_OldPassWord.Text == "")
            {
                errorProvider1.SetError(textBox_OldPassWord, "请输入旧密码");
                return;
            }

            if (textBox_NewPassWord.Text == "")
            {
                errorProvider1.SetError(textBox_NewPassWord, "新密码不能为空");
                return;
            }

            if (textBox_Reconfirm.Text != textBox_NewPassWord.Text)
            {
                errorProvider1.SetError(textBox_Reconfirm, "前后两次密码不一致");
                return;
            }

            if (textBox_OldPassWord.Text != pwd)
            {
                MessageBox.Show("旧密码不正确，身份非法", "警告");
                return;
            }

            if (MessageBox.Show("确认修改密码？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bool isModifyOk = userBll.ModifyPwd(currentUser, textBox_NewPassWord.Text);

                if (isModifyOk)
                {
                    MessageBox.Show("修改成功", "恭喜", MessageBoxButtons.OK);
                    string log = "修改" + currentUser + "密码";
                    LoginDal.SetSystemLog(UserDal.userName, log);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码修改失败!", "提示");
                }
            }
        }

        private void ModifyPasswordUI_Load(object sender, EventArgs e)
        {
            //textBox_OldPassWord.Text = passWord;
        }


    }
}