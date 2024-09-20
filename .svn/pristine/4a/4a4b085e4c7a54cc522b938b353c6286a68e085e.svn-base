using ServiceManagementSoftware.Forms.TaskMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using m = Model;
using d = DataAccess;
using fn = ServiceManagementSoftware.Shared.Functions;
using ServiceManagementSoftware.Shared;

namespace ServiceManagementSoftware.Forms.HomeMenu
{
    public partial class Home : Form
    {
        List<m.TaskItemDetail> _pendingTasks;

        public Home()
        {
            InitializeComponent();

            SetUpControls();
            RefreshData();
            SubscribeEvents();
        }

        #region "Functions"

        private void SetUpControls()
        {
            dgvTask.AutoGenerateColumns = false;
            colNo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            fn.SetTextboxHint(txtSearch, "Search ...");

            if (!fn.Permit(FormId.Home).editAllow)
                fn.LockForm(this, true);
        }

        private void RefreshData()
        {
            _pendingTasks = d.TaskItem.GetByStatus(m.TStatus.Pending)
                .OrderByDescending(t => t.priority).ToList();

            dgvTask.DataSource = _pendingTasks;
        }

        private void SubscribeEvents()
        {
            
        }

        #endregion

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            VoucherEntry entry = new VoucherEntry(null);
            entry.ShowDialog();
            RefreshData();
        }

        private void dgvTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colAction.Index)
            {
                cmsConfirm.Show(Cursor.Position);
            }
        }

        private void dgvTask_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var task = dgvTask.Rows[e.RowIndex].DataBoundItem as m.TaskItemDetail;
            if (task == null) return;

            var voucher = d.Voucher.Get(task.vId);

            VoucherEntry entry = new VoucherEntry(voucher);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                RefreshData();

                // select edited task
                //var row = dgvTask.Rows.Cast<DataGridViewRow>()
                //            .FirstOrDefault(r => (r.DataBoundItem as m.TaskItemDetail)?
                //            .taskItemId == task.taskItemId);
                //if (row != null)
                //    row.Selected = true;
            }
        }

        private void mnuConfirm_Click(object sender, EventArgs e)
        {
            var task = dgvTask.CurrentRow?.DataBoundItem as m.TaskItemDetail;
            if (task == null) return;

            try
            {
                long vId = d.TaskItem.FinishTask(task.taskItemId);

                if (vId > 0)
                {
                    var voucher = d.Voucher.Get(vId);
                    VoucherEntry entry = new VoucherEntry(voucher);
                    if (entry.ShowDialog() == DialogResult.OK)
                    {
                        // do something if needed
                    }
                }

                RefreshData();
            }
            catch
            {
                MessageBox.Show("Error occur while updating data.",
                    "Update data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            cmsConfirm.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                var filterList = _pendingTasks.Where(pt =>
                {
                    return
                    pt.taskName?.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || pt.asignee?.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || pt.createAt.ToShortDateString()?.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || pt.dueDate.ToShortDateString()?.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || pt.customerName?.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || pt.priority.ToString()?.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                });
                var list = _pendingTasks.Where(t => 
                t.taskName.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                dgvTask.DataSource = list;
            }
            else
                dgvTask.DataSource = _pendingTasks;
        }

        private void dgvTask_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == colAction.Index)
            {
                fn.PaintButtonImage(e, Properties.Resources._checked);
            }
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            fn.ShowForm<UnfinishedVouchers>();
        }

        private void dgvTask_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex == colAction.Index) return;

            if (e.ColumnIndex == colNo.Index)
                e.Value = e.RowIndex + 1;

            // format row color
            var task = dgvTask.Rows[e.RowIndex].DataBoundItem as m.TaskItemDetail;
            if (task == null) return;

            if (task.dueDate.Date == DateTime.Today)
            {
                e.CellStyle.BackColor
                = e.CellStyle.SelectionBackColor
                = pnlExp2.BackColor;

                e.CellStyle.ForeColor
                = e.CellStyle.SelectionForeColor
                = Color.White;
            }
            else if (task.dueDate < DateTime.Now)
            {
                e.CellStyle.BackColor
                = e.CellStyle.SelectionBackColor
                = pnlExp.BackColor;

                e.CellStyle.ForeColor
                = e.CellStyle.SelectionForeColor
                = Color.White;
            }
        }
    }
}
