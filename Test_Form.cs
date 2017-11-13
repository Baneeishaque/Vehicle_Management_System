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
    public partial class Test_Form : Form
    {
        
      
        DBhandler db=new DBhandler();
        NumericUpDown a;
        
        private void a_OnValueChange(object sender, EventArgs e)
        {
            MessageBox.Show(a.Value.ToString());
        }
        
      
        public Test_Form()
        {
            InitializeComponent();

            //oDateTimePicker.TextChanged += new EventHandler(dateTimePicker_OnTextChange);
            a = new System.Windows.Forms.NumericUpDown();
            this.Controls.Add(a);
            a.Minimum = Convert.ToInt32("10") + 1;
            a.ValueChanged += new EventHandler(a_OnValueChange);
            
            System.Windows.Forms.Control[] c=new Control[2];
            c[0] = label1;
            c[1] = label9;
            Common_Tasks.disableg(c);

            String fields="[Id] as [Sl. No.],[Vehicle] as [Vehicle No.],[Reason] ,[Remarks]";
            string table="[AVVMS].[dbo].[Vehicle_Notifications]";
            //DGV_Vehicle.DataSource = db.GetTable(Search_Handler.query_builder_search(fields,table));

            String searchkey = "v2";
            String search_field = "[Vehicle]";
            //DGV_Vehicle.DataSource = db.GetTable(Search_Handler.query_builder_search_feild_start(fields, table, search_field, searchkey));

            //DGV_Vehicle.DataSource = db.GetTable(Search_Handler.query_builder_search_feild_end(fields, table, search_field, searchkey));

            //DGV_Vehicle.DataSource = db.GetTable(Search_Handler.query_builder_search_feild_contains(fields, table, search_field, searchkey));

            //DGV_Vehicle.DataSource = db.GetTable(Search_Handler.query_builder_search_feild_notcontains(fields, table, search_field, searchkey));

            DGV_Vehicle.DataSource = db.GetTable(Search_Handler.query_builder_search_feild(fields, table, search_field, searchkey));

            Control[] cx = new Control[2] { label1, label9 };
            Common_Tasks.disableg(cx);
           
        }

        

       

    }
}
