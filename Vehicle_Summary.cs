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
    public partial class Vehicle_Summary : Form
    {
        DBhandler db = new DBhandler();
        public Vehicle_Summary()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = db.GetTable("SELECT [Vehicle No.]FROM [AVVMS].[dbo].[Vehicles] where Status != 'Removed'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                try
                {
                    dataGridView6.Rows.Add("" + dt.Rows[i]["Vehicle No."].ToString() + "", "" + db.sum("SELECT sum(litres)FROM [AVVMS].[dbo].[oil] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'").ToString() + "", "" + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[oil] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'").ToString() + "", "" + db.sum("SELECT sum(litres)FROM [AVVMS].[dbo].[refill bill] where [vehicle]='" + dt.Rows[i]["Vehicle No."].ToString() + "'").ToString() + "", "" + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[refill bill] where [vehicle]='" + dt.Rows[i]["Vehicle No."].ToString() + "'").ToString() + "", "" + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[maintanance] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'").ToString() + "", "" + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[tax] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'").ToString() + "", "" + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[insurance] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'").ToString() + "", "" + (db.sum("SELECT sum(litres)FROM [AVVMS].[dbo].[oil] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[oil] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(litres)FROM [AVVMS].[dbo].[refill bill] where [vehicle]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[refill bill] where [vehicle]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[maintanance] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[tax] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[insurance] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'")).ToString() + "", "" + db.sum("SELECT sum(km)FROM [AVVMS].[dbo].[Trips] where [Vehicle No.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'").ToString() + "", "" + ((db.sum("SELECT sum(litres)FROM [AVVMS].[dbo].[oil] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[oil] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(litres)FROM [AVVMS].[dbo].[refill bill] where [vehicle]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[refill bill] where [vehicle]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[maintanance] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[tax] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[insurance] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'")) / db.sum("SELECT sum(km)FROM [AVVMS].[dbo].[Trips] where [Vehicle No.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'")).ToString() + "");
                }
                catch (DivideByZeroException e)
                {
                    dataGridView6.Rows.Add("" + dt.Rows[i]["Vehicle No."].ToString() + "", "" + db.sum("SELECT sum(litres)FROM [AVVMS].[dbo].[oil] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'").ToString() + "", "" + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[oil] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'").ToString() + "", "" + db.sum("SELECT sum(litres)FROM [AVVMS].[dbo].[refill bill] where [vehicle]='" + dt.Rows[i]["Vehicle No."].ToString() + "'").ToString() + "", "" + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[refill bill] where [vehicle]='" + dt.Rows[i]["Vehicle No."].ToString() + "'").ToString() + "", "" + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[maintanance] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'").ToString() + "", "" + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[tax] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'").ToString() + "", "" + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[insurance] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'").ToString() + "", "" + (db.sum("SELECT sum(litres)FROM [AVVMS].[dbo].[oil] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[oil] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(litres)FROM [AVVMS].[dbo].[refill bill] where [vehicle]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[refill bill] where [vehicle]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[maintanance] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[tax] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'") + db.sum("SELECT sum(amount)FROM [AVVMS].[dbo].[insurance] where [vehicle no.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'")).ToString() + "", "" + db.sum("SELECT sum(km)FROM [AVVMS].[dbo].[Trips] where [Vehicle No.]='" + dt.Rows[i]["Vehicle No."].ToString() + "'").ToString() + "", "N/A");
                }



              
            }
        }
    }
}
