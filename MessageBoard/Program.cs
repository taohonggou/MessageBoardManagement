using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoard
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
            frmLogin fLogin = new frmLogin();
            fLogin.ShowDialog();
            //if (DialogResult.OK==fLogin.DialogResult)
            //{
            //    Application.Run(new frmMain());
            //}
       }
    }
}
