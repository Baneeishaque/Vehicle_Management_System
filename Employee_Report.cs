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
    public partial class Employee_Report : Form
    {
        DBhandler db = new DBhandler();
        DataTable dt = new DataTable();
        private double oa;
        public Employee_Report(String id,String jdate,String dob,String nam,String addr,String mob,String bloo,String cat,String email,String ty,String lise,String liseex)
        {
            InitializeComponent();

            lid.Text = id;
            ljoin.Text = jdate;
            ldob.Text = dob;
            lname.Text = nam;
            laddress.Text = addr;
            lmob.Text = mob;
            lblood.Text = bloo;
            lcategory.Text = cat;
            lemail.Text = email;
            if (cat.Equals("Driver"))
            {
                label_type.Hide();
                ltype.Hide();
                llisence.Text = lise;
                llisenceex.Text = liseex;
            }
            else
            {
                label_lisen.Hide();
                label_lisenex.Hide();
                llisence.Hide();
                llisenceex.Hide();
                ltype.Text = ty;
            }
            
            
            dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Trip No.],  Batha, [Batha Amount],Date FROM         Batha_Report where [Employee ID]='"+id+"'");

            oa = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[3].Value.ToString());
            }
            label2.Text = "Total : " + oa.ToString();


            dt = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle No.],[Journey] ,[Purpose],[Provider],[Date],[Remarks] FROM [AVVMS].[dbo].[Trips] where [date] !='" + DateTime.Now.ToShortDateString() + "' AND [driver]='" + id + "' OR [first cleaner]='" + id + "' OR [second cleaner]='" + id + "'");



            DateTime n = DateTime.Now;
            for (int i = 0; i < dt.Rows.Count; i++)
            {


                DateTime d = DateTime.Parse(dt.Rows[i]["date"].ToString());
                int c = n.CompareTo(d);



                if (c == -1)
                {
                    dataGridView1.Rows.Add(dt.Rows[i]["Sl. No."].ToString(), dt.Rows[i]["Vehicle No."].ToString(), dt.Rows[i]["Journey"].ToString(), dt.Rows[i]["Purpose"].ToString(), dt.Rows[i]["Provider"].ToString(), dt.Rows[i]["Date"].ToString(), dt.Rows[i]["Remarks"].ToString());

                }
            }

            dataGridView2.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle No.],[Journey],[Purpose],[Provider],[mobile] as [Mobile No.],[date] as [Start Date],[Remarks]FROM [AVVMS].[dbo].[Trips] where [status]='On Trip' AND ([driver]='" + id + "' OR [first cleaner]='" + id + "' OR [second cleaner]='" + id + "')");

            dataGridView3.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle No.],[Journey],[Purpose],[Provider],[mobile] as [Mobile No.],[date] as [Start Date],[Remarks]FROM [AVVMS].[dbo].[Trips] where [status]='Complete' AND ([driver]='" + id + "' OR [first cleaner]='" + id + "' OR [second cleaner]='" + id + "')");

            /*string folder = @"c:\Administrator\Data";
                    // Specify a name of folder. 
                    System.IO.Directory.CreateDirectory(folder);
                    // Create  file names for the files you want to create.  
                  
                    string subjectfile = "s.dat";
                  
                    // Use Combine to add the file name dto the path.
                    string csubject = System.IO.Path.Combine(folder, subjectfile);

                    //creating subject file
                    using (System.IO.FileStream fs2 = System.IO.File.Create(csubject))
                    {
                    }

                    //writing subject
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(csubject))
                    {
                        sw.Write("SELECT [Id] as [Sl. No.],[Vehicle No.],[Journey],[Purpose],[Provider],[mobile] as [Mobile No.],[date] as [Start Date],[Remarks]FROM [AVVMS].[dbo].[Trips] where [status]='On Trip' AND ([driver]='" + id + "' OR [first cleaner]='" + id + "' OR [second cleaner]='" + id + "')");
                    }*/
        }
    }
}
