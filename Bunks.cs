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
    public partial class Bunks : Form
    {
        DBhandler db = new DBhandler();
        private double oa;
        public Bunks()
        {
            InitializeComponent();
            dataGridView6.DataSource = db.GetTable("SELECT [no],[name],[address],[initial amount],[amount]as [Bill Amount] FROM [AVVMS].[dbo].[pbunk] where Status != 'Removed'");
            groupBox1.Hide();
        }

        private void dataGridView6_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Bunk No. : " + dataGridView6.SelectedRows[0].Cells[0].Value.ToString();

            dataGridView1.DataSource = db.GetTable("SELECT [no],[date],[vehicle] ,[amount] ,[remark] FROM [AVVMS].[dbo].[refill bill] where bunk=" + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + "");


            oa = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value.ToString());
            }
            oa = oa + Convert.ToDouble(dataGridView6.SelectedRows[0].Cells[3].Value.ToString());
            label9.Text = "Total : " + oa.ToString();

            groupBox1.Show();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to delete Bunk No. : " + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + "", "AVVMS", MessageBoxButtons.YesNo).ToString().Equals("Yes")))
            {
                try
                {
                    
                    db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[pbunk]SET [Status] = 'Removed' WHERE     ([no] = '" + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + "')");
                    MessageBox.Show("Bunk No. : " + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + " Deleted SuccessFully", "AVVMS");
                    dataGridView6.DataSource = db.GetTable("SELECT [no],[name],[address],[amount],[status]FROM [AVVMS].[dbo].[pbunk] where Status != 'Removed'");
                    groupBox1.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Try Again\nReason : " + ex.Message + "", "AVVMS");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Bank_Addition().ShowDialog();
            dataGridView6.DataSource = db.GetTable("SELECT [no],[name],[address],[initial amount],[amount]as [Bill Amount] FROM [AVVMS].[dbo].[pbunk] where Status != 'Removed'");
            groupBox1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new Bank_Pay().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //new Bank_Report(dataGridView6.SelectedRows[0].Cells[0].Value.ToString(), dataGridView6.SelectedRows[0].Cells[1].Value.ToString(), dataGridView6.SelectedRows[0].Cells[2].Value.ToString(), dataGridView6.SelectedRows[0].Cells[3].Value.ToString()).ShowDialog();
            new Bank_Pay(dataGridView6.SelectedRows[0].Cells[0].Value.ToString(), dataGridView6.SelectedRows[0].Cells[4].Value.ToString()).ShowDialog();
            dataGridView6.DataSource = db.GetTable("SELECT [no],[name],[address],[initial amount],[amount]as [Bill Amount] FROM [AVVMS].[dbo].[pbunk] where Status != 'Removed'");
            groupBox1.Hide();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new Bank_Pay_Report().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Bank_Addition(dataGridView6.SelectedRows[0].Cells[0].Value.ToString(), dataGridView6.SelectedRows[0].Cells[1].Value.ToString(), dataGridView6.SelectedRows[0].Cells[2].Value.ToString(), dataGridView6.SelectedRows[0].Cells[4].Value.ToString()).ShowDialog();
            dataGridView6.DataSource = db.GetTable("SELECT [no],[name],[address],[initial amount],[amount]as [Bill Amount] FROM [AVVMS].[dbo].[pbunk] where Status != 'Removed'");
            groupBox1.Hide();
        }
    }
}
