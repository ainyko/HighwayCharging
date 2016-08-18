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
    public partial class ChargeRecordUI : Form
    {
        public ChargeRecordUI()
        {
            InitializeComponent();
            if (GlobalVarBLL.Inoutward_all == "出口")
            {
                ChargeProcessingBLL bll = new ChargeProcessingBLL();
                DataTable chargeRecord_dt = null;
                chargeRecord_dt = bll.Query_ChargeRecord();
                this.dataGridView_ChargeRecord.AutoGenerateColumns = false;//不绑定的行不显示
                this.dataGridView_ChargeRecord.DataSource = chargeRecord_dt;
            }
        }
    }
}