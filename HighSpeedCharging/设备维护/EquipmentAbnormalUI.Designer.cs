namespace HighWayCharging
{
    partial class EquipmentAbnormalUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_EquipmentMaintenance = new System.Windows.Forms.Panel();
            this.groupBox_EquipmentMaintenance = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_EquipmentMaintenance = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Reporting = new System.Windows.Forms.Button();
            this.bt_Maintenance = new System.Windows.Forms.Button();
            this.dataGridView_EquipmentMaintenance = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbnormalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TollstationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaneID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbnormalState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restoring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestoreTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_EquipmentMaintenance.SuspendLayout();
            this.groupBox_EquipmentMaintenance.SuspendLayout();
            this.tableLayoutPanel_EquipmentMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EquipmentMaintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_EquipmentMaintenance
            // 
            this.panel_EquipmentMaintenance.Controls.Add(this.groupBox_EquipmentMaintenance);
            this.panel_EquipmentMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_EquipmentMaintenance.Location = new System.Drawing.Point(0, 0);
            this.panel_EquipmentMaintenance.Name = "panel_EquipmentMaintenance";
            this.panel_EquipmentMaintenance.Size = new System.Drawing.Size(1258, 599);
            this.panel_EquipmentMaintenance.TabIndex = 1;
            // 
            // groupBox_EquipmentMaintenance
            // 
            this.groupBox_EquipmentMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_EquipmentMaintenance.Controls.Add(this.tableLayoutPanel_EquipmentMaintenance);
            this.groupBox_EquipmentMaintenance.Controls.Add(this.dataGridView_EquipmentMaintenance);
            this.groupBox_EquipmentMaintenance.Location = new System.Drawing.Point(8, 8);
            this.groupBox_EquipmentMaintenance.Name = "groupBox_EquipmentMaintenance";
            this.groupBox_EquipmentMaintenance.Size = new System.Drawing.Size(1238, 588);
            this.groupBox_EquipmentMaintenance.TabIndex = 7;
            this.groupBox_EquipmentMaintenance.TabStop = false;
            // 
            // tableLayoutPanel_EquipmentMaintenance
            // 
            this.tableLayoutPanel_EquipmentMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_EquipmentMaintenance.ColumnCount = 3;
            this.tableLayoutPanel_EquipmentMaintenance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51064F));
            this.tableLayoutPanel_EquipmentMaintenance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.48936F));
            this.tableLayoutPanel_EquipmentMaintenance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel_EquipmentMaintenance.Controls.Add(this.bt_Reporting, 2, 0);
            this.tableLayoutPanel_EquipmentMaintenance.Controls.Add(this.bt_Maintenance, 0, 0);
            this.tableLayoutPanel_EquipmentMaintenance.Location = new System.Drawing.Point(391, 548);
            this.tableLayoutPanel_EquipmentMaintenance.Name = "tableLayoutPanel_EquipmentMaintenance";
            this.tableLayoutPanel_EquipmentMaintenance.RowCount = 1;
            this.tableLayoutPanel_EquipmentMaintenance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_EquipmentMaintenance.Size = new System.Drawing.Size(521, 37);
            this.tableLayoutPanel_EquipmentMaintenance.TabIndex = 1;
            // 
            // bt_Reporting
            // 
            this.bt_Reporting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Reporting.Location = new System.Drawing.Point(445, 3);
            this.bt_Reporting.Name = "bt_Reporting";
            this.bt_Reporting.Size = new System.Drawing.Size(73, 31);
            this.bt_Reporting.TabIndex = 0;
            this.bt_Reporting.Text = "异常上报";
            this.bt_Reporting.UseVisualStyleBackColor = true;
            this.bt_Reporting.Click += new System.EventHandler(this.bt_Reporting_Click);
            // 
            // bt_Maintenance
            // 
            this.bt_Maintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Maintenance.Location = new System.Drawing.Point(3, 3);
            this.bt_Maintenance.Name = "bt_Maintenance";
            this.bt_Maintenance.Size = new System.Drawing.Size(76, 31);
            this.bt_Maintenance.TabIndex = 1;
            this.bt_Maintenance.Text = "简易维护";
            this.bt_Maintenance.UseVisualStyleBackColor = true;
            this.bt_Maintenance.Click += new System.EventHandler(this.bt_Maintenance_Click);
            // 
            // dataGridView_EquipmentMaintenance
            // 
            this.dataGridView_EquipmentMaintenance.AllowUserToAddRows = false;
            this.dataGridView_EquipmentMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_EquipmentMaintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_EquipmentMaintenance.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_EquipmentMaintenance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_EquipmentMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EquipmentMaintenance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AbnormalTime,
            this.TollstationName,
            this.LaneID,
            this.AbnormalState,
            this.reportor,
            this.reporting,
            this.reportTime,
            this.restoring,
            this.RestoreTime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_EquipmentMaintenance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_EquipmentMaintenance.Location = new System.Drawing.Point(6, 13);
            this.dataGridView_EquipmentMaintenance.MultiSelect = false;
            this.dataGridView_EquipmentMaintenance.Name = "dataGridView_EquipmentMaintenance";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_EquipmentMaintenance.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_EquipmentMaintenance.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_EquipmentMaintenance.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_EquipmentMaintenance.RowTemplate.Height = 23;
            this.dataGridView_EquipmentMaintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_EquipmentMaintenance.Size = new System.Drawing.Size(1232, 520);
            this.dataGridView_EquipmentMaintenance.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "序号";
            this.ID.Name = "ID";
            // 
            // AbnormalTime
            // 
            this.AbnormalTime.DataPropertyName = "AbnormalTime";
            this.AbnormalTime.HeaderText = "发生时间";
            this.AbnormalTime.Name = "AbnormalTime";
            // 
            // TollstationName
            // 
            this.TollstationName.DataPropertyName = "TollstationName";
            this.TollstationName.HeaderText = "收费站名称";
            this.TollstationName.Name = "TollstationName";
            // 
            // LaneID
            // 
            this.LaneID.DataPropertyName = "LaneID";
            this.LaneID.HeaderText = "车道编号";
            this.LaneID.Name = "LaneID";
            // 
            // AbnormalState
            // 
            this.AbnormalState.DataPropertyName = "AbnormalState";
            this.AbnormalState.HeaderText = "异常状态";
            this.AbnormalState.Name = "AbnormalState";
            // 
            // reportor
            // 
            this.reportor.DataPropertyName = "reportor";
            this.reportor.HeaderText = "处理人员";
            this.reportor.Name = "reportor";
            // 
            // reporting
            // 
            this.reporting.DataPropertyName = "reporting";
            this.reporting.HeaderText = "是否上报";
            this.reporting.Name = "reporting";
            // 
            // reportTime
            // 
            this.reportTime.DataPropertyName = "reportTime";
            this.reportTime.HeaderText = "上报时间";
            this.reportTime.Name = "reportTime";
            // 
            // restoring
            // 
            this.restoring.DataPropertyName = "restoring";
            this.restoring.HeaderText = "是否恢复";
            this.restoring.Name = "restoring";
            // 
            // RestoreTime
            // 
            this.RestoreTime.DataPropertyName = "RestoreTime";
            this.RestoreTime.HeaderText = "恢复时间";
            this.RestoreTime.Name = "RestoreTime";
            // 
            // EquipmentAbnormalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 599);
            this.Controls.Add(this.panel_EquipmentMaintenance);
            this.MaximizeBox = false;
            this.Name = "EquipmentAbnormalUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备异常表";
            this.Load += new System.EventHandler(this.EquipmentAbnormalUI_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EquipmentAbnormalUI_FormClosed);
            this.panel_EquipmentMaintenance.ResumeLayout(false);
            this.groupBox_EquipmentMaintenance.ResumeLayout(false);
            this.tableLayoutPanel_EquipmentMaintenance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EquipmentMaintenance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_EquipmentMaintenance;
        private System.Windows.Forms.GroupBox groupBox_EquipmentMaintenance;
        private System.Windows.Forms.DataGridView dataGridView_EquipmentMaintenance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_EquipmentMaintenance;
        private System.Windows.Forms.Button bt_Reporting;
        private System.Windows.Forms.Button bt_Maintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbnormalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TollstationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaneID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbnormalState;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportor;
        private System.Windows.Forms.DataGridViewTextBoxColumn reporting;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn restoring;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestoreTime;
    }
}