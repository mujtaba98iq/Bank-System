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
    public class clsClient
    {
        enum enMode { Add=0,Update=1,Transfer=2, WithDraw=3,Deposit=4 }
        enMode Mode = enMode.Add;

       public int ID { get; set; }
       public int Balance { get; set; }
       public int PersonID { get; set; }
       public string AccNumber { get; set; }
       public string PinCode { get; set; }


       public int ClientID { get; set; }
       public int IDFrom { get; set; }
       public int IDTo { get; set; }
       public int Ammont { get; set; }

        public clsClient()
        {
            this.ID = -1;
            this.Balance =-1;
            this.PersonID = -1;
            this.AccNumber =  string.Empty;
            this.PinCode = string.Empty;

            Mode= enMode.Add;
        }

        public clsClient(int ID,int PersonID,int Balance,string AccNumber,string PinCode)
        {
            this.ID=ID;
            this.PersonID=PersonID;
            this.Balance = Balance;
            this.AccNumber = AccNumber;
            this.PinCode = PinCode;

            Mode = enMode.Update;

        }
       public clsClient(int IDFrom,int IDTo,int Ammont)
        {
            if(IDFrom!=0 && IDTo!=0)
            {
                this.IDFrom = IDFrom;
                this.IDTo = IDTo;
                this.Ammont = Ammont;

                Mode = enMode.Transfer;
            }
            else if(IDFrom!=0 && IDTo==0)
            {
                this.IDFrom = IDFrom;
                this.Ammont= Ammont;
                Mode = enMode.WithDraw;
            }
            else
            {
                this.IDTo = IDTo;
                this.Ammont = Ammont;
                Mode = enMode.Deposit;
            }
            

        }
       

        static public clsClient Find(int ID)
        {
            clsClientBankAccessData.stClient Client = new clsClientBankAccessData.stClient();


            if (clsClientBankAccessData.GetClientInfo(ID,ref Client))
            {
                return new clsClient(ID, Client.PersonID, Client.Balance, Client.AccNumber,
                    Client.PinCode);
            }

            else
                return null;
         }
        static public clsClient FindClientByAccNumber(string AccNumber)
        {
            clsClientBankAccessData.stClient Client = new clsClientBankAccessData.stClient();
            int ID=-1;
            Client.AccNumber = AccNumber;

            if (clsClientBankAccessData.GetClientInfoByAccNumber(ref ID, ref Client))
            {
                return new clsClient(ID, Client.PersonID, Client.Balance, Client.AccNumber,
                    Client.PinCode);
            }

            else
                return null;
        }

        private bool _Update()
        {
            clsClientBankAccessData.stClient Client= new clsClientBankAccessData.stClient();
            Client.AccNumber=this.AccNumber;
            Client.PinCode=this.PinCode;
            Client.Balance=this.Balance;
            Client.PersonID=this.PersonID;

            return clsClientBankAccessData.UpdateClient(this.ID,Client);
        }

        private bool _Transfer()
        {
            return clsClientBankAccessData.Transfers(this.IDFrom, this.IDTo, this.Ammont);
        }

        private bool _WithDraw()
        {
            return clsClientBankAccessData.WithDraw(this.IDFrom, this.Ammont);
        }
        private bool _Deposit()
        {
            return clsClientBankAccessData.Deposit(this.IDTo, this.Ammont);
        }

        private bool _AddClient()
        {
            clsClientBankAccessData.stClient ClientInfo= new clsClientBankAccessData.stClient();
           
            ClientInfo.AccNumber=this.AccNumber;
            ClientInfo.PinCode=this.PinCode;
            ClientInfo.Balance = this.Balance;
            ClientInfo.PersonID = this.PersonID;

            this.ID = clsClientBankAccessData.AddClient(ClientInfo);
            return (this.ID != -1);
        }

        static public bool DeleteClient(int ID)
        {
            return clsClientBankAccessData.DeleteClient(ID);
        }

        static public DataTable ClientsList()
        {
            return clsClientBankAccessData.GetClientsList();
        }

        static public DataTable ClientsIDsList()
        {
            return clsClientBankAccessData.GetClientsIDsList();
        }

        static public DataTable ClientsAccNumbersList()
        {
            return clsClientBankAccessData.GetClientsAccNumbersList();
        }

        static public bool IsFoundClientByID(int ID)
        {
            return clsClientBankAccessData.IsClientExistingByID(ID);
        }

        static public bool IsFoundClientByAccNumber(string AccNumber)
        {
            return clsClientBankAccessData.IsClientExistingByAccNumber(AccNumber);
        }

        static public string AccNumberByID(int ID)
        {
            return clsClientBankAccessData.GetAccNumebrByID(ID);
        }

        static public bool Login(string AccNumber,string PinCode)
        {
            return clsClientBankAccessData.Login(AccNumber,PinCode);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddClient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    if (_Update())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Transfer:
                    if (_Transfer())
                    {
                        Mode = enMode.Transfer;
                        return true;
                    }
                    else
                        return false;

                case enMode.WithDraw:
                    if (_WithDraw())
                    {
                        Mode = enMode.WithDraw;
                        return true;
                    }
                    else
                        return false;

                case enMode.Deposit:
                    if (_Deposit())
                    {
                        Mode = enMode.Deposit;
                        return true;
                    }
                    else
                        return false;
            }
            return false;

        }

    }
}
