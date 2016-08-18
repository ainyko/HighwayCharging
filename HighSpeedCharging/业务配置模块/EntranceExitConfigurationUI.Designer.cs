namespace HighWayCharging
{
    partial class EntranceExitConfigurationUI
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
            this.groupBox_EntranceExit = new System.Windows.Forms.GroupBox();
            this.dataGridView_Tollstation = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TollstationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TollstationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntranceLane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitLane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpstreamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpstreamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownstreamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownstreamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Modify = new System.Windows.Forms.Button();
            this.bt_Delet = new System.Windows.Forms.Button();
            this.groupBox_EntranceExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tollstation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_EntranceExit
            // 
            this.groupBox_EntranceExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_EntranceExit.Controls.Add(this.dataGridView_Tollstation);
            this.groupBox_EntranceExit.Location = new System.Drawing.Point(12, 12);
            this.groupBox_EntranceExit.Name = "groupBox_EntranceExit";
            this.groupBox_EntranceExit.Size = new System.Drawing.Size(957, 386);
            this.groupBox_EntranceExit.TabIndex = 0;
            this.groupBox_EntranceExit.TabStop = false;
            // 
            // dataGridView_Tollstation
            // 
            this.dataGridView_Tollstation.AllowUserToAddRows = false;
            this.dataGridView_Tollstation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Tollstation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Tollstation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Tollstation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Tollstation.ColumnHeadersHeight = 30;
            this.dataGridView_Tollstation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TollstationID,
            this.TollstationName,
            this.EntranceLane,
            this.ExitLane,
            this.UpstreamID,
            this.UpstreamName,
            this.DownstreamID,
            this.DownstreamName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Tollstation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Tollstation.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_Tollstation.Name = "dataGridView_Tollstation";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Tollstation.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Tollstation.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_Tollstation.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Tollstation.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_Tollstation.RowTemplate.Height = 23;
            this.dataGridView_Tollstation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Tollstation.Size = new System.Drawing.Size(945, 351);
            this.dataGridView_Tollstation.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // TollstationID
            // 
            this.TollstationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TollstationID.DataPropertyName = "TollstationID";
            this.TollstationID.HeaderText = "收费站编号";
            this.TollstationID.Name = "TollstationID";
            // 
            // TollstationName
            // 
            this.TollstationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TollstationName.DataPropertyName = "TollstationName";
            this.TollstationName.HeaderText = "收费站名称";
            this.TollstationName.Name = "TollstationName";
            // 
            // EntranceLane
            // 
            this.EntranceLane.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EntranceLane.DataPropertyName = "EntranceLane";
            this.EntranceLane.HeaderText = "入口车道数";
            this.EntranceLane.Name = "EntranceLane";
            // 
            // ExitLane
            // 
            this.ExitLane.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExitLane.DataPropertyName = "ExitLane";
            this.ExitLane.HeaderText = "出口车道数";
            this.ExitLane.Name = "ExitLane";
            // 
            // UpstreamID
            // 
            this.UpstreamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UpstreamID.DataPropertyName = "UpstreamID";
            this.UpstreamID.HeaderText = "上游收费站编号";
            this.UpstreamID.Name = "UpstreamID";
            // 
            // UpstreamName
            // 
            this.UpstreamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UpstreamName.DataPropertyName = "UpstreamName";
            this.UpstreamName.HeaderText = "上游收费站名称";
            this.UpstreamName.Name = "UpstreamName";
            // 
            // DownstreamID
            // 
            this.DownstreamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DownstreamID.DataPropertyName = "DownstreamID";
            this.DownstreamID.HeaderText = "下游收费站编号";
            this.DownstreamID.Name = "DownstreamID";
            // 
            // DownstreamName
            // 
            this.DownstreamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DownstreamName.DataPropertyName = "DownstreamName";
            this.DownstreamName.HeaderText = "下游收费站名称";
            this.DownstreamName.Name = "DownstreamName";
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(260, 404);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(80, 40);
            this.bt_Add.TabIndex = 1;
            this.bt_Add.Text = "添加";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Modify
            // 
            this.bt_Modify.Location = new System.Drawing.Point(425, 404);
            this.bt_Modify.Name = "bt_Modify";
            this.bt_Modify.Size = new System.Drawing.Size(80, 40);
            this.bt_Modify.TabIndex = 2;
            this.bt_Modify.Text = "修改";
            this.bt_Modify.UseVisualStyleBackColor = true;
            this.bt_Modify.Click += new System.EventHandler(this.bt_Modify_Click);
            // 
            // bt_Delet
            // 
            this.bt_Delet.Location = new System.Drawing.Point(598, 404);
            this.bt_Delet.Name = "bt_Delet";
            this.bt_Delet.Size = new System.Drawing.Size(80, 40);
            this.bt_Delet.TabIndex = 3;
            this.bt_Delet.Text = "删除";
            this.bt_Delet.UseVisualStyleBackColor = true;
            this.bt_Delet.Click += new System.EventHandler(this.bt_Delet_Click);
            // 
            // EntranceExitConfigurationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 454);
            this.Controls.Add(this.bt_Delet);
            this.Controls.Add(this.bt_Modify);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.groupBox_EntranceExit);
            this.MaximizeBox = false;
            this.Name = "EntranceExitConfigurationUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进/出口设置";
            this.Load += new System.EventHandler(this.EntranceExitConfigurationUI_Load);
            this.groupBox_EntranceExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tollstation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_EntranceExit;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Modify;
        private System.Windows.Forms.Button bt_Delet;
        private System.Windows.Forms.DataGridView dataGridView_Tollstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TollstationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TollstationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntranceLane;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitLane;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpstreamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpstreamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DownstreamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DownstreamName;
    }
}