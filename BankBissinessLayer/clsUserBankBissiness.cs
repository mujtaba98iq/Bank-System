using BankAccessDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BankBissinessLayer
{
    public class clsUser
    {
        enum enMode { Add = 0, Update = 1 }
        enMode Mode = enMode.Add;

        public int ID;
        public string UserName;
        public string Password;
        public int Permissions;
        public int PersonID;

        public clsUser()
        {
            this.ID = -1;
            this.UserName = "";
            this.Password = "";
            this.Permissions = 0;
            this.PersonID = -1;
           
            Mode = enMode.Add;
        }

        public clsUser(int ID, string UserName, string Password, int Permissions,
            int PersonID)
        {
            this.ID = ID;
            this.UserName = UserName;
            this.Password = Password;
            this.Permissions = Permissions;
            this.PersonID = PersonID;
          
            Mode = enMode.Update;

        }

        static public bool Login(string UserName,string Password)
        {
            
           return clsUsersBankAccessData.Lgoin(UserName, Password); 
        }

        static public clsUser FindByID(int ID)
        {
 
            clsUsersBankAccessData.stUser User=new clsUsersBankAccessData.stUser();


            if (clsUsersBankAccessData.GetUserInfo(ID,ref User))
            {
                return new clsUser(ID, User.UserName, User.Password, User.Permissions, User.PersonID);
            }

            else
                return null;
        }

        


        static public clsUser FindByUserName(string UserName1)
        {

            clsUsersBankAccessData.stUser User = new clsUsersBankAccessData.stUser();
            User.UserName = UserName1;
            int ID = -1;

            if (clsUsersBankAccessData.GetUserInfoByUserName(ref ID, ref User,UserName1))
            {
                return new clsUser(ID, UserName1, User.Password, User.Permissions, User.PersonID);
            }

            else
                return null;
        }

        private bool _Update()
        {
            clsUsersBankAccessData.stUser User = new clsUsersBankAccessData.stUser();
            User.UserName = this.UserName;
            User.Password = this.Password;
            User.Permissions = this.Permissions;    
            User.PersonID = this.PersonID;
            return clsUsersBankAccessData.UpdateUser(this.ID, User );
        }

        private bool _AddUser()
        {
            clsUsersBankAccessData.stUser UserInfo = new clsUsersBankAccessData.stUser();
            UserInfo.UserName = this.UserName;
            UserInfo.Password = this.Password;
            UserInfo.PersonID = this.PersonID;
            UserInfo.Permissions = this.Permissions;

            this.ID = clsUsersBankAccessData.AddUser(UserInfo);
            return (this.ID != -1);
        }
        static public bool IsFoundUserByID(int ID)
        {
            return clsUsersBankAccessData.IsUserExistingByID(ID);
        }

        static public bool IsFoundUserByUserName(string UserName)
        {
            return clsUsersBankAccessData.IsUserExistingByUserName(UserName);
        }

        static public bool DeleteUser(int ID)
        {
            return clsUsersBankAccessData.DeleteUser(ID);
        }
        static public DataTable UsersList()
        {
            return clsUsersBankAccessData.GetUsersList();
        }

        static public DataTable ListForUserNames()
        {
            return clsUsersBankAccessData.GetUserNamesList();
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddUser())
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

            }
            return false;

        }
    }
}
