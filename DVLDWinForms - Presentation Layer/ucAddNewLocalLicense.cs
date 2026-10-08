using DVLDWinFormsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForms___Presentation_Layer
{
    public partial class ucAddNewLocalLicense : UserControl
    {
        public ucAddNewLocalLicense()
        {
            InitializeComponent();
        }

        private bool _HasErrors = false;
        private int _PersonID = -1;
        private int _ApplicationID = -1;
        private int _DrivingLicenseID = -1;
        private int _LicenseClassID = -1;
        private bool _IsUpdateMode = false;
        private clsPerson Person = null;
        private void btnSave_Click(object sender, EventArgs e)
        {
            _HasErrors = IsThereAnyInfoErrors();

            if (_HasErrors)
            {
                MessageBox.Show("Please complete all required fields in correct way!", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsApplication Application1;

            if (_IsUpdateMode)
            {
                Application1 = clsApplication.FindbyID(_ApplicationID);

            }
            else
            {
                Application1 = new clsApplication();
            }



            GetPersonInfo();
            if (Person == null)
            {
                MessageBox.Show("No person selected. Please select a person before saving the license.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Application1.ApplicantPersonID = _PersonID;
            Application1.ApplicationDate = DateTime.Now;
            Application1.ApplicationTypeID = 1;
            Application1.ApplicationStatus = 1;
            Application1.LastStatusDate = DateTime.Now;
            Application1.PaidFees = 15;
            Application1.CreatedByUserID = 1;


            if (Application1.Save())
            {


                clsLocalLicense localLicense1;

                if (_IsUpdateMode)
                {
                    localLicense1 = clsLocalLicense.FindbyID(_DrivingLicenseID);

                }
                else
                {
                    localLicense1 = new clsLocalLicense();
                }

                localLicense1.ApplicationID = Application1.ApplicationID;
                localLicense1.LicenseClassID = cbLicenseClass.SelectedIndex;

                if (IsLiecenseExist(Person.NationalNo,cbLicenseClass.SelectedItem.ToString()))
                {
                    MessageBox.Show("License Already Exist!", "Add/Update Licese", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                

                if (localLicense1.Save())
                {
                    if (_IsUpdateMode)
                    {
                        MessageBox.Show("License Updated Successfully!", "Update License Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        localLicense1.LicenseClassID = cbLicenseClass.SelectedIndex;
                    }
                    else
                    {
                        MessageBox.Show("License Added Successfully!", "Add New Licese", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    lblDrivingLicenseID.Text = localLicense1.LocalDrivingLicenseApplicationID.ToString();   
                }
                else
                {
                    MessageBox.Show("Something went wrong..\nTry Again!", "Add New License", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool IsLiecenseExist(string NationalNo, string ClassName)
        {
            return clsLocalDrivingLicenseApplications_View.IsLocalDrivingLicenseApplications_ViewExist(ClassName, NationalNo);
        }

        public void LoadLicenseForUpdate(int LicenseID)
        {
            _DrivingLicenseID = LicenseID;
            _IsUpdateMode = true;

            clsLocalLicense LicenseInfo = clsLocalLicense.FindbyID(LicenseID);

            _LicenseClassID = LicenseInfo.LicenseClassID;
            LoadApplicationForUpdate(LicenseInfo.ApplicationID);
        }
        public void LoadApplicationForUpdate(int ApplicationID)
        {
            _ApplicationID = ApplicationID;
            _IsUpdateMode = true;
            FillLicenseInfo();

        }

        private void GetPersonInfo()
        {
            Person = clsPerson.FindbyID(_PersonID);
        }
        private void FillLicenseInfo()
        {
            clsApplication Application1 = clsApplication.FindbyID(_ApplicationID);

            if (Application1 == null)
                return;


            lblApplicationDate.Text = Application1.ApplicationDate.ToShortDateString();
            cbLicenseClass.SelectedIndex = _LicenseClassID;
            lblApplicationFees.Text = Application1.PaidFees.ToString();
            lblCreatedBy.Text = Application1.CreatedByUserID.ToString();
            lblDrivingLicenseID.Text = Application1.ApplicationID.ToString();
        }

        private bool IsThereAnyInfoErrors()
        {
            if (cbLicenseClass.SelectedIndex == 0)
            {
                return true;
            }
            return false;
        }

        public void GetPersonID(int PersonID)
        {
            _PersonID = PersonID;
        }

        private void ucAddNewLocalLicense_Load(object sender, EventArgs e)
        {
            if (!_IsUpdateMode)
            {
                lblApplicationDate.Text = DateTime.Now.ToShortDateString();
                lblApplicationFees.Text = "15";
                lblCreatedBy.Text = "Qais";
            }
        }
    }
}
