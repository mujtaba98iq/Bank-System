using BankBissinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_C__Full_Project
{
    public class clsGloabal
    {
        static public clsClient CurrentClient;
        static public clsPerson CurrentPerson;
        static public clsUser CurrentUser=new clsUser(0,"","",0,0);

        static public int NumberOfFlaidLogin=3;

        public enum ePermissions
        {
            eAll=-1,
            eManageClient=1,
            eManageUser=2,
            eTransactions=4,
        }
    }
}
