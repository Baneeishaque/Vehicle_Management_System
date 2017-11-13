namespace Aryavidyashala_Vehicle_Management_System
{
    partial class Employee_Manipulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Manipulation));
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lb_moment = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_sc = new System.Windows.Forms.Label();
            this.lb_fc = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.PnlSearch.SuspendLayout();
            this.xPander2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(855, 143);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 53);
            this.button5.TabIndex = 21;
            this.button5.Text = "Batha Report";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(855, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 53);
            this.button2.TabIndex = 18;
            this.button2.Text = "Employee Addition";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(855, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 56);
            this.button1.TabIndex = 22;
            this.button1.Text = "Lisence Renew";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.PnlSearch);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 744);
            this.panel1.TabIndex = 23;
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
            this.PnlSearch.Size = new System.Drawing.Size(168, 331);
            this.PnlSearch.TabIndex = 71;
            this.PnlSearch.TooltipText = null;
            this.PnlSearch.Visible = false;
            // 
            // TxtSearch
            // 
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.Location = new System.Drawing.Point(7, 290);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(154, 24);
            this.TxtSearch.TabIndex = 2;
            // 
            // CmbSearchType
            // 
            this.CmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSearchType.ForeColor = System.Drawing.Color.Navy;
            this.CmbSearchType.FormattingEnabled = true;
            this.CmbSearchType.Items.AddRange(new object[] {
            "Vehicle No.",
            "Journey",
            "Purpose",
            "Provider",
            "Date"});
            this.CmbSearchType.Location = new System.Drawing.Point(6, 56);
            this.CmbSearchType.Name = "CmbSearchType";
            this.CmbSearchType.Size = new System.Drawing.Size(153, 25);
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
            this.xPander2.Size = new System.Drawing.Size(156, 127);
            this.xPander2.TabIndex = 1;
            this.xPander2.TooltipText = null;
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
            // 
            // lblSearchKey
            // 
            this.lblSearchKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchKey.AutoSize = true;
            this.lblSearchKey.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchKey.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchKey.ForeColor = System.Drawing.Color.Black;
            this.lblSearchKey.Location = new System.Drawing.Point(8, 266);
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
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Controls.Add(this.dataGridView6);
            this.groupBox6.Location = new System.Drawing.Point(3, 65);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(830, 616);
            this.groupBox6.TabIndex = 72;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Employees";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.lb_moment);
            this.groupBox1.Controls.Add(this.lb_address);
            this.groupBox1.Controls.Add(this.lb_sc);
            this.groupBox1.Controls.Add(this.lb_fc);
            this.groupBox1.Location = new System.Drawing.Point(19, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 185);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(695, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Report";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(695, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(695, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // lb_moment
            // 
            this.lb_moment.AutoSize = true;
            this.lb_moment.Location = new System.Drawing.Point(340, 110);
            this.lb_moment.Name = "lb_moment";
            this.lb_moment.Size = new System.Drawing.Size(45, 13);
            this.lb_moment.TabIndex = 3;
            this.lb_moment.Text = "Address";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Location = new System.Drawing.Point(340, 68);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(44, 13);
            this.lb_address.TabIndex = 2;
            this.lb_address.Text = "Lisence";
            // 
            // lb_sc
            // 
            this.lb_sc.AutoSize = true;
            this.lb_sc.Location = new System.Drawing.Point(39, 110);
            this.lb_sc.Name = "lb_sc";
            this.lb_sc.Size = new System.Drawing.Size(101, 13);
            this.lb_sc.TabIndex = 1;
            this.lb_sc.Text = "Lisence Expiry Date";
            // 
            // lb_fc
            // 
            this.lb_fc.AutoSize = true;
            this.lb_fc.Location = new System.Drawing.Point(39, 68);
            this.lb_fc.Name = "lb_fc";
            this.lb_fc.Size = new System.Drawing.Size(32, 13);
            this.lb_fc.TabIndex = 0;
            this.lb_fc.Text = "Email";
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
            this.dataGridView6.Size = new System.Drawing.Size(792, 339);
            this.dataGridView6.TabIndex = 68;
            this.dataGridView6.Click += new System.EventHandler(this.dataGridView6_Click);
            // 
            // Employee_Manipulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 740);
            this.Controls.Add(this.panel1);
            this.Name = "Employee_Manipulation";
            this.Text = "Employee_Manipulation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            this.xPander2.ResumeLayout(false);
            this.xPander2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lb_moment;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_sc;
        private System.Windows.Forms.Label lb_fc;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
    }
}