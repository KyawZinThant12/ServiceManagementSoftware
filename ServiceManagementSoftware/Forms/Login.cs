using Newtonsoft.Json;
using ServiceManagementSoftware.Components;
using ServiceManagementSoftware.Helpers;
using ServiceManagementSoftware.Model;
using ServiceManagementSoftware.Shared;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using d = DataAccess;
using fn = ServiceManagementSoftware.Shared.Functions;
using va = ServiceManagementSoftware.Shared.Variables;

namespace ServiceManagementSoftware.Forms
{
    public partial class Login : ShadowForm
    {
        public Login()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            fn.ChangeLang(this);

            SetupControls();
            LoadUserInfo();
        }

        #region "Functions"

        private void SetupControls()
        {
            fn.SetTextboxHint(txtUserId, "User Id");
            fn.SetTextboxHint(txtPwd, "Password");
        }

        private void LoadUserInfo()
        {
            var info = fn.GetRegistryValue(RegistryId.UserInfo);
            if (info == null) return;

            var userInfo = JsonConvert.DeserializeObject<UserInfo>(info.ToString());
            if (userInfo.remember)
            {
                txtUserId.Text = userInfo.userId;
                txtPwd.Text = Encoding.ASCII.GetString(userInfo.rPwd);
                chkRme.Checked = userInfo.remember;
                btnLogIn.Select();
            }
        }

        #endregion

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string pwd = Encryptor.Encrypt(txtPwd.Text);
            var user = d.AppUser.Get(txtUserId.Text, pwd);

            if (user != null)
            {
                va.CurrentUser = new UserInfo
                {
                    userId = user.userId,
                    rPwd = Encoding.ASCII.GetBytes(txtPwd.Text),
                    userName = user.userName,
                    userLevel = user.userLevel,
                    remember = chkRme.Checked
                };

                va.Permissions = d.AppPermission.Get(va.CurrentUser.userId).ToList();

                fn.SetRegistryValue(RegistryId.UserInfo, 
                    JsonConvert.SerializeObject(va.CurrentUser));

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(
                    "Invalid user Id or password !", Text, 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtUserId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPwd.Focus();
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogIn.PerformClick();
        }

        private void chkRme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogIn.PerformClick();
        }
    }
}
