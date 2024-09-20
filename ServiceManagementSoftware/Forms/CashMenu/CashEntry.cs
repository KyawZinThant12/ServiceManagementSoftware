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

namespace ServiceManagementSoftware.Forms.CashMenu
{
    public partial class CashEntry : Form
    {
        m.Cash _cash;

        public CashEntry(m.Cash cash, m.CType type)
        {
            _cash = cash;

            InitializeComponent();

            SetupControls(type);
            BindData();
            SubscribeEvents();
        }

        #region "Functions"

        private void SetupControls(m.CType type)
        {
            txtTranNo.Text = d.Cash.GenerateCno();
            if (type == m.CType.Expense)
                rdoExpense.Checked = true;

            RefreshAccount();
        }

        private void BindData()
        {
            if (_cash != null)
            {
                txtTranNo.Text = _cash.cNo;
                dtpDate.Value = _cash.cDate;
                if (_cash.type == m.CType.Expense)
                    rdoExpense.Checked = true;
                cboAcc.Text = _cash.accId;
                numAmount.Value = _cash.amount;
                txtRemark.Text = _cash.remark;
            }
            else
            {
                _cash = new m.Cash();
            }
        }

        private void RefreshAccount()
        {
            m.CType type = m.CType.Income;
            if (rdoExpense.Checked)
                type = m.CType.Expense;

            cboAcc.DataSource = d.Cash.GetAccounts(type);
            cboAcc.SelectedIndex = -1;
        }

        private void SubscribeEvents()
        {
            rdoIncome.CheckedChanged += (sd, er) =>
            {
                RefreshAccount();
            };
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboAcc.Text))
            {
                MessageBox.Show("Please select account.", Text, 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _cash.cNo = txtTranNo.Text;
            _cash.cDate = dtpDate.Value;
            _cash.type = rdoIncome.Checked ? m.CType.Income : m.CType.Expense;
            _cash.accId = cboAcc.Text;
            _cash.amount = numAmount.Value;
            _cash.remark = txtRemark.Text;

            try
            {
                if (_cash.cId == 0)
                {
                    _cash.cId = d.Cash.Insert(_cash);
                }
                else
                {
                    d.Cash.Update(_cash);
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Error occur while saving data.", 
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
