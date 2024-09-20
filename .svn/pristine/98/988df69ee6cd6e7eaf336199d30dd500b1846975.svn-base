using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using d = DataAccess;
using m = Model;
using fn = ServiceManagementSoftware.Shared.Functions;
using ServiceManagementSoftware.Components;
using System.Drawing;
using ServiceManagementSoftware.Shared;

namespace ServiceManagementSoftware.Forms.SetupMenu
{
    public partial class Customer_Main : Form
    {
        BindingList<m.Customer> _customers;
        bool isLocked=false;
        public Customer_Main()
        {
            InitializeComponent();
            SetupContols();
            RefreshCustomers();
        }

        #region "Functions"

        private void SetupContols()
        {
            dgv_customer.AutoGenerateColumns = false;
            fn.SetTextboxHint(txtSearch, "Search customer...");
            if (!fn.Permit(FormId.Customer).editAllow)
            {
                isLocked = true;
                fn.LockForm(this, isLocked);
            }
        }

        private void RefreshCustomers()
        {
            if (rdbtn_all.Checked)
            {
                var list = d.Customer.Get();
                _customers = new BindingList<m.Customer>(list.ToList());
            }
            else
            {
                var list = d.Customer.Get(false); // Active Customer 
                _customers = new BindingList<m.Customer>(list.ToList());
            }
            dgv_customer.DataSource = _customers;
            dgv_customer.Refresh();
            lblCount.Text = "Count : " + _customers.Count;
            
        }

        #endregion

        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var customer = dgv_customer.Rows[e.RowIndex].DataBoundItem as m.Customer;
            switch (e.ColumnIndex)
            {
                case 5: // Update               
                    CustomerEntry customer_entry = new CustomerEntry(customer,isLocked);
                    if (customer_entry.ShowDialog() == DialogResult.OK)
                    {
                        RefreshCustomers();
                    }     
                    break;
                case 6: // Delete
                    if (MessageBox.Show(
                    "Are you sure to delete this customer ?",
                    "Delete Confirmation",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (customer == null) return;
                        try
                        {
                            d.Customer.Delete(customer.customerId);
                            _customers.Remove(customer);
                        }
                        catch
                        {
                            MessageBox.Show("Error occur while deleting customer.",
                                "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
              
                default: break;

            }
        }

        private void dgv_customer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var customer = dgv_customer.Rows[e.RowIndex].DataBoundItem as m.Customer;
            if (customer == null) return;

            CustomerEntry entry = new CustomerEntry(customer,isLocked);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                RefreshCustomers();
            }
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            CustomerEntry customer_entry = new CustomerEntry(null,isLocked);
            if (customer_entry.ShowDialog() == DialogResult.OK)
            {
                RefreshCustomers();
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
                var filterList = _customers.Where(c =>
                {
                    return
                    c.customerName.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || c.address.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || c.phNo.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                });

                dgv_customer.DataSource = new BindingList<m.Customer>(filterList.ToList());
            }
            else
                dgv_customer.DataSource = _customers;
        }

        #region "Update/Delete Icon
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        }

        #endregion

        #region "Radio Checked/Unchecked"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbtn_all_CheckedChanged(object sender, EventArgs e)
        {
            RefreshCustomers();
        }

        private void rdbtn_active_CheckedChanged(object sender, EventArgs e)
        {
            RefreshCustomers();
        }
        #endregion
    }
}
