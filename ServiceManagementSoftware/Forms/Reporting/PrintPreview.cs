using Microsoft.Reporting.WinForms;
using ServiceManagementSoftware.Model;
using System.Windows.Forms;

namespace ServiceManagementSoftware.Forms.Reporting
{
    public partial class PrintPreview : Form
    {
        LocalReport report;

        public PrintPreview(LocalReport localReport)
        {
            report = localReport ?? new LocalReport();

            InitializeComponent();

            SetupReport();
        }

        private void SetupReport()
        {
            rpv.ProcessingMode = ProcessingMode.Local;
            var localReport = rpv.LocalReport;
            localReport.ReportPath = report.ReportPath;

            foreach (var ds in report.DataSources)
            {
                localReport.DataSources.Add(ds);
            }
            
            rpv.RefreshReport();
        }

        private void PrintPreview_Load(object sender, System.EventArgs e)
        {
            
        }
    }
}
