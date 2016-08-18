using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using Utility;
using System.Threading;//线程
using System.Reflection.Emit;

namespace HighWayCharging
{
    public partial class SystemUserManagerUI : Form
    {
        private SystemUserManagerBLL systemUserManagerBLL = new SystemUserManagerBLL();//
        private Thread hQueryThread;//查询线程的句柄
        private bool bQueryEnb;//查询使能
        const int INTERVEL_TIME = 500;//查询间隔
        private BindingSource viewSBind = new BindingSource();
        private DateTime dt_scroll = DateTime.Now.AddSeconds(-3);//手动滚动的时间点

        private  int passwordColIndex = 2;//根据需要设定你的密码列

        public SystemUserManagerUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Add_Click(object sender, EventArgs e)
        {
            UserManageAddUI userManageAddUI = new UserManageAddUI();
            userManageAddUI.ShowDialog(this);

            //刷新界面表格
            Init();
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Del_Click(object sender, EventArgs e)
        {
            string user = "";

            user = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (DialogResult.OK == MessageBox.Show("确定删除该用户？", "提示", MessageBoxButtons.OKCancel))
                {
                    UserBll userBll = new UserBll();
                    userBll.delUser(user);
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的用户", "提示");
            }

            //刷新界面表格
            Init();
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Modify_Click(object sender, EventArgs e)
        {
            string user = "";
            string password = "";

            user = dataGridView1.CurrentRow.Cells["userName"].Value.ToString();
            password = dataGridView1.CurrentRow.Cells["passWord"].Value.ToString();

            ModifyPasswordUI modifyPasswordUI = new ModifyPasswordUI(user, password);
            modifyPasswordUI.ShowDialog(this);
            //刷新界面表格
            Init();
        }

        private void Init()
        {

            SystemUserManagerBLL systemUserManagerbll = new SystemUserManagerBLL();//
  
            DataTable userDt = systemUserManagerbll.GetSystemUserDtInfo();
            this.dataGridView1.DataSource = userDt;

        }

        private void displayInfo(object obj, System.EventArgs e)
        {
            int SelectRowID = 0;
            int FirstScrollingRowID = 0;
            DataSet ds = (DataSet)obj;

            //解决在创建窗口句柄之前,不能在控件上调用 Invoke 或 BeginInvoke。 
            //if (dataGridView_RTGeoInfo.IsHandleCreated)
            {
                SelectRowID = 0;
                FirstScrollingRowID = 0;
                if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
                {
                    SelectRowID = dataGridView1.SelectedRows[0].Index;
                    FirstScrollingRowID = dataGridView1.FirstDisplayedScrollingRowIndex;
                }

                #region 修复“System.IndexOutOfRangeException: 无法找到表 0”BUG；

                /*if (ds == null || ds.Tables.Count == 0)
                {
                    GC.Collect();//回收空间
                    GC.WaitForPendingFinalizers();
                    return;
                }*/
                #endregion

                //防止越界
                SelectRowID = SelectRowID > ds.Tables[0].Rows.Count ? ds.Tables[0].Rows.Count : SelectRowID;
                FirstScrollingRowID = FirstScrollingRowID > ds.Tables[0].Rows.Count ? ds.Tables[0].Rows.Count : FirstScrollingRowID;

                //直接显示
                viewSBind.DataSource = ds;
                dataGridView1.DataSource = viewSBind;
                dataGridView1.DataMember = "Table";

                //选中旧的
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[SelectRowID].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = FirstScrollingRowID;
                }
                GC.Collect();//回收空间
                GC.WaitForPendingFinalizers();
            }

        }

        private void RefreshInfo()
        {
            //bool bRet;
            DataSet ds = null;

            //try
            //{
            //初始化一些资源
            //bRet = systemUserManagerBLL.InitDatabase();
            //if (bRet == false)
            //{
            //    MessageBox.Show("数据库连接失败，请检查设置！");
            //    return;
            //}
            while (bQueryEnb == true)
            {
                //如果正在手动滚动，直接返回
                DateTime dt = DateTime.Now;
                if (dt.CompareTo(dt_scroll.AddSeconds(+1.5)) <= 0)
                    continue;

                //获取数据源
                ds = systemUserManagerBLL.GetSystemUserDsInfo();
                //填充表格内容
                if ((ds != null))//&& geods.Tables[0].Rows.Count != 0))
                {
                    if (dataGridView1.InvokeRequired)
                    {
                        dataGridView1.Invoke(new System.EventHandler(displayInfo), ds);
                    }
                    else
                    {
                        displayInfo(ds, null);
                    }
                }
                else
                {

                    DebugOutput.ProcessMessage("SystemUserManagerUI :RefreshInfo Reset Database...\r\n");
                }
                GC.Collect();//回收空间
                GC.WaitForPendingFinalizers();
                if (bQueryEnb == true)
                    Thread.Sleep(INTERVEL_TIME);
            }
        }

        private void SystemUserManagerUI_Load(object sender, EventArgs e)
        {
            //bQueryEnb = true;
            //hQueryThread = new Thread(RefreshInfo);
            //hQueryThread.IsBackground = true;  //后台运行
            //hQueryThread.Start();

            //刷新表格
            Init();

        }

        private void SystemUserManagerUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (hQueryThread != null)
            {
                if (hQueryThread.IsAlive == true)
                    Thread.Sleep(1000);
                if (hQueryThread.IsAlive == true)
                    hQueryThread.Abort();
            }
           
        }

        private void SystemUserManagerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //退出时关闭数据库操作
            bQueryEnb = false;
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.SmallIncrement || e.Type == ScrollEventType.SmallDecrement)
            {
                dt_scroll = DateTime.Now;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //int i = this.dataGridView1.CurrentCell.ColumnIndex;
            //if (i == passwordColIndex)
            //{
            //    TextBox txt = e.Control as TextBox;
            //    if (txt != null)
            //    {
            //        txt.UseSystemPasswordChar = true;
            //    }
            //}
        }

        //将密码修改为*****
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //string str = e.Value as string;
            //if (e.ColumnIndex == passwordColIndex)
            //{
            //    e.Value = "".PadLeft(str.Length, '*');
            //}
        }
    }
}