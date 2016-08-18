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
    public partial class EquipmentAbnormalUI : Form
    {
        private string id = string.Empty;
        private string abnormalTime = "";
        private string tollStationName = "";
        private string laneID = string.Empty;
        private string abnormalState = string.Empty;//状态
        private string Reporting = string.Empty;//是否上报
        private string Restoring = string.Empty;//是否恢复使用
        private XmlOperation xmlOperation;//xml配置文件操作

        public EquipmentAbnormalUI()
        {
            InitializeComponent();
            xmlOperation = new XmlOperation();
        }

        //刷新表格
        private void Init()
        {


            EquipmentAbnormalBLL equipmentAbnormalBLL = new EquipmentAbnormalBLL();//

            DataTable equipmentAbnormalDt = equipmentAbnormalBLL.GetEquipmentAbnormalInfo();
            this.dataGridView_EquipmentMaintenance.DataSource = equipmentAbnormalDt;
            this.dataGridView_EquipmentMaintenance.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";//设置时间显示格式
            this.dataGridView_EquipmentMaintenance.Columns[7].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";//设置时间显示格式
            this.dataGridView_EquipmentMaintenance.Columns[9].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";//设置时间显示格式


        }

        //获取所选表格信息
        private void GetDataViewInfo()
        {
            id = dataGridView_EquipmentMaintenance.CurrentRow.Cells["ID"].Value.ToString();
            abnormalTime = dataGridView_EquipmentMaintenance.CurrentRow.Cells["AbnormalTime"].Value.ToString();
            tollStationName = dataGridView_EquipmentMaintenance.CurrentRow.Cells["TollStationName"].Value.ToString();
            laneID = dataGridView_EquipmentMaintenance.CurrentRow.Cells["LaneID"].Value.ToString();
            abnormalState = dataGridView_EquipmentMaintenance.CurrentRow.Cells["AbnormalState"].Value.ToString();
            Reporting = dataGridView_EquipmentMaintenance.CurrentRow.Cells["reporting"].Value.ToString();
            Restoring = dataGridView_EquipmentMaintenance.CurrentRow.Cells["restoring"].Value.ToString();
        }

        private void bt_Maintenance_Click(object sender, EventArgs e)
        {
            //获取所选表格信息
            GetDataViewInfo();
            if (abnormalState == "异常")
            {
                //判断是否恢复使用
                if (Restoring != "是")
                {
                    EquipmentMaintenanceUI equipmentMaintenanceUI = new EquipmentMaintenanceUI(id, abnormalTime, tollStationName, laneID, "异常简易维护");
                    equipmentMaintenanceUI.ShowDialog(this);

                    //修改设备状态XML变量
                    if (!xmlOperation.SaveXmlValue("正常"))
                    {
                        MessageBox.Show("维护/上传失败！", "提示", MessageBoxButtons.OK);
                
                    }
                }
                else
                {
                    MessageBox.Show("该记录已经处理！");
                }

            }
            else
            {
                MessageBox.Show("错误类型，请选择：错误上报！");
            }
            //刷新界面表格
            Init();
        }

        private void bt_Reporting_Click(object sender, EventArgs e)
        {
            //获取所选表格信息
            GetDataViewInfo();
            if (abnormalState == "错误")
            {


                //判断是否已经上传
                if (Reporting != "是")
                {
                    EquipmentMaintenanceUI equipmentMaintenanceUI = new EquipmentMaintenanceUI(id, abnormalTime, tollStationName, laneID, "错误上传");
                    equipmentMaintenanceUI.ShowDialog(this);

                    //修改设备状态XML变量
                    if (!xmlOperation.SaveXmlValue("正常"))
                    {
                        MessageBox.Show("维护/上传失败！", "提示", MessageBoxButtons.OK);
                 
                    }

                }
                else
                {
                    MessageBox.Show("该记录已经处理！");
                }
            }
            else
            {
                MessageBox.Show("异常类型，请选择：简易维护！");
            }
            //刷新界面表格
            Init();
        }

        private void EquipmentAbnormalUI_Load(object sender, EventArgs e)
        {
            //刷新表格
            Init();
        }

        private void EquipmentAbnormalUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }


    }
}