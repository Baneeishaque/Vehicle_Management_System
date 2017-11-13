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
    public partial class Bank_Addition : Form
    {
        DBhandler db = new DBhandler();
        private int update_flag=0;
        
        public Bank_Addition()
        {
            InitializeComponent();
            label4.Text = db.max_plus("SELECT max([no])FROM [AVVMS].[dbo].[pbunk]").ToString();
        }

        public Bank_Addition(string no, string name, string address, string bill)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.Text = "Bank Updation";
            label4.Text = no;
            tname.Text = name;
            tadd.Text = address;
            tam.Enabled = false;
            tam.Text = bill;
            label6.Text = "Bill Amount";
            update_flag = 1;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (update_flag == 0)
                {
                    db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[pbunk]([name],[address],[initial amount],[amount],status)VALUES('" + tname.Text + "','" + tadd.Text + "'," + tam.Text + "," + tam.Text + ",'Available')");
                    MessageBox.Show("Added");
                    this.Close();
                }
                else
                {
                    db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[pbunk]SET [name] = '" + tname.Text + "',[address] = '" + tadd.Text + "' WHERE no=" + label4.Text + "");
                    MessageBox.Show("Updated");
                    this.Close();
                }
            }
        }

        ErrorProvider error = new ErrorProvider();
        private bool Validation()
        {
            error.Dispose();
            bool ret = isempty(tname, "Enter Bunk name") && isempty(tadd, "Enter Petrol bunk address") && isempty(tam, "Enter Bunk Initial Amount") && iscorrect(tam, "Enter Correct Initial Amount");



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
