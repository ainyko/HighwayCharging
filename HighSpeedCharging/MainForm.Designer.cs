namespace HighWayCharging
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip_Head = new System.Windows.Forms.MenuStrip();
            this.业务配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收费车道设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进出口设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收费费率更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车道模块配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作员登陆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作员退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设备维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收费对账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.未对账记录查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.对账记录查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.记录查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发卡查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收费查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作日志查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试定时器1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_Info = new System.Windows.Forms.StatusStrip();
            this.toolStripLb_Version = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLb_CarArrivalInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLb_UserLoginInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_CarArriveInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLb_Null = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStriplb_TollStation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStriplb_inoutward = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStriplb_laneId = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLb_DevStateInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStriplb_autoManual = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip_Head = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Tollstation = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Login = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Exit = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel_BackGround = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Charge = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Charge1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Charge3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_ChargeICard = new System.Windows.Forms.Label();
            this.label_ChargeCarLicense = new System.Windows.Forms.Label();
            this.label_ChargeCarLicensePlate = new System.Windows.Forms.Label();
            this.label_EntranceTollstation = new System.Windows.Forms.Label();
            this.label_EntranceTollstationName = new System.Windows.Forms.Label();
            this.label_ChargeICardNum = new System.Windows.Forms.Label();
            this.label_ChargeSendCardTime = new System.Windows.Forms.Label();
            this.lb_ChargeSendCardTime = new System.Windows.Forms.Label();
            this.label_ChargeCarArriveTime = new System.Windows.Forms.Label();
            this.lb_ChargeCarArriveTime = new System.Windows.Forms.Label();
            this.button_Charge = new System.Windows.Forms.Button();
            this.comboBox_ChargeCarType = new System.Windows.Forms.ComboBox();
            this.lb_EntranceCarType = new System.Windows.Forms.Label();
            this.label_ChargeCarType = new System.Windows.Forms.Label();
            this.label_EntranceCarType = new System.Windows.Forms.Label();
            this.tableLayoutPanel_ChargeMode = new System.Windows.Forms.TableLayoutPanel();
            this.label_ChargeMode = new System.Windows.Forms.Label();
            this.bt_ChargeAuto = new System.Windows.Forms.Button();
            this.bt_ChargeManual = new System.Windows.Forms.Button();
            this.tableLayoutPanel__Charge2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_ChargeListInfoNum = new System.Windows.Forms.Label();
            this.label_ChargeListInfoNumber = new System.Windows.Forms.Label();
            this.label_ChargeListInfo = new System.Windows.Forms.Label();
            this.groupBox_Demand = new System.Windows.Forms.GroupBox();
            this.dataGridView_DemandInfo = new System.Windows.Forms.DataGridView();
            this.groupBox_SendCardInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_FirstCarCardID = new System.Windows.Forms.Label();
            this.FirstCarCardID = new System.Windows.Forms.Label();
            this.lb_QueueInfo = new System.Windows.Forms.Label();
            this.lb_QueueCarNum = new System.Windows.Forms.Label();
            this.lb_FirstCarInfo = new System.Windows.Forms.Label();
            this.queueCarCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_SendCarCard = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_CarTpye = new System.Windows.Forms.Label();
            this.comboBox_CarTpye = new System.Windows.Forms.ComboBox();
            this.lb_SendCardInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_SendCardTime = new System.Windows.Forms.Label();
            this.lb_SendICCard = new System.Windows.Forms.Label();
            this.tb_SendICCard = new System.Windows.Forms.TextBox();
            this.lb_SendCardModel = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Auto = new System.Windows.Forms.Button();
            this.bt_Manual = new System.Windows.Forms.Button();
            this.textBox_SendCardTime = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_FirstArriveTime = new System.Windows.Forms.Label();
            this.FirstArriveTime = new System.Windows.Forms.Label();
            this.pictureBox_Tollstation = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.timer_DevAbnormal = new System.Windows.Forms.Timer(this.components);
            this.timer_DemandProduce = new System.Windows.Forms.Timer(this.components);
            this.timer_CarArrive = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_Picture = new System.Windows.Forms.GroupBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectArrEnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectArrExitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntranceStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntranceLane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendCardTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitLane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompleteState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip_Head.SuspendLayout();
            this.statusStrip_Info.SuspendLayout();
            this.toolStrip_Head.SuspendLayout();
            this.tableLayoutPanel_BackGround.SuspendLayout();
            this.groupBox_Charge.SuspendLayout();
            this.tableLayoutPanel_Charge1.SuspendLayout();
            this.tableLayoutPanel_Charge3.SuspendLayout();
            this.tableLayoutPanel_ChargeMode.SuspendLayout();
            this.tableLayoutPanel__Charge2.SuspendLayout();
            this.groupBox_Demand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DemandInfo)).BeginInit();
            this.groupBox_SendCardInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Tollstation)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox_Picture.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Head
            // 
            this.menuStrip_Head.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.业务配置ToolStripMenuItem,
            this.操作员管理ToolStripMenuItem,
            this.收费对账ToolStripMenuItem,
            this.记录查询ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.测试定时器1ToolStripMenuItem});
            this.menuStrip_Head.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Head.Name = "menuStrip_Head";
            this.menuStrip_Head.Size = new System.Drawing.Size(1356, 24);
            this.menuStrip_Head.TabIndex = 0;
            this.menuStrip_Head.Text = "menuStrip1";
            // 
            // 业务配置ToolStripMenuItem
            // 
            this.业务配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.收费车道设置ToolStripMenuItem,
            this.进出口设置ToolStripMenuItem,
            this.收费费率更新ToolStripMenuItem,
            this.车道模块配置ToolStripMenuItem,
            this.数据库配置ToolStripMenuItem});
            this.业务配置ToolStripMenuItem.Name = "业务配置ToolStripMenuItem";
            this.业务配置ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.业务配置ToolStripMenuItem.Text = "业务配置";
            // 
            // 收费车道设置ToolStripMenuItem
            // 
            this.收费车道设置ToolStripMenuItem.Name = "收费车道设置ToolStripMenuItem";
            this.收费车道设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.收费车道设置ToolStripMenuItem.Text = "收费站设置";
            this.收费车道设置ToolStripMenuItem.Click += new System.EventHandler(this.收费站设置ToolStripMenuItem_Click);
            // 
            // 进出口设置ToolStripMenuItem
            // 
            this.进出口设置ToolStripMenuItem.Name = "进出口设置ToolStripMenuItem";
            this.进出口设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.进出口设置ToolStripMenuItem.Text = "进/出口设置";
            this.进出口设置ToolStripMenuItem.Visible = false;
            this.进出口设置ToolStripMenuItem.Click += new System.EventHandler(this.进出口设置ToolStripMenuItem_Click);
            // 
            // 收费费率更新ToolStripMenuItem
            // 
            this.收费费率更新ToolStripMenuItem.Name = "收费费率更新ToolStripMenuItem";
            this.收费费率更新ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.收费费率更新ToolStripMenuItem.Text = "收费费率更新";
            this.收费费率更新ToolStripMenuItem.Click += new System.EventHandler(this.收费费率更新ToolStripMenuItem_Click);
            // 
            // 车道模块配置ToolStripMenuItem
            // 
            this.车道模块配置ToolStripMenuItem.Name = "车道模块配置ToolStripMenuItem";
            this.车道模块配置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.车道模块配置ToolStripMenuItem.Text = "车道模拟配置";
            this.车道模块配置ToolStripMenuItem.Click += new System.EventHandler(this.车道模块配置ToolStripMenuItem_Click);
            // 
            // 数据库配置ToolStripMenuItem
            // 
            this.数据库配置ToolStripMenuItem.Name = "数据库配置ToolStripMenuItem";
            this.数据库配置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.数据库配置ToolStripMenuItem.Text = "数据库配置";
            this.数据库配置ToolStripMenuItem.Click += new System.EventHandler(this.数据库配置ToolStripMenuItem_Click);
            // 
            // 操作员管理ToolStripMenuItem
            // 
            this.操作员管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作员登陆ToolStripMenuItem,
            this.操作员退出ToolStripMenuItem,
            this.系统用户管理ToolStripMenuItem,
            this.设备维护ToolStripMenuItem});
            this.操作员管理ToolStripMenuItem.Name = "操作员管理ToolStripMenuItem";
            this.操作员管理ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.操作员管理ToolStripMenuItem.Text = "操作员管理";
            // 
            // 操作员登陆ToolStripMenuItem
            // 
            this.操作员登陆ToolStripMenuItem.Enabled = false;
            this.操作员登陆ToolStripMenuItem.Name = "操作员登陆ToolStripMenuItem";
            this.操作员登陆ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.操作员登陆ToolStripMenuItem.Text = "操作员登陆";
            this.操作员登陆ToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton_Login_Click);
            // 
            // 操作员退出ToolStripMenuItem
            // 
            this.操作员退出ToolStripMenuItem.Enabled = false;
            this.操作员退出ToolStripMenuItem.Name = "操作员退出ToolStripMenuItem";
            this.操作员退出ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.操作员退出ToolStripMenuItem.Text = "操作员退出";
            this.操作员退出ToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton_Exit_Click);
            // 
            // 系统用户管理ToolStripMenuItem
            // 
            this.系统用户管理ToolStripMenuItem.Name = "系统用户管理ToolStripMenuItem";
            this.系统用户管理ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.系统用户管理ToolStripMenuItem.Text = "系统用户管理";
            this.系统用户管理ToolStripMenuItem.Click += new System.EventHandler(this.系统用户管理ToolStripMenuItem_Click);
            // 
            // 设备维护ToolStripMenuItem
            // 
            this.设备维护ToolStripMenuItem.Name = "设备维护ToolStripMenuItem";
            this.设备维护ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.设备维护ToolStripMenuItem.Text = "设备维护";
            this.设备维护ToolStripMenuItem.Click += new System.EventHandler(this.设备维护ToolStripMenuItem_Click);
            // 
            // 收费对账ToolStripMenuItem
            // 
            this.收费对账ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.未对账记录查询ToolStripMenuItem,
            this.对账记录查询ToolStripMenuItem1});
            this.收费对账ToolStripMenuItem.Name = "收费对账ToolStripMenuItem";
            this.收费对账ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.收费对账ToolStripMenuItem.Text = "收费对账";
            // 
            // 未对账记录查询ToolStripMenuItem
            // 
            this.未对账记录查询ToolStripMenuItem.Name = "未对账记录查询ToolStripMenuItem";
            this.未对账记录查询ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.未对账记录查询ToolStripMenuItem.Text = "未对账收费查询";
            this.未对账记录查询ToolStripMenuItem.Click += new System.EventHandler(this.未对账记录查询ToolStripMenuItem_Click);
            // 
            // 对账记录查询ToolStripMenuItem1
            // 
            this.对账记录查询ToolStripMenuItem1.Name = "对账记录查询ToolStripMenuItem1";
            this.对账记录查询ToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.对账记录查询ToolStripMenuItem1.Text = "对账记录查询";
            this.对账记录查询ToolStripMenuItem1.Click += new System.EventHandler(this.对账记录查询ToolStripMenuItem1_Click);
            // 
            // 记录查询ToolStripMenuItem
            // 
            this.记录查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发卡查询ToolStripMenuItem,
            this.收费查询ToolStripMenuItem,
            this.操作日志查询ToolStripMenuItem});
            this.记录查询ToolStripMenuItem.Name = "记录查询ToolStripMenuItem";
            this.记录查询ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.记录查询ToolStripMenuItem.Text = "记录查询";
            // 
            // 发卡查询ToolStripMenuItem
            // 
            this.发卡查询ToolStripMenuItem.Name = "发卡查询ToolStripMenuItem";
            this.发卡查询ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.发卡查询ToolStripMenuItem.Text = "发卡查询";
            this.发卡查询ToolStripMenuItem.Click += new System.EventHandler(this.发卡查询ToolStripMenuItem_Click);
            // 
            // 收费查询ToolStripMenuItem
            // 
            this.收费查询ToolStripMenuItem.Name = "收费查询ToolStripMenuItem";
            this.收费查询ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.收费查询ToolStripMenuItem.Text = "收费查询";
            this.收费查询ToolStripMenuItem.Click += new System.EventHandler(this.收费查询ToolStripMenuItem_Click);
            // 
            // 操作日志查询ToolStripMenuItem
            // 
            this.操作日志查询ToolStripMenuItem.Name = "操作日志查询ToolStripMenuItem";
            this.操作日志查询ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.操作日志查询ToolStripMenuItem.Text = "操作日志查询";
            this.操作日志查询ToolStripMenuItem.Click += new System.EventHandler(this.操作日志查询ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 测试定时器1ToolStripMenuItem
            // 
            this.测试定时器1ToolStripMenuItem.Name = "测试定时器1ToolStripMenuItem";
            this.测试定时器1ToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.测试定时器1ToolStripMenuItem.Text = "测试定时器1";
            this.测试定时器1ToolStripMenuItem.Visible = false;
            this.测试定时器1ToolStripMenuItem.Click += new System.EventHandler(this.测试定时器1ToolStripMenuItem_Click);
            // 
            // statusStrip_Info
            // 
            this.statusStrip_Info.BackColor = System.Drawing.SystemColors.MenuBar;
            this.statusStrip_Info.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLb_Version,
            this.toolStripLb_CarArrivalInfo,
            this.toolStripLb_UserLoginInfo,
            this.toolStripStatusLabel_CarArriveInfo,
            this.toolStripLb_Null,
            this.toolStriplb_TollStation,
            this.toolStriplb_inoutward,
            this.toolStriplb_laneId,
            this.toolStripLb_DevStateInfo,
            this.toolStriplb_autoManual});
            this.statusStrip_Info.Location = new System.Drawing.Point(0, 557);
            this.statusStrip_Info.Name = "statusStrip_Info";
            this.statusStrip_Info.Size = new System.Drawing.Size(1356, 30);
            this.statusStrip_Info.TabIndex = 1;
            this.statusStrip_Info.Text = "statusStrip1";
            // 
            // toolStripLb_Version
            // 
            this.toolStripLb_Version.AutoSize = false;
            this.toolStripLb_Version.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripLb_Version.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripLb_Version.Name = "toolStripLb_Version";
            this.toolStripLb_Version.Size = new System.Drawing.Size(200, 25);
            this.toolStripLb_Version.Text = "版本：Version 1.0.0.1";
            // 
            // toolStripLb_CarArrivalInfo
            // 
            this.toolStripLb_CarArrivalInfo.AutoSize = false;
            this.toolStripLb_CarArrivalInfo.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripLb_CarArrivalInfo.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripLb_CarArrivalInfo.Name = "toolStripLb_CarArrivalInfo";
            this.toolStripLb_CarArrivalInfo.Size = new System.Drawing.Size(1, 25);
            this.toolStripLb_CarArrivalInfo.Text = "车辆状态";
            // 
            // toolStripLb_UserLoginInfo
            // 
            this.toolStripLb_UserLoginInfo.AutoSize = false;
            this.toolStripLb_UserLoginInfo.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripLb_UserLoginInfo.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripLb_UserLoginInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripLb_UserLoginInfo.Name = "toolStripLb_UserLoginInfo";
            this.toolStripLb_UserLoginInfo.Size = new System.Drawing.Size(150, 25);
            this.toolStripLb_UserLoginInfo.Text = "用户未登录";
            // 
            // toolStripStatusLabel_CarArriveInfo
            // 
            this.toolStripStatusLabel_CarArriveInfo.AutoSize = false;
            this.toolStripStatusLabel_CarArriveInfo.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel_CarArriveInfo.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabel_CarArriveInfo.Name = "toolStripStatusLabel_CarArriveInfo";
            this.toolStripStatusLabel_CarArriveInfo.Size = new System.Drawing.Size(200, 25);
            this.toolStripStatusLabel_CarArriveInfo.Text = "车辆到达显示";
            // 
            // toolStripLb_Null
            // 
            this.toolStripLb_Null.Name = "toolStripLb_Null";
            this.toolStripLb_Null.Size = new System.Drawing.Size(110, 25);
            this.toolStripLb_Null.Spring = true;
            // 
            // toolStriplb_TollStation
            // 
            this.toolStriplb_TollStation.AutoSize = false;
            this.toolStriplb_TollStation.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStriplb_TollStation.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStriplb_TollStation.Name = "toolStriplb_TollStation";
            this.toolStriplb_TollStation.Size = new System.Drawing.Size(180, 25);
            this.toolStriplb_TollStation.Text = "收费站情况";
            // 
            // toolStriplb_inoutward
            // 
            this.toolStriplb_inoutward.AutoSize = false;
            this.toolStriplb_inoutward.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStriplb_inoutward.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStriplb_inoutward.Name = "toolStriplb_inoutward";
            this.toolStriplb_inoutward.Size = new System.Drawing.Size(80, 25);
            this.toolStriplb_inoutward.Text = "出/入口";
            // 
            // toolStriplb_laneId
            // 
            this.toolStriplb_laneId.AutoSize = false;
            this.toolStriplb_laneId.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStriplb_laneId.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStriplb_laneId.Name = "toolStriplb_laneId";
            this.toolStriplb_laneId.Size = new System.Drawing.Size(150, 25);
            this.toolStriplb_laneId.Text = "车道";
            // 
            // toolStripLb_DevStateInfo
            // 
            this.toolStripLb_DevStateInfo.AutoSize = false;
            this.toolStripLb_DevStateInfo.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripLb_DevStateInfo.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripLb_DevStateInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripLb_DevStateInfo.Name = "toolStripLb_DevStateInfo";
            this.toolStripLb_DevStateInfo.Size = new System.Drawing.Size(150, 25);
            this.toolStripLb_DevStateInfo.Text = "设备状态信息";
            // 
            // toolStriplb_autoManual
            // 
            this.toolStriplb_autoManual.AutoSize = false;
            this.toolStriplb_autoManual.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStriplb_autoManual.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStriplb_autoManual.Name = "toolStriplb_autoManual";
            this.toolStriplb_autoManual.Size = new System.Drawing.Size(120, 25);
            this.toolStriplb_autoManual.Text = "自动/半自动";
            // 
            // toolStrip_Head
            // 
            this.toolStrip_Head.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip_Head.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Tollstation,
            this.toolStripButton_Login,
            this.toolStripButton_Exit});
            this.toolStrip_Head.Location = new System.Drawing.Point(0, 24);
            this.toolStrip_Head.Name = "toolStrip_Head";
            this.toolStrip_Head.Size = new System.Drawing.Size(1356, 71);
            this.toolStrip_Head.TabIndex = 2;
            this.toolStrip_Head.Text = "toolStrip1";
            // 
            // toolStripButton_Tollstation
            // 
            this.toolStripButton_Tollstation.Image = global::HighWayCharging.Properties.Resources.tollstation;
            this.toolStripButton_Tollstation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Tollstation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Tollstation.Name = "toolStripButton_Tollstation";
            this.toolStripButton_Tollstation.Size = new System.Drawing.Size(71, 68);
            this.toolStripButton_Tollstation.Text = "收费站设置";
            this.toolStripButton_Tollstation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Tollstation.Click += new System.EventHandler(this.收费站设置ToolStripMenuItem_Click);
            // 
            // toolStripButton_Login
            // 
            this.toolStripButton_Login.Image = global::HighWayCharging.Properties.Resources.open;
            this.toolStripButton_Login.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Login.Name = "toolStripButton_Login";
            this.toolStripButton_Login.Size = new System.Drawing.Size(59, 68);
            this.toolStripButton_Login.Text = "用户登录";
            this.toolStripButton_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Login.Click += new System.EventHandler(this.toolStripButton_Login_Click);
            // 
            // toolStripButton_Exit
            // 
            this.toolStripButton_Exit.AutoSize = false;
            this.toolStripButton_Exit.Image = global::HighWayCharging.Properties.Resources.exit;
            this.toolStripButton_Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Exit.Name = "toolStripButton_Exit";
            this.toolStripButton_Exit.Size = new System.Drawing.Size(68, 68);
            this.toolStripButton_Exit.Text = "用户退出";
            this.toolStripButton_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Exit.Click += new System.EventHandler(this.toolStripButton_Exit_Click);
            // 
            // tableLayoutPanel_BackGround
            // 
            this.tableLayoutPanel_BackGround.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_BackGround.ColumnCount = 2;
            this.tableLayoutPanel_BackGround.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.01768F));
            this.tableLayoutPanel_BackGround.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.98231F));
            this.tableLayoutPanel_BackGround.Controls.Add(this.groupBox_SendCardInfo, 1, 0);
            this.tableLayoutPanel_BackGround.Controls.Add(this.groupBox_Demand, 0, 1);
            this.tableLayoutPanel_BackGround.Controls.Add(this.groupBox_Charge, 0, 0);
            this.tableLayoutPanel_BackGround.Controls.Add(this.groupBox_Picture, 1, 1);
            this.tableLayoutPanel_BackGround.Location = new System.Drawing.Point(0, 95);
            this.tableLayoutPanel_BackGround.Name = "tableLayoutPanel_BackGround";
            this.tableLayoutPanel_BackGround.RowCount = 2;
            this.tableLayoutPanel_BackGround.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_BackGround.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_BackGround.Size = new System.Drawing.Size(1356, 459);
            this.tableLayoutPanel_BackGround.TabIndex = 3;
            // 
            // groupBox_Charge
            // 
            this.groupBox_Charge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Charge.Controls.Add(this.tableLayoutPanel_Charge1);
            this.groupBox_Charge.Enabled = false;
            this.groupBox_Charge.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Charge.Name = "groupBox_Charge";
            this.groupBox_Charge.Size = new System.Drawing.Size(916, 223);
            this.groupBox_Charge.TabIndex = 3;
            this.groupBox_Charge.TabStop = false;
            this.groupBox_Charge.Text = "收费信息发布屏";
            // 
            // tableLayoutPanel_Charge1
            // 
            this.tableLayoutPanel_Charge1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Charge1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_Charge1.ColumnCount = 1;
            this.tableLayoutPanel_Charge1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Charge1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Charge1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Charge1.Controls.Add(this.tableLayoutPanel_Charge3, 0, 1);
            this.tableLayoutPanel_Charge1.Controls.Add(this.tableLayoutPanel__Charge2, 0, 0);
            this.tableLayoutPanel_Charge1.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel_Charge1.Name = "tableLayoutPanel_Charge1";
            this.tableLayoutPanel_Charge1.RowCount = 2;
            this.tableLayoutPanel_Charge1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Charge1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel_Charge1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel_Charge1.Size = new System.Drawing.Size(902, 199);
            this.tableLayoutPanel_Charge1.TabIndex = 4;
            // 
            // tableLayoutPanel_Charge3
            // 
            this.tableLayoutPanel_Charge3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Charge3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_Charge3.ColumnCount = 4;
            this.tableLayoutPanel_Charge3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.17355F));
            this.tableLayoutPanel_Charge3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.82645F));
            this.tableLayoutPanel_Charge3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel_Charge3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 318F));
            this.tableLayoutPanel_Charge3.Controls.Add(this.label_ChargeICard, 0, 0);
            this.tableLayoutPanel_Charge3.Controls.Add(this.label_ChargeCarLicense, 2, 0);
            this.tableLayoutPanel_Charge3.Controls.Add(this.label_ChargeCarLicensePlate, 3, 0);
            this.tableLayoutPanel_Charge3.Controls.Add(this.label_EntranceTollstation, 0, 1);
            this.tableLayoutPanel_Charge3.Controls.Add(this.label_EntranceTollstationName, 1, 1);
            this.tableLayoutPanel_Charge3.Controls.Add(this.label_ChargeICardNum, 1, 0);
            this.tableLayoutPanel_Charge3.Controls.Add(this.label_ChargeSendCardTime, 2, 1);
            this.tableLayoutPanel_Charge3.Controls.Add(this.lb_ChargeSendCardTime, 3, 1);
            this.tableLayoutPanel_Charge3.Controls.Add(this.label_ChargeCarArriveTime, 0, 2);
            this.tableLayoutPanel_Charge3.Controls.Add(this.lb_ChargeCarArriveTime, 1, 2);
            this.tableLayoutPanel_Charge3.Controls.Add(this.button_Charge, 3, 3);
            this.tableLayoutPanel_Charge3.Controls.Add(this.comboBox_ChargeCarType, 1, 3);
            this.tableLayoutPanel_Charge3.Controls.Add(this.lb_EntranceCarType, 3, 2);
            this.tableLayoutPanel_Charge3.Controls.Add(this.label_ChargeCarType, 0, 3);
            this.tableLayoutPanel_Charge3.Controls.Add(this.label_EntranceCarType, 2, 2);
            this.tableLayoutPanel_Charge3.Controls.Add(this.tableLayoutPanel_ChargeMode, 2, 3);
            this.tableLayoutPanel_Charge3.Location = new System.Drawing.Point(4, 36);
            this.tableLayoutPanel_Charge3.Name = "tableLayoutPanel_Charge3";
            this.tableLayoutPanel_Charge3.RowCount = 4;
            this.tableLayoutPanel_Charge3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.18033F));
            this.tableLayoutPanel_Charge3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.tableLayoutPanel_Charge3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel_Charge3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel_Charge3.Size = new System.Drawing.Size(895, 159);
            this.tableLayoutPanel_Charge3.TabIndex = 2;
            // 
            // label_ChargeICard
            // 
            this.label_ChargeICard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ChargeICard.AutoSize = true;
            this.label_ChargeICard.Location = new System.Drawing.Point(4, 1);
            this.label_ChargeICard.Name = "label_ChargeICard";
            this.label_ChargeICard.Size = new System.Drawing.Size(164, 29);
            this.label_ChargeICard.TabIndex = 2;
            this.label_ChargeICard.Text = "IC卡";
            this.label_ChargeICard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ChargeCarLicense
            // 
            this.label_ChargeCarLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ChargeCarLicense.AutoSize = true;
            this.label_ChargeCarLicense.Location = new System.Drawing.Point(352, 1);
            this.label_ChargeCarLicense.Name = "label_ChargeCarLicense";
            this.label_ChargeCarLicense.Size = new System.Drawing.Size(219, 29);
            this.label_ChargeCarLicense.TabIndex = 6;
            this.label_ChargeCarLicense.Text = "车牌";
            this.label_ChargeCarLicense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ChargeCarLicensePlate
            // 
            this.label_ChargeCarLicensePlate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ChargeCarLicensePlate.AutoSize = true;
            this.label_ChargeCarLicensePlate.Location = new System.Drawing.Point(578, 1);
            this.label_ChargeCarLicensePlate.Name = "label_ChargeCarLicensePlate";
            this.label_ChargeCarLicensePlate.Size = new System.Drawing.Size(313, 29);
            this.label_ChargeCarLicensePlate.TabIndex = 7;
            this.label_ChargeCarLicensePlate.Text = "粤E SW121";
            this.label_ChargeCarLicensePlate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_EntranceTollstation
            // 
            this.label_EntranceTollstation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_EntranceTollstation.AutoSize = true;
            this.label_EntranceTollstation.Location = new System.Drawing.Point(4, 31);
            this.label_EntranceTollstation.Name = "label_EntranceTollstation";
            this.label_EntranceTollstation.Size = new System.Drawing.Size(164, 30);
            this.label_EntranceTollstation.TabIndex = 8;
            this.label_EntranceTollstation.Text = "入口收费站";
            this.label_EntranceTollstation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_EntranceTollstationName
            // 
            this.label_EntranceTollstationName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_EntranceTollstationName.AutoSize = true;
            this.label_EntranceTollstationName.Location = new System.Drawing.Point(175, 31);
            this.label_EntranceTollstationName.Name = "label_EntranceTollstationName";
            this.label_EntranceTollstationName.Size = new System.Drawing.Size(170, 30);
            this.label_EntranceTollstationName.TabIndex = 9;
            this.label_EntranceTollstationName.Text = "鱼窝头";
            this.label_EntranceTollstationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ChargeICardNum
            // 
            this.label_ChargeICardNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ChargeICardNum.AutoSize = true;
            this.label_ChargeICardNum.Location = new System.Drawing.Point(175, 1);
            this.label_ChargeICardNum.Name = "label_ChargeICardNum";
            this.label_ChargeICardNum.Size = new System.Drawing.Size(170, 29);
            this.label_ChargeICardNum.TabIndex = 10;
            this.label_ChargeICardNum.Text = "IC 20151015";
            this.label_ChargeICardNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ChargeSendCardTime
            // 
            this.label_ChargeSendCardTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ChargeSendCardTime.AutoSize = true;
            this.label_ChargeSendCardTime.Location = new System.Drawing.Point(352, 31);
            this.label_ChargeSendCardTime.Name = "label_ChargeSendCardTime";
            this.label_ChargeSendCardTime.Size = new System.Drawing.Size(219, 30);
            this.label_ChargeSendCardTime.TabIndex = 11;
            this.label_ChargeSendCardTime.Text = "发卡时间";
            this.label_ChargeSendCardTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ChargeSendCardTime
            // 
            this.lb_ChargeSendCardTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ChargeSendCardTime.AutoSize = true;
            this.lb_ChargeSendCardTime.Location = new System.Drawing.Point(578, 31);
            this.lb_ChargeSendCardTime.Name = "lb_ChargeSendCardTime";
            this.lb_ChargeSendCardTime.Size = new System.Drawing.Size(313, 30);
            this.lb_ChargeSendCardTime.TabIndex = 12;
            this.lb_ChargeSendCardTime.Text = "2015-10-15 15:12:23";
            this.lb_ChargeSendCardTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ChargeCarArriveTime
            // 
            this.label_ChargeCarArriveTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ChargeCarArriveTime.AutoSize = true;
            this.label_ChargeCarArriveTime.Location = new System.Drawing.Point(4, 62);
            this.label_ChargeCarArriveTime.Name = "label_ChargeCarArriveTime";
            this.label_ChargeCarArriveTime.Size = new System.Drawing.Size(164, 34);
            this.label_ChargeCarArriveTime.TabIndex = 13;
            this.label_ChargeCarArriveTime.Text = "到达时间";
            this.label_ChargeCarArriveTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ChargeCarArriveTime
            // 
            this.lb_ChargeCarArriveTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ChargeCarArriveTime.AutoSize = true;
            this.lb_ChargeCarArriveTime.Location = new System.Drawing.Point(175, 62);
            this.lb_ChargeCarArriveTime.Name = "lb_ChargeCarArriveTime";
            this.lb_ChargeCarArriveTime.Size = new System.Drawing.Size(170, 34);
            this.lb_ChargeCarArriveTime.TabIndex = 14;
            this.lb_ChargeCarArriveTime.Text = "2015-11-17 17:00:00";
            this.lb_ChargeCarArriveTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Charge
            // 
            this.button_Charge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Charge.Location = new System.Drawing.Point(578, 100);
            this.button_Charge.Name = "button_Charge";
            this.button_Charge.Size = new System.Drawing.Size(313, 55);
            this.button_Charge.TabIndex = 20;
            this.button_Charge.Text = "收费";
            this.button_Charge.UseVisualStyleBackColor = true;
            this.button_Charge.Click += new System.EventHandler(this.button_Charge_Click);
            // 
            // comboBox_ChargeCarType
            // 
            this.comboBox_ChargeCarType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ChargeCarType.FormattingEnabled = true;
            this.comboBox_ChargeCarType.Items.AddRange(new object[] {
            "小客货Ⅰ型",
            "小客货Ⅱ型",
            "中客货Ⅲ型",
            "大客货Ⅳ型",
            "特客货Ⅴ型",
            "特货Ⅵ型",
            "超货Ⅶ型"});
            this.comboBox_ChargeCarType.Location = new System.Drawing.Point(175, 100);
            this.comboBox_ChargeCarType.Name = "comboBox_ChargeCarType";
            this.comboBox_ChargeCarType.Size = new System.Drawing.Size(170, 20);
            this.comboBox_ChargeCarType.TabIndex = 16;
            this.comboBox_ChargeCarType.Text = "小客货Ⅰ型";
            // 
            // lb_EntranceCarType
            // 
            this.lb_EntranceCarType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_EntranceCarType.AutoSize = true;
            this.lb_EntranceCarType.Location = new System.Drawing.Point(578, 62);
            this.lb_EntranceCarType.Name = "lb_EntranceCarType";
            this.lb_EntranceCarType.Size = new System.Drawing.Size(313, 34);
            this.lb_EntranceCarType.TabIndex = 17;
            this.lb_EntranceCarType.Text = "Ⅰ型";
            this.lb_EntranceCarType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ChargeCarType
            // 
            this.label_ChargeCarType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ChargeCarType.AutoSize = true;
            this.label_ChargeCarType.Location = new System.Drawing.Point(4, 97);
            this.label_ChargeCarType.Name = "label_ChargeCarType";
            this.label_ChargeCarType.Size = new System.Drawing.Size(164, 61);
            this.label_ChargeCarType.TabIndex = 15;
            this.label_ChargeCarType.Text = "出口车型";
            this.label_ChargeCarType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_EntranceCarType
            // 
            this.label_EntranceCarType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_EntranceCarType.AutoSize = true;
            this.label_EntranceCarType.Location = new System.Drawing.Point(352, 62);
            this.label_EntranceCarType.Name = "label_EntranceCarType";
            this.label_EntranceCarType.Size = new System.Drawing.Size(219, 34);
            this.label_EntranceCarType.TabIndex = 18;
            this.label_EntranceCarType.Text = "入口车型";
            this.label_EntranceCarType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_ChargeMode
            // 
            this.tableLayoutPanel_ChargeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_ChargeMode.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_ChargeMode.ColumnCount = 3;
            this.tableLayoutPanel_ChargeMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.18518F));
            this.tableLayoutPanel_ChargeMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.81482F));
            this.tableLayoutPanel_ChargeMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel_ChargeMode.Controls.Add(this.label_ChargeMode, 0, 0);
            this.tableLayoutPanel_ChargeMode.Controls.Add(this.bt_ChargeAuto, 1, 0);
            this.tableLayoutPanel_ChargeMode.Controls.Add(this.bt_ChargeManual, 2, 0);
            this.tableLayoutPanel_ChargeMode.Location = new System.Drawing.Point(352, 100);
            this.tableLayoutPanel_ChargeMode.Name = "tableLayoutPanel_ChargeMode";
            this.tableLayoutPanel_ChargeMode.RowCount = 1;
            this.tableLayoutPanel_ChargeMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ChargeMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ChargeMode.Size = new System.Drawing.Size(219, 55);
            this.tableLayoutPanel_ChargeMode.TabIndex = 21;
            // 
            // label_ChargeMode
            // 
            this.label_ChargeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ChargeMode.AutoSize = true;
            this.label_ChargeMode.Location = new System.Drawing.Point(4, 1);
            this.label_ChargeMode.Name = "label_ChargeMode";
            this.label_ChargeMode.Size = new System.Drawing.Size(38, 53);
            this.label_ChargeMode.TabIndex = 7;
            this.label_ChargeMode.Text = "收费模式";
            this.label_ChargeMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_ChargeAuto
            // 
            this.bt_ChargeAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_ChargeAuto.Location = new System.Drawing.Point(49, 4);
            this.bt_ChargeAuto.Name = "bt_ChargeAuto";
            this.bt_ChargeAuto.Size = new System.Drawing.Size(48, 47);
            this.bt_ChargeAuto.TabIndex = 1;
            this.bt_ChargeAuto.Text = "自动";
            this.bt_ChargeAuto.UseVisualStyleBackColor = true;
            // 
            // bt_ChargeManual
            // 
            this.bt_ChargeManual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_ChargeManual.Location = new System.Drawing.Point(104, 4);
            this.bt_ChargeManual.Name = "bt_ChargeManual";
            this.bt_ChargeManual.Size = new System.Drawing.Size(111, 47);
            this.bt_ChargeManual.TabIndex = 2;
            this.bt_ChargeManual.Text = "手动";
            this.bt_ChargeManual.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel__Charge2
            // 
            this.tableLayoutPanel__Charge2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel__Charge2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel__Charge2.ColumnCount = 3;
            this.tableLayoutPanel__Charge2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.39249F));
            this.tableLayoutPanel__Charge2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.60751F));
            this.tableLayoutPanel__Charge2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 356F));
            this.tableLayoutPanel__Charge2.Controls.Add(this.label_ChargeListInfoNum, 0, 0);
            this.tableLayoutPanel__Charge2.Controls.Add(this.label_ChargeListInfoNumber, 0, 0);
            this.tableLayoutPanel__Charge2.Controls.Add(this.label_ChargeListInfo, 0, 0);
            this.tableLayoutPanel__Charge2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel__Charge2.Name = "tableLayoutPanel__Charge2";
            this.tableLayoutPanel__Charge2.RowCount = 1;
            this.tableLayoutPanel__Charge2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel__Charge2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel__Charge2.Size = new System.Drawing.Size(895, 25);
            this.tableLayoutPanel__Charge2.TabIndex = 0;
            // 
            // label_ChargeListInfoNum
            // 
            this.label_ChargeListInfoNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ChargeListInfoNum.AutoSize = true;
            this.label_ChargeListInfoNum.Location = new System.Drawing.Point(540, 1);
            this.label_ChargeListInfoNum.Name = "label_ChargeListInfoNum";
            this.label_ChargeListInfoNum.Size = new System.Drawing.Size(351, 23);
            this.label_ChargeListInfoNum.TabIndex = 12;
            this.label_ChargeListInfoNum.Text = "0";
            this.label_ChargeListInfoNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ChargeListInfoNumber
            // 
            this.label_ChargeListInfoNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ChargeListInfoNumber.AutoSize = true;
            this.label_ChargeListInfoNumber.Location = new System.Drawing.Point(247, 1);
            this.label_ChargeListInfoNumber.Name = "label_ChargeListInfoNumber";
            this.label_ChargeListInfoNumber.Size = new System.Drawing.Size(286, 23);
            this.label_ChargeListInfoNumber.TabIndex = 9;
            this.label_ChargeListInfoNumber.Text = "排队车辆数(辆)：";
            this.label_ChargeListInfoNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ChargeListInfo
            // 
            this.label_ChargeListInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ChargeListInfo.Location = new System.Drawing.Point(4, 1);
            this.label_ChargeListInfo.Name = "label_ChargeListInfo";
            this.label_ChargeListInfo.Size = new System.Drawing.Size(236, 23);
            this.label_ChargeListInfo.TabIndex = 8;
            this.label_ChargeListInfo.Text = "收费车辆排队信息：";
            this.label_ChargeListInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Demand
            // 
            this.groupBox_Demand.Controls.Add(this.dataGridView_DemandInfo);
            this.groupBox_Demand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Demand.Location = new System.Drawing.Point(3, 232);
            this.groupBox_Demand.Name = "groupBox_Demand";
            this.groupBox_Demand.Size = new System.Drawing.Size(916, 224);
            this.groupBox_Demand.TabIndex = 0;
            this.groupBox_Demand.TabStop = false;
            this.groupBox_Demand.Text = "需求信息";
            // 
            // dataGridView_DemandInfo
            // 
            this.dataGridView_DemandInfo.AllowUserToAddRows = false;
            this.dataGridView_DemandInfo.AllowUserToDeleteRows = false;
            this.dataGridView_DemandInfo.AllowUserToResizeRows = false;
            this.dataGridView_DemandInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_DemandInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DemandInfo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DemandInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_DemandInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_DemandInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CarNum,
            this.CarType,
            this.ExpectArrEnTime,
            this.ExpectArrExitTime,
            this.EntranceStation,
            this.EntranceLane,
            this.SendCardTime,
            this.ExitStation,
            this.ExitLane,
            this.CompleteState});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_DemandInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_DemandInfo.Location = new System.Drawing.Point(6, 18);
            this.dataGridView_DemandInfo.MultiSelect = false;
            this.dataGridView_DemandInfo.Name = "dataGridView_DemandInfo";
            this.dataGridView_DemandInfo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DemandInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_DemandInfo.RowHeadersVisible = false;
            this.dataGridView_DemandInfo.RowTemplate.Height = 23;
            this.dataGridView_DemandInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DemandInfo.Size = new System.Drawing.Size(902, 198);
            this.dataGridView_DemandInfo.TabIndex = 81;
            this.dataGridView_DemandInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DemandInfo_CellClick);
            this.dataGridView_DemandInfo.SelectionChanged += new System.EventHandler(this.dataGridView_DemandInfo_SelectionChanged);
            // 
            // groupBox_SendCardInfo
            // 
            this.groupBox_SendCardInfo.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_SendCardInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_SendCardInfo.Enabled = false;
            this.groupBox_SendCardInfo.Location = new System.Drawing.Point(925, 3);
            this.groupBox_SendCardInfo.Name = "groupBox_SendCardInfo";
            this.groupBox_SendCardInfo.Size = new System.Drawing.Size(428, 223);
            this.groupBox_SendCardInfo.TabIndex = 1;
            this.groupBox_SendCardInfo.TabStop = false;
            this.groupBox_SendCardInfo.Text = "发卡信息发布屏";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_QueueInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_QueueCarNum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_FirstCarInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.queueCarCount, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_SendCardInfo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 197);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.27184F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.72816F));
            this.tableLayoutPanel3.Controls.Add(this.lb_FirstCarCardID, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.FirstCarCardID, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(275, 28);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(136, 48);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // lb_FirstCarCardID
            // 
            this.lb_FirstCarCardID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_FirstCarCardID.AutoSize = true;
            this.lb_FirstCarCardID.Location = new System.Drawing.Point(4, 1);
            this.lb_FirstCarCardID.Name = "lb_FirstCarCardID";
            this.lb_FirstCarCardID.Size = new System.Drawing.Size(26, 46);
            this.lb_FirstCarCardID.TabIndex = 1;
            this.lb_FirstCarCardID.Text = "车牌";
            this.lb_FirstCarCardID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstCarCardID
            // 
            this.FirstCarCardID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstCarCardID.AutoSize = true;
            this.FirstCarCardID.Location = new System.Drawing.Point(37, 1);
            this.FirstCarCardID.Name = "FirstCarCardID";
            this.FirstCarCardID.Size = new System.Drawing.Size(95, 46);
            this.FirstCarCardID.TabIndex = 2;
            this.FirstCarCardID.Text = "粤E SW121";
            this.FirstCarCardID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_QueueInfo
            // 
            this.lb_QueueInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_QueueInfo.Location = new System.Drawing.Point(4, 1);
            this.lb_QueueInfo.Name = "lb_QueueInfo";
            this.lb_QueueInfo.Size = new System.Drawing.Size(89, 23);
            this.lb_QueueInfo.TabIndex = 7;
            this.lb_QueueInfo.Text = "车辆排队信息：";
            this.lb_QueueInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_QueueCarNum
            // 
            this.lb_QueueCarNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_QueueCarNum.AutoSize = true;
            this.lb_QueueCarNum.Location = new System.Drawing.Point(100, 1);
            this.lb_QueueCarNum.Name = "lb_QueueCarNum";
            this.lb_QueueCarNum.Size = new System.Drawing.Size(168, 23);
            this.lb_QueueCarNum.TabIndex = 5;
            this.lb_QueueCarNum.Text = "排队车辆数(辆)：";
            this.lb_QueueCarNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_FirstCarInfo
            // 
            this.lb_FirstCarInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_FirstCarInfo.AutoSize = true;
            this.lb_FirstCarInfo.Location = new System.Drawing.Point(4, 25);
            this.lb_FirstCarInfo.Name = "lb_FirstCarInfo";
            this.lb_FirstCarInfo.Size = new System.Drawing.Size(89, 54);
            this.lb_FirstCarInfo.TabIndex = 8;
            this.lb_FirstCarInfo.Text = "第一辆车信息：";
            this.lb_FirstCarInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // queueCarCount
            // 
            this.queueCarCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.queueCarCount.AutoSize = true;
            this.queueCarCount.Location = new System.Drawing.Point(275, 1);
            this.queueCarCount.Name = "queueCarCount";
            this.queueCarCount.Size = new System.Drawing.Size(136, 23);
            this.queueCarCount.TabIndex = 11;
            this.queueCarCount.Text = "0";
            this.queueCarCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.bt_SendCarCard, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(275, 83);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.56097F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.43903F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(136, 110);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // bt_SendCarCard
            // 
            this.bt_SendCarCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_SendCarCard.Location = new System.Drawing.Point(4, 55);
            this.bt_SendCarCard.Name = "bt_SendCarCard";
            this.bt_SendCarCard.Size = new System.Drawing.Size(128, 51);
            this.bt_SendCarCard.TabIndex = 1;
            this.bt_SendCarCard.Text = "发卡";
            this.bt_SendCarCard.UseVisualStyleBackColor = true;
            this.bt_SendCarCard.Click += new System.EventHandler(this.bt_SendCarCard_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.lb_CarTpye, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.comboBox_CarTpye, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(128, 44);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // lb_CarTpye
            // 
            this.lb_CarTpye.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_CarTpye.AutoSize = true;
            this.lb_CarTpye.Location = new System.Drawing.Point(4, 1);
            this.lb_CarTpye.Name = "lb_CarTpye";
            this.lb_CarTpye.Size = new System.Drawing.Size(120, 17);
            this.lb_CarTpye.TabIndex = 1;
            this.lb_CarTpye.Text = "车型";
            this.lb_CarTpye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_CarTpye
            // 
            this.comboBox_CarTpye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_CarTpye.FormattingEnabled = true;
            this.comboBox_CarTpye.Items.AddRange(new object[] {
            "小客货Ⅰ型",
            "小客货Ⅱ型",
            "中客货Ⅲ型",
            "大客货Ⅳ型",
            "特客货Ⅴ型",
            "特货Ⅵ型",
            "超货Ⅶ型"});
            this.comboBox_CarTpye.Location = new System.Drawing.Point(4, 22);
            this.comboBox_CarTpye.Name = "comboBox_CarTpye";
            this.comboBox_CarTpye.Size = new System.Drawing.Size(120, 20);
            this.comboBox_CarTpye.TabIndex = 2;
            // 
            // lb_SendCardInfo
            // 
            this.lb_SendCardInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SendCardInfo.AutoSize = true;
            this.lb_SendCardInfo.Location = new System.Drawing.Point(4, 80);
            this.lb_SendCardInfo.Name = "lb_SendCardInfo";
            this.lb_SendCardInfo.Size = new System.Drawing.Size(89, 116);
            this.lb_SendCardInfo.TabIndex = 13;
            this.lb_SendCardInfo.Text = "发卡信息：";
            this.lb_SendCardInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.15569F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.84431F));
            this.tableLayoutPanel5.Controls.Add(this.lb_SendCardTime, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lb_SendICCard, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tb_SendICCard, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lb_SendCardModel, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.textBox_SendCardTime, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(100, 83);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.38095F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(168, 110);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // lb_SendCardTime
            // 
            this.lb_SendCardTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SendCardTime.AutoSize = true;
            this.lb_SendCardTime.Location = new System.Drawing.Point(4, 31);
            this.lb_SendCardTime.Name = "lb_SendCardTime";
            this.lb_SendCardTime.Size = new System.Drawing.Size(30, 32);
            this.lb_SendCardTime.TabIndex = 2;
            this.lb_SendCardTime.Text = "发卡时间";
            this.lb_SendCardTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_SendICCard
            // 
            this.lb_SendICCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SendICCard.AutoSize = true;
            this.lb_SendICCard.Location = new System.Drawing.Point(4, 1);
            this.lb_SendICCard.Name = "lb_SendICCard";
            this.lb_SendICCard.Size = new System.Drawing.Size(30, 29);
            this.lb_SendICCard.TabIndex = 1;
            this.lb_SendICCard.Text = "IC卡";
            this.lb_SendICCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_SendICCard
            // 
            this.tb_SendICCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SendICCard.Location = new System.Drawing.Point(41, 4);
            this.tb_SendICCard.Name = "tb_SendICCard";
            this.tb_SendICCard.Size = new System.Drawing.Size(123, 21);
            this.tb_SendICCard.TabIndex = 4;
            this.tb_SendICCard.Text = "IC 20151015";
            this.tb_SendICCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_SendCardModel
            // 
            this.lb_SendCardModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SendCardModel.AutoSize = true;
            this.lb_SendCardModel.Location = new System.Drawing.Point(4, 64);
            this.lb_SendCardModel.Name = "lb_SendCardModel";
            this.lb_SendCardModel.Size = new System.Drawing.Size(30, 45);
            this.lb_SendCardModel.TabIndex = 6;
            this.lb_SendCardModel.Text = "发卡模式";
            this.lb_SendCardModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.bt_Auto, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.bt_Manual, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(41, 67);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(123, 39);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // bt_Auto
            // 
            this.bt_Auto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Auto.Location = new System.Drawing.Point(3, 3);
            this.bt_Auto.Name = "bt_Auto";
            this.bt_Auto.Size = new System.Drawing.Size(55, 33);
            this.bt_Auto.TabIndex = 0;
            this.bt_Auto.Text = "自动";
            this.bt_Auto.UseVisualStyleBackColor = true;
            this.bt_Auto.Click += new System.EventHandler(this.bt_Auto_Click);
            // 
            // bt_Manual
            // 
            this.bt_Manual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Manual.Location = new System.Drawing.Point(64, 3);
            this.bt_Manual.Name = "bt_Manual";
            this.bt_Manual.Size = new System.Drawing.Size(56, 33);
            this.bt_Manual.TabIndex = 1;
            this.bt_Manual.Text = "手动";
            this.bt_Manual.UseVisualStyleBackColor = true;
            this.bt_Manual.Click += new System.EventHandler(this.bt_Manual_Click);
            // 
            // textBox_SendCardTime
            // 
            this.textBox_SendCardTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SendCardTime.Location = new System.Drawing.Point(41, 34);
            this.textBox_SendCardTime.Name = "textBox_SendCardTime";
            this.textBox_SendCardTime.Size = new System.Drawing.Size(123, 21);
            this.textBox_SendCardTime.TabIndex = 8;
            this.textBox_SendCardTime.Text = "2015-10-10 19:40:15";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.27273F));
            this.tableLayoutPanel7.Controls.Add(this.lb_FirstArriveTime, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.FirstArriveTime, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(100, 28);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(168, 48);
            this.tableLayoutPanel7.TabIndex = 17;
            // 
            // lb_FirstArriveTime
            // 
            this.lb_FirstArriveTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_FirstArriveTime.AutoSize = true;
            this.lb_FirstArriveTime.Location = new System.Drawing.Point(4, 1);
            this.lb_FirstArriveTime.Name = "lb_FirstArriveTime";
            this.lb_FirstArriveTime.Size = new System.Drawing.Size(31, 46);
            this.lb_FirstArriveTime.TabIndex = 3;
            this.lb_FirstArriveTime.Text = "到达时间";
            this.lb_FirstArriveTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstArriveTime
            // 
            this.FirstArriveTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstArriveTime.AutoSize = true;
            this.FirstArriveTime.Location = new System.Drawing.Point(42, 1);
            this.FirstArriveTime.Name = "FirstArriveTime";
            this.FirstArriveTime.Size = new System.Drawing.Size(122, 46);
            this.FirstArriveTime.TabIndex = 4;
            this.FirstArriveTime.Text = "2015-10-15 15:12:23";
            this.FirstArriveTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Tollstation
            // 
            this.pictureBox_Tollstation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Tollstation.Image = global::HighWayCharging.Properties.Resources.TollstationUI;
            this.pictureBox_Tollstation.Location = new System.Drawing.Point(6, 18);
            this.pictureBox_Tollstation.Name = "pictureBox_Tollstation";
            this.pictureBox_Tollstation.Size = new System.Drawing.Size(412, 198);
            this.pictureBox_Tollstation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Tollstation.TabIndex = 4;
            this.pictureBox_Tollstation.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 77);
            this.label5.TabIndex = 2;
            this.label5.Text = "到达时间";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(4, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "车牌";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.27184F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.72816F));
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(4, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "车牌";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_DevAbnormal
            // 
            this.timer_DevAbnormal.Tick += new System.EventHandler(this.timer_DevAbnormal_Tick);
            // 
            // timer_DemandProduce
            // 
            this.timer_DemandProduce.Tick += new System.EventHandler(this.timer_DemandProduce_Tick);
            // 
            // timer_CarArrive
            // 
            this.timer_CarArrive.Enabled = true;
            this.timer_CarArrive.Tick += new System.EventHandler(this.timer_CarArrive_Tick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Picture
            // 
            this.groupBox_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Picture.Controls.Add(this.pictureBox_Tollstation);
            this.groupBox_Picture.Location = new System.Drawing.Point(925, 232);
            this.groupBox_Picture.Name = "groupBox_Picture";
            this.groupBox_Picture.Size = new System.Drawing.Size(428, 224);
            this.groupBox_Picture.TabIndex = 4;
            this.groupBox_Picture.TabStop = false;
            this.groupBox_Picture.Text = "高速公路车道收费软件";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 83.67981F;
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CarNum
            // 
            this.CarNum.DataPropertyName = "CarNum";
            this.CarNum.FillWeight = 87.67908F;
            this.CarNum.HeaderText = "车牌";
            this.CarNum.Name = "CarNum";
            this.CarNum.ReadOnly = true;
            this.CarNum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CarType
            // 
            this.CarType.DataPropertyName = "CarType";
            this.CarType.FillWeight = 89.44173F;
            this.CarType.HeaderText = "车型";
            this.CarType.Name = "CarType";
            this.CarType.ReadOnly = true;
            // 
            // ExpectArrEnTime
            // 
            this.ExpectArrEnTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ExpectArrEnTime.DataPropertyName = "ExpectArrEnTime";
            this.ExpectArrEnTime.HeaderText = "预计到达入口时间";
            this.ExpectArrEnTime.MaxInputLength = 65535;
            this.ExpectArrEnTime.Name = "ExpectArrEnTime";
            this.ExpectArrEnTime.ReadOnly = true;
            this.ExpectArrEnTime.Width = 130;
            // 
            // ExpectArrExitTime
            // 
            this.ExpectArrExitTime.DataPropertyName = "ExpectArrExitTime";
            this.ExpectArrExitTime.FillWeight = 179.1044F;
            this.ExpectArrExitTime.HeaderText = "预计到达出口时间";
            this.ExpectArrExitTime.Name = "ExpectArrExitTime";
            this.ExpectArrExitTime.ReadOnly = true;
            // 
            // EntranceStation
            // 
            this.EntranceStation.DataPropertyName = "EntranceStation";
            this.EntranceStation.FillWeight = 92.28439F;
            this.EntranceStation.HeaderText = "入口站";
            this.EntranceStation.Name = "EntranceStation";
            this.EntranceStation.ReadOnly = true;
            // 
            // EntranceLane
            // 
            this.EntranceLane.DataPropertyName = "EntranceLane";
            this.EntranceLane.FillWeight = 93.86948F;
            this.EntranceLane.HeaderText = "入口车道";
            this.EntranceLane.Name = "EntranceLane";
            this.EntranceLane.ReadOnly = true;
            // 
            // SendCardTime
            // 
            this.SendCardTime.DataPropertyName = "SendCardTime";
            this.SendCardTime.FillWeight = 93.07443F;
            this.SendCardTime.HeaderText = "发卡时间";
            this.SendCardTime.Name = "SendCardTime";
            this.SendCardTime.ReadOnly = true;
            // 
            // ExitStation
            // 
            this.ExitStation.DataPropertyName = "ExitStation";
            this.ExitStation.FillWeight = 95.10165F;
            this.ExitStation.HeaderText = "出口站";
            this.ExitStation.Name = "ExitStation";
            this.ExitStation.ReadOnly = true;
            // 
            // ExitLane
            // 
            this.ExitLane.DataPropertyName = "ExitLane";
            this.ExitLane.FillWeight = 94.39445F;
            this.ExitLane.HeaderText = "出口车道";
            this.ExitLane.Name = "ExitLane";
            this.ExitLane.ReadOnly = true;
            // 
            // CompleteState
            // 
            this.CompleteState.DataPropertyName = "CompleteState";
            this.CompleteState.FillWeight = 91.3704F;
            this.CompleteState.HeaderText = "完成状态";
            this.CompleteState.Name = "CompleteState";
            this.CompleteState.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1356, 587);
            this.Controls.Add(this.tableLayoutPanel_BackGround);
            this.Controls.Add(this.toolStrip_Head);
            this.Controls.Add(this.statusStrip_Info);
            this.Controls.Add(this.menuStrip_Head);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Head;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "高速公路车道收费软件";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip_Head.ResumeLayout(false);
            this.menuStrip_Head.PerformLayout();
            this.statusStrip_Info.ResumeLayout(false);
            this.statusStrip_Info.PerformLayout();
            this.toolStrip_Head.ResumeLayout(false);
            this.toolStrip_Head.PerformLayout();
            this.tableLayoutPanel_BackGround.ResumeLayout(false);
            this.groupBox_Charge.ResumeLayout(false);
            this.tableLayoutPanel_Charge1.ResumeLayout(false);
            this.tableLayoutPanel_Charge3.ResumeLayout(false);
            this.tableLayoutPanel_Charge3.PerformLayout();
            this.tableLayoutPanel_ChargeMode.ResumeLayout(false);
            this.tableLayoutPanel_ChargeMode.PerformLayout();
            this.tableLayoutPanel__Charge2.ResumeLayout(false);
            this.tableLayoutPanel__Charge2.PerformLayout();
            this.groupBox_Demand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DemandInfo)).EndInit();
            this.groupBox_SendCardInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Tollstation)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox_Picture.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Head;
        private System.Windows.Forms.ToolStripMenuItem 业务配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收费对账ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 记录查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip_Info;
        private System.Windows.Forms.ToolStripMenuItem 操作员登陆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作员退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发卡查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收费查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作日志查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进出口设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收费费率更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车道模块配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip_Head;
        private System.Windows.Forms.ToolStripButton toolStripButton_Login;
        private System.Windows.Forms.ToolStripButton toolStripButton_Exit;
        private System.Windows.Forms.ToolStripMenuItem 未对账记录查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 对账记录查询ToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_BackGround;
        private System.Windows.Forms.GroupBox groupBox_Demand;
        private System.Windows.Forms.DataGridView dataGridView_DemandInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLb_Version;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLb_UserLoginInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLb_CarArrivalInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLb_DevStateInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLb_Null;
        private System.Windows.Forms.GroupBox groupBox_SendCardInfo;
        private System.Windows.Forms.Button bt_SendCarCard;
        private System.Windows.Forms.Label lb_QueueInfo;
        private System.Windows.Forms.Label lb_QueueCarNum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_FirstCarInfo;
        private System.Windows.Forms.Label queueCarCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lb_SendCardInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lb_FirstCarCardID;
        private System.Windows.Forms.Label lb_SendCardTime;
        private System.Windows.Forms.Label lb_SendICCard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lb_FirstArriveTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label FirstCarCardID;
        private System.Windows.Forms.Label FirstArriveTime;
        private System.Windows.Forms.TextBox tb_SendICCard;
        private System.Windows.Forms.Label lb_SendCardModel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button bt_Auto;
        private System.Windows.Forms.Button bt_Manual;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label lb_CarTpye;
        private System.Windows.Forms.ToolStripStatusLabel toolStriplb_TollStation;
        private System.Windows.Forms.ToolStripStatusLabel toolStriplb_inoutward;
        private System.Windows.Forms.ToolStripStatusLabel toolStriplb_autoManual;
        private System.Windows.Forms.Timer timer_DevAbnormal;
        private System.Windows.Forms.Timer timer_DemandProduce;
        private System.Windows.Forms.Timer timer_CarArrive;
        private System.Windows.Forms.ToolStripMenuItem 设备维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_Tollstation;
        private System.Windows.Forms.ToolStripMenuItem 收费车道设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStriplb_laneId;
        private System.Windows.Forms.ToolStripMenuItem 测试定时器1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_CarArriveInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_Charge;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Charge1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel__Charge2;
        private System.Windows.Forms.Label label_ChargeListInfoNum;
        private System.Windows.Forms.Label label_ChargeListInfoNumber;
        private System.Windows.Forms.Label label_ChargeListInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Charge3;
        private System.Windows.Forms.Label label_ChargeICard;
        private System.Windows.Forms.Label label_ChargeCarLicense;
        private System.Windows.Forms.Label label_ChargeCarLicensePlate;
        private System.Windows.Forms.Label label_EntranceTollstation;
        private System.Windows.Forms.Label label_EntranceTollstationName;
        private System.Windows.Forms.Label label_ChargeICardNum;
        private System.Windows.Forms.Label label_ChargeSendCardTime;
        private System.Windows.Forms.Label lb_ChargeSendCardTime;
        private System.Windows.Forms.Label label_ChargeCarArriveTime;
        private System.Windows.Forms.Label lb_ChargeCarArriveTime;
        private System.Windows.Forms.Button button_Charge;
        private System.Windows.Forms.ComboBox comboBox_ChargeCarType;
        private System.Windows.Forms.Label lb_EntranceCarType;
        private System.Windows.Forms.Label label_ChargeCarType;
        private System.Windows.Forms.Label label_EntranceCarType;
        private System.Windows.Forms.TextBox textBox_SendCardTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ChargeMode;
        private System.Windows.Forms.Label label_ChargeMode;
        private System.Windows.Forms.Button bt_ChargeAuto;
        private System.Windows.Forms.Button bt_ChargeManual;
        private System.Windows.Forms.ComboBox comboBox_CarTpye;
        private System.Windows.Forms.PictureBox pictureBox_Tollstation;
        private System.Windows.Forms.GroupBox groupBox_Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectArrEnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectArrExitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntranceStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntranceLane;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendCardTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitLane;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompleteState;
    }
}

