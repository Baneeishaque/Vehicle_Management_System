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
    public partial class Assign_Trip : Form
    {
        DBhandler db = new DBhandler();
        ErrorProvider e = new ErrorProvider();
   
        public Assign_Trip()
        {
            InitializeComponent();
            panelcleaner.Hide();
            dateTimePicker1.CustomFormat = "dd:MMM:yyyy";
            label20.Text = db.max_plus("SELECT max([Id])FROM [AVVMS].[dbo].[Trips]").ToString();
            combotype.SelectedIndex = 0;
            combovehi.SelectedIndex = 0;

            DataTable dt = new DataTable();
            dt = db.GetTable("SELECT [Employee ID]FROM [AVVMS].[dbo].[Employee] where [Category]='Driver' and [Status]='Available'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                combodriver.Items.Add(dt.Rows[i]["Employee ID"].ToString());
            }
            combodriver.SelectedIndex = 0;

            dt = new DataTable();
            dt = db.GetTable("SELECT [Employee ID]FROM [AVVMS].[dbo].[Employee] where [Category]='Cleaner' and [Status]='Available'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                combofirst.Items.Add(dt.Rows[i]["Employee ID"].ToString());
            }
            
            combofirst.SelectedIndex = 0;

            for (int i = 1; i < combofirst.Items.Count; i++)
            {

                comboBox7.Items.Add(combofirst.Items[i]);
            }
            comboBox7.SelectedIndex = 0;

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!combotype.SelectedItem.ToString().Equals("Select Vehicle Type"))
            {
                if (combotype.SelectedItem.ToString().Equals("Hospital Heavy")) 
                {
                    panelcleaner.Show();
                    while (combovehi.Items.Count != 1)
                    {
                        combovehi.Items.RemoveAt(1);
                    }
                    DataTable dt = new DataTable();
                    dt = db.GetTable("SELECT [Vehicle No.]FROM [AVVMS].[dbo].[Vehicles] where [Type]='Hospital Heavy' and [Status]='Available'");

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        combovehi.Items.Add(dt.Rows[i]["Vehicle No."].ToString());
                    }
                    combovehi.SelectedIndex = 0;
                }
                else if (combotype.SelectedItem.ToString().Equals("Heavy"))
                {

                    panelcleaner.Show();
                    while (combovehi.Items.Count != 1)
                    {
                        combovehi.Items.RemoveAt(1);
                    }
                    DataTable dt = new DataTable();
                    dt = db.GetTable("SELECT [Vehicle No.]FROM [AVVMS].[dbo].[Vehicles] where [Type]='Heavy' and [Status]='Available'");

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        combovehi.Items.Add(dt.Rows[i]["Vehicle No."].ToString());
                    }
                    combovehi.SelectedIndex = 0;
                }
                else if (combotype.SelectedItem.ToString().Equals("Light"))
                {

                    panelcleaner.Hide();
                    while (combovehi.Items.Count != 1)
                    {
                        combovehi.Items.RemoveAt(1);
                    }
                    DataTable dt = new DataTable();
                    dt = db.GetTable("SELECT [Vehicle No.]FROM [AVVMS].[dbo].[Vehicles] where [Type]='Light' and [Status]='Available'");

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        combovehi.Items.Add(dt.Rows[i]["Vehicle No."].ToString());
                    }
                    combovehi.SelectedIndex = 0;
                }
                else if (combotype.SelectedItem.ToString().Equals("Hospital Light"))
                {

                    panelcleaner.Hide();
                    while (combovehi.Items.Count != 1)
                    {
                        combovehi.Items.RemoveAt(1);
                    }
                    DataTable dt = new DataTable();
                    dt = db.GetTable("SELECT [Vehicle No.]FROM [AVVMS].[dbo].[Vehicles] where [Type]='Hospital Light' and [Status]='Available'");

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        combovehi.Items.Add(dt.Rows[i]["Vehicle No."].ToString());
                    }
                    combovehi.SelectedIndex = 0;
                }
               
            }
            
        }

        private void Assign_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox7.Items.Remove(combofirst.SelectedItem);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text=db.GetValue("SELECT [Meter Reading]FROM [AVVMS].[dbo].[Vehicles] where [Vehicle No.]='"+combovehi.SelectedItem.ToString()+"'");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                String fc = "", sc = "";
                if (panelcleaner.Visible)
                {
                    if (!combofirst.SelectedItem.ToString().Equals("Select First Cleaner"))
                    {
                        fc = combofirst.SelectedItem.ToString();
                    }
                    if (!comboBox7.SelectedItem.ToString().Equals("Select Second Cleaner"))
                    {

                        sc = comboBox7.SelectedItem.ToString();
                    }


                }
                try
                {

                    db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Trips]([Vehicle No.],[Journey],[Purpose],[Provider],[Remarks],[date],[driver],[first cleaner],[second cleaner],[address],[mobile],[mail],[start meter],[start time],[moment slip no.],[status],km)VALUES('" + combovehi.SelectedItem.ToString() + "','" + tfrom.Text + "-" + tto.Text + "','" + tpur.Text + "','" + tname.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + combodriver.SelectedItem.ToString() + "','" + fc + "','" + sc + "','" + richTextadd.Text + "','" + tmobile.Text + "','" + tmail.Text + "','" + label5.Text + "','" + timePicker.Value.ToShortTimeString() + "','" + tmom.Text + "','On Trip',0)");
                  
                    db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Vehicles]SET [Status] = 'On Trip'WHERE [Vehicle No.] = '" + combovehi.SelectedItem.ToString() + "'");

                    db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Employee]SET [Status] = 'On Trip'WHERE [Employee ID] = '" + combodriver.SelectedItem.ToString() + "'");
                    if (panelcleaner.Visible)
                    {
                        if (!combofirst.SelectedItem.ToString().Equals("Select First Cleaner"))
                        {
                            db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Employee]SET [Status] = 'On Trip'WHERE [Employee ID] = '" + combofirst.SelectedItem.ToString() + "'");
                        }
                        if (!comboBox7.SelectedItem.ToString().Equals("Select Second Cleaner"))
                        {
                            db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Employee]SET [Status] = 'On Trip'WHERE [Employee ID] = '" + comboBox7.SelectedItem.ToString() + "'");
                        }


                    }
                    MessageBox.Show("Assigned Successfully");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Try Again\nReason :" + ex.Message);
                }
            }
        }

        private bool Validation()
        {
            e.Dispose();
            bool ret;
            if (panelcleaner.Visible)
            {
                ret = isselected(combotype, "Select Vehicle Type") && isselected(combovehi, "Select Vehicle No.") && isselected(combodriver, "Select Driver") && isselected(combofirst, "Select First Cleaner") && isempty(tname, "Enter Name of Provider") && isempty(richTextadd, "Enter Provider address") && isempty(tpur, "Enter Journey Purpose") && isempty(tmail, "Enter provider mail ID") && isempty(tmobile, "Enter provider Mobile Number") && isempty(tfrom, "Enter Journey From") && isempty(tto, "Enter joureny to") && isempty(tmom, "Enter Moment Slip No.") && iscorrect(tmom, "Enter Currect Moment Slip No.");
            }
            else
            {
                ret = isselected(combotype, "Select Vehicle Type") && isselected(combovehi, "Select Vehicle No.") && isselected(combodriver, "Select Driver") && isempty(tname, "Enter Name of Provider") && isempty(richTextadd, "Enter Provider address") && isempty(tpur, "Enter Journey Purpose") && isempty(tmail, "Enter provider mail ID") && isempty(tmobile, "Enter provider Mobile Number") && isempty(tfrom, "Enter Journey From") && isempty(tto, "Enter joureny to") && isempty(tmom, "Enter Moment Slip No.") && iscorrect(tmom, "Enter Currect Moment Slip No.");
            }
          
            
            return ret;
        }

        bool isempty(System.Windows.Forms.Control c, String text)
        {

            bool ret = true;

            if (c.Text.Equals(""))
            {

                e.SetError(c, text);
                c.Focus();
                ret = false;
            }
            return ret;
        }

        bool isselected(System.Windows.Forms.ComboBox c, String text)
        {

            bool ret = true;

            if (c.SelectedIndex == 0)
            {

                e.SetError(c, text);
                c.Focus();
                ret = false;
            }
            return ret;
        }

        bool iscorrect(System.Windows.Forms.TextBox c, String text)
        {

            bool ret = true;
            try
            {

                Decimal i = Convert.ToDecimal(c.Text);
                if (i == 0)
                {
                    e.SetError(c, text);
                    c.Focus();
                    ret = false;
                }
            }
            catch (FormatException ex)
            {

                e.SetError(c, text);
                c.Focus();
                ret = false;
            }

            return ret;
        }

    }
}
