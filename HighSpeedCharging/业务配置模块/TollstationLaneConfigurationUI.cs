using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;
using System.Threading;


namespace HighWayCharging
{
    public partial class TollstationLaneConfigurationUI : Form
    {
        public TollstationLaneConfigurationUI()
        {
            InitializeComponent();
            //打开数据库线程
            Thread DBThread = new Thread(DataBaseConnectionBLL.StartDBConnection);
            DBThread.IsBackground = true;
            DBThread.Start();
            
        }
        private void TollstationLaneConfigurationUI_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1000); 
            
            Init_Tollstation();
        }
        //根据收费站查询出入口车道
        private void comboBox_Tollstation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Init_TollstationLane();
        }
        //根据收费站，出入口查询车道
        private void comboBox_EntranceExit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Init_TollstationLane();
        }
        //收费站绑定
        public void Init_Tollstation()
        {
            if (!MySQLHelper.SQLConnectedFlag)
            {
                //MessageBox.Show("数据库打开失败,请核对数据库配置！");
                this.Dispose();
                return;

            }
            TollstationLaneConfigurationBLL bll = new TollstationLaneConfigurationBLL();
            DataTable tollstation_dt = bll.Tollstation_Query();
          
            comboBox_Tollstation.DataSource = tollstation_dt;
            comboBox_Tollstation.DisplayMember = "TollstationName";
            comboBox_Tollstation.ValueMember = "TollstationID";
            string tollstationid=comboBox_Tollstation.SelectedValue.ToString();
            string inoutward=comboBox_EntranceExit.SelectedItem.ToString();
            DataTable tollstation_lane_dt = bll.TollstationLane_Query(tollstationid, inoutward);
            if (tollstation_lane_dt.Rows.Count > 0)
            {
                comboBox_TollstationLane.DataSource = tollstation_lane_dt;
                comboBox_TollstationLane.DisplayMember = "LaneID";
            }
            else
            {
                comboBox_TollstationLane.DataSource=null;
            }
        }
        //车道绑定
        public void Init_TollstationLane()
        {
            TollstationLaneConfigurationBLL bll = new TollstationLaneConfigurationBLL();
            string tollstationid = comboBox_Tollstation.SelectedValue.ToString();
            string inoutward = comboBox_EntranceExit.SelectedItem.ToString();
            DataTable tollstation_lane_dt = bll.TollstationLane_Query(tollstationid, inoutward);
            if (tollstation_lane_dt.Rows.Count > 0)
            {
                comboBox_TollstationLane.DataSource = tollstation_lane_dt;
                comboBox_TollstationLane.DisplayMember = "LaneID";
            }
            else
            {
                comboBox_TollstationLane.DataSource = null;
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            GlobalVarBLL.TollstationName_all = comboBox_Tollstation.Text.ToString();
            GlobalVarBLL.Inoutward_all = comboBox_EntranceExit.SelectedItem.ToString();
            GlobalVarBLL.LaneID_all = comboBox_TollstationLane.Text.ToString();
            if (MessageBox.Show("保存成功", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}