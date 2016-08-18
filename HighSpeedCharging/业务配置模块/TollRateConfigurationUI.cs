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
    public partial class TollRateConfigurationUI : Form
    {
        public TollRateConfigurationUI()
        {
            InitializeComponent();
            TollRateConfigurationBLL bll = new TollRateConfigurationBLL();
            DataTable tollrate_dt = bll.Query();
            this.dataGridView_TollRate.AutoGenerateColumns = false;//不绑定的行不显示
            this.dataGridView_TollRate.DataSource = tollrate_dt;
        }
    }
}