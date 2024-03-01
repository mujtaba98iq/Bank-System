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
using static Bank_C__Full_Project.clsGloabal;

namespace Bank_C__Full_Project
{
    public partial class frmManageUsers : frmLayout
    {
        public frmManageUsers() : base("ManageUsers")
        {
            InitializeComponent();
        }
        clsUser _CurrentUserChosedByComboBox;
        clsPerson _PersonInfoOfCurrentUser;
        int _PermissionsForUpdateUser;
        int _PermissionsForNewUser;
        int _NumberOfUsers;
        void FillListViewWithUsersInfo(string SearchsConditions = "")
        {

            int CounterShowListUser = 0;
            lvShowUser.Items.Clear();
            DataTable dt = clsUser.UsersList();
            _NumberOfUsers = dt.Rows.Count;
            if (SearchsConditions == "")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lvShowUser.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    lvShowUser.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    lvShowUser.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    lvShowUser.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    lvShowUser.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                    lvShowUser.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    lvShowUser.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    lvShowUser.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                    lvShowUser.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                    lvShowUser.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
                    lvShowUser.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                }
            }
            else
            {
                foreach (DataRow dr in dt.Select($"UserName Like '%{SearchsConditions}%'"))
                {

                    lvShowUser.Items.Add(dr["ID"].ToString());
                    lvShowUser.Items[CounterShowListUser].SubItems.Add(dr["UserName"].ToString());
                    lvShowUser.Items[CounterShowListUser].SubItems.Add(dr["FirstName"].ToString());
                    lvShowUser.Items[CounterShowListUser].SubItems.Add(dr["LastName"].ToString());
                    lvShowUser.Items[CounterShowListUser].SubItems.Add(dr["Email"].ToString());
                    lvShowUser.Items[CounterShowListUser].SubItems.Add(dr["Phone"].ToString());
                    lvShowUser.Items[CounterShowListUser].SubItems.Add(dr["Permissions"].ToString());
                    lvShowUser.Items[CounterShowListUser].SubItems.Add(dr["Password"].ToString());
                    lvShowUser.Items[CounterShowListUser].SubItems.Add(dr["Address"].ToString());
                    lvShowUser.Items[CounterShowListUser].SubItems.Add(dr["Gendor"].ToString());
                    lvShowUser.Items[CounterShowListUser].SubItems.Add(dr["DateOfBirth"].ToString());

                    CounterShowListUser++;

                }
            }
        }
        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            restShowUserList();
        }
        void restShowUserList()
        {
            lvShowUser.Items.Clear();
            FillListViewWithUsersInfo();
            lblShowNumberOfUsers.Text = _NumberOfUsers.ToString() + " Client (s)";

        }
        void restAddNewUserForm()
        {
            txtFirstNameForAddNewUser.Clear();
            txtUserNameForAddNewUser.Clear();
            txtLastNameForUserName.Clear();
            txtEmailForUserName.Clear();
            txtPhoneForUserName.Clear();
            txtAddressForUserName.Clear();
            txtPasswordForUserName.Clear();
            txtDateOfBirthForUserName.Clear();
            txtGendorForUserName.Clear();
            rbPermissionsYesForAddUser.Checked=false;
            rbPermissionsNoForAddUser.Checked=false;
            chkManageClientForAddUser.Checked=false;
            chkManageUserForAddUser.Checked=false;
            chkCurrencyExchangeForAddUser.Checked=false;
            chkTransacionsForAddUser.Checked=false;
            ChangeCheckBoxesAddNewUserForPermissions(false);
            grpAddNewUserPermissions.Enabled = false;
            rbPermissionsNoForAddUser.Checked = true;
            _PermissionsForNewUser = 0;
            circularProgressBarAddNewUser.Value = 0;
            circularProgressBarAddNewUser.Text = "0%";
            btnAddNewUser.Enabled = false;
        }

        void FillComboBoxWithUserNames()
        {
            DataTable dt = clsUser.ListForUserNames();
           
            foreach(DataRow dr in dt.Rows)
            {
                cbUserNamesForUpdateUser.Items.Add(dr["UserName"]);
            }
        }

        void restUpdateUserForm()
        {
            cbUserNamesForUpdateUser.Items.Clear();
            txtFirstNameForUpdateUser.Clear();
            txtLastNameForUpdateUser.Clear();
            txtEmailForUpdateUser.Clear();
            txtPhoneForUpdateUser.Clear();
            txtAddressForUpdateUser.Clear();
            txtPasswordForUpdateUser.Clear();
            txtDateOfBirthForUpdateUser.Clear();
            txtGendorForUpdateUser.Clear();
            rbPermissionsYesForUpdateUser.Checked = false;
            rbPermissionsNoForUpdateUser.Checked = false;
            chkManageUsersForUpdateUser.Checked = false;
            chkManageClientForUpdateUser.Checked = false;
            chkClientsTransacionsForUpdateUser.Checked = false;
            chkCurrencyExchangeForUpdateUser.Checked = false;
            ChangeCheckBoxesUpdateUserForPermissions(false);
            grpUpdateUserPermissionsForUser.Enabled = false;

            _PermissionsForUpdateUser = 0;
            btnUpdateUser.Enabled = false;
            FillComboBoxWithUserNames();
        }
        void FillListViewShowLoginUserLog(string SearchsConditions="")
        {
            
            int CounterShowListUser = 0;
            lvSowLoginUserLog.Items.Clear();
            DataTable dt = clsLoginUserLog.ListOfLgoinUserLog();
            _NumberOfUsers = dt.Rows.Count;
            if (SearchsConditions == "")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lvSowLoginUserLog.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    lvSowLoginUserLog.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    lvSowLoginUserLog.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    lvSowLoginUserLog.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    lvSowLoginUserLog.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                    lvSowLoginUserLog.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    lvSowLoginUserLog.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    lvSowLoginUserLog.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                    lvSowLoginUserLog.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                }
            }
            else
            {
                foreach (DataRow dr in dt.Select($"UserName Like '%{SearchsConditions}%'"))
                {

                    lvSowLoginUserLog.Items.Add(dr["ID"].ToString());
                    lvSowLoginUserLog.Items[CounterShowListUser].SubItems.Add(dr["UserName"].ToString());
                    lvSowLoginUserLog.Items[CounterShowListUser].SubItems.Add(dr["Date"].ToString());
                    lvSowLoginUserLog.Items[CounterShowListUser].SubItems.Add(dr["FirstName"].ToString());
                    lvSowLoginUserLog.Items[CounterShowListUser].SubItems.Add(dr["LastName"].ToString());
                    lvSowLoginUserLog.Items[CounterShowListUser].SubItems.Add(dr["Email"].ToString());
                    lvSowLoginUserLog.Items[CounterShowListUser].SubItems.Add(dr["Phone"].ToString());
                    lvSowLoginUserLog.Items[CounterShowListUser].SubItems.Add(dr["Permissions"].ToString());
                    lvSowLoginUserLog.Items[CounterShowListUser].SubItems.Add(dr["Password"].ToString());

                    CounterShowListUser++;

                }
            }
        }
        void restLoginUserLogForm()
        {
            lvSowLoginUserLog.Items.Clear();
            FillListViewShowLoginUserLog();
        }
        void restUserManageForms()
        {
            restShowUserList();
            restAddNewUserForm();
            restUpdateUserForm();
            restLoginUserLogForm();
        }

        private void txtSearchByUserName_TextChanged(object sender, EventArgs e)
        {
            restUserManageForms();

        }

        private void rbSortinAsc_CheckedChanged(object sender, EventArgs e)
        {
            lvShowUser.Sorting = SortOrder.Ascending;
        }

        private void rbSortingDesc_CheckedChanged(object sender, EventArgs e)
        {
            lvShowUser.Sorting = SortOrder.Descending;
        }

        int addNewClientValidFormInputsCount()
        {
            int counter = 0;

            if (!string.IsNullOrWhiteSpace(txtFirstNameForAddNewUser.Text) && !clsClient.IsFoundClientByAccNumber(txtFirstNameForAddNewUser.Text))
                counter++;
            if (!string.IsNullOrWhiteSpace(txtUserNameForAddNewUser.Text))
                counter++;
            if (!string.IsNullOrWhiteSpace(txtLastNameForUserName.Text))
                counter++;
            if (!string.IsNullOrWhiteSpace(txtEmailForUserName.Text) && txtEmailForUserName.Text.Contains("@"))
                counter++;
            if (!string.IsNullOrWhiteSpace(txtPhoneForUserName.Text) && txtPhoneForUserName.Text.All(char.IsDigit))
                counter++;
            if (!string.IsNullOrWhiteSpace(txtAddressForUserName.Text))
                counter++;
            if (!string.IsNullOrWhiteSpace(txtPasswordForUserName.Text))
                counter++;
            if (!string.IsNullOrWhiteSpace(txtGendorForUserName.Text))
                counter++;
            if (!string.IsNullOrWhiteSpace(txtDateOfBirthForUserName.Text))
                counter++;

            return counter;
        }
        private void checkBtnAddNewClientStatus()
        {
            if (circularProgressBarAddNewUser.Value == 9)
            {
                btnAddNewUser.Enabled = true;
                grpAddNewUserPermissions.Enabled = true;
                ChangeCheckBoxesAddNewUserForPermissions(true);
            }

            else
                btnAddNewUser.Enabled = false;
        }

        private void updateProgressBarAddNewClient(int value)
        {
            if (value <= 9)
                circularProgressBarAddNewUser.Value = value;
            circularProgressBarAddNewUser.Text = (((float)circularProgressBarAddNewUser.Value / circularProgressBarAddNewUser.Maximum) * 100).ToString("0") + "%";
            circularProgressBarAddNewUser.ProgressColor = Color.FromArgb(192, 192, 255);
            circularProgressBarAddNewUser.Refresh();

            checkBtnAddNewClientStatus();
        }

        private void validateUserForm(System.Windows.Forms.TextBox textBox, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                clientInfoErrorProvider.SetError(textBox, "required");
            }
            else if (textBox.Name == "txtUserNameForAddNewUser" && clsUser.IsFoundUserByUserName(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                clientInfoErrorProvider.SetError(textBox, "User Name (" + textBox.Text + ") is already used, Choose another one.");
            }
            else if ((textBox.Name == "txtEmailForUserName" || textBox.Name == "txtEmailForUserName") && !textBox.Text.Contains("@"))
            {
                e.Cancel = true;
                textBox.Focus();
                clientInfoErrorProvider.SetError(textBox, "Invalid Email, Include an '@' in the email address");
            }
            else if ((textBox.Name == "txtPhoneForUserName" || textBox.Name == "txtPhoneForUserName") && !textBox.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                textBox.Focus();
                clientInfoErrorProvider.SetError(textBox, "Invalid Phone, Only Numbers Accepted");
            }
            else if ((textBox.Name == "txtDateOfBirthForUserName" || textBox.Name == "txtDateOfBirthForUserName") && String.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                clientInfoErrorProvider.SetError(textBox, "Invalid Date, Only Date Accepted");
            }
            else
            {
                e.Cancel = false;
                clientInfoErrorProvider.SetError(textBox, null);
            }

            updateProgressBarAddNewClient(addNewClientValidFormInputsCount());
        }

        private void validateUserForm(object sender, CancelEventArgs e) => validateUserForm((System.Windows.Forms.TextBox)sender, e);

        private void tabShowUsers_Click(object sender, EventArgs e)
        {

        }
        void ChangeCheckBoxesAddNewUserForPermissions(bool status)
        {
            chkManageUsersForUpdateUser.Enabled = status;
            chkManageUserForAddUser.Enabled = status;
            chkTransacionsForAddUser.Enabled = status;
            chkCurrencyExchangeForAddUser.Enabled = status;
        }

        private void rbAddUserPermissionsNo_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCheckBoxesAddNewUserForPermissions(true);
        }

        private void rbAddUserPermissionsYes_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCheckBoxesAddNewUserForPermissions(false);
            _PermissionsForNewUser = -1;
        }

        private void txtAddressForUserName_TextChanged(object sender, EventArgs e)
        {
            updateProgressBarAddNewClient(addNewClientValidFormInputsCount());
        }

      
        private void GetPermissionsForAddNewUser()
        {
            int CountPermissions = 0;

            if (rbPermissionsNoForAddUser.Checked)
            {
                if (chkManageClientForAddUser.Checked)
                    CountPermissions += 1;
                if (chkManageUserForAddUser.Checked)
                    CountPermissions += 2;

                if (chkTransacionsForAddUser.Checked)
                    CountPermissions += 4;

                if (chkCurrencyExchangeForAddUser.Checked)
                    CountPermissions += 8;

                _PermissionsForNewUser = CountPermissions;
            }
        }

        private void GetPermissionsForUpdateUser()
        {
            int CountPermissions = 0;

            if (rbPermissionsNoForUpdateUser.Checked)
            {
                if (chkManageUsersForUpdateUser.Checked)
                    CountPermissions += 1;
                if (chkManageUsersForUpdateUser.Checked)
                    CountPermissions += 2;

                if (chkClientsTransacionsForUpdateUser.Checked)
                    CountPermissions += 4;

                if (chkCurrencyExchangeForUpdateUser.Checked)
                    CountPermissions += 8;

                _PermissionsForUpdateUser = CountPermissions;
            }
        }
        clsUser FillNewUserWithInfo()
        {
            GetPermissionsForAddNewUser();
            clsUser User = new clsUser();
            User.UserName = txtUserNameForAddNewUser.Text;
            User.Password = txtPasswordForUserName.Text;
            User.Permissions = _PermissionsForNewUser;
            return User;
        }
        clsPerson FillNewPersonWithInfo()
        {
            clsPerson Person = new clsPerson();

            Person.FirstName = txtFirstNameForAddNewUser.Text;
            Person.LasttName = txtLastNameForUserName.Text;
            Person.Email = txtEmailForUserName.Text;
            Person.Phone = txtPhoneForUserName.Text;
            Person.Address = txtAddressForUserName.Text;
            Person.Gendor = txtGendorForUserName.Text;
            if (txtDateOfBirthForUserName.Text != "")
            {
                try
                {
                    Person.DateOfBirth = Convert.ToDateTime(txtDateOfBirthForUserName.Text);

                }
                catch
                {
                    MessageBox.Show("Write Correct Date !");
                    Person.DateOfBirth = DateTime.Now;
                }
            }
            return Person;
        }
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                          "Are you sure to Add Client (" + txtUserNameForAddNewUser.Text + ")?",
                          "Confirm"
                          , MessageBoxButtons.OKCancel,
                          MessageBoxIcon.Question) == DialogResult.OK)
            {
               clsUser  User = FillNewUserWithInfo();
               clsPerson Person1 = FillNewPersonWithInfo();
                if (Person1.Save())
                {
                    User.PersonID = Person1.ID;


                    if (User.Save())
                    {
                        MessageBox.Show("User (" + txtFirstNameForAddNewUser.Text + ") Added Successfully",
                  "Info",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                        restAddNewUserForm();
                    }

                }
            }
        }

        private void tabManageClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            restUserManageForms();
        }

        private void tabUpdateUser_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void FillUpdateUserInfoFromTextBoxes()
        {
            GetPermissionsForUpdateUser();
            _CurrentUserChosedByComboBox.Password = txtPasswordForUpdateUser.Text;
            _CurrentUserChosedByComboBox.Permissions = Convert.ToInt32(_PermissionsForUpdateUser);
        }
        void FillUpdatePersonInfoFromTextBoxes()
        {
            _PersonInfoOfCurrentUser.FirstName = txtFirstNameForUpdateUser.Text;
            _PersonInfoOfCurrentUser.LasttName = txtLastNameForUpdateUser.Text;
            _PersonInfoOfCurrentUser.Email = txtEmailForUpdateUser.Text;
            _PersonInfoOfCurrentUser.Phone = txtPhoneForUpdateUser.Text;
            _PersonInfoOfCurrentUser.Address = txtAddressForUpdateUser.Text;
            _PersonInfoOfCurrentUser.Gendor = txtGendorForUpdateUser.Text;
            _PersonInfoOfCurrentUser.DateOfBirth = Convert.ToDateTime(txtDateOfBirthForUpdateUser.Text);


        }
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(
                        "Are you sure to Update User (" + txtFirstNameForUpdateUser.Text + ")?",
                        "Confirm"
                        , MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.OK))
            {


                FillUpdateUserInfoFromTextBoxes();
                FillUpdatePersonInfoFromTextBoxes();
                if (_CurrentUserChosedByComboBox.Save() && _PersonInfoOfCurrentUser.Save())
                {
                    MessageBox.Show("User (" + txtFirstNameForUpdateUser.Text + ") Updated Successfully",
                       "Info",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    restUpdateUserForm();
                }

            }
        }
        void ChangeCheckBoxesUpdateUserForPermissions(bool status)
        {
            chkManageClientForUpdateUser.Enabled = status;
            chkManageUsersForUpdateUser.Enabled = status;
            chkClientsTransacionsForUpdateUser.Enabled = status;
            chkCurrencyExchangeForUpdateUser.Enabled = status;
        }

        void FillTextBoxesWithInfoOfCurrentUser()
        {
            txtPasswordForUpdateUser.Text=_CurrentUserChosedByComboBox.Password   ;
        }

        void FillTextBoxesWithPersonInfoOfCurrentUser()
        {
            int PersonID = _CurrentUserChosedByComboBox.PersonID;
            _PersonInfoOfCurrentUser = clsPerson.Find(PersonID);

            txtFirstNameForUpdateUser.Text = _PersonInfoOfCurrentUser.FirstName;
            txtLastNameForUpdateUser.Text =   _PersonInfoOfCurrentUser.LasttName;
            txtEmailForUpdateUser.Text   =_PersonInfoOfCurrentUser.Email  ;
            txtAddressForUpdateUser.Text =_PersonInfoOfCurrentUser.Address;
            txtPhoneForUpdateUser.Text   =_PersonInfoOfCurrentUser.Phone  ;
            txtGendorForUpdateUser.Text  =_PersonInfoOfCurrentUser.Gendor ;
            txtDateOfBirthForUpdateUser.Text= _PersonInfoOfCurrentUser.DateOfBirth.ToString();
        }

        private void cbUserNamesForUpdateUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _UserName = cbUserNamesForUpdateUser.SelectedItem.ToString();
            _CurrentUserChosedByComboBox=clsUser.FindByUserName(_UserName);
            FillTextBoxesWithInfoOfCurrentUser();
            FillTextBoxesWithPersonInfoOfCurrentUser();
            ChangeCheckBoxesUpdateUserForPermissions(true);
            grpUpdateUserPermissionsForUser.Enabled = true;

            rbPermissionsNoForUpdateUser.Checked = true;
        }

        private void rbPermissionsYesForUpdateUser_CheckedChanged(object sender, EventArgs e)
        {
            _PermissionsForUpdateUser = -1;
            ChangeCheckBoxesUpdateUserForPermissions(false);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(lvShowUser.SelectedItems[0].SubItems[0].Text);
            clsUser _User=clsUser.FindByID(UserID);
            int PersonID=_User.PersonID;
            if(clsUser.DeleteUser(UserID) && clsPerson.DeletePerson(PersonID))
            {
                MessageBox.Show("User " + _User.UserName + " Deleted Seccssfuly");
                FillListViewWithUsersInfo();
            }

        }

        private void tabAddNewUser_Click(object sender, EventArgs e)
        {

        }

        private void txtAddressForUserName_TextChanged_1(object sender, EventArgs e)
        {
            updateProgressBarAddNewClient(addNewClientValidFormInputsCount());
        }

        private void rbPermissionsNoForAddUser_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCheckBoxesAddNewUserForPermissions(true);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            FillListViewShowLoginUserLog(txtSearchUserNameForLoginUserLog.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lvSowLoginUserLog.Sorting = SortOrder.Ascending;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lvSowLoginUserLog.Sorting = SortOrder.Descending;
        }
    }
}
