namespace ServiceManagementSoftware.Forms.SetupMenu
{
    partial class ItemEntry
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
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblIName = new System.Windows.Forms.Label();
            this.lblIPrice = new System.Windows.Forms.Label();
            this.lblIRemark = new System.Windows.Forms.Label();
            this.txtIRemark = new System.Windows.Forms.TextBox();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.chk_InActive = new System.Windows.Forms.CheckBox();
            this.txtIPrice = new System.Windows.Forms.NumericUpDown();
            this.ctrBox = new ServiceManagementSoftware.Components.ControlBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tblMain.SuspendLayout();
            this.tblButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIPrice)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemName.Location = new System.Drawing.Point(13, 42);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(472, 32);
            this.txtItemName.TabIndex = 0;
            // 
            // lblIName
            // 
            this.lblIName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIName.AutoSize = true;
            this.lblIName.Location = new System.Drawing.Point(13, 10);
            this.lblIName.Name = "lblIName";
            this.lblIName.Size = new System.Drawing.Size(91, 24);
            this.lblIName.TabIndex = 7;
            this.lblIName.Text = "Stock Name";
            // 
            // lblIPrice
            // 
            this.lblIPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIPrice.AutoSize = true;
            this.lblIPrice.Location = new System.Drawing.Point(13, 79);
            this.lblIPrice.Name = "lblIPrice";
            this.lblIPrice.Size = new System.Drawing.Size(42, 24);
            this.lblIPrice.TabIndex = 7;
            this.lblIPrice.Text = "Price";
            // 
            // lblIRemark
            // 
            this.lblIRemark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIRemark.AutoSize = true;
            this.lblIRemark.Location = new System.Drawing.Point(13, 148);
            this.lblIRemark.Name = "lblIRemark";
            this.lblIRemark.Size = new System.Drawing.Size(62, 24);
            this.lblIRemark.TabIndex = 7;
            this.lblIRemark.Text = "Remark";
            // 
            // txtIRemark
            // 
            this.txtIRemark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIRemark.Location = new System.Drawing.Point(13, 180);
            this.txtIRemark.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.txtIRemark.Name = "txtIRemark";
            this.txtIRemark.Size = new System.Drawing.Size(472, 32);
            this.txtIRemark.TabIndex = 2;
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.Controls.Add(this.tblButton, 1, 7);
            this.tblMain.Controls.Add(this.lblIName, 1, 1);
            this.tblMain.Controls.Add(this.txtItemName, 1, 2);
            this.tblMain.Controls.Add(this.lblIPrice, 1, 3);
            this.tblMain.Controls.Add(this.txtIRemark, 1, 6);
            this.tblMain.Controls.Add(this.lblIRemark, 1, 5);
            this.tblMain.Controls.Add(this.txtIPrice, 1, 4);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 30);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 9;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.Size = new System.Drawing.Size(498, 276);
            this.tblMain.TabIndex = 9;
            // 
            // tblButton
            // 
            this.tblButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblButton.ColumnCount = 4;
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblButton.Controls.Add(this.btnCancel, 3, 0);
            this.tblButton.Controls.Add(this.btnAddItem, 2, 0);
            this.tblButton.Controls.Add(this.chk_InActive, 1, 0);
            this.tblButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButton.Location = new System.Drawing.Point(10, 217);
            this.tblButton.Margin = new System.Windows.Forms.Padding(0);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 1;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButton.Size = new System.Drawing.Size(478, 49);
            this.tblButton.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancel.BackColor = global::ServiceManagementSoftware.Properties.Settings.Default.ButtonBackColor2;
            this.btnCancel.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ServiceManagementSoftware.Properties.Settings.Default, "ButtonBackColor2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(375, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddItem.BackColor = global::ServiceManagementSoftware.Properties.Settings.Default.ThemeColor;
            this.btnAddItem.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ServiceManagementSoftware.Properties.Settings.Default, "ThemeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(269, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(100, 40);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Save";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // chk_InActive
            // 
            this.chk_InActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chk_InActive.AutoSize = true;
            this.chk_InActive.Location = new System.Drawing.Point(163, 10);
            this.chk_InActive.Name = "chk_InActive";
            this.chk_InActive.Size = new System.Drawing.Size(84, 29);
            this.chk_InActive.TabIndex = 6;
            this.chk_InActive.Text = "InActive";
            this.chk_InActive.UseVisualStyleBackColor = true;
            this.chk_InActive.Click += new System.EventHandler(this.chk_active_Click);
            // 
            // txtIPrice
            // 
            this.txtIPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIPrice.Location = new System.Drawing.Point(13, 107);
            this.txtIPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIPrice.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtIPrice.Name = "txtIPrice";
            this.txtIPrice.Size = new System.Drawing.Size(472, 32);
            this.txtIPrice.TabIndex = 11;
            this.txtIPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ctrBox
            // 
            this.ctrBox.BackColor = global::ServiceManagementSoftware.Properties.Settings.Default.ControlColor;
            this.ctrBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ServiceManagementSoftware.Properties.Settings.Default, "ControlColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ctrBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrBox.Location = new System.Drawing.Point(0, 0);
            this.ctrBox.LockButton = false;
            this.ctrBox.Margin = new System.Windows.Forms.Padding(0);
            this.ctrBox.Name = "ctrBox";
            this.ctrBox.Size = new System.Drawing.Size(498, 30);
            this.ctrBox.TabIndex = 8;
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.tblMain);
            this.pnlMain.Controls.Add(this.ctrBox);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(500, 308);
            this.pnlMain.TabIndex = 10;
            // 
            // ItemEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 308);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name = "ItemEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock && Charges Information";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblButton.ResumeLayout(false);
            this.tblButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIPrice)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblIName;
        private System.Windows.Forms.Label lblIPrice;
        private System.Windows.Forms.Label lblIRemark;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtIRemark;
        private Components.ControlBox ctrBox;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.CheckBox chk_InActive;
        private System.Windows.Forms.NumericUpDown txtIPrice;
    }
}