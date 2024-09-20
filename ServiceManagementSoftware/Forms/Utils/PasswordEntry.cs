using System;
using System.Text;
using System.Windows.Forms;
using va = ServiceManagementSoftware.Shared.Variables;

namespace ServiceManagementSoftware.Forms.Utils
{
    public partial class PasswordEntry : Form
    {
        public PasswordEntry()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtPwd.Text != Encoding.ASCII.GetString(va.CurrentUser.rPwd))
            {
                MessageBox.Show("Incorrect password.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtPwd.SelectAll();
                txtPwd.Focus();

                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOk.PerformClick();
        }
    }
}
