using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyKTV
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
            //前台
            //Application.Run(new FrmMain());

            //后台
            Application.Run(new FrmLogin());
        }
    }
}
