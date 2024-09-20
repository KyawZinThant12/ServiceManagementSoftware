using ServiceManagementSoftware.Components;
using System;
using System.Windows.Forms;

namespace ServiceManagementSoftware.Forms.TaskMenu
{
    public partial class DateEntry : ShadowForm
    {
        public DateTime SelectedDate;

        public DateEntry()
        {
            InitializeComponent();
        }

        private void DateEntry_Load(object sender, EventArgs e)
        {
            dtp.Value = SelectedDate;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SelectedDate = dtp.Value;

            DialogResult = DialogResult.OK;
        }

        private void DateEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                DialogResult = DialogResult.Cancel;
        }
    }
}
