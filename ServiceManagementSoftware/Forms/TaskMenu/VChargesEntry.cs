using System;
using System.Windows.Forms;
using ServiceManagementSoftware.Forms.SetupMenu;
using m = Model;
using d = DataAccess;
using fn = ServiceManagementSoftware.Shared.Functions;

namespace ServiceManagementSoftware.Forms.TaskMenu
{
    public partial class VChargesEntry : Form
    {
        public m.VoucherCharge Vcharge;
        bool isLocked = false;

        public VChargesEntry(m.VoucherCharge vCharge, bool locked)
        {
            Vcharge = vCharge;

            InitializeComponent();

            SetUpControls(locked);
            BindData();
            isLocked = locked;
            
            SubscribeEvents();
        }

        #region "Functions"

        private void SetUpControls(bool locked)
        {
            cboCharge.DataSource = d.Charge.Get();

            if (locked)
                fn.LockForm(this, true);
        }

        private void BindData()
        {
            if (Vcharge == null)
            {
                Vcharge = new m.VoucherCharge();
            }
            else
            {
                cboCharge.SelectedValue = Vcharge.chargeId;
                numQty.Value = Vcharge.qty;
                numPrice.Value = Vcharge.price;
                numAmt.Value = Vcharge.amount;
                txtRemark.Text = Vcharge.remark;
            }
        }

        private void SubscribeEvents()
        {
            cboCharge.SelectedValueChanged += (sd, er) =>
            {
                var charge = cboCharge.SelectedItem as m.Charge;
                if (charge == null) return;

                numPrice.Value = charge.price;
            };
        }

        private bool CheckDataValid()
        {
            string wrnMsg = "";

            if (cboCharge.SelectedValue == null)
                wrnMsg = "Please select charge.";

            if (!string.IsNullOrWhiteSpace(wrnMsg))
            {
                MessageBox.Show(wrnMsg, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else
                return true;
        }

        #endregion

        private void btnAddCharge_Click(object sender, EventArgs e)
        {
            ItemEntry entry = new ItemEntry(null,isLocked);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                cboCharge.DataSource = d.Charge.Get();
                cboCharge.SelectedValue = entry.ItemId;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckDataValid())
                return;

            Vcharge.chargeId = (int)cboCharge.SelectedValue;
            Vcharge.charge = cboCharge.SelectedItem as m.Charge;
            Vcharge.qty = numQty.Value;
            Vcharge.price = numPrice.Value;
            Vcharge.amount = numAmt.Value;
            Vcharge.remark = txtRemark.Text;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void numPrice_ValueChanged(object sender, EventArgs e)
        {
            numAmt.Value = numQty.Value * numPrice.Value;
        }
    }
}
