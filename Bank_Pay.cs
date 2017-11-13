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
    public partial class Bank_Pay : Form
    {

        DBhandler db = new DBhandler();
        public Bank_Pay(string no,string am)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            label11.Text = db.max_plus("SELECT max([no])FROM [AVVMS].[dbo].[bunk pay]").ToString();
            lbbunk.Text = no;
            lbam.Text = am;
            comboBox2.SelectedIndex = 0;

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            new Bank_Pay_Report().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (iscorrect(tpay, "Enter Correct Payed Amount"))
            {
                lbbal.Text = ((Convert.ToDecimal(lbam.Text)) - (Convert.ToDecimal(tpay.Text))).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[bunk pay]([date],[payed],[bunk],[amount],[balance],[payement mode],[document code],[remark])VALUES('" + dateTimePicker1.Value.ToShortDateString() + "'," + tpay.Text + "," + lbbunk.Text + "," + lbam.Text + "," + lbbal.Text + ",'" + comboBox2.SelectedItem.ToString() + "','" + tbill.Text + "','" + trm.Text + "')");

                db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[pbunk] SET [initial amount] = " + lbbal.Text + ",[amount] = " + lbbal.Text + " WHERE no=" + lbbunk.Text + "");

                MessageBox.Show("added");
                this.Close();
            }
        }

        ErrorProvider error = new ErrorProvider();
        private bool Validation()
        {
            error.Dispose();
            bool ret = isempty(tpay, "Enter Payed Amount") && isempty(tbill, "Enter Bill No.") && isselected(comboBox2, "Select Payement Mode") && iscorrect(tpay, "Enter Correct Payed Amount") && iscorrect(tbill, "Enter Currect Bill No.") ;



            return ret;
        }

        bool isempty(System.Windows.Forms.Control c, String text)
        {

            bool ret = true;

            if (c.Text.Equals(""))
            {

                error.SetError(c, text);
                c.Focus();
                ret = false;
            }
            return ret;
        }

        bool isselected(System.Windows.Forms.ComboBox c, String text)
        {

            bool ret = true;

            if (c.SelectedIndex == 0)
            {

                error.SetError(c, text);
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
                    error.SetError(c, text);
                    c.Focus();
                    ret = false;
                }
            }
            catch (FormatException ex)
            {

                error.SetError(c, text);
                c.Focus();
                ret = false;
            }

            return ret;
        }
    }
}
