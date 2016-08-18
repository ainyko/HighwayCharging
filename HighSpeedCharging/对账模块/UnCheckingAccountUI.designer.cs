namespace HighWayCharging
{
    partial class UnCheckingAccountUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_RecordCount = new System.Windows.Forms.Label();
            this.label_TotalAmount = new System.Windows.Forms.Label();
            this.button_Modify = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.tableLayoutPanel_UnCheck = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_UnCheck = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardRecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntranceStationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntranceLane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ICCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntranceCarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitStationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitTollStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitLane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChargeState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel_UnCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UnCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label_RecordCount);
            this.flowLayoutPanel1.Controls.Add(this.label_TotalAmount);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.button_Modify);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.button_Save);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.button_Close);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 428);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1381, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label_RecordCount
            // 
            this.label_RecordCount.Location = new System.Drawing.Point(50, 0);
            this.label_RecordCount.Name = "label_RecordCount";
            this.label_RecordCount.Size = new System.Drawing.Size(189, 40);
            this.label_RecordCount.TabIndex = 0;
            this.label_RecordCount.Text = "记录数：xx        ";
            // 
            // label_TotalAmount
            // 
            this.label_TotalAmount.Location = new System.Drawing.Point(245, 0);
            this.label_TotalAmount.Name = "label_TotalAmount";
            this.label_TotalAmount.Size = new System.Drawing.Size(173, 40);
            this.label_TotalAmount.TabIndex = 0;
            this.label_TotalAmount.Text = "总金额：        ";
            // 
            // button_Modify
            // 
            this.button_Modify.Location = new System.Drawing.Point(481, 3);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(85, 37);
            this.button_Modify.TabIndex = 2;
            this.button_Modify.Text = "修改(&M)";
            this.button_Modify.UseVisualStyleBackColor = true;
            this.button_Modify.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "        ";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(619, 3);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(85, 37);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "对账无误";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(424, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 40);
            this.label5.TabIndex = 3;
            this.label5.Text = "        ";
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(757, 3);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(85, 37);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "关闭(&C)";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // tableLayoutPanel_UnCheck
            // 
            this.tableLayoutPanel_UnCheck.ColumnCount = 1;
            this.tableLayoutPanel_UnCheck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_UnCheck.Controls.Add(this.dataGridView_UnCheck, 0, 0);
            this.tableLayoutPanel_UnCheck.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel_UnCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_UnCheck.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_UnCheck.Name = "tableLayoutPanel_UnCheck";
            this.tableLayoutPanel_UnCheck.RowCount = 2;
            this.tableLayoutPanel_UnCheck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_UnCheck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_UnCheck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_UnCheck.Size = new System.Drawing.Size(1381, 468);
            this.tableLayoutPanel_UnCheck.TabIndex = 0;
            // 
            // dataGridView_UnCheck
            // 
            this.dataGridView_UnCheck.AllowUserToAddRows = false;
            this.dataGridView_UnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_UnCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_UnCheck.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_UnCheck.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_UnCheck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_UnCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_UnCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CardRecordID,
            this.CarNum,
            this.EntranceStationTime,
            this.EntranceLane,
            this.CardTime,
            this.ICCardID,
            this.EntranceCarType,
            this.ExitStationTime,
            this.ExitTollStation,
            this.ExitLane,
            this.Cost,
            this.ChargeState,
            this.Operator});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_UnCheck.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_UnCheck.Location = new System.Drawing.Point(4, 4);
            this.dataGridView_UnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_UnCheck.Name = "dataGridView_UnCheck";
            this.dataGridView_UnCheck.RowHeadersVisible = false;
            this.dataGridView_UnCheck.RowTemplate.Height = 23;
            this.dataGridView_UnCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_UnCheck.Size = new System.Drawing.Size(1373, 420);
            this.dataGridView_UnCheck.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(572, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "        ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(710, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "        ";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "序号";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // CardRecordID
            // 
            this.CardRecordID.DataPropertyName = "CardRecordID";
            this.CardRecordID.HeaderText = "发卡记录编号";
            this.CardRecordID.Name = "CardRecordID";
            // 
            // CarNum
            // 
            this.CarNum.DataPropertyName = "CarNum";
            this.CarNum.HeaderText = "车牌";
            this.CarNum.Name = "CarNum";
            // 
            // EntranceStationTime
            // 
            this.EntranceStationTime.DataPropertyName = "EntranceStationTime";
            this.EntranceStationTime.HeaderText = "入口收费站";
            this.EntranceStationTime.Name = "EntranceStationTime";
            // 
            // EntranceLane
            // 
            this.EntranceLane.DataPropertyName = "EntranceLane";
            this.EntranceLane.HeaderText = "入口车道";
            this.EntranceLane.Name = "EntranceLane";
            // 
            // CardTime
            // 
            this.CardTime.DataPropertyName = "CardTime";
            this.CardTime.HeaderText = "发卡时间";
            this.CardTime.Name = "CardTime";
            // 
            // ICCardID
            // 
            this.ICCardID.DataPropertyName = "ICCardID";
            this.ICCardID.HeaderText = "IC卡号";
            this.ICCardID.Name = "ICCardID";
            // 
            // EntranceCarType
            // 
            this.EntranceCarType.DataPropertyName = "EntranceCarType";
            this.EntranceCarType.HeaderText = "入口车型";
            this.EntranceCarType.Name = "EntranceCarType";
            // 
            // ExitStationTime
            // 
            this.ExitStationTime.DataPropertyName = "ExitStationTime";
            this.ExitStationTime.HeaderText = "出站到达时间";
            this.ExitStationTime.Name = "ExitStationTime";
            // 
            // ExitTollStation
            // 
            this.ExitTollStation.DataPropertyName = "ExitTollStation";
            this.ExitTollStation.HeaderText = "出口收费站";
            this.ExitTollStation.Name = "ExitTollStation";
            // 
            // ExitLane
            // 
            this.ExitLane.DataPropertyName = "ExitLane";
            this.ExitLane.HeaderText = "出口车道";
            this.ExitLane.Name = "ExitLane";
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "费用（元）";
            this.Cost.Name = "Cost";
            // 
            // ChargeState
            // 
            this.ChargeState.DataPropertyName = "ChargeState";
            this.ChargeState.HeaderText = "收费状态";
            this.ChargeState.Name = "ChargeState";
            // 
            // Operator
            // 
            this.Operator.DataPropertyName = "Operator";
            this.Operator.HeaderText = "操作员";
            this.Operator.Name = "Operator";
            // 
            // UnCheckingAccountUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 468);
            this.Controls.Add(this.tableLayoutPanel_UnCheck);
            this.MaximizeBox = false;
            this.Name = "UnCheckingAccountUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "未对账收费查询";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel_UnCheck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UnCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_RecordCount;
        private System.Windows.Forms.Label label_TotalAmount;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_UnCheck;
        private System.Windows.Forms.DataGridView dataGridView_UnCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardRecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntranceStationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntranceLane;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ICCardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntranceCarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitStationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitTollStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitLane;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChargeState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;

    }
}