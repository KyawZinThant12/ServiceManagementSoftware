using System.Windows.Forms;

namespace ServiceManagementSoftware.Components
{
    public class NoCuesButton : Button
    {
        public NoCuesButton()
        {
            SetStyle(ControlStyles.Selectable, false);
        }

        public void MakeClick()
        {
            SetStyle(ControlStyles.Selectable, true);
            PerformClick();
            SetStyle(ControlStyles.Selectable, false);
        }

        //protected override bool ShowFocusCues
        //{
        //    get
        //    {
        //        return false;
        //    }
        //}
    }
}
