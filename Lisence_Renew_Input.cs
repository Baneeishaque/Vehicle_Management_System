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
    public partial class Lisence_Renew_Input : Form
    {
        DBhandler db = new DBhandler();
        public Lisence_Renew_Input()
        {
            InitializeComponent();
            label2.Text = (Convert.ToInt32(db.GetValue("SELECT [no] FROM [AVVMS].[dbo].[license renew]"))+1).ToString();
            DataTable dt = new DataTable();
            dt = db.GetTable("SELECT [Employee ID]FROM [AVVMS].[dbo].[Employee] where Status != 'Removed' AND Category='Driver'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                comboBox1.Items.Add(dt.Rows[i]["Employee ID"].ToString());
            }
            comboBox1.SelectedIndex = 0;
            label11.Hide();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Equals("Select Employee"))
            {
                label11.Hide();
            }
            else
            {

                label11.Text = "Expires On : " + db.GetValue("SELECT [License Expiry date]  FROM [AVVMS].[dbo].[Employee] where [Employee ID]='" + comboBox1.SelectedItem.ToString() + "'");
                label11.Show();
            }
        }

        ErrorProvider err = new ErrorProvider();
        private bool Validation()
        {

            err.Dispose();


           
                return isselectedg(new ComboBox[1] { comboBox1 });
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                try
                {
                    db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[license renew] ([Entry Date] ,[Employee ID] ,[New Expiry Date] ,[remarks] ) VALUES ('" + dateTimePicker1.Value.ToShortDateString() + "' ,'" + comboBox1.SelectedItem.ToString() + "' ,'" + dateTimePicker3.Value.ToShortDateString() + "' ,'" + textBox7.Text + "' )");
                    db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Employee] SET [License Expiry date] = '" + dateTimePicker3.Value.ToShortDateString() + "' where [Employee ID]='" + comboBox1.SelectedItem.ToString() + "'");
                    MessageBox.Show("Insertion Success");

                    if ((DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15).CompareTo(DateTime.Parse(dateTimePicker3.Value.ToShortDateString()))) >= 0)
                    {
                        db.Ins_Up_Del("INSERT INTO [AVVMS].[dbo].[Employee_Notifications]([Employee_ID],[Reason],[Remarks])VALUES('" + comboBox1.SelectedItem.ToString() + "','Lisence of Employee ID : " + comboBox1.SelectedItem.ToString() + " will expire On : " + dateTimePicker3.Value.ToShortDateString() + "','Expiration Date : " + dateTimePicker3.Value.ToShortDateString() + "')");

                        Program.pi.Display("Lisence of Employee ID : " + comboBox1.SelectedItem.ToString() + " will expire On : " + dateTimePicker3.Value.ToShortDateString() + "");

                        db.Ins_Up_Del("UPDATE [AVVMS].[dbo].[Employee]SET [status] = 'On Lisence Expiration' WHERE [Employee ID]='" + comboBox1.SelectedItem.ToString() + "'");



                    }

                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Try Again...\nReason : " + ex.Message);
                }
            }
            
        }
    }
}
