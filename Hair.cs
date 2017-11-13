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
    
    public partial class Hair : Form
    {
        DBhandler db = new DBhandler();

        private double oa;
        
        private int print_flag=0;
        public Hair()
        {
            InitializeComponent();
            DGV_traffic_exception.Rows.Add("Toll Fee","","","");
            DGV_traffic_exception.Rows.Add("Parking Fee", "", "","");
            DGV_traffic_exception.Rows.Add("Fuel", "", "","");
            lno.Text = db.max_plus("select MAX([no]) FROM [AVVMS].[dbo].[hair]").ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DGV_traffic_exception.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Selection");
            }
            else
            {
                DGV_traffic_exception.Rows.Remove(DGV_traffic_exception.SelectedRows[0]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DGV_traffic_exception.Rows.Add("", "", "","");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (print_flag == 0)
                {
                    int c1f = 0;
                    oa = 0;
                    for (int i = 0; i < DGV_traffic_exception.Rows.Count; i++)
                    {
                        if (DGV_traffic_exception.Rows[i].Cells[0].Value.ToString().Equals(""))
                        {
                            c1f = 1;
                            MessageBox.Show("Enter Description For Row " + (i + 1));
                        }

                    }
                    if (c1f == 0)
                    {
                        for (int i = 0; i < DGV_traffic_exception.Rows.Count; i++)
                        {
                            if (DGV_traffic_exception.Rows[i].Cells[1].Value.ToString().Equals(""))
                            {
                                c1f = 1;
                                MessageBox.Show("Enter Amount For Row " + (i + 1));
                            }
                            else
                            {
                                try
                                {
                                    Decimal k = Convert.ToDecimal(DGV_traffic_exception.Rows[i].Cells[1].Value.ToString());
                                }
                                catch (FormatException ex)
                                {
                                    c1f = 1;
                                    MessageBox.Show("Enter Correct Amount For Row " + (i + 1));
                                }
                            }

                        }
                    }
                    if (c1f == 0)
                    {
                        for (int i = 0; i < DGV_traffic_exception.Rows.Count; i++)
                        {
                            oa = oa + Convert.ToDouble(DGV_traffic_exception.Rows[i].Cells[1].Value.ToString());


                        }

                        lb_total.Text = ((Convert.ToDouble(lb_a.Text)) + oa).ToString();
                        lb_total.Show();
                       
                        print_flag = 1;
                        button4.Text = "Print";
                    }
                }
                else
                {
                    db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[hair]([date],[entry],[Vehicle],[pay],[remarks],[km],[run],[total],[purpose],[am])VALUES('" + dateTimePickerdate.Value.ToShortDateString() + "','" + dateTimePickerentry.Value.ToShortDateString() + "','" + tve.Text + "','" + tpay.Text + "','" + trem.Text + "','" + tkm.Text + "','" + trun.Text + "','" + lb_total.Text + "','" + tpur.Text + "','" + lb_a.Text + "')");
                    
                    

                    if (DGV_traffic_exception.Rows.Count != 0)
                    {
                        for (int i = 0; i < DGV_traffic_exception.Rows.Count; i++)
                        {
                            db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[overhead expenses]([description],[amount],[bill],[remarks])VALUES('" + DGV_traffic_exception.Rows[i].Cells[0].Value.ToString() + "','" + DGV_traffic_exception.Rows[i].Cells[1].Value.ToString() + "','" + DGV_traffic_exception.Rows[i].Cells[2].Value.ToString() + "','" + DGV_traffic_exception.Rows[i].Cells[3].Value.ToString() + "')");


                        }
                        new Print_Hair_Over().ShowDialog();
                        db.Ins_Up_Del("DELETE FROM [AVVMS].[dbo].[overhead expenses]");
                    }
                    else
                    {
                        new Print_Hair().ShowDialog();
                    }
                    this.Close();





                }
            }

            
        }

        ErrorProvider error = new ErrorProvider();
        private bool Validation()
        {
            error.Dispose();
            bool ret = isempty(tve, "Enter Vehicle No.") && isempty(tpay, "Enter Payee Name") && isempty(tpur, "Enter Journey Purpose") && isempty(tkm, "Enter KM Rate") && isempty(trun, "Enter Running KM") && iscorrect(tkm, "Enter Correct KM Rate") && iscorrect(trun, "Enter Currect Running KM");
            


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


        

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (iscorrect(tkm, "Enter Correct KM Rate"))
            {
                error.Dispose();
                if (iscorrect(trun, "Enter Correct Running KM"))
                {
                    error.Dispose();
                    lb_a.Text = ((Convert.ToDouble(tkm.Text)) * (Convert.ToDouble(trun.Text))).ToString();
                }
            }
        }
    }
}
