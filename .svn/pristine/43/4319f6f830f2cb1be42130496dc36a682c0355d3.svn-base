using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using d = DataAccess;
using m = Model;
using fn = ServiceManagementSoftware.Shared.Functions;
using ServiceManagementSoftware.Shared;

namespace ServiceManagementSoftware.Forms.SetupMenu
{
    public partial class Task_Main : Form
    {
        BindingList<m.Task> _Tasks;
        bool isLocked = false;
        public Task_Main()
        {
            InitializeComponent();

            SetupContols();
            RefreshTasks();
        }

        #region "Functions"

        private void SetupContols()
        {
            TCost.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Task.AutoGenerateColumns = false;
            fn.SetTextboxHint(txtSearch, "Search Servies...");
            if (!fn.Permit(FormId.Task).editAllow)
            {
                isLocked = true;
                fn.LockForm(this, isLocked);
            }
        }

        private void RefreshTasks()
        {
            if (rdbtn_All.Checked)
            {
                var list = d.Task.Get();
                _Tasks = new BindingList<m.Task>(list.ToList());
            }
            else
            {
                var list = d.Task.Get(false);
                _Tasks = new BindingList<m.Task>(list.ToList());
            }
           
            dgv_Task.DataSource = _Tasks;
            dgv_Task.Refresh();
            lblTaskCount.Text = "Count: " + _Tasks.Count;
        }

        #endregion

        private void dgv_Task_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Task = dgv_Task.Rows[e.RowIndex].DataBoundItem as m.Task;

            switch (e.ColumnIndex)
            {
                case 3: // Update
                    TaskEntry Task_entry = new TaskEntry(Task,isLocked);
                    if (Task_entry.ShowDialog() == DialogResult.OK)
                    {
                        RefreshTasks();
                    }
                    break;
                case 4: // Delete
                    if (MessageBox.Show(
                   "Are you sure to delete this Task ?",
                   "Delete Confirmation",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //var Task = dgv_Task.Rows[e.RowIndex].DataBoundItem as m.Task;
                        if (Task == null) return;

                        try
                        {
                            d.Task.Delete(Task.taskId);
                            _Tasks.Remove(Task);
                        }
                        catch
                        {
                            MessageBox.Show("Error occur while deleting Task.",
                                "Delete Task", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;

               
                default: break;
            }

        
        }

        private void dgv_Task_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var Task = dgv_Task.Rows[e.RowIndex].DataBoundItem as m.Task;
            if (Task == null) return;

            TaskEntry entry = new TaskEntry(Task,isLocked);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                dgv_Task.Refresh();
            }
        }

        private void btn_addTask_Click(object sender, EventArgs e)
        {
            TaskEntry Task_entry = new TaskEntry(null,false);
            if (Task_entry.ShowDialog() == DialogResult.OK)
            {
                RefreshTasks();
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
                var filterList = _Tasks.Where(c =>
                {
                    return
                    c.taskName.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || c.remark.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || c.cost.ToString().IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                   
                });

                dgv_Task.DataSource = new BindingList<m.Task>(filterList.ToList());
            }
            else
                dgv_Task.DataSource = _Tasks;
        }

        private void dgv_Task_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void rdbtn_active_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTasks();
        }

        private void rdbtn_All_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTasks();
        }

    }
}
