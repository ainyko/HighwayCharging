using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace HighWayCharging
{
    public partial class UserManageReviseUI : Form
    {
        public string username;

        public UserManageReviseUI(string user,string password,string role)
        {
            InitializeComponent();

            this.textBox1.Text = Convert.ToString(user);
            this.textBox2.Text = Convert.ToString(password);
            this.textBox3.Text = Convert.ToString(role);

            username = user;            
        }

        private void UserManageRevise_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "")
            //{
            //    UserManageBll2.revise(this.textBox1.Text.Trim(), this.textBox2.Text.Trim(), this.textBox3.Text.Trim(),username);
                
            //    this.Dispose();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("数据不能为空！");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
