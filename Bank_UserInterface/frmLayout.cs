using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_C__Full_Project
{
    public partial class frmLayout : Form
    {

        private frmLayout()
        {
           
        }

        public frmLayout(string Text)
        {
            InitializeComponent();
            this.Text = Text;
            if (!String.IsNullOrEmpty(clsGloabal.CurrentUser.UserName))
                lblWelcome.Text = "Welcome: " + clsGloabal.CurrentUser.UserName.ToUpper();

        }

        private void lnkMujtabaIbrahim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            lnkMujtabaIbrahim.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/mujtaba-ibrahim-670229280/");
        }

        private void FrmLayout_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            timer1.Start();
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM yyyy");
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
            lblSup.Text = DateTime.Now.ToString("tt"); //AM PM
        }
      

        private void pnlSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM yyyy");
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
            lblSup.Text = DateTime.Now.ToString("tt");

            timer1.Start();
        }
    }
}
