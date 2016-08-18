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
    public partial class UserManageAddUI : Form
    {
        public UserManageAddUI()
        {
            InitializeComponent();

            //角色
            comboBox_role.Items.Add("中心管理员");
            comboBox_role.Items.Add("收费站管理员");
            comboBox_role.Items.Add("收费站操作员");

            //权限
            comboBox_privilege.Items.Add("中心主任");
            comboBox_privilege.Items.Add("中心出纳");
            comboBox_privilege.Items.Add("收费站站长");
            comboBox_privilege.Items.Add("收费站副站长");
            comboBox_privilege.Items.Add("发卡员");
            comboBox_privilege.Items.Add("收费员");
            comboBox_privilege.Items.Add("系统管理员");
           
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            bool bRet = false;
            if (textBox_user.Text.Trim() != "" && textBox_PassWord.Text.Trim() != "" && comboBox_role.Text.Trim() != "" && comboBox_privilege.Text.Trim() != "")
            {
                UserBll userBLL = new UserBll();
                bRet = userBLL.addUser(textBox_user.Text.Trim(), textBox_PassWord.Text.Trim(), comboBox_role.Text.Trim(), comboBox_privilege.Text.Trim(), textBox_name.Text.Trim(), comboBox_gender.Text.Trim(), textBox_IDCard.Text.Trim(), comboBox_state.Text.Trim());
                if (bRet)
                {
                    string log = "增加" + textBox_user.Text.Trim() + "用户";
                    LoginDal.SetSystemLog(UserDal.userName, log);
                }
                else 
                {
                    MessageBox.Show("增加失败，用户已存在！");
                    return;
                }

            }
            else
            {
                MessageBox.Show("用户名及密码不能为空！");
                return;
            }
                

            this.Dispose();

            this.Close();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();

            this.Close();
        }

        private void UserManageAdd_Load(object sender, EventArgs e)
        {
            //combox初始化成第一项
            comboBox_role.SelectedIndex = 0;
            comboBox_privilege.SelectedIndex = 0;
            comboBox_gender.SelectedIndex = 0;
            comboBox_state.SelectedIndex = 0;
 
        }
    }
}
