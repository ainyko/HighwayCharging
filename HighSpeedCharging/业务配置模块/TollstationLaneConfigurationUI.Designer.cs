namespace HighWayCharging
{
    partial class TollstationLaneConfigurationUI
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
            this.comboBox_Tollstation = new System.Windows.Forms.ComboBox();
            this.groupBox_TollstationLane = new System.Windows.Forms.GroupBox();
            this.comboBox_EntranceExit = new System.Windows.Forms.ComboBox();
            this.label_EntranceExit = new System.Windows.Forms.Label();
            this.label_TollstationLane = new System.Windows.Forms.Label();
            this.comboBox_TollstationLane = new System.Windows.Forms.ComboBox();
            this.label_Tollstation = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.groupBox_TollstationLane.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Tollstation
            // 
            this.comboBox_Tollstation.FormattingEnabled = true;
            this.comboBox_Tollstation.Location = new System.Drawing.Point(83, 33);
            this.comboBox_Tollstation.Name = "comboBox_Tollstation";
            this.comboBox_Tollstation.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Tollstation.TabIndex = 0;
            this.comboBox_Tollstation.SelectedIndexChanged += new System.EventHandler(this.comboBox_Tollstation_SelectedIndexChanged);
            // 
            // groupBox_TollstationLane
            // 
            this.groupBox_TollstationLane.Controls.Add(this.comboBox_EntranceExit);
            this.groupBox_TollstationLane.Controls.Add(this.label_EntranceExit);
            this.groupBox_TollstationLane.Controls.Add(this.label_TollstationLane);
            this.groupBox_TollstationLane.Controls.Add(this.comboBox_TollstationLane);
            this.groupBox_TollstationLane.Controls.Add(this.label_Tollstation);
            this.groupBox_TollstationLane.Controls.Add(this.comboBox_Tollstation);
            this.groupBox_TollstationLane.Location = new System.Drawing.Point(12, 12);
            this.groupBox_TollstationLane.Name = "groupBox_TollstationLane";
            this.groupBox_TollstationLane.Size = new System.Drawing.Size(222, 166);
            this.groupBox_TollstationLane.TabIndex = 1;
            this.groupBox_TollstationLane.TabStop = false;
            // 
            // comboBox_EntranceExit
            // 
            this.comboBox_EntranceExit.FormattingEnabled = true;
            this.comboBox_EntranceExit.Items.AddRange(new object[] {
            "入口",
            "出口"});
            this.comboBox_EntranceExit.Location = new System.Drawing.Point(83, 77);
            this.comboBox_EntranceExit.Name = "comboBox_EntranceExit";
            this.comboBox_EntranceExit.Size = new System.Drawing.Size(121, 20);
            this.comboBox_EntranceExit.TabIndex = 6;
            this.comboBox_EntranceExit.Text = "入口";
            this.comboBox_EntranceExit.SelectedIndexChanged += new System.EventHandler(this.comboBox_EntranceExit_SelectedIndexChanged);
            // 
            // label_EntranceExit
            // 
            this.label_EntranceExit.AutoSize = true;
            this.label_EntranceExit.Location = new System.Drawing.Point(18, 80);
            this.label_EntranceExit.Name = "label_EntranceExit";
            this.label_EntranceExit.Size = new System.Drawing.Size(59, 12);
            this.label_EntranceExit.TabIndex = 5;
            this.label_EntranceExit.Text = "进/出口：";
            // 
            // label_TollstationLane
            // 
            this.label_TollstationLane.AutoSize = true;
            this.label_TollstationLane.Location = new System.Drawing.Point(36, 126);
            this.label_TollstationLane.Name = "label_TollstationLane";
            this.label_TollstationLane.Size = new System.Drawing.Size(41, 12);
            this.label_TollstationLane.TabIndex = 3;
            this.label_TollstationLane.Text = "车道：";
            // 
            // comboBox_TollstationLane
            // 
            this.comboBox_TollstationLane.FormattingEnabled = true;
            this.comboBox_TollstationLane.Location = new System.Drawing.Point(83, 123);
            this.comboBox_TollstationLane.Name = "comboBox_TollstationLane";
            this.comboBox_TollstationLane.Size = new System.Drawing.Size(121, 20);
            this.comboBox_TollstationLane.TabIndex = 2;
            // 
            // label_Tollstation
            // 
            this.label_Tollstation.AutoSize = true;
            this.label_Tollstation.Location = new System.Drawing.Point(24, 36);
            this.label_Tollstation.Name = "label_Tollstation";
            this.label_Tollstation.Size = new System.Drawing.Size(53, 12);
            this.label_Tollstation.TabIndex = 1;
            this.label_Tollstation.Text = "收费站：";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(84, 184);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(80, 40);
            this.bt_save.TabIndex = 2;
            this.bt_save.Text = "保存";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // TollstationLaneConfigurationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 231);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.groupBox_TollstationLane);
            this.MaximizeBox = false;
            this.Name = "TollstationLaneConfigurationUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收费站设置";
            this.Load += new System.EventHandler(this.TollstationLaneConfigurationUI_Load);
            this.groupBox_TollstationLane.ResumeLayout(false);
            this.groupBox_TollstationLane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Tollstation;
        private System.Windows.Forms.GroupBox groupBox_TollstationLane;
        private System.Windows.Forms.Label label_Tollstation;
        private System.Windows.Forms.Label label_TollstationLane;
        private System.Windows.Forms.ComboBox comboBox_TollstationLane;
        private System.Windows.Forms.Label label_EntranceExit;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.ComboBox comboBox_EntranceExit;
    }
}