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
    [DefaultEvent("ButtonClick")]
    public partial class DropdownButton : UserControl
    {
        public DropdownButton()
        {
            InitializeComponent();

            btnDropdown.Text = ((char)0x25BC).ToString();
        }

        public Color BackgroundColor
        {
            get { return btnMain.BackColor; }
            set
            {
                btnMain.BackColor
                = btnDropdown.BackColor
                = value;
            }
        }

        public Color TextColor
        {
            get { return btnMain.ForeColor; }
            set
            {
                btnMain.ForeColor
                = btnDropdown.ForeColor
                = value;
            }
        }

        public string ButtonText
        {
            get { return btnMain.Text; }
            set
            {
                btnMain.Text = value;
            }
        }
        
        public ContentAlignment TextAlignment
        {
            get { return btnMain.TextAlign; }
            set { btnMain.TextAlign = value; }
        }

        public event EventHandler ButtonClick;

        private void btnDropdown_Click(object sender, EventArgs e)
        {
            if (ContextMenuStrip == null) return;

            ContextMenuStrip.Show(btnMain, 0, btnMain.Height);
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke(sender, e);
        }
    }
}
