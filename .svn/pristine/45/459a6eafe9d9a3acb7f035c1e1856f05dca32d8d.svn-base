using System;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using va = ServiceManagementSoftware.Shared.Variables;
using fn = ServiceManagementSoftware.Shared.Functions;
using ServiceManagementSoftware.Shared;

namespace ServiceManagementSoftware.Forms.OptionsMenu
{
    public partial class PrinterOption : Form
    {
        public PrinterOption()
        {
            InitializeComponent();

            SetupControls();
        }

        #region "Functions"

        private void SetupControls()
        {
            cboPrinter.DataSource = PrinterSettings.InstalledPrinters.Cast<string>().ToList();
            cboPaperSize.DataSource = Enum.GetValues(typeof(Model.PaperSize));

            cboPrinter.Text = va.PrinterInfo.PrinterName;
            cboPaperSize.SelectedItem = va.PrinterInfo.PaperSize;
            numCopy.Value = va.PrinterInfo.Copies;

            cboPrinter.TextChanged += (sd, er) => btnSave.Visible = true;
            cboPaperSize.SelectedValueChanged += (sd, er) => btnSave.Visible = true;
            numCopy.ValueChanged += (sd, er) => btnSave.Visible = true;
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;

            va.PrinterInfo.PrinterName = cboPrinter.Text;
            va.PrinterInfo.PaperSize = (Model.PaperSize)cboPaperSize.SelectedItem;
            va.PrinterInfo.Copies = (int)numCopy.Value;

            fn.SetRegistryValue(RegistryId.PrinterInfo, 
                JsonConvert.SerializeObject(va.PrinterInfo));
        }
    }
}
