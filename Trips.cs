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
    public partial class Trips : Form
    {
        DBhandler db = new DBhandler();
        DataTable dt = new DataTable();
        

        public Trips()
        {
            InitializeComponent();
            label1.Text = label1.Text + " : " + DateTime.Now.ToShortDateString();
           
            DGV_Today_Trips.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle No.],[Journey] ,[Purpose],[Provider],[Remarks] FROM [AVVMS].[dbo].[Trips] where [date] ='" + DateTime.Now.ToShortDateString() + "' and [Status] != 'Complete'");

            
            dt = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle No.],[Journey] ,[Purpose],[Provider],[Date],[Remarks] FROM [AVVMS].[dbo].[Trips] where [date] !='" + DateTime.Now.ToShortDateString() + "'");

            coming_trips_display(dt);

            comboBox1.SelectedIndex=0;
            
            CmbSearchType.SelectedIndex = 0;
            

            
            
        }

        public void coming_trips_display(DataTable dt)
        {
            
            dataGridView1.Rows.Clear();
            DateTime n = DateTime.Now;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DateTime d = DateTime.Parse(dt.Rows[i]["date"].ToString());
                int c = n.CompareTo(d);
                if (c == -1)
                {
                    dataGridView1.Rows.Add(dt.Rows[i]["Sl. No."].ToString(), dt.Rows[i]["Vehicle No."].ToString(), dt.Rows[i]["Journey"].ToString(), dt.Rows[i]["Purpose"].ToString(), dt.Rows[i]["Provider"].ToString(), dt.Rows[i]["Date"].ToString(), dt.Rows[i]["Remarks"].ToString());
                }
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            String fields = "[Id] as [Sl. No.],[Vehicle No.],[Journey] ,[Purpose],[Provider],[Remarks]";
            string table = "[AVVMS].[dbo].[Trips]";
           
            String search_field = "[Vehicle No.]";
            String searchkey = TxtSearch.Text;

            String append_text_today="where [date] ='" + DateTime.Now.ToShortDateString() + "' and [Status] != 'Complete'";
            String append_text_coming = "where [date] !='" + DateTime.Now.ToShortDateString() + "'";

            if (TxtSearch.Text.Equals(""))
            {
                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search(fields,table),append_text_today));

                fields = "[Id] as [Sl. No.],[Vehicle No.],[Journey] ,[Purpose],[Provider],[Date],[Remarks]";
                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search(fields, table), append_text_coming));
                coming_trips_display(dt);
            }
            else
            {
                if (xPander2.IsExpanded)
                {
                    if (RdbStartsWith.Checked)
                    {

                        if (comboBox1.SelectedItem.ToString().Equals("Today Trips"))
                        {


                            append_text_today = "and [date] ='" + DateTime.Now.ToShortDateString() + "' and [Status] != 'Complete'";
                            if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                            {
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_start(fields, table, search_field, searchkey), append_text_today));


                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Journey"))
                            {
                                search_field = "[Journey]";
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_start(fields, table, search_field, searchkey), append_text_today));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Purpose"))
                            {
                                search_field = "[Purpose]";
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_start(fields, table, search_field, searchkey), append_text_today));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Provider"))
                            {
                                search_field = "[Provider]";
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_start(fields, table, search_field, searchkey), append_text_today));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                            {
                                search_field = "[Remarks]";
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_start(fields, table, search_field, searchkey), append_text_today));

                            }



                        }
                        else if (comboBox1.SelectedItem.ToString().Equals("Coming Trips"))
                        {
                            append_text_coming = "and [date] !='" + DateTime.Now.ToShortDateString() + "'";
                            fields = "[Id] as [Sl. No.],[Vehicle No.],[Journey] ,[Purpose],[Provider],[Date],[Remarks]";



                            if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                            {
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_start(fields, table, search_field, searchkey), append_text_coming));


                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Journey"))
                            {
                                search_field = "[Journey]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_start(fields, table, search_field, searchkey), append_text_coming));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Purpose"))
                            {
                                search_field = "[Purpose]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_start(fields, table, search_field, searchkey), append_text_coming));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Provider"))
                            {
                                search_field = "[Provider]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_start(fields, table, search_field, searchkey), append_text_coming));

                            }

                            else if (CmbSearchType.SelectedItem.ToString().Equals("Date"))
                            {
                                search_field = "[Date]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_start(fields, table, search_field, searchkey), append_text_coming));

                            }

                            else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                            {
                                search_field = "[Remarks]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_start(fields, table, search_field, searchkey), append_text_coming));

                            }
                            coming_trips_display(dt);

                        }
                        
                    }
                    else if (RdbEndsWithH.Checked)
                    {
                        if (comboBox1.SelectedItem.ToString().Equals("Today Trips"))
                        {


                            append_text_today = "and [date] ='" + DateTime.Now.ToShortDateString() + "' and [Status] != 'Complete'";
                            if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                            {
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_end(fields, table, search_field, searchkey), append_text_today));


                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Journey"))
                            {
                                search_field = "[Journey]";
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_end(fields, table, search_field, searchkey), append_text_today));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Purpose"))
                            {
                                search_field = "[Purpose]";
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_end(fields, table, search_field, searchkey), append_text_today));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Provider"))
                            {
                                search_field = "[Provider]";
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_end(fields, table, search_field, searchkey), append_text_today));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                            {
                                search_field = "[Remarks]";
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_end(fields, table, search_field, searchkey), append_text_today));

                            }



                        }
                        else if (comboBox1.SelectedItem.ToString().Equals("Coming Trips"))
                        {
                            append_text_coming = "and [date] !='" + DateTime.Now.ToShortDateString() + "'";
                            fields = "[Id] as [Sl. No.],[Vehicle No.],[Journey] ,[Purpose],[Provider],[Date],[Remarks]";



                            if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                            {
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_end(fields, table, search_field, searchkey), append_text_coming));


                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Journey"))
                            {
                                search_field = "[Journey]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_end(fields, table, search_field, searchkey), append_text_coming));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Purpose"))
                            {
                                search_field = "[Purpose]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_end(fields, table, search_field, searchkey), append_text_coming));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Provider"))
                            {
                                search_field = "[Provider]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_end(fields, table, search_field, searchkey), append_text_coming));

                            }

                            else if (CmbSearchType.SelectedItem.ToString().Equals("Date"))
                            {
                                search_field = "[Date]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_end(fields, table, search_field, searchkey), append_text_coming));

                            }

                            else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                            {
                                search_field = "[Remarks]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_end(fields, table, search_field, searchkey), append_text_coming));

                            }
                            coming_trips_display(dt);

                        }

                    }
                    else if (RdbContains.Checked)
                    {

                        if (comboBox1.SelectedItem.ToString().Equals("Today Trips"))
                        {


                            append_text_today = "and [date] ='" + DateTime.Now.ToShortDateString() + "' and [Status] != 'Complete'";
                            if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                            {
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_contains(fields, table, search_field, searchkey), append_text_today));


                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Journey"))
                            {
                                search_field = "[Journey]";
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_contains(fields, table, search_field, searchkey), append_text_today));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Purpose"))
                            {
                                search_field = "[Purpose]";
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_contains(fields, table, search_field, searchkey), append_text_today));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Provider"))
                            {
                                search_field = "[Provider]";
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_contains(fields, table, search_field, searchkey), append_text_today));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                            {
                                search_field = "[Remarks]";
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_contains(fields, table, search_field, searchkey), append_text_today));

                            }



                        }
                        else if (comboBox1.SelectedItem.ToString().Equals("Coming Trips"))
                        {
                            append_text_coming = "and [date] !='" + DateTime.Now.ToShortDateString() + "'";
                            fields = "[Id] as [Sl. No.],[Vehicle No.],[Journey] ,[Purpose],[Provider],[Date],[Remarks]";



                            if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                            {
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_contains(fields, table, search_field, searchkey), append_text_coming));


                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Journey"))
                            {
                                search_field = "[Journey]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_contains(fields, table, search_field, searchkey), append_text_coming));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Purpose"))
                            {
                                search_field = "[Purpose]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_contains(fields, table, search_field, searchkey), append_text_coming));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Provider"))
                            {
                                search_field = "[Provider]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_contains(fields, table, search_field, searchkey), append_text_coming));

                            }

                            else if (CmbSearchType.SelectedItem.ToString().Equals("Date"))
                            {
                                search_field = "[Date]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_contains(fields, table, search_field, searchkey), append_text_coming));

                            }

                            else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                            {
                                search_field = "[Remarks]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_contains(fields, table, search_field, searchkey), append_text_coming));

                            }
                            coming_trips_display(dt);

                        }
                    }
                    else if (RdbDoesNotContains.Checked)
                    {

                        if (comboBox1.SelectedItem.ToString().Equals("Today Trips"))
                        {


                            append_text_today = "and [date] ='" + DateTime.Now.ToShortDateString() + "' and [Status] != 'Complete'";
                            if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                            {
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_notcontains(fields, table, search_field, searchkey), append_text_today));


                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Journey"))
                            {
                                search_field = "[Journey]";
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_notcontains(fields, table, search_field, searchkey), append_text_today));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Purpose"))
                            {
                                search_field = "[Purpose]";
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_notcontains(fields, table, search_field, searchkey), append_text_today));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Provider"))
                            {
                                search_field = "[Provider]";
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_notcontains(fields, table, search_field, searchkey), append_text_today));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                            {
                                search_field = "[Remarks]";
                                DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_notcontains(fields, table, search_field, searchkey), append_text_today));

                            }



                        }
                        else if (comboBox1.SelectedItem.ToString().Equals("Coming Trips"))
                        {
                            append_text_coming = "and [date] !='" + DateTime.Now.ToShortDateString() + "'";
                            fields = "[Id] as [Sl. No.],[Vehicle No.],[Journey] ,[Purpose],[Provider],[Date],[Remarks]";



                            if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                            {
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_notcontains(fields, table, search_field, searchkey), append_text_coming));


                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Journey"))
                            {
                                search_field = "[Journey]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_notcontains(fields, table, search_field, searchkey), append_text_coming));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Purpose"))
                            {
                                search_field = "[Purpose]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_notcontains(fields, table, search_field, searchkey), append_text_coming));

                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Provider"))
                            {
                                search_field = "[Provider]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_notcontains(fields, table, search_field, searchkey), append_text_coming));

                            }

                            else if (CmbSearchType.SelectedItem.ToString().Equals("Date"))
                            {
                                search_field = "[Date]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_notcontains(fields, table, search_field, searchkey), append_text_coming));

                            }

                            else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                            {
                                search_field = "[Remarks]";
                                dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild_notcontains(fields, table, search_field, searchkey), append_text_coming));

                            }
                            coming_trips_display(dt);

                        }
                    }
                }
                else
                {

                    if (comboBox1.SelectedItem.ToString().Equals("Today Trips"))
                    {


                        append_text_today = "and [date] ='" + DateTime.Now.ToShortDateString() + "' and [Status] != 'Complete'";
                        if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                        {
                            DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild(fields, table, search_field, searchkey), append_text_today));
                           

                        }
                        else if (CmbSearchType.SelectedItem.ToString().Equals("Journey"))
                        {
                            search_field="[Journey]";
                            DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild(fields, table, search_field, searchkey), append_text_today));
                            
                        }
                        else if (CmbSearchType.SelectedItem.ToString().Equals("Purpose"))
                        {
                            search_field = "[Purpose]";
                            DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild(fields, table, search_field, searchkey), append_text_today));

                        }
                        else if (CmbSearchType.SelectedItem.ToString().Equals("Provider"))
                        {
                            search_field = "[Provider]";
                            DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild(fields, table, search_field, searchkey), append_text_today));

                        }
                        else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                        {
                            search_field = "[Remarks]";
                            DGV_Today_Trips.DataSource = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild(fields, table, search_field, searchkey), append_text_today));

                        }



                    }
                    else if (comboBox1.SelectedItem.ToString().Equals("Coming Trips"))
                    {
                        append_text_coming = "and [date] !='" + DateTime.Now.ToShortDateString() + "'";
                        fields = "[Id] as [Sl. No.],[Vehicle No.],[Journey] ,[Purpose],[Provider],[Date],[Remarks]";
                        

                        
                        if (CmbSearchType.SelectedItem.ToString().Equals("Vehicle No."))
                        {
                            dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild(fields, table, search_field, searchkey), append_text_coming));


                        }
                        else if (CmbSearchType.SelectedItem.ToString().Equals("Journey"))
                        {
                            search_field = "[Journey]";
                            dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild(fields, table, search_field, searchkey), append_text_coming));

                        }
                        else if (CmbSearchType.SelectedItem.ToString().Equals("Purpose"))
                        {
                            search_field = "[Purpose]";
                            dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild(fields, table, search_field, searchkey), append_text_coming));

                        }
                        else if (CmbSearchType.SelectedItem.ToString().Equals("Provider"))
                        {
                            search_field = "[Provider]";
                            dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild(fields, table, search_field, searchkey), append_text_coming));

                        }

                        else if (CmbSearchType.SelectedItem.ToString().Equals("Date"))
                        {
                            search_field = "[Date]";
                            dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild(fields, table, search_field, searchkey), append_text_coming));

                        }

                        else if (CmbSearchType.SelectedItem.ToString().Equals("Remarks"))
                        {
                            search_field = "[Remarks]";
                            dt = db.GetTable(Search_Handler.query_append(Search_Handler.query_builder_search_feild(fields, table, search_field, searchkey), append_text_coming));

                        }
                        coming_trips_display(dt);

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

            if (comboBox1.SelectedItem.ToString().Equals("Today Trips"))
            {
                

               

                
                dt = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle No.],[Journey] ,[Purpose],[Provider],[Date],[Remarks] FROM [AVVMS].[dbo].[Trips] where [date] !='" + DateTime.Now.ToShortDateString() + "'");

                coming_trips_display(dt);

                CmbSearchType.Items.Add("Vehicle No.");
                CmbSearchType.Items.Add("Journey");
                CmbSearchType.Items.Add("Purpose");
                CmbSearchType.Items.Add("Provider");
                CmbSearchType.Items.Add("Remarks");

            }
            else if (comboBox1.SelectedItem.ToString().Equals("Coming Trips"))
            {
                DGV_Today_Trips.DataSource = db.GetTable("SELECT [Id] as [Sl. No.],[Vehicle No.],[Journey] ,[Purpose],[Provider],[Remarks] FROM [AVVMS].[dbo].[Trips] where [date] ='" + DateTime.Now.ToShortDateString() + "' and [Status] != 'Complete'");

                CmbSearchType.Items.Add("Vehicle No.");
                CmbSearchType.Items.Add("Journey");
                CmbSearchType.Items.Add("Purpose");
                CmbSearchType.Items.Add("Provider");
                CmbSearchType.Items.Add("Date");
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
