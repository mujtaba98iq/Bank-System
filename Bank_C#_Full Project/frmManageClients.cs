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
    public partial class frmManageClients : frmLayout
    {
        clsClient _client;
        clsPerson _person;
        public frmManageClients():base ("Manage Clients")
        {
            InitializeComponent();
            fillClientsListView();

          
        }
        int CounterShowListClient = 0;
        void resetAddNewClientForm()
        {
            txtAddNewAccNumber.Clear();
            txtAddNewFirstName.Clear();
            txtAddNewLastName.Clear();
            txtAddNewEmail.Clear();
            txtAddNewPhone.Clear();
            txtAddNewAddress.Clear();
            txtAddNewPinCode.Clear();
            txtAddNewClientDateOfBirth.Clear();
            nudBalance.Value = 0;
            circularProgressBarAddNewClient.Value = 0;
            circularProgressBarAddNewClient.Text = "0%";
            btnAddNewClient.Enabled = false;
        }

        private void changeUpdateClientFormInputsStatus(bool status)
        {
            txtUpdateClientPinCode.Enabled = status;
            txtUpdateClientFirstName.Enabled = status;
            txtUpdateClientLastName.Enabled = status;
            txtUpdateClientEmail.Enabled = status;
            txtUpdateClientPhone.Enabled = status;
            txtUpdateClientAddress.Enabled = status;
            txtUpdateClientPinCode.Enabled = status;
            txtUpdateClientDateOfBirth.Enabled = status;

            nudUpdateClientBalance.Enabled = status;
        }
        void resetUpdateClientForm()
        {
            changeUpdateClientFormInputsStatus(false);
            txtUpdateClientFirstName.Clear();
            txtUpdateClientFirstName.Clear();
            txtUpdateClientLastName.Clear();
            txtUpdateClientEmail.Clear();
            txtUpdateClientPhone.Clear();
            txtUpdateClientAddress.Clear();
            txtUpdateClientPinCode.Clear();
            txtUpdateClientDateOfBirth.Clear();
            nudUpdateClientBalance.Value = 0;
            btnUpdateClient.Enabled = false;
            FillComboBoxWithClientsAccNumber();
        }
        void fillClientsListView(string SearchsConditions = "")
        {
            lvShowClients.Items.Clear();
            DataTable dt = clsClient.ClientsList();
            if (SearchsConditions == "")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lvShowClients.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    lvShowClients.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    lvShowClients.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    lvShowClients.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    lvShowClients.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                    lvShowClients.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    lvShowClients.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    lvShowClients.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                    lvShowClients.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                    lvShowClients.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
                    lvShowClients.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                }
            }
            else
            {
                foreach (DataRow dr in dt.Select($"AccNumber Like '%{SearchsConditions}%'"))
                {

                        lvShowClients.Items.Add(dr["ID"].ToString());
                        lvShowClients.Items[CounterShowListClient].SubItems.Add(dr["AccNumber"].ToString());
                        lvShowClients.Items[CounterShowListClient].SubItems.Add(dr["FirstName"].ToString());
                        lvShowClients.Items[CounterShowListClient].SubItems.Add(dr["LastName"].ToString());
                        lvShowClients.Items[CounterShowListClient].SubItems.Add(dr["Email"].ToString());
                        lvShowClients.Items[CounterShowListClient].SubItems.Add(dr["Phone"].ToString());
                        lvShowClients.Items[CounterShowListClient].SubItems.Add(dr["Balance"].ToString());
                        lvShowClients.Items[CounterShowListClient].SubItems.Add(dr["PinCode"].ToString());
                        lvShowClients.Items[CounterShowListClient].SubItems.Add(dr["Address"].ToString());
                        lvShowClients.Items[CounterShowListClient].SubItems.Add(dr["Gendor"].ToString());
                        lvShowClients.Items[CounterShowListClient].SubItems.Add(dr["DateOfBirth"].ToString());

                    CounterShowListClient++;
                  
                }
            }
        }

        void FillTextBoxesWithInfo()
        {

            nudUpdateClientBalance.Text = _client.Balance.ToString();
            txtUpdateClientPinCode.Text = _client.PinCode;
            txtUpdateClientFirstName.Text =_person.FirstName;
            txtUpdateClientLastName.Text = _person.LasttName;
            txtUpdateClientEmail.Text =    _person.Email;
            txtUpdateClientPhone.Text =    _person.Phone;
            txtUpdateClientAddress.Text =  _person.Address;
            txtUpdateClientDateOfBirth.Text= _person.DateOfBirth.ToString();
            txtUpdateClientGendor.Text = _person.Gendor;
        }


        void FillComboBoxWithClientsAccNumber()
        {
                cbUpdate.Items.Clear();
                DataTable dt = clsClient.ClientsAccNumbersList();
            
                foreach(DataRow dr in dt.Rows)
            {
                cbUpdate.Items.Add(dr["AccNumber"].ToString());
            }
            
        }


        private void frmManageClients_Load(object sender, EventArgs e)
        {
            
        }

        void RestartUpdateClientFrom()
        {
            fillClientsListView();
            resetAddNewClientForm();
            resetUpdateClientForm();
        }

        private void UpdateShowClientAndAccNumbers(object sender, EventArgs e)
        {
            lvShowClients.Items.Clear();
            fillClientsListView(txtSearchByAccNumber.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lvShowClients.Sorting=SortOrder.Ascending;
        }

        private void rbSortingDesc_CheckedChanged(object sender, EventArgs e)
        {
            lvShowClients.Sorting = SortOrder.Descending;

        }
        int addNewClientValidFormInputsCount()
        {
            int counter = 0;

            if (!string.IsNullOrWhiteSpace(txtAddNewAccNumber.Text) && !clsClient.IsFoundClientByAccNumber(txtAddNewAccNumber.Text))
                counter++;
            if (!string.IsNullOrWhiteSpace(txtAddNewFirstName.Text))
                counter++;
            if (!string.IsNullOrWhiteSpace(txtAddNewLastName.Text))
                counter++;
            if (!string.IsNullOrWhiteSpace(txtAddNewEmail.Text) && txtAddNewEmail.Text.Contains("@"))
                counter++;
            if (!string.IsNullOrWhiteSpace(txtAddNewPhone.Text) && txtAddNewPhone.Text.All(char.IsDigit))
                counter++;
            if (!string.IsNullOrWhiteSpace(txtAddNewAddress.Text))
                counter++;
            if (Convert.ToInt32(nudBalance.Text) != 0)
                counter++;
            if (!string.IsNullOrWhiteSpace(txtAddNewPinCode.Text))
                counter++;
            if (!string.IsNullOrWhiteSpace(txtAddNewGendor.Text))
                counter++;
            if (!string.IsNullOrWhiteSpace(txtAddNewClientDateOfBirth.Text))
                counter++;

            return counter;
        }

        private void updateProgressBarAddNewClient(int value)
        {
            if(value<=10)
            circularProgressBarAddNewClient.Value = value;
            circularProgressBarAddNewClient.Text = (((float)circularProgressBarAddNewClient.Value / circularProgressBarAddNewClient.Maximum) * 100).ToString("0") + "%";
            circularProgressBarAddNewClient.ProgressColor = Color.FromArgb(192, 192, 255);
            circularProgressBarAddNewClient.Refresh();

            checkBtnAddNewClientStatus();
        }
        private void checkBtnAddNewClientStatus()
        {
            if (circularProgressBarAddNewClient.Value == 9)
                btnAddNewClient.Enabled = true;
            else
                btnAddNewClient.Enabled = false;
        }



        private void validateClientForm(System.Windows.Forms.TextBox textBox, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                clientInfoErrorProvider.SetError(textBox, "required");
            }
            else if (textBox.Name == "txtAddNewAccNumber" && clsClient.IsFoundClientByAccNumber(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                clientInfoErrorProvider.SetError(textBox, "Account Number (" + textBox.Text + ") is already used, Choose another one.");
            }
            else if ((textBox.Name == "txtAddNewEmail" || textBox.Name == "txtUpdateClientEmail") && !textBox.Text.Contains("@"))
            {
                e.Cancel = true;
                textBox.Focus();
                clientInfoErrorProvider.SetError(textBox, "Invalid Email, Include an '@' in the email address");
            }
            else if ((textBox.Name == "txtAddNewPhone" || textBox.Name == "txtUpdateClientPhone") && !textBox.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                textBox.Focus();
                clientInfoErrorProvider.SetError(textBox, "Invalid Phone, Only Numbers Accepted");
            }
            else if ((textBox.Name == "txtAddNewClientDateOfBirth" || textBox.Name == "txtUpdateClientDateOfBirth") && String.IsNullOrEmpty(textBox.Text))
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

        private void validateClientForm(object sender, CancelEventArgs e) => validateClientForm((System.Windows.Forms.TextBox)sender, e);

        

        private void tabAddNewClient_Click(object sender, EventArgs e)
        {
         
        }

        private void nudBalance_Validating(object sender, CancelEventArgs e)
        {
            updateProgressBarAddNewClient(addNewClientValidFormInputsCount());
        }

        private void mtxtAddNewDateOfBirth_Validated(object sender, EventArgs e)
        {
            updateProgressBarAddNewClient(addNewClientValidFormInputsCount());

        }
        clsClient FillNewClientWithInfo()
        {
            clsClient Client = new clsClient();
            Client.AccNumber=txtAddNewAccNumber.Text;
            Client.PinCode=txtAddNewPinCode.Text;
            Client.Balance =Convert.ToInt32(nudBalance.Value);
            return Client;
        }

        clsPerson FillNewPersonWithInfo()
        {
            clsPerson Person = new clsPerson();

            Person.FirstName = txtAddNewFirstName.Text;
            Person.LasttName = txtAddNewLastName.Text;
            Person.Email = txtAddNewEmail.Text;
            Person.Phone = txtAddNewPhone.Text;
            Person.Address = txtAddNewAddress.Text;
            Person.Gendor = txtAddNewGendor.Text;
            if(txtAddNewClientDateOfBirth.Text!="")
            {
                try
                {
                    Person.DateOfBirth = Convert.ToDateTime(txtAddNewClientDateOfBirth.Text);

                }
                catch 
                {
                    MessageBox.Show("Write Correct Date !");
                    Person.DateOfBirth = DateTime.Now;
                }
            }
               

            return Person;
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                           "Are you sure to Add Client (" + txtAddNewFirstName.Text + ")?",
                           "Confirm"
                           , MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question) == DialogResult.OK)
            {
                clsClient Client1 = FillNewClientWithInfo();
                clsPerson Person1 = FillNewPersonWithInfo();
                if (Person1.Save())
                {
                    Client1.PersonID = Person1.ID;


                    if (Client1.Save())
                    {
                        MessageBox.Show("Client (" + txtAddNewAccNumber.Text + ") Added Successfully",
                  "Info",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                        resetAddNewClientForm();
                    }
                  
                } 
            }
        }

        private void validateClientForm(object sender, EventArgs e)
        {

        }

       
     

        

        void FillUpdateClientInfoFromTextBoxes()
        {
            _client.PinCode=txtUpdateClientPinCode.Text;
            _client.Balance =Convert.ToInt32(nudUpdateClientBalance.Value);
        }

        void FillUpdatePersonInfoFromTextBoxes()
        {
            _person.FirstName = txtUpdateClientFirstName.Text;
            _person.LasttName = txtUpdateClientLastName.Text;
            _person.Email = txtUpdateClientEmail.Text;
            _person.Phone = txtUpdateClientPhone.Text;
            _person.Address = txtUpdateClientAddress.Text;
            _person.Gendor = txtUpdateClientGendor.Text;
            _person.DateOfBirth = Convert.ToDateTime(txtUpdateClientDateOfBirth.Text);

           
        }

        private void nudUpdateClientBalance_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btUpdateClient_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(
                           "Are you sure to Update Client (" + txtUpdateClientFirstName.Text + ")?",
                           "Confirm"
                           ,MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question)==DialogResult.OK))
            {
               

                FillUpdateClientInfoFromTextBoxes();
                FillUpdatePersonInfoFromTextBoxes();
                if (_client.Save() && _person.Save())
                {
                    MessageBox.Show("Client (" + txtUpdateClientFirstName.Text + ") Updated Successfully",
                       "Info",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    RestartUpdateClientFrom();
                }
                    
            }
          
        }

        private void tabUpdateClient_Click(object sender, EventArgs e)
        {

        }

        private void tabManageClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestartUpdateClientFrom();
        }

        private void cbUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            _client = clsClient.FindClientByAccNumber(cbUpdate.SelectedItem.ToString());
            _person = clsPerson.Find(_client.PersonID);
            changeUpdateClientFormInputsStatus(true);
            btnUpdateClient.Enabled = true;
            FillTextBoxesWithInfo();
             


        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientTransactions frm= new frmClientTransactions(0,lvShowClients.SelectedItems[0].SubItems[1].Text);
            frm.ShowDialog();
        }

        private void withDrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ClietnID = Convert.ToInt32(lvShowClients.SelectedItems[0].SubItems[0].Text);
            _client = clsClient.Find(ClietnID);
            
            if (clsClient.DeleteClient(ClietnID)&& clsPerson.DeletePerson(_client.PersonID))
               
            {
                MessageBox.Show("Client Deleted Seccessfuly");
                fillClientsListView();
            }
            else
                MessageBox.Show("Client Deleted failer");
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientTransactions frm = new frmClientTransactions(1, lvShowClients.Items[0].SubItems[1].Text);
            frm.ShowDialog();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientTransactions frm = new frmClientTransactions(3, lvShowClients.Items[0].SubItems[1].Text);
            frm.ShowDialog();
        }

        private void txtAddNewAddress_TextChanged(object sender, EventArgs e)
        {
            updateProgressBarAddNewClient(addNewClientValidFormInputsCount());
        }
    }
}
