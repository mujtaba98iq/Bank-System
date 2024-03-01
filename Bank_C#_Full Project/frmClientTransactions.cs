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
    public partial class frmClientTransactions : frmLayout
    {
        string ChossedAccNumber = "";
        clsClient _ClientTransferForm;
        clsClient _ClientTransferTo;
        int _ClientsNumber = 0;
        string DepositAccNumber;

        public frmClientTransactions() : base("Client Transactions")
        {
            InitializeComponent();
            FillAllComboBoxesWithAccNumbers();
            FillWithDrawComboBoxWithAccNumbers();  
        }

        public frmClientTransactions(int TransactionType,string clientAccountNumber ) : base("Client Transactions")
        {
            InitializeComponent();
            FillAllComboBoxesWithAccNumbers();
          
            switch (TransactionType)
            {
                case 0:
                    cbDepositAccNumbers.Text = clientAccountNumber;
                    break;
                case 1:
                    cbClientWithDraw.Text= clientAccountNumber;
                    break;
                case 3:
                    cbTransferFromShowAccNumbers.Text= clientAccountNumber;
                    break;
            }
           
            tabManageClients.SelectedIndex = TransactionType;
        }

        private void tabShowClients_Click(object sender, EventArgs e)
        {

        }

        private void tabTotalBalances_Click(object sender, EventArgs e)
        {

        }
        void FillAllComboBoxesWithAccNumbers()
        {
            cbDepositAccNumbers.Items.Clear();
            cbClientWithDraw.Items.Clear();

            DataTable dt = clsClient.ClientsAccNumbersList();
            foreach (DataRow dr in dt.Rows)
            {
                cbDepositAccNumbers.Items.Add(dr["AccNumber"].ToString());
                cbClientWithDraw.Items.Add(dr["AccNumber"].ToString());
                cbTransferFromShowAccNumbers.Items.Add(dr["AccNumber"].ToString());
               
            }
          
        }

        void FillWithDrawComboBoxWithAccNumbers()
        {
            //cbClientWithDraw.Items.Clear();

            //DataTable dt = clsClient.ClientsList();
            //foreach (DataRow dr in dt.Rows)
            //{
            //    cbClientWithDraw.Items.Add(dr["AccNumber"].ToString());
            //}
        }

        void FillDepositnumBalanceWithClientBalance()
        {
            nudClientWithDrawBalance.Value = clsGloabal.CurrentClient.Balance;
        }
        void FillListViewWithClientInfoForTotalBalanceForm(string conditionToSearch="")
        {
            int Counter = 0;
            lvShowClientsBalanceInfo.Items.Clear();
            DataTable dt = clsClient.ClientsList();
            if (conditionToSearch=="")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lvShowClientsBalanceInfo.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    lvShowClientsBalanceInfo.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    lvShowClientsBalanceInfo.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                }  
            }
            else
            {
                foreach (DataRow dr in dt.Select($"AccNumber Like '%{conditionToSearch}%'"))
                {

                    lvShowClientsBalanceInfo.Items.Add(dr["ID"].ToString());
                    lvShowClientsBalanceInfo.Items[Counter].SubItems.Add(dr["AccNumber"].ToString());
                    lvShowClientsBalanceInfo.Items[Counter].SubItems.Add(dr["Balance"].ToString());

                    Counter++;

                }
            }
        }

        void FillComboBoxesWithAccNumbers(ComboBox Cb)
        {
            if (cbTransferFromShowAccNumbers.SelectedIndex < 0 &&
                cbTransferToShowAccNumbers.SelectedIndex < 0)
                ChossedAccNumber = "";
            Cb.Items.Clear();
            DataTable dt = clsClient.ClientsList();
            if (ChossedAccNumber == "")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Cb.Items.Add(dt.Rows[i].ItemArray[1].ToString());
                }
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if(dr["AccNumber"].ToString()!= ChossedAccNumber)
                    Cb.Items.Add(dr["AccNumber"].ToString());
                }
            }
        }
        private void tabManageClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            restTransactionsForms();
        }

        private void cbDepositAccNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsGloabal.CurrentClient = clsClient.FindClientByAccNumber(cbDepositAccNumbers.Text);
            changeDepositClientFormInputsStatus(true);
            lblCurrentBalanceDeposit.Text = "Current Balace is: $ " + clsGloabal.CurrentClient.Balance;
        }
        void changeDepositClientFormInputsStatus(bool status)
        {
            btDeposit.Enabled = status;
            nudDepositBalance.Enabled= status;
        }

        void changeWithDrawClientFormInputsStatus(bool status)
        {
            btWithDraw.Enabled = status;
            nudClientWithDrawBalance.Enabled = status;
        }
        void restDepositForm()
        {
            changeDepositClientFormInputsStatus(false);
            nudDepositBalance.Value = 0;
            lblCurrentBalanceDeposit.Text = "";
            FillAllComboBoxesWithAccNumbers();
        }
        void restWithDrawForm()
        {
            changeWithDrawClientFormInputsStatus(false);
            nudClientWithDrawBalance.Value = 0;
            lblCurrentBalanceWithDraw.Text = "";
        }
        void FillLablesTotalBalanceFrom()
        {
            int _TotalBalance=0;
            DataTable dt = clsClient.ClientsList();

            foreach(DataRow dr in dt.Rows)
            {
                _TotalBalance += Convert.ToInt32( dr["Balance"]);
            }
            lblTotalBalancesNumber.Text = "Total Balance is:($"+_TotalBalance.ToString()+")";
            lblTotalBalancesWord.Text="( "+clsMujtabaUtil.NumberToText(_TotalBalance)+" ) Dolar(s)";
        }

       void changeTransferBalanceClientFormInputsStatus(bool status)
        {
            nudTransferAmount.Enabled = status;
            btnTransfer.Enabled = status;
        }

        void restTotalBalanceForm()
        {
            txtTotalBalancesSearch.Text = "";
            FillLablesTotalBalanceFrom();
            FillListViewWithClientInfoForTotalBalanceForm();

        }
        
        void restTransfserFrom()
        {
            changeTransferBalanceClientFormInputsStatus(false);
            lblTotalBalanceTransferFrom.Text = "";
            lblTotalBalanceTransferTo.Text = "";
            nudTransferAmount.Value = 0;
            ChossedAccNumber = "";
            cbTransferToShowAccNumbers.Items.Clear();
            cbTransferFromShowAccNumbers.Items.Clear();
        }

        void FillTransferLogListViewWithInfo(string conditionStatment="")
        {
            lvTransferLog.Items.Clear();
            _ClientsNumber = 0;
            int Counter = 0;
            DataTable dt = clsTransferLog.GetTransferLogList();
            if (conditionStatment == "")
            {
                foreach (DataRow dr in dt.Rows)
                {
                    _ClientsNumber++;
                    lvTransferLog.Items.Add(dr["ID"].ToString());
                    lvTransferLog.Items[Counter].SubItems.Add(dr["FromAccNumber"].ToString());
                    lvTransferLog.Items[Counter].SubItems.Add(dr["ToAccNumber"].ToString());
                    lvTransferLog.Items[Counter].SubItems.Add(dr["Amount"].ToString());
                    lvTransferLog.Items[Counter].SubItems.Add(dr["Date"].ToString());
                    Counter ++;
                }
            }
            else
            {
                foreach (DataRow dr in dt.Select($"FromAccNumber Like '%{conditionStatment}%'"))
                {
                    _ClientsNumber++;
                    lvTransferLog.Items.Add(dr["ID"].ToString());
                    lvTransferLog.Items[Counter].SubItems.Add(dr["FromAccNumber"].ToString());
                    lvTransferLog.Items[Counter].SubItems.Add(dr["ToAccNumber"].ToString());
                    lvTransferLog.Items[Counter].SubItems.Add(dr["Amount"].ToString());
                    lvTransferLog.Items[Counter].SubItems.Add(dr["Date"].ToString());
                    Counter++;

                }
            }
        }
        void restTransferLogForm()
        {
            FillTransferLogListViewWithInfo();
            txtSearchAccNumberTransferLog.Text = "";
            lblNumberOfClientsInTransferLogForm.Text= _ClientsNumber.ToString()+" Client (s)";
        }

        void restTransactionsForms()
        {
            restDepositForm();
            restWithDrawForm();
            restTotalBalanceForm();
            restTransfserFrom();
            restTransferLogForm();
        }
        private void btDeposit_Click(object sender, EventArgs e)
        {
            if(nudDepositBalance.Value>0)
            {
                int IDTo = clsGloabal.CurrentClient.ID;
                int Balance = Convert.ToInt32(nudDepositBalance.Value);
                clsClient Client = new clsClient(0, IDTo, Balance);

                if (Client.Save())
                {
                    MessageBox.Show("Deposit Seccessfuly");
                    restTransactionsForms();
                }
                else
                    MessageBox.Show("Deposit failer");
            }
            else
                MessageBox.Show("Deposit Value Mustn't Equal Zero!");


        }

        private void btWithDraw_Click(object sender, EventArgs e)
        {
            if (nudClientWithDrawBalance.Value > 0 )
            {
                if(nudClientWithDrawBalance.Value <= clsGloabal.CurrentClient.Balance)
                {
                    int IDFrom = clsGloabal.CurrentClient.ID;
                    int Balance = Convert.ToInt32(nudClientWithDrawBalance.Value);
                    clsClient Client = new clsClient(IDFrom, 0, Balance);

                    if (Client.Save())
                    {
                        MessageBox.Show("WithDraw Seccessfuly");
                        restTransactionsForms();
                    }
                    else
                        MessageBox.Show("WithDraw failer");
                }
                else
                    MessageBox.Show("WithDraw Value Must less or Equal to Current Balance!");

            }
            else
                MessageBox.Show("WithDraw Value Mustn't Equal Zero!");
        }

        private void cbClientWithDraw_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsGloabal.CurrentClient = clsClient.FindClientByAccNumber(cbClientWithDraw.Text);
            if(clsGloabal.CurrentClient.Balance==0)
            {
                MessageBox.Show("Your Balance is Zero You Can't Do WithDraw On This AccNumber");

            }
            else
            {
                changeWithDrawClientFormInputsStatus(true);
                lblCurrentBalanceWithDraw.Text = "Current Balace is: $ " + clsGloabal.CurrentClient.Balance;
                FillDepositnumBalanceWithClientBalance();

            }
        }

        private void txtTotalBalancesSearch_TextChanged(object sender, EventArgs e)
        {
            FillListViewWithClientInfoForTotalBalanceForm(txtTotalBalancesSearch.Text);
        }

        private void rbSortinAsc_CheckedChanged(object sender, EventArgs e)
        {
            lvShowClientsBalanceInfo.Sorting=SortOrder.Ascending;
        }

        private void rbSortingDesc_CheckedChanged(object sender, EventArgs e)
        {
            lvShowClientsBalanceInfo.Sorting = SortOrder.Descending;

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (nudTransferAmount.Value > 0)
            {
                if (nudTransferAmount.Value <= _ClientTransferForm.Balance)
                {
                    int IDFrom = _ClientTransferForm.ID;
                    int IDTo = _ClientTransferTo.ID;

                    int Amount = Convert.ToInt32(nudTransferAmount.Value);
                    clsClient Client = new clsClient(IDFrom, IDTo, Amount);
                    clsTransferLog transferLog = new clsTransferLog(_ClientTransferForm.AccNumber,
                        _ClientTransferTo.AccNumber,Amount,DateTime.Now);

                    if (Client.Save() && transferLog.Save())
                    {
                        MessageBox.Show("Transfer Seccessfuly");
                        restTransfserFrom();
                    }
                    else
                        MessageBox.Show("Transfer failer");
                }
                else
                    MessageBox.Show("Transfer Value Must less or Equal to Client Form Balance!");

            }
            else
                MessageBox.Show("Transfer Value Mustn't Equal Zero!");


        }
        private void AccNumberThatChossedByComboBoxes(ComboBox cb)
        {
            ChossedAccNumber = cb.SelectedItem.ToString();
        }

        private void cbTransferChoseAccNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
                AccNumberThatChossedByComboBoxes((ComboBox)sender);
                if (cbTransferFromShowAccNumbers.SelectedIndex >= 0 &&
                    cbTransferToShowAccNumbers.SelectedIndex >= 0)
                {
                   
                    changeTransferBalanceClientFormInputsStatus(true);
                    _ClientTransferForm = clsClient.FindClientByAccNumber(cbTransferFromShowAccNumbers.SelectedItem.ToString());
                    if (_ClientTransferForm.Balance == 0)
                    {
                        MessageBox.Show("Your Amount Zero You Can't Transfer To Another Client");
                    }
                    else
                {
                    _ClientTransferTo = clsClient.FindClientByAccNumber(cbTransferToShowAccNumbers.SelectedItem.ToString());
                    lblTotalBalanceTransferFrom.Text = "Balance Client From IS: $" + _ClientTransferForm.Balance.ToString();
                    lblTotalBalanceTransferTo.Text = "Balance Client To IS: $" + _ClientTransferTo.Balance.ToString();

                }

            }
            
            
           
        }

        private void ComboBoxedOnClieck_TransferShowAccNumbers_Click(object sender, EventArgs e)
        {
            FillComboBoxesWithAccNumbers((ComboBox)sender);
        }

        private void rbAccTransferLog_CheckedChanged(object sender, EventArgs e)
        {
            lvTransferLog.Sorting = SortOrder.Ascending;
        }

        private void rbDescTransferLog_CheckedChanged(object sender, EventArgs e)
        {
            lvTransferLog.Sorting= SortOrder.Descending;
        }

        private void txtSearchAccNumberTransferLog_TextChanged(object sender, EventArgs e)
        {
            FillTransferLogListViewWithInfo(txtSearchAccNumberTransferLog.Text);
        }

        private void frmClientTransactions_Load(object sender, EventArgs e)
        {

        }
    }
}
