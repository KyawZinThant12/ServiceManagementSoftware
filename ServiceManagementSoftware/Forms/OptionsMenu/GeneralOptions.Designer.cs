﻿namespace ServiceManagementSoftware.Forms.OptionsMenu
{
    partial class GeneralOptions
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
            this.btnSave = new System.Windows.Forms.Button();
            this.tbl = new System.Windows.Forms.TableLayoutPanel();
            this.btnBusiness = new System.Windows.Forms.Button();
            this.tblLang = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rdoLangEn = new System.Windows.Forms.RadioButton();
            this.rdoLangMz = new System.Windows.Forms.RadioButton();
            this.rdoLangMu = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rdoFontMu = new System.Windows.Forms.RadioButton();
            this.rdoFontMz = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            this.tbl.SuspendLayout();
            this.tblLang.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 548F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.btnSave, 2, 1);
            this.tblMain.Controls.Add(this.tbl, 1, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblMain.Size = new System.Drawing.Size(737, 467);
            this.tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = global::ServiceManagementSoftware.Properties.Settings.Default.ThemeColor;
            this.btnSave.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ServiceManagementSoftware.Properties.Settings.Default, "ThemeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(561, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbl
            // 
            this.tbl.ColumnCount = 1;
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl.Controls.Add(this.btnBusiness, 0, 1);
            this.tbl.Controls.Add(this.tblLang, 0, 0);
            this.tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl.Location = new System.Drawing.Point(10, 10);
            this.tbl.Margin = new System.Windows.Forms.Padding(0);
            this.tbl.Name = "tbl";
            this.tbl.RowCount = 3;
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl.Size = new System.Drawing.Size(548, 447);
            this.tbl.TabIndex = 4;
            // 
            // btnBusiness
            // 
            this.btnBusiness.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBusiness.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusiness.ForeColor = System.Drawing.Color.Black;
            this.btnBusiness.Location = new System.Drawing.Point(0, 109);
            this.btnBusiness.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.btnBusiness.Name = "btnBusiness";
            this.btnBusiness.Size = new System.Drawing.Size(547, 42);
            this.btnBusiness.TabIndex = 2;
            this.btnBusiness.Text = "Business Info";
            this.btnBusiness.UseVisualStyleBackColor = false;
            this.btnBusiness.Click += new System.EventHandler(this.btnBusiness_Click);
            // 
            // tblLang
            // 
            this.tblLang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblLang.ColumnCount = 2;
            this.tblLang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLang.Controls.Add(this.label2, 0, 1);
            this.tblLang.Controls.Add(this.label3, 0, 2);
            this.tblLang.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tblLang.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tblLang.Controls.Add(this.label1, 0, 0);
            this.tblLang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLang.Location = new System.Drawing.Point(0, 0);
            this.tblLang.Margin = new System.Windows.Forms.Padding(0);
            this.tblLang.Name = "tblLang";
            this.tblLang.RowCount = 3;
            this.tblLang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblLang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLang.Size = new System.Drawing.Size(548, 99);
            this.tblLang.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Language : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Font : ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.rdoLangEn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rdoLangMz, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rdoLangMu, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(96, 30);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(452, 32);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // rdoLangEn
            // 
            this.rdoLangEn.AutoSize = true;
            this.rdoLangEn.Location = new System.Drawing.Point(3, 3);
            this.rdoLangEn.Name = "rdoLangEn";
            this.rdoLangEn.Size = new System.Drawing.Size(73, 26);
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
            this.rdoLangMz.Size = new System.Drawing.Size(141, 26);
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
            this.rdoLangMu.Size = new System.Drawing.Size(148, 26);
            this.rdoLangMu.TabIndex = 0;
            this.rdoLangMu.TabStop = true;
            this.rdoLangMu.Text = "Myanmar Unicode";
            this.rdoLangMu.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.rdoFontMu, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.rdoFontMz, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(96, 62);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(452, 37);
            this.tableLayoutPanel3.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.tblLang.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Language and Font";
            // 
            // GeneralOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 467);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "GeneralOptions";
            this.Text = "GeneralOptions";
            this.tblMain.ResumeLayout(false);
            this.tbl.ResumeLayout(false);
            this.tblLang.ResumeLayout(false);
            this.tblLang.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Button btnBusiness;
        private System.Windows.Forms.TableLayoutPanel tblLang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rdoLangEn;
        private System.Windows.Forms.RadioButton rdoLangMz;
        private System.Windows.Forms.RadioButton rdoLangMu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rdoFontMu;
        private System.Windows.Forms.RadioButton rdoFontMz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tbl;
        private System.Windows.Forms.Button btnSave;
    }
}