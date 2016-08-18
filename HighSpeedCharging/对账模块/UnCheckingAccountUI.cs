using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;

namespace HighWayCharging
{
    public partial class UnCheckingAccountUI : Form
    {
        private int count = 0;//定义记录数
        private int TotalAmount = 0;//总金额
        public UnCheckingAccountUI()
        {
            InitializeComponent();
            ChargeProcessingBLL bll = new ChargeProcessingBLL();
            DataTable UnCheck_dt = null;
            UnCheck_dt = bll.Query_UnCheck();
            this.dataGridView_UnCheck.AutoGenerateColumns = false;//不绑定的行不显示
            this.dataGridView_UnCheck.DataSource = UnCheck_dt;
            
            
            //累计未对账记录数
            for (int i = 0; i < UnCheck_dt.Rows.Count; i++)
            {
                count++;
                TotalAmount = TotalAmount + Convert.ToInt32(this.dataGridView_UnCheck.Rows[i].Cells[11].Value.ToString());
            }
            label_RecordCount.Text = "记录数（条）："+Convert.ToString(count);//显示记录数
            label_TotalAmount.Text = "总金额（元）：" + Convert.ToString(TotalAmount);//显示总金额
        }

        //对账记录保存
        private void button_Save_Click(object sender, EventArgs e)
        {
            string cashier = "";//收费员
            DateTime checktime = DateTime.MinValue;//对账时间
            int totalamount = 0;//对账金额
            int chargecount = 0;//收费记录数
            bool ispay = false;//是否交款
            bool flag_Lane = false;//车道收费对账标志位

            cashier = UserDal.userName;
            checktime = DateTime.Now;
            totalamount = TotalAmount;
            chargecount = count;
            ChargeProcessingBLL bll = new ChargeProcessingBLL();
            flag_Lane = bll.InsertCheckRecord(cashier, checktime, totalamount, chargecount, ispay);
            
            if (flag_Lane)
            {
                MessageBox.Show("对账成功！");
                Change_Reconciliation();
            }
            else
            {
                MessageBox.Show("对账失败！");
                return;
            }
        }

        //关闭窗口
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //把收费记录表中的“是否对账”改为true
        public void Change_Reconciliation()
        {
            string id="";//每一行的主键值
            ChargeProcessingBLL bll = new ChargeProcessingBLL();
            DataTable UnCheck_dt = null;
            UnCheck_dt = bll.Query_UnCheck();
            this.dataGridView_UnCheck.AutoGenerateColumns = false;//不绑定的行不显示
            this.dataGridView_UnCheck.DataSource = UnCheck_dt;
            //改变每一条未对账记录的状态为true
            for (int i = 0; i < UnCheck_dt.Rows.Count; i++)
            {
                id = this.dataGridView_UnCheck.Rows[i].Cells[0].Value.ToString();
                bll.Change_IsCheck(id);
            }
            UnCheck_dt = bll.Query_UnCheck();
            this.dataGridView_UnCheck.AutoGenerateColumns = false;//不绑定的行不显示
            this.dataGridView_UnCheck.DataSource = UnCheck_dt;
        }
    }
}