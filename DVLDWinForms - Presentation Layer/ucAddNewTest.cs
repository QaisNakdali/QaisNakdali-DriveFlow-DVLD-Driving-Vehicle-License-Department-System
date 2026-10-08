using DVLDWinFormsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForms___Presentation_Layer
{
    public partial class ucAddNewTest : UserControl
    {
        public ucAddNewTest()
        {
            InitializeComponent();
        }

        private clsLocalDrivingLicenseApplications_View _LocalDrivingLicenseApplications_View;
        private byte _Trial = 0;
        private bool _IsUpdate = false;
        public void GetTestAppointment_ViewInfo(int _LocalDrivingLicenseApplications_ViewID, byte TrialNumber)
        {
            _Trial = TrialNumber;
            _LocalDrivingLicenseApplications_View = clsLocalDrivingLicenseApplications_View.FindbyID(_LocalDrivingLicenseApplications_ViewID);
        }

        private decimal GetPaidFees(string ClassName)
        {
            clsLicenseClass licenseClass = clsLicenseClass.FindLicenseClassByClassName(ClassName);
            return licenseClass.ClassFees;
        }

        public DateTime GetTestTime()
        {
            return dtpTestDate.Value;
        }
        private void ucAddNewTest_Load(object sender, EventArgs e)
        {
            lblDrivingLicenseApplicationID.Text = _LocalDrivingLicenseApplications_View.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = _LocalDrivingLicenseApplications_View.ClassName.ToString();
            lblPersonName.Text = _LocalDrivingLicenseApplications_View.FullName.ToString();
            lblTrial.Text = _Trial.ToString();
            lblFees.Text = GetPaidFees(_LocalDrivingLicenseApplications_View.ClassName).ToString();
   

                dtpTestDate.MinDate = DateTime.Now.AddDays(1);
                dtpTestDate.MaxDate = DateTime.Now.AddYears(1);
            
         
        }
    }
}
