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
    public partial class Vehicle_Report : Form
    {
        DBhandler db = new DBhandler();
       

        
        public Vehicle_Report(string no, string vtype, string meter, string fcapac, string engineno, string horse, string ftype, string model, string frefilllimit, string enginecc, string chasisno, string color, string milage, string taxdate, string rcdate, string permitdate, string insudate, string frefilldate)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = db.GetTable("SELECT [weight],[Quotatio date],[Selected Quotation No.],[Cheque No.],[Purchase Amount],[Purchase date],[CF date],[Pollution Certificate Expiry date],[Green Tax Expiry date],[fuel]FROM [AVVMS].[dbo].[Vehicles] where [Vehicle No.]='" + no + "'");

            lbno.Text = no;
            lbvtype.Text = vtype;
            lbmeter.Text = meter;
            lbfca.Text = fcapac;
            lbeno.Text = engineno;
            lbhor.Text = horse;
            lbweig.Text = dt.Rows[0]["weight"].ToString();
            lbfuety.Text = ftype;
            lbmo.Text = model;
            lbrefli.Text = frefilllimit;
            lbecc.Text = enginecc;
            lbchano.Text = chasisno;
            lbcolo.Text = color;
            lbmila.Text = milage;
            lbqoudate.Text = dt.Rows[0]["Quotatio date"].ToString();
            lbsqno.Text = dt.Rows[0]["Selected Quotation No."].ToString();
            lbcheck.Text = dt.Rows[0]["Cheque No."].ToString();
            lbpuam.Text = dt.Rows[0]["Purchase Amount"].ToString();
            lbpudate.Text = dt.Rows[0]["Purchase date"].ToString();
            lbtaxd.Text = taxdate;
            lbrcd.Text = rcdate;
            lbcfd.Text = dt.Rows[0]["CF date"].ToString();
            lbpollud.Text = dt.Rows[0]["Pollution Certificate Expiry date"].ToString();
            lbperd.Text=permitdate;
            lbgreed.Text = dt.Rows[0]["Green Tax Expiry date"].ToString();
            lbinsud.Text = insudate;
            lblasrefdate.Text = frefilldate;
            lbrfuel.Text = dt.Rows[0]["fuel"].ToString();

            dt=db.GetTable("SELECT [supplier],[quotation amount]FROM [AVVMS].[dbo].[qoutation]where [vehicle no.]='"+no+"'");
             for (int i = 0; i < dt.Rows.Count; i++)
                {

                    dataGridView2.Rows.Add("" + (i+1).ToString() + "", "" + dt.Rows[i]["supplier"].ToString() + "", "" + dt.Rows[i]["quotation amount"].ToString() + "");
                }

             dt = db.GetTable("SELECT [traffic exception due],[expiry date] FROM [AVVMS].[dbo].[traffic exception]where [vehicle no.]='" + no + "'");
             for (int i = 0; i < dt.Rows.Count; i++)
             {

                 DGV_traffic_exception.Rows.Add("" + dt.Rows[i]["traffic exception due"].ToString() + "", "" + dt.Rows[i]["expiry date"].ToString() + "");
             }


             lol.Text=db.sum("SELECT sum(litres)FROM [AVVMS].[dbo].[oil] where [vehicle no.]='" + no + "'").ToString();
             lop.Text = db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[oil] where [vehicle no.]='" + no + "'").ToString();

             lfl.Text = db.sum("SELECT sum(litres)FROM [AVVMS].[dbo].[refill bill] where [vehicle]='" + no + "'").ToString();
             lfp.Text = db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[refill bill] where [vehicle]='" + no + "'").ToString();
             lmc.Text = db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[maintanance] where [vehicle no.]='" + no + "'").ToString();
             lmt.Text = db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[tax] where [vehicle no.]='" + no + "'").ToString();
             lmi.Text = db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[insurance] where [vehicle no.]='" + no + "'").ToString();
             lt.Text = (Convert.ToDecimal(lop.Text) + Convert.ToDecimal(lfp.Text) + Convert.ToDecimal(lmc.Text) + Convert.ToDecimal(lmt.Text) + Convert.ToDecimal(lmi.Text)).ToString();

             lkm.Text = db.sum("SELECT sum(km)FROM [AVVMS].[dbo].[Trips] where [Vehicle No.]='" + no + "'").ToString();
             try
             {
                 lekm.Text = ((Convert.ToDecimal(lt.Text)) / (Convert.ToDecimal(lkm.Text))).ToString();
             }
             catch (DivideByZeroException e)
             {
                 lekm.Text = "0";
             }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
