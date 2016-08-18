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
    public partial class CardRecordUI : Form
    {
        public CardRecordUI()
        {
            InitializeComponent();
        }

        //刷新表格
        private void QueryInfo()
        {

            CardRecordBLL cardRecordBLL = new CardRecordBLL();//

            DataTable cardRecordDt = cardRecordBLL.GetCardRecordDtInfo();
            this.dataGridView_SendCardRecord.DataSource = cardRecordDt;
            this.dataGridView_SendCardRecord.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";//设置时间显示格式
            this.dataGridView_SendCardRecord.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";//设置时间显示格式

        }


        private void CardRecordUI_Load(object sender, EventArgs e)
        {
            //刷新表格
            QueryInfo();
        }
    }
}