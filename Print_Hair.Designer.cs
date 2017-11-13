namespace Aryavidyashala_Vehicle_Management_System
{
    partial class Print_Hair
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.hairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Hair_dataset = new Aryavidyashala_Vehicle_Management_System.Hair_dataset();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hairTableAdapter = new Aryavidyashala_Vehicle_Management_System.Hair_datasetTableAdapters.hairTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hairBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hair_dataset)).BeginInit();
            this.SuspendLayout();
            // 
            // hairBindingSource
            // 
            this.hairBindingSource.DataMember = "hair";
            this.hairBindingSource.DataSource = this.Hair_dataset;
            // 
            // Hair_dataset
            // 
            this.Hair_dataset.DataSetName = "Hair_dataset";
            this.Hair_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Hair_dset";
            reportDataSource1.Value = this.hairBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Aryavidyashala_Vehicle_Management_System.Hair_Report_wover.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(512, 581);
            this.reportViewer1.TabIndex = 0;
            // 
            // hairTableAdapter
            // 
            this.hairTableAdapter.ClearBeforeFill = true;
            // 
            // Print_Hair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 581);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Print_Hair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print_Hair";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Print_Hair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hairBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hair_dataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource hairBindingSource;
        private Hair_dataset Hair_dataset;
        private Hair_datasetTableAdapters.hairTableAdapter hairTableAdapter;
    }
}