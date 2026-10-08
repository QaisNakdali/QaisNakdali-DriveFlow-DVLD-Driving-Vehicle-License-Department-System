using DVLDWinFormsDateAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDWinFormsBusinessLayer
{
    public class clsTestAppointments_View
    {
        public int TestAppointmentID { set; get; }
        public int LocalDrivingLicenseApplicationID { set; get; }
        public string TestTypeTitle { set; get; }
        public string ClassName { set; get; }
        public DateTime AppointmentDate { set; get; }
        public decimal PaidFees { set; get; }
        public string FullName { set; get; }
        public byte IsLocked { set; get; }

        private clsTestAppointments_View(int testappointmentID, int localdrivinglicenseapplicationID, string testtypetitle, string classname, DateTime appointmentdate, Decimal paidfees, string fullname, byte islocked)
        {
            TestAppointmentID = testappointmentID;
            LocalDrivingLicenseApplicationID = localdrivinglicenseapplicationID;
            TestTypeTitle = testtypetitle;
            ClassName = classname;
            AppointmentDate = appointmentdate;
            PaidFees = paidfees;
            FullName = fullname;
            IsLocked = islocked;
        }

        public static clsTestAppointments_View FindbyID(int TestAppointmentID)
        {
            string classname = "", testtypetitle = "", fullname = "";
            DateTime appointmentdate = DateTime.Now;
            int localdrivinglicenseapplicationID = -1;
            decimal paidfees = -1;
            byte islocked = 0;

            if (clsTestAppointments_ViewDataAccessLayer.GetTestAppointments_ViewInfoByID(TestAppointmentID, ref localdrivinglicenseapplicationID, ref testtypetitle, ref classname, ref appointmentdate, ref paidfees, ref fullname, ref islocked))
            {
                return new clsTestAppointments_View(TestAppointmentID, localdrivinglicenseapplicationID, testtypetitle, classname, appointmentdate, paidfees, fullname, islocked);
            }
            else
            { return null; }
        }

        static public DataTable GetAllTestAppointments_View()
        {
            return clsTestAppointments_ViewDataAccessLayer.GetAllTestAppointments_View();
        }

        static public bool IsTestAppointment_ViewExist(int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointments_ViewDataAccessLayer.IsTestAppointment_ViewExist(LocalDrivingLicenseApplicationID);
        }

        static public DataTable GetAllTestAppointmentsForOnePerson(int LocalLicenseID)
        {
            return clsTestAppointments_ViewDataAccessLayer.GetAllTestAppointments_ViewForOnePerson(LocalLicenseID);
        }
    }
}