namespace HighWayCharging
{
    partial class ChargeRecordUI
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
            this.tableLayoutPanel_ChargeRecord = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_ChargeRecord = new System.Windows.Forms.DataGridView();
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
            this.tableLayoutPanel_ChargeRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChargeRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_ChargeRecord
            // 
            this.tableLayoutPanel_ChargeRecord.ColumnCount = 1;
            this.tableLayoutPanel_ChargeRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ChargeRecord.Controls.Add(this.dataGridView_ChargeRecord, 0, 0);
            this.tableLayoutPanel_ChargeRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ChargeRecord.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_ChargeRecord.Name = "tableLayoutPanel_ChargeRecord";
            this.tableLayoutPanel_ChargeRecord.RowCount = 1;
            this.tableLayoutPanel_ChargeRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ChargeRecord.Size = new System.Drawing.Size(1330, 468);
            this.tableLayoutPanel_ChargeRecord.TabIndex = 0;
            // 
            // dataGridView_ChargeRecord
            // 
            this.dataGridView_ChargeRecord.AllowUserToAddRows = false;
            this.dataGridView_ChargeRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ChargeRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ChargeRecord.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_ChargeRecord.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ChargeRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ChargeRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ChargeRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ChargeRecord.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ChargeRecord.Location = new System.Drawing.Point(4, 4);
            this.dataGridView_ChargeRecord.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_ChargeRecord.Name = "dataGridView_ChargeRecord";
            this.dataGridView_ChargeRecord.RowHeadersVisible = false;
            this.dataGridView_ChargeRecord.RowTemplate.Height = 23;
            this.dataGridView_ChargeRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ChargeRecord.Size = new System.Drawing.Size(1322, 460);
            this.dataGridView_ChargeRecord.TabIndex = 0;
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
            // ChargeRecordUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 468);
            this.Controls.Add(this.tableLayoutPanel_ChargeRecord);
            this.MaximizeBox = false;
            this.Name = "ChargeRecordUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收费记录查询";
            this.tableLayoutPanel_ChargeRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChargeRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ChargeRecord;
        private System.Windows.Forms.DataGridView dataGridView_ChargeRecord;
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