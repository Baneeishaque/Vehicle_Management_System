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
    public partial class Batha_Report : Form
    {
        DBhandler db = new DBhandler();
        private double oa;
        private int date_p_flag=0;
        public Batha_Report()
        {
            InitializeComponent();
            dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report");
            
            oa = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[3].Value.ToString());
            }
            label2.Text = "Total : "+oa.ToString();
            label3.Hide();
            CmbSearchType.SelectedIndex = 0;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(1);
            label3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(-1);
            label3.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            date_p_flag = 1;
            TxtSearch.Text = "";
            label1.Text = dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Year.ToString();
            dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%"+label1.Text+"%'");

            oa = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[3].Value.ToString());
            }
            label2.Text = "Total : " + oa.ToString();
            date_p_flag = 0;
            

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label1.Text = "All";
            date_p_flag = 1;
            TxtSearch.Text = "";

            dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report");

            oa = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[3].Value.ToString());
            }
            label2.Text = "Total : " + oa.ToString();
            date_p_flag = 0;
            label3.Hide();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if(date_p_flag==0)
            {
                if (TxtSearch.Text.Equals(""))
                {
                    if (label3.Visible)
                    {
                        dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%'");
                    }
                    else
                    {
                        dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report");
                    }
                }
                else
                {
                    if (xPander2.IsExpanded)
                    {
                        if (RdbStartsWith.Checked)
                        {


                            if (CmbSearchType.SelectedItem.ToString().Equals("Employee ID"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND [Employee ID] LIKE '" + TxtSearch.Text + "%'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where [Employee ID] LIKE '" + TxtSearch.Text + "%'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Trip No."))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND [Trip No.] LIKE '" + TxtSearch.Text + "%'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where [Trip No.] LIKE '" + TxtSearch.Text + "%'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Date"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND Date LIKE '" + TxtSearch.Text + "%'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where Date LIKE '" + TxtSearch.Text + "%'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Batha"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND Batha LIKE '" + TxtSearch.Text + "%'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where Batha LIKE '" + TxtSearch.Text + "%'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Batha Amount"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND [Batha Amount] LIKE '" + TxtSearch.Text + "%'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where [Batha Amount] LIKE '" + TxtSearch.Text + "%'");
                                }
                            }



                           
                                



                            
                            
                        }
                        else if (RdbEndsWithH.Checked)
                        {



                            if (CmbSearchType.SelectedItem.ToString().Equals("Employee ID"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND [Employee ID] LIKE '%" + TxtSearch.Text + "'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where [Employee ID] LIKE '%" + TxtSearch.Text + "'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Trip No."))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND [Trip No.] LIKE '%" + TxtSearch.Text + "'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where [Trip No.] LIKE '%" + TxtSearch.Text + "'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Date"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND Date LIKE '%" + TxtSearch.Text + "'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where Date LIKE '%" + TxtSearch.Text + "'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Batha"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND Batha LIKE '%" + TxtSearch.Text + "'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where Batha LIKE '%" + TxtSearch.Text + "'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Batha Amount"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND [Batha Amount] LIKE '%" + TxtSearch.Text + "'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where [Batha Amount] LIKE '%" + TxtSearch.Text + "'");
                                }
                            }


                            
                               



                         
                            

                        }
                        else if (RdbContains.Checked)
                        {

                            if (CmbSearchType.SelectedItem.ToString().Equals("Employee ID"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND [Employee ID] LIKE '%" + TxtSearch.Text + "%'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where [Employee ID] LIKE '%" + TxtSearch.Text + "%'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Trip No."))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND [Trip No.] LIKE '%" + TxtSearch.Text + "%'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where [Trip No.] LIKE '%" + TxtSearch.Text + "%'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Date"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND Date LIKE '%" + TxtSearch.Text + "%'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where Date LIKE '%" + TxtSearch.Text + "%'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Batha"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND Batha LIKE '%" + TxtSearch.Text + "%'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where Batha LIKE '%" + TxtSearch.Text + "%'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Batha Amount"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND [Batha Amount] LIKE '%" + TxtSearch.Text + "%'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where [Batha Amount] LIKE '%" + TxtSearch.Text + "%'");
                                }
                            }



                              



                            
                            
                        }
                        else if (RdbDoesNotContains.Checked)
                        {

                            if (CmbSearchType.SelectedItem.ToString().Equals("Employee ID"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND [Employee ID] NOT LIKE '%" + TxtSearch.Text + "%'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where [Employee ID] NOT LIKE '%" + TxtSearch.Text + "%'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Trip No."))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND [Trip No.] NOT LIKE '%" + TxtSearch.Text + "%'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where [Trip No.] NOT LIKE '%" + TxtSearch.Text + "%'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Date"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND Date NOT LIKE '%" + TxtSearch.Text + "%'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where Date NOT LIKE '%" + TxtSearch.Text + "%'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Batha"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND Batha NOT LIKE '%" + TxtSearch.Text + "%'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where Batha NOT LIKE '%" + TxtSearch.Text + "%'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Batha Amount"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND [Batha Amount] NOT LIKE '%" + TxtSearch.Text + "%'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where [Batha Amount] NOT LIKE '%" + TxtSearch.Text + "%'");
                                }
                            }




                               
                            
                        }
                    }
                    else
                    {
                            if (CmbSearchType.SelectedItem.ToString().Equals("Employee ID"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND [Employee ID]='" + TxtSearch.Text + "'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where [Employee ID]='" + TxtSearch.Text + "'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Trip No."))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND [Trip No.]='" + TxtSearch.Text + "'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where [Trip No.]='" + TxtSearch.Text + "'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Date"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND Date='" + TxtSearch.Text + "'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where Date='" + TxtSearch.Text + "'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Batha"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND Batha='" + TxtSearch.Text + "'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where Batha='" + TxtSearch.Text + "'");
                                }
                            }
                            else if (CmbSearchType.SelectedItem.ToString().Equals("Batha Amount"))
                            {
                                if (label3.Visible)
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where date like '%" + label1.Text + "%' AND [Batha Amount]='" + TxtSearch.Text + "'");
                                }
                                else
                                {
                                    dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report where [Batha Amount]='" + TxtSearch.Text + "'");
                                }
                            }
                            
                    }
                    
                }
                oa = 0;
                for (int i = 0; i < dataGridView6.Rows.Count; i++)
                {
                    oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[3].Value.ToString());
                }
                label2.Text = "Total : " + oa.ToString();
            }
        }

        private void xPander2_XPanderCollapsed(XPanderControl.XPander x)
        {
            
        }

        private void xPander2_XPanderExpanded(XPanderControl.XPander x)
        {
            
        }

        private void xPander2_MouseClick(object sender, MouseEventArgs e)
        {
            date_p_flag = 1;
            TxtSearch.Text = "";

            dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report");

            oa = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[3].Value.ToString());
            }
            label2.Text = "Total : " + oa.ToString();
            date_p_flag = 0;
        }

        private void RdbStartsWith_CheckedChanged(object sender, EventArgs e)
        {
            date_p_flag = 1;
            TxtSearch.Text = "";

            dataGridView6.DataSource = db.GetTable("SELECT     id AS [Sl. No.], [Employee ID], Batha, [Batha Amount], [Trip No.], Date FROM         Batha_Report");

            oa = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[3].Value.ToString());
            }
            label2.Text = "Total : " + oa.ToString();
            date_p_flag = 0;

        }

        
    }
}
