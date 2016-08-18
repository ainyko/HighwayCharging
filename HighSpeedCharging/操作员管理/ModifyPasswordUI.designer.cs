
namespace HighWayCharging
{
    partial class ModifyPasswordUI
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
            this.components = new System.ComponentModel.Container();
            this.lb_OldPassWord = new System.Windows.Forms.Label();
            this.textBox_OldPassWord = new System.Windows.Forms.TextBox();
            this.lb_NewPassWord = new System.Windows.Forms.Label();
            this.textBox_NewPassWord = new System.Windows.Forms.TextBox();
            this.lb_Reconfirm = new System.Windows.Forms.Label();
            this.textBox_Reconfirm = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.bt_ModifyOK = new System.Windows.Forms.Button();
            this.bt_CancleOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_OldPassWord
            // 
            this.lb_OldPassWord.AutoSize = true;
            this.lb_OldPassWord.Location = new System.Drawing.Point(42, 31);
            this.lb_OldPassWord.Name = "lb_OldPassWord";
            this.lb_OldPassWord.Size = new System.Drawing.Size(47, 12);
            this.lb_OldPassWord.TabIndex = 0;
            this.lb_OldPassWord.Text = "旧密码:";
            // 
            // textBox_OldPassWord
            // 
            this.textBox_OldPassWord.Location = new System.Drawing.Point(107, 27);
            this.textBox_OldPassWord.Name = "textBox_OldPassWord";
            this.textBox_OldPassWord.PasswordChar = '*';
            this.textBox_OldPassWord.Size = new System.Drawing.Size(115, 21);
            this.textBox_OldPassWord.TabIndex = 1;
            // 
            // lb_NewPassWord
            // 
            this.lb_NewPassWord.AutoSize = true;
            this.lb_NewPassWord.Location = new System.Drawing.Point(42, 78);
            this.lb_NewPassWord.Name = "lb_NewPassWord";
            this.lb_NewPassWord.Size = new System.Drawing.Size(47, 12);
            this.lb_NewPassWord.TabIndex = 0;
            this.lb_NewPassWord.Text = "新密码:";
            // 
            // textBox_NewPassWord
            // 
            this.textBox_NewPassWord.Location = new System.Drawing.Point(107, 74);
            this.textBox_NewPassWord.Name = "textBox_NewPassWord";
            this.textBox_NewPassWord.PasswordChar = '*';
            this.textBox_NewPassWord.Size = new System.Drawing.Size(115, 21);
            this.textBox_NewPassWord.TabIndex = 2;
            // 
            // lb_Reconfirm
            // 
            this.lb_Reconfirm.AutoSize = true;
            this.lb_Reconfirm.Location = new System.Drawing.Point(42, 126);
            this.lb_Reconfirm.Name = "lb_Reconfirm";
            this.lb_Reconfirm.Size = new System.Drawing.Size(59, 12);
            this.lb_Reconfirm.TabIndex = 0;
            this.lb_Reconfirm.Text = "重新确认:";
            // 
            // textBox_Reconfirm
            // 
            this.textBox_Reconfirm.Location = new System.Drawing.Point(107, 121);
            this.textBox_Reconfirm.Name = "textBox_Reconfirm";
            this.textBox_Reconfirm.PasswordChar = '*';
            this.textBox_Reconfirm.Size = new System.Drawing.Size(115, 21);
            this.textBox_Reconfirm.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(20, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 3);
            this.label4.TabIndex = 2;
            // 
            // bt_ModifyOK
            // 
            this.bt_ModifyOK.Location = new System.Drawing.Point(35, 197);
            this.bt_ModifyOK.Name = "bt_ModifyOK";
            this.bt_ModifyOK.Size = new System.Drawing.Size(77, 35);
            this.bt_ModifyOK.TabIndex = 4;
            this.bt_ModifyOK.Text = "确定(&Q)";
            this.bt_ModifyOK.UseVisualStyleBackColor = true;
            this.bt_ModifyOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_CancleOK
            // 
            this.bt_CancleOK.Location = new System.Drawing.Point(150, 197);
            this.bt_CancleOK.Name = "bt_CancleOK";
            this.bt_CancleOK.Size = new System.Drawing.Size(77, 35);
            this.bt_CancleOK.TabIndex = 5;
            this.bt_CancleOK.Text = "取消(&C)";
            this.bt_CancleOK.UseVisualStyleBackColor = true;
            this.bt_CancleOK.Click += new System.EventHandler(this.button2_Click);
            // 
            // ModifyPasswordUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(263, 238);
            this.Controls.Add(this.bt_CancleOK);
            this.Controls.Add(this.bt_ModifyOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Reconfirm);
            this.Controls.Add(this.lb_Reconfirm);
            this.Controls.Add(this.textBox_NewPassWord);
            this.Controls.Add(this.lb_NewPassWord);
            this.Controls.Add(this.textBox_OldPassWord);
            this.Controls.Add(this.lb_OldPassWord);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.Name = "ModifyPasswordUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.ModifyPasswordUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_OldPassWord;
        private System.Windows.Forms.TextBox textBox_OldPassWord;
        private System.Windows.Forms.Label lb_NewPassWord;
        private System.Windows.Forms.TextBox textBox_NewPassWord;
        private System.Windows.Forms.Label lb_Reconfirm;
        private System.Windows.Forms.TextBox textBox_Reconfirm;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bt_ModifyOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_CancleOK;
    }
}

