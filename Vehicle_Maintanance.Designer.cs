namespace Aryavidyashala_Vehicle_Management_System
{
    partial class Vehicle_Maintanance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicle_Maintanance));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.PnlSearch.SuspendLayout();
            this.xPander2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tax Ledger";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(575, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Workshop Maintanence Ledger";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Insurance Ledger";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.PnlSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 741);
            this.panel1.TabIndex = 3;
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
            this.PnlSearch.Location = new System.Drawing.Point(840, 372);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.PnlSearch.PaneBottomRightColor = System.Drawing.Color.Transparent;
            this.PnlSearch.PaneOutlineColor = System.Drawing.Color.Black;
            this.PnlSearch.PaneTopLeftColor = System.Drawing.Color.Transparent;
            this.PnlSearch.Size = new System.Drawing.Size(168, 308);
            this.PnlSearch.TabIndex = 32;
            this.PnlSearch.TooltipText = null;
            this.PnlSearch.Visible = false;
            // 
            // TxtSearch
            // 
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.Location = new System.Drawing.Point(7, 265);
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
            "Last Refill Date"});
            this.CmbSearchType.Location = new System.Drawing.Point(9, 60);
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
            this.xPander2.Location = new System.Drawing.Point(6, 103);
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
            this.lblSearchKey.Location = new System.Drawing.Point(8, 241);
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
            this.label13.Location = new System.Drawing.Point(11, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Search Type";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(840, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 226);
            this.panel2.TabIndex = 77;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(11, 180);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 36);
            this.button7.TabIndex = 29;
            this.button7.Text = "Oil Change Receipt Input";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(8, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(155, 36);
            this.button8.TabIndex = 28;
            this.button8.Text = "Total Maintanance Cost";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(9, 67);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(155, 36);
            this.button9.TabIndex = 27;
            this.button9.Text = "Maintanance Reciept Input";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(11, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 36);
            this.button6.TabIndex = 30;
            this.button6.Text = "Oil Change Receipts";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(851, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 37);
            this.button5.TabIndex = 76;
            this.button5.Text = "Tax Reciept Input";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.dataGridView6);
            this.groupBox6.Location = new System.Drawing.Point(3, 65);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(830, 616);
            this.groupBox6.TabIndex = 75;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tax Receipts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(748, 587);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Total : 2000";
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
            this.dataGridView6.Size = new System.Drawing.Size(792, 537);
            this.dataGridView6.TabIndex = 68;
            // 
            // Vehicle_Maintanance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 740);
            this.Controls.Add(this.panel1);
            this.Name = "Vehicle_Maintanance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle_Maintanance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            this.xPander2.ResumeLayout(false);
            this.xPander2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel2;
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
    }
}