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
    public partial class Tax_Reciept_Input : Form
    {
        DBhandler db = new DBhandler();
        DataTable dt=new DataTable();
        public Tax_Reciept_Input()
        {
            InitializeComponent();

            dt=db.GetTable("SELECT [Vehicle No.]     FROM [AVVMS].[dbo].[Vehicles] where Status != 'Removed'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                comboBoxvehicle.Items.Add(dt.Rows[i]["Vehicle No."].ToString());
            }

            comboBoxvehicle.SelectedIndex = 0;
            comboBoxpmode.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[tax]([no.],[date],[to],[payement mode],[document code],[document date],[remarks],[from],[vehicle no.],[amount])VALUES('" + tno.Text + "','" + dateTimePickerdate.Value.ToShortDateString() + "','" + dateTimePickerto.Value.ToShortDateString() + "','" + comboBoxpmode.SelectedItem.ToString() + "','" + tdcode.Text + "','" + dateTimePickerddte.Value.ToShortDateString() + "','" + tremark.Text + "','" + dateTimePickerfrom.Value.ToShortDateString() + "','" + comboBoxvehicle.SelectedItem.ToString() + "','" + tam.Text + "')");

                db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Vehicles]SET [Tax Expiry date] = '" + dateTimePickerto.Value.ToShortDateString() + "' WHERE     ([Vehicle No.] = '" + comboBoxvehicle.SelectedItem.ToString() + "')");

                if ((DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15).CompareTo(DateTime.Parse(dateTimePickerto.Value.ToShortDateString()))) >= 0)
                {
                    db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Vehicle_Notifications]([Vehicle],[Reason],[Remarks])VALUES('" + comboBoxvehicle.SelectedItem.ToString() + "','Tax Certificate of Vehicle No. : " + comboBoxvehicle.SelectedItem.ToString() + " will expire On : " + dateTimePickerto.Value.ToShortDateString() + "','Expiration Date : " + dateTimePickerto.Value.ToShortDateString() + "')");

                    db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Vehicles]SET [status] = 'On Certificate Expiration' WHERE [Vehicle No.]='" + comboBoxvehicle.SelectedItem.ToString() + "'");

                    Program.pi.Display("Tax Certificate of Vehicle No. : " + comboBoxvehicle.SelectedItem.ToString() + " will expire On : " + dateTimePickerto.Value.ToShortDateString() + "");



                }

                MessageBox.Show("In Success");
                this.Close();
            }
        }


        ErrorProvider err = new ErrorProvider();
        private bool Validation()
        {

            err.Dispose();

            return isemptyg(new Control[1] { tno }) && isselectedg(new ComboBox[1] { comboBoxvehicle }) && isemptyg(new Control[1] { tam }) && isselectedg(new ComboBox[1] { comboBoxpmode }) && isemptyg(new Control[1] { tdcode }) && iscorrectg(new TextBox[2] { tam, tdcode });

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
