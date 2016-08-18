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
    public partial class EntranceExitConfigurationModifyUI : Form
    {
        public bool isAdd = false;  //是否新增标志位
        public string Id = "";  //需要修改的序号

        public EntranceExitConfigurationModifyUI()
        {
            InitializeComponent();
        }
        //添加进出口收费站
        public EntranceExitConfigurationModifyUI(bool isAdd)
        {
            InitializeComponent();
            this.isAdd = isAdd;
        }
        //修改进出口收费站
        public EntranceExitConfigurationModifyUI(string id,string TollstationID,string TollstationName,string EntranceLane,string ExitLane,string UpstreamID,string UpstreamName,string DownstreamID,string DownstreamName, bool isAdd)
        {
            InitializeComponent();
            Id = id;
            Init(TollstationID, TollstationName, EntranceLane, ExitLane, UpstreamID, UpstreamName, DownstreamID, DownstreamName);//显示所有要修改的窗口
            this.isAdd = isAdd;
        }
        //显示所有要修改的窗口
        public void Init(string TollstationID, string TollstationName, string EntranceLane, string ExitLane, string UpstreamID, string UpstreamName, string DownstreamID, string DownstreamName)
        {
            this.textBox_TollstationID.Text = TollstationID;
            this.textBox_TollstationName.Text = TollstationName;
            this.textBox_EntranceLane.Text = EntranceLane;
            this.textBox_ExitLane.Text = ExitLane;
            this.textBox_UpstreamID.Text = UpstreamID;
            this.textBox_UpstreamName.Text = UpstreamName;
            this.textBox_DownstreamID.Text = DownstreamID;
            this.textBox_DownstreamName.Text = DownstreamName;
            //禁止修改收费站编号
            this.textBox_TollstationID.Enabled = false;
            //如果上下游的收费站为空，就允许添加收费站，否则就不允许修改上下游收费站编号
            if (this.textBox_UpstreamID.Text == string.Empty)
            {
                this.textBox_UpstreamID.Enabled = true;
            }
            else if (this.textBox_UpstreamID.Text != string.Empty)
            {
                this.textBox_UpstreamID.Enabled = false;
            }
            if (this.textBox_DownstreamID.Text == string.Empty)
            {
                this.textBox_DownstreamID.Enabled = true;
            }
            else if (this.textBox_DownstreamID.Text != string.Empty)
            {
                this.textBox_DownstreamID.Enabled = false;
            }
        }
        private void bt_Save_Click(object sender, EventArgs e)
        {
            bool flag = false;
            
            string TollstationID = this.textBox_TollstationID.Text;
            string TollstationName = this.textBox_TollstationName.Text;
            string EntranceLane = this.textBox_EntranceLane.Text;
            string ExitLane = this.textBox_ExitLane.Text;
            string UpstreamID = this.textBox_UpstreamID.Text;
            string UpstreamName = this.textBox_UpstreamName.Text;
            string DownstreamID = this.textBox_DownstreamID.Text;
            string DownstreamName = this.textBox_DownstreamName.Text;
            
            EntranceExitConfigurationBll bll = new EntranceExitConfigurationBll();

            if (isAdd)
            {
                flag = bll.Add_TollStation(TollstationID, TollstationName, EntranceLane, ExitLane, UpstreamID, UpstreamName,DownstreamID, DownstreamName);
                if (flag)
                {
                    MessageBox.Show("保存成功！");
                }
                else
                    MessageBox.Show("保存失败，请检查选项配置是否正确！");
            }
            else 
            {
                flag = bll.Modify_TollStation(Id, TollstationName, EntranceLane, ExitLane, UpstreamID, UpstreamName, DownstreamID, DownstreamName);
                if (flag)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                    MessageBox.Show("修改失败，请检查选项配置是否正确！");
            }
        }
    }
}