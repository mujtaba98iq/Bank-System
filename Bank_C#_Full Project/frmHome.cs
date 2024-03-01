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
    public partial class frmHome : frmLayout
    {
        public frmHome():base("Home")
        {
            InitializeComponent();
        }

        bool _checkAccess(int menueNumber,int UserPermissions)
        {
            if (UserPermissions == -1)
                return true;
            if((menueNumber&UserPermissions)==menueNumber)
                return true;

            return false;
        }

        void restHomeForm()
        {
            if(!_checkAccess(1,clsGloabal.CurrentUser.Permissions))
            {
                btnManageClient.Enabled = false;
                btnManageClient.Visible = false;
            }
            if (!_checkAccess(2, clsGloabal.CurrentUser.Permissions) )
            {
                btnTransactions.Enabled = false;
                btnTransactions.Visible = false;
            }
            if (!_checkAccess(4, clsGloabal.CurrentUser.Permissions))
            {
                btnManageUsers.Enabled = false;
                btnManageUsers.Visible = false;
            }
            if (!_checkAccess(8, clsGloabal.CurrentUser.Permissions))
            {
                btnCurrencyExchange.Enabled = false;
                btnCurrencyExchange.Visible = false;
            }
        }


        private void frmHome_Load(object sender, EventArgs e)
        {
            restHomeForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm=new frmManageClients();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm=new frmClientTransactions();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageUsers();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new frmCurrencyExchange();
            frm.ShowDialog();
        }
    }
}
