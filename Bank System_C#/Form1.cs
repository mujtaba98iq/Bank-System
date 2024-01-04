using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
          List <string> stAccountNumber=new List<string>();
          List <string> stPinCod = new List<string>();
          List <string> stPhone = new List<string>();
          List <string> stCity = new List<string>();
          List <string> stAccountBalance = new List<string>();

      
        void refTable()
        {
            listView1.Items.Clear();
            for (int i = 0; i < stAccountBalance.Count; i++)
            {
                string[] row= { stAccountNumber[i], stPinCod[i], stPhone[i], stCity[i], stAccountBalance[i] };
                var LItem= new ListViewItem(row);
                listView1.Items.Add(LItem);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        ListViewItem SearchForItem(TextBox txtB)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].ToString().ToLower().Contains(txtB.Text.ToLower()))
                {
                    return item;
                }
            }
            return null;
        }
        void ClearTxtAddClient()
        {
            txtACNAddClient.Clear();
            txtPinCode.Clear();
            txtPhone.Clear();
            txtCity.Clear();
            txtACB.Clear();
        }
        void UpdateClient()
        {
            listView1.SelectedItems[0].SubItems[0].Text = txtACNAddClient.Text;
            listView1.SelectedItems[0].SubItems[1].Text = txtPinCode.Text;
            listView1.SelectedItems[0].SubItems[2].Text = txtPhone.Text;
            listView1.SelectedItems[0].SubItems[3].Text = txtCity.Text;
            listView1.SelectedItems[0].SubItems[4].Text = txtACB.Text;

            btAdd.Text = "Add";
            ClearTxtAddClient();
            return;
        }
        void AddClient()
        {
            ListViewItem item = new ListViewItem(txtACNAddClient.Text.Trim());
            item.SubItems.Add(txtPinCode.Text.Trim());
            item.SubItems.Add(txtPhone.Text.Trim());
            item.SubItems.Add(txtCity.Text.Trim());
            item.SubItems.Add(txtACB.Text.Trim());
            listView1.Items.Add(item);

            stAccountNumber.Add(txtACNAddClient.Text);
            stPinCod.Add(txtPinCode.Text);
            stPhone.Add(txtPhone.Text);
            stCity.Add(txtCity.Text);
            stAccountBalance.Add(txtACB.Text);

            txtACNAddClient.Focus();
            ClearTxtAddClient();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(btAdd.Text=="Update")
            {
             UpdateClient();
             return;
            }
            if(string.IsNullOrEmpty(txtACNAddClient.Text )&& 
                string.IsNullOrEmpty(txtPinCode.Text) &&
                string.IsNullOrEmpty(txtPhone.Text)&&
                string.IsNullOrEmpty(txtCity.Text) &&
                string.IsNullOrEmpty(txtACB.Text)
                )
            {
                return;
            }
            AddClient();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                txtACNAddClient.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtPinCode.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtPhone.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtCity.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtACB.Text = listView1.SelectedItems[0].SubItems[4].Text;
                btAdd.Text = "Update";
            }
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AccountBalance=0;
            AccountBalance = Convert.ToInt32(listView1.SelectedItems[0].SubItems[4].Text);
            AccountBalance += Convert.ToInt16(txtDeposit.Text);
            listView1.SelectedItems[0].SubItems[4].Text=AccountBalance.ToString();
        }

        private void withDrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                if (Convert.ToInt32(listView1.SelectedItems[0].SubItems[4].Text)>=Convert.ToInt32( txtWithDraw.Text))
                {  
                int AccountBalance = 0;
                AccountBalance = Convert.ToInt32(listView1.SelectedItems[0].SubItems[4].Text);
                AccountBalance -= Convert.ToInt32(txtWithDraw.Text);
                listView1.SelectedItems[0].SubItems[4].Text = AccountBalance.ToString();

                }
                else
                {
                    MessageBox.Show("The Client Doesn't have Enogh Mony to WithDraw");
                }
              
            }
        
        }

        private void txtACNfindClient_TextChanged(object sender, EventArgs e)
        {
          if(txtACNfindClient.Text=="")
            {
                refTable();
            }
          else
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (!item.ToString().ToLower().Contains(txtACNfindClient.Text.ToLower()))
                    {
                        listView1.Items.Remove(item);
                    }
                }
            }
            
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.Items)
            {
                if (!item.ToString().ToLower().Contains(txtACNfindClient.Text.ToLower()))
                {
                    listView1.Items.Remove(item);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem ItemFrom = SearchForItem(txtFrom);
            ListViewItem ItemTo = SearchForItem(txtTo);

            int AmmountFrom =0;
            int AmmountTo =0;
            if(ItemFrom != null && ItemTo != null)
            {
                AmmountFrom = Convert.ToInt32(ItemFrom.SubItems[4].Text);
                AmmountTo = Convert.ToInt32(ItemTo.SubItems[4].Text);
                AmmountFrom -=Convert.ToInt32(txtAmount.Text);
                AmmountTo +=Convert.ToInt32(txtAmount.Text);
                ItemFrom.SubItems[4].Text=AmmountFrom.ToString();
                ItemTo.SubItems[4].Text = AmmountTo.ToString();
                txtFrom.Clear();
                txtAmount.Clear();
                txtTo.Clear();
            }
            else
            {
                MessageBox.Show("There is No Clients with This Account Number");
            }
        }
    }
}
