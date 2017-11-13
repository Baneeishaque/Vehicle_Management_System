using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Aryavidyashala_Vehicle_Management_System
{
    class Common_Tasks
    {
        
        internal static void nullify(System.Windows.Forms.Control c)
        {
            c.Text = "";
        }



        internal static void disable(System.Windows.Forms.Control c)
        {
            c.Enabled = false;
            
        }

        


        internal static void disableg(System.Windows.Forms.Control[] c)
        {
            
            for (int i = 0; i < c.Length; i++)
            {
                c[i].Enabled = false;
            }

        }


        internal static bool isempty(System.Windows.Forms.TextBox c,String text)
        {
            ErrorProvider e = new ErrorProvider();
            bool ret = true;
            
            if (c.Text.Equals(""))
            {

                e.SetError(c, text);
                c.Focus();
                ret = false;
            }
            return ret;
        }

        internal static bool isselected(System.Windows.Forms.ComboBox c, String text)
        {
            ErrorProvider e = new ErrorProvider();
            bool ret = true;
            
            if (c.SelectedIndex==0)
            {

                e.SetError(c, text);
                c.Focus();
                ret = false;
            }
            return ret;
        }

        internal static bool iscorrect(System.Windows.Forms.TextBox c, String text)
        {
            ErrorProvider e = new ErrorProvider();
            bool ret = true;
            try
            {
                int i = Convert.ToInt32(c.Text);
            }
            catch (FormatException ex)
            {
                
                e.SetError(c, text);
                c.Focus();
                ret = false;
            }
            
            return ret;
        }


       

        
    }
}
