using BankAccessDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBissinessLayer
{
    public class clsTransferLog
    {
        public int ID { get; set; }
        public string ClientAccNumberFrom { get; set; }
        public string ClientAccNumberTo { get; set; }
        public int Amount { get; set; }
        public DateTime DateTransfer { get; set; }

        public clsTransferLog(string ClientAccNumberFrom, string ClientAccNumberTo,
            int Amount,DateTime DateTransfer) 
        {
            this.ID = 0;
            this.ClientAccNumberFrom = ClientAccNumberFrom;
            this.ClientAccNumberTo = ClientAccNumberTo;
            this.Amount = Amount;
            this.DateTransfer = DateTransfer;
        }

        private bool _AddClient()
        {
            this.ID = clsTransferLogBankAccessData.AddTransferLog(this.ClientAccNumberFrom,
                this.ClientAccNumberTo, this.Amount, this.DateTransfer);
            return (this.ID != -1);
        }

        static public DataTable GetTransferLogList()
        {
            return clsTransferLogBankAccessData.TransferLogList(); 
        }

         public bool Save()
        {
            return _AddClient();
        }
    }
}
