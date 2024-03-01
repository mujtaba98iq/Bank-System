using BankAccessDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankAccessDataLayer.clsPersonAccessLayer;

namespace BankBissinessLayer
{
    public class clsPerson
    {
        enum enMode
        {
            AddNew=0,Update=1
        }
        enMode Mode = enMode.AddNew;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Gendor { get; set; }
        public DateTime DateOfBirth { get; set; }

        public clsPerson(int ID,string FirstName,string LastName,string Email,string Phone,
            string Address,string Gendor,DateTime DateOfBirth) 
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LasttName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.Gendor = Gendor;
            this.DateOfBirth = DateOfBirth;

            Mode = enMode.Update;
        }
        public clsPerson()
        {
            this.ID = -1;
            this.FirstName = "";
            this.LasttName = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.Gendor = "";
            this.DateOfBirth= DateTime.Now;

            Mode= enMode.AddNew;

        }
        private bool _AddNewPerson()
        {
            clsPersonAccessLayer.stPerson person = new clsPersonAccessLayer.stPerson();

            person.FirstName = this.FirstName;
            person.LastName=this.LasttName;
            person.Email = this.Email;
            person.Phone = this.Phone;
            person.Address = this.Address;
            person.Gendor = this.Gendor;
            person.DateOfBirth = this.DateOfBirth;

            this.ID =clsPersonAccessLayer.AddPerson(person);

            return (this.ID!=-1);
        }

        static public clsPerson Find(int ID)
        {
            clsPersonAccessLayer.stPerson Person = new clsPersonAccessLayer.stPerson();


            if (clsPersonAccessLayer.GetPersonInfo(ID, ref Person))
            {
                return new clsPerson(ID, Person.FirstName, Person.LastName, Person.Email,
                    Person.Phone,Person.Address,Person.Gendor,Person.DateOfBirth);
            }

            else
                return null;
        }

       

        static public bool DeletePerson(int ID)
        {
            return clsPersonAccessLayer.DeletePerson(ID);
        }

        private bool _Update()
        {
            clsPersonAccessLayer.stPerson person = new clsPersonAccessLayer.stPerson();


            person.FirstName = this.FirstName;
            person.LastName = this.LasttName;
            person.Email = this.Email;
            person.Phone = this.Phone;
            person.Address = this.Address;
            person.Gendor = this.Gendor;
            person.DateOfBirth = this.DateOfBirth;

            return clsPersonAccessLayer.UpdatePerson(this.ID, person);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    { return false; }
                case enMode.Update:
                    if (_Update())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    { return false; }

            }
            return false;
        }

    }
}
