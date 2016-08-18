using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utility;
using BLL;
using DAL;
using HighWayCharging;
using System.Threading;

namespace HighWayCharging
{
    public partial class MainForm : Form
    {

        private XmlOperation xmlOperation;//xml配置文件操作
        private string EquipmentState = "正常";//设备状态
        private bool AbnormalFoundFlag = false;//异常发现标志
        private string AbnormalTime = "";//异常时间
        ExceptionOptBLL exceptionOptBLL = new ExceptionOptBLL();//异常处理
        DemandGenerationBLL demandGenerationBLL = new DemandGenerationBLL();//需求生成
        DemandProcessingBLL demandProcessingBLL = new DemandProcessingBLL();//需求处理
        SendCardProcessingBLL sendCardProcessingBLL = new SendCardProcessingBLL();//发卡
        private string tollStationName, laneID;//收费站名字、车道号
        private string CurrentCarNum = "";//当前车牌
        private string CurrentCarType = "";//当前车型
        private string CurrentIC = "";//当前IC卡
        private DateTime CurrentCarArrEnTime = DateTime.MinValue;//当前车到达入口时间
        private DateTime CurrentSendCardTime = DateTime.MinValue;//当前发卡时间
        private DateTime CurrentExpectArrExitTime = DateTime.MinValue;//当前预计到达出口时间
        private string CurrentEntranceLane = "";//入口车道
        private int WaitSendCardCount = 0;//等待发卡车辆数
        private bool flag = false;//车道打开标志
        private bool exitDemaneFlag = false;//还有数据标志

        private bool auto = false;//自动
        private bool Manual = true;//默认手动

        public MainForm()
        {
            //xml配置文件操作
            xmlOperation = new XmlOperation();
            //初始化全局变量
            GlobalVarBLL.InitGlobalVar();

            InitializeComponent();

            //在收费站还未设置前“登录”和“退出”为不可编辑状态
            toolStripButton_Login.Enabled = false;
            toolStripButton_Exit.Enabled = false;
            操作员登陆ToolStripMenuItem.Enabled = false;
            操作员退出ToolStripMenuItem.Enabled = false;
            //操作员未登录前，“收费费率”、“车道模拟配置”、“系统用户管理”、“设备维护”、“收费对账”、“记录查询”、“测试定时器”都为不可编辑状态
            收费费率更新ToolStripMenuItem.Enabled = false;
            车道模块配置ToolStripMenuItem.Enabled = false;
            系统用户管理ToolStripMenuItem.Enabled = false;
            设备维护ToolStripMenuItem.Enabled = false;
            收费对账ToolStripMenuItem.Enabled = false;
            记录查询ToolStripMenuItem.Enabled = false;
            //测试定时器1ToolStripMenuItem.Enabled = false;
        }

        //刷新进口需求表格信息
        private void RefreshDemandDataViewInfo()
        {

            DataTable demandInfoDt = demandGenerationBLL.GetDemandDtInfo();//界面显示需求表
            this.dataGridView_DemandInfo.DataSource = demandInfoDt;
            this.dataGridView_DemandInfo.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";//设置时间显示格式
            this.dataGridView_DemandInfo.Columns[6].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";//设置时间显示格式
            this.dataGridView_DemandInfo.Columns[9].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";//设置时间显示格式

        }

        //刷新出口需求表格信息
        private void RefreshTollDataViewInfo(string tollState)
        {

            DataTable tollInfoDt = demandGenerationBLL.GetTollDtInfo(tollState);//界面显示需求表
            this.dataGridView_DemandInfo.DataSource = tollInfoDt;
            this.dataGridView_DemandInfo.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";//设置时间显示格式
            this.dataGridView_DemandInfo.Columns[6].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";//设置时间显示格式
            this.dataGridView_DemandInfo.Columns[9].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";//设置时间显示格式

        }

        //把“已发卡”状态改为“代收费”状态
        private void Modify_completeState(string complete_state, string sendcardTime)
        {
            demandProcessingBLL.Modify_CompleteState("待收费", complete_state, sendcardTime);//界面显示需求表
            DataTable tollInfoDt = demandGenerationBLL.GetDemandDtInfo_charge();
            this.dataGridView_DemandInfo.DataSource = tollInfoDt;
            this.dataGridView_DemandInfo.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";//设置时间显示格式
            this.dataGridView_DemandInfo.Columns[6].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";//设置时间显示格式
            this.dataGridView_DemandInfo.Columns[9].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";//设置时间显示格式

        }

        //在控件上显示信息
        private void DisplayTextInfo(TextBox Textbox, string szTxt)
        {
            if (Textbox.InvokeRequired)  //非当前线程调用该控件,采用Invoke方法
            {//采用触发方法显示统计信息
                Textbox.Invoke(new MethodInvoker(delegate { Textbox.Text = szTxt; }));//占有率
            }
            else
            {//直接显示
                Textbox.Text = szTxt;
            }
        }

        //在控件上显示信息
        private void DisplayTextInfo(ToolStripStatusLabel toolstriplabel, string szTxt)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((EventHandler)delegate
                    {
                        toolstriplabel.Text = szTxt;
                    });
            }
            else
            {//直接显示
                toolstriplabel.Text = szTxt;
            }
        }

        //状态栏显示用户登录信息
        private void DisplayLoginMsg(string szText)
        {
            try
            {
                DisplayTextInfo(toolStripLb_UserLoginInfo, szText);
            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage("MainForm.cs/DisplayLoginMsg:" + ex.ToString());
            }
        }

        //初始化定时器
        private void InitTimer()
        {
            timer_DevAbnormal.Interval = GlobalVarBLL.AbnormalIntervalTime;//设备异常定时器时间间隔
            timer_CarArrive.Interval = GlobalVarBLL.QueryIntervalTime; ;//车辆到达查询定时器时间间隔
            timer_DemandProduce.Interval = GlobalVarBLL.DemandIntervalTime; ;//需求产生定时器时间间隔

            timer_DevAbnormal.Enabled = true;//设备异常定时器使能
            timer_CarArrive.Enabled = true;//车辆到达查询定时器使能
            timer_DemandProduce.Enabled = true;//需求产生定时器使能
        }

        //关闭定时器CloseTimer()
        private void CloseTimer()
        {
            timer_DevAbnormal.Interval = GlobalVarBLL.AbnormalIntervalTime;//设备异常定时器时间间隔
            timer_CarArrive.Interval = GlobalVarBLL.QueryIntervalTime; ;//车辆到达查询定时器时间间隔
            timer_DemandProduce.Interval = GlobalVarBLL.DemandIntervalTime; ;//需求产生定时器时间间隔

            timer_DevAbnormal.Enabled = false;//设备异常定时器使能
            timer_CarArrive.Enabled = false;//车辆到达查询定时器使能
            timer_DemandProduce.Enabled = false;//需求产生定时器使能
        }

        //设备自检
        private bool SelfChecking()
        {
            bool bRet = true;
            //加载设备状态XML变量
            if (!xmlOperation.ReadXmlValue(out EquipmentState))
            {
                MessageBox.Show("读取设备状态失败！", "提示", MessageBoxButtons.OK);
                // =============设备状态参数=================//
                toolStripLb_DevStateInfo.Text = "设备状态：" + EquipmentState;
                return bRet = false;
            }


            //设备自检
            if (EquipmentState == "正常")
            {
                // =============设备状态参数=================//
                toolStripLb_DevStateInfo.Text = "设备状态：" + EquipmentState;
                return bRet;
            }
            else if (EquipmentState == "异常")
            {
                // =============设备状态参数=================//
                toolStripLb_DevStateInfo.Text = "设备状态：" + EquipmentState;
                if (AbnormalFoundFlag == false)
                {
                    AbnormalTime = DateTime.Now.ToString();
                    AbnormalFoundFlag = true;
                }

                if (MessageBox.Show("设备出现异常,是否进行简易维护？", "设备异常", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //简易维护，将处理结果存入数据库
                    exceptionOptBLL.Maintenance(AbnormalTime, GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all, "异常");

                    MessageBox.Show("简易维护完成,设备恢复正常!", "设备恢复正常", MessageBoxButtons.OK);
                    // =============设备状态参数=================//
                    toolStripLb_DevStateInfo.Text = "设备状态：" + "正常";

                }
                else//将异常存入数据库
                {

                    exceptionOptBLL.NoMaintenance(AbnormalTime, GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all, "异常");
                    // =============设备状态参数=================//
                    toolStripLb_DevStateInfo.Text = "设备状态：" + "异常";
                    设备维护ToolStripMenuItem.Enabled = true;
                    return bRet = false;
                }
                //MessageBox.Show("设备出现异常！", "设备异常",MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else//错误
            {
                // =============设备状态参数=================//
                toolStripLb_DevStateInfo.Text = "设备状态：" + EquipmentState;
                if (MessageBox.Show("设备出现错误,是否进行上报？", "设备错误", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //简易维护，将处理结果存入数据库
                    exceptionOptBLL.Maintenance(DateTime.Now.ToString(), GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all, "错误");


                }
                else//将异常存入数据库
                {
                    exceptionOptBLL.ErrorNoReporting(DateTime.Now.ToString(), GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all, "错误");
                    return bRet = false;
                }
                //MessageBox.Show("设备出现错误！", "设备错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //修改设备状态XML变量
            if (!xmlOperation.SaveXmlValue("正常"))
            {
                MessageBox.Show("维护/上传失败！", "提示", MessageBoxButtons.OK);
                bRet = false;
                return bRet;
            }

            //重新加载设备状态XML变量
            if (!xmlOperation.ReadXmlValue(out EquipmentState))
            {
                MessageBox.Show("读取设备状态失败！", "提示", MessageBoxButtons.OK);
                // =============设备状态参数=================//
                toolStripLb_DevStateInfo.Text = "设备状态：" + EquipmentState;

                return bRet = false;
            }


            return bRet;
        }
        private void InitSendCardInfo()
        {
            ////初始化 发卡按钮 屏蔽
            bt_Auto.Enabled = false;
            bt_Manual.Enabled = false;
            bt_SendCarCard.Enabled = false;
            bt_SendCarCard.Text = "发卡";
            bt_ChargeAuto.Enabled = false;
            bt_ChargeManual.Enabled = false;
            button_Charge.Enabled = false;
            comboBox_CarTpye.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitSendCardInfo();
            GlobalVarBLL.LoginTime = DateTime.Now;
           


            //dateTimePicker_SendCardTime.Format = DateTimePickerFormat.Custom;
            //dateTimePicker_SendCardTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";



        }

        private void 数据库配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBaseSettingUI dataBaseSettingUI = new DataBaseSettingUI();
            dataBaseSettingUI.ShowDialog(this);
        }

        private void 车道模块配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaneSimulationConfigurationUI laneSimulationConfigurationUI = new LaneSimulationConfigurationUI();
            laneSimulationConfigurationUI.ShowDialog(this);
        }

        private void 进出口设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntranceExitConfigurationUI entranceExitConfigurationUI = new EntranceExitConfigurationUI();
            entranceExitConfigurationUI.ShowDialog(this);
        }

        private void 收费站设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TollstationLaneConfigurationUI tollstationLaneConfigurationUI = new TollstationLaneConfigurationUI();
            tollstationLaneConfigurationUI.ShowDialog(this);
            if (!MySQLHelper.SQLConnectedFlag)
            {
                MessageBox.Show("数据库打开失败,请核对数据库配置！");
                return;

            }
            if (GlobalVarBLL.Inoutward_all == "入口")
            {
                groupBox_Charge.Enabled = false;
                groupBox_SendCardInfo.Enabled = true;
            }
            else if (GlobalVarBLL.Inoutward_all == "出口")//出口
            {
                groupBox_Charge.Enabled = true;
                groupBox_SendCardInfo.Enabled = false;
            }
            //收费站设置好之后在状态栏显示
            DisplayTextInfo(toolStriplb_TollStation, "收费站名：" + GlobalVarBLL.TollstationName_all);
            DisplayTextInfo(toolStriplb_inoutward, GlobalVarBLL.Inoutward_all);
            DisplayTextInfo(toolStriplb_laneId, "车道编号：" + GlobalVarBLL.LaneID_all);
            TollstationLaneConfigurationBLL bll = new TollstationLaneConfigurationBLL();
            DataTable dt = bll.TollstationState_Query(GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all);//根据收费站名字，车道编号查出自动/半自动状态及设备状态
            if (dt != null && dt.Rows.Count > 0)
            {
                DisplayTextInfo(toolStriplb_autoManual, "自动/半自动：" + dt.Rows[0][0].ToString());
                DisplayTextInfo(toolStripLb_DevStateInfo, "设备状态：" + "无");
            }
            else
            {
                return;
            }
            toolStripButton_Login.Enabled = true;//收费站设置好之后允许操作员登陆
            操作员登陆ToolStripMenuItem.Enabled = true;
        }

        private void 收费费率更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TollRateConfigurationUI tollRateConfigurationUI = new TollRateConfigurationUI();
            tollRateConfigurationUI.ShowDialog(this);
        }

        private void 系统用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemUserManagerUI systemUserManagerUI = new SystemUserManagerUI();
            systemUserManagerUI.ShowDialog(this);
        }

        private void 发卡查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CardRecordUI cardRecordUI = new CardRecordUI();
            cardRecordUI.ShowDialog(this);
        }

        private void 收费查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChargeRecordUI chargeRecordUI = new ChargeRecordUI();
            chargeRecordUI.ShowDialog(this);
        }

        private void 操作日志查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemLogUI systemLogUI = new SystemLogUI();
            systemLogUI.ShowDialog(this);
        }

        private void 设备维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquipmentAbnormalUI equipmentAbnormalUI = new EquipmentAbnormalUI();
            equipmentAbnormalUI.ShowDialog(this);
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutUI formAboutUI = new FormAboutUI();
            formAboutUI.ShowDialog(this);
        }

        private void 对账记录查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CheckingAccountUI checkingAccountUI = new CheckingAccountUI();
            checkingAccountUI.ShowDialog(this);
        }

        private void 未对账记录查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckingAccountUI unCheckingAccountUI = new UnCheckingAccountUI();
            unCheckingAccountUI.ShowDialog(this);
        }

        //开放车道
        private void toolStripButton_Login_Click(object sender, EventArgs e)
        {
            LoginUI login = new LoginUI();
            login.ShowDialog(this);

            if (!GlobalVarBLL.LoginFlag)
            {
                MessageBox.Show("操作员登录失败！");
                return;
            }
           
            //设备自检
            if (SelfChecking())
            {
                //初始化时间间隔
                GlobalVarBLL.InitGlobalVar();

                //初始化定时器
                InitTimer();
               
            }
            else//自检失败，车道不开通
            {
                // =============设备状态参数=================//
                toolStripLb_DevStateInfo.Text = "设备状态：" + EquipmentState;
                MessageBox.Show("设备自检失败，请检查相关设置！");
                return;
            }

            //状态栏显示用户登录信息
            string msg = string.Empty;
            msg = UserDal.userName + "用户:  登录" + "\r\n";
            DisplayLoginMsg(msg);


            if (UserDal.userName != null)
            {
                //开通车道
                TollstationLaneConfigurationBLL bll = new TollstationLaneConfigurationBLL();
                flag = bll.Modify_OpenState(GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all, "开通");
                if (flag)
                {
                    MessageBox.Show("车道开通！");
                }
                else
                {
                    MessageBox.Show("车道开通失败！");
                    return;
                }
                //使能退出按钮
                toolStripButton_Exit.Enabled = true;
                操作员退出ToolStripMenuItem.Enabled = true;
                //屏蔽开始按钮
                toolStripButton_Login.Enabled = false;
                操作员登陆ToolStripMenuItem.Enabled = false;
                //使能“收费费率”、“车道模拟配置”、“系统用户管理”、“设备维护”、“收费对账”、“记录查询”、“测试定时器”
                收费费率更新ToolStripMenuItem.Enabled = true;
                车道模块配置ToolStripMenuItem.Enabled = true;
                系统用户管理ToolStripMenuItem.Enabled = true;
                设备维护ToolStripMenuItem.Enabled = true;
                收费对账ToolStripMenuItem.Enabled = true;
                记录查询ToolStripMenuItem.Enabled = true;
                测试定时器1ToolStripMenuItem.Enabled = true;

                if (UserDal.userName == "user")
                {
                    //关闭定时器
                    CloseTimer();
                }
            }

        }

        //发卡
        private void bt_SendCarCard_Click(object sender, EventArgs e)
        {
            if (dataGridView_DemandInfo.Rows.Count == 0)
            {
                MessageBox.Show("当前没有需求数据！");
                //数据没有的时候，初始化发卡界面
                InitSendCardInfo();
                return;
            }
               
            DateTime expectArrExitTime = DateTime.MinValue;
            DateTime sendCardTime = DateTime.MinValue;
            if (sendCardProcessingBLL.SendCard(CurrentCarNum, CurrentCarArrEnTime, CurrentIC, CurrentCarType, out sendCardTime))//保存成功
            {

                expectArrExitTime = CurrentExpectArrExitTime + (DateTime.Now - CurrentSendCardTime);
                //expectArrExitTime = DateTime.Now.AddSeconds(20);//测试用，减小到达出口时间；
                demandProcessingBLL.UpdateDemandStateInfo("已发卡", CurrentCarNum, expectArrExitTime, sendCardTime);//更新需求状态
                bt_SendCarCard.Enabled = false;
                bt_SendCarCard.Text = CurrentCarNum + "已发卡";
                WaitSendCardCount--;
                queueCarCount.Text = WaitSendCardCount.ToString();//发卡排队车辆
            }


            //刷新需求表格数据
            RefreshDemandDataViewInfo();

        }

        //自动发卡
        private void bt_Auto_Click(object sender, EventArgs e)
        {
            auto = true;//自动
            Manual = false;//默认手动
        }

        //手动发卡
        private void bt_Manual_Click(object sender, EventArgs e)
        {
            //auto = false;//自动
            //Manual = true;//默认手动
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
         
            DialogResult dr = MessageBox.Show("确认是否退出平台？", "警告！", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                if (dataGridView_DemandInfo.Rows.Count > 0)
                {
              
                    e.Cancel = true;

                }
                if (flag)//车道打开过
                    toolStripButton_Exit_Click(this, null);
            }
            else
            {
                e.Cancel = true;

            }
         
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        //设备异常定时器
        private void timer_DevAbnormal_Tick(object sender, EventArgs e)
        {
            xmlOperation.SaveXmlValue("异常");

            //加载设备状态XML变量
            if (!xmlOperation.ReadXmlValue(out EquipmentState))
            {
                MessageBox.Show("读取设备状态失败！", "提示", MessageBoxButtons.OK);
                timer_DevAbnormal.Stop();//定时器停止
            }

            if (EquipmentState == "正常")
            {
                return;
            }
            else if (EquipmentState == "异常")
            {


                if (MessageBox.Show("设备出现异常,是否进行简易维护？", "设备异常", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //简易维护，将处理结果存入数据库
                    timer_DevAbnormal.Stop();//定时器停止
                    //EquipmentMaintenanceUI equipmentMaintenanceUI = new EquipmentMaintenanceUI(id, abnormalTime, tollStationName, laneID, "异常简易维护");
                    //equipmentMaintenanceUI.ShowDialog(this);

                    exceptionOptBLL.Maintenance(DateTime.Now.ToString(), "", "", "异常");
                    xmlOperation.SaveXmlValue("正常");
                    MessageBox.Show("简易维护完成！", "设备恢复正常", MessageBoxButtons.OK);
                    timer_DevAbnormal.Start();//定时器开始

                }
                else//将异常存入数据库
                {

                    exceptionOptBLL.NoMaintenance(DateTime.Now.ToString(), GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all, "异常");

                    timer_DevAbnormal.Enabled = false;//定时器停止
                }
                //MessageBox.Show("设备出现异常！", "设备异常",MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (EquipmentState == "错误")//错误
            {
                xmlOperation.SaveXmlValue("错误");
                if (MessageBox.Show("设备出现错误,是否进行上报？", "设备错误", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //简易维护，将处理结果存入数据库
                    timer_DevAbnormal.Stop();//定时器停止
                    //EquipmentMaintenanceUI equipmentMaintenanceUI = new EquipmentMaintenanceUI(id, abnormalTime, tollStationName, laneID, "错误上传");
                    //equipmentMaintenanceUI.ShowDialog(this);
                    exceptionOptBLL.Maintenance(DateTime.Now.ToString(), "", "", "错误");
                    timer_DevAbnormal.Start();//定时器开始

                }
                else//将异常存入数据库
                {
                    exceptionOptBLL.ErrorNoReporting(DateTime.Now.ToString(), "", "", "异常");
                    timer_DevAbnormal.Enabled = false;//定时器停止
                }
                //MessageBox.Show("设备出现错误！", "设备错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //加载设备状态XML变量
            if (!xmlOperation.ReadXmlValue(out EquipmentState))
            {
                MessageBox.Show("读取设备状态失败！", "提示", MessageBoxButtons.OK);
                timer_DevAbnormal.Stop();//定时器停止
            }
            // =============设备状态参数=================//
            toolStripLb_DevStateInfo.Text = "设备状态：" + EquipmentState;

        }
        //需求产生定时器
        private void timer_DemandProduce_Tick(object sender, EventArgs e)
        {
            string exitStation = "";
            if (GlobalVarBLL.Inoutward_all == "入口")
            {
                if (demandGenerationBLL.SetSimulationPara(out exitStation) == false)//生成需求并插入数据库
                {

                    if (exitStation != "")
                    {
                        MessageBox.Show(" 入口: " + GlobalVarBLL.TollstationName_all + " 到出口:" + exitStation + " 之间没有里程！\r\n");

                    }
                    else
                    {
                        //MessageBox.Show("该入口需求产生失败，该入口所对应的出口未开通！");
                    }
                }
                ////刷新需求表格数据
                //RefreshDemandDataViewInfo();
            }
            else
            {


            }
        }
        //车辆到达查询定时器
        private void timer_CarArrive_Tick(object sender, EventArgs e)
        {
            bool firstCarCome = false;
            string CarNumTemp = "无";//车牌
            string CarTypeTemp = "";//车型
            string EntranceStation = "";//入口收费站
            string SendCardTime = "";//发卡时间
            //int charge_CarCount = 0;//定义排队计数的局部变量，每次清零
            //int IC;//卡号

            if (GlobalVarBLL.Inoutward_all == "入口")
            {
                if (demandProcessingBLL.DemandProcessing(out firstCarCome, out CarNumTemp, out CarTypeTemp))
                {
                    if (CurrentCarNum == CarNumTemp)//查询间隔小于1S时消除同一车牌反复处理
                        return;


                    CurrentCarNum = CarNumTemp;
                    CurrentCarType = CarTypeTemp;
                    CurrentCarArrEnTime = DateTime.Now;
                    WaitSendCardCount++;
                    queueCarCount.Text = WaitSendCardCount.ToString();//发卡排队车辆
                    //if (firstCarCome)//第一辆车到达
                    //{
                    //    FirstCarCardID.Text = demandProcessingBLL.FirstCarNum;
                    //    FirstArriveTime.Text = demandProcessingBLL.FirstCarArrTime;
                    //    firstCarCome = false;

                    //}
                    //发卡信息显示
                    toolStripStatusLabel_CarArriveInfo.Text = CurrentCarType + "车 " + CurrentCarNum + "到达";
                    //textBox_SendCardTime.Text = CurrentCarArrEnTime.ToString();
                    //Random random = new Random();
                    //IC = random.Next(100000,999999);
                    //CurrentIC = "IC" + IC.ToString();
                    //tb_SendICCard.Text = CurrentIC;
                    //textBox_CarTpye.Text = CurrentCarType;
                    if (Manual == true)//手动
                    {
                        //if (MessageBox.Show(CurrentCarType + "车 " + CurrentCarNum + "到达，请选择发卡！", "发卡提示", MessageBoxButtons.OK) == DialogResult.OK)
                        //{
                        demandProcessingBLL.UpdateDemandStateInfo("待发卡", CurrentCarNum, DateTime.Now);//更新需求状态

                        //bt_SendCarCard.Enabled = true;
                        //bt_SendCarCard.Text = "发卡";
                        bt_Manual.Enabled = true;
                        //刷新需求表格数据
                        RefreshDemandDataViewInfo();
                        this.dataGridView_DemandInfo.Rows[0].Selected = true;
                        // }
                    }
                    else if (auto == true)//自动发卡
                    {
                        bt_SendCarCard.Enabled = false;
                        bt_Auto.Enabled = true;
                    }
                }
                else
                {

                }
                //发卡模式下屏蔽收费按钮
                bt_ChargeManual.Enabled = false;
                button_Charge.Enabled = false;
            }
            else if (GlobalVarBLL.Inoutward_all == "出口")//出口
            {
                if (demandProcessingBLL.DemandProcessing(out CarNumTemp, out CarTypeTemp, out EntranceStation, out SendCardTime, GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all))
                {
                    if (CurrentCarNum == CarNumTemp)//查询间隔小于1S时消除同一车牌反复处理
                        return;
                    CurrentCarNum = CarNumTemp;
                    CurrentCarType = CarTypeTemp;
                    CurrentExpectArrExitTime = DateTime.Now;
                    //WaitSendCardCount++;//排队计数
                  
                    toolStripStatusLabel_CarArriveInfo.Text = CurrentCarType + "车 " + CurrentCarNum + "到达";
                    //刷新需求表格数据
                    Modify_completeState("已发卡", SendCardTime);
                    //for (int i = 0; i < this.dataGridView_DemandInfo.Rows.Count; i++)
                    //{
                    //    charge_CarCount++;//排队计数

                    //}
                    WaitSendCardCount = this.dataGridView_DemandInfo.Rows.Count;
                    label_ChargeListInfoNum.Text = WaitSendCardCount.ToString();//发卡排队车辆

                    ////发卡信息显示
                    //lb_EntranceCarType.Text = CurrentCarType;//入口车型
                    //lb_ChargeSendCardTime.Text = SendCardTime;//发卡时间
                    //lb_ChargeCarArriveTime.Text = CurrentExpectArrExitTime.ToString();//到达时间
                    //label_EntranceTollstationName.Text = EntranceStation;//入口收费站
                    //label_ChargeCarLicensePlate.Text = CurrentCarNum;//车牌
                    //DataTable dt = null;
                    //dt = demandProcessingBLL.Get_ICcard(SendCardTime);//根据发卡时间查询IC卡号
                    //if (dt != null && dt.Rows.Count > 0)
                    //{
                    //    label_ChargeICardNum.Text = dt.Rows[0][0].ToString();
                    //}

                    if (Manual == true)//手动
                    {
                        bt_ChargeManual.Enabled = true;
                    }
                    else if (auto == true)//自动发卡
                    {
                        button_Charge.Enabled = false;
                        bt_ChargeAuto.Enabled = true;
                    }
                }

                else
                {
                    //MessageBox.Show("该收费站当前没有车辆到达");
                }
                //收费模式下屏蔽发卡按钮
                bt_Manual.Enabled = false;
                bt_SendCarCard.Enabled = false;
            }

        }

        private void toolStripButton_Exit_Click(object sender, EventArgs e)
        {
     
            if (GlobalVarBLL.Inoutward_all == "入口")
            {
                if (dataGridView_DemandInfo.Rows.Count > 0)
                {
                    MessageBox.Show("还有车辆等待发卡，请发完卡，再尝试退出！");
                    exitDemaneFlag = true;
                    return;
                }
            }
            else if (GlobalVarBLL.Inoutward_all == "出口")
            {
                if (dataGridView_DemandInfo.Rows.Count > 0)
                {
                    MessageBox.Show("还有车辆等待收费，请收费完，再尝试退出！");
                    return;
                }
            }

            //if (exitDemaneFlag)//还有数据，需要等待数据写入数据库
            //{
            //    Thread.Sleep(5000); 
            //}
            LoginDal.SetSystemLog(UserDal.userName, "退出");
            MessageBox.Show("用户: " + UserDal.userName + " 退出成功！", "提示");
            DisplayLoginMsg("用户未登录");//状态栏恢复默认状态
            //关闭车道
            TollstationLaneConfigurationBLL bll = new TollstationLaneConfigurationBLL();
            flag = bll.Modify_OpenState(GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all, "关闭");
            if (flag)
            {
                MessageBox.Show("车道关闭！");
            }
            else
            {
                MessageBox.Show("车道关闭失败！");
                return;
            }

            //操作员退出，“收费费率”、“车道模拟配置”、“系统用户管理”、“设备维护”、“收费对账”、“记录查询”、“测试定时器”都为不可编辑状态
            收费费率更新ToolStripMenuItem.Enabled = false;
            车道模块配置ToolStripMenuItem.Enabled = false;
            系统用户管理ToolStripMenuItem.Enabled = false;
            设备维护ToolStripMenuItem.Enabled = false;
            收费对账ToolStripMenuItem.Enabled = false;
            记录查询ToolStripMenuItem.Enabled = false;
            测试定时器1ToolStripMenuItem.Enabled = false;

            //关闭定时器
            CloseTimer();
            //屏蔽退出按钮
            toolStripButton_Exit.Enabled = false;
            操作员退出ToolStripMenuItem.Enabled = false;
            //使能开始按钮
            toolStripButton_Login.Enabled = true;
            操作员登陆ToolStripMenuItem.Enabled = true;

            //登录状态初始化
            GlobalVarBLL.LoginFlag = false;

            //初始化发卡栏
            InitSendCardInfo();



            //删除需求
            //demandProcessingBLL.DeleteDemandInfo();
            //刷新需求表格数据
            RefreshDemandDataViewInfo();


        }

        private void 测试定时器1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string exitStation = "";
            if (GlobalVarBLL.Inoutward_all == "入口")
            {
                if (demandGenerationBLL.SetSimulationPara(out exitStation) == false)//生成需求并插入数据库
                {

                    if (exitStation != "")
                    {
                        MessageBox.Show(" 入口: " + GlobalVarBLL.TollstationName_all + " 到出口:" + exitStation + " 之间没有里程！\r\n");

                    }
                    else
                    {
                        //MessageBox.Show("该入口需求产生失败，查询该入口的出口是否未开通！");
                    }
                }
            }
            else
            {


            }

            //刷新需求表格数据
            RefreshDemandDataViewInfo();
        }

        private void dataGridView_DemandInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int IC;//卡号
            //string SelectCarNum = string.Empty;
            //string SelectCarType = string.Empty;
            //try
            //{
            //    if (GlobalVarBLL.Inoutward_all == "入口")
            //    {
            //        if (dataGridView_DemandInfo.CurrentRow != null && dataGridView_DemandInfo.CurrentRow.Cells["CompleteState"].Value.ToString() == "待发卡" && CurrentCarArrEnTime != DateTime.MinValue)
            //        {
            //            bt_SendCarCard.Enabled = true;
            //            bt_SendCarCard.Text = "发卡";

            //            SelectCarNum = dataGridView_DemandInfo.CurrentRow.Cells["CarNum"].Value.ToString();
            //            SelectCarType = dataGridView_DemandInfo.CurrentRow.Cells["CarType"].Value.ToString();
            //            CurrentCarNum = SelectCarNum;
            //            CurrentCarType = SelectCarType;
            //            CurrentCarArrEnTime = Convert.ToDateTime(dataGridView_DemandInfo.CurrentRow.Cells["ExpectArrEnTime"].Value.ToString());
            //            CurrentSendCardTime = Convert.ToDateTime(dataGridView_DemandInfo.CurrentRow.Cells["SendCardTime"].Value.ToString());
            //            CurrentExpectArrExitTime = Convert.ToDateTime(dataGridView_DemandInfo.CurrentRow.Cells["ExpectArrExitTime"].Value.ToString());
            //            //发卡信息显示
            //            comboBox_CarTpye.Text = SelectCarType;
            //            textBox_SendCardTime.Text = DateTime.Now.ToString();
            //            Random random = new Random();
            //            IC = random.Next(100000, 999999);
            //            CurrentIC = "IC" + IC.ToString();
            //            tb_SendICCard.Text = CurrentIC;
            //            FirstCarCardID.Text = CurrentCarNum;
            //            FirstArriveTime.Text = CurrentCarArrEnTime.ToString();
            //        }


            //    }
            //    else if (GlobalVarBLL.Inoutward_all == "出口")//出口
            //    {
            //        if (dataGridView_DemandInfo.CurrentRow != null && dataGridView_DemandInfo.CurrentRow.Cells["CompleteState"].Value.ToString() == "待收费" && CurrentExpectArrExitTime != DateTime.MinValue)
            //        {
            //            button_Charge.Enabled = true;
            //            button_Charge.Text = "收费";

            //            SelectCarNum = dataGridView_DemandInfo.CurrentRow.Cells["CarNum"].Value.ToString();
            //            SelectCarType = dataGridView_DemandInfo.CurrentRow.Cells["CarType"].Value.ToString();
            //            CurrentCarNum = SelectCarNum;
            //            CurrentCarType = SelectCarType;
            //            CurrentEntranceLane = dataGridView_DemandInfo.CurrentRow.Cells["EntranceLane"].Value.ToString();
            //            CurrentSendCardTime = Convert.ToDateTime(dataGridView_DemandInfo.CurrentRow.Cells["SendCardTime"].Value.ToString());
            //            CurrentCarArrEnTime = Convert.ToDateTime(dataGridView_DemandInfo.CurrentRow.Cells["ExpectArrEnTime"].Value.ToString());
            //            CurrentExpectArrExitTime = Convert.ToDateTime(dataGridView_DemandInfo.CurrentRow.Cells["ExpectArrExitTime"].Value.ToString());
            //            //发卡信息显示
            //            lb_EntranceCarType.Text = SelectCarType;
            //            comboBox_ChargeCarType.Text = SelectCarType;
            //            lb_ChargeSendCardTime.Text = CurrentSendCardTime.ToString();
            //            label_ChargeCarLicensePlate.Text = CurrentCarNum;
            //            lb_ChargeCarArriveTime.Text = CurrentExpectArrExitTime.ToString();
            //            label_EntranceTollstationName.Text = dataGridView_DemandInfo.CurrentRow.Cells["EntranceStation"].Value.ToString();
            //            DataTable dt = null;
            //            dt = demandProcessingBLL.Get_ICcard(CurrentSendCardTime.ToString());//根据发卡时间查询IC卡号
            //            if (dt != null && dt.Rows.Count > 0)
            //            {
            //                CurrentIC = dt.Rows[0][0].ToString();
            //                label_ChargeICardNum.Text = CurrentIC;
            //            }
            //        }


            //    }
            //}
            //catch (Exception ex)
            //{
            //    DebugOutput.ProcessMessage(ex.ToString()+"\r\n");
            //}

        }
        //收费操作
        private void button_Charge_Click(object sender, EventArgs e)
        {
            if (dataGridView_DemandInfo.Rows.Count == 0)
            {
                MessageBox.Show("当前没有需求数据！");
                //数据没有的时候，初始化发卡界面
                InitSendCardInfo();
                return;
            }
            ChargeProcessingBLL chargeProcessingBLL = new ChargeProcessingBLL();
            int SendCardNum = 0;//对应发卡记录编号
            DataTable dt_SendCardNum = null;
            dt_SendCardNum = chargeProcessingBLL.Get_SendCardID(CurrentSendCardTime);
            if (dt_SendCardNum != null && dt_SendCardNum.Rows.Count > 0)
            {
                SendCardNum = Convert.ToInt32(dt_SendCardNum.Rows[0][0].ToString());
            }
            else
            {
                return;
            }
            string EntranceStation = "";//入口收费站
            string EntranceCarType = "";//入口车型
            string ExitCarType = "";//出口车型
            int Rate = 0;//费用
            EntranceStation = label_EntranceTollstationName.Text.ToString();
            EntranceCarType = CurrentCarType;
            ExitCarType = comboBox_ChargeCarType.Text.ToString();
            DataTable dt_Rate = null;
            dt_Rate = demandProcessingBLL.Get_Rate(EntranceStation, GlobalVarBLL.TollstationName_all, ExitCarType);
            if (dt_Rate != null && dt_Rate.Rows.Count > 0)
            {
                Rate = Convert.ToInt32(dt_Rate.Rows[0][0].ToString());
            }
            else
            {
                MessageBox.Show("该路段没有录入费率");
                return;
            }
            if (MessageBox.Show("入口车型：" + EntranceCarType + "\r\n" + "出口车型：" + ExitCarType + "\r\n" + "入口收费站：" + EntranceStation + "\r\n" + "费用：" + Rate + "\r\n" + "是否确定收取费用？", "收费提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                demandProcessingBLL.UpdateDemandStateInfo("待收费", CurrentCarNum, CurrentExpectArrExitTime);//更新需求状态,把状态改为“1”
                chargeProcessingBLL.Charging(SendCardNum, CurrentCarNum, CurrentCarArrEnTime, EntranceStation, CurrentEntranceLane, CurrentSendCardTime, CurrentIC, CurrentCarType, ExitCarType, CurrentExpectArrExitTime, GlobalVarBLL.TollstationName_all, GlobalVarBLL.LaneID_all, Rate, "正常", UserDal.userName, false);
                WaitSendCardCount--;
                label_ChargeListInfoNum.Text = WaitSendCardCount.ToString();//排队数量减1
                RefreshTollDataViewInfo("待收费");
            }
            else
            {
                return;
            }
        }

        private void dataGridView_DemandInfo_SelectionChanged(object sender, EventArgs e)
        {
            int IC;//卡号
            string SelectCarNum = string.Empty;
            string SelectCarType = string.Empty;
            if (GlobalVarBLL.Inoutward_all == "入口")
            {
                if (dataGridView_DemandInfo.CurrentRow != null && dataGridView_DemandInfo.CurrentRow.Cells["CompleteState"].Value.ToString() == "待发卡" && CurrentCarArrEnTime != DateTime.MinValue)
                {
                    bt_SendCarCard.Enabled = true;
                    bt_SendCarCard.Text = "发卡";

                    SelectCarNum = dataGridView_DemandInfo.CurrentRow.Cells["CarNum"].Value.ToString();
                    SelectCarType = dataGridView_DemandInfo.CurrentRow.Cells["CarType"].Value.ToString();
                    CurrentCarNum = SelectCarNum;
                    CurrentCarType = SelectCarType;
                    CurrentCarArrEnTime = Convert.ToDateTime(dataGridView_DemandInfo.CurrentRow.Cells["ExpectArrEnTime"].Value.ToString());
                    CurrentSendCardTime = Convert.ToDateTime(dataGridView_DemandInfo.CurrentRow.Cells["SendCardTime"].Value.ToString());
                    CurrentExpectArrExitTime = Convert.ToDateTime(dataGridView_DemandInfo.CurrentRow.Cells["ExpectArrExitTime"].Value.ToString());
                    if (dataGridView_DemandInfo.CurrentRow.Cells["CarNum"].Value.ToString() == FirstCarCardID.Text)
                    {
                        //发卡信息显示
                        //comboBox_CarTpye.Text = SelectCarType;
                        textBox_SendCardTime.Text = DateTime.Now.ToString();
                        //Random random = new Random();
                        //IC = random.Next(100000, 999999);
                        //CurrentIC = "IC" + IC.ToString();
                        //tb_SendICCard.Text = CurrentIC;
                        //FirstCarCardID.Text = CurrentCarNum;
                        //FirstArriveTime.Text = CurrentCarArrEnTime.ToString();
                    }
                    else
                    {
                        //发卡信息显示
                        comboBox_CarTpye.Text = SelectCarType;
                        textBox_SendCardTime.Text = DateTime.Now.ToString();
                        Random random = new Random();
                        IC = random.Next(100000, 999999);
                        CurrentIC = "IC" + IC.ToString();
                        tb_SendICCard.Text = CurrentIC;
                        FirstCarCardID.Text = CurrentCarNum;
                        FirstArriveTime.Text = CurrentCarArrEnTime.ToString();
                    }
                   
                }


            }
            else if (GlobalVarBLL.Inoutward_all == "出口")//出口
            {
                if (dataGridView_DemandInfo.CurrentRow != null && dataGridView_DemandInfo.CurrentRow.Cells["CompleteState"].Value.ToString() == "待收费" && CurrentExpectArrExitTime != DateTime.MinValue)
                {
                    button_Charge.Enabled = true;
                    button_Charge.Text = "收费";

                    SelectCarNum = dataGridView_DemandInfo.CurrentRow.Cells["CarNum"].Value.ToString();
                    SelectCarType = dataGridView_DemandInfo.CurrentRow.Cells["CarType"].Value.ToString();
                    CurrentCarNum = SelectCarNum;
                    CurrentCarType = SelectCarType;
                    CurrentEntranceLane = dataGridView_DemandInfo.CurrentRow.Cells["EntranceLane"].Value.ToString();
                    CurrentSendCardTime = Convert.ToDateTime(dataGridView_DemandInfo.CurrentRow.Cells["SendCardTime"].Value.ToString());
                    CurrentCarArrEnTime = Convert.ToDateTime(dataGridView_DemandInfo.CurrentRow.Cells["ExpectArrEnTime"].Value.ToString());
                    CurrentExpectArrExitTime = Convert.ToDateTime(dataGridView_DemandInfo.CurrentRow.Cells["ExpectArrExitTime"].Value.ToString());
                   
                    lb_EntranceCarType.Text = SelectCarType;
                    comboBox_ChargeCarType.Text = SelectCarType;
                    lb_ChargeSendCardTime.Text = CurrentSendCardTime.ToString();
                    label_ChargeCarLicensePlate.Text = CurrentCarNum;
                    lb_ChargeCarArriveTime.Text = CurrentExpectArrExitTime.ToString();
                    label_EntranceTollstationName.Text = dataGridView_DemandInfo.CurrentRow.Cells["EntranceStation"].Value.ToString();
                    DataTable dt = null;
                    dt = demandProcessingBLL.Get_ICcard(CurrentSendCardTime.ToString());//根据发卡时间查询IC卡号
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        CurrentIC = dt.Rows[0][0].ToString();
                        label_ChargeICardNum.Text = CurrentIC;
                    }
                }
            }
        }
    }
}