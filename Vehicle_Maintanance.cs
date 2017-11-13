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
    public partial class Vehicle_Maintanance : Form
    {
        DBhandler db = new DBhandler();
        private double oa;
        public Vehicle_Maintanance()
        {
            InitializeComponent();
            button1.Enabled = false;
            dataGridView6.DataSource = db.GetTable("SELECT [no.],[date] ,[vehicle no.],[to],[from],[amount],[payement mode],[document code],[document date],[remarks]FROM [AVVMS].[dbo].[tax]");
            oa = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[5].Value.ToString());
            }
            label9.Text = "Total : " + oa.ToString();
            panel2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Tax_Ledger().Show();
            button1.Enabled = false;
            button3.Enabled = true;
            button2.Enabled = true;
            groupBox6.Text = "Tax Receipts";
            button5.Text = "Tax Receipt Input";

            dataGridView6.DataSource = db.GetTable("SELECT [no.],[date] ,[vehicle no.],[to],[from],[amount],[payement mode],[document code],[document date],[remarks]FROM [AVVMS].[dbo].[tax]");
            oa = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[5].Value.ToString());
            }
            label9.Text = "Total : " + oa.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new Insurance_Ledger().Show();
            button1.Enabled = true;
            button3.Enabled = false;
            button2.Enabled = true;
            groupBox6.Text = "Insurance Receipts";
            button5.Text = "Insurance Receipt Input";

            dataGridView6.DataSource = db.GetTable("SELECT [no.],[date] ,[vehicle no.],[to],[from],[amount],[payement mode],[document code],[document date],[remarks]FROM [AVVMS].[dbo].[insurance]");
            oa = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[5].Value.ToString());
            }
            label9.Text = "Total : " + oa.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //new Workshop_Ledger().ShowDialog();
            //new Insurance_Ledger().Show();
            button1.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = false;
            panel2.Show();

            

            groupBox6.Text = "Total Maintanance Cost";
            button5.Hide();

            panel2.Location = new Point(839, 114);

            button8.Enabled = false;
            dataGridView6.DataSource = db.GetTable("SELECT [no.],[vehicle no.],[date],[amount],[workshop],[address],[bill no.],[remarks]FROM [AVVMS].[dbo].[maintanance]");
            oa = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[3].Value.ToString());
            }
            label9.Text = "Total : " + oa.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!button1.Enabled)
            {
                new Tax_Reciept_Input().ShowDialog();
                dataGridView6.DataSource = db.GetTable("SELECT [no.],[date] ,[vehicle no.],[to],[from],[amount],[payement mode],[document code],[document date],[remarks]FROM [AVVMS].[dbo].[tax]");
                oa = 0;
                for (int i = 0; i < dataGridView6.Rows.Count; i++)
                {

                    oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[5].Value.ToString());
                }
                label9.Text = "Total : " + oa.ToString();
            }
            else
            {
                new Insurance_Reciept_Input().ShowDialog();
                dataGridView6.DataSource = db.GetTable("SELECT [no.],[date] ,[vehicle no.],[to],[from],[amount],[payement mode],[document code],[document date],[remarks]FROM [AVVMS].[dbo].[insurance]");
                oa = 0;
                for (int i = 0; i < dataGridView6.Rows.Count; i++)
                {

                    oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[5].Value.ToString());
                }
                label9.Text = "Total : " + oa.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Maintanance_Registration().ShowDialog();
            dataGridView6.DataSource = db.GetTable("SELECT [no.],[vehicle no.],[date],[amount],[workshop],[address],[bill no.],[remarks]FROM [AVVMS].[dbo].[maintanance]");
            oa = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[3].Value.ToString());
            }
            label9.Text = "Total : " + oa.ToString();
            button8.Enabled = false;
            button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            dataGridView6.DataSource = db.GetTable("SELECT [no.],[vehicle no.],[date],[amount],[workshop],[address],[bill no.],[remarks],litres FROM [AVVMS].[dbo].[oil]");
            oa = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[3].Value.ToString());
            }
            label9.Text = "Total : " + oa.ToString();
            button8.Enabled = true;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Oil_Registration().ShowDialog();
            button6.Enabled = false;
            dataGridView6.DataSource = db.GetTable("SELECT [no.],[vehicle no.],[date],[amount],[workshop],[address],[bill no.],[remarks],litres FROM [AVVMS].[dbo].[oil]");
            oa = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[3].Value.ToString());
            }
            label9.Text = "Total : " + oa.ToString();
            button8.Enabled = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            dataGridView6.DataSource = db.GetTable("SELECT [no.],[vehicle no.],[date],[amount],[workshop],[address],[bill no.],[remarks]FROM [AVVMS].[dbo].[maintanance]");
            oa = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[3].Value.ToString());
            }
            label9.Text = "Total : " + oa.ToString();
            button6.Enabled = true;
        }
    }
}
