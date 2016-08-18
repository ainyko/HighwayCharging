namespace HighWayCharging
{
    partial class LoginUI
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
            this.bt_Login = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.lb_ErrorInfo = new System.Windows.Forms.Label();
            this.checkBox_RememberPW = new System.Windows.Forms.CheckBox();
            this.bt_ServiceConfiguration = new System.Windows.Forms.Button();
            this.pictureBox_Login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Login
            // 
            this.bt_Login.Enabled = false;
            this.bt_Login.Image = global::HighWayCharging.Properties.Resources.bt_picture;
            this.bt_Login.Location = new System.Drawing.Point(263, 69);
            this.bt_Login.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(68, 41);
            this.bt_Login.TabIndex = 0;
            this.bt_Login.Text = "登陆";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Image = global::HighWayCharging.Properties.Resources.bt_picture;
            this.bt_exit.Location = new System.Drawing.Point(449, 69);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(68, 41);
            this.bt_exit.TabIndex = 1;
            this.bt_exit.Text = "退出";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(90, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "账号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(261, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(139, 15);
            this.tbUser.Margin = new System.Windows.Forms.Padding(2);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(76, 21);
            this.tbUser.TabIndex = 6;
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(313, 16);
            this.tbPwd.Margin = new System.Windows.Forms.Padding(2);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(76, 21);
            this.tbPwd.TabIndex = 6;
            this.tbPwd.UseSystemPasswordChar = true;
            // 
            // lb_ErrorInfo
            // 
            this.lb_ErrorInfo.AutoSize = true;
            this.lb_ErrorInfo.ForeColor = System.Drawing.Color.Red;
            this.lb_ErrorInfo.Location = new System.Drawing.Point(149, 45);
            this.lb_ErrorInfo.Name = "lb_ErrorInfo";
            this.lb_ErrorInfo.Size = new System.Drawing.Size(317, 12);
            this.lb_ErrorInfo.TabIndex = 9;
            this.lb_ErrorInfo.Text = "数据库连接失败，请进行数据库配置，修改成功后重启程序";
            this.lb_ErrorInfo.Visible = false;
            // 
            // checkBox_RememberPW
            // 
            this.checkBox_RememberPW.AutoSize = true;
            this.checkBox_RememberPW.Checked = true;
            this.checkBox_RememberPW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RememberPW.Location = new System.Drawing.Point(449, 20);
            this.checkBox_RememberPW.Name = "checkBox_RememberPW";
            this.checkBox_RememberPW.Size = new System.Drawing.Size(72, 16);
            this.checkBox_RememberPW.TabIndex = 11;
            this.checkBox_RememberPW.Text = "记住密码";
            this.checkBox_RememberPW.UseVisualStyleBackColor = true;
            // 
            // bt_ServiceConfiguration
            // 
            this.bt_ServiceConfiguration.Image = global::HighWayCharging.Properties.Resources.bt_picture;
            this.bt_ServiceConfiguration.Location = new System.Drawing.Point(92, 69);
            this.bt_ServiceConfiguration.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ServiceConfiguration.Name = "bt_ServiceConfiguration";
            this.bt_ServiceConfiguration.Size = new System.Drawing.Size(68, 41);
            this.bt_ServiceConfiguration.TabIndex = 8;
            this.bt_ServiceConfiguration.Text = "数据库  配置";
            this.bt_ServiceConfiguration.UseVisualStyleBackColor = true;
            this.bt_ServiceConfiguration.Click += new System.EventHandler(this.bt_ServiceConfiguration_Click);
            // 
            // pictureBox_Login
            // 
            this.pictureBox_Login.Image = global::HighWayCharging.Properties.Resources.background;
            this.pictureBox_Login.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox_Login.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Login.Name = "pictureBox_Login";
            this.pictureBox_Login.Size = new System.Drawing.Size(631, 397);
            this.pictureBox_Login.TabIndex = 7;
            this.pictureBox_Login.TabStop = false;
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 392);
            this.Controls.Add(this.checkBox_RememberPW);
            this.Controls.Add(this.lb_ErrorInfo);
            this.Controls.Add(this.bt_ServiceConfiguration);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.pictureBox_Login);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LoginUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginUI_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.PictureBox pictureBox_Login;
        private System.Windows.Forms.Button bt_ServiceConfiguration;
        private System.Windows.Forms.Label lb_ErrorInfo;
        private System.Windows.Forms.CheckBox checkBox_RememberPW;
    }
}