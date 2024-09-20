using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using fn = ServiceManagementSoftware.Shared.Functions;

namespace ServiceManagementSoftware.Components
{
    public partial class ControlBox : UserControl
    {
        public bool LockButton
        {
            get { return btnLock.Visible; }
            set { btnLock.Visible = value; }
        }

        bool locked;
        public bool Locked
        {
            get { return locked; }
            set
            {
                locked = value;

                if (!LockButton)
                    LockButton = true;

                btnLock.Image = locked ? Properties.Resources.lock_p : Properties.Resources.unlock_p;

                fn.LockForm(ParentForm, locked);
            }
        }

        public EventHandler<LockEventArgs> LockStateChanged;

        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int IParam);
        [DllImport("user32.dll")]
        static extern bool ReleaseCapture();

        public ControlBox()
        {
            InitializeComponent();
            btnLock.Visible = false;
        }

        private void ParentForm_TextChanged(object sender, EventArgs e)
        {
            lblTitle.Text = ParentForm.Text;
        }

        private void tblMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(ParentForm.Handle, 0xA1, 0x2, 0);
            }
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(ParentForm.Handle, 0xA1, 0x2, 0);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (ParentForm != null)
                ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void ControlBox_Load(object sender, EventArgs e)
        {
            lblTitle.Text = ParentForm.Text;
            ParentForm.TextChanged += ParentForm_TextChanged;

            ParentForm.Deactivate += (sd, er) =>
            {
                pnlMain.BackColor = Color.DimGray;
            };

            ParentForm.Activated += (sd, er) =>
            {
                pnlMain.BackColor = Properties.Settings.Default.ControlColor;
            };
        }

        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Clicks >= 2)
            //    return;

            //if (e.Button == MouseButtons.Left)
            //{
            //    ReleaseCapture();
            //    SendMessage(this.Parent.Handle, 0xA1, 0x2, 0);
            //}
        }

        private void pnlMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //var form = this.Parent as Form;
            //if (form != null)
            //{
            //    if (form.WindowState == FormWindowState.Normal)
            //        form.WindowState = FormWindowState.Maximized;
            //    else if (form.WindowState == FormWindowState.Maximized)
            //        form.WindowState = FormWindowState.Normal;
            //}
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            // should not any change control data cause manually handle by caller

            LockStateChanged?.Invoke(sender, new LockEventArgs { Locked = !locked });
        }
    }

    public class LockEventArgs : EventArgs
    {
        public bool Locked { get; set; }
    }
}
