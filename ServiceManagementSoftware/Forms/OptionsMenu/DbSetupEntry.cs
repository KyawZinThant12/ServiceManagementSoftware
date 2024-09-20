using Newtonsoft.Json;
using ServiceManagementSoftware.Model;
using ServiceManagementSoftware.Shared;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using d = DataAccess;
using fn = ServiceManagementSoftware.Shared.Functions;

namespace ServiceManagementSoftware.Forms.OptionsMenu
{
    public partial class DbSetupEntry : Form
    {
        CancellationTokenSource cts;

        public DbSetupEntry()
        {
            InitializeComponent();

            SetupData();
        }

        #region "Functions"

        private void SetupData()
        {
            var info = fn.GetRegistryValue(RegistryId.DbInfo);
            if (info == null) return;

            var dbInfo = JsonConvert.DeserializeObject<DbInfo>(info.ToString());

            txtServerName.Text = dbInfo.ServerName;
            txtUserName.Text = dbInfo.DbUserName;
            txtPwd.Text = Encoding.ASCII.GetString(dbInfo.DbPwd);
            txtDbName.Text = dbInfo.DbName;
        }

        #endregion

        private async void btnOk_Click(object sender, EventArgs e)
        {
            string conString = fn.GetConString(txtServerName.Text, txtUserName.Text, 
                txtPwd.Text, txtDbName.Text);

            btnOk.Text = "Saving...";
            btnOk.Enabled = btnTest.Enabled = false;

            cts = new CancellationTokenSource();
            if (await fn.IsConStringValid(conString, cts.Token))
            {
                d.SetUp.ConString = conString;

                var dbInfo = new DbInfo
                {
                    ServerName = txtServerName.Text,
                    DbUserName = txtUserName.Text,
                    DbPwd = Encoding.ASCII.GetBytes(txtPwd.Text),
                    DbName = txtDbName.Text
                };

                var info = JsonConvert.SerializeObject(dbInfo);
                fn.SetRegistryValue(RegistryId.DbInfo, info);

                DialogResult = DialogResult.OK;
            }
            else
            {
                btnOk.Enabled = btnTest.Enabled = true;

                btnOk.Text = btnOk.Tag as string;

                if (!cts.IsCancellationRequested)
                {
                    MessageBox.Show("Connection is not valid !", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            cts = null;
        }

        private async void btnTest_Click(object sender, EventArgs e)
        {
            string conString = fn.GetConString(txtServerName.Text, txtUserName.Text,
                txtPwd.Text, txtDbName.Text);

            btnTest.Text = "Testing...";
            btnOk.Enabled = btnTest.Enabled = false;

            cts = new CancellationTokenSource();
            if (await fn.IsConStringValid(conString, cts.Token))
            {
                btnOk.Enabled = btnTest.Enabled = true;
                btnTest.Text = btnTest.Tag as string;

                MessageBox.Show("Test connection success !", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnOk.Enabled = btnTest.Enabled = true;
                btnTest.Text = btnTest.Tag as string;

                if (!cts.IsCancellationRequested)
                {
                    MessageBox.Show("Connection is not valid !", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            cts = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
                return;
            }

            DialogResult = DialogResult.Cancel;
        }

        private void DbSetupEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            cts?.Cancel();
        }
    }
}
