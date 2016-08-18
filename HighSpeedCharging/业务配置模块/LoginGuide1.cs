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
        //�Ƿ�����һ��
        bool isPreviewStep = false;
        //��ʱ���������Ƿ�����
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
        /// ��һ��
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
                MessageBox.Show(ex.Message, "����");
            }

            //���ݿ�����
            OracleConnection conn = null;
            try
            {
                string connectStr = AccountSetting.GetConnectStr(textBox1.Text, comboBox1.Text, textBox2.Text, textBox3.Text, "dbadmin", "super");
                AccountSetting.GetConnectStrByUser(textBox1.Text, comboBox1.Text, textBox2.Text, textBox3.Text, "dbadmin", "super");
                OracleHelper.InitConnetString(connectStr);
                conn = new OracleConnection(connectStr);
                conn.Open(); //�����ݿ�

                //LoginGuide2 guide2 = new LoginGuide2(this, null, textBox1.Text.Trim(), comboBox1.Text, textBox2.Text.Trim(), textBox3.Text.Trim());
                //guide2.ShowDialog();
                Login login = new Login(this, textBox1.Text.Trim());
                login.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("�޷����ӵ�Ŀ�������,������������\n������Ϣ:" + ex.Message, "��ʾ");
            }
            finally
            {
                //�ر�����
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        /// <summary>
        /// ��������ʱ��
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
                //�ر���
                Dongle.CloseSenseLock();
                //��������Ի���
                MessageBox.Show("���������γ��򱻸��������򼴽��˳�", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //�ͷ���Դ
                this.Dispose();
                //�˳�����
                Application.Exit();

            }
#endif
        }

        /// <summary>
        /// �б��Ѿ��򿪵ļ��ܹ��Ƿ�����
        /// </summary>
        private void InvalidLock()
        {
            if (false == Dongle.ElepCheck())
            {
                //�ر���
                Dongle.CloseSenseLock();
                //��������Ի���
                MessageBox.Show("�Ƿ��ļ�����������ǿ���˳�", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
                Application.Exit();
            }
        }

        private void LoginGuide1_Load(object sender, EventArgs e)
        {
            try
            {
#if !ABC
                //�򿪼�����
                bool isOpen = Dongle.OpenSenseLock();

                if (!isOpen)
                {
                    //��������Ի���
                    MessageBox.Show("û�м�⵽�����������򼴽��˳�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Dispose();
                    Application.Exit();
                }
                else
                {
                    //�жϼ��ܹ��Ƿ�Ϸ�
                    InvalidLock();
                }

                try
                {
                    //��ֻ�������� ��ʼ��ַ1152
                    //ֻ����Э�� ����1���ֽ� �û����ͣ� ��2��3�ֽ� �������� ��4��5��6�ֽ� �����������7��8��9�ֽ��������� 
                    countOfAccount = Dongle.ReadNumber(1153, 2);
                    countOfIntersection = Dongle.ReadNumber(1155, 3);
                    countOfWay = Dongle.ReadNumber(1158, 3);
                }
                catch
                {
                    MessageBox.Show("������Ȩ��������Ч,�˼����������ã�", "����");
                    this.Dispose();
                    Application.Exit();
                }
#endif
                //��ʱ�����ܹ�
                dogTimer.Interval = 5000;
                dogTimer.Tick += new EventHandler(dogTimer_Tick);
                dogTimer.Enabled = true;

                //��ʾĬ������
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
                MessageBox.Show(ex.Message, "����");
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