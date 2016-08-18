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
        //�û�������
        private UserBll userBll;      
        //��ǰ��ѡ�û�
        private string currentUser;
        //�û�����
        private string pwd;

        public ModifyPasswordUI(string userName, string passWord)
        {
            InitializeComponent();            
            currentUser = userName;
            pwd = passWord;
            userBll = new UserBll();
        }

        /// <summary>
        /// ȡ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// ȷ���޸�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_OldPassWord.Text == "")
            {
                errorProvider1.SetError(textBox_OldPassWord, "�����������");
                return;
            }

            if (textBox_NewPassWord.Text == "")
            {
                errorProvider1.SetError(textBox_NewPassWord, "�����벻��Ϊ��");
                return;
            }

            if (textBox_Reconfirm.Text != textBox_NewPassWord.Text)
            {
                errorProvider1.SetError(textBox_Reconfirm, "ǰ���������벻һ��");
                return;
            }

            if (textBox_OldPassWord.Text != pwd)
            {
                MessageBox.Show("�����벻��ȷ����ݷǷ�", "����");
                return;
            }

            if (MessageBox.Show("ȷ���޸����룿", "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bool isModifyOk = userBll.ModifyPwd(currentUser, textBox_NewPassWord.Text);

                if (isModifyOk)
                {
                    MessageBox.Show("�޸ĳɹ�", "��ϲ", MessageBoxButtons.OK);
                    string log = "�޸�" + currentUser + "����";
                    LoginDal.SetSystemLog(UserDal.userName, log);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("�����޸�ʧ��!", "��ʾ");
                }
            }
        }

        private void ModifyPasswordUI_Load(object sender, EventArgs e)
        {
            //textBox_OldPassWord.Text = passWord;
        }


    }
}