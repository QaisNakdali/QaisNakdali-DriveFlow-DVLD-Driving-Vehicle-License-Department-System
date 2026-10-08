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
    public partial class ucDrivingLicenseInfoShort : UserControl
    {
        public ucDrivingLicenseInfoShort()
        {
            InitializeComponent();
        }

        private clsLocalDrivingLicenseApplications_View _LocalDrivingLicenseApplications_View;

        private int _LocalDrivingLicenseApplicationID;

        public void LoadLicense(int LocalDrivingLicenseApplicationID)
        {
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            FillLicenseInfoCard();
        }

        public int GetLicensePersonID()
        {
            clsPerson person = clsPerson.FindbyNationalNo(_LocalDrivingLicenseApplications_View.NationalNO);
            return person.PersonID;
        }
        private clsLocalDrivingLicenseApplications_View GetDrivingLicenseInfo()
        {
            clsLocalDrivingLicenseApplications_View DrivingLicense = clsLocalDrivingLicenseApplications_View.FindbyID(_LocalDrivingLicenseApplicationID);
            return DrivingLicense;
        }
        private void FillLicenseInfoCard()
        {
            _LocalDrivingLicenseApplications_View = GetDrivingLicenseInfo();

            if (_LocalDrivingLicenseApplications_View == null)
            {
                MessageBox.Show("License is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDrivingLicenseID.Text = _LocalDrivingLicenseApplications_View.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseClass.Text = _LocalDrivingLicenseApplications_View.ClassName.ToString();
            lblPassedTests.Text = _LocalDrivingLicenseApplications_View.PassedTestCount.ToString() + "/3";

        }
    }
}
