namespace HighWayCharging
{
    partial class UserManageAddUI
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
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.lb_PassWord = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.lb_type = new System.Windows.Forms.Label();
            this.comboBox_privilege = new System.Windows.Forms.ComboBox();
            this.lb_privilege = new System.Windows.Forms.Label();
            this.comboBox_state = new System.Windows.Forms.ComboBox();
            this.lb_state = new System.Windows.Forms.Label();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.lb_gender = new System.Windows.Forms.Label();
            this.lb_IDCard = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_IDCard = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(100, 218);
            this.bt_Add.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(54, 34);
            this.bt_Add.TabIndex = 0;
            this.bt_Add.Text = "添加";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(258, 218);
            this.bt_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(54, 34);
            this.bt_Exit.TabIndex = 0;
            this.bt_Exit.Text = "退出";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(86, 31);
            this.textBox_user.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(98, 21);
            this.textBox_user.TabIndex = 1;
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.Location = new System.Drawing.Point(86, 78);
            this.textBox_PassWord.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.Size = new System.Drawing.Size(98, 21);
            this.textBox_PassWord.TabIndex = 1;
            // 
            // lb_PassWord
            // 
            this.lb_PassWord.AutoSize = true;
            this.lb_PassWord.Location = new System.Drawing.Point(28, 78);
            this.lb_PassWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PassWord.Name = "lb_PassWord";
            this.lb_PassWord.Size = new System.Drawing.Size(41, 12);
            this.lb_PassWord.TabIndex = 2;
            this.lb_PassWord.Text = "密码：";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(16, 34);
            this.lb_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(53, 12);
            this.lb_user.TabIndex = 2;
            this.lb_user.Text = "用户名：";
            // 
            // comboBox_role
            // 
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Location = new System.Drawing.Point(86, 123);
            this.comboBox_role.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(98, 20);
            this.comboBox_role.TabIndex = 5;
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(22, 129);
            this.lb_type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(47, 12);
            this.lb_type.TabIndex = 4;
            this.lb_type.Text = "角色 ：";
            // 
            // comboBox_privilege
            // 
            this.comboBox_privilege.FormattingEnabled = true;
            this.comboBox_privilege.Location = new System.Drawing.Point(86, 172);
            this.comboBox_privilege.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_privilege.Name = "comboBox_privilege";
            this.comboBox_privilege.Size = new System.Drawing.Size(98, 20);
            this.comboBox_privilege.TabIndex = 7;
            // 
            // lb_privilege
            // 
            this.lb_privilege.AutoSize = true;
            this.lb_privilege.Location = new System.Drawing.Point(22, 178);
            this.lb_privilege.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_privilege.Name = "lb_privilege";
            this.lb_privilege.Size = new System.Drawing.Size(47, 12);
            this.lb_privilege.TabIndex = 6;
            this.lb_privilege.Text = "权限 ：";
            // 
            // comboBox_state
            // 
            this.comboBox_state.FormattingEnabled = true;
            this.comboBox_state.Items.AddRange(new object[] {
            "无"});
            this.comboBox_state.Location = new System.Drawing.Point(286, 170);
            this.comboBox_state.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_state.Name = "comboBox_state";
            this.comboBox_state.Size = new System.Drawing.Size(114, 20);
            this.comboBox_state.TabIndex = 11;
            // 
            // lb_state
            // 
            this.lb_state.AutoSize = true;
            this.lb_state.Location = new System.Drawing.Point(222, 176);
            this.lb_state.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_state.Name = "lb_state";
            this.lb_state.Size = new System.Drawing.Size(41, 12);
            this.lb_state.TabIndex = 10;
            this.lb_state.Text = "状态：";
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox_gender.Location = new System.Drawing.Point(286, 121);
            this.comboBox_gender.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(114, 20);
            this.comboBox_gender.TabIndex = 9;
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Location = new System.Drawing.Point(222, 127);
            this.lb_gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(47, 12);
            this.lb_gender.TabIndex = 8;
            this.lb_gender.Text = "性别 ：";
            // 
            // lb_IDCard
            // 
            this.lb_IDCard.AutoSize = true;
            this.lb_IDCard.Location = new System.Drawing.Point(216, 37);
            this.lb_IDCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_IDCard.Name = "lb_IDCard";
            this.lb_IDCard.Size = new System.Drawing.Size(53, 12);
            this.lb_IDCard.TabIndex = 14;
            this.lb_IDCard.Text = "身份证：";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(228, 81);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 12);
            this.name.TabIndex = 15;
            this.name.Text = "姓名：";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(286, 81);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(114, 21);
            this.textBox_name.TabIndex = 12;
            // 
            // textBox_IDCard
            // 
            this.textBox_IDCard.Location = new System.Drawing.Point(286, 34);
            this.textBox_IDCard.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_IDCard.Name = "textBox_IDCard";
            this.textBox_IDCard.Size = new System.Drawing.Size(114, 21);
            this.textBox_IDCard.TabIndex = 13;
            this.textBox_IDCard.Text = "44************1234";
            // 
            // UserManageAddUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 272);
            this.Controls.Add(this.lb_IDCard);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_IDCard);
            this.Controls.Add(this.comboBox_state);
            this.Controls.Add(this.lb_state);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.comboBox_privilege);
            this.Controls.Add(this.lb_privilege);
            this.Controls.Add(this.comboBox_role);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.lb_PassWord);
            this.Controls.Add(this.textBox_PassWord);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_Add);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "UserManageAddUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加用户";
            this.Load += new System.EventHandler(this.UserManageAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_PassWord;
        private System.Windows.Forms.Label lb_PassWord;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.ComboBox comboBox_privilege;
        private System.Windows.Forms.Label lb_privilege;
        private System.Windows.Forms.ComboBox comboBox_state;
        private System.Windows.Forms.Label lb_state;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.Label lb_IDCard;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_IDCard;
    }
}