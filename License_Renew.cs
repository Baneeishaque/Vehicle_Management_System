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
    public partial class License_Renew : Form
    {
        DBhandler db = new DBhandler();
        public License_Renew()
        {
            InitializeComponent();
            dataGridView6.DataSource = db.GetTable("SELECT [no] as [Sl. No.] ,[Employee ID] ,[New Expiry Date] ,[Entry Date],[remarks] as Remarks FROM [AVVMS].[dbo].[license renew]");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Lisence_Renew_Input().ShowDialog();
            dataGridView6.DataSource = db.GetTable("SELECT [no] as [Sl. No.] ,[Employee ID] ,[New Expiry Date] ,[Entry Date],[remarks] as Remarks FROM [AVVMS].[dbo].[license renew]");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
