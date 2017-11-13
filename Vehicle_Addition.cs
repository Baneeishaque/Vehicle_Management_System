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
    public partial class Vehicle_Addition : Form
    {
        DBhandler db = new DBhandler();
        ErrorProvider e = new ErrorProvider();
        private DateTimePicker oDateTimePicker;
        private int update_flag=0;
       
        public Vehicle_Addition()
        {
            InitializeComponent();
           
          
            combofuel.SelectedIndex = 0;
            combotype.SelectedIndex = 0;
            dataGridView1.Rows.Add("1", "", "");

            DGV_traffic_exception.Rows.Add("Kallayi Road Branch",DateTime.Now.ToShortDateString());
            DGV_traffic_exception.Rows.Add("Mavoor Road Branch", DateTime.Now.ToShortDateString());
            DGV_traffic_exception.Rows.Add("Ernamkulam Road Branch", DateTime.Now.ToShortDateString());
            
        }

        public Vehicle_Addition(string no, string vtype, string meter, string fcapac, string engineno, string horse, string ftype, string model, string frefilllimit, string enginecc, string chasisno, string color, string milage, string taxdate, string rcdate, string permitdate, string insudate)
        {
            // TODO: Complete member initialization
            InitializeComponent();

            this.Text = "Vehicle Updation";

            DataTable dt = new DataTable();
            dt = db.GetTable("SELECT [weight],[Quotatio date],[Selected Quotation No.],[Cheque No.],[Purchase Amount],[Purchase date],[CF date],[Pollution Certificate Expiry date],[Green Tax Expiry date],[fuel]FROM [AVVMS].[dbo].[Vehicles] where [Vehicle No.]='" + no + "'");

            tno.Text = no;
            tno.Enabled = false;

            combotype.SelectedItem = vtype;
            combotype.Enabled = false;
            
            tmeter.Text = meter;
            tmeter.Enabled = false;
            
            tfcapacity.Text = fcapac;
            tfcapacity.Enabled = false;

            //groupBox1.Enabled = false;

            teno.Text = engineno;
            teno.Enabled = false;

            thorse.Text = horse;
            thorse.Enabled = false; 
            
            tweight.Text = dt.Rows[0]["weight"].ToString();
            tweight.Enabled = false;

            combofuel.SelectedItem = ftype;
            combofuel.Enabled = false;

            tmodel.Text = model;
            tmodel.Enabled = false;

            tfrefill.Text = frefilllimit;
            tfrefill.Enabled = false;

            tecc.Text = enginecc;
            tecc.Enabled = false;

            tchasis.Text = chasisno;
            tchasis.Enabled = false;

            tcolor.Text = color;
            tcolor.Enabled = false;

            tmila.Text = milage;
            tmila.Enabled = false;

            dateTimePickerqdate.Value = DateTime.Parse(dt.Rows[0]["Quotatio date"].ToString());
            dateTimePickerqdate.Enabled = false;

            tsupplierno.Text = dt.Rows[0]["Selected Quotation No."].ToString();
            tsupplierno.Enabled = false;

            tchequeno.Text = dt.Rows[0]["Cheque No."].ToString();
            tchequeno.Enabled = false;

            tpurchaseno.Text = dt.Rows[0]["Purchase Amount"].ToString();
            tpurchaseno.Enabled = false;

            dateTimePickerpurchase.Value = DateTime.Parse(dt.Rows[0]["Purchase date"].ToString());
            dateTimePickerpurchase.Enabled = false;

            dateTimePickertax.Value = DateTime.Parse(taxdate);
            dateTimePickertax.Enabled = false;

            dateTimePickerrc.Value = DateTime.Parse(rcdate);
            dateTimePickercf.Value = DateTime.Parse(dt.Rows[0]["CF date"].ToString());
            dateTimePickerpollution.Value = DateTime.Parse(dt.Rows[0]["Pollution Certificate Expiry date"].ToString());
            dateTimePickerpermit.Value = DateTime.Parse(permitdate);
            dateTimePickergreen.Value = DateTime.Parse(dt.Rows[0]["Green Tax Expiry date"].ToString());
            
            dateTimePickerinsurance.Value = DateTime.Parse(insudate);
            dateTimePickerinsurance.Enabled = false;

            button5.Hide();
            button2.Hide();

            dataGridView1.ReadOnly = true;

            dt = db.GetTable("SELECT [supplier],[quotation amount]FROM [AVVMS].[dbo].[qoutation]where [vehicle no.]='" + no + "'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                dataGridView1.Rows.Add("" + (i + 1).ToString() + "", "" + dt.Rows[i]["supplier"].ToString() + "", "" + dt.Rows[i]["quotation amount"].ToString() + "");
            }

            dt = db.GetTable("SELECT [traffic exception due],[expiry date] FROM [AVVMS].[dbo].[traffic exception]where [vehicle no.]='" + no + "'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                DGV_traffic_exception.Rows.Add("" + dt.Rows[i]["traffic exception due"].ToString() + "", "" + dt.Rows[i]["expiry date"].ToString() + "");
            }

            update_flag = 1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (update_flag == 0)
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
                                message = message + "Enter Address For Supplier No. : " + (i + 1);
                            }
                            else
                            {
                                message = message + "\nEnter Address For Supplier No. : " + (i + 1);
                            }
                        }
                        if (dataGridView1.Rows[i].Cells[2].Value.ToString().Equals(""))
                        {
                            c1f = 1;
                            if (message.Equals(""))
                            {
                                message = message + "Enter Qoutation Amount For Supplier No. : " + (i + 1);
                            }
                            else
                            {
                                message = message + "\nEnter Qoutation Amount For Supplier No. : " + (i + 1);
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

                    }
                    for (int i = 0; i < DGV_traffic_exception.Rows.Count; i++)
                    {
                        if (DGV_traffic_exception.Rows[i].Cells[0].Value.ToString().Equals(""))
                        {
                            c1f = 1;
                            if (message.Equals(""))
                            {
                                message = message + "Enter Description For Traffic Exception No. : " + (i + 1);
                            }
                            else
                            {
                                message = message + "\nEnter Description For Traffic Exception No. : " + (i + 1);
                            }
                        }
                        if (DGV_traffic_exception.Rows[i].Cells[1].Value.ToString().Equals(""))
                        {
                            c1f = 1;
                            if (message.Equals(""))
                            {
                                message = message + "Enter Expiry Date For Traffic Exception No. : " + (i + 1);
                            }
                            else
                            {
                                message = message + "\nEnter Expiry Date For Traffic Exception No. : " + (i + 1);
                            }
                        }

                    }
                    if (c1f == 0)
                    {
                        try
                        {
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[qoutation]([supplier],[quotation amount],[vehicle no.]) VALUES ('" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "'," + dataGridView1.Rows[i].Cells[2].Value.ToString() + " ,'" + tno.Text + "')");

                            }
                            String n = "";
                            if (DGV_traffic_exception.Rows.Count != 0)
                            {

                                for (int i = 0; i < DGV_traffic_exception.Rows.Count; i++)
                                {
                                    db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[traffic exception]([traffic exception due],[expiry date],[vehicle no.]) VALUES ('" + DGV_traffic_exception.Rows[i].Cells[0].Value.ToString() + "','" + DGV_traffic_exception.Rows[i].Cells[1].Value.ToString() + "' ,'" + tno.Text + "')");

                                    if ((DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15).CompareTo(DateTime.Parse(DGV_traffic_exception.Rows[i].Cells[1].Value.ToString()))) >= 0)
                                    {
                                        db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Vehicle_Notifications]([Vehicle],[Reason],[Remarks])VALUES('" + tno.Text + "','Traffic Exception Due Certificate-" + DGV_traffic_exception.Rows[i].Cells[0].Value.ToString() + " of Vehicle No. : " + tno.Text + " will expire On : " + DGV_traffic_exception.Rows[i].Cells[1].Value.ToString() + "','Expiration Date : " + DGV_traffic_exception.Rows[i].Cells[1].Value.ToString() + "')");
                                        if (n.Equals(""))
                                        {
                                            n = n + "Traffic Exception Due Certificate-" + DGV_traffic_exception.Rows[i].Cells[0].Value.ToString() + " of Vehicle No. : " + tno.Text + " will expire On : " + DGV_traffic_exception.Rows[i].Cells[1].Value.ToString() + "";
                                        }
                                        else
                                        {
                                            n = n + "\nTraffic Exception Due Certificate-" + DGV_traffic_exception.Rows[i].Cells[0].Value.ToString() + " of Vehicle No. : " + tno.Text + " will expire On : " + DGV_traffic_exception.Rows[i].Cells[1].Value.ToString() + "";
                                        }



                                    }

                                }
                            }

                            db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Vehicles]([Vehicle No.],[Type],[Model],[Fuel Capacity],[Fuel Refill Limit],[Meter Reading],[Engine No.],[Horse Power],[Chasis No.],[Fuel Type],[Color],[Engine CC],[Quotatio date],[Selected Quotation No.],[Purchase Amount],[Cheque No.],[Purchase date],[Tax Expiry date],[RC Expiry date],[Insurance Expiry date],[CF date],[Pollution Certificate Expiry date],[Permit Expiry date],[Green Tax Expiry date],[Status],[fuel],[Full tank],weight)VALUES('" + tno.Text + "','" + combotype.SelectedItem.ToString() + "','" + tmodel.Text + "'," + tmila.Text + "," + tfrefill.Text + "," + tmeter.Text + ",'" + teno.Text + "','" + thorse.Text + "','" + tchasis.Text + "','" + combofuel.Text + "','" + tcolor.Text + "','" + tecc.Text + "','" + dateTimePickerqdate.Value.ToShortDateString() + "','" + tsupplierno.Text + "','" + tpurchaseno.Text + "','" + tchequeno.Text + "','" + dateTimePickerpurchase.Value.ToShortDateString() + "','" + dateTimePickertax.Value.ToShortDateString() + "','" + dateTimePickerrc.Value.ToShortDateString() + "','" + dateTimePickerinsurance.Value.ToShortDateString() + "','" + dateTimePickercf.Value.ToShortDateString() + "','" + dateTimePickerpollution.Value.ToShortDateString() + "','" + dateTimePickerpermit.Value.ToShortDateString() + "','" + dateTimePickergreen.Value.ToShortDateString() + "','Available'," + tfcapacity.Text + "," + tfcapacity.Text + "," + tweight.Text + ")");

                            MessageBox.Show("Inserted Successfully");


                            String m = "";

                            if ((DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15).CompareTo(DateTime.Parse(dateTimePickertax.Value.ToShortDateString()))) >= 0)
                            {
                                db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Vehicle_Notifications]([Vehicle],[Reason],[Remarks])VALUES('" + tno.Text + "','Tax Certificate of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickertax.Value.ToShortDateString() + "','Expiration Date : " + dateTimePickertax.Value.ToShortDateString() + "')");
                                if (m.Equals(""))
                                {
                                    m = m + "Tax Certificate of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickertax.Value.ToShortDateString() + "";
                                }
                                else
                                {
                                    m = m + "\nTax Certificate of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickertax.Value.ToShortDateString() + "";
                                }



                            }

                            if ((DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15).CompareTo(DateTime.Parse(dateTimePickerrc.Value.ToShortDateString()))) >= 0)
                            {
                                db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Vehicle_Notifications]([Vehicle],[Reason],[Remarks])VALUES('" + tno.Text + "','RC of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerrc.Value.ToShortDateString() + "','Expiration Date : " + dateTimePickerrc.Value.ToShortDateString() + "')");

                                if (m.Equals(""))
                                {
                                    m = m + "RC of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerrc.Value.ToShortDateString() + "";
                                }
                                else
                                {
                                    m = m + "\nRC of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerrc.Value.ToShortDateString() + "";
                                }



                            }

                            if ((DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15).CompareTo(DateTime.Parse(dateTimePickerinsurance.Value.ToShortDateString()))) >= 0)
                            {
                                db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Vehicle_Notifications]([Vehicle],[Reason],[Remarks])VALUES('" + tno.Text + "','Insurance of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerinsurance.Value.ToShortDateString() + "','Expiration Date : " + dateTimePickerinsurance.Value.ToShortDateString() + "')");

                                if (m.Equals(""))
                                {
                                    m = m + "Insurance of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerinsurance.Value.ToShortDateString() + "";
                                }
                                else
                                {
                                    m = m + "\nInsurance of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerinsurance.Value.ToShortDateString() + "";
                                }



                            }

                            if ((DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15).CompareTo(DateTime.Parse(dateTimePickercf.Value.ToShortDateString()))) >= 0)
                            {
                                db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Vehicle_Notifications]([Vehicle],[Reason],[Remarks])VALUES('" + tno.Text + "','CF of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickercf.Value.ToShortDateString() + "','Expiration Date : " + dateTimePickercf.Value.ToShortDateString() + "')");

                                if (m.Equals(""))
                                {
                                    m = m + "Cf of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickercf.Value.ToShortDateString() + "";
                                }
                                else
                                {
                                    m = m + "\nCf of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickercf.Value.ToShortDateString() + "";
                                }



                            }

                            if ((DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15).CompareTo(DateTime.Parse(dateTimePickerpollution.Value.ToShortDateString()))) >= 0)
                            {
                                db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Vehicle_Notifications]([Vehicle],[Reason],[Remarks])VALUES('" + tno.Text + "','Pollution Certificate of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerpollution.Value.ToShortDateString() + "','Expiration Date : " + dateTimePickerpollution.Value.ToShortDateString() + "')");

                                if (m.Equals(""))
                                {
                                    m = m + "Pollution Certificate of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerpollution.Value.ToShortDateString() + "";
                                }
                                else
                                {
                                    m = m + "\nPollution Certificate of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerpollution.Value.ToShortDateString() + "";
                                }




                            }

                            if ((DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15).CompareTo(DateTime.Parse(dateTimePickerpermit.Value.ToShortDateString()))) >= 0)
                            {
                                db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Vehicle_Notifications]([Vehicle],[Reason],[Remarks])VALUES('" + tno.Text + "','Permit of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerpermit.Value.ToShortDateString() + "','Expiration Date : " + dateTimePickerpermit.Value.ToShortDateString() + "')");

                                if (m.Equals(""))
                                {
                                    m = m + "Permit of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerpermit.Value.ToShortDateString() + "";
                                }
                                else
                                {
                                    m = m + "\nPermit of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerpermit.Value.ToShortDateString() + "";
                                }




                            }

                            if ((DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15).CompareTo(DateTime.Parse(dateTimePickergreen.Value.ToShortDateString()))) >= 0)
                            {
                                db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Vehicle_Notifications]([Vehicle],[Reason],[Remarks])VALUES('" + tno.Text + "','Green Tax Certificate of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickergreen.Value.ToShortDateString() + "','Expiration Date : " + dateTimePickergreen.Value.ToShortDateString() + "')");

                                if (m.Equals(""))
                                {
                                    m = m + "Green Tax Certificate of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickergreen.Value.ToShortDateString() + "";
                                }
                                else
                                {
                                    m = m + "\nGreen Tax Certificate of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickergreen.Value.ToShortDateString() + "";
                                }



                            }

                            if (!n.Equals(""))
                            {

                                if (m.Equals(""))
                                {
                                    m = m + n;
                                }
                                else
                                {
                                    m = m + "\n" + n;
                                }
                            }

                            if (!m.Equals(""))
                            {
                                db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Vehicles]SET [status] = 'On Certificate Expiration' WHERE [Vehicle No.]='" + tno.Text + "'");
                                Program.pi.Display(m);
                            }



                            this.Close();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Try Again...\nReason : " + ex.Message);



                            db.close();

                        }
                    }
                    else
                    {
                        MessageBox.Show(message);
                    }
                }
                else
                {
                    String message = "";
                    int c1f = 0;


                    for (int i = 0; i < DGV_traffic_exception.Rows.Count; i++)
                    {
                        if (DGV_traffic_exception.Rows[i].Cells[0].Value.ToString().Equals(""))
                        {
                            c1f = 1;
                            if (message.Equals(""))
                            {
                                message = message + "Enter Description For Traffic Exception No. : " + (i + 1);
                            }
                            else
                            {
                                message = message + "\nEnter Description For Traffic Exception No. : " + (i + 1);
                            }
                        }
                        if (DGV_traffic_exception.Rows[i].Cells[1].Value.ToString().Equals(""))
                        {
                            c1f = 1;
                            if (message.Equals(""))
                            {
                                message = message + "Enter Expiry Date For Traffic Exception No. : " + (i + 1);
                            }
                            else
                            {
                                message = message + "\nEnter Expiry Date For Traffic Exception No. : " + (i + 1);
                            }
                        }

                    }
                    if (c1f == 0)
                    {
                        try
                        {

                            String n = "";
                            if (DGV_traffic_exception.Rows.Count != 0)
                            {

                                db.Ins_Up_Del("DELETE FROM [AVVMS].[dbo].[traffic exception] WHERE [Vehicle No.]='" + tno.Text + "'");

                                for (int i = 0; i < DGV_traffic_exception.Rows.Count; i++)
                                {
                                    db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[traffic exception]([traffic exception due],[expiry date],[vehicle no.]) VALUES ('" + DGV_traffic_exception.Rows[i].Cells[0].Value.ToString() + "','" + DGV_traffic_exception.Rows[i].Cells[1].Value.ToString() + "' ,'" + tno.Text + "')");

                                    if ((DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15).CompareTo(DateTime.Parse(DGV_traffic_exception.Rows[i].Cells[1].Value.ToString()))) >= 0)
                                    {
                                        db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Vehicle_Notifications]([Vehicle],[Reason],[Remarks])VALUES('" + tno.Text + "','Traffic Exception Due Certificate-" + DGV_traffic_exception.Rows[i].Cells[0].Value.ToString() + " of Vehicle No. : " + tno.Text + " will expire On : " + DGV_traffic_exception.Rows[i].Cells[1].Value.ToString() + "','Expiration Date : " + DGV_traffic_exception.Rows[i].Cells[1].Value.ToString() + "')");
                                        if (n.Equals(""))
                                        {
                                            n = n + "Traffic Exception Due Certificate-" + DGV_traffic_exception.Rows[i].Cells[0].Value.ToString() + " of Vehicle No. : " + tno.Text + " will expire On : " + DGV_traffic_exception.Rows[i].Cells[1].Value.ToString() + "";
                                        }
                                        else
                                        {
                                            n = n + "\nTraffic Exception Due Certificate-" + DGV_traffic_exception.Rows[i].Cells[0].Value.ToString() + " of Vehicle No. : " + tno.Text + " will expire On : " + DGV_traffic_exception.Rows[i].Cells[1].Value.ToString() + "";
                                        }



                                    }

                                }
                            }



                            db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Vehicles] SET [RC Expiry date] = '" + dateTimePickerrc.Value.ToShortDateString() + "',[CF date] = '" + dateTimePickercf.Value.ToShortDateString() + "',[Pollution Certificate Expiry date] = '" + dateTimePickerpollution.Value.ToShortDateString() + "',[Permit Expiry date] = '" + dateTimePickerpermit.Value.ToShortDateString() + "',[Green Tax Expiry date] = '" + dateTimePickergreen.Value.ToShortDateString() + "' WHERE [Vehicle No.]='" + tno.Text + "'");



                            MessageBox.Show("Updated Successfully");


                            String m = "";



                            if ((DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15).CompareTo(DateTime.Parse(dateTimePickerrc.Value.ToShortDateString()))) >= 0)
                            {
                                db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Vehicle_Notifications]([Vehicle],[Reason],[Remarks])VALUES('" + tno.Text + "','RC of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerrc.Value.ToShortDateString() + "','Expiration Date : " + dateTimePickerrc.Value.ToShortDateString() + "')");

                                if (m.Equals(""))
                                {
                                    m = m + "RC of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerrc.Value.ToShortDateString() + "";
                                }
                                else
                                {
                                    m = m + "\nRC of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerrc.Value.ToShortDateString() + "";
                                }



                            }



                            if ((DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15).CompareTo(DateTime.Parse(dateTimePickercf.Value.ToShortDateString()))) >= 0)
                            {
                                db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Vehicle_Notifications]([Vehicle],[Reason],[Remarks])VALUES('" + tno.Text + "','CF of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickercf.Value.ToShortDateString() + "','Expiration Date : " + dateTimePickercf.Value.ToShortDateString() + "')");

                                if (m.Equals(""))
                                {
                                    m = m + "Cf of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickercf.Value.ToShortDateString() + "";
                                }
                                else
                                {
                                    m = m + "\nCf of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickercf.Value.ToShortDateString() + "";
                                }



                            }


                            if ((DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15).CompareTo(DateTime.Parse(dateTimePickerpollution.Value.ToShortDateString()))) >= 0)
                            {
                                db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Vehicle_Notifications]([Vehicle],[Reason],[Remarks])VALUES('" + tno.Text + "','Pollution Certificate of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerpollution.Value.ToShortDateString() + "','Expiration Date : " + dateTimePickerpollution.Value.ToShortDateString() + "')");

                                if (m.Equals(""))
                                {
                                    m = m + "Pollution Certificate of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerpollution.Value.ToShortDateString() + "";
                                }
                                else
                                {
                                    m = m + "\nPollution Certificate of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerpollution.Value.ToShortDateString() + "";
                                }




                            }


                            if ((DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15).CompareTo(DateTime.Parse(dateTimePickerpermit.Value.ToShortDateString()))) >= 0)
                            {
                                db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Vehicle_Notifications]([Vehicle],[Reason],[Remarks])VALUES('" + tno.Text + "','Permit of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerpermit.Value.ToShortDateString() + "','Expiration Date : " + dateTimePickerpermit.Value.ToShortDateString() + "')");

                                if (m.Equals(""))
                                {
                                    m = m + "Permit of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerpermit.Value.ToShortDateString() + "";
                                }
                                else
                                {
                                    m = m + "\nPermit of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickerpermit.Value.ToShortDateString() + "";
                                }




                            }


                            if ((DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15).CompareTo(DateTime.Parse(dateTimePickergreen.Value.ToShortDateString()))) >= 0)
                            {
                                db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Vehicle_Notifications]([Vehicle],[Reason],[Remarks])VALUES('" + tno.Text + "','Green Tax Certificate of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickergreen.Value.ToShortDateString() + "','Expiration Date : " + dateTimePickergreen.Value.ToShortDateString() + "')");

                                if (m.Equals(""))
                                {
                                    m = m + "Green Tax Certificate of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickergreen.Value.ToShortDateString() + "";
                                }
                                else
                                {
                                    m = m + "\nGreen Tax Certificate of Vehicle No. : " + tno.Text + " will expire On : " + dateTimePickergreen.Value.ToShortDateString() + "";
                                }



                            }

                            if (!n.Equals(""))
                            {

                                if (m.Equals(""))
                                {
                                    m = m + n;
                                }
                                else
                                {
                                    m = m + "\n" + n;
                                }
                            }

                            if (!m.Equals(""))
                            {
                                db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Vehicles]SET [status] = 'On Certificate Expiration' WHERE [Vehicle No.]='" + tno.Text + "'");
                                Program.pi.Display(m);
                            }
                            else
                            {
                                if (db.GetValue("SELECT[Status]FROM [AVVMS].[dbo].[Vehicles] where [Vehicle No.]='" + tno.Text + "'").Equals("On Certificate Expiration"))
                                {

                                    db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Vehicles]SET [status] = 'Available' WHERE [Vehicle No.]='" + tno.Text + "'");
                                }

                            }



                            this.Close();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Try Again...\nReason : " + ex.Message);



                            db.close();

                        }
                    }
                    else
                    {
                        MessageBox.Show(message);
                    }
                }
            }
            
        }


        private bool Validation()
        {

            e.Dispose();
           
            bool ret = (isempty(tno, "Enter Vehicle No.")) && (isempty(tmeter, "Enter Current Meter Reading")) && (isempty(tfcapacity, "Enter fuel Capacity")) && (isempty(teno, "Enter Engine No.")) && (isempty(tecc, "Enter CC")) && (isempty(tchasis, "Enter Chasis No.")) && (isempty(tcolor, "Enter Vehicle Color")) && (isempty(tmila, "Enter Vehicle Milage")) && (isselected(combotype, "Select Vehicle Category")) && (isselected(combofuel, "Select Vehicle Fuel type")) && (isempty(thorse, "Enter Vehicle Horse Power")) && (isempty(tweight, "Enter Vehicle Weight")) && (isempty(tmodel, "Enter Vehicle Model")) && (isempty(tfrefill, "Enter Vehicle Refill Limit")) && (isempty(tsupplierno, "Enter Selected Vehicle Suplier No.")) && (isempty(tchequeno, "Enter Cheque No.")) && (isempty(tpurchaseno, "Enter Vehicle Purchase amount")) && (iscorrect(tmeter, "Enter Correct Value for Meter")) && (iscorrect(tfcapacity, "Enter Correct Value for Fuel Capacity")) && (iscorrect(thorse, "Enter Correct Value for Horse Power")) && (iscorrect(tweight, "Enter Correct Value for Vehicle Weight")) && (iscorrect(tfrefill, "Enter Correct Value for Fuel Refill Limit")) && (iscorrect(tecc, "Enter Correct Value for Engine CC")) && (iscorrect(tmila, "Enter Correct Value for Vehicle Milage")) && (iscorrect(tsupplierno, "Enter Correct Value for Selected Supplier No.")) && (iscorrect(tchequeno, "Enter Correct Value for Cheque No.")) && (iscorrect(tpurchaseno, "Enter Correct Value for Purchase Amount"));
            
            return ret;
        }


        bool isempty(System.Windows.Forms.TextBox c, String text)
        {
            
            bool ret = true;

            if (c.Text.Equals(""))
            {

                e.SetError(c, text);
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

                e.SetError(c, text);
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
               
                Decimal i=Convert.ToDecimal(c.Text);
                if (i == 0)
                {
                    e.SetError(c, text);
                    c.Focus();
                    ret = false;
                }
            }
            catch (FormatException ex)
            {
                
                e.SetError(c, text);
                c.Focus();
                ret = false;
            }

            return ret;
        }

        private void button1_Click(object sender, EventArgs e)
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
                MessageBox.Show("Atleast 1 Supplier is needed");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DGV_traffic_exception.Rows.Add("", "");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (DGV_traffic_exception.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Rows");
            }
            else
            {
                DGV_traffic_exception.Rows.Remove(DGV_traffic_exception.SelectedRows[0]);
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_traffic_exception_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // If any cell is clicked on the Second column which is our date Column
            if (e.ColumnIndex == 1)
            {
                oDateTimePicker = new DateTimePicker();  //DateTimePicker  

                //Adding DateTimePicker control into DataGridView 
                DGV_traffic_exception.Controls.Add(oDateTimePicker);

                // Intially made it invisible
                oDateTimePicker.Visible = false;

                // Setting the format (i.e. 2014-10-10)
                oDateTimePicker.Format = DateTimePickerFormat.Short;  //

                oDateTimePicker.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                // Now make it visible
                oDateTimePicker.Visible = true;

                oDateTimePicker.Value = DateTime.Parse(DGV_traffic_exception.CurrentCell.Value.ToString());

                // It returns the retangular area that represents the Display area for a cell
                Rectangle oRectangle = DGV_traffic_exception.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control
                oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);

                // Setting Location
                oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);

                oDateTimePicker.CloseUp += new EventHandler(oDateTimePicker_CloseUp);
            }
        }

        private void dateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            DGV_traffic_exception.CurrentCell.Value = oDateTimePicker.Text.ToString();
        }

        void oDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            oDateTimePicker.Visible = false;
        }
    }
}
