using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HighWayCharging
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            //if (Properties.Settings.Default.DBServer != "")
            //{
            //    MainForm main = new MainForm();
            //    main.ShowDialog();
            //}
            //else
            //    MessageBox.Show("请配置数据库！");
        }
    }
}