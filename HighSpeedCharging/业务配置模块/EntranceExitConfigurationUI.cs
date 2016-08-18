using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HighWayCharging;
using BLL;

namespace HighWayCharging
{
    public partial class EntranceExitConfigurationUI : Form
    {
        public EntranceExitConfigurationUI()
        {
            InitializeComponent();
        }
        private void EntranceExitConfigurationUI_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void bt_Add_Click(object sender, EventArgs e)
        {
            EntranceExitConfigurationModifyUI CurrentChildForm = new HighWayCharging.EntranceExitConfigurationModifyUI(true);
            CurrentChildForm.Text = "添加进出口收费站";
            CurrentChildForm.ShowDialog();
            Init();
        }
        //刷新进出口收费站列表
        public void Init()
        {
            EntranceExitConfigurationBll bll = new EntranceExitConfigurationBll();
            DataTable tollstation_dt = bll.Query();
            this.dataGridView_Tollstation.DataSource = tollstation_dt;
        }
        //修改进出口收费站列表
        private void bt_Modify_Click(object sender, EventArgs e)
        {
            string id = dataGridView_Tollstation.CurrentRow.Cells[0].Value.ToString();//需要修改的行序号
            string TollstationID = dataGridView_Tollstation.CurrentRow.Cells[1].Value.ToString();
            string TollstationName = dataGridView_Tollstation.CurrentRow.Cells[2].Value.ToString();
            string EntranceLane = dataGridView_Tollstation.CurrentRow.Cells[3].Value.ToString();
            string ExitLane = dataGridView_Tollstation.CurrentRow.Cells[4].Value.ToString();
            string UpstreamID = dataGridView_Tollstation.CurrentRow.Cells[5].Value.ToString();
            string UpstreamName = dataGridView_Tollstation.CurrentRow.Cells[6].Value.ToString();
            string DownstreamID = dataGridView_Tollstation.CurrentRow.Cells[7].Value.ToString();
            string DownstreamName = dataGridView_Tollstation.CurrentRow.Cells[8].Value.ToString();

            EntranceExitConfigurationModifyUI CurrentChildForm = new HighWayCharging.EntranceExitConfigurationModifyUI(id, TollstationID, TollstationName, EntranceLane, ExitLane, UpstreamID, UpstreamName, DownstreamID, DownstreamName,false);
            CurrentChildForm.Text = "修改进出口收费站";
            CurrentChildForm.ShowDialog();
            Init();
        }
        //删除收费站
        private void bt_Delet_Click(object sender, EventArgs e)
        {
            string id = dataGridView_Tollstation.CurrentRow.Cells[0].Value.ToString();//需要删除的收费站行序号
            EntranceExitConfigurationBll bll = new EntranceExitConfigurationBll();
            bool flag = false;
            flag=bll.Delet_TollStation(id);
            if (flag)
            {
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("删除失败，请检查选项配置是否正确！");
            }
            Init();
        }
    }
}