using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using d = DataAccess;
using m = Model;
using fn = ServiceManagementSoftware.Shared.Functions;

namespace ServiceManagementSoftware.Forms.ReportMenu
{
    public partial class ProfitAndLoss : Form
    {
        const int maxWidth = 500;

        public ProfitAndLoss()
        {
            InitializeComponent();

            SetupControls();
            RefreshData();
            SubscribeEvents();
        }

        #region "Functions"

        private void SetupControls()
        {
            cboPeriod.DataSource = d.Period.Get();
            SetPeriodUserStore();
            CheckCustomPeriod();
        }

        private void RefreshData()
        {
            var period = cboPeriod.SelectedItem as m.Period;
            if (period == null) return;

            if (period.periodId == 4)
            {
                period.startDate = dtpStartDate.Value.Date;
                period.endDate = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1);
            }

            var list = d.Report.GetProfitAndLoss(period);
            BindData(list);   
        }

        private void BindData(List<m.ProfitAndLoss> pList)
        {
            // bind income
            lvwIncome.Items.Clear();
            int width = 150;
            decimal totalInc = 0;
            foreach (var p in pList.FindAll(p => p.type == m.CType.Income))
            {
                int w = TextRenderer.MeasureText(p.name, lvwIncome.Font).Width;
                if (w > width && w <= maxWidth)
                    width = w;

                totalInc += p.amount;
                lvwIncome.Items.Add(new ListViewItem(new string[] { p.name, p.amount.ToString("N0") }));
            }
            colIName.Width = width;
            tblList.ColumnStyles[0].Width = colIName.Width + 3;
            lblTolInc.Text = totalInc.ToString("N0");

            // bind expense
            lvwExpense.Items.Clear();
            decimal totalExp = 0;
            foreach (var p in pList.FindAll(p => p.type == m.CType.Expense))
            {
                totalExp += p.amount;
                lvwExpense.Items.Add(new ListViewItem(new string[] { p.name, p.amount.ToString("N0") }));
            }
            colEName.Width = colIName.Width + colIAmt.Width;
            lblTolExp.Text = totalExp.ToString("N0");

            // net profit and loss
            decimal netAmt = totalInc - totalExp;
            lblNetAmt.Text = netAmt.ToString("N0");
            if (netAmt > 0)
                lblNetAmt.ForeColor = Color.Green;
            else if (netAmt < 0)
                lblNetAmt.ForeColor = Color.Red;
            else
                lblNetAmt.ForeColor = Color.Black;
        }

        private void SetPeriodUserStore()
        {
            var period = fn.GetUserStore<m.Period>(Model.StoreId.PnL_Period);
            if (period == null) return;

            cboPeriod.SelectedValue = period.periodId;
            dtpStartDate.Value = period.startDate;
            dtpEndDate.Value = period.endDate;
        }

        private void CheckCustomPeriod()
        {
            var pId = cboPeriod.SelectedValue as int?;

            dtpStartDate.Enabled = dtpEndDate.Enabled = (pId == 4);
        }

        private void SubscribeEvents()
        {
            cboPeriod.SelectedValueChanged += (sd, er) =>
            {
                var period = cboPeriod.SelectedItem as m.Period;
                if (period == null) return;

                dtpStartDate.Value = period.startDate;
                dtpEndDate.Value = period.endDate;

                CheckCustomPeriod();
                RefreshData();
            };
        }

        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void ProfitAndLoss_FormClosed(object sender, FormClosedEventArgs e)
        {
            var period = cboPeriod.SelectedItem as m.Period;
            if (period.periodId == 4)
            {
                period.startDate = dtpStartDate.Value;
                period.endDate = dtpEndDate.Value;
            }
            fn.SetUserStoreAsync(Model.StoreId.PnL_Period, period);
        }
    }
}
