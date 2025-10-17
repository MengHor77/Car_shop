using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagementSystem
{
    internal static class Program
    {
        public static Login frmLogin;
        public static Home frmHome;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin = new Login();
            frmHome = new Home();

            Application.Run(frmLogin);
        }
    }
}
