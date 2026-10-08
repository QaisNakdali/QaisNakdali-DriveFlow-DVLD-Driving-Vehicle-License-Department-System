using DVLDWinFormsDateAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDWinFormsBusinessLayer
{
    public class clsTestType
    {
        public int TestTypeID { set; get; }
        public string TestTypeTitle { set; get; }
        public string TestTypeDescription { set; get; }
        public decimal TestFees { set; get; }
        enum enMode { Update = 1 }
        enMode Mode { set; get; }

        private clsTestType(int TesttypeID, string Testtypetitle,string Testtypedescription, decimal Testfees)
        {
            TestTypeID = TesttypeID;
            TestTypeTitle = Testtypetitle;
            TestTypeDescription = Testtypedescription;
            TestFees = Testfees;
            Mode = enMode.Update;
        }

        public static clsTestType FindbyID(int TestTypeID)
        {
            string TestTypeTitle = "", TestTypeDescription = "";
            decimal TestFees = -1;

            if (clsTestsTypesDataAccessLayer.GetTestTypeInfoByID(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestFees))
            {
                return new clsTestType(TestTypeID, TestTypeTitle,TestTypeDescription, TestFees);
            }
            else
            { return null; }
        }
        public static clsTestType FindbyTestTypeTitle(string TestTypeTitle)
        {
            string TestTypeDescription = "";
            int TestTypeID = -1;
            decimal TestFees = -1;

            if (clsTestsTypesDataAccessLayer.GetTestTypeInfoByTestTypeTitle(TestTypeTitle, ref TestTypeDescription, ref TestTypeID, ref TestFees))
            {
                return new clsTestType(TestTypeID,TestTypeTitle, TestTypeDescription, TestFees);
            }
            else
            { return null; }


        }

        private bool _UpadteTestType()
        {
            return clsTestsTypesDataAccessLayer.UpdateTestsTypes(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestFees);
        }

        static public DataTable GetAllTestsTypes()
        {
            return clsTestsTypesDataAccessLayer.GetAllTestsTypes();
        }

        static public bool IsTestTypeExist(int TestTypeID)
        {
            return clsTestsTypesDataAccessLayer.IsTestTypeExist(TestTypeID);
        }

        static public bool IsTestTypeExist(string TestTypeTitle)
        {
            return clsTestsTypesDataAccessLayer.IsTestTypeExist(TestTypeTitle);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Update:
                    {

                        return _UpadteTestType();
                    }
                default:
                    return false;
            }
        }
    }
}
