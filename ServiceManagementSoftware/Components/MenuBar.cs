using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceManagementSoftware.Components
{
    public partial class MenuBar : UserControl
    {
        public EventHandler HomeButtonClick;
        public EventHandler ReportButtonClick;
        public EventHandler TaskButtonClick;
        public EventHandler CashButtonClick;
        public EventHandler SetupButtonClick;
        public EventHandler SettingsButtonClick;

        int menuItemHeight = 70;
        public int MenuItemHeight
        {
            get { return menuItemHeight; }
            set
            {
                menuItemHeight = value;
                foreach (Button btn in tblMain.Controls)
                {
                    if (btn == null) continue;

                    btn.Height = value;
                }
            }
        }


        public MenuBar()
        {
            InitializeComponent();
        }

        #region "Functions

        private void SetAsActive(Button activeButton)
        {
            activeButton.BackColor = Properties.Settings.Default.ThemeActiveColor;
            foreach (var ctrl in tblMain.Controls)
	        {
                Button btn = ctrl as Button;
		        if (btn != null && btn != activeButton)
                {
                    btn.BackColor = pnlMain.BackColor;
                }
	        }
        }

        #endregion

        private void btnHome_Click(object sender, EventArgs e)
        {
            SetAsActive(sender as Button);

            HomeButtonClick?.Invoke(sender, e);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            SetAsActive(sender as Button);

            ReportButtonClick?.Invoke(sender, e);
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            SetAsActive(sender as Button);

            TaskButtonClick?.Invoke(sender, e);
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            SetAsActive(sender as Button);

            CashButtonClick?.Invoke(sender, e);
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            SetAsActive(sender as Button);

            SetupButtonClick?.Invoke(sender, e);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SetAsActive(sender as Button);

            SettingsButtonClick?.Invoke(sender, e);
        }

        protected override bool ProcessTabKey(bool forward)
        {
            return SelectNextControl(ActiveControl, true, true, true, true);
            //return base.ProcessTabKey(forward);
        }
    }
}
