using System.Windows.Forms;

namespace ServiceManagementSoftware.Components
{
    public class PercentageUpDown : NumericUpDown
    {
        public override void DownButton()
        {
            if (!this.ReadOnly)
                base.DownButton();
        }

        public override void UpButton()
        {
            if (!this.ReadOnly)
                base.UpButton();
        }

        public override string Text
        {
            get
            {
                return base.Text.TrimEnd('%');
            }
            set
            {
                base.Text = Value + "%";
            }
        }

        //[System.ComponentModel.Category("Data")]
        //[System.ComponentModel.DefaultValue(0.0)]
        //public new double Value
        //{
        //    get
        //    {
        //        return (double)base.Value / 100;
        //    }
        //    set
        //    {
        //        base.Value = (decimal)Value * 100;
        //    }
        //}
    }
}
