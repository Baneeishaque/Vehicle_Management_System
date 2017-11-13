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
    public partial class Notifications : Form
    {
        DBhandler db = new DBhandler();
        public Notifications()
        {
            InitializeComponent();
            
            DGV_Refill.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Remain] as [Remaining Fuel],[Limit] as [Refill Limit],[LastRefillDate] as [Last Refill Date] FROM [AVVMS].[dbo].[Refill_Notifications]");
            DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications]");
            DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications]");

            comboBox1.SelectedIndex = 0;
            CmbSearchType.SelectedIndex = 0;
            
        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aVVMSDataSet.Employee_Notifications' table. You can move, or remove it, as needed.
            

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if(TxtSearch.Text.Equals(""))
            {
                DGV_Refill.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Remain] as [Remaining Fuel],[Limit] as [Refill Limit],[LastRefillDate] as [Last Refill Date] FROM [AVVMS].[dbo].[Refill_Notifications]");
                DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications]");
                DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications]");
            }
            else
            {
                if (xPander2.IsExpanded)
                {
                    if (RdbStartsWith.Checked)
                    {

                        if (comboBox1.SelectedItem.ToString().Equals("Refill Notifications"))
                        {



                            if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                            {

                                DGV_Refill.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Remain] as [Remaining Fuel],[Limit] as [Refill Limit],[LastRefillDate] as [Last Refill Date] FROM [AVVMS].[dbo].[Refill_Notifications] where [Vehicle] LIKE '"+TxtSearch.Text+"%'");

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Last Refill Date"))
                            {
                                DGV_Refill.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Remain] as [Remaining Fuel],[Limit] as [Refill Limit],[LastRefillDate] as [Last Refill Date] FROM [AVVMS].[dbo].[Refill_Notifications] where [LastRefillDate]LIKE '" + TxtSearch.Text + "%'");

                            }



                        }
                        else if (comboBox1.SelectedItem.ToString().Equals("Vehicle Notifications"))
                        {


                            if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                            {

                                DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications] where [Vehicle]LIKE '" + TxtSearch.Text + "%'");

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Reason"))
                            {

                                DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications] where [Reason]LIKE '" + TxtSearch.Text + "%'");

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                            {

                                DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications] where [Remarks]LIKE '" + TxtSearch.Text + "%'");

                            }


                        }
                        else if (comboBox1.SelectedItem.ToString().Equals("Employee Notifications"))
                        {


                            if (CmbSearchType.SelectedItem.ToString().Equals("Employee_ID"))
                            {


                                DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications] where [Employee_ID]LIKE '" + TxtSearch.Text + "%'");
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Reason"))
                            {

                                DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications] where [Reason]LIKE '" + TxtSearch.Text + "%'");
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                            {

                                DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications] where [Remarks]LIKE '" + TxtSearch.Text + "%'");
                            }

                        }
                    }
                    else if (RdbEndsWithH.Checked)
                    {
                        if (comboBox1.SelectedItem.ToString().Equals("Refill Notifications"))
                        {



                            if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                            {

                                DGV_Refill.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Remain] as [Remaining Fuel],[Limit] as [Refill Limit],[LastRefillDate] as [Last Refill Date] FROM [AVVMS].[dbo].[Refill_Notifications] where [Vehicle]LIKE '%" + TxtSearch.Text + "'");

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Last Refill Date"))
                            {
                                DGV_Refill.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Remain] as [Remaining Fuel],[Limit] as [Refill Limit],[LastRefillDate] as [Last Refill Date] FROM [AVVMS].[dbo].[Refill_Notifications] where [LastRefillDate]LIKE '%" + TxtSearch.Text + "'");

                            }



                        }
                        else if (comboBox1.SelectedItem.ToString().Equals("Vehicle Notifications"))
                        {


                            if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                            {

                                DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications] where [Vehicle]LIKE '%" + TxtSearch.Text + "'");

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Reason"))
                            {

                                DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications] where [Reason]LIKE '%" + TxtSearch.Text + "'");

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                            {

                                DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications] where [Remarks]LIKE '%" + TxtSearch.Text + "'");

                            }


                        }
                        else if (comboBox1.SelectedItem.ToString().Equals("Employee Notifications"))
                        {


                            if (CmbSearchType.SelectedItem.ToString().Equals("Employee_ID"))
                            {


                                DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications] where [Employee_ID]LIKE '%" + TxtSearch.Text + "'");
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Reason"))
                            {

                                DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications] where [Reason]LIKE '%" + TxtSearch.Text + "'");
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                            {

                                DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications] where [Remarks]LIKE '%" + TxtSearch.Text + "'");
                            }

                        }

                    }
                    else if (RdbContains.Checked)
                    {

                        if (comboBox1.SelectedItem.ToString().Equals("Refill Notifications"))
                        {



                            if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                            {

                                DGV_Refill.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Remain] as [Remaining Fuel],[Limit] as [Refill Limit],[LastRefillDate] as [Last Refill Date] FROM [AVVMS].[dbo].[Refill_Notifications] where [Vehicle]LIKE '%" + TxtSearch.Text + "%'");

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Last Refill Date"))
                            {
                                DGV_Refill.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Remain] as [Remaining Fuel],[Limit] as [Refill Limit],[LastRefillDate] as [Last Refill Date] FROM [AVVMS].[dbo].[Refill_Notifications] where [LastRefillDate]LIKE '%" + TxtSearch.Text + "%'");

                            }



                        }
                        else if (comboBox1.SelectedItem.ToString().Equals("Vehicle Notifications"))
                        {


                            if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                            {

                                DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications] where [Vehicle]LIKE '%" + TxtSearch.Text + "%'");

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Reason"))
                            {

                                DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications] where [Reason]LIKE '%" + TxtSearch.Text + "%'");

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                            {

                                DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications] where [Remarks]LIKE '%" + TxtSearch.Text + "%'");

                            }


                        }
                        else if (comboBox1.SelectedItem.ToString().Equals("Employee Notifications"))
                        {


                            if (CmbSearchType.SelectedItem.ToString().Equals("Employee_ID"))
                            {


                                DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications] where [Employee_ID]LIKE '%" + TxtSearch.Text + "%'");
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Reason"))
                            {

                                DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications] where [Reason]LIKE '%" + TxtSearch.Text + "%'");
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                            {

                                DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications] where [Remarks]LIKE '%" + TxtSearch.Text + "%'");
                            }

                        }
                    }
                    else if (RdbDoesNotContains.Checked)
                    {

                        if (comboBox1.SelectedItem.ToString().Equals("Refill Notifications"))
                        {



                            if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                            {

                                DGV_Refill.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Remain] as [Remaining Fuel],[Limit] as [Refill Limit],[LastRefillDate] as [Last Refill Date] FROM [AVVMS].[dbo].[Refill_Notifications] where [Vehicle]NOT LIKE '%" + TxtSearch.Text + "%'");

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Last Refill Date"))
                            {
                                DGV_Refill.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Remain] as [Remaining Fuel],[Limit] as [Refill Limit],[LastRefillDate] as [Last Refill Date] FROM [AVVMS].[dbo].[Refill_Notifications] where [LastRefillDate]NOT LIKE '%" + TxtSearch.Text + "%'");

                            }



                        }
                        else if (comboBox1.SelectedItem.ToString().Equals("Vehicle Notifications"))
                        {


                            if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                            {

                                DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications] where [Vehicle]NOT LIKE '%" + TxtSearch.Text + "%'");

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Reason"))
                            {

                                DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications] where [Reason]NOT LIKE '%" + TxtSearch.Text + "%'");

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                            {

                                DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications] where [Remarks]NOT LIKE '%" + TxtSearch.Text + "%'");

                            }


                        }
                        else if (comboBox1.SelectedItem.ToString().Equals("Employee Notifications"))
                        {


                            if (CmbSearchType.SelectedItem.ToString().Equals("Employee_ID"))
                            {


                                DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications] where [Employee_ID]NOT LIKE '%" + TxtSearch.Text + "%'");
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Reason"))
                            {

                                DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications] where [Reason]NOT LIKE '%" + TxtSearch.Text + "%'");
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                            {

                                DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications] where [Remarks]NOT LIKE '%" + TxtSearch.Text + "%'");
                            }

                        }
                    }
                }
                else
                {
                    //MessageBox.Show("hai");
                    if (comboBox1.SelectedItem.ToString().Equals("Refill Notifications"))
                    {
                        
                        

                        if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                        {

                            DGV_Refill.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Remain] as [Remaining Fuel],[Limit] as [Refill Limit],[LastRefillDate] as [Last Refill Date] FROM [AVVMS].[dbo].[Refill_Notifications] where [Vehicle]='"+TxtSearch.Text+"'");
                       
                        }
                        else if (CmbSearchType.SelectedItem.ToString().Equals("Last Refill Date"))
                        {
                            DGV_Refill.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Remain] as [Remaining Fuel],[Limit] as [Refill Limit],[LastRefillDate] as [Last Refill Date] FROM [AVVMS].[dbo].[Refill_Notifications] where [LastRefillDate]='" + TxtSearch.Text + "'");
                     
                        }
                    
                    

                    }
                    else if (comboBox1.SelectedItem.ToString().Equals("Vehicle Notifications"))
                    {
                       

                        if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                        {

                            DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications] where [Vehicle]='" + TxtSearch.Text + "'");
                      
                        }
                        else if (CmbSearchType.SelectedItem.ToString().Equals("Reason"))
                        {

                            DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications] where [Reason]='" + TxtSearch.Text + "'");
                    
                        }
                        else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                        {

                            DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications] where [Remarks]='" + TxtSearch.Text + "'");
                     
                        }
                    
                    
                    }
                    else if (comboBox1.SelectedItem.ToString().Equals("Employee Notifications"))
                    {
                       
                       
                        if (CmbSearchType.SelectedItem.ToString().Equals("Employee_ID"))
                        {


                            DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications] where [Employee_ID]='" + TxtSearch.Text + "'");
                        }
                        else if (CmbSearchType.SelectedItem.ToString().Equals("Reason"))
                        {

                            DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications] where [Reason]='" + TxtSearch.Text + "'");
                        }
                        else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                        {

                            DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications] where [Remarks]='" + TxtSearch.Text + "'");
                        }
                   
                    }
                }
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (CmbSearchType.Items.Count != 0)
            {
                CmbSearchType.Items.RemoveAt(0);
            }

            if (comboBox1.SelectedItem.ToString().Equals("Refill Notifications"))
            {
                DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications]");
                DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications]");

                CmbSearchType.Items.Add("Vehicle No.");
                CmbSearchType.Items.Add("Last Refill Date");
                
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Vehicle Notifications"))
            {
                DGV_Refill.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Remain] as [Remaining Fuel],[Limit] as [Refill Limit],[LastRefillDate] as [Last Refill Date] FROM [AVVMS].[dbo].[Refill_Notifications]");

                DGV_Employee.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Employee_ID] as [Employee ID],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Employee_Notifications]");

                CmbSearchType.Items.Add("Vehicle No.");
                CmbSearchType.Items.Add("Reason");
                CmbSearchType.Items.Add("Remarks");
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Employee Notifications"))
            {
                DGV_Refill.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Remain] as [Remaining Fuel],[Limit] as [Refill Limit],[LastRefillDate] as [Last Refill Date] FROM [AVVMS].[dbo].[Refill_Notifications]");
                DGV_Vehicle.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks] FROM [AVVMS].[dbo].[Vehicle_Notifications]");

                CmbSearchType.Items.Add("Employee_ID");
                CmbSearchType.Items.Add("Reason");
                CmbSearchType.Items.Add("Remarks");
            }
            CmbSearchType.SelectedIndex = 0;
            TxtSearch.Text = "";
        }

        private void CmbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtSearch.Text = "";
        }

        private void xPander2_MouseClick(object sender, MouseEventArgs e)
        {
            TxtSearch.Text = "";
        }
    }
}
