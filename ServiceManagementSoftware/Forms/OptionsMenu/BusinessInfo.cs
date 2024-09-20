using System;
using System.Windows.Forms;
using d = DataAccess;
using m = Model;
using va = ServiceManagementSoftware.Shared.Variables;

namespace ServiceManagementSoftware.Forms.OptionsMenu
{
    public partial class BusinessInfo : Form
    {
        public BusinessInfo()
        {
            InitializeComponent();

            LoadBusinessInfo();
        }

        #region "Functions"

        private void LoadBusinessInfo()
        {
            var bInfo = d.BusinessInfo.Get();
            if (bInfo == null)
                return;

            txtName.Text = bInfo.name;
            txtBtype.Text = bInfo.businessType;
            txtPhNo.Text = bInfo.phNo;
            txtEmail.Text = bInfo.email;
            txtAddress.Text = bInfo.address;
        }

        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please fill business name.", "Save business information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtName.Focus();

                return;
            }

            var bInfo = new m.BusinessInfo
            {
                name = txtName.Text,
                businessType = txtBtype.Text,
                phNo = txtPhNo.Text,
                email = txtEmail.Text,
                address = txtAddress.Text
            };

            try
            {
                var exInfo = d.BusinessInfo.Get();
                if (exInfo != null)
                {
                    bInfo.businessId = exInfo.businessId;
                    d.BusinessInfo.Update(bInfo);
                }
                else
                {
                    bInfo.businessId = Guid.NewGuid();
                    d.BusinessInfo.Insert(bInfo);
                }

                va.BusinessInfo = bInfo;

                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Error occur while saving business information", "Save business information",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
