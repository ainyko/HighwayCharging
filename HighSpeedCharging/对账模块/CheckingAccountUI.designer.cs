namespace HighWayCharging
{
    partial class CheckingAccountUI
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_Checkinfo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cashier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChargeNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsReconciliation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReconciliationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Checkinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_Checkinfo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 468);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView_Checkinfo
            // 
            this.dataGridView_Checkinfo.AllowUserToAddRows = false;
            this.dataGridView_Checkinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Checkinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Checkinfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Checkinfo.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Checkinfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Checkinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Checkinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cashier,
            this.CheckTime,
            this.CheckAmount,
            this.ChargeNum,
            this.IsPay,
            this.PayTime,
            this.IsReconciliation,
            this.ReconciliationID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Checkinfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Checkinfo.Location = new System.Drawing.Point(4, 4);
            this.dataGridView_Checkinfo.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Checkinfo.Name = "dataGridView_Checkinfo";
            this.dataGridView_Checkinfo.RowHeadersVisible = false;
            this.dataGridView_Checkinfo.RowTemplate.Height = 23;
            this.dataGridView_Checkinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Checkinfo.Size = new System.Drawing.Size(901, 460);
            this.dataGridView_Checkinfo.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "序号";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Cashier
            // 
            this.Cashier.DataPropertyName = "Cashier";
            this.Cashier.HeaderText = "收费员";
            this.Cashier.Name = "Cashier";
            // 
            // CheckTime
            // 
            this.CheckTime.DataPropertyName = "CheckTime";
            this.CheckTime.HeaderText = "对账时间";
            this.CheckTime.Name = "CheckTime";
            // 
            // CheckAmount
            // 
            this.CheckAmount.DataPropertyName = "CheckAmount";
            this.CheckAmount.HeaderText = "对账金额";
            this.CheckAmount.Name = "CheckAmount";
            // 
            // ChargeNum
            // 
            this.ChargeNum.DataPropertyName = "ChargeNum";
            this.ChargeNum.HeaderText = "收费记录数";
            this.ChargeNum.Name = "ChargeNum";
            // 
            // IsPay
            // 
            this.IsPay.DataPropertyName = "IsPay";
            this.IsPay.HeaderText = "是否交款";
            this.IsPay.Name = "IsPay";
            // 
            // PayTime
            // 
            this.PayTime.DataPropertyName = "PayTime";
            this.PayTime.HeaderText = "交款时间";
            this.PayTime.Name = "PayTime";
            // 
            // IsReconciliation
            // 
            this.IsReconciliation.DataPropertyName = "IsReconciliation";
            this.IsReconciliation.HeaderText = "收费站是否对账";
            this.IsReconciliation.Name = "IsReconciliation";
            // 
            // ReconciliationID
            // 
            this.ReconciliationID.DataPropertyName = "ReconciliationID";
            this.ReconciliationID.HeaderText = "收费对账编号";
            this.ReconciliationID.Name = "ReconciliationID";
            // 
            // CheckingAccountUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 468);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "CheckingAccountUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "对账收费查询";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Checkinfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_Checkinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cashier;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChargeNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsReconciliation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReconciliationID;
    }
}