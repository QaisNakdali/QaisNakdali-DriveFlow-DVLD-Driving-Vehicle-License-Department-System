using DVLDWinFormsDateAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDWinFormsBusinessLayer
{
    public class clsTestAppointment
    {
        public int TestAppointmentID { set; get; }
        public int TestTypeID { set; get; }
        public int LocalDrivingLicenseApplicationID { set; get; }
        public DateTime AppointmentDate { set; get; }
        public Decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsLocked { set; get; }

        enum enMode { AddNew = 1, Update = 2 }

        enMode Mode { set; get; }

        public clsTestAppointment()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;
            this.IsLocked = false;

            Mode = enMode.AddNew;

        }

        private clsTestAppointment(int testappointmentID, int testtypeID, int localdrivinglicenseapplicationID, DateTime appointmentdate, decimal paidfees, int createdbyuserID, bool islocked)
        {
            TestAppointmentID = testappointmentID;
            TestTypeID = testtypeID;
            LocalDrivingLicenseApplicationID = localdrivinglicenseapplicationID;
            AppointmentDate = appointmentdate;
            PaidFees = paidfees;
            CreatedByUserID = createdbyuserID;
            IsLocked = islocked;

            Mode = enMode.Update;
        }

        public static clsTestAppointment FindbyID(int TestAppointmentID)
        {
            int TestTypeID = -1, LocalDrivingLicenseApplicationID = -1, CreatedByUserID = -1;
            DateTime AppointmentDate = DateTime.Now;
            bool IsLocked = false;
            decimal PaidFees = -1;

            if (clsTestAppointmentsDataAccessLayer.GetTestAppointmentByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked))
            {
                return new clsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate.Date, PaidFees, CreatedByUserID, IsLocked);
            }
            else
            { return null; }
        }

        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentsDataAccessLayer.AddNewTestAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);

            return (this.TestAppointmentID != -1);
        }

        private bool _UpadteTestAppointment()
        {
            return clsTestAppointmentsDataAccessLayer.UpdateTestAppointment(this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);
        }

        static public bool DeleteTestAppointment(int TestAppointmentID)
        {
            return clsTestAppointmentsDataAccessLayer.DeleteTestAppointment(TestAppointmentID);
        }

        static public DataTable GetAllTestAppointments()
        {
            return clsTestAppointmentsDataAccessLayer.GetAllTestAppointments();
        }

        static public bool IsTestAppointmentExist(int TestAppointmentID)
        {
            return clsTestAppointmentsDataAccessLayer.IsTestAppointmentExist(TestAppointmentID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
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

                        return _UpadteTestAppointment();
                    }
            }
            return false;
        }
    }
}