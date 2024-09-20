using ServiceManagementSoftware.Components;
using System;
using System.Windows.Forms;
using d = DataAccess;
using m = Model;

namespace ServiceManagementSoftware.Forms.SetupMenu
{
    public partial class ItemEntry : ShadowForm
    {
        public int ItemId;
        m.Charge item;
        public bool original_active ;

        public ItemEntry(m.Charge Item_value, bool isLock)
        {
            item = Item_value;
            InitializeComponent();
            if (item != null)
            {
                txtItemName.Text = item.name;
                txtIPrice.Text = item.price.ToString();
                txtIRemark.Text = item.remark;
                chk_InActive.Checked = item.inActive;
                original_active = item.inActive;
            }
            else
                item = new m.Charge();
            if (isLock)
            {
                ctrBox.Locked = true;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            item.name = txtItemName.Text;
            item.remark = txtIRemark.Text;
            item.price = txtIPrice.Value;

            if (string.IsNullOrWhiteSpace(item.name))
            {
                MessageBox.Show("Please enter Stock Name.");
                txtItemName.Focus();
                return;
            }
            else
            {
                if (item.chargeId == 0)
                {
                    item.chargeId = d.Charge.Insert(item);
                }
                else if (item.chargeId != 0)
                {
                    d.Charge.Update(item);
                }

                ItemId = item.chargeId;

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            item.inActive = original_active;
            DialogResult = DialogResult.Cancel;
        }

        private void chk_active_Click(object sender, EventArgs e)
        {
            if (chk_InActive.Checked)
            {
                if (MessageBox.Show("Are you sure to InActive this stock ?", "InActive Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    item.inActive = true; // now item is Inactive
                }
                else
                {
                    chk_InActive.Checked = false;
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure to Active this item ?", "Active Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    item.inActive = false; // now item is active
                }
                else chk_InActive.Checked = true;

            }

        }
    }
}
