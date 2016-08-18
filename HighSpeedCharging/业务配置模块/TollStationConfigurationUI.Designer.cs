namespace HighWayCharging
{
    partial class TollStationConfigurationUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntranceLineCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitLineCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpStationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpStationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownStationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownStationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 497);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 464);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "收费费率表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.StationName,
            this.EntranceLineCount,
            this.ExitLineCount,
            this.UpStationID,
            this.UpStationName,
            this.DownStationID,
            this.DownStationName});
            this.dataGridView1.Location = new System.Drawing.Point(6, 13);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(882, 447);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            // 
            // StationName
            // 
            this.StationName.HeaderText = "收费站名称";
            this.StationName.Name = "StationName";
            // 
            // EntranceLineCount
            // 
            this.EntranceLineCount.HeaderText = "入口车道数";
            this.EntranceLineCount.Name = "EntranceLineCount";
            // 
            // ExitLineCount
            // 
            this.ExitLineCount.HeaderText = "出口车道数";
            this.ExitLineCount.Name = "ExitLineCount";
            // 
            // UpStationID
            // 
            this.UpStationID.HeaderText = "上游收费站编号";
            this.UpStationID.Name = "UpStationID";
            this.UpStationID.Width = 120;
            // 
            // UpStationName
            // 
            this.UpStationName.HeaderText = "上游收费站名称";
            this.UpStationName.Name = "UpStationName";
            this.UpStationName.Width = 120;
            // 
            // DownStationID
            // 
            this.DownStationID.HeaderText = "下游收费站编号";
            this.DownStationID.Name = "DownStationID";
            this.DownStationID.Width = 120;
            // 
            // DownStationName
            // 
            this.DownStationName.HeaderText = "下游收费站名称";
            this.DownStationName.Name = "DownStationName";
            this.DownStationName.Width = 120;
            // 
            // TollStationConfigurationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 476);
            this.Controls.Add(this.panel1);
            this.Name = "TollStationConfigurationUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收费站车道设置";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntranceLineCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitLineCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpStationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpStationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DownStationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DownStationName;

    }
}