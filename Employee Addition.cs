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
    
    public partial class Employee_Addition : Form
    {
        DBhandler db = new DBhandler();
        private int update_flag=0;
        
       
        public Employee_Addition()
        {
            InitializeComponent();
            comboBoxcate.SelectedIndex = 0;
            panel1.Hide();
            comboBoxtyp.SelectedIndex = 0;
            comboBoxbloo.SelectedIndex = 0;
            panel2.Hide();
        }

        public Employee_Addition(string Employee_ID, string Name, string Join_date, string Mobile_No, string type, string Category, string DOB, string Blood_Group, string Email, string License_Expiry_date, string License_No, string Address)
        {
            InitializeComponent();

            groupBox6.Text = "Employee Updation";
            label8.Text = Employee_ID;
            label8.Location = tid.Location;
            tid.Text = Employee_ID;
            tid.Hide();

            dateTimePickerjdate.Value = DateTime.Parse(Join_date);
            tname.Text = Name;
            richTextBoxadd.Text = Address;
            tmail.Text = Email;
            tmob.Text = Mobile_No;

            comboBoxbloo.SelectedItem = Blood_Group;

            comboBoxcate.SelectedItem = Category;
            if (Category.Equals("Driver"))
            {
                panel1.Hide();
                tlise.Text = License_No;
                dateTimePickerexp.Value = DateTime.Parse(License_Expiry_date);
            }
            else
            {
                panel2.Hide();
                panel2.Location = panel1.Location;
                comboBoxtyp.SelectedItem = type;
            }

            update_flag = 1;
            

            dateTimePickerdob.Value = DateTime.Parse(DOB);
            

            
            
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxcate.SelectedIndex == 2)
            {
                panel1.Location = panel2.Location;
                panel2.Hide();
                panel1.Show();
            }
            else if (comboBoxcate.SelectedIndex == 1)
            {
                panel1.Hide();
                panel2.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                String type = "", lisence = "", lisence_expiry = "";
                if (panel1.Visible)
                {
                    type = comboBoxtyp.SelectedItem.ToString();
                }
                else if (panel2.Visible)
                {
                    lisence = tlise.Text;
                    lisence_expiry = dateTimePickerexp.Value.ToShortDateString();
                }
                if (update_flag == 0)
                {
                    db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Employee]([Employee ID],[Join date],[Name],[Address],[Mobile No.],[Email],[DOB],[Category],[Type],[License No.],[License Expiry date],[Status],[Blood Group])VALUES('" + tid.Text + "','" + dateTimePickerjdate.Value.ToShortDateString() + "','" + tname.Text + "','" + richTextBoxadd.Text + "','" + tmob.Text + "','" + tmail.Text + "','" + dateTimePickerdob.Value.ToShortDateString() + "','" + comboBoxcate.SelectedItem.ToString() + "','" + type + "','" + lisence + "','" + lisence_expiry + "','Available','" + comboBoxbloo.SelectedItem.ToString() + "')");
                    MessageBox.Show("Added Successfully");
                }
                else
                {

                    db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Employee] SET [Join date] = '" + dateTimePickerjdate.Value.ToShortDateString() + "',[Name] = '" + tname.Text + "' ,[Address] ='" + richTextBoxadd.Text + "' ,[Mobile No.]='" + tmob.Text + "' ,[Email] = '" + tmail.Text + "' ,[DOB] = '" + dateTimePickerdob.Value.ToShortDateString() + "' ,[Category] = '" + comboBoxcate.SelectedItem.ToString() + "',[Type] = '" + type + "' ,[License No.] = '" + lisence + "' ,[License Expiry date] = '" + lisence_expiry + "',[Blood Group] = '" + comboBoxbloo.SelectedItem.ToString() + "' WHERE     ([Employee ID] = '" + label8.Text + "')");
                    MessageBox.Show("Updated Successfully");
                }

                if (comboBoxcate.SelectedItem.ToString().Equals("Driver"))
                {
                    if ((DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15).CompareTo(DateTime.Parse(dateTimePickerexp.Value.ToShortDateString()))) >= 0)
                    {
                        db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Employee_Notifications]([Employee_ID],[Reason],[Remarks])VALUES('" + tid.Text + "','Lisence of Employee ID : " + tid.Text + " will expire On : " + dateTimePickerexp.Value.ToShortDateString() + "','Expiration Date : " + dateTimePickerexp.Value.ToShortDateString() + "')");

                        Program.pi.Display("Lisence of Employee ID : " + tid.Text + " will expire On : " + dateTimePickerexp.Value.ToShortDateString() + "");

                        db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Employee]SET [status] = 'On Lisence Expiration' WHERE [Employee ID]='" + tid.Text + "'");



                    }
                }


                this.Close();
            }
        }


        private bool Validation()
        {

            err.Dispose();

            
            if (panel2.Visible)
            {
                return isemptyg(new Control[6] { tid, tname, richTextBoxadd, tmob, tmail, tlise })&&isselectedg(new ComboBox[2] {comboBoxbloo,comboBoxcate});
            }
            else
            {
                return isemptyg(new Control[5] { tid, tname, richTextBoxadd, tmob, tmail }) && isselectedg(new ComboBox[3] { comboBoxbloo, comboBoxcate,comboBoxtyp });
            }
        }

        bool isselectedg(System.Windows.Forms.ComboBox[] c)
        {

            bool ret = true;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i].SelectedIndex == 0)
                {

                    err.SetError(c[i], "Required field");
                    c[i].Focus();
                    ret = false;
                    break;
                }
            }
            
            return ret;
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



        
    }
}
