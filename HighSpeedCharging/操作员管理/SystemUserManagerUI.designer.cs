namespace HighWayCharging
{
    partial class SystemUserManagerUI
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Del = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Modify = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_close = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 495);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.userName,
            this.passWord,
            this.privilege,
            this.name,
            this.gender,
            this.IDCard,
            this.state});
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(755, 447);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            this.ID.Width = 80;
            // 
            // userName
            // 
            this.userName.DataPropertyName = "userName";
            this.userName.HeaderText = "用户名";
            this.userName.Name = "userName";
            // 
            // passWord
            // 
            this.passWord.DataPropertyName = "passWord";
            this.passWord.HeaderText = "密码";
            this.passWord.Name = "passWord";
            this.passWord.ToolTipText = ";";
            // 
            // privilege
            // 
            this.privilege.DataPropertyName = "privilege";
            this.privilege.HeaderText = "权限";
            this.privilege.Name = "privilege";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            this.name.Width = 80;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "性别";
            this.gender.Name = "gender";
            this.gender.Width = 60;
            // 
            // IDCard
            // 
            this.IDCard.DataPropertyName = "IDCard";
            this.IDCard.HeaderText = "身份证";
            this.IDCard.Name = "IDCard";
            this.IDCard.Width = 150;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "用户状态";
            this.state.Name = "state";
            this.state.Width = 80;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.bt_Add);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.bt_Del);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.bt_Modify);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.bt_close);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 455);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(763, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "        ";
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(94, 3);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(80, 35);
            this.bt_Add.TabIndex = 1;
            this.bt_Add.Text = "添加";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(180, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "        ";
            // 
            // bt_Del
            // 
            this.bt_Del.Location = new System.Drawing.Point(227, 3);
            this.bt_Del.Name = "bt_Del";
            this.bt_Del.Size = new System.Drawing.Size(80, 35);
            this.bt_Del.TabIndex = 2;
            this.bt_Del.Text = "删除";
            this.bt_Del.UseVisualStyleBackColor = true;
            this.bt_Del.Click += new System.EventHandler(this.bt_Del_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(313, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "        ";
            // 
            // bt_Modify
            // 
            this.bt_Modify.Location = new System.Drawing.Point(360, 3);
            this.bt_Modify.Name = "bt_Modify";
            this.bt_Modify.Size = new System.Drawing.Size(80, 35);
            this.bt_Modify.TabIndex = 2;
            this.bt_Modify.Text = "修改密码";
            this.bt_Modify.UseVisualStyleBackColor = true;
            this.bt_Modify.Click += new System.EventHandler(this.bt_Modify_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(446, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "        ";
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(493, 3);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(80, 35);
            this.bt_close.TabIndex = 2;
            this.bt_close.Text = "关闭(&C)";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // SystemUserManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 495);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "SystemUserManagerUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统用户管理";
            this.Load += new System.EventHandler(this.SystemUserManagerUI_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SystemUserManagerUI_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SystemUserManagerUI_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Del;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Modify;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn passWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilege;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
    }
}