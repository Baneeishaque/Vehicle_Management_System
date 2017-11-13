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
    public partial class Oil_Registration : Form
    {
        DBhandler db = new DBhandler();
      
        public Oil_Registration()
        {
            InitializeComponent();
            label8.Text = db.max_plus("SELECT max([no.])FROM [AVVMS].[dbo].[oil]").ToString();
            
            DataTable dt = new DataTable();
            dt = db.GetTable("SELECT [Vehicle No.]FROM [AVVMS].[dbo].[Vehicles] where  [Status]='On Maintenence'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                comboBox1.Items.Add(dt.Rows[i]["Vehicle No."].ToString());
            }

            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[oil]([date],[workshop],[address],[bill no.],[remarks],[vehicle no.],[amount],litres)VALUES('" + dateTimePicker1.Value.ToShortDateString() + "','" + twork.Text + "','" + taddress.Text + "','" + tbill.Text + "','" + tre.Text + "','" + comboBox1.SelectedItem.ToString() + "'," + tam.Text + "," + toil.Text + ")");
                db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Vehicles]SET [Status] = 'Available' WHERE [Vehicle No.] = '" + comboBox1.SelectedItem.ToString() + "'");
                MessageBox.Show("Added");
                this.Close();
            }
        }

        ErrorProvider err = new ErrorProvider();
        private bool Validation()
        {

            err.Dispose();

            return isemptyg(new Control[1] { twork }) && isselectedg(new ComboBox[1] { comboBox1 }) && isemptyg(new Control[4] { taddress, tam, tbill,toil }) && iscorrectg(new TextBox[3] { tam, tbill,toil });

        }

        bool isselectedg(System.Windows.Forms.ComboBox[] c)
        {

            bool ret = true;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i].SelectedIndex == 0)
                {

                    err.SetError(c[i], "Required field");
                    c[i].Focus();
                    ret = false;
                    break;
                }
            }

            return ret;
        }

        bool isemptyg(System.Windows.Forms.Control[] c)
        {
            bool ret = true;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i].Text.Equals(""))
                {

                    err.SetError(c[i], "Required field");
                    c[i].Focus();
                    ret = false;
                    break;
                }
            }
            return ret;
        }

        bool iscorrectg(System.Windows.Forms.TextBox[] c)
        {

            bool ret = true;

            for (int i = 0; i < c.Length; i++)
            {
                try
                {

                    Decimal i2 = Convert.ToDecimal(c[i].Text);
                    if (i2 == 0)
                    {
                        err.SetError(c[i], "Required field");
                        c[i].Focus();
                        ret = false;
                        break;
                    }
                }
                catch (FormatException ex)
                {

                    err.SetError(c[i], "Required field");
                    c[i].Focus();
                    ret = false;
                    break;
                }


            }


            return ret;
        }
    }
}
