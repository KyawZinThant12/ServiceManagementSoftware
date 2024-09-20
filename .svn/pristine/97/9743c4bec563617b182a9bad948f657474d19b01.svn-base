using ServiceManagementSoftware.Components;
using System;
using System.Windows.Forms;
using d = DataAccess;
using m = Model;

namespace ServiceManagementSoftware.Forms.SetupMenu
{
    public partial class TaskEntry : ShadowForm
    {
        public int TaskId;
        m.Task task;
        public bool original_active;

        public TaskEntry(m.Task Task_value,bool isLock)
        {
            task = Task_value;
            InitializeComponent();
            if (task != null)
            {
                txtTaskName.Text = task.taskName;
                txtTRemark.Text = task.remark;
                txtTCost.Value = task.cost;
                chk_Inactive.Checked = task.inActive;
                original_active = task.inActive;
            }
            else
                task = new m.Task();
            if (isLock) controlBox1.Locked = true;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            task.taskName = txtTaskName.Text;
            task.remark = txtTRemark.Text;
            task.cost = txtTCost.Value;

            if (string.IsNullOrWhiteSpace(task.taskName))
            {
                MessageBox.Show("Please enter Service Name.");
                txtTaskName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(task.cost.ToString()))
            {
                MessageBox.Show("Please enter Cost");
                txtTCost.Focus();
                return;
            }
            else
            {
                if (task.taskId == 0)
                {
                    task.taskId = d.Task.Insert(task);
                }
                else if (task.taskId != 0)
                {
                    d.Task.Update(task);
                }

                TaskId = task.taskId;

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            task.inActive = original_active;
            DialogResult = DialogResult.Cancel;
        }

        private void chk_active_Click(object sender, EventArgs e)
        {
            if (chk_Inactive.Checked)
            {
                if (MessageBox.Show("Are you sure to InActive this Service ?", "InActive Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    task.inActive = true; // now task is Inactive
                }
                else
                {
                    chk_Inactive.Checked = false;
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure to Active this Service ?", "Active Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    task.inActive = false; // now task is Active
                }
                else chk_Inactive.Checked = true;

            }

        }
    }
}
