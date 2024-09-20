using System.Windows.Forms;

namespace ServiceManagementSoftware.Components
{
    public partial class BorderLabel : UserControl
    {
        public BorderLabel()
        {
            InitializeComponent();
        }

        public string Label
        {
            get
            {
                return lblLabel.Text;
            }
            set
            {
                lblLabel.Text = value;
            }
        }

        public bool StartBorder
        {
            get
            {
                return pnlStart.Visible;
            }
            set
            {
                pnlStart.Visible = value;
            }
        }

        public bool BottomBorder
        {
            get
            {
                return pnlBottom.Visible;
            }
            set
            {
                pnlBottom.Visible = value;
            }
        }
    }
}
