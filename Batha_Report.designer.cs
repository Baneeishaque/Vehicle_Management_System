﻿namespace Aryavidyashala_Vehicle_Management_System
{
    partial class Batha_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Batha_Report));
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PnlSearch = new XPanderControl.XPander();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.CmbSearchType = new System.Windows.Forms.ComboBox();
            this.xPander2 = new XPanderControl.XPander();
            this.RdbEndsWithH = new System.Windows.Forms.RadioButton();
            this.RdbDoesNotContains = new System.Windows.Forms.RadioButton();
            this.RdbStartsWith = new System.Windows.Forms.RadioButton();
            this.RdbContains = new System.Windows.Forms.RadioButton();
            this.lblSearchKey = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlSearch.SuspendLayout();
            this.xPander2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total : 2000";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMMM yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(847, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.UseWaitCursor = true;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // PnlSearch
            // 
            this.PnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.PnlSearch.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.PnlSearch.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.PnlSearch.CaptionFormatFlag = XPanderControl.XPander.FormatFlag.NoWrap;
            this.PnlSearch.CaptionRightColor = System.Drawing.Color.Gray;
            this.PnlSearch.CaptionStyle = XPanderControl.XPander.CaptionStyleEnum.Normal;
            this.PnlSearch.CaptionText = "Search";
            this.PnlSearch.CaptionTextAlign = XPanderControl.XPander.CaptionTextAlignment.Middle;
            this.PnlSearch.CaptionTextColor = System.Drawing.Color.Black;
            this.PnlSearch.CaptionTextHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PnlSearch.ChevronStyle = XPanderControl.XPander.ChevronStyleEnum.Image;
            this.PnlSearch.CollapsedHighlightImage = ((System.Drawing.Bitmap)(resources.GetObject("PnlSearch.CollapsedHighlightImage")));
            this.PnlSearch.CollapsedImage = ((System.Drawing.Bitmap)(resources.GetObject("PnlSearch.CollapsedImage")));
            this.PnlSearch.Controls.Add(this.TxtSearch);
            this.PnlSearch.Controls.Add(this.CmbSearchType);
            this.PnlSearch.Controls.Add(this.xPander2);
            this.PnlSearch.Controls.Add(this.lblSearchKey);
            this.PnlSearch.Controls.Add(this.label13);
            this.PnlSearch.ExpandedHighlightImage = ((System.Drawing.Bitmap)(resources.GetObject("PnlSearch.ExpandedHighlightImage")));
            this.PnlSearch.ExpandedImage = ((System.Drawing.Bitmap)(resources.GetObject("PnlSearch.ExpandedImage")));
            this.PnlSearch.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlSearch.Location = new System.Drawing.Point(843, 318);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.PnlSearch.PaneBottomRightColor = System.Drawing.Color.Transparent;
            this.PnlSearch.PaneOutlineColor = System.Drawing.Color.Black;
            this.PnlSearch.PaneTopLeftColor = System.Drawing.Color.Transparent;
            this.PnlSearch.Size = new System.Drawing.Size(161, 344);
            this.PnlSearch.TabIndex = 75;
            this.PnlSearch.TooltipText = null;
            // 
            // TxtSearch
            // 
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.Location = new System.Drawing.Point(9, 290);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(144, 24);
            this.TxtSearch.TabIndex = 2;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // CmbSearchType
            // 
            this.CmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSearchType.ForeColor = System.Drawing.Color.Navy;
            this.CmbSearchType.FormattingEnabled = true;
            this.CmbSearchType.Items.AddRange(new object[] {
            "Employee ID",
            "Trip No.",
            "Date",
            "Batha",
            "Batha Amount"});
            this.CmbSearchType.Location = new System.Drawing.Point(6, 56);
            this.CmbSearchType.Name = "CmbSearchType";
            this.CmbSearchType.Size = new System.Drawing.Size(147, 25);
            this.CmbSearchType.TabIndex = 0;
            // 
            // xPander2
            // 
            this.xPander2.Animated = true;
            this.xPander2.AnimationTime = 50;
            this.xPander2.BackColor = System.Drawing.Color.Transparent;
            this.xPander2.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.xPander2.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.xPander2.CaptionFormatFlag = XPanderControl.XPander.FormatFlag.NoWrap;
            this.xPander2.CaptionLeftColor = System.Drawing.Color.Transparent;
            this.xPander2.CaptionRightColor = System.Drawing.Color.Gray;
            this.xPander2.CaptionStyle = XPanderControl.XPander.CaptionStyleEnum.Normal;
            this.xPander2.CaptionText = "Advanced Search";
            this.xPander2.CaptionTextAlign = XPanderControl.XPander.CaptionTextAlignment.Left;
            this.xPander2.CaptionTextColor = System.Drawing.Color.Black;
            this.xPander2.CaptionTextHighlightColor = System.Drawing.Color.Navy;
            this.xPander2.ChevronStyle = XPanderControl.XPander.ChevronStyleEnum.Image;
            this.xPander2.CollapsedHighlightImage = ((System.Drawing.Bitmap)(resources.GetObject("xPander2.CollapsedHighlightImage")));
            this.xPander2.CollapsedImage = ((System.Drawing.Bitmap)(resources.GetObject("xPander2.CollapsedImage")));
            this.xPander2.Controls.Add(this.RdbEndsWithH);
            this.xPander2.Controls.Add(this.RdbDoesNotContains);
            this.xPander2.Controls.Add(this.RdbStartsWith);
            this.xPander2.Controls.Add(this.RdbContains);
            this.xPander2.ExpandedHighlightImage = ((System.Drawing.Bitmap)(resources.GetObject("xPander2.ExpandedHighlightImage")));
            this.xPander2.ExpandedImage = ((System.Drawing.Bitmap)(resources.GetObject("xPander2.ExpandedImage")));
            this.xPander2.ForeColor = System.Drawing.Color.Black;
            this.xPander2.Location = new System.Drawing.Point(6, 110);
            this.xPander2.Name = "xPander2";
            this.xPander2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.xPander2.PaneBottomRightColor = System.Drawing.Color.Transparent;
            this.xPander2.PaneOutlineColor = System.Drawing.Color.Black;
            this.xPander2.PaneTopLeftColor = System.Drawing.Color.Transparent;
            this.xPander2.Size = new System.Drawing.Size(147, 127);
            this.xPander2.TabIndex = 1;
            this.xPander2.TooltipText = null;
            this.xPander2.XPanderCollapsed += new XPanderControl.XPander.XPanderCollapsedHandler(this.xPander2_XPanderCollapsed);
            this.xPander2.XPanderExpanded += new XPanderControl.XPander.XPanderExpandedHandler(this.xPander2_XPanderExpanded);
            this.xPander2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.xPander2_MouseClick);
            // 
            // RdbEndsWithH
            // 
            this.RdbEndsWithH.AutoSize = true;
            this.RdbEndsWithH.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbEndsWithH.ForeColor = System.Drawing.Color.Black;
            this.RdbEndsWithH.Location = new System.Drawing.Point(10, 55);
            this.RdbEndsWithH.Name = "RdbEndsWithH";
            this.RdbEndsWithH.Size = new System.Drawing.Size(86, 19);
            this.RdbEndsWithH.TabIndex = 4;
            this.RdbEndsWithH.Text = "Ends With";
            this.RdbEndsWithH.UseVisualStyleBackColor = true;
            this.RdbEndsWithH.CheckedChanged += new System.EventHandler(this.RdbStartsWith_CheckedChanged);
            // 
            // RdbDoesNotContains
            // 
            this.RdbDoesNotContains.AutoSize = true;
            this.RdbDoesNotContains.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbDoesNotContains.ForeColor = System.Drawing.Color.Black;
            this.RdbDoesNotContains.Location = new System.Drawing.Point(10, 104);
            this.RdbDoesNotContains.Name = "RdbDoesNotContains";
            this.RdbDoesNotContains.Size = new System.Drawing.Size(135, 19);
            this.RdbDoesNotContains.TabIndex = 3;
            this.RdbDoesNotContains.Text = "Does Not Contain";
            this.RdbDoesNotContains.UseVisualStyleBackColor = true;
            this.RdbDoesNotContains.CheckedChanged += new System.EventHandler(this.RdbStartsWith_CheckedChanged);
            // 
            // RdbStartsWith
            // 
            this.RdbStartsWith.AutoSize = true;
            this.RdbStartsWith.Checked = true;
            this.RdbStartsWith.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbStartsWith.ForeColor = System.Drawing.Color.Black;
            this.RdbStartsWith.Location = new System.Drawing.Point(10, 28);
            this.RdbStartsWith.Name = "RdbStartsWith";
            this.RdbStartsWith.Size = new System.Drawing.Size(93, 19);
            this.RdbStartsWith.TabIndex = 0;
            this.RdbStartsWith.TabStop = true;
            this.RdbStartsWith.Text = "Starts With";
            this.RdbStartsWith.UseVisualStyleBackColor = true;
            this.RdbStartsWith.CheckedChanged += new System.EventHandler(this.RdbStartsWith_CheckedChanged);
            // 
            // RdbContains
            // 
            this.RdbContains.AutoSize = true;
            this.RdbContains.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbContains.ForeColor = System.Drawing.Color.Black;
            this.RdbContains.Location = new System.Drawing.Point(10, 79);
            this.RdbContains.Name = "RdbContains";
            this.RdbContains.Size = new System.Drawing.Size(81, 19);
            this.RdbContains.TabIndex = 2;
            this.RdbContains.Text = "Contains";
            this.RdbContains.UseVisualStyleBackColor = true;
            this.RdbContains.CheckedChanged += new System.EventHandler(this.RdbStartsWith_CheckedChanged);
            // 
            // lblSearchKey
            // 
            this.lblSearchKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchKey.AutoSize = true;
            this.lblSearchKey.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchKey.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchKey.ForeColor = System.Drawing.Color.Black;
            this.lblSearchKey.Location = new System.Drawing.Point(1, 266);
            this.lblSearchKey.Name = "lblSearchKey";
            this.lblSearchKey.Size = new System.Drawing.Size(75, 15);
            this.lblSearchKey.TabIndex = 25;
            this.lblSearchKey.Text = "Search Key";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(8, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Search Type";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.dataGridView6);
            this.groupBox6.Location = new System.Drawing.Point(3, 65);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(823, 619);
            this.groupBox6.TabIndex = 76;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Batha Details";
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(19, 37);
            this.dataGridView6.MultiSelect = false;
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.RowHeadersVisible = false;
            this.dataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView6.Size = new System.Drawing.Size(792, 530);
            this.dataGridView6.TabIndex = 68;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(842, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 152);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "All";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "       All       ";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.PnlSearch);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 742);
            this.panel1.TabIndex = 78;
            // 
            // Batha_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 740);
            this.Controls.Add(this.panel1);
            this.Name = "Batha_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batha_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            this.xPander2.ResumeLayout(false);
            this.xPander2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private XPanderControl.XPander PnlSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.ComboBox CmbSearchType;
        private XPanderControl.XPander xPander2;
        private System.Windows.Forms.RadioButton RdbEndsWithH;
        private System.Windows.Forms.RadioButton RdbDoesNotContains;
        private System.Windows.Forms.RadioButton RdbStartsWith;
        private System.Windows.Forms.RadioButton RdbContains;
        private System.Windows.Forms.Label lblSearchKey;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}