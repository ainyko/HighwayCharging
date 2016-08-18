namespace HighWayCharging
{
    partial class SystemLogUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_QueryAll = new System.Windows.Forms.Button();
            this.lb_fromTimeto = new System.Windows.Forms.Label();
            this.dateTimePicker_queryStartTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_queryEndTime = new System.Windows.Forms.DateTimePicker();
            this.bt_QuerySetion = new System.Windows.Forms.Button();
            this.lb_queryTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_SystemLog = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SystemLog)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.bt_QueryAll);
            this.panel1.Controls.Add(this.lb_fromTimeto);
            this.panel1.Controls.Add(this.dateTimePicker_queryStartTime);
            this.panel1.Controls.Add(this.dateTimePicker_queryEndTime);
            this.panel1.Controls.Add(this.bt_QuerySetion);
            this.panel1.Controls.Add(this.lb_queryTime);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 528);
            this.panel1.TabIndex = 0;
            // 
            // bt_QueryAll
            // 
            this.bt_QueryAll.Location = new System.Drawing.Point(334, 47);
            this.bt_QueryAll.Name = "bt_QueryAll";
            this.bt_QueryAll.Size = new System.Drawing.Size(75, 23);
            this.bt_QueryAll.TabIndex = 96;
            this.bt_QueryAll.Text = "查询全部";
            this.bt_QueryAll.UseVisualStyleBackColor = true;
            this.bt_QueryAll.Click += new System.EventHandler(this.bt_QueryAll_Click);
            // 
            // lb_fromTimeto
            // 
            this.lb_fromTimeto.AutoSize = true;
            this.lb_fromTimeto.Location = new System.Drawing.Point(154, 31);
            this.lb_fromTimeto.Name = "lb_fromTimeto";
            this.lb_fromTimeto.Size = new System.Drawing.Size(17, 12);
            this.lb_fromTimeto.TabIndex = 95;
            this.lb_fromTimeto.Text = "至";
            // 
            // dateTimePicker_queryStartTime
            // 
            this.dateTimePicker_queryStartTime.Location = new System.Drawing.Point(77, 7);
            this.dateTimePicker_queryStartTime.Name = "dateTimePicker_queryStartTime";
            this.dateTimePicker_queryStartTime.Size = new System.Drawing.Size(178, 21);
            this.dateTimePicker_queryStartTime.TabIndex = 94;
            this.dateTimePicker_queryStartTime.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker_queryEndTime
            // 
            this.dateTimePicker_queryEndTime.Location = new System.Drawing.Point(77, 49);
            this.dateTimePicker_queryEndTime.Name = "dateTimePicker_queryEndTime";
            this.dateTimePicker_queryEndTime.Size = new System.Drawing.Size(178, 21);
            this.dateTimePicker_queryEndTime.TabIndex = 93;
            // 
            // bt_QuerySetion
            // 
            this.bt_QuerySetion.Location = new System.Drawing.Point(334, 8);
            this.bt_QuerySetion.Name = "bt_QuerySetion";
            this.bt_QuerySetion.Size = new System.Drawing.Size(75, 23);
            this.bt_QuerySetion.TabIndex = 91;
            this.bt_QuerySetion.Text = "选择查询";
            this.bt_QuerySetion.UseVisualStyleBackColor = true;
            this.bt_QuerySetion.Click += new System.EventHandler(this.bt_QuerySetion_Click);
            // 
            // lb_queryTime
            // 
            this.lb_queryTime.AutoSize = true;
            this.lb_queryTime.Location = new System.Drawing.Point(4, 10);
            this.lb_queryTime.Name = "lb_queryTime";
            this.lb_queryTime.Size = new System.Drawing.Size(77, 12);
            this.lb_queryTime.TabIndex = 92;
            this.lb_queryTime.Text = "查询时间段：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_SystemLog, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 394F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 394F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 394F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 394F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 394F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 448);
            this.tableLayoutPanel1.TabIndex = 90;
            // 
            // dataGridView_SystemLog
            // 
            this.dataGridView_SystemLog.AllowUserToAddRows = false;
            this.dataGridView_SystemLog.AllowUserToDeleteRows = false;
            this.dataGridView_SystemLog.AllowUserToResizeRows = false;
            this.dataGridView_SystemLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_SystemLog.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_SystemLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_SystemLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.LoginUser,
            this.Action,
            this.LoginTime});
            this.dataGridView_SystemLog.Location = new System.Drawing.Point(4, 4);
            this.dataGridView_SystemLog.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_SystemLog.MultiSelect = false;
            this.dataGridView_SystemLog.Name = "dataGridView_SystemLog";
            this.dataGridView_SystemLog.RowHeadersVisible = false;
            this.dataGridView_SystemLog.RowTemplate.Height = 23;
            this.dataGridView_SystemLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_SystemLog.Size = new System.Drawing.Size(473, 440);
            this.dataGridView_SystemLog.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            // 
            // LoginUser
            // 
            this.LoginUser.DataPropertyName = "LoginUser";
            this.LoginUser.HeaderText = "登录用户";
            this.LoginUser.Name = "LoginUser";
            // 
            // Action
            // 
            this.Action.DataPropertyName = "Action";
            this.Action.HeaderText = "动作";
            this.Action.Name = "Action";
            this.Action.Width = 120;
            // 
            // LoginTime
            // 
            this.LoginTime.DataPropertyName = "LoginTime";
            this.LoginTime.HeaderText = "登录时间";
            this.LoginTime.Name = "LoginTime";
            this.LoginTime.Width = 150;
            // 
            // SystemLogUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 525);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "SystemLogUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "操作日志查询";
            this.Load += new System.EventHandler(this.SystemLogrUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SystemLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_fromTimeto;
        private System.Windows.Forms.DateTimePicker dateTimePicker_queryStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_queryEndTime;
        private System.Windows.Forms.Button bt_QuerySetion;
        private System.Windows.Forms.Label lb_queryTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_SystemLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginTime;
        private System.Windows.Forms.Button bt_QueryAll;


    }
}