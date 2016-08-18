using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utility;
using BLL;


namespace HighWayCharging
{
    public partial class EquipmentMaintenanceUI : Form
    {
        public string AbnormalStyle;//异常类型
        public int ID;
        ExceptionOptBLL exceptionOptBLL = new ExceptionOptBLL();
        public EquipmentMaintenanceUI(string id, string AbnormalTime, string TollStationName, string LaneID,string style)
        {
            InitializeComponent();

            //初始化dateTimePicker格式
            dateTimePicker_AbnormalTime.Format = DateTimePickerFormat.Custom;
            dateTimePicker_AbnormalTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker_RestoreTime.Format = DateTimePickerFormat.Custom;
            dateTimePicker_RestoreTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            AbnormalStyle = style;
            ID = Convert.ToInt32(id);
            textBox_ID.Text = id;
            textBox_LaneID.Text = LaneID;
            textBox_TollStationName.Text = TollStationName;
            dateTimePicker_AbnormalTime.Text = AbnormalTime;
            dateTimePicker_RestoreTime.Text = DateTime.Now.ToString();

            if (style == "异常简易维护")
            {
                bt_Maintenance.Text = "简易维护";
                comboBox_restoring.SelectedIndex = 0;//可恢复
                comboBox_reporting.SelectedIndex = 0;//不上传
                comboBox_AbnormalState.SelectedIndex = 1;//异常
                //comboBox_restoring.Enabled = true;//错误可恢复
                //comboBox_reporting.Enabled = false;//异常不上传
            }
            else//错误上传
            {
                bt_Maintenance.Text = "错误上传";              
                comboBox_restoring.SelectedIndex = 1;//不可恢复
                comboBox_reporting.SelectedIndex = 1;//上传
                comboBox_AbnormalState.SelectedIndex = 2;//错误
                //comboBox_restoring.Enabled = false;//错误不可恢复
                //comboBox_reporting.Enabled = true;//错误上传
            }



        }


        private void bt_Maintenance_Click(object sender, EventArgs e)
        {
           
            if (AbnormalStyle == "异常简易维护")
            {
                if (exceptionOptBLL.Maintenance(ID) == true)
                {
                    MessageBox.Show("异常已进行简易维护！");
                    this.Dispose();
                }
            }
            else//错误上传
            {
                if (exceptionOptBLL.ErrorReporting(ID) == true)
                {
                    MessageBox.Show("错误信息已经上传成功！");
                    this.Dispose();
                }
            }
        }

        private void EquipmentMaintenanceUI_Load(object sender, EventArgs e)
        {
            DataTable dt = null;

            try
            {
                EquipmentAbnormalBLL equipmentAbnormalBLL = new EquipmentAbnormalBLL();//

                dt = equipmentAbnormalBLL.GetEquipmentAbnormalInfo();
             

            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage("EquipmentMaintenanceUI : " +　ex.ToString() + "\r\n");
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}