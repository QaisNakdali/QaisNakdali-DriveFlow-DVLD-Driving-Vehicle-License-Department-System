using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DVLDWinFormsDateAccessLayer;

namespace DVLDWinFormsBusinessLayer
{
    public class clsCountries
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        enum enMode { AddNew = 1, Update = 2 }

        enMode Mode { set; get; }

        public clsCountries()
        {
            CountryID = -1;
            CountryName = "";

            Mode = enMode.AddNew;

        }

        private clsCountries(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;

            Mode = enMode.Update;

        }

        static public clsCountries FindByCountryName(string CountryName)
        {
            int CountryID = -1;

            if (clsCountriesDataAccessLayer.GetCountryByName(CountryName,ref CountryID))
            {
                return new clsCountries(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }

        static public clsCountries FindByCountryID(int CountryID)
        {
            string CountryName = "";

            if (clsCountriesDataAccessLayer.GetCountryByID(CountryID,ref CountryName))
            {
                return new clsCountries(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }

        static public DataTable GetAllCountries()
        {
            return clsCountriesDataAccessLayer.GetAllCountries();
        }

        private bool _AddNewCountry()
        {
            this.CountryID = clsCountriesDataAccessLayer.AddNewCountry(this.CountryName);

            return (this.CountryID != -1);
        }

        private bool _UpadteCountry()
        {
            return clsCountriesDataAccessLayer.UpdateCountry(this.CountryID, this.CountryName);
        }

        static public bool DeleteCountry(int CountryID)
        {
            return clsCountriesDataAccessLayer.DeleteCountry(CountryID);
        }

        static public bool IsCountryExist(int CountryID)
        {
            return clsCountriesDataAccessLayer.IsCountryExist(CountryID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
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

                        return _UpadteCountry();
                    }
            }
            return false;
        }
    }
}
