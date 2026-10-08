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
    public partial class ucApplicationsInfoShort : UserControl
    {
        public ucApplicationsInfoShort()
        {
            InitializeComponent();
        }

        private clsApplication _Application;

        private int _ApplicationID;

        private int _LicenseID;

        private clsPerson _Person;
        public void LoadApplication(int ApplicationID, int LicenseID)
        {
            _ApplicationID = ApplicationID;
            _LicenseID = LicenseID;
            FillApplicationInfoCard();
        }

        private void GetPersonInfo()
        {
            _Person = clsPerson.FindbyID(_Application.ApplicantPersonID); 
        }
        private clsApplication GetApplicationInfo()
        {
            clsApplication Application = clsApplication.FindbyID(_ApplicationID);
            return Application;
        }
        private void FillApplicationInfoCard()
        {
            _Application = GetApplicationInfo();

            if (_Application == null)
            {
                MessageBox.Show("Application is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GetPersonInfo();

            lblApplicationID.Text = _Application.ApplicationID.ToString();
            lblStatus.Text = _Application.ApplicationStatus.ToString();
            lblFees.Text = _Application.PaidFees.ToString();
            lblType.Text = GetApplicationTypeTitle(_Application.ApplicationTypeID);
            lblApplicantPersonName.Text = _Person.FullName();
            lblApplicationDate.Text = _Application.ApplicationDate.ToShortDateString();
            lblLastStatusDate.Text = _Application.LastStatusDate.ToShortDateString();
            lblCreatedBy.Text = GetCreatedUserName(_Application.CreatedByUserID);

        }

        private string GetCreatedUserName (int CreatedUserID)
        {
            clsUsers User = clsUsers.FindByUserID(CreatedUserID);
            return User.UserName;
        }
        private string GetApplicationTypeTitle(int ApplicationTypeID)
        {
            clsApplicationType ApplicationType = clsApplicationType.FindbyID(ApplicationTypeID);
            return ApplicationType.ApplicationTypeTitle;
        }

        private void lblShowPersonAndLicenseFullInfo_Click(object sender, EventArgs e)
        {
            frmLicenseDetails showLicenseInfo = new frmLicenseDetails(frmLicenseDetails.enMode.Show, _LicenseID);

            showLicenseInfo.ShowDialog();
        }
    }
}
