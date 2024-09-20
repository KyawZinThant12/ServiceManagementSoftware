using ServiceManagementSoftware.Shared;
using System;
using System.Windows.Forms;
using fn = ServiceManagementSoftware.Shared.Functions;

namespace ServiceManagementSoftware.Forms.SetupMenu
{
    public partial class SetUpOptions : Form
    {
        public SetUpOptions()
        {
            InitializeComponent();

            CheckUserPermissions();
        }

        private void CheckUserPermissions()
        {
            btnCustomer.Visible = fn.Permit(FormId.Customer).viewAllow;
            btnEmployee.Visible = fn.Permit(FormId.Employee).viewAllow;
            btnTask.Visible = fn.Permit(FormId.Task).viewAllow;
            btnItem.Visible = fn.Permit(FormId.Item).viewAllow;
            btnUser.Visible = fn.Permit(FormId.AppUser).viewAllow;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            fn.ShowForm<Customer_Main>();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            fn.ShowForm<Employee_Main>();
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            fn.ShowForm<Task_Main>();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            fn.ShowForm<Item_Main>();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            fn.ShowForm<AppUser_Main>();
        }
    }
}
