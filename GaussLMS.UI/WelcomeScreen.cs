using System;
using System.Windows.Forms;

namespace GaussLMS.UI
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }
        Timer tmr;
        private void WelcomeScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            //set time interval 3 sec
            tmr.Interval = 3000;
            //starts the timer
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            //after 3 sec stop the timer
            tmr.Stop();
            //display mainform
            MainMDIForm mf = new MainMDIForm();
            mf.Show();
            //hide this form
            this.Hide();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            tmr_Tick(sender,e);
        }
    }
}
