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
    public partial class Employee_Main : Form
    {
        BindingList<m.Employee> _Employees;
        bool isLocked=false;
        public Employee_Main()
        {
            InitializeComponent();
            SetupContols();
            RefreshEmployees();
        }

        #region "Functions"

        private void SetupContols()
        {
            dgv_Employee.AutoGenerateColumns = false;
            fn.SetTextboxHint(txtSearch, "Search Employee...");
            if (!fn.Permit(FormId.Employee).editAllow)
            {
                isLocked = true;
                fn.LockForm(this, isLocked);
            }
        }

        private void RefreshEmployees()
        {
            if (rdbtn_All.Checked)
            {
                var list = d.Employee.Get();
                _Employees = new BindingList<m.Employee>(list.ToList());
            } else
            {
                var list = d.Employee.Get(false);
                _Employees = new BindingList<m.Employee>(list.ToList());
            }
            
            dgv_Employee.DataSource = _Employees;
            dgv_Employee.Refresh();
            lblECount.Text = "Count: "+_Employees.Count;
        }

        #endregion


        private void dgv_Employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Employee = dgv_Employee.Rows[e.RowIndex].DataBoundItem as m.Employee;
            switch (e.ColumnIndex)
            {
                case 5: // Update
                    EmployeeEntry Employee_entry = new EmployeeEntry(Employee,isLocked);
                    if (Employee_entry.ShowDialog() == DialogResult.OK)
                    {
                        RefreshEmployees();
                    }
                    break;
                case 6: // Delete
                    if (MessageBox.Show(
                   "Are you sure to delete this Employee ?",
                   "Delete Confirmation",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (Employee == null) return;

                        try
                        {
                            d.Employee.Delete(Employee.empId);
                            _Employees.Remove(Employee);
                        }
                        catch
                        {
                            MessageBox.Show("Error occur while deleting Employee.",
                                "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
             
                default: break;
            }
        }

        private void dgv_Employee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var Employee = dgv_Employee.Rows[e.RowIndex].DataBoundItem as m.Employee;
            if (Employee == null) return;

            EmployeeEntry entry = new EmployeeEntry(Employee,isLocked);
            if (entry.ShowDialog() == DialogResult.OK)
            {
                dgv_Employee.Refresh();
            }
        }

        private void btn_addEmployee_Click(object sender, EventArgs e)
        {
            EmployeeEntry Employee_entry = new EmployeeEntry(null,isLocked);
            if (Employee_entry.ShowDialog() == DialogResult.OK)
            {
                RefreshEmployees();
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
                var filterList = _Employees.Where(c =>
                {
                    return
                    c.empName?.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || c.address?.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0
                    || c.position?.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                });

                dgv_Employee.DataSource = new BindingList<m.Employee>(filterList.ToList());
            }
            else
                dgv_Employee.DataSource = _Employees;
        }

        private void dgv_Employee_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
            RefreshEmployees();
        }

        private void rdbtn_All_CheckedChanged(object sender, EventArgs e)
        {
            RefreshEmployees();
        }
    }
}
