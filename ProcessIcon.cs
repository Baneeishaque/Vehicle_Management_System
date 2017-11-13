using System;
using System.Diagnostics;
using System.Windows.Forms;
using Aryavidyashala_Vehicle_Management_System.Properties;
using System.Runtime.InteropServices;

namespace Aryavidyashala_Vehicle_Management_System
{

    class ProcessIcon : IDisposable
    {

        /// The NotifyIcon object.

        NotifyIcon ni;

        

        /// Initializes a new instance of the <see cref="ProcessIcon"/> class.

        public ProcessIcon()
        {
            // Instantiate the NotifyIcon object.
            ni = new NotifyIcon();
        }


        /// Displays the icon in the system tray.

        public void Display()
        {


            ni.BalloonTipTitle = "AVVMS";
            ni.BalloonTipText = "Arya Vidyashala Vehicle Management System";
            ni.Icon = Resources.vsta;
            ni.Text = "AVVMS";
            ni.Visible = true;
            ni.ShowBalloonTip(100);

           
        }

        public void Display(String message)
        {


            ni.BalloonTipTitle = "AVVMS";
            ni.BalloonTipText = message;
            ni.Icon = Resources.vsta;
            ni.Text = "AVVMS";
            ni.Visible = true;
            ni.ShowBalloonTip(100);


        }


        /// Releases unmanaged and - optionally - managed resources

        public void Dispose()
        {
            // When the application closes, this will remove the icon from the system tray immediately.
            ni.Dispose();
        }


    }
}