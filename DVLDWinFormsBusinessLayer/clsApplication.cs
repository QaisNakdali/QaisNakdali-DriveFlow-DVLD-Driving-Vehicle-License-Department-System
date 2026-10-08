using DVLDWinFormsDateAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDWinFormsBusinessLayer
{
    public class clsApplication
    {
        public int ApplicationID { set; get; }
        public int ApplicantPersonID { set; get; }
        public DateTime ApplicationDate { set; get; }
        public int ApplicationTypeID { set; get; }
        public byte ApplicationStatus { set; get; }
        public DateTime LastStatusDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }


        enum enMode { AddNew = 1, Update = 2 }

        enMode Mode { set; get; }

        public clsApplication()
        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = 0;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;

        }

        private clsApplication(int applicationID, int applicantpersonID, DateTime applicationdate, int applicationtypeID, byte applicationstatus,DateTime laststatusdate
            , decimal paidfees, int createdbyuserID)
        {
            ApplicationID = applicationID;
            ApplicantPersonID = applicantpersonID;
            ApplicationDate = applicationdate;
            ApplicationTypeID = applicationtypeID;
            ApplicationStatus = applicationstatus;
            LastStatusDate = laststatusdate;
            PaidFees = paidfees;
            CreatedByUserID = createdbyuserID;
            Mode = enMode.Update;
        }
       public static clsApplication FindbyID(int ApplicationID)
        {
            int applicantpersonID = -1, applicationtypeID = -1, createdbyuserID = -1;
            byte applicationstatus = 0;
            decimal paidfees = -1;
            DateTime applicationdate = DateTime.Now, laststatusdate = DateTime.Now;

            if (clsApplicationsDataAccessLayer.GetApplicationInfoByID(ApplicationID, ref applicantpersonID,ref applicationdate, ref applicationtypeID,ref applicationstatus,
                ref laststatusdate, ref paidfees, ref createdbyuserID))
            {
                return new clsApplication(ApplicationID,applicantpersonID,applicationdate,applicationtypeID,applicationstatus,
                laststatusdate,paidfees,createdbyuserID);
            }
            else
            { return null; }
        }

        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationsDataAccessLayer.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus
                , this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return (this.ApplicationID != -1);
        }

        private bool _UpadteApplication()
        {
            return clsApplicationsDataAccessLayer.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus
                , this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }

        static public bool CancelApplication(int ApplicationID)
        {
            return clsApplicationsDataAccessLayer.CancelApplication(ApplicationID);
        }

        static public bool CompleteApplication(int ApplicationID)
        {
            return clsApplicationsDataAccessLayer.CompleteApplication(ApplicationID);
        }

        static public bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationsDataAccessLayer.DeleteApplication(ApplicationID);
        }

        static public DataTable GetAllApplications()
        {
            return clsApplicationsDataAccessLayer.GetAllApplications();
        }

        static public bool IsApplicationExist(int ApplicationID)
        {
            return clsApplicationsDataAccessLayer.IsApplicationExist(ApplicationID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
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

                        return _UpadteApplication();
                    }
            }
            return false;
        }
    }
}
