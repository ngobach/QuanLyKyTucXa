using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LapTrinhCSharp.Forms;

namespace LapTrinhCSharp
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
#if true
            Application.Run(new FormMain());
#else
            Application.Run(new FormSplash());
#endif
        }
    }
}
