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
    public partial class Petrol_Bank_Manipulation : Form
    {
        DBhandler db = new DBhandler();
        private double oa;
        public Petrol_Bank_Manipulation()
        {
            InitializeComponent();
            dataGridView6.DataSource = db.GetTable("SELECT [no],[date],[vehicle],[bunk] ,[amount] ,[remark],litres FROM [AVVMS].[dbo].[refill bill]");

          
            oa = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[4].Value.ToString());
            }
            label9.Text = "Total : " + oa.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Bank_Addition().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new Bank_Pay().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Refill_Bill_Input().ShowDialog();
            dataGridView6.DataSource = db.GetTable("SELECT [no],[date],[vehicle],[bunk] ,[amount] ,[remark],litres FROM [AVVMS].[dbo].[refill bill]");


            oa = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[4].Value.ToString());
            }
            label9.Text = "Total : " + oa.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Bunks().ShowDialog();
        }
    }
}
