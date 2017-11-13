using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Aryavidyashala_Vehicle_Management_System
{
    public partial class Trip_Completion : Form
    {

        DBhandler db = new DBhandler();
        int jtype;
        Decimal oa;
        DataTable dt;
        private int cal_flag=0;

        String date;
        private int etime_falg=0;
        private int ekm_flag=0;
        private Decimal oac;
        

        public Trip_Completion(string id, string vehicle, string purpose, string name, string address, string mobile, string driver, string startm, string startt,string sdate,string remark,string j,string fc,string sc)
        {
            InitializeComponent();
            

            dateTimePicker1.MinDate = DateTime.Parse(sdate);

            numericUpDown1.Minimum = ((Convert.ToInt32(startm)));
           
           
            DGV_traffic_exception.Rows.Add("Toll Fee","","");
            DGV_traffic_exception.Rows.Add("Parking Fee","","");
            DGV_traffic_exception.Rows.Add("Fuel","","");
            label20.Text = id;
            lb_address.Text = address;
            lb_driver.Text = driver;
            lb_mobile.Text = mobile;
            lb_name.Text = name;
            lb_purpose.Text = purpose;
            lb_smeter.Text = startm;

            lb_vehicle.Text = vehicle;
      

            lb_remarks.Text = remark;
            ld_sdatea.Text = sdate + " " + startt;
            date = sdate;

            lb_j.Text = j;
            lb_fc.Text = fc;
            lb_sc.Text = sc;

            
            label31.Text = db.GetValue("SELECT [mail]FROM [AVVMS].[dbo].[Trips] where [Id]='" + id + "'");
            tefc.Text = db.GetValue("SELECT [heavy extra amount cleaner]FROM [AVVMS].[dbo].[batha]");

            if (db.GetValue("SELECT [Type]FROM [AVVMS].[dbo].[Employee] where [Employee ID]='" + fc + "'").Equals("Permanent"))
            {
                tkmfc.Text = db.GetValue("SELECT [heavy km alavence permanent cleaner]FROM [AVVMS].[dbo].[batha]");

            }
            else
            {
                tkmfc.Text = db.GetValue("SELECT [heavy km alavance temporary cleaner]FROM [AVVMS].[dbo].[batha]");

            }

            if (sc.Equals(""))
            {
                groupBox2.Text=groupBox2.Text+" : For Driver,First Cleaner";
                panel2sc.Hide();
                Common_Tasks.nullify(label4);
                
                jtype = 2;
                
                
            }
            else
            {
                groupBox2.Text = groupBox2.Text + " : For Driver,First Cleaner,Second Cleaner";
                jtype = 3;

                tesc.Text = tefc.Text;
                if (db.GetValue("SELECT [Type]FROM [AVVMS].[dbo].[Employee] where [Employee ID]='" + sc + "'").Equals("Permanent"))
                {
                    tkmsc.Text = db.GetValue("SELECT [heavy km alavence permanent cleaner]FROM [AVVMS].[dbo].[batha]");

                }
                else
                {
                    tkmsc.Text = db.GetValue("SELECT [heavy km alavance temporary cleaner]FROM [AVVMS].[dbo].[batha]");

                }
            }


            lb_b.Hide();
            txt_hbatha.Hide();

            ebatha.Text = db.GetValue("SELECT [heavy extra amount driver]FROM [AVVMS].[dbo].[batha]");
            hbatha.Text = db.GetValue("SELECT [heavy hault batha]FROM [AVVMS].[dbo].[batha]");
            tkmdheavy.Text = db.GetValue("SELECT [heavy km alavence driver]FROM [AVVMS].[dbo].[batha]");

            ini_flag=1;


        }

        public Trip_Completion(string id, string vehicle, string purpose, string name, string address, string mobile, string driver, string startm, string startt, string sdate, string remark, string j)
        {
            InitializeComponent();
            jtype = 1;
            dateTimePicker1.MinDate = DateTime.Parse(sdate);

            numericUpDown1.Minimum = ((Convert.ToInt32(startm)));

            DGV_traffic_exception.Rows.Add("Toll Fee", "", "");
            DGV_traffic_exception.Rows.Add("Parking Fee", "", "");
            DGV_traffic_exception.Rows.Add("Fuel", "", "");
            label20.Text = id;
            lb_address.Text = address;
            lb_driver.Text = driver;
            lb_mobile.Text = mobile;
            lb_name.Text = name;
            lb_purpose.Text = purpose;
            lb_smeter.Text = startm;

            lb_vehicle.Text = vehicle;


            lb_remarks.Text = remark;
            ld_sdatea.Text = sdate + " " + startt;
            date = sdate;

            lb_j.Text = j;
            
       

            Common_Tasks.nullify(lb_fc);
            Common_Tasks.nullify(lb_sc);
            Common_Tasks.nullify(label11);
            Common_Tasks.nullify(label4);

    
            label31.Text = db.GetValue("SELECT [mail]FROM [AVVMS].[dbo].[Trips] where [Id]='" + id + "'");

            groupBox2.Text = groupBox2.Text + " : For Driver";

            lbextraheavy.Hide();
            tkmdheavy.Hide();
            panelheavy.Hide();

            lb_b.Hide();
            txt_hbatha.Hide();

            ebatha.Text = db.GetValue("SELECT [light extra amount]FROM [AVVMS].[dbo].[batha]");
            hbatha.Text = db.GetValue("SELECT [light hault batha]FROM [AVVMS].[dbo].[batha]");
            ini_flag=1;
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
            DGV_traffic_exception.Rows.Add("", "", "");
        }

        
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            etime_falg = 1;
            if (ekm_flag == 1)
            {
                batha_calculation();

            }
           

            
            
        }

        private void batha_calculation()
        {
                DateTime dts = DateTime.Parse(ld_sdatea.Text);

                DateTime dtc = DateTime.Parse(dateTimePicker1.Value.ToShortDateString() + " " + timePicker.Value.ToShortTimeString());
                TimeSpan r = dtc.Subtract(dts);

                lb_etime.Text = r.TotalHours.ToString();

                lb_b.Hide();
                txt_hbatha.Hide();

                if (jtype == 1)
                {



                    if ((Convert.ToDecimal(r.TotalHours.ToString()) > 6) || ((Convert.ToDecimal(lb_ekm.Text)) > 70))
                    {
                        lb_b.Text = "Full Batha";
                        txt_hbatha.Text = db.GetValue("SELECT [light full Batha]FROM [AVVMS].[dbo].[batha]");
                        txt_hbatha.Show();
                        lb_b.Show();
                    }
                    else
                    {
                        if ((Convert.ToDecimal(lb_ekm.Text)) > 16)
                        {
                            lb_b.Text = "Half Batha";
                            txt_hbatha.Text = db.GetValue("SELECT [Light half Batha]FROM [AVVMS].[dbo].[batha]");
                            txt_hbatha.Show();
                            lb_b.Show();
                        }
                        
                            
                        
                    }

                }
                else
                {
                    if ((Convert.ToDecimal(r.TotalHours.ToString()) > 6) || ((Convert.ToDecimal(lb_ekm.Text)) > 70))
                    {
                        lb_b.Text = "Full Batha";
                        txt_hbatha.Text = db.GetValue("SELECT [heavy full Batha]FROM [AVVMS].[dbo].[batha]");
                        txt_hbatha.Show();
                        lb_b.Show();
                    }
                    else
                    {
                        if ((Convert.ToDecimal(lb_ekm.Text)) > 16)
                        {
                            lb_b.Text = "Half Batha";
                            txt_hbatha.Text = db.GetValue("SELECT [heavy half Batha]FROM [AVVMS].[dbo].[batha]");
                            txt_hbatha.Show();
                            lb_b.Show();
                        }
                    }

                }
            
            
        }

       
        
        private void textBox14_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                error.Dispose();
                if (cal_flag == 1)
                {
                    db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Trips]SET [status] = 'Complete',km=" + lb_ekm.Text + " WHERE [Id]='" + label20.Text + "'");

                    db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Vehicles]SET [Status] = 'Available', [Meter Reading]=" + numericUpDown1.Value + ",[fuel]=" + lb_rfuel.Text + " WHERE [Vehicle No.] = '" + lb_vehicle.Text + "'");

                    if ((Convert.ToDouble(dt.Rows[0]["Fuel Refill Limit"].ToString())) >= (Convert.ToDouble(lb_rfuel.Text)))
                    {
                        db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Refill_Notifications]([Vehicle],[Remain],[Limit],[LastRefillDate])VALUES('" + lb_vehicle.Text + "'," + lb_rfuel.Text + "," + dt.Rows[0]["Fuel Refill Limit"].ToString() + ",'" + db.GetValue("SELECT     [last refill date]FROM         Vehicles WHERE     ([Vehicle No.] = '" + lb_vehicle.Text + "')") + "')");
                        Program.pi.Display("Vehicle No. " + lb_vehicle.Text + " is in refill stage");
                    }

                    db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Employee]SET [Status] = 'Available'WHERE [Employee ID] = '" + lb_driver.Text + "'");

                    if (!lb_fc.Text.Equals(""))
                    {
                        db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Employee]SET [Status] = 'Available'WHERE [Employee ID] = '" + lb_fc.Text + "'");
                    }

                    if (!lb_sc.Text.Equals(""))
                    {
                        db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Employee]SET [Status] = 'Available'WHERE [Employee ID] = '" + lb_sc.Text + "'");
                    }

                    if (txt_hbatha.Visible)
                    {
                        db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Batha_Report]([Trip No.],[Date],[Batha],[Batha Amount],[Employee ID])VALUES('" + label20.Text + "','" + date + "','" + lb_b.Text + "','" + txt_hbatha.Text + "','" + lb_driver.Text + "')");
                    }

                    try
                    {
                        MailMessage email = new MailMessage();
                        email.From = new MailAddress("avvmskottakkal@gmail.com");
                        email.To.Add(label31.Text);
                        email.Body = "Your Trip Expense " + lb_total.Text;
                        email.Subject = "Arya Vydya Shala Trip ";

                        SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                        mailclient.Credentials = new NetworkCredential("avvmskottakkal", "9895091284");
                        mailclient.EnableSsl = true;

                        //SmtpClient mailclient = new SmtpClient("localhost", 25);
                        //mailclient.Credentials = new NetworkCredential("baneeishaque@localhost.com", "9895204814");


                        mailclient.Send(email);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mailing Failure...\nReason : " + ex.Message + "\n" + ex.HelpLink);
                    }

                    MessageBox.Show("De-Assigned Successfully");

                    this.Close();

                }

                else
                {

                    int c1f = 0;
                    oa = 0;
                    for (int i = 0; i < DGV_traffic_exception.Rows.Count; i++)
                    {
                        if (DGV_traffic_exception.Rows[i].Cells[0].Value.ToString().Equals(""))
                        {
                            c1f = 1;
                            MessageBox.Show("Enter Description For Overhead Expense " + (i + 1));
                        }

                    }
                    if (c1f == 0)
                    {
                        for (int i = 0; i < DGV_traffic_exception.Rows.Count; i++)
                        {
                            if (DGV_traffic_exception.Rows[i].Cells[1].Value.ToString().Equals(""))
                            {
                                c1f = 1;
                                MessageBox.Show("Enter Amount For Overhead Expense " + (i + 1));
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
                                    MessageBox.Show("Enter Correct Amount For Overhead Expense " + (i + 1));
                                }
                            }

                        }
                    }
                    if (c1f == 0)
                    {
                        if (carebatha())
                        {
                            for (int i = 0; i < DGV_traffic_exception.Rows.Count; i++)
                            {
                                oa = oa + Convert.ToDecimal(DGV_traffic_exception.Rows[i].Cells[1].Value.ToString());


                            }

                            if (jtype == 1)
                            {
                                lb_total.Text = ((Convert.ToDecimal(ebatha.Text)) + (Convert.ToDecimal(hbatha.Text)) + (Convert.ToDecimal(txt_hbatha.Text)) + oa).ToString();
                            }
                            else if (jtype == 2)
                            {
                                lbchault.Text = lbchault.Text + " *2";
                                lb_b.Text = lb_b.Text + " *2";
                                lb_total.Text = ((Convert.ToDecimal(ebatha.Text)) + ((Convert.ToDecimal(hbatha.Text)) * 2) + ((Convert.ToDecimal(txt_hbatha.Text)) * 2) + (Convert.ToDecimal(tkmdheavy.Text)) + (Convert.ToDecimal(tefc.Text)) + (Convert.ToDecimal(tkmfc.Text)) + oa).ToString();
                            }
                            else if (jtype == 3)
                            {
                                lbchault.Text = lbchault.Text + " *3";
                                lb_b.Text = lb_b.Text + " *3";
                                lb_total.Text = ((Convert.ToDecimal(ebatha.Text)) + ((Convert.ToDecimal(hbatha.Text)) * 3) + ((Convert.ToDecimal(txt_hbatha.Text)) * 3) + (Convert.ToDecimal(tkmdheavy.Text)) + (Convert.ToDecimal(tefc.Text)) + (Convert.ToDecimal(tkmfc.Text)) + (Convert.ToDecimal(tesc.Text)) + (Convert.ToDecimal(tkmsc.Text)) + oa).ToString();
                            }
                            lb_total.Show();
                            cal_flag = 1;
                            button2.Hide();
                            button3.Hide();

                            DGV_traffic_exception.ReadOnly = true;
                            Common_Tasks.disable(ebatha);
                            Common_Tasks.disable(txt_hbatha);
                            Common_Tasks.disable(hbatha);
                            Common_Tasks.disable(numericUpDown1);

                            oac = 0;
                            for (int i = 0; i < DGV_traffic_exception.Rows.Count; i++)
                            {

                                oac = oac + Convert.ToDecimal(DGV_traffic_exception.Rows[i].Cells[1].Value.ToString());
                            }
                            total.Text = "Total : " + oac.ToString();

                            Common_Tasks.disable(dateTimePicker1);
                            Common_Tasks.disable(timePicker);

                            Common_Tasks.disable(panelheavy);
                            Common_Tasks.disable(tkmdheavy);

                            button1.Text = "Submit,Mail";
                        }
                    }



                }
            }

            
        }

        private bool carebatha()
        {
            return bathacorrect(ebatha,"Enter Corrcet Value")&&bathacorrect(hbatha, "Enter Corrcet Value")&&bathacorrect(txt_hbatha, "Enter Corrcet Value")&&bathacorrect(tkmdheavy, "Enter Corrcet Value")&&bathacorrect(tefc, "Enter Corrcet Value")&&bathacorrect(tkmfc, "Enter Corrcet Value")&&bathacorrect(tesc, "Enter Corrcet Value")&&bathacorrect(tkmsc, "Enter Corrcet Value");
        }

        bool bathacorrect(System.Windows.Forms.TextBox c,String text)
        {
            bool ret = true;
            if (c.Text.Equals(""))
            {
                c.Text = "0";
            }
            else
            {
                try
                {

                    Decimal i = Convert.ToDecimal(c.Text);
                    
                }
                catch (FormatException ex)
                {
                    ret = false;
                    error.SetError(c, text);
                    c.Focus();
                    
                }

            }
            return ret;
        }

        ErrorProvider error = new ErrorProvider();
        private  int ini_flag=0;
        

        

        

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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            if (ini_flag == 1)
            {
                lb_ekm.Text = (numericUpDown1.Value - (Convert.ToDecimal(lb_smeter.Text))).ToString();
                dt = new DataTable();
                dt = db.GetTable("SELECT [Fuel Capacity],[fuel],[Fuel Refill Limit]FROM [AVVMS].[dbo].[Vehicles] where [Vehicle No.]='" + lb_vehicle.Text + "'");
                lb_efuel.Text = ((Convert.ToDouble(lb_ekm.Text)) / (Convert.ToDouble(dt.Rows[0]["Fuel Capacity"].ToString()))).ToString();
                lb_rfuel.Text = ((Convert.ToDouble(dt.Rows[0]["fuel"].ToString())) - (Convert.ToDouble(lb_efuel.Text))).ToString();

                ekm_flag = 1;
                if (etime_falg == 1)
                {
                    batha_calculation();
                }

            }
        }

        bool Validation()
        {
            return numericupdownselectg(new NumericUpDown[1] { numericUpDown1 });
        }

        
        public bool numericupdownselectg(NumericUpDown[] c)
        {
            bool ret=true;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i].Value == c[i].Minimum)
                {

                    error.SetError(c[i], "Invalid Value");
                    c[i].Focus();
                    ret = false;
                    break;
                }
            }

            return ret;
            
        }

    }
}
