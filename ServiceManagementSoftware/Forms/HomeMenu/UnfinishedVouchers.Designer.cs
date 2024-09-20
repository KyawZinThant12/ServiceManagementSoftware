namespace ServiceManagementSoftware.Forms.HomeMenu
{
    partial class UnfinishedVouchers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVoucher = new System.Windows.Forms.DataGridView();
            this.colVno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGtol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.formTitle1 = new ServiceManagementSoftware.Components.FormTitle();
            this.tblToolBar = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtpVdate = new System.Windows.Forms.DateTimePicker();
            this.tblLayot_totals = new System.Windows.Forms.TableLayoutPanel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblReceived = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblNetAmt = new System.Windows.Forms.Label();
            this.lblAllTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).BeginInit();
            this.tblMain.SuspendLayout();
            this.tblToolBar.SuspendLayout();
            this.tblLayot_totals.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVoucher
            // 
            this.dgvVoucher.AllowUserToAddRows = false;
            this.dgvVoucher.AllowUserToDeleteRows = false;
            this.dgvVoucher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVoucher.BackgroundColor = System.Drawing.Color.White;
            this.dgvVoucher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVoucher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVoucher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVoucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVoucher.ColumnHeadersHeight = 30;
            this.dgvVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVno,
            this.colDate,
            this.colCustomer,
            this.colGtol,
            this.colDiscount,
            this.colNetAmt,
            this.colRamo,
            this.colBalance});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(166)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVoucher.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvVoucher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVoucher.EnableHeadersVisualStyles = false;
            this.dgvVoucher.Location = new System.Drawing.Point(13, 81);
            this.dgvVoucher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvVoucher.Name = "dgvVoucher";
            this.dgvVoucher.ReadOnly = true;
            this.dgvVoucher.RowHeadersVisible = false;
            this.dgvVoucher.RowTemplate.Height = 30;
            this.dgvVoucher.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVoucher.Size = new System.Drawing.Size(949, 354);
            this.dgvVoucher.TabIndex = 2;
            this.dgvVoucher.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoucher_CellDoubleClick);
            // 
            // colVno
            // 
            this.colVno.DataPropertyName = "vNo";
            this.colVno.HeaderText = "Voucher No.";
            this.colVno.Name = "colVno";
            this.colVno.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "vDate";
            dataGridViewCellStyle2.Format = "d/M/yyyy h:mm tt";
            this.colDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colCustomer
            // 
            this.colCustomer.DataPropertyName = "customerName";
            dataGridViewCellStyle3.NullValue = "-";
            this.colCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            // 
            // colGtol
            // 
            this.colGtol.DataPropertyName = "vTol";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.colGtol.DefaultCellStyle = dataGridViewCellStyle4;
            this.colGtol.HeaderText = "Total Amount";
            this.colGtol.Name = "colGtol";
            this.colGtol.ReadOnly = true;
            // 
            // colDiscount
            // 
            this.colDiscount.DataPropertyName = "disAmt";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.colDiscount.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            // 
            // colNetAmt
            // 
            this.colNetAmt.DataPropertyName = "netAmt";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.colNetAmt.DefaultCellStyle = dataGridViewCellStyle6;
            this.colNetAmt.HeaderText = "Net Amount";
            this.colNetAmt.Name = "colNetAmt";
            this.colNetAmt.ReadOnly = true;
            // 
            // colRamo
            // 
            this.colRamo.DataPropertyName = "recAmt";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            this.colRamo.DefaultCellStyle = dataGridViewCellStyle7;
            this.colRamo.HeaderText = "Received Amount";
            this.colRamo.Name = "colRamo";
            this.colRamo.ReadOnly = true;
            // 
            // colBalance
            // 
            this.colBalance.DataPropertyName = "vBal";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            this.colBalance.DefaultCellStyle = dataGridViewCellStyle8;
            this.colBalance.HeaderText = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.ReadOnly = true;
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.Controls.Add(this.formTitle1, 1, 1);
            this.tblMain.Controls.Add(this.tblToolBar, 1, 2);
            this.tblMain.Controls.Add(this.dgvVoucher, 1, 3);
            this.tblMain.Controls.Add(this.tblLayot_totals, 1, 4);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 6;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblMain.Size = new System.Drawing.Size(975, 474);
            this.tblMain.TabIndex = 3;
            // 
            // formTitle1
            // 
            this.formTitle1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formTitle1.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle1.Location = new System.Drawing.Point(397, 5);
            this.formTitle1.Margin = new System.Windows.Forms.Padding(0);
            this.formTitle1.Name = "formTitle1";
            this.formTitle1.Size = new System.Drawing.Size(180, 26);
            this.formTitle1.TabIndex = 3;
            this.formTitle1.Title = "Pending Vouchers";
            // 
            // tblToolBar
            // 
            this.tblToolBar.ColumnCount = 3;
            this.tblToolBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblToolBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tblToolBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 286F));
            this.tblToolBar.Controls.Add(this.btnBack, 0, 0);
            this.tblToolBar.Controls.Add(this.txtSearch, 2, 0);
            this.tblToolBar.Controls.Add(this.dtpVdate, 1, 0);
            this.tblToolBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblToolBar.Location = new System.Drawing.Point(10, 31);
            this.tblToolBar.Margin = new System.Windows.Forms.Padding(0);
            this.tblToolBar.Name = "tblToolBar";
            this.tblToolBar.RowCount = 1;
            this.tblToolBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblToolBar.Size = new System.Drawing.Size(955, 46);
            this.tblToolBar.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = global::ServiceManagementSoftware.Properties.Settings.Default.ButtonBackColor2;
            this.btnBack.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ServiceManagementSoftware.Properties.Settings.Default, "ButtonBackColor2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::ServiceManagementSoftware.Properties.Resources.arrow_left;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(672, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 32);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dtpVdate
            // 
            this.dtpVdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpVdate.Checked = false;
            this.dtpVdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVdate.Location = new System.Drawing.Point(535, 7);
            this.dtpVdate.Name = "dtpVdate";
            this.dtpVdate.ShowCheckBox = true;
            this.dtpVdate.Size = new System.Drawing.Size(131, 32);
            this.dtpVdate.TabIndex = 6;
            this.dtpVdate.ValueChanged += new System.EventHandler(this.dtpVdate_ValueChanged);
            // 
            // tblLayot_totals
            // 
            this.tblLayot_totals.ColumnCount = 7;
            this.tblLayot_totals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayot_totals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tblLayot_totals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayot_totals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tblLayot_totals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tblLayot_totals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tblLayot_totals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tblLayot_totals.Controls.Add(this.lblBalance, 6, 0);
            this.tblLayot_totals.Controls.Add(this.lblReceived, 5, 0);
            this.tblLayot_totals.Controls.Add(this.lblDiscount, 3, 0);
            this.tblLayot_totals.Controls.Add(this.lblNetAmt, 4, 0);
            this.tblLayot_totals.Controls.Add(this.lblAllTotal, 0, 0);
            this.tblLayot_totals.Controls.Add(this.lblTotal, 1, 0);
            this.tblLayot_totals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayot_totals.Location = new System.Drawing.Point(13, 442);
            this.tblLayot_totals.Name = "tblLayot_totals";
            this.tblLayot_totals.RowCount = 1;
            this.tblLayot_totals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayot_totals.Size = new System.Drawing.Size(949, 24);
            this.tblLayot_totals.TabIndex = 9;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(886, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(60, 24);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "100000";
            // 
            // lblReceived
            // 
            this.lblReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReceived.AutoSize = true;
            this.lblReceived.Location = new System.Drawing.Point(780, 0);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(52, 24);
            this.lblReceived.TabIndex = 4;
            this.lblReceived.Text = "10000";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(550, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(60, 24);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "100000";
            // 
            // lblNetAmt
            // 
            this.lblNetAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNetAmt.AutoSize = true;
            this.lblNetAmt.Location = new System.Drawing.Point(661, 0);
            this.lblNetAmt.Name = "lblNetAmt";
            this.lblNetAmt.Size = new System.Drawing.Size(60, 24);
            this.lblNetAmt.TabIndex = 3;
            this.lblNetAmt.Text = "100000";
            // 
            // lblAllTotal
            // 
            this.lblAllTotal.AutoSize = true;
            this.lblAllTotal.Location = new System.Drawing.Point(3, 0);
            this.lblAllTotal.Name = "lblAllTotal";
            this.lblAllTotal.Size = new System.Drawing.Size(67, 24);
            this.lblAllTotal.TabIndex = 0;
            this.lblAllTotal.Text = "Totals ::";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(412, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 24);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "100000";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnfinishedVouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(975, 474);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "UnfinishedVouchers";
            this.Text = "FinishVoucher";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).EndInit();
            this.tblMain.ResumeLayout(false);
            this.tblToolBar.ResumeLayout(false);
            this.tblToolBar.PerformLayout();
            this.tblLayot_totals.ResumeLayout(false);
            this.tblLayot_totals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVoucher;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private Components.FormTitle formTitle1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tblToolBar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpVdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGtol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;
        private System.Windows.Forms.TableLayoutPanel tblLayot_totals;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblNetAmt;
        private System.Windows.Forms.Label lblAllTotal;
    }
}