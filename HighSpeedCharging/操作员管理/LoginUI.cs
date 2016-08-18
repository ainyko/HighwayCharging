using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OracleClient;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using BLL;
using DAL;
using Utility;

namespace HighWayCharging
{
    public partial class LoginUI : Form
    {
        bool DBOpenFlag = true;//数据库开启标志  

        public LoginUI()
        {
            InitializeComponent();
        }

        //开启服务
        public bool DBConnectionStartUI()
        {

            //DataBaseConnectionBLL.ProcessMessageUIEvent += new DataBaseConnectionBLL.ProcessMessageUI(DisplayNetServerMessage);//后台消息处理
            DBOpenFlag &= DataBaseConnectionBLL.StartDataBaseConnection();//打开数据库部分
            return DBOpenFlag;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            string user, passwd;
            RegistryConfigurationBLL userSettingbll = new RegistryConfigurationBLL();
            //从数据库加载配置
            userSettingbll.GetUserConfigInfo(out user, out passwd);
            //界面填充
            tbUser.Text = user;
            tbPwd.Text = passwd;

            if (!DBConnectionStartUI())//数据库连接
            {
                bt_Login.Enabled = false;
                lb_ErrorInfo.Visible = true;
                return;
            }

            bt_Login.Enabled = true;

        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            string user = "", passwd = "";
            string db_ip, db_name, db_user, db_passwd;
            int db_port;
            //账号密码匹配
            string tag = string.Empty;

            try
            {
                //记住密码
                if (checkBox_RememberPW.Checked == true)
                {
                    user = tbUser.Text.Trim();
                    passwd = tbPwd.Text.Trim();
                    RegistryConfigurationBLL userSettingbll = new RegistryConfigurationBLL();
                    //从注册表加载配置
                    userSettingbll.SetUserConfigInfo(user, passwd);
                }
                else
                {
                    RegistryConfigurationBLL userSettingbll = new RegistryConfigurationBLL();
                    //从注册表加载配置
                    userSettingbll.SetUserConfigInfo(user, passwd);
                }

            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex.ToString() + "保存设置失败!!");//输出到文件
                MessageBox.Show("保存设置失败!");
            }


            try
            {

                RegistryConfigurationBLL dataBaseSettingbll = new RegistryConfigurationBLL();
                //从注册表加载配置
                dataBaseSettingbll.GetDatabaseConfigInfo(out db_ip, out db_port, out db_name, out db_user, out db_passwd);
                tag = LoginBLL.Login(tbUser.Text, tbPwd.Text, db_ip, db_name, db_user, db_passwd);
       
                switch (tag)
                {
                    case "0":
                        MessageBox.Show("用户不存在或密码不正确", "提示");
                        break;

                    case "1":
                        LoginDal.SetSystemLog(UserDal.userName, "登录");
                      
                        GlobalVarBLL.LoginFlag = true;
                        MessageBox.Show("登陆成功", "提示");
                        this.Close();
                        break;

                    default:
                        MessageBox.Show("数据库连接失败！", "警告");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
            }

            //默认值存储
            try
            {
                if (checkBox_RememberPW.Checked)
                {

                    Properties.Settings.Default["UserName"] = tbUser.Text.Trim();

                    Properties.Settings.Default["PassWord"] = tbPwd.Text.Trim();

                }

                if (!checkBox_RememberPW.Checked)
                {

                    Properties.Settings.Default["UserName"] = null;

                    Properties.Settings.Default["PassWord"] = null;
                }

                Properties.Settings.Default["default_login"] = checkBox_RememberPW.Checked;

                Properties.Settings.Default.Save();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }

            //if (tag == "1")
            //{
         
            //    MainForm main = new MainForm(this);

            //    main.ShowDialog();

            //}
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();

            this.Close();
        }

        private void bt_ServiceConfiguration_Click(object sender, EventArgs e)
        {
            DataBaseSettingUI dataBaseSettingUI = new DataBaseSettingUI();
            dataBaseSettingUI.ShowDialog(this);
            //if (ServerOpenFlag)
            //{
            //    if (!DBConnectionStartUI())
            //    {
            //        MessageBox.Show("获取数据库配置失败!", "错误");
            //        lb_ErrorInfo.Visible = true;
            //        return;
            //    }
            //}
        }

        private void LoginUI_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
