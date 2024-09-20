using System.Windows.Forms;

namespace ServiceManagementSoftware.Components
{
    public partial class FormTitle : UserControl
    {
        public FormTitle()
        {
            InitializeComponent();
        }

        public string Title
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }
    }
}
