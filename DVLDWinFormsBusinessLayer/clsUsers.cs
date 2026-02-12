using DVLDWinFormsDateAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DVLDWinFormsBusinessLayer
{
    public class clsUsers
    {

        public int UserID { get; set; }
        public string UserName { get; set; }
        public int PersonID { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        enum enMode { AddNew = 1, Update = 2 }

        enMode Mode { set; get; }

        public clsUsers()
        {
            UserID = -1;
            UserName = "";
            PersonID = -1;
            Password = "";
            IsActive = false;

            Mode = enMode.AddNew;

        }

        private clsUsers(int UserID, string UserName, int PersonID, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.PersonID = PersonID;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = enMode.Update;

        }

        static public clsUsers FindByUserName(string UserName)
        {
            int UserID = -1,
            PersonID = -1;
            string Password = "";
            bool IsActive = false;


            if (clsUsersDataAccessLayer.GetUserByUsername(UserName, ref UserID,ref PersonID,ref Password, ref IsActive))
            {
                return new clsUsers(UserID, UserName, PersonID, Password,IsActive);
            }
            else
            {
                return null;
            }
        }

        static public clsUsers FindByUserID(int UserID)
        {
            string UserName = "";
            int PersonID = -1;
            string Password = "";
            bool IsActive = false;


            if (clsUsersDataAccessLayer.GetUserByID(UserID, ref UserName, ref PersonID, ref Password, ref IsActive))
            {
                return new clsUsers(UserID, UserName, PersonID, Password, IsActive);
            }
            else
            {
                return null;
            }
        }

        static public DataTable GetAllUsers()
        {
            return clsUsersDataAccessLayer.GetAllUsers();
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUsersDataAccessLayer.AddNewUser(this.UserName, this.PersonID,this.Password,this.IsActive);

            return (this.UserID != -1);
        }

        private bool _UpadteUser()
        {
            return clsUsersDataAccessLayer.UpdateUser(this.UserID, this.UserName, this.PersonID, this.Password, this.IsActive);
        }

        static public bool DeleteUser(int UserID)
        {
            return clsUsersDataAccessLayer.DeleteUser(UserID);
        }

        static public bool IsUserExist(int UserID)
        {
            return clsUsersDataAccessLayer.IsUserExist(UserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
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

                        return _UpadteUser();
                    }
            }
            return false;
        }
    }
}
