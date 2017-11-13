using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aryavidyashala_Vehicle_Management_System
{
    public partial class Batha_Assign : Form
    {
        DBhandler db = new DBhandler();
        DataTable dt = new DataTable();
        public Batha_Assign()
        {
            InitializeComponent();
            dt = db.GetTable("SELECT [Light half Batha] ,[light full batha] ,[light extra amount] ,[light hault batha] ,[heavy half batha] ,[heavy hault batha] ,[heavy full batha] ,[heavy km alavence driver] ,[heavy km alavence permanent cleaner] ,[heavy km alavance temporary cleaner] ,[heavy extra amount driver] ,[heavy extra amount cleaner]FROM [AVVMS].[dbo].[batha]");
           light_half.Text = dt.Rows[0]["Light half Batha"].ToString();
            light_full.Text = dt.Rows[0]["light full batha"].ToString();
            light_extra.Text = dt.Rows[0]["light extra amount"].ToString();
            light_hault.Text = dt.Rows[0]["light hault batha"].ToString();
            heavy_half.Text = dt.Rows[0]["heavy half batha"].ToString();
            heavy_full.Text = dt.Rows[0]["heavy full batha"].ToString();
            heavy_hault.Text = dt.Rows[0]["heavy hault batha"].ToString();
            heavykm_d.Text = dt.Rows[0]["heavy km alavence driver"].ToString();
            heavykm_p.Text = dt.Rows[0]["heavy km alavence permanent cleaner"].ToString();
            heavykm_t.Text = dt.Rows[0]["heavy km alavance temporary cleaner"].ToString();
            heavyed.Text = dt.Rows[0]["heavy extra amount driver"].ToString();
            heavyec.Text = dt.Rows[0]["heavy extra amount cleaner"].ToString();

            tgm.Text = db.GetValue("SELECT [gm] FROM [AVVMS].[dbo].[exceptional_trip]");
            tjgm.Text = db.GetValue("SELECT [jgm] FROM [AVVMS].[dbo].[exceptional_trip]");
            tspe.Text = db.GetValue("SELECT [special] FROM [AVVMS].[dbo].[exceptional_trip]");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                try
                {

                    db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[batha] SET [Light half Batha] = " + light_half.Text + " ,[light full batha] = " + light_full.Text + ",[light extra amount] = " + light_extra.Text + " ,[light hault batha] = " + light_hault.Text + " ,[heavy half batha] = " + heavy_half.Text + " ,[heavy hault batha] = " + heavy_hault.Text + " ,[heavy full batha] = " + heavy_full.Text + " ,[heavy km alavence driver] = " + heavykm_d.Text + " ,[heavy km alavence permanent cleaner] = " + heavykm_p.Text + " ,[heavy km alavance temporary cleaner] = " + heavykm_t.Text + ",[heavy extra amount driver] = " + heavyed.Text + " ,[heavy extra amount cleaner] = " + heavyec.Text + "");
                    MessageBox.Show("Updation Success");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Try Again...\nReason : " + ex.Message);
                }
            }
        }

        ErrorProvider err = new ErrorProvider();
        private bool Validation()
        {

            err.Dispose();

            bool ret = (isempty(light_half, "Enter Light Half Batha")) && (isempty(light_extra, "Enter Light extra Amount")) && (isempty(light_full, "Enter light full batha")) && (isempty(light_hault, "Enter light hault batha")) && (isempty(heavy_half, "Enter heavy half batha")) && (isempty(heavy_hault, "Enter heavy hault")) && (isempty(heavy_full, "Enter heavy full batha")) && (isempty(heavykm_d, "Enter KM alavence for driver")) && (isempty(heavykm_p, "Enter KM alavence for permanenet driver")) && (isempty(heavykm_t, "Enter KM alavance for temporary cleaner")) && (isempty(heavyed, "Enter Heavy Extra amount for driver")) && (isempty(heavyec, "Enter heavy extra amount for cleaner")) && (iscorrect(light_half, "Enter Light Half Batha")) && (iscorrect(light_extra, "Enter Light extra Amount")) && (iscorrect(light_full, "Enter light full batha")) && (iscorrect(light_hault, "Enter light hault batha")) && (iscorrect(heavy_half, "Enter heavy half batha")) && (iscorrect(heavy_hault, "Enter heavy hault")) && (iscorrect(heavy_full, "Enter heavy full batha")) && (iscorrect(heavykm_d, "Enter KM alavence for driver")) && (iscorrect(heavykm_p, "Enter KM alavence for permanenet driver")) && (iscorrect(heavykm_t, "Enter KM alavance for temporary cleaner")) && (iscorrect(heavyed, "Enter Heavy Extra amount for driver")) && (iscorrect(heavyec, "Enter heavy extra amount for cleaner"));

            return ret;
        }

        bool isempty(System.Windows.Forms.TextBox c, String text)
        {

            bool ret = true;

            if (c.Text.Equals(""))
            {

                err.SetError(c, text);
                c.Focus();
                ret = false;
            }
            return ret;
        }

       

        bool iscorrect(System.Windows.Forms.TextBox c, String text)
        {

            bool ret = true;
            try
            {

                Decimal i = Convert.ToDecimal(c.Text);
                if (i == 0)
                {
                    err.SetError(c, text);
                    c.Focus();
                    ret = false;
                }
            }
            catch (FormatException ex)
            {

                err.SetError(c, text);
                c.Focus();
                ret = false;
            }

            return ret;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Validation2())
            {
                if (tnew.Text.Equals(trnew.Text))
                {
                    err.Dispose();
                    String oldp = db.GetValue("SELECT [Password]FROM [AVVMS].[dbo].[Login]");
                    if (oldp.Equals(told.Text))
                    {
                        db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Login]SET [Password] = '"+tnew.Text+"'");
                        MessageBox.Show("Up Success");
                        Common_Tasks.nullify(told);
                        Common_Tasks.nullify(tnew);
                        Common_Tasks.nullify(trnew);
                    }
                    else
                    {
                        
       

                        err.Dispose();

                        err.SetError(told, "Enter Correct old password");
                        told.Focus();
                    }
                }
                else
                {
                    err.Dispose();
                   
                    err.SetError(tnew, "Unmatched passwords");
                    tnew.Focus();
                }

            }
        }

        private bool Validation2()
        {

            err.Dispose();

            bool ret = (isempty(told, "Enter Old Password")) && (isempty(tnew, "Enter New Password")) && (isempty(trnew, "Repeat new password"));

            return ret;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validation3())
            {
                db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[exceptional_trip]SET [gm] = '"+tgm.Text+"',[jgm] = '"+tjgm.Text+"',[special] = '"+tspe.Text+"'");
                MessageBox.Show("Up Success");
            }
        }

        private bool Validation3()
        {

            err.Dispose();

            bool ret = (isempty(tgm, "Enter GM qouta")) && (isempty(tjgm, "Enter JGM qouta")) && (isempty(tspe, "Enter Special quota")) && (iscorrect(tgm, "Enter GM qouta")) && (iscorrect(tjgm, "Enter JGM qouta")) && (iscorrect(tspe, "Enter Special quota"));

            return ret;
        }
    }
}
