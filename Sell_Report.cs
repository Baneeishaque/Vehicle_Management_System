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
    public partial class Sell_Report : Form
    {
        DBhandler db = new DBhandler();
        private double oa;
        public Sell_Report()
        {
            InitializeComponent();
            dataGridView6.DataSource = db.GetTable("SELECT [Id] ,[Tender date] ,[Selected Tender No.] ,[Tender Amount] ,[Cheque No.] ,[Purchase date] ,[vehicle] FROM [AVVMS].[dbo].[sell]");

            oa = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {

                oa = oa + Convert.ToDouble(dataGridView6.Rows[i].Cells[4].Value.ToString());
            }
            label9.Text = "Total : " + oa.ToString();
        }
    }
}
