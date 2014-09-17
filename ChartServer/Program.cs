using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChartServer.view;

namespace ChartServer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mainForm = new MainForm();
            if (mainForm != null)
            {
                try
                {
                    Application.Run(mainForm);
                }
                catch
                {
                    MessageBox.Show("系统异常","错误");
                }
                
            }
        }
    }
}
