namespace HighWayCharging
{
    partial class TollRateConfigurationUI
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
            this.groupBox_TollRate = new System.Windows.Forms.GroupBox();
            this.dataGridView_TollRate = new System.Windows.Forms.DataGridView();
            this.panel_TollRate = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartStation1ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartStation1Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartStation2ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartStation2Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilometers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_TollRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TollRate)).BeginInit();
            this.panel_TollRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_TollRate
            // 
            this.groupBox_TollRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_TollRate.Controls.Add(this.dataGridView_TollRate);
            this.groupBox_TollRate.Location = new System.Drawing.Point(14, 12);
            this.groupBox_TollRate.Name = "groupBox_TollRate";
            this.groupBox_TollRate.Size = new System.Drawing.Size(791, 435);
            this.groupBox_TollRate.TabIndex = 6;
            this.groupBox_TollRate.TabStop = false;
            this.groupBox_TollRate.Text = "收费费率表";
            // 
            // dataGridView_TollRate
            // 
            this.dataGridView_TollRate.AllowUserToAddRows = false;
            this.dataGridView_TollRate.AllowUserToDeleteRows = false;
            this.dataGridView_TollRate.AllowUserToResizeRows = false;
            this.dataGridView_TollRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_TollRate.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_TollRate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_TollRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_TollRate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.StartStation1ID,
            this.StartStation1Name,
            this.StartStation2ID,
            this.StartStation2Name,
            this.CarType,
            this.Kilometers,
            this.Rate});
            this.dataGridView_TollRate.Location = new System.Drawing.Point(6, 18);
            this.dataGridView_TollRate.MultiSelect = false;
            this.dataGridView_TollRate.Name = "dataGridView_TollRate";
            this.dataGridView_TollRate.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_TollRate.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_TollRate.RowTemplate.Height = 23;
            this.dataGridView_TollRate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_TollRate.Size = new System.Drawing.Size(779, 411);
            this.dataGridView_TollRate.TabIndex = 2;
            // 
            // panel_TollRate
            // 
            this.panel_TollRate.Controls.Add(this.groupBox_TollRate);
            this.panel_TollRate.Location = new System.Drawing.Point(-2, 0);
            this.panel_TollRate.Name = "panel_TollRate";
            this.panel_TollRate.Size = new System.Drawing.Size(815, 450);
            this.panel_TollRate.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "序号";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // StartStation1ID
            // 
            this.StartStation1ID.DataPropertyName = "StartStation1ID";
            this.StartStation1ID.HeaderText = "起止站点1编号";
            this.StartStation1ID.Name = "StartStation1ID";
            this.StartStation1ID.Width = 120;
            // 
            // StartStation1Name
            // 
            this.StartStation1Name.DataPropertyName = "StartStation1Name";
            this.StartStation1Name.HeaderText = "起止站点1名称";
            this.StartStation1Name.Name = "StartStation1Name";
            this.StartStation1Name.Width = 120;
            // 
            // StartStation2ID
            // 
            this.StartStation2ID.DataPropertyName = "StartStation2ID";
            this.StartStation2ID.HeaderText = "起止站点2编号";
            this.StartStation2ID.Name = "StartStation2ID";
            this.StartStation2ID.Width = 120;
            // 
            // StartStation2Name
            // 
            this.StartStation2Name.DataPropertyName = "StartStation2Name";
            this.StartStation2Name.HeaderText = "起止站点2名称";
            this.StartStation2Name.Name = "StartStation2Name";
            this.StartStation2Name.Width = 120;
            // 
            // CarType
            // 
            this.CarType.DataPropertyName = "CarType";
            this.CarType.HeaderText = "车型";
            this.CarType.Name = "CarType";
            // 
            // Kilometers
            // 
            this.Kilometers.DataPropertyName = "Kilometers";
            this.Kilometers.HeaderText = "公里数(km/h)";
            this.Kilometers.Name = "Kilometers";
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "费用";
            this.Rate.Name = "Rate";
            // 
            // TollRateConfigurationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.panel_TollRate);
            this.MaximizeBox = false;
            this.Name = "TollRateConfigurationUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收费费率更新配置";
            this.groupBox_TollRate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TollRate)).EndInit();
            this.panel_TollRate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_TollRate;
        private System.Windows.Forms.DataGridView dataGridView_TollRate;
        private System.Windows.Forms.Panel panel_TollRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartStation1ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartStation1Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartStation2ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartStation2Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilometers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;




    }
}