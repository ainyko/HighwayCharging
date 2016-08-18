namespace HighWayCharging
{
    partial class LaneSimulationConfigurationUI
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
            this.lb_DemandInterval = new System.Windows.Forms.Label();
            this.lb_QueryInterval = new System.Windows.Forms.Label();
            this.lb_AbnormalInterval = new System.Windows.Forms.Label();
            this.groupBox_TimeInterval = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_SaveTimInterval = new System.Windows.Forms.Button();
            this.textBox_QueryInterval = new System.Windows.Forms.TextBox();
            this.textBox_AbnormalInterval = new System.Windows.Forms.TextBox();
            this.textBox_DemandInterval = new System.Windows.Forms.TextBox();
            this.groupBox_TimeInterval.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_DemandInterval
            // 
            this.lb_DemandInterval.AutoSize = true;
            this.lb_DemandInterval.Location = new System.Drawing.Point(19, 36);
            this.lb_DemandInterval.Name = "lb_DemandInterval";
            this.lb_DemandInterval.Size = new System.Drawing.Size(113, 12);
            this.lb_DemandInterval.TabIndex = 0;
            this.lb_DemandInterval.Text = "通行需求时间间隔：";
            // 
            // lb_QueryInterval
            // 
            this.lb_QueryInterval.AutoSize = true;
            this.lb_QueryInterval.Location = new System.Drawing.Point(19, 103);
            this.lb_QueryInterval.Name = "lb_QueryInterval";
            this.lb_QueryInterval.Size = new System.Drawing.Size(113, 12);
            this.lb_QueryInterval.TabIndex = 1;
            this.lb_QueryInterval.Text = "车辆到达时间间隔：";
            // 
            // lb_AbnormalInterval
            // 
            this.lb_AbnormalInterval.AutoSize = true;
            this.lb_AbnormalInterval.Location = new System.Drawing.Point(19, 167);
            this.lb_AbnormalInterval.Name = "lb_AbnormalInterval";
            this.lb_AbnormalInterval.Size = new System.Drawing.Size(113, 12);
            this.lb_AbnormalInterval.TabIndex = 2;
            this.lb_AbnormalInterval.Text = "设备异常时间间隔：";
            // 
            // groupBox_TimeInterval
            // 
            this.groupBox_TimeInterval.Controls.Add(this.label3);
            this.groupBox_TimeInterval.Controls.Add(this.label2);
            this.groupBox_TimeInterval.Controls.Add(this.label1);
            this.groupBox_TimeInterval.Controls.Add(this.bt_SaveTimInterval);
            this.groupBox_TimeInterval.Controls.Add(this.textBox_QueryInterval);
            this.groupBox_TimeInterval.Controls.Add(this.textBox_AbnormalInterval);
            this.groupBox_TimeInterval.Controls.Add(this.textBox_DemandInterval);
            this.groupBox_TimeInterval.Controls.Add(this.lb_AbnormalInterval);
            this.groupBox_TimeInterval.Controls.Add(this.lb_QueryInterval);
            this.groupBox_TimeInterval.Controls.Add(this.lb_DemandInterval);
            this.groupBox_TimeInterval.Location = new System.Drawing.Point(12, 12);
            this.groupBox_TimeInterval.Name = "groupBox_TimeInterval";
            this.groupBox_TimeInterval.Size = new System.Drawing.Size(260, 250);
            this.groupBox_TimeInterval.TabIndex = 3;
            this.groupBox_TimeInterval.TabStop = false;
            this.groupBox_TimeInterval.Text = "模拟定时器时间间隔配置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "ms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "ms";
            // 
            // bt_SaveTimInterval
            // 
            this.bt_SaveTimInterval.Location = new System.Drawing.Point(82, 198);
            this.bt_SaveTimInterval.Name = "bt_SaveTimInterval";
            this.bt_SaveTimInterval.Size = new System.Drawing.Size(82, 41);
            this.bt_SaveTimInterval.TabIndex = 6;
            this.bt_SaveTimInterval.Text = "应用";
            this.bt_SaveTimInterval.UseVisualStyleBackColor = true;
            this.bt_SaveTimInterval.Click += new System.EventHandler(this.SaveTimInterval_Click);
            // 
            // textBox_QueryInterval
            // 
            this.textBox_QueryInterval.Location = new System.Drawing.Point(138, 100);
            this.textBox_QueryInterval.Name = "textBox_QueryInterval";
            this.textBox_QueryInterval.Size = new System.Drawing.Size(100, 21);
            this.textBox_QueryInterval.TabIndex = 5;
            // 
            // textBox_AbnormalInterval
            // 
            this.textBox_AbnormalInterval.Enabled = false;
            this.textBox_AbnormalInterval.Location = new System.Drawing.Point(138, 164);
            this.textBox_AbnormalInterval.Name = "textBox_AbnormalInterval";
            this.textBox_AbnormalInterval.Size = new System.Drawing.Size(100, 21);
            this.textBox_AbnormalInterval.TabIndex = 4;
            // 
            // textBox_DemandInterval
            // 
            this.textBox_DemandInterval.Location = new System.Drawing.Point(138, 33);
            this.textBox_DemandInterval.Name = "textBox_DemandInterval";
            this.textBox_DemandInterval.Size = new System.Drawing.Size(100, 21);
            this.textBox_DemandInterval.TabIndex = 3;
            this.textBox_DemandInterval.TextChanged += new System.EventHandler(this.textBox_DemandInterval_TextChanged);
            // 
            // LaneSimulationConfigurationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 274);
            this.Controls.Add(this.groupBox_TimeInterval);
            this.MaximizeBox = false;
            this.Name = "LaneSimulationConfigurationUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "车道模拟配置";
            this.Load += new System.EventHandler(this.LaneSimulationConfigurationUI_Load);
            this.groupBox_TimeInterval.ResumeLayout(false);
            this.groupBox_TimeInterval.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_DemandInterval;
        private System.Windows.Forms.Label lb_QueryInterval;
        private System.Windows.Forms.Label lb_AbnormalInterval;
        private System.Windows.Forms.GroupBox groupBox_TimeInterval;
        private System.Windows.Forms.Button bt_SaveTimInterval;
        private System.Windows.Forms.TextBox textBox_QueryInterval;
        private System.Windows.Forms.TextBox textBox_AbnormalInterval;
        private System.Windows.Forms.TextBox textBox_DemandInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}