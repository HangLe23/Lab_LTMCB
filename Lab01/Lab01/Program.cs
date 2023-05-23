using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
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
            Application.Run(new Lab01());
            // Application.Run(new BT1());
            // Application.Run(new BT2());
            // Application.Run(new BT3());
            // Application.Run(new BT4());
            // Application.Run(new BT5());
        }
    }
}
