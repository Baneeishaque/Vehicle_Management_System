using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Aryavidyashala_Vehicle_Management_System
{
    static class Program
    {
        public static ProcessIcon pi;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Show the system tray icon.					
            using (pi = new ProcessIcon())
            {
                pi.Display();

                // Make sure the application runs!
                Application.Run(new Login());
                //Application.Run(new Hair());
                //Application.Run(new Lisence_Renew_Input());
                //Application.Run(new Test_Form());
                //Application.Run(new Batha_Assign());
            }
            
        }
    }
}
