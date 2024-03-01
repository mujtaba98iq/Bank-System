using BankAccessDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankBissinessLayer
{
    public class clsCurrencies
    {
        public string CurrencyCode { get; set; }
        public string CountryName { get; set; }
        public string CurrencyName { get; set; }
        public decimal Rate { get; set; }

        public clsCurrencies(string CurrencyCode, string CountryName,
            string CurrencyName, decimal Rate) 
        { 
            this.CurrencyCode = CurrencyCode;
            this.CountryName = CountryName;
            this.CurrencyName = CurrencyName;
            this.Rate = Rate;
        }
        public clsCurrencies()
        {
            this.CurrencyCode = "";
            this.CountryName = "";
            this.CurrencyName = "";
            this.Rate = 0;
        }
        bool _UpdateCurrency()
        {
           return clsCurrenciesAccessLayer.UpdateCurrency(this.CurrencyCode,this.Rate);
        }
        static public clsCurrencies FindCurrencyInfoByCurrencyCode(string currencyCode)
        {
            clsCurrenciesAccessLayer.stCurrecncyInfo currecncyInfo=new clsCurrenciesAccessLayer.stCurrecncyInfo();
          
            if(clsCurrenciesAccessLayer.GetCurrencyInfoByCurrencyCode(currencyCode, ref currecncyInfo))
            {
                return new clsCurrencies(currencyCode, currecncyInfo.CountryName,
               currecncyInfo.CurrencyName, currecncyInfo.Rate);
            }
            return null;
           
        }

        public static DataTable CurrenciesList()
        {
            return clsCurrenciesAccessLayer.GetCurrenciessList();
        }
        public static DataTable CurrenciesCodeList()
        {
            return clsCurrenciesAccessLayer.GetCurrenciessCodeList();
        }
        public bool Save()
        {
            return _UpdateCurrency();
        }
    }
}
