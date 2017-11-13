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
    public partial class Trip_Manipulation : Form
    {
        DBhandler db = new DBhandler();
        DataTable dt = new DataTable();

        public Trip_Manipulation()
        {
            InitializeComponent();

            dataGridView6.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle No.],[Journey],[Purpose],[Provider],[mobile] as [Mobile No.],[date] as [Start Date],[driver] as [Driver],[Remarks]FROM [AVVMS].[dbo].[Trips] where [status]='On Trip' ");

            groupBox1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Assign_Trip().ShowDialog();

            dataGridView6.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle No.],[Journey],[Purpose],[Provider],[mobile] as [Mobile No.],[date] as [Start Date],[driver] as [Driver],[Remarks]FROM [AVVMS].[dbo].[Trips] where [status]='On Trip' ");
            groupBox1.Hide();
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Trips_Summary().ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new Hair().ShowDialog();
        }

        private void dataGridView6_Click(object sender, EventArgs e)
        {
            if (dataGridView6.SelectedRows.Count != 0)
            {
                groupBox1.Text = "Trip No. : " + dataGridView6.SelectedRows[0].Cells[0].Value.ToString();


                if (db.GetValue("SELECT [Type]FROM [AVVMS].[dbo].[Vehicles] where [Vehicle No.]='" + dataGridView6.SelectedRows[0].Cells[1].Value.ToString() + "'").Contains("Heavy"))
                {

                    dt = db.GetTable("SELECT [first cleaner],[second cleaner],[address],[start meter],[start time],[moment slip no.]FROM [AVVMS].[dbo].[Trips] where [id]=" + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + "");

                    lb_fc.Text = "First Cleaner : " + dt.Rows[0]["first cleaner"].ToString();
                    if (dt.Rows[0]["second cleaner"].ToString().Equals(""))
                    {
                        Common_Tasks.nullify(lb_sc);

                    }
                    else
                    {
                        lb_sc.Text = "Second Cleaner : " + dt.Rows[0]["second cleaner"].ToString();
                    }


                }
                else
                {
                    Common_Tasks.nullify(lb_fc);
                    Common_Tasks.nullify(lb_sc);
                    dt = db.GetTable("SELECT [address],[start meter],[start time],[moment slip no.]FROM [AVVMS].[dbo].[Trips] where [id]=" + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + "");
                }

                lb_address.Text = "Provider Address : " + dt.Rows[0]["address"].ToString();
                lb_startmeter.Text = "Start Meter : " + dt.Rows[0]["start meter"].ToString();
                lb_starttime.Text = "Start Time : " + dt.Rows[0]["start time"].ToString();
                lb_moment.Text = "Moment Slip No. : " + dt.Rows[0]["moment slip no."].ToString();

                groupBox1.Show();
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (db.GetValue("SELECT [Type]FROM [AVVMS].[dbo].[Vehicles] where [Vehicle No.]='" + dataGridView6.SelectedRows[0].Cells[1].Value.ToString() + "'").Contains("Heavy"))
            {
                new Trip_Completion(dataGridView6.SelectedRows[0].Cells[0].Value.ToString(), dataGridView6.SelectedRows[0].Cells[1].Value.ToString(), dataGridView6.SelectedRows[0].Cells[3].Value.ToString(), dataGridView6.SelectedRows[0].Cells[4].Value.ToString(), dt.Rows[0]["address"].ToString(), dataGridView6.SelectedRows[0].Cells[5].Value.ToString(), dataGridView6.SelectedRows[0].Cells[7].Value.ToString(), dt.Rows[0]["start meter"].ToString(), dt.Rows[0]["start time"].ToString(), dataGridView6.SelectedRows[0].Cells[6].Value.ToString(), dataGridView6.SelectedRows[0].Cells[8].Value.ToString(), dataGridView6.SelectedRows[0].Cells[2].Value.ToString(), dt.Rows[0]["first cleaner"].ToString(), dt.Rows[0]["second cleaner"].ToString()).ShowDialog();
            }
            else
            {
                new Trip_Completion(dataGridView6.SelectedRows[0].Cells[0].Value.ToString(), dataGridView6.SelectedRows[0].Cells[1].Value.ToString(), dataGridView6.SelectedRows[0].Cells[3].Value.ToString(), dataGridView6.SelectedRows[0].Cells[4].Value.ToString(), dt.Rows[0]["address"].ToString(), dataGridView6.SelectedRows[0].Cells[5].Value.ToString(), dataGridView6.SelectedRows[0].Cells[7].Value.ToString(), dt.Rows[0]["start meter"].ToString(), dt.Rows[0]["start time"].ToString(), dataGridView6.SelectedRows[0].Cells[6].Value.ToString(), dataGridView6.SelectedRows[0].Cells[8].Value.ToString(), dataGridView6.SelectedRows[0].Cells[2].Value.ToString()).ShowDialog();
            }
            
            dataGridView6.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle No.],[Journey],[Purpose],[Provider],[mobile] as [Mobile No.],[date] as [Start Date],[driver] as [Driver],[Remarks]FROM [AVVMS].[dbo].[Trips] where [status]='On Trip' ");
            groupBox1.Hide();
        }
    }
}
