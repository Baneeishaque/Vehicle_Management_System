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
    public partial class Employee_Manipulation : Form
    {
        DBhandler db = new DBhandler();
        DataTable dt = new DataTable();

        public Employee_Manipulation()
        {
            InitializeComponent();
            dataGridView6.DataSource = db.GetTable("SELECT     [Employee ID], Name,  [Join date], [Mobile No.], Type ,Category, DOB, [Blood Group],Status FROM         Employee where Status != 'Removed'");
            groupBox1.Hide();
            //groupBox2.Hide();
            //comboBox1.SelectedIndex = 0;
            //panel3.Hide();
            //comboBox3.SelectedIndex = 0;
            //comboBox2.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Employee_Addition().ShowDialog();
            dataGridView6.DataSource = db.GetTable("SELECT     [Employee ID], Name,  [Join date], [Mobile No.], Type ,Category, DOB, [Blood Group],Status FROM         Employee where Status != 'Removed'");
            groupBox1.Hide();
            //groupBox2.Show();
        }

       
        

        private void button5_Click(object sender, EventArgs e)
        {
            new Batha_Report().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new License_Renew().ShowDialog();
            dataGridView6.DataSource = db.GetTable("SELECT     [Employee ID], Name,  [Join date], [Mobile No.], Type ,Category, DOB, [Blood Group],Status FROM         Employee where Status != 'Removed'");
            groupBox1.Hide();
        }

        private void dataGridView6_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Employee ID : " + dataGridView6.SelectedRows[0].Cells[0].Value.ToString();

            dt = db.GetTable("SELECT     Email, Address, [License No.], [License Expiry date] FROM Employee WHERE     ([Employee ID] = '" + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + "')");
            lb_fc.Text = "Email ID : " + dt.Rows[0]["Email"].ToString();
            lb_sc.Text = "License Expiry Date : " + dt.Rows[0]["License Expiry date"].ToString();
            lb_address.Text = "Lisence No. : " + dt.Rows[0]["License No."].ToString();
           
            lb_moment.Text = "Address : " + dt.Rows[0]["Address"].ToString();
            groupBox1.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if((MessageBox.Show("Do you want to delete Employee ID : " + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + "", "AVVMS", MessageBoxButtons.YesNo).ToString().Equals("Yes")))
            {
                try
                {
                    //db.Ins_Up_Del("DELETE FROM Employee WHERE     ([Employee ID] = '" + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + "')");
                    db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Employee]SET [Status] = 'Removed' WHERE     ([Employee ID] = '" + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + "')");
                    MessageBox.Show("Employee ID : " + dataGridView6.SelectedRows[0].Cells[0].Value.ToString() + " Deleted SuccessFully", "AVVMS");
                    dataGridView6.DataSource = db.GetTable("SELECT     [Employee ID], Name,  [Join date], [Mobile No.], Type ,Category, DOB, [Blood Group],Status FROM         Employee where Status != 'Removed'");
                    groupBox1.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Try Again\nReason : "+ex.Message+"", "AVVMS");
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new Employee_Addition(dataGridView6.SelectedRows[0].Cells[0].Value.ToString(), dataGridView6.SelectedRows[0].Cells[1].Value.ToString(), dataGridView6.SelectedRows[0].Cells[2].Value.ToString(), dataGridView6.SelectedRows[0].Cells[3].Value.ToString(), dataGridView6.SelectedRows[0].Cells[4].Value.ToString(), dataGridView6.SelectedRows[0].Cells[5].Value.ToString(), dataGridView6.SelectedRows[0].Cells[6].Value.ToString(), dataGridView6.SelectedRows[0].Cells[7].Value.ToString(), dt.Rows[0]["Email"].ToString(), dt.Rows[0]["License Expiry date"].ToString(), dt.Rows[0]["License No."].ToString(), dt.Rows[0]["Address"].ToString()).ShowDialog();
            dataGridView6.DataSource = db.GetTable("SELECT     [Employee ID], Name,  [Join date], [Mobile No.], Type ,Category, DOB, [Blood Group],Status FROM         Employee where Status != 'Removed'");
            groupBox1.Hide();
            //this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            new Employee_Report(dataGridView6.SelectedRows[0].Cells[0].Value.ToString(), dataGridView6.SelectedRows[0].Cells[2].Value.ToString(), dataGridView6.SelectedRows[0].Cells[6].Value.ToString(), dataGridView6.SelectedRows[0].Cells[1].Value.ToString(), dt.Rows[0]["Address"].ToString(), dataGridView6.SelectedRows[0].Cells[3].Value.ToString(), dataGridView6.SelectedRows[0].Cells[7].Value.ToString(), dataGridView6.SelectedRows[0].Cells[5].Value.ToString(), dt.Rows[0]["Email"].ToString(), dataGridView6.SelectedRows[0].Cells[4].Value.ToString(), dt.Rows[0]["License No."].ToString(), dt.Rows[0]["License Expiry date"].ToString()).ShowDialog();
        }
    }
}
