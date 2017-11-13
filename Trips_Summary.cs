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
    public partial class Trips_Summary : Form
    {
        DBhandler db = new DBhandler();
        DataTable dt = new DataTable();
        public Trips_Summary()
        {
            InitializeComponent();
            dataGridView6.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle No.],[Journey],[Purpose],[Provider],[mobile] as [Mobile No.],[date] as [Start Date],[driver] as [Driver],[Remarks]FROM [AVVMS].[dbo].[Trips]  ");

            groupBox1.Hide();
        }

        private void dataGridView6_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Trip No. : " + dataGridView6.SelectedRows[0].Cells[0].Value.ToString();

            dt = db.GetTable("SELECT [first cleaner],[second cleaner],[address],[start meter],[start time],[moment slip no.]FROM [AVVMS].[dbo].[Trips] where [id]=" + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + "");
            lb_fc.Text = "First Cleaner : " + dt.Rows[0]["first cleaner"].ToString();
            lb_sc.Text = "Second Cleaner : " + dt.Rows[0]["second cleaner"].ToString();
            lb_address.Text = "Provider Address : " + dt.Rows[0]["address"].ToString();
            lb_startmeter.Text = "Start Meter : " + dt.Rows[0]["start meter"].ToString();
            lb_starttime.Text = "Start Time : " + dt.Rows[0]["start time"].ToString();
            lb_moment.Text = "Moment Slip No. : " + dt.Rows[0]["moment slip no."].ToString();
            groupBox1.Show();
        }
    }
}
