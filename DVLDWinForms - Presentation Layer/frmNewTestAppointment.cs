using DVLDWinFormsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForms___Presentation_Layer
{
    public partial class frmNewTestAppointment : Form
    {

        public delegate void RefreshDataEventHandler(object sender, DataTable dtTestAppointments);

        public event RefreshDataEventHandler RefreshData;
        public frmNewTestAppointment()
        {
            InitializeComponent();
        }

        private int _LocalDrivingLicenseApplications_ViewID = -1;
        private byte _TrialNumber = 0;
        private int _TestAppointmentID = -1;
        private clsTestAppointment _TestAppointment;
        private bool _RetakeTest = false;
        private bool _TestResult = false;
        public enum enMode { Add = 0, Update = 1 }

        private static enMode _TestMode;
        public void LoadData(int LocalDrivingLicenseApplications_ViewID, byte TrialNumber, enMode TestMode, int TestAppointmentID, bool TestResult)
        {

            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }
            _LocalDrivingLicenseApplications_ViewID = LocalDrivingLicenseApplications_ViewID;
            _TrialNumber = TrialNumber;
            _TestMode = TestMode;
            _TestAppointmentID = TestAppointmentID;
            ucAddNewTest1.GetTestAppointment_ViewInfo(_LocalDrivingLicenseApplications_ViewID, _TrialNumber);
            _TestResult = TestResult;

            if (_TestResult)
            {
                pnlTestResults.Visible = true;
                ucAddNewTest1.Enabled = false;
            }
            else
            {
                pnlTestResults.Visible = false;
                ucAddNewTest1.Enabled = true;
            }    
        }

        private decimal GetTestPaidFees(int TestTypeID)
        {
            clsTestType TestType = clsTestType.FindbyID(TestTypeID);
            return TestType.TestFees;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_TestMode == enMode.Update)
            {
                _TestAppointment = clsTestAppointment.FindbyID(_TestAppointmentID);
               // _TestAppointment.IsLocked = _TrialNumber 
            }
            else
            {
                _TestAppointment = new clsTestAppointment();
                _TestAppointment.IsLocked = false;
                _TestAppointment.TestTypeID = 1;
            }

            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplications_ViewID;
            _TestAppointment.AppointmentDate = ucAddNewTest1.GetTestTime();
            _TestAppointment.PaidFees = GetTestPaidFees(_TestAppointment.TestTypeID);
            _TestAppointment.CreatedByUserID = 1;

            _TestAppointment.IsLocked = true;

            if (rbFail.Checked)
            {
                _RetakeTest = true;
            }    

            if (_TestAppointment.Save())
            {
                if (_TestMode == enMode.Update)
                {
                    MessageBox.Show("Test Updated Successfully!", "Update Test Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
                else
                {
                    MessageBox.Show("Test Added Successfully!", "Add New Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                _TestAppointmentID = _TestAppointment.TestAppointmentID;

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataTable dtTestAppointments = clsTestAppointment.GetAllTestAppointments();

            RefreshData?.Invoke(this, dtTestAppointments);
            this.Close();

        }
    }
}
