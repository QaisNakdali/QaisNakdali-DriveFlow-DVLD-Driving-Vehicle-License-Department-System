using DVLDWinFormsDateAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDWinFormsBusinessLayer
{
    public class clsLocalDrivingLicenseApplications_View
    {
        public int LocalDrivingLicenseApplicationID { set; get; }
        public string ClassName { set; get; }
        public string NationalNO { set; get; }
        public string FullName { set; get; }
        public DateTime ApplicationDate { set; get; }
        public int PassedTestCount { set; get; }
        public string Status { set; get; }

        private clsLocalDrivingLicenseApplications_View(int localdrivinglicenseapplicationID, string classname, string nationalNO, string fullName, DateTime applicationDate, int passedTestCount, string status)
        {
            LocalDrivingLicenseApplicationID = localdrivinglicenseapplicationID;
            ClassName = classname;
            NationalNO = nationalNO;
            FullName = fullName;
            ApplicationDate = applicationDate;
            PassedTestCount = passedTestCount;
            Status = status;
        }

        public static clsLocalDrivingLicenseApplications_View FindbyID(int LocalDrivingLicenseApplicationID)
        {
            string classname = "", nationalNO = "", fullName = "", status = "";
            DateTime applicationDate = DateTime.Now;
            int passedTestCount = 0;

            if (clsLocalLicenseApplicationsViewDataAccessLayer.GetLocalDrivingLicenseApplications_ViewInfoByID(LocalDrivingLicenseApplicationID, ref classname, ref nationalNO, ref fullName, ref applicationDate, ref passedTestCount, ref status))
            {
                return new clsLocalDrivingLicenseApplications_View(LocalDrivingLicenseApplicationID, classname, nationalNO, fullName, applicationDate, passedTestCount, status);
            }
            else
            { return null; }
        }

        static public DataTable GetAllLocalDrivingLicenseApplications_View()
        {
            return clsLocalLicenseApplicationsViewDataAccessLayer.GetAllLocalDrivingLicenseApplications_View();
        }

        static public bool IsLocalDrivingLicenseApplications_ViewExist(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalLicenseApplicationsViewDataAccessLayer.IsLocalDrivingLicenseApplications_ViewExist(LocalDrivingLicenseApplicationID);
        }
        static public bool IsLocalDrivingLicenseApplications_ViewExist(string ClassName, string NationalNo)
        {
            return clsLocalLicenseApplicationsViewDataAccessLayer.IsLocalDrivingLicenseApplications_ViewExist(ClassName,NationalNo);
        }
    }
}
