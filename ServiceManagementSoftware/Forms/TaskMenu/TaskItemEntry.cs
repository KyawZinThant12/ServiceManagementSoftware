using ServiceManagementSoftware.Components;
using ServiceManagementSoftware.Forms.SetupMenu;
using System;
using System.Linq;
using System.Windows.Forms;
using d = DataAccess;
using fn = ServiceManagementSoftware.Shared.Functions;
using m = Model;

namespace ServiceManagementSoftware.Forms.TaskMenu
{
    public partial class TaskItemEntry : ShadowForm
    {
        public m.TaskItem TItem;
        int sEmpId;
        bool isLocked;

        public TaskItemEntry(m.TaskItem taskItem, bool locked, int selectedEmpId = 0)
        {
            TItem = taskItem;
            sEmpId = selectedEmpId;

            InitializeComponent();

            SetUpControls(locked);
            BindData();
            SubscribeEvent();
        }

        #region "Functions"

        private void SetUpControls(bool locked)
        {
            cboTask.DataSource = d.Task.Get();

            var employees = d.Employee.Get().ToList();
            employees.Insert(0, new m.Employee
            {
                empId = 0,
                empName = "None"
            });
            cboAsignee.DataSource = employees;

            cboPriority.DataSource = Enum.GetValues(typeof(m.Priority));
            
            cboPriority.SelectedIndex = 0;

            if (locked)
                fn.LockForm(this, true);
        }

        private void BindData()
        {
            if (TItem != null)
            {
                cboTask.SelectedValue = TItem.taskId;
                numQty.Value = TItem.qty;
                numCost.Value = TItem.cost;
                numAmount.Value = TItem.amount;
                cboAsignee.SelectedValue = TItem.empId != null ? TItem.empId : 0;
                cboPriority.SelectedItem = TItem.priority;

                if (TItem.status == m.TStatus.Finish)
                    cboTask.Enabled = btnAddTask.Enabled = numQty.Enabled = false;
            }
            else
            {
                TItem = new m.TaskItem();
                cboAsignee.SelectedValue = sEmpId;
                cboTask.SelectedValue = 0;
            }
        }

        private void SubscribeEvent()
        {
            cboTask.SelectedValueChanged += (sd, er) =>
            {
                if (cboTask.SelectedValue == null)
                    return;

                numCost.Value = (cboTask.SelectedItem as m.Task)?.cost ?? 0;
            };
        }

        private string CheckUserInputDataValid()
        {
            if (cboTask.SelectedValue == null)
                return "Please select task.";

            return null;
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string wrnMsg = CheckUserInputDataValid();
            if (!string.IsNullOrWhiteSpace(wrnMsg))
            {
                MessageBox.Show(wrnMsg, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TItem.taskId = (int)cboTask.SelectedValue;
            TItem.task = cboTask.SelectedItem as m.Task;
            TItem.qty = numQty.Value;
            TItem.cost = numCost.Value;
            TItem.amount = numAmount.Value;
            TItem.createAt = DateTime.Now;
            var eId = cboAsignee.SelectedValue as int?;
            TItem.empId = eId != 0 ? eId : null;
            TItem.priority = (m.Priority)cboPriority.SelectedItem;

            if (TItem.status != m.TStatus.Finish)
                TItem.status = m.TStatus.Pending;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            numAmount.Value = numQty.Value * numCost.Value;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            TaskEntry entry = new TaskEntry(null,false);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                cboTask.DataSource = d.Task.Get();
                cboTask.SelectedValue = entry.TaskId;
            }
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            EmployeeEntry entry = new EmployeeEntry(null,isLocked);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                cboAsignee.DataSource = d.Employee.Get();
                cboAsignee.SelectedValue = entry.EmpId;
            }
        }

        private void cboAsignee_Leave(object sender, EventArgs e)
        {
            if (cboAsignee.SelectedValue == null)
                cboAsignee.SelectedValue = 0;
        }
    }
}
