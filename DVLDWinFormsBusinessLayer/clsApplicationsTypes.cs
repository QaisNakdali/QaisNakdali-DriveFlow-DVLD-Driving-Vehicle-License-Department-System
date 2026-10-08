using DVLDWinFormsDateAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDWinFormsBusinessLayer
{
    public class clsApplicationType
    {
            public int ApplicationTypeID { set; get; }
            public string ApplicationTypeTitle { set; get; }
            public decimal ApplicationFees { set; get; }

            enum enMode {Update = 1}

            enMode Mode { set; get; }

            private clsApplicationType(int applicationtypeID, string applicationtypetitle, decimal applicationfees)
            {
                ApplicationTypeID = applicationtypeID;
                ApplicationTypeTitle = applicationtypetitle;
                ApplicationFees = applicationfees;
                Mode = enMode.Update;
            }

            public static clsApplicationType FindbyID(int ApplicationTypeID)
            {
            string ApplicationTypeTitle = "";
            decimal ApplicationFees = -1;

                if (clsApplicationsTypesDataAccessLayer.GetApplicationTypeInfoByID(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
                {
                    return new clsApplicationType(ApplicationTypeID,ApplicationTypeTitle,ApplicationFees);
                }
                else
                { return null; }
            }
            public static clsApplicationType FindbyApplicationTypeTitle(string ApplicationTypeTitle)
            {
                int ApplicationTypeID = -1;
                decimal ApplicationFees = -1;

                if (clsApplicationsTypesDataAccessLayer.GetApplicationTypeInfoByApplicationTypeTitle(ApplicationTypeTitle, ref ApplicationTypeID, ref ApplicationFees))
                {
                    return new clsApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
                }
                else
                { return null; }


            }

            static public DataTable GetAllApplicationsTypes()
            {
                return clsApplicationsTypesDataAccessLayer.GetAllApplicationsTypes();
            }

            static public bool IsApplicationTypeExist(int ApplicationTypeID)
            {
                return clsApplicationsTypesDataAccessLayer.IsApplicationTypeExist(ApplicationTypeID);
            }

            static public bool IsApplicationTypeExist(string ApplicationTypeTitle)
            {
                return clsApplicationsTypesDataAccessLayer.IsApplicationTypeExist(ApplicationTypeTitle);
            }
    }
}
