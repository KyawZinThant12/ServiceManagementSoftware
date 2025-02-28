﻿namespace ServiceManagementSoftware.Forms.SetupMenu
{
    partial class AppUserEntry
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbl_appUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rdoFontMu = new System.Windows.Forms.RadioButton();
            this.rdoFontMz = new System.Windows.Forms.RadioButton();
            this.tbl = new System.Windows.Forms.TableLayoutPanel();
            this.rdoLangEn = new System.Windows.Forms.RadioButton();
            this.rdoLangMz = new System.Windows.Forms.RadioButton();
            this.rdoLangMu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.cboUserLevel = new System.Windows.Forms.ComboBox();
            this.lblConfirmPwd = new System.Windows.Forms.Label();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChangePwd = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.chk_active = new System.Windows.Forms.CheckBox();
            this.ctrControl = new ServiceManagementSoftware.Components.ControlBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tblMain.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tbl.SuspendLayout();
            this.tblButton.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(13, 106);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(472, 32);
            this.txtUserName.TabIndex = 0;
            // 
            // lbl_appUserName
            // 
            this.lbl_appUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_appUserName.AutoSize = true;
            this.lbl_appUserName.Location = new System.Drawing.Point(13, 79);
            this.lbl_appUserName.Name = "lbl_appUserName";
            this.lbl_appUserName.Size = new System.Drawing.Size(86, 24);
            this.lbl_appUserName.TabIndex = 7;
            this.lbl_appUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 217);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 25);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(13, 245);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(472, 32);
            this.txtPassword.TabIndex = 1;
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.Controls.Add(this.txtUserName, 1, 4);
            this.tblMain.Controls.Add(this.lbl_appUserName, 1, 3);
            this.tblMain.Controls.Add(this.label1, 1, 1);
            this.tblMain.Controls.Add(this.txtUserId, 1, 2);
            this.tblMain.Controls.Add(this.cboUserLevel, 1, 6);
            this.tblMain.Controls.Add(this.lblPassword, 1, 7);
            this.tblMain.Controls.Add(this.txtPassword, 1, 8);
            this.tblMain.Controls.Add(this.lblConfirmPwd, 1, 9);
            this.tblMain.Controls.Add(this.txtConfirmPwd, 1, 10);
            this.tblMain.Controls.Add(this.tblButton, 1, 13);
            this.tblMain.Controls.Add(this.label3, 1, 5);
            this.tblMain.Controls.Add(this.groupBox1, 1, 11);
            this.tblMain.Controls.Add(this.groupBox2, 1, 12);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 30);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 15;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(498, 548);
            this.tblMain.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.rdoFontMu, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.rdoFontMz, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(472, 39);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // rdoFontMu
            // 
            this.rdoFontMu.AutoSize = true;
            this.rdoFontMu.Location = new System.Drawing.Point(98, 3);
            this.rdoFontMu.Name = "rdoFontMu";
            this.rdoFontMu.Size = new System.Drawing.Size(81, 29);
            this.rdoFontMu.TabIndex = 0;
            this.rdoFontMu.TabStop = true;
            this.rdoFontMu.Text = "Unicode";
            this.rdoFontMu.UseVisualStyleBackColor = true;
            // 
            // rdoFontMz
            // 
            this.rdoFontMz.AutoSize = true;
            this.rdoFontMz.Location = new System.Drawing.Point(3, 3);
            this.rdoFontMz.Name = "rdoFontMz";
            this.rdoFontMz.Size = new System.Drawing.Size(74, 29);
            this.rdoFontMz.TabIndex = 0;
            this.rdoFontMz.TabStop = true;
            this.rdoFontMz.Text = "Zawgyi";
            this.rdoFontMz.UseVisualStyleBackColor = true;
            // 
            // tbl
            // 
            this.tbl.ColumnCount = 3;
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl.Controls.Add(this.rdoLangEn, 0, 0);
            this.tbl.Controls.Add(this.rdoLangMz, 1, 0);
            this.tbl.Controls.Add(this.rdoLangMu, 2, 0);
            this.tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl.Location = new System.Drawing.Point(3, 28);
            this.tbl.Margin = new System.Windows.Forms.Padding(0);
            this.tbl.Name = "tbl";
            this.tbl.RowCount = 1;
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tbl.Size = new System.Drawing.Size(472, 39);
            this.tbl.TabIndex = 12;
            // 
            // rdoLangEn
            // 
            this.rdoLangEn.AutoSize = true;
            this.rdoLangEn.Location = new System.Drawing.Point(3, 3);
            this.rdoLangEn.Name = "rdoLangEn";
            this.rdoLangEn.Size = new System.Drawing.Size(73, 29);
            this.rdoLangEn.TabIndex = 0;
            this.rdoLangEn.TabStop = true;
            this.rdoLangEn.Text = "English";
            this.rdoLangEn.UseVisualStyleBackColor = true;
            // 
            // rdoLangMz
            // 
            this.rdoLangMz.AutoSize = true;
            this.rdoLangMz.Location = new System.Drawing.Point(98, 3);
            this.rdoLangMz.Name = "rdoLangMz";
            this.rdoLangMz.Size = new System.Drawing.Size(141, 29);
            this.rdoLangMz.TabIndex = 0;
            this.rdoLangMz.TabStop = true;
            this.rdoLangMz.Text = "Myanmar Zawgyi";
            this.rdoLangMz.UseVisualStyleBackColor = true;
            // 
            // rdoLangMu
            // 
            this.rdoLangMu.AutoSize = true;
            this.rdoLangMu.Location = new System.Drawing.Point(255, 3);
            this.rdoLangMu.Name = "rdoLangMu";
            this.rdoLangMu.Size = new System.Drawing.Size(148, 29);
            this.rdoLangMu.TabIndex = 0;
            this.rdoLangMu.TabStop = true;
            this.rdoLangMu.Text = "Myanmar Unicode";
            this.rdoLangMu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Id";
            // 
            // txtUserId
            // 
            this.txtUserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserId.Location = new System.Drawing.Point(13, 37);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(472, 32);
            this.txtUserId.TabIndex = 0;
            // 
            // cboUserLevel
            // 
            this.cboUserLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUserLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserLevel.FormattingEnabled = true;
            this.cboUserLevel.Location = new System.Drawing.Point(13, 177);
            this.cboUserLevel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboUserLevel.Name = "cboUserLevel";
            this.cboUserLevel.Size = new System.Drawing.Size(472, 33);
            this.cboUserLevel.TabIndex = 11;
            // 
            // lblConfirmPwd
            // 
            this.lblConfirmPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblConfirmPwd.AutoSize = true;
            this.lblConfirmPwd.Location = new System.Drawing.Point(13, 280);
            this.lblConfirmPwd.Name = "lblConfirmPwd";
            this.lblConfirmPwd.Size = new System.Drawing.Size(128, 25);
            this.lblConfirmPwd.TabIndex = 7;
            this.lblConfirmPwd.Text = "Confirm Password";
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPwd.Location = new System.Drawing.Point(13, 308);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = '●';
            this.txtConfirmPwd.Size = new System.Drawing.Size(472, 32);
            this.txtConfirmPwd.TabIndex = 1;
            // 
            // tblButton
            // 
            this.tblButton.ColumnCount = 4;
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tblButton.Controls.Add(this.btnCancel, 3, 0);
            this.tblButton.Controls.Add(this.btnAddCustomer, 2, 0);
            this.tblButton.Controls.Add(this.chk_active, 0, 0);
            this.tblButton.Controls.Add(this.btnChangePwd, 1, 0);
            this.tblButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButton.Location = new System.Drawing.Point(10, 483);
            this.tblButton.Margin = new System.Windows.Forms.Padding(0);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 1;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButton.Size = new System.Drawing.Size(478, 55);
            this.tblButton.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.BackColor = global::ServiceManagementSoftware.Properties.Settings.Default.ButtonBackColor2;
            this.btnCancel.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ServiceManagementSoftware.Properties.Settings.Default, "ButtonBackColor2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(375, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnChangePwd.BackColor = global::ServiceManagementSoftware.Properties.Settings.Default.ThemeColor;
            this.btnChangePwd.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ServiceManagementSoftware.Properties.Settings.Default, "ThemeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnChangePwd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnChangePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePwd.ForeColor = System.Drawing.Color.White;
            this.btnChangePwd.Location = new System.Drawing.Point(116, 7);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(141, 40);
            this.btnChangePwd.TabIndex = 3;
            this.btnChangePwd.Text = "Change Password";
            this.btnChangePwd.UseVisualStyleBackColor = false;
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddCustomer.BackColor = global::ServiceManagementSoftware.Properties.Settings.Default.ThemeColor;
            this.btnAddCustomer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ServiceManagementSoftware.Properties.Settings.Default, "ThemeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(266, 7);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(100, 40);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "Save";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chk_active
            // 
            this.chk_active.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chk_active.AutoSize = true;
            this.chk_active.Location = new System.Drawing.Point(3, 13);
            this.chk_active.Name = "chk_active";
            this.chk_active.Size = new System.Drawing.Size(84, 29);
            this.chk_active.TabIndex = 5;
            this.chk_active.Text = "InActive";
            this.chk_active.UseVisualStyleBackColor = true;
            this.chk_active.Click += new System.EventHandler(this.chk_active_Click);
            // 
            // ctrControl
            // 
            this.ctrControl.BackColor = global::ServiceManagementSoftware.Properties.Settings.Default.ControlColor;
            this.ctrControl.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ServiceManagementSoftware.Properties.Settings.Default, "ControlColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ctrControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrControl.Location = new System.Drawing.Point(0, 0);
            this.ctrControl.LockButton = false;
            this.ctrControl.Margin = new System.Windows.Forms.Padding(0);
            this.ctrControl.Name = "ctrControl";
            this.ctrControl.Size = new System.Drawing.Size(498, 30);
            this.ctrControl.TabIndex = 8;
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.tblMain);
            this.pnlMain.Controls.Add(this.ctrControl);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(500, 580);
            this.pnlMain.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Language";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 343);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 70);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Language";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 413);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 70);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // AppUserEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 580);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name = "AppUserEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Information";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tbl.ResumeLayout(false);
            this.tbl.PerformLayout();
            this.tblButton.ResumeLayout(false);
            this.tblButton.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbl_appUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private Components.ControlBox ctrControl;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chk_active;
        private System.Windows.Forms.ComboBox cboUserLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblConfirmPwd;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.Button btnChangePwd;
        private System.Windows.Forms.TableLayoutPanel tbl;
        private System.Windows.Forms.RadioButton rdoLangEn;
        private System.Windows.Forms.RadioButton rdoLangMz;
        private System.Windows.Forms.RadioButton rdoLangMu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rdoFontMu;
        private System.Windows.Forms.RadioButton rdoFontMz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}