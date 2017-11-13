using System;
using System.Windows.Forms;


namespace Aryavidyashala_Vehicle_Management_System
{
    public partial class Print_Hair_Over : Form
    {
        public Print_Hair_Over()
        {
            InitializeComponent();
            
        }

        private void Print_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Hair_dataset.hair' table. You can move, or remove it, as needed.
            this.hairTableAdapter.Fill(this.Hair_dataset.hair);
            // TODO: This line of code loads data into the 'Hair_dataset.overhead_expenses' table. You can move, or remove it, as needed.
            this.overhead_expensesTableAdapter.Fill(this.Hair_dataset.overhead_expenses);

            this.reportViewer1.RefreshReport();
        }
    }
}
