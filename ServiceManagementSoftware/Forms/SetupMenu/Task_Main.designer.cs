namespace ServiceManagementSoftware.Forms.SetupMenu
{
    partial class Task_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Task = new System.Windows.Forms.DataGridView();
            this.Tname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tremark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTaskCount = new System.Windows.Forms.Label();
            this.tblToolBar = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btn_addTasks = new ServiceManagementSoftware.Components.NoCuesButton();
            this.rdbtn_active = new System.Windows.Forms.RadioButton();
            this.rdbtn_All = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.formTitle1 = new ServiceManagementSoftware.Components.FormTitle();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Task)).BeginInit();
            this.tblMain.SuspendLayout();
            this.tblToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Task
            // 
            this.dgv_Task.AllowUserToAddRows = false;
            this.dgv_Task.AllowUserToDeleteRows = false;
            this.dgv_Task.AllowUserToOrderColumns = true;
            this.dgv_Task.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Task.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Task.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Task.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Task.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Task.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Task.ColumnHeadersHeight = 30;
            this.dgv_Task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Task.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tname,
            this.TCost,
            this.Tremark,
            this.colUpdate,
            this.colDelete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(166)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Task.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Task.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Task.EnableHeadersVisualStyles = false;
            this.dgv_Task.Location = new System.Drawing.Point(13, 79);
            this.dgv_Task.Name = "dgv_Task";
            this.dgv_Task.ReadOnly = true;
            this.dgv_Task.RowHeadersVisible = false;
            this.dgv_Task.RowTemplate.Height = 30;
            this.dgv_Task.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Task.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Task.Size = new System.Drawing.Size(911, 378);
            this.dgv_Task.TabIndex = 1;
            this.dgv_Task.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Task_CellContentClick);
            this.dgv_Task.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Task_CellDoubleClick);
            this.dgv_Task.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_Task_CellPainting);
            // 
            // Tname
            // 
            this.Tname.DataPropertyName = "taskName";
            this.Tname.FillWeight = 298.5894F;
            this.Tname.HeaderText = "Services";
            this.Tname.MinimumWidth = 350;
            this.Tname.Name = "Tname";
            this.Tname.ReadOnly = true;
            // 
            // TCost
            // 
            this.TCost.DataPropertyName = "cost";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.TCost.DefaultCellStyle = dataGridViewCellStyle2;
            this.TCost.FillWeight = 11.75549F;
            this.TCost.HeaderText = "Cost";
            this.TCost.MinimumWidth = 22;
            this.TCost.Name = "TCost";
            this.TCost.ReadOnly = true;
            // 
            // Tremark
            // 
            this.Tremark.DataPropertyName = "remark";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Tremark.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tremark.FillWeight = 11.75549F;
            this.Tremark.HeaderText = "Remark";
            this.Tremark.MinimumWidth = 400;
            this.Tremark.Name = "Tremark";
            this.Tremark.ReadOnly = true;
            // 
            // colUpdate
            // 
            this.colUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.colUpdate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colUpdate.HeaderText = "";
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.ReadOnly = true;
            this.colUpdate.Text = "";
            this.colUpdate.UseColumnTextForButtonValue = true;
            this.colUpdate.Width = 30;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 30;
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.Controls.Add(this.dgv_Task, 1, 3);
            this.tblMain.Controls.Add(this.lblTaskCount, 1, 4);
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
            this.tblMain.Size = new System.Drawing.Size(937, 490);
            this.tblMain.TabIndex = 3;
            // 
            // lblTaskCount
            // 
            this.lblTaskCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTaskCount.AutoSize = true;
            this.lblTaskCount.Location = new System.Drawing.Point(13, 460);
            this.lblTaskCount.Name = "lblTaskCount";
            this.lblTaskCount.Size = new System.Drawing.Size(50, 25);
            this.lblTaskCount.TabIndex = 3;
            this.lblTaskCount.Text = "Count";
            // 
            // tblToolBar
            // 
            this.tblToolBar.ColumnCount = 5;
            this.tblToolBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblToolBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tblToolBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tblToolBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tblToolBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblToolBar.Controls.Add(this.txtSearch, 3, 0);
            this.tblToolBar.Controls.Add(this.btn_addTasks, 4, 0);
            this.tblToolBar.Controls.Add(this.rdbtn_active, 1, 0);
            this.tblToolBar.Controls.Add(this.rdbtn_All, 2, 0);
            this.tblToolBar.Controls.Add(this.btnBack, 0, 0);
            this.tblToolBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblToolBar.Location = new System.Drawing.Point(10, 30);
            this.tblToolBar.Margin = new System.Windows.Forms.Padding(0);
            this.tblToolBar.Name = "tblToolBar";
            this.tblToolBar.RowCount = 1;
            this.tblToolBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblToolBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblToolBar.Size = new System.Drawing.Size(917, 46);
            this.tblToolBar.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(573, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 32);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btn_addTasks
            // 
            this.btn_addTasks.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_addTasks.BackColor = global::ServiceManagementSoftware.Properties.Settings.Default.ThemeColor;
            this.btn_addTasks.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ServiceManagementSoftware.Properties.Settings.Default, "ThemeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_addTasks.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_addTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTasks.ForeColor = System.Drawing.Color.White;
            this.btn_addTasks.Location = new System.Drawing.Point(806, 3);
            this.btn_addTasks.Name = "btn_addTasks";
            this.btn_addTasks.Size = new System.Drawing.Size(108, 40);
            this.btn_addTasks.TabIndex = 2;
            this.btn_addTasks.Text = "Add Services";
            this.btn_addTasks.UseVisualStyleBackColor = false;
            this.btn_addTasks.Click += new System.EventHandler(this.btn_addTask_Click);
            // 
            // rdbtn_active
            // 
            this.rdbtn_active.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdbtn_active.AutoSize = true;
            this.rdbtn_active.Checked = true;
            this.rdbtn_active.Location = new System.Drawing.Point(440, 8);
            this.rdbtn_active.Name = "rdbtn_active";
            this.rdbtn_active.Size = new System.Drawing.Size(69, 29);
            this.rdbtn_active.TabIndex = 6;
            this.rdbtn_active.TabStop = true;
            this.rdbtn_active.Text = "Active";
            this.rdbtn_active.UseVisualStyleBackColor = true;
            this.rdbtn_active.CheckedChanged += new System.EventHandler(this.rdbtn_active_CheckedChanged);
            // 
            // rdbtn_All
            // 
            this.rdbtn_All.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdbtn_All.AutoSize = true;
            this.rdbtn_All.Location = new System.Drawing.Point(524, 8);
            this.rdbtn_All.Name = "rdbtn_All";
            this.rdbtn_All.Size = new System.Drawing.Size(43, 29);
            this.rdbtn_All.TabIndex = 7;
            this.rdbtn_All.Text = "All";
            this.rdbtn_All.UseVisualStyleBackColor = true;
            this.rdbtn_All.CheckedChanged += new System.EventHandler(this.rdbtn_All_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBack.BackColor = global::ServiceManagementSoftware.Properties.Settings.Default.ButtonBackColor2;
            this.btnBack.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ServiceManagementSoftware.Properties.Settings.Default, "ButtonBackColor2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::ServiceManagementSoftware.Properties.Resources.arrow_left;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // formTitle1
            // 
            this.formTitle1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formTitle1.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle1.Location = new System.Drawing.Point(413, 5);
            this.formTitle1.Margin = new System.Windows.Forms.Padding(0);
            this.formTitle1.Name = "formTitle1";
            this.formTitle1.Size = new System.Drawing.Size(111, 25);
            this.formTitle1.TabIndex = 4;
            this.formTitle1.Title = "Services";
            // 
            // Task_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(937, 490);
            this.ControlBox = false;
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name = "Task_Main";
            this.Text = "Customer_Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Task)).EndInit();
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblToolBar.ResumeLayout(false);
            this.tblToolBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Components.NoCuesButton btn_addTasks;
        public System.Windows.Forms.DataGridView dgv_Task;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblToolBar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton rdbtn_active;
        private System.Windows.Forms.RadioButton rdbtn_All;
        private System.Windows.Forms.Label lblTaskCount;
        private Components.FormTitle formTitle1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tname;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tremark;
        private System.Windows.Forms.DataGridViewButtonColumn colUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}