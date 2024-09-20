using ServiceManagementSoftware.Components;
using System;
using System.Windows.Forms;
using d = DataAccess;
using m = Model;

namespace ServiceManagementSoftware.Forms.SetupMenu
{
    public partial class EmployeeEntry : ShadowForm
    {
        public int EmpId;
        m.Employee employee;
        public bool original_active;

        public EmployeeEntry(m.Employee Employee_value,bool isLock)
        {
            employee = Employee_value;
            InitializeComponent();

            if (employee != null)
            {
                txtEName.Text = employee.empName;
                txtEAddress.Text = employee.address;
                txtEPosition.Text = employee.position;
                txtEPhone.Text = employee.phNo;
                txtERemark.Text = employee.remark;
                chk_InActive.Checked = employee.inActive;
                original_active = employee.inActive;
            }
            else
                employee = new m.Employee();
            if (isLock)
            {
                ctrControl.Locked = true;
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            employee.empName = txtEName.Text.ToString();
            employee.address = txtEAddress.Text.ToString();
            employee.position = txtEPosition.Text.ToString();
            employee.phNo = txtEPhone.Text;
            employee.remark = txtERemark.Text;

            if (string.IsNullOrWhiteSpace(employee.empName))
            {
                MessageBox.Show("Please enter Employee Name.");
                txtEName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(employee.position))
            {
                MessageBox.Show("Please enter Position");
                txtEPosition.Focus();
                return;
            }
            else
            {
                if (employee.empId == 0)
                {
                    employee.empId = d.Employee.Insert(employee);
                }
                else if (employee.empId != 0)
                {
                    d.Employee.Update(employee);
                }
                EmpId = employee.empId;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            employee.inActive = original_active;
            DialogResult = DialogResult.Cancel;
        }

        private void chk_active_Click(object sender, EventArgs e)
        {
            if (chk_InActive.Checked)
            {
                if (MessageBox.Show("Are you sure to InActive this employee ?", "InActive Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    employee.inActive = true; // now employee is INactive
                }
                else
                {
                    chk_InActive.Checked = false;
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure to Active this employee ?", "Active Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    employee.inActive = false; // now employee is active
                }
                else chk_InActive.Checked = true;

            }

        }
    }
}
