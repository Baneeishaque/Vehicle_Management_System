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
    public partial class Refill_Bill_Input : Form
    {
        DBhandler db = new DBhandler();
        public Refill_Bill_Input()
        {
            InitializeComponent();
            label11.Text = db.max_plus("SELECT max([no])FROM [AVVMS].[dbo].[refill bill]").ToString();
            DataTable dt = new DataTable();
            dt = db.GetTable("SELECT [Vehicle No.]FROM [AVVMS].[dbo].[Vehicles] where [Status]!='Removed'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                comboBoxv.Items.Add(dt.Rows[i]["Vehicle No."].ToString());
            }
            comboBoxv.SelectedIndex = 0;


            dt = db.GetTable("SELECT [no]FROM [AVVMS].[dbo].[pbunk] where [Status]!='Removed'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                comboBoxbunk.Items.Add(dt.Rows[i]["no"].ToString());
            }
            comboBoxbunk.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[refill bill]([date],[vehicle],[bunk],[amount],[remark],litres)VALUES('" + dateTimePicker1.Value.ToShortDateString() + "','" + comboBoxv.SelectedItem.ToString() + "'," + comboBoxbunk.SelectedItem.ToString() + "," + tam.Text + ",'" + tbill.Text + "'," + tpretr.Text + ")");

                db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Vehicles]SET [last refill date] = '" + dateTimePicker1.Value.ToShortDateString() + "' WHERE     ([Vehicle No.] = '" + comboBoxv.SelectedItem.ToString() + "')");

                db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[pbunk]SET [amount] = " + ((Convert.ToDouble(tam.Text)) + (Convert.ToDouble(db.GetValue("SELECT [amount] FROM [AVVMS].[dbo].[pbunk] WHERE     ([no] = " + comboBoxbunk.SelectedItem.ToString() + ")")))) + " WHERE     ([no] = " + comboBoxbunk.SelectedItem.ToString() + ")");

                MessageBox.Show("Added");
                this.Close();
            }
        }


        ErrorProvider error = new ErrorProvider();
        private bool Validation()
        {
            error.Dispose();
            bool ret = isselected(comboBoxv, "Select Vehicle No.") && isselected(comboBoxbunk, "Select Petrol Bunk") && isempty(tam, "Enter Bill Amount") && isempty(tbill, "Enter Bill No.") && isempty(tpretr, "Enter Petrol in Litres") && iscorrect(tam, "Enter Correct Amount") && iscorrect(tbill, "Enter Currect Bill No.")&&iscorrect(tpretr,"Enter correct petrol in litres");



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
