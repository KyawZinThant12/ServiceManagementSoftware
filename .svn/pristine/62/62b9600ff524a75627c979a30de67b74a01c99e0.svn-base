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
using va = ServiceManagementSoftware.Shared.Variables;
using fn = ServiceManagementSoftware.Shared.Functions;

namespace ServiceManagementSoftware.Forms.OptionsMenu
{
    public partial class GeneralOptions : Form
    {
        List<m.OptionId> changedOpts;

        public GeneralOptions()
        {
            InitializeComponent();

            changedOpts = new List<m.OptionId>();
            SetupControls();
            LoadOptionValues();
            SubscribeEvents();
        }

        #region "Functions"

        private void SetupControls()
        {
            btnSave.Visible = false;
        }

        private void SubscribeEvents()
        {
            // lang & font
            rdoLangEn.CheckedChanged += RdoLangAndFont_CheckedChanged;
            rdoLangMz.CheckedChanged += RdoLangAndFont_CheckedChanged;
            rdoLangMu.CheckedChanged += RdoLangAndFont_CheckedChanged;
            rdoFontMz.CheckedChanged += RdoLangAndFont_CheckedChanged;
            rdoFontMu.CheckedChanged += RdoLangAndFont_CheckedChanged;
        }

        private void LoadOptionValues()
        {
            // lang & font
            // 0 = En, 1 = Mz, 2 = Mu
            string lang = va.Options.Find(o => o.optionId == m.OptionId.Language)?.value;
            switch (lang)
            {
                case "1":
                    rdoLangMz.Checked = true;
                    break;
                case "2":
                    rdoLangMu.Checked = true;
                    break;
                default:
                    rdoLangEn.Checked = true;
                    break;
            }
            // 0 = Mz, 1 = Mu
            string font = va.Options.Find(o => o.optionId == m.OptionId.Font)?.value;
            if (font == "Mu")
                rdoFontMu.Checked = true;
            else
                rdoFontMz.Checked = true;
        }

        #endregion

        private void RdoLangAndFont_CheckedChanged(object sender, EventArgs e)
        {
            // 'language' assume 'language & font'
            if (changedOpts.Contains(m.OptionId.Language))
                return;

            changedOpts.Add(m.OptionId.Language);
            btnSave.Visible = true;
        }

        private void btnBusiness_Click(object sender, EventArgs e)
        {
            BusinessInfo info = new BusinessInfo();
            if (info.ShowDialog() != DialogResult.OK)
                return;

            var mainForm = ParentForm?.ParentForm as MainForm;
            mainForm?.UpdateBusinessInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool restartRequried = false;

            // save in database
            // save lang & font
            if (changedOpts.Contains(m.OptionId.Language))
            {
                string selectedLang;
                if (rdoLangMz.Checked)
                    selectedLang = "1";
                else if (rdoLangMu.Checked)
                    selectedLang = "2";
                else
                    selectedLang = "0";

                string selectedFont;
                if (rdoFontMu.Checked)
                    selectedFont = "1";
                else
                    selectedFont = "0";

                try
                {
                    d.AppOption.Update(m.OptionId.Language, selectedLang);
                    d.AppOption.Update(m.OptionId.Font, selectedFont);
                    restartRequried = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error occur while saving language and font option.",
                        "Save option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btnSave.Visible = false;

            if (restartRequried)
            {
                MessageBox.Show("Application need to restart to affect changes.",
                    "Options", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fn.RestartApplication();
            }
        }
    }
}
