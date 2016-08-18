using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace HighWayCharging
{
    public partial class SystemLogUI : Form
    {
        private string startTime, endTime;

        public SystemLogUI()
        {
            InitializeComponent();
            //初始化dateTimePicker格式
            dateTimePicker_queryStartTime.Format = DateTimePickerFormat.Custom;
            dateTimePicker_queryStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker_queryEndTime.Format = DateTimePickerFormat.Custom;
            dateTimePicker_queryEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void QueryAll()
        {

            SystemLogBLL systemLogBLL = new SystemLogBLL();//

            DataTable systemLogDt = systemLogBLL.GetSystemLogInfo();
            this.dataGridView_SystemLog.DataSource = systemLogDt;
            this.dataGridView_SystemLog.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";//设置时间显示格式

        }


        private void SelectQuery(string startTime,string endTime)
        {

            SystemLogBLL systemLogBLL = new SystemLogBLL();//

            DataTable systemLogDt = systemLogBLL.GetSystemLogInfo(startTime, endTime);
            this.dataGridView_SystemLog.DataSource = systemLogDt;
            this.dataGridView_SystemLog.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";//设置时间显示格式

        }

        private void SystemLogrUI_Load(object sender, EventArgs e)
        {
            //查询全部
            QueryAll();
        }

        private void bt_QuerySetion_Click(object sender, EventArgs e)
        {

            startTime = dateTimePicker_queryStartTime.Value.ToString();
            endTime = dateTimePicker_queryEndTime.Value.ToString();

            //选择查询
            SelectQuery(startTime, endTime);

        }

        private void bt_QueryAll_Click(object sender, EventArgs e)
        {
            //查询全部
            QueryAll();
        }
    }
}