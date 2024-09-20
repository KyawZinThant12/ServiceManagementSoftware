using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ServiceManagementSoftware.Shared;
using d = DataAccess;
using m = Model;
using fn = ServiceManagementSoftware.Shared.Functions;

namespace ServiceManagementSoftware.Forms.SetupMenu
{
    public partial class AppUser_Main : Form
    {
        BindingList<m.AppUser> _AppUser;
        bool isLock;

        public AppUser_Main()
        {
            InitializeComponent();
            SetupContols();
            RefreshAppUser();
        }

        #region "Functions"

        private void SetupContols()
        {
            dgv_appUser.AutoGenerateColumns = false;
            fn.SetTextboxHint(txtSearch, "Search app User...");

            if (!fn.Permit(FormId.AppUser).editAllow)
            {
                isLock = true;
                fn.LockForm(this, isLock);
            }
        }

        private void RefreshAppUser()
        {
            if (rdbtn_all.Checked)
            {
                var list = d.AppUser.Get();
                _AppUser = new BindingList<m.AppUser>(list.ToList());
            }
            else
            {
                var list = d.AppUser.Get(false);
                _AppUser = new BindingList<m.AppUser>(list.ToList());
            }


            dgv_appUser.DataSource = _AppUser;
            dgv_appUser.Refresh();
            lblUsersCount.Text = "Count: " + _AppUser.Count;
        }

        #endregion

        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var appUser = dgv_appUser.Rows[e.RowIndex].DataBoundItem as m.AppUser;
            switch (e.ColumnIndex)
            {
                case 3: // Update               
                    AppUserEntry AppUser_entry = new AppUserEntry(appUser, isLock);
                    if (AppUser_entry.ShowDialog() == DialogResult.OK)
                    {
                        RefreshAppUser();
                    }
                    
                    break;
                case 4: // Delete
                    if (MessageBox.Show(
                    "Are you sure to delete this AppUser ?",
                    "Delete Confirmation",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (appUser == null) return;
                        try
                        {
                            d.AppUser.Delete(appUser.userId);
                            _AppUser.Remove(appUser);
                        }
                        catch
                        {
                            MessageBox.Show("Error occur while deleting AppUser.",
                                "Delete AppUser", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
              
                default: break;

            }


        }

        private void dgv_customer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var AppUser = dgv_appUser.Rows[e.RowIndex].DataBoundItem as m.AppUser;
            if (AppUser == null) return;

            AppUserEntry entry = new AppUserEntry(AppUser, isLock);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                dgv_appUser.Refresh();
            }
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            AppUserEntry AppUser_entry = new AppUserEntry(null, false);
            if (AppUser_entry.ShowDialog() == DialogResult.OK)
            {
                RefreshAppUser();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fn.ShowForm<SetUpOptions>();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                var filterList = _AppUser.Where(c =>
                {
                    return
                    c.userName.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || c.pwd.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                    //|| c.userLevel.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                });

                dgv_appUser.DataSource = new BindingList<m.AppUser>(filterList.ToList());
            }
            else
                dgv_appUser.DataSource = _AppUser;
        }

        private void dgv_customer_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == colUpdate.Index)
            {
                fn.PaintButtonImage(e, Properties.Resources.edit);
            }
            if (e.ColumnIndex == colDelete.Index)
            {
                fn.PaintButtonImage(e, Properties.Resources.delete);
            }

            //if (e.ColumnIndex == colActive.Index)
            //{
            //    fn.PaintButtonImage(e, Properties.Resources.check_mark);
            //}

        }

        private void rdbtn_all_CheckedChanged(object sender, EventArgs e)
        {
            RefreshAppUser();

        }

        private void rdbtn_active_CheckedChanged(object sender, EventArgs e)
        {
            RefreshAppUser();

        }

        private void btnPermit_Click(object sender, EventArgs e)
        {
            PermissionSetup setup = new PermissionSetup();
            setup.ShowDialog();
        }
    }
}
