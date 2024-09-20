using Newtonsoft.Json;
using ServiceManagementSoftware.Components;
using ServiceManagementSoftware.Forms.Utils;
using ServiceManagementSoftware.Model;
using ServiceManagementSoftware.Shared;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using d = DataAccess;
using fn = ServiceManagementSoftware.Shared.Functions;

namespace ServiceManagementSoftware.Forms.OptionsMenu
{
    public partial class DbManagement : Form
    {
        string currentDbName;
        string selectedDbName;

        public DbManagement()
        {
            InitializeComponent();

            LoadDatabases();
        }

        #region "Functions"
        
        private void LoadDatabases()
        {
            var builder = new SqlConnectionStringBuilder(d.SetUp.ConString);
            currentDbName = builder.InitialCatalog;
            lblCurDbName.Text = lblCurDbName.Tag + currentDbName;

            var databaseNames = d.Utils.GetDatabaseNames();

            // bind db names
            foreach (var name in databaseNames)
            {
                var pnl = new Panel
                {
                    Dock = DockStyle.Top,
                    MinimumSize = new Size(flpDatabase.Width - 5, 0),
                    BackColor = Color.Gainsboro,
                    Height = 40
                };
                var btnOpt = new NoCuesButton
                {
                    Tag = name,
                    Dock = DockStyle.Right,
                    Width = 35,
                    FlatStyle = FlatStyle.Flat
                };
                btnOpt.FlatAppearance.BorderColor = Color.Silver;
                
                var btn = new NoCuesButton
                {
                    Text = name,
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.Fill
                };
                btn.FlatAppearance.BorderColor = Color.Silver;
                if (name == currentDbName)
                {
                    btn.BackColor = Color.LightGreen;
                    btn.ForeColor = Color.White;
                    btnOpt.Image = Properties.Resources.check_mark;
                }
                else
                {
                    btnOpt.Image = Properties.Resources.opt;
                    btnOpt.Click += (sd, er) =>
                    {
                        selectedDbName = (sd as Button)?.Tag as string;
                        cmsOpt.Show(Cursor.Position);
                    };
                }
                pnl.Controls.Add(btnOpt);
                pnl.Controls.Add(btn);

                flpDatabase.Controls.Add(pnl);
            }
        }

        private void BackupDb(string dbName)
        {
            try
            {
                var dialog = new SaveFileDialog();
                dialog.Filter = "bak File|*.bak";
                dialog.Title = "Save a database backup file";
                dialog.FileName = $"{currentDbName}_{DateTime.Now.ToString("yyyy-MM-dd")}.bak";
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                string filePath = dialog.FileName;

                d.Utils.BackupDatabase(dbName, filePath);

                MessageBox.Show("Backup file successfully created.", "Backup Database", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error occur while creating backup file.", "Backup Database",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure to reset all data ?",
                "Reset data",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                != DialogResult.Yes)
                return;

            // ask password
            PasswordEntry entry = new PasswordEntry();
            if (entry.ShowDialog() != DialogResult.OK)
                return;

            // to backup db

            try
            {
                d.Utils.ResetAllData();

                MessageBox.Show("All data reset successfully !", "Reset data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error occur while deleting data.", "Reset data",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            BackupDb(currentDbName);
        }

        private void mnuUseCur_Click(object sender, EventArgs e)
        {
            // ask password
            PasswordEntry entry = new PasswordEntry();
            if (entry.ShowDialog() != DialogResult.OK)
                return;

            currentDbName = selectedDbName;

            // update in registry
            var info = fn.GetRegistryValue(RegistryId.DbInfo);
            if (info == null)
                return;

            var dbInfo = JsonConvert.DeserializeObject<DbInfo>(info.ToString());
            dbInfo.DbName = currentDbName;
            fn.SetRegistryValue(RegistryId.DbInfo,
                JsonConvert.SerializeObject(dbInfo));

            MessageBox.Show("Application need to restart to affect changes.", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // restart app
            fn.RestartApplication();
        }

        private void mnuBackup_Click(object sender, EventArgs e)
        {
            BackupDb(selectedDbName);
        }
    }
}
