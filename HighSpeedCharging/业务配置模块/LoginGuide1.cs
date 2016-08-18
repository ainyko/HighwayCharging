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
using DAL;
using BLL;

namespace COAMDY
{
    public partial class LoginGuide1 : LoginGuideBase
    {
        //是否是上一步
        bool isPreviewStep = false;
        //定时检测加密锁是否正常
        private System.Windows.Forms.Timer dogTimer = new System.Windows.Forms.Timer();

        public LoginGuide1(Login guide2)
        {
            if (guide2 != null)
            {
                guide2.Dispose();
                guide2.Close();
                guide2 = null;
                isPreviewStep = true;
            }
            InitializeComponent();
        }

        /// <summary>
        /// 下一步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    Properties.Settings.Default["DBServer"] = textBox1.Text.Trim();
                    Properties.Settings.Default["Protocol"] = comboBox1.Text;
                    Properties.Settings.Default["ServiceName"] = textBox2.Text.Trim();
                    Properties.Settings.Default["Port"] = textBox3.Text.Trim();
                }

                Properties.Settings.Default["default1"] = checkBox1.Checked;
                Properties.Settings.Default.Save();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }

            //数据库连接
            OracleConnection conn = null;
            try
            {
                string connectStr = AccountSetting.GetConnectStr(textBox1.Text, comboBox1.Text, textBox2.Text, textBox3.Text, "dbadmin", "super");
                AccountSetting.GetConnectStrByUser(textBox1.Text, comboBox1.Text, textBox2.Text, textBox3.Text, "dbadmin", "super");
                OracleHelper.InitConnetString(connectStr);
                conn = new OracleConnection(connectStr);
                conn.Open(); //打开数据库

                //LoginGuide2 guide2 = new LoginGuide2(this, null, textBox1.Text.Trim(), comboBox1.Text, textBox2.Text.Trim(), textBox3.Text.Trim());
                //guide2.ShowDialog();
                Login login = new Login(this, textBox1.Text.Trim());
                login.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("无法连接到目标服务器,请检查连接设置\n错误消息:" + ex.Message, "提示");
            }
            finally
            {
                //关闭连接
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        /// <summary>
        /// 加密锁计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dogTimer_Tick(object sender, EventArgs e)
        {
#if ABC
            if (Dongle.OpenSenseLock() == false)
            {
                dogTimer.Enabled = false;
                dogTimer.Stop();
                //关闭锁
                Dongle.CloseSenseLock();
                //弹出错误对话框
                MessageBox.Show("加密锁被拔出或被更换，程序即将退出", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //释放资源
                this.Dispose();
                //退出程序
                Application.Exit();

            }
#endif
        }

        /// <summary>
        /// 判别已经打开的加密狗是否正版
        /// </summary>
        private void InvalidLock()
        {
            if (false == Dongle.ElepCheck())
            {
                //关闭锁
                Dongle.CloseSenseLock();
                //弹出错误对话框
                MessageBox.Show("非法的加密锁，程序强制退出", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
                Application.Exit();
            }
        }

        private void LoginGuide1_Load(object sender, EventArgs e)
        {
            try
            {
#if !ABC
                //打开加密锁
                bool isOpen = Dongle.OpenSenseLock();

                if (!isOpen)
                {
                    //弹出错误对话框
                    MessageBox.Show("没有检测到加密锁，程序即将退出", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Dispose();
                    Application.Exit();
                }
                else
                {
                    //判断加密狗是否合法
                    InvalidLock();
                }

                try
                {
                    //读只读区数据 起始地址1152
                    //只读区协议 【第1个字节 用户类型， 第2、3字节 套帐数， 第4、5、6字节 交叉口数，第7、8、9字节子区数】 
                    countOfAccount = Dongle.ReadNumber(1153, 2);
                    countOfIntersection = Dongle.ReadNumber(1155, 3);
                    countOfWay = Dongle.ReadNumber(1158, 3);
                }
                catch
                {
                    MessageBox.Show("加密锁权限设置无效,此加密锁不可用！", "错误");
                    this.Dispose();
                    Application.Exit();
                }
#endif
                //定时检测加密狗
                dogTimer.Interval = 5000;
                dogTimer.Tick += new EventHandler(dogTimer_Tick);
                dogTimer.Enabled = true;

                //显示默认设置
                textBox1.Text = Properties.Settings.Default["DBServer"].ToString();
                comboBox1.Text = Properties.Settings.Default["Protocol"].ToString();
                textBox2.Text = Properties.Settings.Default["ServiceName"].ToString();
                textBox3.Text = Properties.Settings.Default["Port"].ToString();
                checkBox1.Checked = Convert.ToBoolean(Properties.Settings.Default["default1"].ToString());

                if (checkBox1.Checked)
                {
                    if (!isPreviewStep)
                    {
                       button2_Click(this, EventArgs.Empty);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}