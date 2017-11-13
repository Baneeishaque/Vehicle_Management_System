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
    public partial class Login : Form
    {
        DBhandler db = new DBhandler();
        public Login()
        {
            InitializeComponent();
            DataTable dt = new DataTable();

            dt = db.GetTable("SELECT [Employee ID]FROM [AVVMS].[dbo].[Employee] where Status != 'Removed'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                comboBox2.Items.Add(dt.Rows[i]["Employee ID"].ToString());
                comboBox5.Items.Add(dt.Rows[i]["Employee ID"].ToString());
            }

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;

            label3.Hide();
            label4.Hide();

            label7.Hide();
            label8.Hide();

            panel2.Hide();

            label9.Hide();


        }

        private bool Validation()
        {

            err.Dispose();


            
                return isemptyg(new Control[2] { txt_username,txt_password }) ;
            
        }

        

        ErrorProvider err = new ErrorProvider();

        bool isemptyg(System.Windows.Forms.Control[] c)
        {
            bool ret = true;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i].Text.Equals(""))
                {

                    err.SetError(c[i], "Required field");
                    c[i].Focus();
                    ret = false;
                    break;
                }
            }
            return ret;
        }


        private void button_login_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (db.GetTable("SELECT [UserName]FROM [AVVMS].[dbo].[Login] where [UserName]='" + txt_username.Text + "' and [Password]='" + txt_password.Text + "'").Rows.Count != 0)
                {


                    panel1.Hide();
                    panel2.Show();

                }
                else
                {

                    label9.Show();
                    txt_username.Text = "";
                    txt_password.Text = "";

                }
            }
        }

        private void button_notifications_Click(object sender, EventArgs e)
        {
            new Notifications().ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox1.SelectedItem.ToString().Equals("Select Vehicle"))
            {
                label3.Text = db.GetValue("SELECT[Status]FROM [AVVMS].[dbo].[Vehicles] where [Vehicle No.]='" + comboBox1.SelectedItem.ToString() + "'");
                label3.Show();
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox2.SelectedItem.ToString().Equals("Select Employee"))
            {
                label4.Text = db.GetValue("SELECT[Status]FROM [AVVMS].[dbo].[Employee] where [Employee ID]='" + comboBox2.SelectedItem.ToString() + "'");
                label4.Show();
            }
        }

        private void button_trips_Click(object sender, EventArgs e)
        {
            new Trips().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Batha_Assign().ShowDialog();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Program.pi.Dispose();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = "";
            
            if (comboBox3.SelectedItem.ToString().Equals("Light"))
            {
                
                while (comboBox1.Items.Count != 1)
                {
                    comboBox1.Items.RemoveAt(1);
                }
                DataTable dt = new DataTable();
                dt = db.GetTable("SELECT [Vehicle No.]FROM [AVVMS].[dbo].[Vehicles] where [Type]='Light' AND Status != 'Removed'");
               
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    
                    comboBox1.Items.Add(dt.Rows[i]["Vehicle No."].ToString());
                }
                comboBox1.SelectedIndex = 0;
            }
            else if (comboBox3.SelectedItem.ToString().Equals("Hospital Light"))
            {
                while (comboBox1.Items.Count != 1)
                {
                    comboBox1.Items.RemoveAt(1);
                }
                DataTable dt = new DataTable();
                dt = db.GetTable("SELECT [Vehicle No.]FROM [AVVMS].[dbo].[Vehicles] where [Type]='Hospital Light' AND Status != 'Removed'");

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    comboBox1.Items.Add(dt.Rows[i]["Vehicle No."].ToString());
                }
                comboBox1.SelectedIndex = 0;
            }
            else if (comboBox3.SelectedItem.ToString().Equals("Heavy"))
            {
                while (comboBox1.Items.Count != 1)
                {
                    comboBox1.Items.RemoveAt(1);
                }
                DataTable dt = new DataTable();
                dt = db.GetTable("SELECT [Vehicle No.]FROM [AVVMS].[dbo].[Vehicles] where [Type]='Heavy' AND Status != 'Removed'");

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    comboBox1.Items.Add(dt.Rows[i]["Vehicle No."].ToString());
                }
                comboBox1.SelectedIndex = 0;
            }
            else if (comboBox3.SelectedItem.ToString().Equals("Hospital Heavy"))
            {
                while (comboBox1.Items.Count != 1)
                {
                    comboBox1.Items.RemoveAt(1);
                }
                DataTable dt = new DataTable();
                dt = db.GetTable("SELECT [Vehicle No.]FROM [AVVMS].[dbo].[Vehicles] where [Type]='Hospital Heavy' AND Status != 'Removed'");

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    comboBox1.Items.Add(dt.Rows[i]["Vehicle No."].ToString());
                }
                comboBox1.SelectedIndex = 0;
            }
        }

       

        private void button_vehicle_Click(object sender, EventArgs e)
        {
            new Vehicle_Manipulation().ShowDialog();
        }

        private void button_batha_Click(object sender, EventArgs e)
        {
            new About_Us().ShowDialog();
        }

       
        private void button_employee_Click(object sender, EventArgs e)
        {
            
            new Employee_Manipulation().ShowDialog();

            while (comboBox5.Items.Count != 1)
            {
                comboBox5.Items.RemoveAt(1);
            }
            DataTable dt=new DataTable();
            dt= db.GetTable("SELECT [Employee ID]FROM [AVVMS].[dbo].[Employee] where Status != 'Removed'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                
                comboBox5.Items.Add(dt.Rows[i]["Employee ID"].ToString());
            }

           
            comboBox5.SelectedIndex = 0;
           
        }

        private void button_trip_Click(object sender, EventArgs e)
        {
            new Trip_Manipulation().ShowDialog();
        }

        private void button_petrol_Click(object sender, EventArgs e)
        {
            new Petrol_Bank_Manipulation().ShowDialog();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            label9.Hide();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox6.SelectedItem.ToString().Equals("Select Vehicle"))
            {
                label8.Text = db.GetValue("SELECT[Status]FROM [AVVMS].[dbo].[Vehicles] where [Vehicle No.]='" + comboBox6.SelectedItem.ToString() + "'");
                label8.Show();
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox5.SelectedItem.ToString().Equals("Select Employee"))
            {
                label7.Text = db.GetValue("SELECT[Status]FROM [AVVMS].[dbo].[Employee] where [Employee ID]='" + comboBox5.SelectedItem.ToString() + "'");
                label7.Show();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = "";

            if (comboBox4.SelectedItem.ToString().Equals("Light"))
            {

                while (comboBox6.Items.Count != 1)
                {
                    comboBox6.Items.RemoveAt(1);
                }
                DataTable dt = new DataTable();
                dt = db.GetTable("SELECT [Vehicle No.]FROM [AVVMS].[dbo].[Vehicles] where [Type]='Light' AND Status != 'Removed'");

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    comboBox6.Items.Add(dt.Rows[i]["Vehicle No."].ToString());
                }
                comboBox6.SelectedIndex = 0;
            }
            else if (comboBox4.SelectedItem.ToString().Equals("Hospital Light"))
            {
                while (comboBox6.Items.Count != 1)
                {
                    comboBox6.Items.RemoveAt(1);
                }
                DataTable dt = new DataTable();
                dt = db.GetTable("SELECT [Vehicle No.]FROM [AVVMS].[dbo].[Vehicles] where [Type]='Hospital Light' AND Status != 'Removed'");

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    comboBox6.Items.Add(dt.Rows[i]["Vehicle No."].ToString());
                }
                comboBox6.SelectedIndex = 0;
            }
            else if (comboBox4.SelectedItem.ToString().Equals("Heavy"))
            {
                while (comboBox6.Items.Count != 1)
                {
                    comboBox6.Items.RemoveAt(1);
                }
                DataTable dt = new DataTable();
                dt = db.GetTable("SELECT [Vehicle No.]FROM [AVVMS].[dbo].[Vehicles] where [Type]='Heavy' AND Status != 'Removed'");

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    comboBox6.Items.Add(dt.Rows[i]["Vehicle No."].ToString());
                }
                comboBox6.SelectedIndex = 0;
            }
            else if (comboBox4.SelectedItem.ToString().Equals("Hospital Heavy"))
            {
                while (comboBox6.Items.Count != 1)
                {
                    comboBox6.Items.RemoveAt(1);
                }
                DataTable dt = new DataTable();
                dt = db.GetTable("SELECT [Vehicle No.]FROM [AVVMS].[dbo].[Vehicles] where [Type]='Hospital Heavy' AND Status != 'Removed'");

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    comboBox6.Items.Add(dt.Rows[i]["Vehicle No."].ToString());
                }
                comboBox6.SelectedIndex = 0;
            }
        }

        
    }
}
