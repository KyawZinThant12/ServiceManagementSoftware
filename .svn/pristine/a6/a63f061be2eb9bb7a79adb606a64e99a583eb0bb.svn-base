using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using d = DataAccess;
using m = Model;
using fn = ServiceManagementSoftware.Shared.Functions;
using System.Drawing;
using ServiceManagementSoftware.Shared;

namespace ServiceManagementSoftware.Forms.SetupMenu
{
    public partial class Item_Main : Form
    {
        BindingList<m.Charge> _Items;
        bool isLocked = false;
        public Item_Main()
        {
            InitializeComponent();
            SetupContols();
            RefreshItems();
        }

        #region "Functions"

        private void SetupContols()
        {
            Itemprice.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Item.AutoGenerateColumns = false;
            fn.SetTextboxHint(txtSearch, "Search Stocks...");
            if (!fn.Permit(FormId.Item).editAllow)
            {
                isLocked = true;
                fn.LockForm(this, isLocked);
            }
        }

        private void RefreshItems()
        {
            if (rdbtn_All.Checked)
            {
                var list = d.Charge.Get();
                _Items = new BindingList<m.Charge>(list.ToList());
            }
            else
            {
                var list = d.Charge.Get(false);
                _Items = new BindingList<m.Charge>(list.ToList());
            }
            
            dgv_Item.DataSource = _Items;
            dgv_Item.Refresh();
            lblItemCount.Text = "Count: " + _Items.Count;
        }

        #endregion

        private void dgv_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Item = dgv_Item.Rows[e.RowIndex].DataBoundItem as m.Charge;

            switch (e.ColumnIndex)
            {
                case 3: // Update
                    ItemEntry Item_entry = new ItemEntry(Item,isLocked);
                    if (Item_entry.ShowDialog() == DialogResult.OK)
                    {
                        RefreshItems();
                    }
                    break;
                case 4: // Delete
                    if (MessageBox.Show(
                    "Are you sure to delete this Stocks ?",
                    "Delete Confirmation",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //var Item = dgv_Item.Rows[e.RowIndex].DataBoundItem as m.Charge;
                        if (Item == null) return;

                        try
                        {
                            d.Charge.Delete(Item.chargeId);
                            _Items.Remove(Item);
                        }
                        catch
                        {
                            MessageBox.Show("Error occur while deleting Stock.",
                                "Delete Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;

                default: break;

            }
        }

        private void dgv_Item_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var Item = dgv_Item.Rows[e.RowIndex].DataBoundItem as m.Charge;
            if (Item == null) return;

            ItemEntry entry = new ItemEntry(Item,isLocked);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                RefreshItems();
            }
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            ItemEntry Item_entry = new ItemEntry(null,isLocked);
            if (Item_entry.ShowDialog() == DialogResult.OK)
            {
                RefreshItems();
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
                var filterList = _Items.Where(c =>
                {
                    return
                    c.name?.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || c.remark?.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                   
                });

                dgv_Item.DataSource = new BindingList<m.Charge>(filterList.ToList());
            }
            else
                dgv_Item.DataSource = _Items;
        }

        private void dgv_Item_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void rdbtn_Active_CheckedChanged(object sender, EventArgs e)
        {
            RefreshItems();
        }

        private void rdbtn_All_CheckedChanged(object sender, EventArgs e)
        {
            RefreshItems();
        }

    }
}
