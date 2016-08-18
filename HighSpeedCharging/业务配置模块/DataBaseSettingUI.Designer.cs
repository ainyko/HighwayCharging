namespace HighWayCharging
{
    partial class DataBaseSettingUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_DATABASE_SETTING = new System.Windows.Forms.GroupBox();
            this.textBox_DATABASE_PASSWD = new System.Windows.Forms.TextBox();
            this.textBox_DATABASE_USER = new System.Windows.Forms.TextBox();
            this.textBox_DATABASE_IPADDR = new System.Windows.Forms.TextBox();
            this.textBox_DATABASE_PORT = new System.Windows.Forms.TextBox();
            this.textBox_DATABASE_NAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_NETSET_CONFIRM = new System.Windows.Forms.Button();
            this.groupBox_DATABASE_SETTING.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_DATABASE_SETTING
            // 
            this.groupBox_DATABASE_SETTING.Controls.Add(this.textBox_DATABASE_PASSWD);
            this.groupBox_DATABASE_SETTING.Controls.Add(this.textBox_DATABASE_USER);
            this.groupBox_DATABASE_SETTING.Controls.Add(this.textBox_DATABASE_IPADDR);
            this.groupBox_DATABASE_SETTING.Controls.Add(this.textBox_DATABASE_PORT);
            this.groupBox_DATABASE_SETTING.Controls.Add(this.textBox_DATABASE_NAME);
            this.groupBox_DATABASE_SETTING.Controls.Add(this.label3);
            this.groupBox_DATABASE_SETTING.Controls.Add(this.label2);
            this.groupBox_DATABASE_SETTING.Controls.Add(this.label5);
            this.groupBox_DATABASE_SETTING.Controls.Add(this.label4);
            this.groupBox_DATABASE_SETTING.Controls.Add(this.label1);
            this.groupBox_DATABASE_SETTING.Location = new System.Drawing.Point(12, 12);
            this.groupBox_DATABASE_SETTING.Name = "groupBox_DATABASE_SETTING";
            this.groupBox_DATABASE_SETTING.Size = new System.Drawing.Size(270, 164);
            this.groupBox_DATABASE_SETTING.TabIndex = 1;
            this.groupBox_DATABASE_SETTING.TabStop = false;
            this.groupBox_DATABASE_SETTING.Text = "系统数据库设置";
            // 
            // textBox_DATABASE_PASSWD
            // 
            this.textBox_DATABASE_PASSWD.Location = new System.Drawing.Point(100, 127);
            this.textBox_DATABASE_PASSWD.Name = "textBox_DATABASE_PASSWD";
            this.textBox_DATABASE_PASSWD.PasswordChar = '*';
            this.textBox_DATABASE_PASSWD.Size = new System.Drawing.Size(134, 21);
            this.textBox_DATABASE_PASSWD.TabIndex = 1;
            this.textBox_DATABASE_PASSWD.UseSystemPasswordChar = true;
            // 
            // textBox_DATABASE_USER
            // 
            this.textBox_DATABASE_USER.Location = new System.Drawing.Point(100, 100);
            this.textBox_DATABASE_USER.Name = "textBox_DATABASE_USER";
            this.textBox_DATABASE_USER.Size = new System.Drawing.Size(134, 21);
            this.textBox_DATABASE_USER.TabIndex = 1;
            // 
            // textBox_DATABASE_IPADDR
            // 
            this.textBox_DATABASE_IPADDR.Location = new System.Drawing.Point(100, 19);
            this.textBox_DATABASE_IPADDR.Name = "textBox_DATABASE_IPADDR";
            this.textBox_DATABASE_IPADDR.Size = new System.Drawing.Size(134, 21);
            this.textBox_DATABASE_IPADDR.TabIndex = 1;
            // 
            // textBox_DATABASE_PORT
            // 
            this.textBox_DATABASE_PORT.Location = new System.Drawing.Point(100, 46);
            this.textBox_DATABASE_PORT.Name = "textBox_DATABASE_PORT";
            this.textBox_DATABASE_PORT.Size = new System.Drawing.Size(134, 21);
            this.textBox_DATABASE_PORT.TabIndex = 1;
            // 
            // textBox_DATABASE_NAME
            // 
            this.textBox_DATABASE_NAME.Location = new System.Drawing.Point(100, 73);
            this.textBox_DATABASE_NAME.Name = "textBox_DATABASE_NAME";
            this.textBox_DATABASE_NAME.Size = new System.Drawing.Size(134, 21);
            this.textBox_DATABASE_NAME.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "端口：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "网络地址：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库：";
            // 
            // button_NETSET_CONFIRM
            // 
            this.button_NETSET_CONFIRM.Location = new System.Drawing.Point(93, 182);
            this.button_NETSET_CONFIRM.Name = "button_NETSET_CONFIRM";
            this.button_NETSET_CONFIRM.Size = new System.Drawing.Size(100, 43);
            this.button_NETSET_CONFIRM.TabIndex = 4;
            this.button_NETSET_CONFIRM.Text = "应用";
            this.button_NETSET_CONFIRM.UseVisualStyleBackColor = true;
            this.button_NETSET_CONFIRM.Click += new System.EventHandler(this.button_NETSET_CONFIRM_Click);
            // 
            // DataBaseSettingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 233);
            this.Controls.Add(this.button_NETSET_CONFIRM);
            this.Controls.Add(this.groupBox_DATABASE_SETTING);
            this.MaximizeBox = false;
            this.Name = "DataBaseSettingUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库配置";
            this.Load += new System.EventHandler(this.DataBaseSetting_Load);
            this.groupBox_DATABASE_SETTING.ResumeLayout(false);
            this.groupBox_DATABASE_SETTING.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_DATABASE_SETTING;
        private System.Windows.Forms.TextBox textBox_DATABASE_PASSWD;
        private System.Windows.Forms.TextBox textBox_DATABASE_USER;
        private System.Windows.Forms.TextBox textBox_DATABASE_IPADDR;
        private System.Windows.Forms.TextBox textBox_DATABASE_PORT;
        private System.Windows.Forms.TextBox textBox_DATABASE_NAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_NETSET_CONFIRM;
    }
}