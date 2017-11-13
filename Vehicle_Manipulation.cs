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
    public partial class Vehicle_Manipulation : Form
    {
        DBhandler db = new DBhandler();
        DataTable dt = new DataTable();
        public Vehicle_Manipulation()
        {
            InitializeComponent();
            dataGridView6.DataSource = db.GetTable("SELECT [Vehicle No.] ,[Type] ,[Model]  ,[Fuel Capacity] as Milage,[Fuel Type],[fuel]as [Current Feul],[Fuel Refill Limit]    ,[Status]    FROM [AVVMS].[dbo].[Vehicles] where Status != 'Removed'");

            // [Quotatio date] ,[Selected Quotation No.] ,[Purchase Amount] ,[Cheque No.] ,[Purchase date]
            // ,[Insurance Target] ,[CF date] ,[Pollution Certificate Expiry date] ,[Green Tax Expiry date]
            groupBox1.Hide();
            button9.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //new Status_Change().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Vehicle_Addition().ShowDialog();
            dataGridView6.DataSource = db.GetTable("SELECT [Vehicle No.] ,[Type] ,[Model]  ,[Fuel Capacity] as Milage,[Fuel Type],[fuel]as [Current Feul],[Fuel Refill Limit]    ,[Status]    FROM [AVVMS].[dbo].[Vehicles] where Status != 'Removed'");

           
            groupBox1.Hide();
            button9.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Vehicle_Maintanance().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //new Vehicles().Show();
        }

        private void dataGridView6_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Vehicle No. : " + dataGridView6.SelectedRows[0].Cells[0].Value.ToString();

            dt = db.GetTable("SELECT     [Engine No.] ,[Horse Power] ,[Chasis No.],[Engine CC],[Full tank],[Meter Reading],[Color] ,[last refill date],[Tax Expiry date] ,[RC Expiry date] ,[Insurance Expiry date],[Permit Expiry date] FROM Vehicles WHERE     ([Vehicle No.] = '" + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + "')");
            lb_fc.Text = "Engine No." + dt.Rows[0]["Engine No."].ToString();
            lb_sc.Text = "Horse Power : " + dt.Rows[0]["Horse Power"].ToString();
            lb_address.Text = "Chasis No. : " + dt.Rows[0]["Chasis No."].ToString();

            lb_moment.Text = "Engine CC : " + dt.Rows[0]["Engine CC"].ToString();

            label2.Text = "Fuel Capacity : " + dt.Rows[0]["Full tank"].ToString();
            label1.Text = "Meter Reading : " + dt.Rows[0]["Meter Reading"].ToString();
            label3.Text = "Color : " + dt.Rows[0]["Color"].ToString();
            label4.Text = "Last Refill Date : " + dt.Rows[0]["last refill date"].ToString();

            label5.Text = "Tax Expiry Date : " + dt.Rows[0]["Tax Expiry date"].ToString();
            label6.Text = "Insurance Expiry Date : " + dt.Rows[0]["Insurance Expiry date"].ToString();
            label7.Text = "RC Expiry date : " + dt.Rows[0]["RC Expiry date"].ToString();
            label8.Text = "Permit Expiry date : " + dt.Rows[0]["Permit Expiry date"].ToString();

            comboBox2.SelectedItem = dataGridView6.SelectedRows[0].Cells[7].Value.ToString();

            if (!comboBox2.SelectedItem.ToString().Equals("Available"))
            {
                comboBox2.Enabled = false;
            }
            else
            {
                comboBox2.Enabled = true;
            }

            groupBox1.Show();
            button9.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to delete Vehicle No. : " + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + "", "AVVMS", MessageBoxButtons.YesNo).ToString().Equals("Yes")))
            {
                try
                {
                    //db.Ins_Up_Del("DELETE FROM Employee WHERE     ([Employee ID] = '" + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + "')");
                    db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Vehicles]SET [Status] = 'Removed' WHERE     ([Vehicle No.] = '" + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + "')");
                    new Vehicle_Sell(dataGridView6.SelectedRows[0].Cells[0].Value.ToString()).ShowDialog();
                    MessageBox.Show("Vehicle No. : " + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + " Deleted SuccessFully", "AVVMS");
                    dataGridView6.DataSource = db.GetTable("SELECT [Vehicle No.] ,[Type] ,[Model]  ,[Fuel Capacity] as Milage,[Fuel Type],[fuel]as [Current Feul],[Fuel Refill Limit]    ,[Status]    FROM [AVVMS].[dbo].[Vehicles] where Status != 'Removed'");
                    groupBox1.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Try Again\nReason : " + ex.Message + "", "AVVMS");
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                button9.Show();
            
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                
                db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Vehicles]SET [Status] = '"+comboBox2.SelectedItem.ToString()+"' WHERE     ([Vehicle No.] = '" + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + "')");
                MessageBox.Show("Vehicle No. : " + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + " Updated SuccessFully", "AVVMS");
                dataGridView6.DataSource = db.GetTable("SELECT [Vehicle No.] ,[Type] ,[Model]  ,[Fuel Capacity] as Milage,[Fuel Type],[fuel]as [Current Feul],[Fuel Refill Limit]    ,[Status]    FROM [AVVMS].[dbo].[Vehicles] where Status != 'Removed'");
                groupBox1.Hide();
                button9.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again\nReason : " + ex.Message + "", "AVVMS");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Vehicle_Report(dataGridView6.SelectedRows[0].Cells[0].Value.ToString(), dataGridView6.SelectedRows[0].Cells[1].Value.ToString(), dt.Rows[0]["Meter Reading"].ToString(), dt.Rows[0]["Full tank"].ToString(), dt.Rows[0]["Engine No."].ToString(), dt.Rows[0]["Horse Power"].ToString(), dataGridView6.SelectedRows[0].Cells[4].Value.ToString(), dataGridView6.SelectedRows[0].Cells[2].Value.ToString(), dataGridView6.SelectedRows[0].Cells[6].Value.ToString(), dt.Rows[0]["Engine CC"].ToString(), dt.Rows[0]["Chasis No."].ToString(), dt.Rows[0]["Color"].ToString(), dataGridView6.SelectedRows[0].Cells[3].Value.ToString(),dt.Rows[0]["Tax Expiry date"].ToString(),dt.Rows[0]["RC Expiry date"].ToString(),dt.Rows[0]["Permit Expiry date"].ToString(),dt.Rows[0]["Insurance Expiry date"].ToString(),dt.Rows[0]["last refill date"].ToString()).ShowDialog();

          
      
     
           

      
      
     
          

         
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Vehicle_Summary().ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new Sell_Report().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Vehicle_Addition(dataGridView6.SelectedRows[0].Cells[0].Value.ToString(), dataGridView6.SelectedRows[0].Cells[1].Value.ToString(), dt.Rows[0]["Meter Reading"].ToString(), dt.Rows[0]["Full tank"].ToString(), dt.Rows[0]["Engine No."].ToString(), dt.Rows[0]["Horse Power"].ToString(), dataGridView6.SelectedRows[0].Cells[4].Value.ToString(), dataGridView6.SelectedRows[0].Cells[2].Value.ToString(), dataGridView6.SelectedRows[0].Cells[6].Value.ToString(), dt.Rows[0]["Engine CC"].ToString(), dt.Rows[0]["Chasis No."].ToString(), dt.Rows[0]["Color"].ToString(), dataGridView6.SelectedRows[0].Cells[3].Value.ToString(), dt.Rows[0]["Tax Expiry date"].ToString(), dt.Rows[0]["RC Expiry date"].ToString(), dt.Rows[0]["Permit Expiry date"].ToString(), dt.Rows[0]["Insurance Expiry date"].ToString()).ShowDialog();

            dataGridView6.DataSource = db.GetTable("SELECT [Vehicle No.] ,[Type] ,[Model]  ,[Fuel Capacity] as Milage,[Fuel Type],[fuel]as [Current Feul],[Fuel Refill Limit]    ,[Status]    FROM [AVVMS].[dbo].[Vehicles] where Status != 'Removed'");

           
            groupBox1.Hide();
            button9.Hide();
        }
    }
}
