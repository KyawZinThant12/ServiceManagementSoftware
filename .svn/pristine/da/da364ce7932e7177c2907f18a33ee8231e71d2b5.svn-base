using ServiceManagementSoftware.Shared;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using d = DataAccess;
using m = Model;
using ServiceManagementSoftware.Components;

namespace ServiceManagementSoftware.Forms.SetupMenu
{
    public partial class PermissionSetup : ShadowForm
    {
        public PermissionSetup()
        {
            InitializeComponent();

            SetupControls();
        }

        #region "Functions"

        private void SetupControls()
        {
            colNo.HeaderCell.Style.Alignment
            = colRNo.HeaderCell.Style.Alignment
            = colView.HeaderCell.Style.Alignment
            = colRView.HeaderCell.Style.Alignment
            = colEdit.HeaderCell.Style.Alignment
            = DataGridViewContentAlignment.MiddleCenter;

            cboUser.DataSource = d.AppUser.Get();

            dgvForm.AutoGenerateColumns = dgvReport.AutoGenerateColumns = false;

            RefreshPermissions();

            cboUser.SelectedValueChanged += cboUser_SelectedValueChanged;
            dgvForm.CellValueChanged += Dgv_CellValueChanged;
            dgvReport.CellValueChanged += Dgv_CellValueChanged;
        }

        private void RefreshPermissions()
        {
            var userId = cboUser.SelectedValue as string;
            if (userId == null) return;

            var permits = d.AppPermission.Get(userId).ToList();
            var forms = permits.FindAll(p => p.formId.StartsWith("fm_"));
            var reports = permits.FindAll(p => p.formId.StartsWith("rp_"));
            var allows = permits.FindAll(p => p.formId.StartsWith("al_"));

            dgvForm.DataSource = forms;
            dgvReport.DataSource = reports;
            BindAllows(allows);

            btnSave.Visible = false;
        }

        private void BindAllows(List<m.AppPermission> permits)
        {
            flpAllow.Controls.Clear();

            foreach (var permit in permits)
            {
                var chk = new CheckBox
                {
                    Text = permit.appForm?.name ?? "N/A",
                    Tag = permit,
                    Checked = permit.viewAllow,
                    AutoSize = true
                };

                chk.CheckedChanged += Chk_CheckedChanged;
                flpAllow.Controls.Add(chk);
                chk.PerformLayout();
            }
        }

        private List<m.AppPermission> GetAllows()
        {
            var allows = new List<m.AppPermission>();

            foreach (CheckBox chk in flpAllow.Controls.OfType<CheckBox>())
            {
                var permit = chk.Tag as m.AppPermission;
                if (permit == null) continue;

                permit.viewAllow = chk.Checked;
                allows.Add(permit);
            }

            return allows;
        }

        private void CheckDependencyPermit(int colIndex, int rowIndex)
        {
            bool pValue = Convert.ToBoolean(dgvForm.Rows[rowIndex].Cells[colIndex].Value);
            if (pValue) return;

            var permit = dgvForm.Rows[rowIndex].DataBoundItem as m.AppPermission;
            if (permit == null) return;

            //if (permit.formId == FormId.Report)
            //{
            //    UpdatePermit(FormId.VCashRec, GetViewValue(colIndex), false);
            //    UpdatePermit(FormId.PopTask, GetViewValue(colIndex), false);
            //    UpdatePermit(FormId.CashByTask, GetViewValue(colIndex), false);

            //    dgvForm.Refresh();
            //}
            //else if (permit.formId == FormId.Setup)
            //{
            //    UpdatePermit(FormId.Customer, GetViewValue(colIndex), false);
            //    UpdatePermit(FormId.Employee, GetViewValue(colIndex), false);
            //    UpdatePermit(FormId.Task, GetViewValue(colIndex), false);
            //    UpdatePermit(FormId.Item, GetViewValue(colIndex), false);
            //    UpdatePermit(FormId.AppUser, GetViewValue(colIndex), false);

            //    dgvForm.Refresh();
            //}
        }

        private bool? GetViewValue(int colIndex)
        {
            if (colIndex == colView.Index)
                return false;
            else
                return null;
        }

        private void UpdatePermit(string formId, bool? viewAllow, bool? editAllow)
        {
            foreach (DataGridViewRow row in dgvForm.Rows)
            {
                var permit = row.DataBoundItem as m.AppPermission;
                if (permit == null) continue;
                if (permit.formId != formId) continue;

                if (viewAllow != null)
                    permit.viewAllow = (bool)viewAllow;
                if (editAllow != null)
                    permit.editAllow = (bool)editAllow;

                return;
            }
        }

        #endregion

        private void cboUser_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshPermissions();
        }

        private void Dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Visible = true;
        }

        private void Chk_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Visible = true;
        }

        //private void dgvPermission_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex < 0) return;

        //    CheckDependencyPermit(e.ColumnIndex, e.RowIndex);
        //    if (e.ColumnIndex == colView.Index)
        //    {
        //        if (!Convert.ToBoolean(dgvForm.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
        //        {
        //            dgvForm.CellValueChanged -= dgvPermission_CellValueChanged;
        //            dgvForm.Rows[e.RowIndex].Cells[colEdit.Index].Value = false;
        //            dgvForm.CellValueChanged += dgvPermission_CellValueChanged;
        //        }
        //    }
        //    else if (e.ColumnIndex == colEdit.Index)
        //    {
        //        if (Convert.ToBoolean(dgvForm.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
        //        {
        //            dgvForm.CellValueChanged -= dgvPermission_CellValueChanged;
        //            dgvForm.Rows[e.RowIndex].Cells[colView.Index].Value = true;
        //            dgvForm.CellValueChanged += dgvPermission_CellValueChanged;
        //        }
        //    }

        //    btnSave.Visible = true;
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = cboUser.SelectedValue as string;
                if (userId == null) return;

                var forms = dgvForm.DataSource as List<m.AppPermission>;
                var reports = dgvReport.DataSource as List<m.AppPermission>;
                var allows = GetAllows();
                if (forms == null || reports == null)
                {
                    MessageBox.Show("Data is not valid !", "Save Permission", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                forms.AddRange(reports);
                forms.AddRange(allows);

                d.AppPermission.Delete(userId);
                d.AppPermission.Insert(forms);

                btnSave.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Error occur while saving data.", "Save Permission", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvForm_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == colNo.Index)
                e.Value = e.RowIndex + 1;
            else if (e.ColumnIndex == colName.Index)
                e.Value = (dgvForm.Rows[e.RowIndex].DataBoundItem as m.AppPermission)
                            ?.appForm?.name;
        }

        private void dgvReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == colNo.Index)
                e.Value = e.RowIndex + 1;
            else if (e.ColumnIndex == colRName.Index)
                e.Value = (dgvReport.Rows[e.RowIndex].DataBoundItem as m.AppPermission)
                            ?.appForm?.name;
        }

        private void dgvForm_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvForm.IsCurrentCellDirty)
                dgvForm.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvReport_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvReport.IsCurrentCellDirty)
                dgvReport.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void PermissionSetup_Load(object sender, EventArgs e)
        {
            //RefreshPermissions();

            //cboUser.SelectedValueChanged += cboUser_SelectedValueChanged;
        }
    }
}
