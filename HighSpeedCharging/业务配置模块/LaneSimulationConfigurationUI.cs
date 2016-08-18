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
    public partial class LaneSimulationConfigurationUI : Form
    {
        XmlOperation xmlOperation = new XmlOperation();
        string DemandInterval, QueryInterval, AbnormalInterval;

        public LaneSimulationConfigurationUI()
        {
            InitializeComponent();
        }

        //保存时间间隔
        private void SaveTimInterval_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox_QueryInterval.Text) > 1000)
            {
                MessageBox.Show("车辆到达时间间隔应小于1000");
                return;
            }
            ////需求时间间隔
            DemandInterval = textBox_DemandInterval.Text;
            ////车辆到达时间间隔
            QueryInterval = textBox_QueryInterval.Text;
            ////异常时间间隔
            AbnormalInterval = textBox_AbnormalInterval.Text;
            if (xmlOperation.SaveXmlValue(DemandInterval, QueryInterval, AbnormalInterval))
            {

                MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK);
                ////退出
                this.Close();

            }
            else
            {

                MessageBox.Show("保存失败！", "提示", MessageBoxButtons.OK);
            }
        }

        private void LaneSimulationConfigurationUI_Load(object sender, EventArgs e)
        {
            //加载XML变量
            if (!xmlOperation.ReadXmlValue(out DemandInterval, out QueryInterval, out AbnormalInterval))
                MessageBox.Show("读取配置文件失败！", "提示", MessageBoxButtons.OK);
            // =============时间间隔参数=================//
            textBox_DemandInterval.Text = DemandInterval;
            textBox_QueryInterval.Text = QueryInterval;
            textBox_AbnormalInterval.Text = AbnormalInterval;
            //初始化时间间隔
            GlobalVarBLL.InitGlobalVar();
        }

        private void textBox_DemandInterval_TextChanged(object sender, EventArgs e)
        {

            textBox_AbnormalInterval.Text = (Convert.ToUInt32(textBox_DemandInterval.Text) * 100).ToString();//机率1%
        }
    }
}