namespace HighWayCharging
{
    partial class CardRecordUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_CardRecord = new System.Windows.Forms.GroupBox();
            this.dataGridView_SendCardRecord = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TollStationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaneID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendCardTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ICCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox_CardRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SendCardRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1014, 586);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_CardRecord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 580);
            this.panel1.TabIndex = 0;
            // 
            // groupBox_CardRecord
            // 
            this.groupBox_CardRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_CardRecord.Controls.Add(this.dataGridView_SendCardRecord);
            this.groupBox_CardRecord.Location = new System.Drawing.Point(3, 3);
            this.groupBox_CardRecord.Name = "groupBox_CardRecord";
            this.groupBox_CardRecord.Size = new System.Drawing.Size(1002, 586);
            this.groupBox_CardRecord.TabIndex = 0;
            this.groupBox_CardRecord.TabStop = false;
            this.groupBox_CardRecord.Text = "发卡记录表";
            // 
            // dataGridView_SendCardRecord
            // 
            this.dataGridView_SendCardRecord.AllowUserToAddRows = false;
            this.dataGridView_SendCardRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_SendCardRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SendCardRecord.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_SendCardRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SendCardRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CarNum,
            this.ArrivalTime,
            this.TollStationName,
            this.LaneID,
            this.SendCardTime,
            this.ICCard,
            this.CarType});
            this.dataGridView_SendCardRecord.Location = new System.Drawing.Point(1, 15);
            this.dataGridView_SendCardRecord.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_SendCardRecord.MultiSelect = false;
            this.dataGridView_SendCardRecord.Name = "dataGridView_SendCardRecord";
            this.dataGridView_SendCardRecord.RowHeadersVisible = false;
            this.dataGridView_SendCardRecord.RowTemplate.Height = 23;
            this.dataGridView_SendCardRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_SendCardRecord.Size = new System.Drawing.Size(1001, 565);
            this.dataGridView_SendCardRecord.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            // 
            // CarNum
            // 
            this.CarNum.DataPropertyName = "CarNum";
            this.CarNum.HeaderText = "车牌";
            this.CarNum.Name = "CarNum";
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.DataPropertyName = "ArrivalTime";
            this.ArrivalTime.HeaderText = "到达时间";
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.ToolTipText = ";";
            // 
            // TollStationName
            // 
            this.TollStationName.DataPropertyName = "TollStationName";
            this.TollStationName.HeaderText = "收费站名称";
            this.TollStationName.Name = "TollStationName";
            // 
            // LaneID
            // 
            this.LaneID.DataPropertyName = "LaneID";
            this.LaneID.HeaderText = "车道";
            this.LaneID.Name = "LaneID";
            // 
            // SendCardTime
            // 
            this.SendCardTime.DataPropertyName = "SendCardTime";
            this.SendCardTime.HeaderText = "发卡时间";
            this.SendCardTime.Name = "SendCardTime";
            // 
            // ICCard
            // 
            this.ICCard.DataPropertyName = "ICCard";
            this.ICCard.HeaderText = "IC卡号";
            this.ICCard.Name = "ICCard";
            // 
            // CarType
            // 
            this.CarType.DataPropertyName = "CarType";
            this.CarType.HeaderText = "车型";
            this.CarType.Name = "CarType";
            // 
            // CardRecordUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 586);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "CardRecordUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发卡查询";
            this.Load += new System.EventHandler(this.CardRecordUI_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox_CardRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SendCardRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_CardRecord;
        private System.Windows.Forms.DataGridView dataGridView_SendCardRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TollStationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaneID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendCardTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ICCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
    }
}