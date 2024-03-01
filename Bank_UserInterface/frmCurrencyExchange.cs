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
    public partial class frmCurrencyExchange : frmLayout
    {
        int _NumberOfCurrencies=0;
        public clsCurrencies _CurrencyConvertTo ;
        public clsCurrencies _CurrencyConvertFrom ;
        public frmCurrencyExchange():base("Currency Exchange")
        {
            InitializeComponent();
        }

        private void tabShowClients_Click(object sender, EventArgs e)
        {

        }
        void FillListViewShowCurrencies(string SearchsConditions="")
        {
            int CounterShowListUser = 0;
            lvShowCurrencies.Items.Clear();
            DataTable dt = clsCurrencies.CurrenciesList();
            _NumberOfCurrencies = dt.Rows.Count;
            if (SearchsConditions == "")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lvShowCurrencies.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    lvShowCurrencies.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    lvShowCurrencies.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    lvShowCurrencies.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                }
            }
            else
            {
                foreach (DataRow dr in dt.Select($"CountryName Like '%{SearchsConditions}%' or CurrencyCode Like '%{SearchsConditions}%'"))
                {

                    lvShowCurrencies.Items.Add(dr["CountryName"].ToString());
                    lvShowCurrencies.Items[CounterShowListUser].SubItems.Add(dr["CurrencyCode"].ToString());
                    lvShowCurrencies.Items[CounterShowListUser].SubItems.Add(dr["CurrencyName"].ToString());
                    lvShowCurrencies.Items[CounterShowListUser].SubItems.Add(dr["Rate"].ToString());
                    CounterShowListUser++;

                }
            }
        }
        void restShowCurrencyForm()
        {
            txtSearchByCurrencyCodeOrCountryForShowCurrencyList.Text = string.Empty;
            FillListViewShowCurrencies();
        }
        void FillComboBoxWithCurrncyCode(ComboBox cb)
        {
            cb.Items.Clear();
            DataTable dt = clsCurrencies.CurrenciesCodeList();
            foreach(DataRow dr in dt.Rows)
            {
                cb.Items.Add(dr["CurrencyCode"]);
            }

        }
        void restUpdateCurrencyForm()
        {
            FillComboBoxWithCurrncyCode(cbUpdateRateCurrencyCode);
            cbUpdateRateCurrencyCode.Text = "";
            lblCurrenyInfo.Text = string.Empty;
            numUpdateRate.Value = 0;

        }
        void restCurrencyCalculateForm()
        {
            FillComboBoxWithCurrncyCode(cbCurrencyFrom);
            FillComboBoxWithCurrncyCode(cbCurrencyTo);
            cbCurrencyFrom.Text = string.Empty;
            cbCurrencyTo.Text = string.Empty;
            lblCurrencyFromShowInfo.Text = string.Empty;
            lblCurrencyToShowInfo.Text = string.Empty;
            lblAmountExchange.Text = string.Empty;
            numUpdateRate.Value = 0;

        }
        void restCurrencyForms()
        {
            restShowCurrencyForm();
            restUpdateCurrencyForm();
            restCurrencyCalculateForm();
        }
        private void frmCurrencyExchange_Load(object sender, EventArgs e)
        {
            restCurrencyForms();
        }

        private void txtSearchByCurrencyCodeOrCountryForShowCurrencyList_TextChanged(object sender, EventArgs e)
        {
            FillListViewShowCurrencies(txtSearchByCurrencyCodeOrCountryForShowCurrencyList.Text);
        }

        private void rbSortinAsc_CheckedChanged(object sender, EventArgs e)
        {
            lvShowCurrencies.Sorting = SortOrder.Ascending;
        }

        private void rbSortingDesc_CheckedChanged(object sender, EventArgs e)
        {
            lvShowCurrencies.Sorting = SortOrder.Descending;

        }

        private void tabManageClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            restShowCurrencyForm();
        }
        void FillTextBoxesWithInfo(clsCurrencies currencies)
        {
            lblCurrenyInfo.Text ="Country: "+ currencies.CountryName+
                                 "\nCode: "+currencies.CurrencyCode+
                                 "\nName: "+currencies.CurrencyName+
                                 "\nRate("+currencies.Rate.ToString()+"$)";
            numUpdateRate.Value = currencies.Rate;
        }
        private void cbUpdateRateCurrencyCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currecnyCode = cbUpdateRateCurrencyCode.SelectedItem.ToString();
            clsCurrencies currencies = clsCurrencies.FindCurrencyInfoByCurrencyCode(currecnyCode);
            MessageBox.Show("Currency Find it" + currencies.CountryName);
            MessageBox.Show("Currency rate " + currencies.Rate);

            if (currencies != null)
            {
                FillTextBoxesWithInfo(currencies);
            }
        }

        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            string currecnyCode = cbUpdateRateCurrencyCode.SelectedItem.ToString();
            decimal NewcurrencyRate=numUpdateRate.Value;
            clsCurrencies currency = clsCurrencies.FindCurrencyInfoByCurrencyCode(currecnyCode);
            currency.Rate=NewcurrencyRate;
            if(currency.Save())
            {
                MessageBox.Show("Currency rate " + currency.CurrencyCode + " Updated Seccessfuly");
                restCurrencyForms();
            }
            else
                MessageBox.Show("Currency rate " + currency.CurrencyCode + " falid ");


        }

        private void tabCurrencyCalculator_Click(object sender, EventArgs e)
        {

        }

        private void tabUpdateRate_Click(object sender, EventArgs e)
        {

        }
        void FillLablesWithInfoCurrecnyChoesd(Label lb,clsCurrencies currencies)
        {
            lb.Text = "Country: " + currencies.CountryName +
                             "\nCode: " + currencies.CurrencyCode +
                             "\nName: " + currencies.CurrencyName +
                             "\nRate(" + currencies.Rate.ToString() + "$)";
        }
        private void cbCurrencyFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currecnyCode = cbCurrencyFrom.SelectedItem.ToString();
             _CurrencyConvertFrom = clsCurrencies.FindCurrencyInfoByCurrencyCode(currecnyCode);
            _CurrencyConvertFrom.CurrencyCode = currecnyCode;
            MessageBox.Show(_CurrencyConvertFrom.CurrencyCode);

            FillLablesWithInfoCurrecnyChoesd(lblCurrencyFromShowInfo, _CurrencyConvertFrom);
        }

        private void cbCurrencyTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currecnyCode = cbCurrencyTo.SelectedItem.ToString();
             _CurrencyConvertTo = clsCurrencies.FindCurrencyInfoByCurrencyCode(currecnyCode);
            _CurrencyConvertTo.CurrencyCode = currecnyCode;
            MessageBox.Show(_CurrencyConvertTo.CurrencyCode);

            FillLablesWithInfoCurrecnyChoesd(lblCurrencyToShowInfo, _CurrencyConvertTo);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(_CurrencyConvertFrom != null && _CurrencyConvertTo!=null)
            {
                lblAmountExchange.Text = nudConvertCurrency.Value.ToString() +" "+ _CurrencyConvertFrom.CurrencyCode +
                " = " + (nudConvertCurrency.Value * _CurrencyConvertTo.Rate) +" "+ _CurrencyConvertTo.CurrencyCode;
            }
            else
                MessageBox.Show("Please Choss Currency From And Currency To");
            
        }
    }
}
