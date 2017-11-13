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
    public partial class Print_Hair : Form
    {
        public Print_Hair()
        {
            InitializeComponent();
            
        }

        private void Print_Hair_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Hair_dataset.hair' table. You can move, or remove it, as needed.
            this.hairTableAdapter.Fill(this.Hair_dataset.hair);

            this.reportViewer1.RefreshReport();
        }
    }
}
