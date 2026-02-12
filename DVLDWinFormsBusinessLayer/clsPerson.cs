using DVLDWinFormsDateAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDWinFormsDateAccessLayer;
using System.Net;
using System.Security.Policy;
using System.Data;

namespace DVLDWinFormsBusinessLayer
{
    public class clsPerson
    {
        public int PersonID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string FullName ()
        {
           return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
        }
        public DateTime DateOfBirth { set; get; }
        public string Gender { set; get; }
        public string Address {  set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public int NationalityCountryID { set; get; }
        public string ImagePath { set; get; }

        enum enMode { AddNew = 1, Update = 2 }

        enMode Mode { set; get; }

        public clsPerson ()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender = "";
            this.Address = "";
            this.Email = "";
            this.Phone = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            Mode = enMode.AddNew;

        }

        private clsPerson (int personID, string nationalNo, string firstName, string secondName, string thirdName, string lastName, DateTime dateOfBirth, string gender, string address, string email, string phone, int nationalityCountryID, string imagePath)
        {
            PersonID = personID;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth.Date;
            Gender = gender;
            Address = address;
            Email = email;
            Phone = phone;
            NationalityCountryID = nationalityCountryID;
            ImagePath = imagePath;

            Mode = enMode.Update;
        }

        public static clsPerson FindbyID (int personID)
        {
            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Email = "", Phone = "", ImagePath = "",Gender = "";
            int NationalityCountryID = -1;
            DateTime DateOfBirth = DateTime.Now;

            if (clsPeopleDataAccessLayer.GetPersonInfoByID(personID,ref NationalNo,ref FirstName,ref SecondName,ref ThirdName,ref LastName,ref DateOfBirth,ref Gender,ref Address,ref Email,
                ref Phone,ref NationalityCountryID,ref ImagePath))
            {
                return new clsPerson(personID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth.Date, Gender, Address, Email, Phone, NationalityCountryID, ImagePath);
            }
            else
            { return null; }
        }

        public static clsPerson FindbyNationalNo(string NationalNo)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Email = "", Phone = "", ImagePath = "",Gender = "";
            int NationalityCountryID = -1, PersonID = -1;
            DateTime DateOfBirth = DateTime.Now;

            if (clsPeopleDataAccessLayer.GetPersonInfoByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Email,
                ref Phone, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Email, Phone, NationalityCountryID, ImagePath);
            }
            else
            { return null; }


        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPeopleDataAccessLayer.AddNewPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.NationalNo, this.Gender, this.DateOfBirth, this.Email, this.Phone, this.Address, this.NationalityCountryID, this.ImagePath);

            return (this.PersonID != -1);
        }

        private bool _UpadtePerson()
        {
            return clsPeopleDataAccessLayer.UpdatePerson(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.NationalNo, this.Gender, this.DateOfBirth, this.Email, this.Phone, this.Address, this.NationalityCountryID, this.ImagePath);
        }

        static public bool DeletePerson(int PersonID)
        {
            return clsPeopleDataAccessLayer.DeletePerson(PersonID);
        }

        static public DataTable GetAllPeople()
        {
            return clsPeopleDataAccessLayer.GetAllPeople();
        }

        static public bool IsPersonExist(int PersonID)
        {
            return clsPeopleDataAccessLayer.IsPersonExist(PersonID);
        }

        static public bool IsPersonExist(string NationalNo)
        {
            return clsPeopleDataAccessLayer.IsPersonExist(NationalNo);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    case enMode.Update:
                    {

                        return _UpadtePerson();
                    }
            }
            return false;
        }
    }
}
