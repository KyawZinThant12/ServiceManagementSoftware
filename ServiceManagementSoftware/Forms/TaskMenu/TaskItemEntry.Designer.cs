namespace ServiceManagementSoftware.Forms.TaskMenu
{
    partial class TaskItemEntry
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboPriority = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tblAssignee = new System.Windows.Forms.TableLayoutPanel();
            this.cboAsignee = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tblQtyCost = new System.Windows.Forms.TableLayoutPanel();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tblTask = new System.Windows.Forms.TableLayoutPanel();
            this.cboTask = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.controlBox1 = new ServiceManagementSoftware.Components.ControlBox();
            this.tblMain.SuspendLayout();
            this.tblButton.SuspendLayout();
            this.tblAssignee.SuspendLayout();
            this.tblQtyCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            this.tblTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.Controls.Add(this.tblButton, 1, 8);
            this.tblMain.Controls.Add(this.cboPriority, 1, 7);
            this.tblMain.Controls.Add(this.label6, 1, 6);
            this.tblMain.Controls.Add(this.tblAssignee, 1, 5);
            this.tblMain.Controls.Add(this.label4, 1, 3);
            this.tblMain.Controls.Add(this.tblQtyCost, 1, 2);
            this.tblMain.Controls.Add(this.tblTask, 1, 1);
            this.tblMain.Controls.Add(this.numAmount, 1, 4);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 30);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 10;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.Size = new System.Drawing.Size(498, 405);
            this.tblMain.TabIndex = 0;
            // 
            // tblButton
            // 
            this.tblButton.ColumnCount = 2;
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblButton.Controls.Add(this.btnCancel, 1, 0);
            this.tblButton.Controls.Add(this.btnAdd, 0, 0);
            this.tblButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButton.Location = new System.Drawing.Point(10, 343);
            this.tblButton.Margin = new System.Windows.Forms.Padding(0);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 1;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButton.Size = new System.Drawing.Size(478, 52);
            this.tblButton.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(375, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Tag = "true";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(76)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(269, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ok";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboPriority
            // 
            this.cboPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPriority.BackColor = System.Drawing.Color.White;
            this.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Location = new System.Drawing.Point(13, 303);
            this.cboPriority.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(472, 33);
            this.cboPriority.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Priority";
            // 
            // tblAssignee
            // 
            this.tblAssignee.ColumnCount = 2;
            this.tblAssignee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAssignee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblAssignee.Controls.Add(this.cboAsignee, 0, 1);
            this.tblAssignee.Controls.Add(this.label5, 0, 0);
            this.tblAssignee.Controls.Add(this.btnAddEmp, 1, 1);
            this.tblAssignee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblAssignee.Location = new System.Drawing.Point(10, 209);
            this.tblAssignee.Margin = new System.Windows.Forms.Padding(0);
            this.tblAssignee.Name = "tblAssignee";
            this.tblAssignee.RowCount = 2;
            this.tblAssignee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblAssignee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAssignee.Size = new System.Drawing.Size(478, 65);
            this.tblAssignee.TabIndex = 7;
            // 
            // cboAsignee
            // 
            this.cboAsignee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAsignee.BackColor = System.Drawing.Color.White;
            this.cboAsignee.DisplayMember = "empName";
            this.cboAsignee.FormattingEnabled = true;
            this.cboAsignee.Location = new System.Drawing.Point(3, 27);
            this.cboAsignee.Name = "cboAsignee";
            this.cboAsignee.Size = new System.Drawing.Size(432, 33);
            this.cboAsignee.TabIndex = 5;
            this.cboAsignee.ValueMember = "empId";
            this.cboAsignee.Leave += new System.EventHandler(this.cboAsignee_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Asignee";
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.LightGray;
            this.btnAddEmp.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmp.Location = new System.Drawing.Point(441, 27);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(34, 33);
            this.btnAddEmp.TabIndex = 2;
            this.btnAddEmp.Text = "+";
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Amount";
            // 
            // tblQtyCost
            // 
            this.tblQtyCost.ColumnCount = 2;
            this.tblQtyCost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblQtyCost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblQtyCost.Controls.Add(this.numQty, 0, 1);
            this.tblQtyCost.Controls.Add(this.label2, 0, 0);
            this.tblQtyCost.Controls.Add(this.numCost, 1, 1);
            this.tblQtyCost.Controls.Add(this.label3, 1, 0);
            this.tblQtyCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblQtyCost.Location = new System.Drawing.Point(10, 75);
            this.tblQtyCost.Margin = new System.Windows.Forms.Padding(0);
            this.tblQtyCost.Name = "tblQtyCost";
            this.tblQtyCost.RowCount = 2;
            this.tblQtyCost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblQtyCost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblQtyCost.Size = new System.Drawing.Size(478, 65);
            this.tblQtyCost.TabIndex = 7;
            // 
            // numQty
            // 
            this.numQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numQty.Location = new System.Drawing.Point(3, 27);
            this.numQty.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(137, 32);
            this.numQty.TabIndex = 2;
            this.numQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQty.ThousandsSeparator = true;
            this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQty.ValueChanged += new System.EventHandler(this.numQty_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity";
            // 
            // numCost
            // 
            this.numCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCost.Location = new System.Drawing.Point(146, 27);
            this.numCost.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(329, 32);
            this.numCost.TabIndex = 3;
            this.numCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCost.ThousandsSeparator = true;
            this.numCost.ValueChanged += new System.EventHandler(this.numQty_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cost";
            // 
            // tblTask
            // 
            this.tblTask.ColumnCount = 2;
            this.tblTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblTask.Controls.Add(this.cboTask, 0, 1);
            this.tblTask.Controls.Add(this.label1, 0, 0);
            this.tblTask.Controls.Add(this.btnAddTask, 1, 1);
            this.tblTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTask.Location = new System.Drawing.Point(10, 10);
            this.tblTask.Margin = new System.Windows.Forms.Padding(0);
            this.tblTask.Name = "tblTask";
            this.tblTask.RowCount = 2;
            this.tblTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTask.Size = new System.Drawing.Size(478, 65);
            this.tblTask.TabIndex = 7;
            // 
            // cboTask
            // 
            this.cboTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTask.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboTask.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTask.BackColor = System.Drawing.Color.White;
            this.cboTask.DisplayMember = "taskName";
            this.cboTask.FormattingEnabled = true;
            this.cboTask.Location = new System.Drawing.Point(3, 27);
            this.cboTask.Name = "cboTask";
            this.cboTask.Size = new System.Drawing.Size(432, 33);
            this.cboTask.TabIndex = 1;
            this.cboTask.ValueMember = "taskId";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Services";
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.LightGray;
            this.btnAddTask.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Location = new System.Drawing.Point(441, 27);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(34, 33);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.Text = "+";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // numAmount
            // 
            this.numAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numAmount.Enabled = false;
            this.numAmount.Location = new System.Drawing.Point(13, 167);
            this.numAmount.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(472, 32);
            this.numAmount.TabIndex = 4;
            this.numAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAmount.ThousandsSeparator = true;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.tblMain);
            this.pnlMain.Controls.Add(this.controlBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(500, 437);
            this.pnlMain.TabIndex = 1;
            // 
            // controlBox1
            // 
            this.controlBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlBox1.Location = new System.Drawing.Point(0, 0);
            this.controlBox1.LockButton = false;
            this.controlBox1.Name = "controlBox1";
            this.controlBox1.Size = new System.Drawing.Size(498, 30);
            this.controlBox1.TabIndex = 2;
            // 
            // TaskItemEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 437);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskItemEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Services";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblButton.ResumeLayout(false);
            this.tblAssignee.ResumeLayout(false);
            this.tblAssignee.PerformLayout();
            this.tblQtyCost.ResumeLayout(false);
            this.tblQtyCost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            this.tblTask.ResumeLayout(false);
            this.tblTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTask;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.ComboBox cboAsignee;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.TableLayoutPanel tblTask;
        private System.Windows.Forms.TableLayoutPanel tblQtyCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tblAssignee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlMain;
        private Components.ControlBox controlBox1;
    }
}