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
    public partial class Vehicle_Sell : Form
    {
        DBhandler db = new DBhandler();
       
       
        public Vehicle_Sell(string no)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            label6.Text = db.max_plus("SELECT max([Id])FROM [AVVMS].[dbo].[sell]").ToString();
            label2.Text = no;
            dataGridView1.Rows.Add("1", "", "");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                dataGridView1.Rows.Add("1", "", "");
            }
            else
            {

                dataGridView1.Rows.Add("" + (Convert.ToInt32(dataGridView1.Rows[(dataGridView1.Rows.Count - 1)].Cells[0].Value.ToString()) + 1).ToString() + "", "", "");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                MessageBox.Show("Atleast 1 Customer is needed");
            }
            else
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Validation())
            {
                String message = "";
                int c1f = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString().Equals(""))
                    {
                        c1f = 1;
                        if (message.Equals(""))
                        {
                            message = message + "Enter Address For Customer No. : " + (i + 1);
                        }
                        else
                        {
                            message = message + "\nEnter Address For Customer No. : " + (i + 1);
                        }
                    }
                    if (dataGridView1.Rows[i].Cells[2].Value.ToString().Equals(""))
                    {
                        c1f = 1;
                        if (message.Equals(""))
                        {
                            message = message + "Enter Tender Amount For Customer No. : " + (i + 1);
                        }
                        else
                        {
                            message = message + "\nEnter Tender Amount For Customer No. : " + (i + 1);
                        }
                    }
                    else
                    {
                        try
                        {
                            Decimal k = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        }
                        catch (FormatException ex)
                        {
                            c1f = 1;
                            if (message.Equals(""))
                            {
                                message = message + "Enter Correct Qoutation Amount For Supplier No. : " + (i + 1);
                            }
                            else
                            {
                                message = message + "\nEnter Correct Qoutation Amount For Supplier No. : " + (i + 1);
                            }
                        }
                    }
                    if (c1f == 0)
                    {
                        for (int i2 = 0; i2 < dataGridView1.Rows.Count; i2++)
                        {
                            db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[tender]([customer],[tender amount],[vehicle no.]) VALUES ('" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "'," + dataGridView1.Rows[i].Cells[2].Value.ToString() + " ,'" + label2.Text + "')");

                        }
                        db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[sell] ([Tender date] ,[Selected Tender No.],[Tender Amount],[Cheque No.],[Purchase date],vehicle)VALUES('" + dateTimePicker1.Value.ToString() + "','" + tsq.Text + "','" + tam.Text + "','" + tcheck.Text + "','" + dateTimePicker2.Value.ToShortDateString() + "','" + label2.Text + "')");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(message);
                    }

                }
            }
        }

        ErrorProvider err = new ErrorProvider();
        private bool Validation()
        {

            err.Dispose();

            return isemptyg(new Control[3] { tsq, tcheck, tam }) && iscorrectg(new TextBox[3] { tsq, tcheck, tam });

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
                        err.SetError(c[i], "Invalid Value");
                        c[i].Focus();
                        ret = false;
                        break;
                    }
                }
                catch (FormatException ex)
                {

                    err.SetError(c[i], "Invalid Value");
                    c[i].Focus();
                    ret = false;
                    break;
                }


            }


            return ret;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Sell_Report().ShowDialog();
        }
    }
}
