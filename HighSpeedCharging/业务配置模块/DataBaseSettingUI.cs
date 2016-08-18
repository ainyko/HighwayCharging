using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using Utility;

namespace HighWayCharging
{
    public partial class DataBaseSettingUI : Form
    {
        public DataBaseSettingUI()
        {
            InitializeComponent();
        }
        //初始化的信息
        private bool InitNetSetInfo()
        {
            bool ret = true;
            string db_ip, db_name, db_user, db_passwd;
            int db_port;
            //从数据库加载
            RegistryConfigurationBLL DataBaseSettingbll = new RegistryConfigurationBLL();
            DataBaseSettingbll.GetDatabaseConfigInfo(out db_ip, out db_port, out db_name, out db_user, out db_passwd);

            //界面填充,数据库
            textBox_DATABASE_IPADDR.Text = db_ip;
            textBox_DATABASE_PORT.Text = db_port.ToString();
            textBox_DATABASE_NAME.Text = db_name;
            textBox_DATABASE_USER.Text = db_user;
            textBox_DATABASE_PASSWD.Text = db_passwd;

            return ret;
        }

        //将界面的设置存入注册表
        private bool SaveNetSetInfo()
        {
            bool ret = true;
            string db_ip, db_name, db_user, db_passwd;
            int db_port;
            try
            {
                //数据库界面数据库信息获取
                db_ip = textBox_DATABASE_IPADDR.Text;
                db_port = Convert.ToInt32(textBox_DATABASE_PORT.Text);
                db_name = textBox_DATABASE_NAME.Text;
                db_user = textBox_DATABASE_USER.Text;
                db_passwd = textBox_DATABASE_PASSWD.Text;

                //存入注册表
                RegistryConfigurationBLL DataBaseSettingbll = new RegistryConfigurationBLL();
                ret &= DataBaseSettingbll.SetDatabaseConfigInfo(db_ip, db_port, db_name, db_user, db_passwd);


            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex.ToString() + "保存设置失败!!");//输出到文件
                MessageBox.Show("保存设置失败!!");
            }
            return ret;
        }

        private void DataBaseSetting_Load(object sender, EventArgs e)
        {
            InitNetSetInfo();//初始化设置
        }

        private void button_NETSET_CONFIRM_Click(object sender, EventArgs e)
        {
            //保存设置
            if (SaveNetSetInfo())
            {
                //弹出确认窗口
                MessageBox.Show("数据库配置成功");
                this.Dispose();

            }
            else
            {
                //弹出确认窗口
                MessageBox.Show("数据库配置失败");
            }

        }
    }
}