using BankBissinessLayer;
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
    public partial class frmLogin : frmLayout
    {
        public frmLogin():base("Login")
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }
        private void RestFormLogin()
        {
            txtUserName.Clear() ;
            txtPassword.Clear();
            clsGloabal.NumberOfFlaidLogin = 3;
            lblErrorMassage.ResetText();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text)||string.IsNullOrEmpty(txtPassword.Text)||
                string.IsNullOrWhiteSpace(txtUserName.Text)||string.IsNullOrWhiteSpace(txtPassword.Text) )
            {
                lblErrorMassage.Text = "The UserName or Password Is Null!," +
                    " please Enter The UserName And Password Correct";
            }

            else if (clsGloabal.NumberOfFlaidLogin > 0 && !clsUser.Login(txtUserName.Text, txtPassword.Text))
            {
                clsGloabal.NumberOfFlaidLogin--;

                if (clsGloabal.NumberOfFlaidLogin == 0)
                {
                    gbLogin.Enabled = false;
                    lblErrorMassage.Text = "The System Has Locked !";
                }
                else
                {
                    lblErrorMassage.Text = "The UserName And Password Isn't Correct! ," +
                    "You Have " + clsGloabal.NumberOfFlaidLogin + " Try after system Locked ";
                }

            }
            else
            {
                string _UserName=txtUserName.Text;  
                clsGloabal.CurrentUser=clsUser.FindByUserName(_UserName);
                clsLoginUserLog UserLoginLog = new clsLoginUserLog();
                UserLoginLog.UserID = clsGloabal.CurrentUser.ID;
                UserLoginLog.DateLog = DateTime.Now;
               
                    if (UserLoginLog.Save())
                    {
                        MessageBox.Show("Add Login USer " + clsGloabal.CurrentUser.UserName + " UserID : " + UserLoginLog.UserID);
                        RestFormLogin();
                        Form frm = new frmHome();
                        frm.ShowDialog();
                    }

            }
            

        }
    }
}
