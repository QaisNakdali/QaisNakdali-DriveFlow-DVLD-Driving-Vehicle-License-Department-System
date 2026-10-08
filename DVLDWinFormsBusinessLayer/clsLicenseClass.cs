using DVLDWinFormsDateAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDWinFormsBusinessLayer
{
    public class clsLicenseClass
    {
        public int LicenseClassID { set; get; }
        public string ClassName { set; get; }
        public string ClassDescription { set; get; }
        public byte MinimumAllowedAge { set; get; }
        public byte DefaultValidityLength { set; get; }
        public decimal ClassFees { set; get; }

        private clsLicenseClass(int licenseclassID, string classname, string classdescription, byte minimumallowedage, byte defaultvaliditylength, decimal classfees)
        {
            LicenseClassID = licenseclassID;
            ClassName = classname;
            ClassDescription = classdescription;
            MinimumAllowedAge = minimumallowedage;
            DefaultValidityLength = defaultvaliditylength;
            ClassFees = classfees;
        }

        public static clsLicenseClass FindbyID(int LicenseClassID)
        {
            string classname = "", classdescription = "";
            byte minimumallowedage = 0, defaultvaliditylength = 0;
            decimal classfees = -1;

            if (clsLicenseClassesDataAccessLayer.GetLicenseClassInfoByID(LicenseClassID, ref classname, ref classdescription, ref minimumallowedage, ref defaultvaliditylength, ref classfees))
            {
                return new clsLicenseClass(LicenseClassID, classname, classdescription, minimumallowedage, defaultvaliditylength, classfees);
            }
            else
            { return null; }
        }
        public static clsLicenseClass FindLicenseClassByClassName(string ClassName)
        {
            int licenseclassID = -1;
            string classdescription = "";
            byte minimumallowedage = 0, defaultvaliditylength = 0;
            decimal classfees = -1;

            if (clsLicenseClassesDataAccessLayer.GetLicenseClassInfoByClassName(ClassName, ref licenseclassID, ref classdescription, ref minimumallowedage, ref defaultvaliditylength, ref classfees))
            {
                return new clsLicenseClass(licenseclassID, ClassName, classdescription, minimumallowedage, defaultvaliditylength, classfees);
            }
            else
            { return null; }


        }

        static public DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassesDataAccessLayer.GetAllLicenseClasses();
        }

        static public bool IsLicenseClassExist(int LicenseClassID)
        {
            return clsLicenseClassesDataAccessLayer.IsLicenseClassExist(LicenseClassID);
        }

        static public bool IsLicenseClassExist(string ClassName)
        {
            return clsLicenseClassesDataAccessLayer.IsLicenseClassExist(ClassName);
        }
    }
}
