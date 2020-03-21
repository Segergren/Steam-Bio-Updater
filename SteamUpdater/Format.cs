using System;
using System.Drawing;
using System.Windows.Forms;

namespace SteamCoronaUpdater
{
    public partial class Format : Form
    {
        public Format()
        {
            InitializeComponent();
        }
        /* Move window */
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        /* END move window */

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Format_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(185, 59, 212), 1), new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1)));
        }

        private void Format_MouseDown(object sender, MouseEventArgs e)
        {
            //Makes it possible for the user to move the window
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Formatbx_MouseDown(object sender, MouseEventArgs e)
        {
            //Makes it possible for the user to move the window
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Formatlbl_MouseDown(object sender, MouseEventArgs e)
        {
            //Makes it possible for the user to move the window
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
