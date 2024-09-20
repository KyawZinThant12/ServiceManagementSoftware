using ServiceManagementSoftware.Components;
using System;
using System.Windows.Forms;
using d = DataAccess;
using m = Model;

namespace ServiceManagementSoftware.Forms.SetupMenu
{
    public partial class CustomerEntry : ShadowForm
    {
        public int CustomerId;
        m.Customer customer;
        public bool original_active;

        #region "Customer Constructor"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer_value"></param>
        /// <param name="isLock"></param>
        public CustomerEntry(m.Customer customer_value,bool isLock)
        {
            customer = customer_value;
           
            InitializeComponent();

            if (customer != null)
            {
                txtCustName.Text = customer.customerName;
                txtCAddress.Text = customer.address;
                txtCPhone.Text = customer.phNo;
                txtCEmail.Text = customer.email;
                txtCRemark.Text = customer.remark;
                chk_CInactive.Checked = customer.inActive;
                original_active = customer.inActive;
            }
            else
                customer = new m.Customer();
            if (isLock) ctrControl.Locked = true;
        }
        #endregion

        #region "Add or Update Customer"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            customer.customerName = txtCustName.Text;
            customer.address = txtCAddress.Text;
            customer.phNo = txtCPhone.Text;
            customer.email = txtCEmail.Text;
            customer.remark = txtCRemark.Text;

            if (string.IsNullOrWhiteSpace(customer.customerName))
            {
                MessageBox.Show("Please enter customer Name.");
                txtCustName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(customer.phNo))
            {
                MessageBox.Show("Please enter phone number");
                txtCPhone.Focus();
                return;
            }
            else
            {
                if (customer.customerId == 0)
                {
                    customer.customerId = d.Customer.Insert(customer);
                }
                else if (customer.customerId != 0)
                {
                    d.Customer.Update(customer);
                }

                CustomerId = customer.customerId;

                DialogResult = DialogResult.OK;
            }
        }
        #endregion

        #region "Cancel Click"
        /// <summary>
        /// When cancel clicked, checked box returned to original
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            customer.inActive = original_active;
            DialogResult = DialogResult.Cancel;
            
        }
        #endregion

        #region "Active Customer"

        // if checked, user is inactive,
        // if not checked, user is active
        private void chk_InActive_Click(object sender, EventArgs e)
        {
            if (chk_CInactive.Checked)
            {
                if (MessageBox.Show("Are you sure to InActive this customer ?","InActive Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    customer.inActive = true; // now Customer is Inactive
                } else
                {
                    chk_CInactive.Checked = false;
                }
            } else
            {
                if (MessageBox.Show("Are you sure to Active this customer ?","Active Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    customer.inActive = false; // now Customer is Active
                }
                else chk_CInactive.Checked = true;

            }

            #endregion

        }
    }
}
