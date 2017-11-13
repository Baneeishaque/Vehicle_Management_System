namespace Aryavidyashala_Vehicle_Management_System
{
    partial class Trips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trips));
            this.DGV_Today_Trips = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlSearch = new XPanderControl.XPander();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.CmbSearchType = new System.Windows.Forms.ComboBox();
            this.xPander2 = new XPanderControl.XPander();
            this.RdbEndsWithH = new System.Windows.Forms.RadioButton();
            this.RdbDoesNotContains = new System.Windows.Forms.RadioButton();
            this.RdbStartsWith = new System.Windows.Forms.RadioButton();
            this.RdbContains = new System.Windows.Forms.RadioButton();
            this.lblSearchKey = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Today_Trips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.PnlSearch.SuspendLayout();
            this.xPander2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Today_Trips
            // 
            this.DGV_Today_Trips.AllowUserToAddRows = false;
            this.DGV_Today_Trips.AllowUserToDeleteRows = false;
            this.DGV_Today_Trips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Today_Trips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Today_Trips.Location = new System.Drawing.Point(61, 96);
            this.DGV_Today_Trips.Name = "DGV_Today_Trips";
            this.DGV_Today_Trips.ReadOnly = true;
            this.DGV_Today_Trips.RowHeadersVisible = false;
            this.DGV_Today_Trips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Today_Trips.Size = new System.Drawing.Size(706, 149);
            this.DGV_Today_Trips.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Today Trips";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(61, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(706, 260);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sl. No.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Vehicle No.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Journey";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Purpose";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Provider";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Remarks";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Coming Trips";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.PnlSearch);
            this.panel1.Controls.Add(this.DGV_Today_Trips);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 744);
            this.panel1.TabIndex = 9;
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
            this.PnlSearch.Controls.Add(this.comboBox1);
            this.PnlSearch.Controls.Add(this.label2);
            this.PnlSearch.Controls.Add(this.TxtSearch);
            this.PnlSearch.Controls.Add(this.CmbSearchType);
            this.PnlSearch.Controls.Add(this.xPander2);
            this.PnlSearch.Controls.Add(this.lblSearchKey);
            this.PnlSearch.Controls.Add(this.label13);
            this.PnlSearch.ExpandedHighlightImage = ((System.Drawing.Bitmap)(resources.GetObject("PnlSearch.ExpandedHighlightImage")));
            this.PnlSearch.ExpandedImage = ((System.Drawing.Bitmap)(resources.GetObject("PnlSearch.ExpandedImage")));
            this.PnlSearch.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlSearch.Location = new System.Drawing.Point(791, 96);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.PnlSearch.PaneBottomRightColor = System.Drawing.Color.Transparent;
            this.PnlSearch.PaneOutlineColor = System.Drawing.Color.Black;
            this.PnlSearch.PaneTopLeftColor = System.Drawing.Color.Transparent;
            this.PnlSearch.Size = new System.Drawing.Size(168, 503);
            this.PnlSearch.TabIndex = 25;
            this.PnlSearch.TooltipText = null;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Navy;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Today Trips",
            "Coming Trips"});
            this.comboBox1.Location = new System.Drawing.Point(9, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 25);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Search Validity";
            // 
            // TxtSearch
            // 
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.Location = new System.Drawing.Point(7, 374);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(154, 24);
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
            "Vehicle No.",
            "Journey",
            "Purpose",
            "Provider",
            "Remarks"});
            this.CmbSearchType.Location = new System.Drawing.Point(9, 142);
            this.CmbSearchType.Name = "CmbSearchType";
            this.CmbSearchType.Size = new System.Drawing.Size(153, 25);
            this.CmbSearchType.TabIndex = 0;
            this.CmbSearchType.SelectedIndexChanged += new System.EventHandler(this.CmbSearchType_SelectedIndexChanged);
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
            this.xPander2.Location = new System.Drawing.Point(6, 196);
            this.xPander2.Name = "xPander2";
            this.xPander2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.xPander2.PaneBottomRightColor = System.Drawing.Color.Transparent;
            this.xPander2.PaneOutlineColor = System.Drawing.Color.Black;
            this.xPander2.PaneTopLeftColor = System.Drawing.Color.Transparent;
            this.xPander2.Size = new System.Drawing.Size(156, 127);
            this.xPander2.TabIndex = 1;
            this.xPander2.TooltipText = null;
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
            this.lblSearchKey.Location = new System.Drawing.Point(8, 350);
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
            this.label13.Location = new System.Drawing.Point(11, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Search Type";
            // 
            // Trips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 740);
            this.Controls.Add(this.panel1);
            this.Name = "Trips";
            this.Text = "Trips";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Today_Trips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            this.xPander2.ResumeLayout(false);
            this.xPander2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Today_Trips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}