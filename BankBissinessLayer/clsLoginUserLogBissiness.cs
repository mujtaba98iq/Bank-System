using BankAccessDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBissinessLayer
{
    public class clsLoginUserLog
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public DateTime DateLog { get; set; }

        public clsLoginUserLog() 
        { 
            this.ID = 0;
            this.UserID = 0;
            this.DateLog = DateTime.Now;
        }

        bool _AddNewLog()
        {
         this.ID= clsLoginUserLogAccessLayer.AddLoginUserLog(this.UserID,this.DateLog);
            return (this.ID>0);
        }

        static public DataTable ListOfLgoinUserLog()
        {
            return clsLoginUserLogAccessLayer.LoginUserLogList();
        }

        public bool Save()
        {
            return _AddNewLog();
        }

    }
}
