namespace HighWayCharging
{
    partial class EquipmentMaintenanceUI
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
            this.groupBox_DevAbnormalInfo = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_RestoreTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_AbnormalTime = new System.Windows.Forms.DateTimePicker();
            this.lb_AbnormalTime = new System.Windows.Forms.Label();
            this.LaneID = new System.Windows.Forms.Label();
            this.textBox_LaneID = new System.Windows.Forms.TextBox();
            this.lb_RestoreTime = new System.Windows.Forms.Label();
            this.comboBox_restoring = new System.Windows.Forms.ComboBox();
            this.lb_restoring = new System.Windows.Forms.Label();
            this.comboBox_reporting = new System.Windows.Forms.ComboBox();
            this.lb_reporting = new System.Windows.Forms.Label();
            this.comboBox_AbnormalState = new System.Windows.Forms.ComboBox();
            this.lb_AbnormalState = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_TollStationName = new System.Windows.Forms.Label();
            this.textBox_TollStationName = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_Maintenance = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox_DevAbnormalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_DevAbnormalInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 345);
            this.panel1.TabIndex = 0;
            // 
            // groupBox_DevAbnormalInfo
            // 
            this.groupBox_DevAbnormalInfo.Controls.Add(this.dateTimePicker_RestoreTime);
            this.groupBox_DevAbnormalInfo.Controls.Add(this.dateTimePicker_AbnormalTime);
            this.groupBox_DevAbnormalInfo.Controls.Add(this.lb_AbnormalTime);
            this.groupBox_DevAbnormalInfo.Controls.Add(this.LaneID);
            this.groupBox_DevAbnormalInfo.Controls.Add(this.textBox_LaneID);
            this.groupBox_DevAbnormalInfo.Controls.Add(this.lb_RestoreTime);
            this.groupBox_DevAbnormalInfo.Controls.Add(this.comboBox_restoring);
            this.groupBox_DevAbnormalInfo.Controls.Add(this.lb_restoring);
            this.groupBox_DevAbnormalInfo.Controls.Add(this.comboBox_reporting);
            this.groupBox_DevAbnormalInfo.Controls.Add(this.lb_reporting);
            this.groupBox_DevAbnormalInfo.Controls.Add(this.comboBox_AbnormalState);
            this.groupBox_DevAbnormalInfo.Controls.Add(this.lb_AbnormalState);
            this.groupBox_DevAbnormalInfo.Controls.Add(this.lb_ID);
            this.groupBox_DevAbnormalInfo.Controls.Add(this.lb_TollStationName);
            this.groupBox_DevAbnormalInfo.Controls.Add(this.textBox_TollStationName);
            this.groupBox_DevAbnormalInfo.Controls.Add(this.textBox_ID);
            this.groupBox_DevAbnormalInfo.Controls.Add(this.bt_Exit);
            this.groupBox_DevAbnormalInfo.Controls.Add(this.bt_Maintenance);
            this.groupBox_DevAbnormalInfo.Location = new System.Drawing.Point(0, 0);
            this.groupBox_DevAbnormalInfo.Name = "groupBox_DevAbnormalInfo";
            this.groupBox_DevAbnormalInfo.Size = new System.Drawing.Size(533, 342);
            this.groupBox_DevAbnormalInfo.TabIndex = 0;
            this.groupBox_DevAbnormalInfo.TabStop = false;
            this.groupBox_DevAbnormalInfo.Text = "维护信息";
            // 
            // dateTimePicker_RestoreTime
            // 
            this.dateTimePicker_RestoreTime.Enabled = false;
            this.dateTimePicker_RestoreTime.Location = new System.Drawing.Point(291, 166);
            this.dateTimePicker_RestoreTime.Name = "dateTimePicker_RestoreTime";
            this.dateTimePicker_RestoreTime.Size = new System.Drawing.Size(177, 21);
            this.dateTimePicker_RestoreTime.TabIndex = 53;
            this.dateTimePicker_RestoreTime.Value = new System.DateTime(2015, 11, 14, 19, 26, 15, 0);
            // 
            // dateTimePicker_AbnormalTime
            // 
            this.dateTimePicker_AbnormalTime.Enabled = false;
            this.dateTimePicker_AbnormalTime.Location = new System.Drawing.Point(292, 28);
            this.dateTimePicker_AbnormalTime.Name = "dateTimePicker_AbnormalTime";
            this.dateTimePicker_AbnormalTime.Size = new System.Drawing.Size(176, 21);
            this.dateTimePicker_AbnormalTime.TabIndex = 52;
            // 
            // lb_AbnormalTime
            // 
            this.lb_AbnormalTime.AutoSize = true;
            this.lb_AbnormalTime.Location = new System.Drawing.Point(222, 31);
            this.lb_AbnormalTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_AbnormalTime.Name = "lb_AbnormalTime";
            this.lb_AbnormalTime.Size = new System.Drawing.Size(65, 12);
            this.lb_AbnormalTime.TabIndex = 50;
            this.lb_AbnormalTime.Text = "发生时间：";
            // 
            // LaneID
            // 
            this.LaneID.AutoSize = true;
            this.LaneID.Location = new System.Drawing.Point(222, 75);
            this.LaneID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LaneID.Name = "LaneID";
            this.LaneID.Size = new System.Drawing.Size(65, 12);
            this.LaneID.TabIndex = 51;
            this.LaneID.Text = "车道编号：";
            // 
            // textBox_LaneID
            // 
            this.textBox_LaneID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_LaneID.Enabled = false;
            this.textBox_LaneID.Location = new System.Drawing.Point(291, 78);
            this.textBox_LaneID.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_LaneID.Name = "textBox_LaneID";
            this.textBox_LaneID.Size = new System.Drawing.Size(177, 21);
            this.textBox_LaneID.TabIndex = 48;
            // 
            // lb_RestoreTime
            // 
            this.lb_RestoreTime.AutoSize = true;
            this.lb_RestoreTime.Location = new System.Drawing.Point(222, 170);
            this.lb_RestoreTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_RestoreTime.Name = "lb_RestoreTime";
            this.lb_RestoreTime.Size = new System.Drawing.Size(65, 12);
            this.lb_RestoreTime.TabIndex = 46;
            this.lb_RestoreTime.Text = "恢复时间：";
            // 
            // comboBox_restoring
            // 
            this.comboBox_restoring.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_restoring.Enabled = false;
            this.comboBox_restoring.FormattingEnabled = true;
            this.comboBox_restoring.Items.AddRange(new object[] {
            "是",
            "否"});
            this.comboBox_restoring.Location = new System.Drawing.Point(291, 118);
            this.comboBox_restoring.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_restoring.Name = "comboBox_restoring";
            this.comboBox_restoring.Size = new System.Drawing.Size(177, 20);
            this.comboBox_restoring.TabIndex = 45;
            // 
            // lb_restoring
            // 
            this.lb_restoring.AutoSize = true;
            this.lb_restoring.Location = new System.Drawing.Point(222, 121);
            this.lb_restoring.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_restoring.Name = "lb_restoring";
            this.lb_restoring.Size = new System.Drawing.Size(65, 12);
            this.lb_restoring.TabIndex = 44;
            this.lb_restoring.Text = "是否恢复：";
            // 
            // comboBox_reporting
            // 
            this.comboBox_reporting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_reporting.Enabled = false;
            this.comboBox_reporting.FormattingEnabled = true;
            this.comboBox_reporting.Items.AddRange(new object[] {
            "否",
            "是"});
            this.comboBox_reporting.Location = new System.Drawing.Point(91, 169);
            this.comboBox_reporting.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_reporting.Name = "comboBox_reporting";
            this.comboBox_reporting.Size = new System.Drawing.Size(127, 20);
            this.comboBox_reporting.TabIndex = 43;
            // 
            // lb_reporting
            // 
            this.lb_reporting.AutoSize = true;
            this.lb_reporting.Location = new System.Drawing.Point(16, 175);
            this.lb_reporting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_reporting.Name = "lb_reporting";
            this.lb_reporting.Size = new System.Drawing.Size(71, 12);
            this.lb_reporting.TabIndex = 42;
            this.lb_reporting.Text = "是否上报 ：";
            // 
            // comboBox_AbnormalState
            // 
            this.comboBox_AbnormalState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_AbnormalState.Enabled = false;
            this.comboBox_AbnormalState.FormattingEnabled = true;
            this.comboBox_AbnormalState.Items.AddRange(new object[] {
            "正常",
            "异常",
            "错误"});
            this.comboBox_AbnormalState.Location = new System.Drawing.Point(91, 120);
            this.comboBox_AbnormalState.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_AbnormalState.Name = "comboBox_AbnormalState";
            this.comboBox_AbnormalState.Size = new System.Drawing.Size(127, 20);
            this.comboBox_AbnormalState.TabIndex = 41;
            // 
            // lb_AbnormalState
            // 
            this.lb_AbnormalState.AutoSize = true;
            this.lb_AbnormalState.Location = new System.Drawing.Point(22, 126);
            this.lb_AbnormalState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_AbnormalState.Name = "lb_AbnormalState";
            this.lb_AbnormalState.Size = new System.Drawing.Size(65, 12);
            this.lb_AbnormalState.TabIndex = 40;
            this.lb_AbnormalState.Text = "异常状态：";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(46, 31);
            this.lb_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(41, 12);
            this.lb_ID.TabIndex = 38;
            this.lb_ID.Text = "编号：";
            // 
            // lb_TollStationName
            // 
            this.lb_TollStationName.AutoSize = true;
            this.lb_TollStationName.Location = new System.Drawing.Point(34, 75);
            this.lb_TollStationName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TollStationName.Name = "lb_TollStationName";
            this.lb_TollStationName.Size = new System.Drawing.Size(53, 12);
            this.lb_TollStationName.TabIndex = 39;
            this.lb_TollStationName.Text = "收费站：";
            // 
            // textBox_TollStationName
            // 
            this.textBox_TollStationName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TollStationName.Enabled = false;
            this.textBox_TollStationName.Location = new System.Drawing.Point(91, 75);
            this.textBox_TollStationName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TollStationName.Name = "textBox_TollStationName";
            this.textBox_TollStationName.Size = new System.Drawing.Size(127, 21);
            this.textBox_TollStationName.TabIndex = 36;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ID.Enabled = false;
            this.textBox_ID.Location = new System.Drawing.Point(91, 28);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(127, 21);
            this.textBox_ID.TabIndex = 37;
            // 
            // bt_Exit
            // 
            this.bt_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Exit.Location = new System.Drawing.Point(341, 237);
            this.bt_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(97, 60);
            this.bt_Exit.TabIndex = 34;
            this.bt_Exit.Text = "退出";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // bt_Maintenance
            // 
            this.bt_Maintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Maintenance.Location = new System.Drawing.Point(110, 237);
            this.bt_Maintenance.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Maintenance.Name = "bt_Maintenance";
            this.bt_Maintenance.Size = new System.Drawing.Size(95, 60);
            this.bt_Maintenance.TabIndex = 35;
            this.bt_Maintenance.Text = "维修";
            this.bt_Maintenance.UseVisualStyleBackColor = true;
            this.bt_Maintenance.Click += new System.EventHandler(this.bt_Maintenance_Click);
            // 
            // EquipmentMaintenanceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 345);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "EquipmentMaintenanceUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备简易维护";
            this.Load += new System.EventHandler(this.EquipmentMaintenanceUI_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox_DevAbnormalInfo.ResumeLayout(false);
            this.groupBox_DevAbnormalInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_DevAbnormalInfo;
        private System.Windows.Forms.Label lb_AbnormalTime;
        private System.Windows.Forms.Label LaneID;
        private System.Windows.Forms.TextBox textBox_LaneID;
        private System.Windows.Forms.Label lb_RestoreTime;
        private System.Windows.Forms.ComboBox comboBox_restoring;
        private System.Windows.Forms.Label lb_restoring;
        private System.Windows.Forms.ComboBox comboBox_reporting;
        private System.Windows.Forms.Label lb_reporting;
        private System.Windows.Forms.ComboBox comboBox_AbnormalState;
        private System.Windows.Forms.Label lb_AbnormalState;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Label lb_TollStationName;
        private System.Windows.Forms.TextBox textBox_TollStationName;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_Maintenance;
        private System.Windows.Forms.DateTimePicker dateTimePicker_AbnormalTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_RestoreTime;

    }
}