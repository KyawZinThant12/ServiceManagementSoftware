﻿namespace ServiceManagementSoftware.Forms.SetupMenu
{
    partial class AppUser_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_appUser = new System.Windows.Forms.DataGridView();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsersCount = new System.Windows.Forms.Label();
            this.tblToolBar = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btn_addUser = new ServiceManagementSoftware.Components.NoCuesButton();
            this.rdbtn_active = new System.Windows.Forms.RadioButton();
            this.rdbtn_all = new System.Windows.Forms.RadioButton();
            this.btnPermit = new ServiceManagementSoftware.Components.NoCuesButton();
            this.formTitle1 = new ServiceManagementSoftware.Components.FormTitle();
            this.colUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appUser)).BeginInit();
            this.tblMain.SuspendLayout();
            this.tblToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_appUser
            // 
            this.dgv_appUser.AllowUserToAddRows = false;
            this.dgv_appUser.AllowUserToDeleteRows = false;
            this.dgv_appUser.AllowUserToOrderColumns = true;
            this.dgv_appUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_appUser.BackgroundColor = System.Drawing.Color.White;
            this.dgv_appUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_appUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_appUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_appUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_appUser.ColumnHeadersHeight = 30;
            this.dgv_appUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_appUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserId,
            this.name,
            this.userLevel,
            this.colUpdate,
            this.colDelete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(166)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_appUser.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_appUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_appUser.EnableHeadersVisualStyles = false;
            this.dgv_appUser.Location = new System.Drawing.Point(13, 81);
            this.dgv_appUser.Name = "dgv_appUser";
            this.dgv_appUser.ReadOnly = true;
            this.dgv_appUser.RowHeadersVisible = false;
            this.dgv_appUser.RowTemplate.Height = 30;
            this.dgv_appUser.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_appUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_appUser.Size = new System.Drawing.Size(951, 388);
            this.dgv_appUser.TabIndex = 1;
            this.dgv_appUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellContentClick);
            this.dgv_appUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellDoubleClick);
            this.dgv_appUser.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_customer_CellPainting);
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.Controls.Add(this.lblUsersCount, 1, 4);
            this.tblMain.Controls.Add(this.dgv_appUser, 1, 3);
            this.tblMain.Controls.Add(this.tblToolBar, 1, 2);
            this.tblMain.Controls.Add(this.formTitle1, 1, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 6;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblMain.Size = new System.Drawing.Size(977, 502);
            this.tblMain.TabIndex = 3;
            // 
            // lblUsersCount
            // 
            this.lblUsersCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsersCount.AutoSize = true;
            this.lblUsersCount.Location = new System.Drawing.Point(13, 472);
            this.lblUsersCount.Name = "lblUsersCount";
            this.lblUsersCount.Size = new System.Drawing.Size(65, 25);
            this.lblUsersCount.TabIndex = 3;
            this.lblUsersCount.Text = "Count : ";
            // 
            // tblToolBar
            // 
            this.tblToolBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblToolBar.ColumnCount = 6;
            this.tblToolBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblToolBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblToolBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tblToolBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tblToolBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tblToolBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tblToolBar.Controls.Add(this.btnBack, 0, 0);
            this.tblToolBar.Controls.Add(this.txtSearch, 4, 0);
            this.tblToolBar.Controls.Add(this.btn_addUser, 5, 0);
            this.tblToolBar.Controls.Add(this.rdbtn_active, 2, 0);
            this.tblToolBar.Controls.Add(this.rdbtn_all, 3, 0);
            this.tblToolBar.Controls.Add(this.btnPermit, 1, 0);
            this.tblToolBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblToolBar.Location = new System.Drawing.Point(10, 32);
            this.tblToolBar.Margin = new System.Windows.Forms.Padding(0);
            this.tblToolBar.Name = "tblToolBar";
            this.tblToolBar.RowCount = 1;
            this.tblToolBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblToolBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblToolBar.Size = new System.Drawing.Size(957, 46);
            this.tblToolBar.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBack.BackColor = global::ServiceManagementSoftware.Properties.Settings.Default.ButtonBackColor2;
            this.btnBack.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ServiceManagementSoftware.Properties.Settings.Default, "ButtonBackColor2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::ServiceManagementSoftware.Properties.Resources.arrow_left;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Tag = "True";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(668, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(175, 32);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Tag = "True";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btn_addUser
            // 
            this.btn_addUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_addUser.BackColor = global::ServiceManagementSoftware.Properties.Settings.Default.ThemeColor;
            this.btn_addUser.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ServiceManagementSoftware.Properties.Settings.Default, "ThemeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_addUser.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addUser.ForeColor = System.Drawing.Color.White;
            this.btn_addUser.Location = new System.Drawing.Point(854, 3);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(100, 40);
            this.btn_addUser.TabIndex = 2;
            this.btn_addUser.Text = "Add User";
            this.btn_addUser.UseVisualStyleBackColor = false;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // rdbtn_active
            // 
            this.rdbtn_active.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdbtn_active.AutoSize = true;
            this.rdbtn_active.Checked = true;
            this.rdbtn_active.Location = new System.Drawing.Point(529, 8);
            this.rdbtn_active.Name = "rdbtn_active";
            this.rdbtn_active.Size = new System.Drawing.Size(69, 29);
            this.rdbtn_active.TabIndex = 6;
            this.rdbtn_active.TabStop = true;
            this.rdbtn_active.Tag = "True";
            this.rdbtn_active.Text = "Active";
            this.rdbtn_active.UseVisualStyleBackColor = true;
            this.rdbtn_active.CheckedChanged += new System.EventHandler(this.rdbtn_active_CheckedChanged);
            // 
            // rdbtn_all
            // 
            this.rdbtn_all.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdbtn_all.AutoSize = true;
            this.rdbtn_all.Location = new System.Drawing.Point(610, 8);
            this.rdbtn_all.Name = "rdbtn_all";
            this.rdbtn_all.Size = new System.Drawing.Size(43, 29);
            this.rdbtn_all.TabIndex = 7;
            this.rdbtn_all.Tag = "True";
            this.rdbtn_all.Text = "All";
            this.rdbtn_all.UseVisualStyleBackColor = true;
            this.rdbtn_all.CheckedChanged += new System.EventHandler(this.rdbtn_all_CheckedChanged);
            // 
            // btnPermit
            // 
            this.btnPermit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPermit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPermit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermit.Location = new System.Drawing.Point(53, 3);
            this.btnPermit.Name = "btnPermit";
            this.btnPermit.Size = new System.Drawing.Size(100, 40);
            this.btnPermit.TabIndex = 8;
            this.btnPermit.Text = "Permissions";
            this.btnPermit.UseVisualStyleBackColor = true;
            this.btnPermit.Click += new System.EventHandler(this.btnPermit_Click);
            // 
            // formTitle1
            // 
            this.formTitle1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formTitle1.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle1.Location = new System.Drawing.Point(445, 5);
            this.formTitle1.Margin = new System.Windows.Forms.Padding(0);
            this.formTitle1.Name = "formTitle1";
            this.formTitle1.Size = new System.Drawing.Size(87, 27);
            this.formTitle1.TabIndex = 4;
            this.formTitle1.Title = "User";
            // 
            // colUserId
            // 
            this.colUserId.DataPropertyName = "userId";
            this.colUserId.HeaderText = "User Id";
            this.colUserId.Name = "colUserId";
            this.colUserId.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "userName";
            this.name.HeaderText = "User Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // userLevel
            // 
            this.userLevel.DataPropertyName = "userLevel";
            this.userLevel.HeaderText = "User Level";
            this.userLevel.Name = "userLevel";
            this.userLevel.ReadOnly = true;
            // 
            // colUpdate
            // 
            this.colUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.colUpdate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colUpdate.HeaderText = "";
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.ReadOnly = true;
            this.colUpdate.Text = "";
            this.colUpdate.Width = 30;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "";
            this.colDelete.Width = 30;
            // 
            // AppUser_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(977, 502);
            this.ControlBox = false;
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name = "AppUser_Main";
            this.Text = "Customer_Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appUser)).EndInit();
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblToolBar.ResumeLayout(false);
            this.tblToolBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Components.NoCuesButton btn_addUser;
        public System.Windows.Forms.DataGridView dgv_appUser;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblToolBar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton rdbtn_all;
        private System.Windows.Forms.RadioButton rdbtn_active;
        private Components.NoCuesButton btnPermit;
        private System.Windows.Forms.Label lblUsersCount;
        private Components.FormTitle formTitle1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLevel;
        private System.Windows.Forms.DataGridViewButtonColumn colUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}