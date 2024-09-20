using ServiceManagementSoftware.Components;
using System;
using System.Drawing;
using System.Windows.Forms;
using d = DataAccess;
using fn = ServiceManagementSoftware.Shared.Functions;
using va = ServiceManagementSoftware.Shared.Variables;
using m = Model;
using ServiceManagementSoftware.Shared;

namespace ServiceManagementSoftware.Forms.SetupMenu
{
    public partial class AppUserEntry : ShadowForm
    {
        public int appUserId;
        m.AppUser AppUser;
        public bool original_active;
        bool isNew;
        int oHeight;
        
        public AppUserEntry(m.AppUser appUser, bool isLock)
        {
            AppUser = appUser;
           
            InitializeComponent();

            oHeight = this.Height;
            //Size = new Size(Width, Height - btnChangePwd.Height);
            cboUserLevel.DataSource = Enum.GetValues(typeof(m.UserLevel));
            
            if (AppUser != null)
            {
                txtUserId.Text = AppUser.userId;
                txtUserName.Text = AppUser.userName;
                cboUserLevel.SelectedItem = AppUser.userLevel;
                chk_active.Checked = AppUser.inActive;
                original_active = AppUser.inActive;

                txtUserId.ReadOnly = true;
                ChangePasswordVisible(false);
            }
            else
            {
                isNew = true;
                btnChangePwd.Visible = false;
                AppUser = new m.AppUser();
            }

            if (isLock)
                ctrControl.Locked = true;
        }

        #region "Functions"

        private void ChangePasswordVisible(bool isVisible)
        {
            lblPassword.Visible
            = txtPassword.Visible
            = lblConfirmPwd.Visible
            = txtConfirmPwd.Visible
            = isVisible;

            Size = new Size(Width, isVisible ? oHeight : oHeight -138);
            this.CenterToParent();
        }

        private string CheckDataValid()
        {
            if (string.IsNullOrWhiteSpace(txtUserId.Text))
            {
                txtUserId.Focus();
                return "Please fill User Id.";
            }
            else if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.Focus();
                return "Please fill User Name.";
            }
            else if (cboUserLevel.SelectedItem == null)
            {
                cboUserLevel.Focus();
                return "Please select User Level.";
            }

            if (isNew)
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    txtPassword.Focus();
                    return "Please fill Password.";
                }
                else if (string.IsNullOrWhiteSpace(txtConfirmPwd.Text))
                {
                    txtConfirmPwd.Focus();
                    return "Please fill Confirm Password.";
                }
            }

            if (txtPassword.Text != txtConfirmPwd.Text)
            {
                txtPassword.Focus();
                return "Password and Confirm Password must be same.";
            }

            return null;
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AppUser.inActive = original_active;
            DialogResult = DialogResult.Cancel;
        }

        private void chk_active_Click(object sender, EventArgs e)
        {
            if (chk_active.Checked)
            {
                if (MessageBox.Show("Are you sure to InActive this AppUser ?","InActive Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AppUser.inActive = true; // now AppUser is Inactive
                } else
                {
                    chk_active.Checked = false;
                }
            } else
            {
                if (MessageBox.Show("Are you sure to Active this AppUser ?","Active Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AppUser.inActive = false; // now AppUser is active
                }
                else chk_active.Checked = true;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string wrnMsg = CheckDataValid();
            if (!string.IsNullOrWhiteSpace(wrnMsg))
            {
                MessageBox.Show(wrnMsg, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AppUser.userId = txtUserId.Text;
            AppUser.userName = txtUserName.Text;
            AppUser.userLevel = (m.UserLevel)cboUserLevel.SelectedItem;
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                AppUser.pwd = Helpers.Encryptor.Encrypt(txtPassword.Text);

            try
            {
                if (isNew)
                {
                    d.AppUser.Insert(AppUser);
                    d.AppPermission.InsertPermitions(AppUser.userId);
                }
                else
                {
                    d.AppUser.Update(AppUser);
                }

                // if current user info have been changed
                if (AppUser.userId == va.CurrentUser.userId)
                {
                    MessageBox.Show("Application need to restart to affect changes.", Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    fn.DeleteRegistryValue(RegistryId.UserInfo);

                    Application.Restart();

                    return;
                }
                
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Error occur while saving data.", Text, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            btnChangePwd.Visible = false;

            ChangePasswordVisible(true);

            txtPassword.Focus();
            txtPassword.Select();
        }
    }
}
