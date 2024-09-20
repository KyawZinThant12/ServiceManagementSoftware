namespace ServiceManagementSoftware.Forms.SetupMenu
{
    partial class CustomerEntry
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
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblCPhone = new System.Windows.Forms.Label();
            this.lblCAddress = new System.Windows.Forms.Label();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.txtCAddress = new System.Windows.Forms.TextBox();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.chk_CInactive = new System.Windows.Forms.CheckBox();
            this.lblCEmail = new System.Windows.Forms.Label();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            this.lblCRemark = new System.Windows.Forms.Label();
            this.txtCRemark = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.ctrControl = new ServiceManagementSoftware.Components.ControlBox();
            this.tblMain.SuspendLayout();
            this.tblButton.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustName
            // 
            this.txtCustName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustName.Location = new System.Drawing.Point(13, 37);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(472, 32);
            this.txtCustName.TabIndex = 0;
            // 
            // lblCName
            // 
            this.lblCName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(13, 10);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(119, 24);
            this.lblCName.TabIndex = 7;
            this.lblCName.Text = "Customer Name";
            // 
            // lblCPhone
            // 
            this.lblCPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCPhone.AutoSize = true;
            this.lblCPhone.Location = new System.Drawing.Point(13, 79);
            this.lblCPhone.Name = "lblCPhone";
            this.lblCPhone.Size = new System.Drawing.Size(109, 24);
            this.lblCPhone.TabIndex = 7;
            this.lblCPhone.Text = "Phone Number";
            // 
            // lblCAddress
            // 
            this.lblCAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCAddress.AutoSize = true;
            this.lblCAddress.Location = new System.Drawing.Point(13, 148);
            this.lblCAddress.Name = "lblCAddress";
            this.lblCAddress.Size = new System.Drawing.Size(64, 24);
            this.lblCAddress.TabIndex = 7;
            this.lblCAddress.Text = "Address";
            // 
            // txtCPhone
            // 
            this.txtCPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPhone.Location = new System.Drawing.Point(13, 106);
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Size = new System.Drawing.Size(472, 32);
            this.txtCPhone.TabIndex = 1;
            // 
            // txtCAddress
            // 
            this.txtCAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCAddress.Location = new System.Drawing.Point(13, 175);
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.Size = new System.Drawing.Size(472, 32);
            this.txtCAddress.TabIndex = 2;
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.Controls.Add(this.tblButton, 1, 11);
            this.tblMain.Controls.Add(this.txtCustName, 1, 2);
            this.tblMain.Controls.Add(this.lblCPhone, 1, 3);
            this.tblMain.Controls.Add(this.txtCPhone, 1, 4);
            this.tblMain.Controls.Add(this.txtCAddress, 1, 6);
            this.tblMain.Controls.Add(this.lblCAddress, 1, 5);
            this.tblMain.Controls.Add(this.lblCName, 1, 1);
            this.tblMain.Controls.Add(this.lblCEmail, 1, 7);
            this.tblMain.Controls.Add(this.txtCEmail, 1, 8);
            this.tblMain.Controls.Add(this.lblCRemark, 1, 9);
            this.tblMain.Controls.Add(this.txtCRemark, 1, 10);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 30);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 13;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.Size = new System.Drawing.Size(498, 415);
            this.tblMain.TabIndex = 9;
            // 
            // tblButton
            // 
            this.tblButton.ColumnCount = 4;
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tblButton.Controls.Add(this.btnCancel, 3, 0);
            this.tblButton.Controls.Add(this.btnAddCustomer, 2, 0);
            this.tblButton.Controls.Add(this.chk_CInactive, 1, 0);
            this.tblButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButton.Location = new System.Drawing.Point(10, 355);
            this.tblButton.Margin = new System.Windows.Forms.Padding(0);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 1;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButton.Size = new System.Drawing.Size(478, 50);
            this.tblButton.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.BackColor = global::ServiceManagementSoftware.Properties.Settings.Default.ButtonBackColor2;
            this.btnCancel.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ServiceManagementSoftware.Properties.Settings.Default, "ButtonBackColor2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(375, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddCustomer.BackColor = global::ServiceManagementSoftware.Properties.Settings.Default.ThemeColor;
            this.btnAddCustomer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ServiceManagementSoftware.Properties.Settings.Default, "ThemeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(268, 5);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(100, 40);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Save";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // chk_CInactive
            // 
            this.chk_CInactive.AutoSize = true;
            this.chk_CInactive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chk_CInactive.Location = new System.Drawing.Point(167, 5);
            this.chk_CInactive.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chk_CInactive.Name = "chk_CInactive";
            this.chk_CInactive.Size = new System.Drawing.Size(91, 40);
            this.chk_CInactive.TabIndex = 5;
            this.chk_CInactive.Text = "InActive";
            this.chk_CInactive.UseVisualStyleBackColor = true;
            this.chk_CInactive.Click += new System.EventHandler(this.chk_InActive_Click);
            // 
            // lblCEmail
            // 
            this.lblCEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCEmail.AutoSize = true;
            this.lblCEmail.Location = new System.Drawing.Point(13, 217);
            this.lblCEmail.Name = "lblCEmail";
            this.lblCEmail.Size = new System.Drawing.Size(45, 24);
            this.lblCEmail.TabIndex = 11;
            this.lblCEmail.Text = "Email";
            // 
            // txtCEmail
            // 
            this.txtCEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCEmail.Location = new System.Drawing.Point(13, 244);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(472, 32);
            this.txtCEmail.TabIndex = 3;
            // 
            // lblCRemark
            // 
            this.lblCRemark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCRemark.AutoSize = true;
            this.lblCRemark.Location = new System.Drawing.Point(13, 286);
            this.lblCRemark.Name = "lblCRemark";
            this.lblCRemark.Size = new System.Drawing.Size(62, 24);
            this.lblCRemark.TabIndex = 13;
            this.lblCRemark.Text = "Remark";
            // 
            // txtCRemark
            // 
            this.txtCRemark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCRemark.Location = new System.Drawing.Point(13, 313);
            this.txtCRemark.Name = "txtCRemark";
            this.txtCRemark.Size = new System.Drawing.Size(472, 32);
            this.txtCRemark.TabIndex = 4;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.tblMain);
            this.pnlMain.Controls.Add(this.ctrControl);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(500, 447);
            this.pnlMain.TabIndex = 10;
            // 
            // ctrControl
            // 
            this.ctrControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrControl.Location = new System.Drawing.Point(0, 0);
            this.ctrControl.LockButton = false;
            this.ctrControl.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.ctrControl.Name = "ctrControl";
            this.ctrControl.Size = new System.Drawing.Size(498, 30);
            this.ctrControl.TabIndex = 11;
            // 
            // CustomerEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 447);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name = "CustomerEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Information";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblButton.ResumeLayout(false);
            this.tblButton.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblCPhone;
        private System.Windows.Forms.Label lblCAddress;
        private System.Windows.Forms.TextBox txtCPhone;
        private System.Windows.Forms.TextBox txtCAddress;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chk_CInactive;
        private Components.ControlBox ctrControl;
        private System.Windows.Forms.Label lblCEmail;
        private System.Windows.Forms.TextBox txtCEmail;
        private System.Windows.Forms.Label lblCRemark;
        private System.Windows.Forms.TextBox txtCRemark;
    }
}