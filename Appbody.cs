using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Digital_Club_Remainder
{
    public partial class Appbody : Form
    {
       
        public Appbody()
        {
            InitializeComponent();
            slideexpanded = true;
            expandslidetext();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Appbody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            Login_timer.Start();
        }

        private void Login_timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity = this.Opacity + 0.025;
            }
            else
            {
                Login_timer.Stop();
            }
        }

        public void expandslidetext()
        {
            cludinfo.Text = "CLUBDETAILS";
            memlist.Text = "MEMBERSLIST";
            men_info.Text = "MEMBERSINFO";
            remainders.Text = "REMAINDERS";
            iconmode.Text = "ICONMODE";
            about.Text = "ABOUT";
            cludinfo.BackgroundImage = null;
            men_info.BackgroundImage = null;
            memlist.BackgroundImage = null;
            remainders.BackgroundImage = null;
            iconmode.BackgroundImage = null;
            about.BackgroundImage = null;
        }

        public void retractslidetext()
        {
            men_info.Text = null;
            memlist.Text = null;
            cludinfo.Text = null;
            remainders.Text = null;
            iconmode.Text = null;
            about.Text = null;
            cludinfo.BackgroundImage=Properties.Resources.blood;
            men_info.BackgroundImage = Properties.Resources.person2;
            memlist.BackgroundImage = Properties.Resources.person;
            remainders.BackgroundImage = Properties.Resources.remainder;
            iconmode.BackgroundImage = Properties.Resources.undo;
            about.BackgroundImage = Properties.Resources.iconfinder_information_faq_help_info_about_3994375;
        }

        bool slideexpanded;
        const int b = 130;
        const int a = 100;



        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

  
        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Iconmode_Click(object sender, EventArgs e)
        {
            if (slideexpanded)
            {
                // retractslidetext();
            }
            Slide_timer.Start();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Slide_timer_Tick(object sender, EventArgs e)
        {
            if (slideexpanded)
            {

                if (slidepanel.Width <= a)
                {
                    slideexpanded = false;
                    Slide_timer.Stop();
                    retractslidetext();
                    this.Refresh();
                }
                slidepanel.Width -= 30;
            }
            else
            {

                if (slidepanel.Width >= b)
                {
                    slideexpanded = true;
                    expandslidetext();
                    Slide_timer.Stop();

                    this.Refresh();
                }
                slidepanel.Width += 30;
            }
        }

        private void Memlist_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(MemberlistUserControl.Instance))
            {
                panel2.Controls.Add(MemberlistUserControl.Instance);
                MemberlistUserControl.Instance.Dock = DockStyle.Fill;
                MemberlistUserControl.Instance.BringToFront();

            }
            else
            {
                MemberlistUserControl.Instance.BringToFront();
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cludinfo_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ClubDetails.Instance))
            {
                panel2.Controls.Add(ClubDetails.Instance);
                ClubDetails.Instance.Dock = DockStyle.Fill;
                ClubDetails.Instance.BringToFront();

            }
            else
            {
                ClubDetails.Instance.BringToFront();
            }
        }

        private void Men_info_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(MemberDetails.Instance))
            {
                panel2.Controls.Add(MemberDetails.Instance);
                MemberDetails.Instance.Dock = DockStyle.Fill;
                MemberDetails.Instance.BringToFront();

            }
            else
            {
                MemberDetails.Instance.BringToFront();
            }
        }

        private void Remainders_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(remainderdetails.Instance))
            {
                panel2.Controls.Add(remainderdetails.Instance);
                remainderdetails.Instance.Dock = DockStyle.Fill;
                remainderdetails.Instance.BringToFront();

            }
            else
            {
                remainderdetails.Instance.BringToFront();
            }
        }

        private void About_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(AbtUserControl.Instance))
            {
                panel2.Controls.Add(AbtUserControl.Instance);
                AbtUserControl.Instance.Dock = DockStyle.Fill;
                AbtUserControl.Instance.BringToFront();

            }
            else
            {
                AbtUserControl.Instance.BringToFront();
            }
        }
    }
}
