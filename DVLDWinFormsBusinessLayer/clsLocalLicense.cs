using DVLDWinFormsDateAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDWinFormsBusinessLayer
{
    public class clsLocalLicense
    {
        public int LocalDrivingLicenseApplicationID { set; get; }
        public int ApplicationID { set; get; }
        public int LicenseClassID {  set; get; }

        enum enMode { AddNew = 1, Update = 2 }

        enMode Mode { set; get; }

        public clsLocalLicense()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ApplicationID = -1;
            this.LicenseClassID = -1;

            Mode = enMode.AddNew;

        }

        private clsLocalLicense(int localdrivinglicensapplicationID, int applicationID, int licenseclassID)
        {
            LocalDrivingLicenseApplicationID = localdrivinglicensapplicationID;
            ApplicationID = applicationID;
            LicenseClassID = licenseclassID;

            Mode = enMode.Update;
        }

        public static clsLocalLicense FindbyID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1, LicenseClassID = -1;

            if (clsLocalLicensesDataAccessLayer.GetLocalLicenseInfoByID(LocalDrivingLicenseApplicationID,ref ApplicationID, ref LicenseClassID))
            {
                return new clsLocalLicense(LocalDrivingLicenseApplicationID, ApplicationID,LicenseClassID);
            }
            else
            { return null; }
        }

        private bool _AddNewLocalLicense()
        {
            this.LocalDrivingLicenseApplicationID = clsLocalLicensesDataAccessLayer.AddNewLocalLicense(this.ApplicationID,this.LicenseClassID);

            return (this.LocalDrivingLicenseApplicationID != -1);
        }

        private bool _UpadteLocalLicense()
        {
            return clsLocalLicensesDataAccessLayer.UpdateLocalLicense(this.LocalDrivingLicenseApplicationID, this.ApplicationID,this.LicenseClassID);
        }

        static public bool DeleteLocalLicense(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalLicensesDataAccessLayer.DeleteLocalLicense(LocalDrivingLicenseApplicationID);
        }

        static public DataTable GetAllLocalLicenses()
        {
            return clsLocalLicensesDataAccessLayer.GetAllLocalLicenses();
        }

        static public bool IsLocalLicenseExist(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalLicensesDataAccessLayer.IsLocalLicenseExist(LocalDrivingLicenseApplicationID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalLicense())
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

                        return _UpadteLocalLicense();
                    }
            }
            return false;
        }
    }
}