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
    public partial class CheckingAccountUI : Form
    {
        public CheckingAccountUI()
        {
            InitializeComponent();
            ChargeProcessingBLL bll = new ChargeProcessingBLL();
            DataTable checkinfo_dt = null;
            checkinfo_dt = bll.Query_Checkinfo();
            this.dataGridView_Checkinfo.AutoGenerateColumns = false;//不绑定的行不显示
            this.dataGridView_Checkinfo.DataSource = checkinfo_dt;
        }
    }
}