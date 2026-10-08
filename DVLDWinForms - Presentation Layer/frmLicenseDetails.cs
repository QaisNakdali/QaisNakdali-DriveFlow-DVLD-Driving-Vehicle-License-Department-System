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
using static DVLDWinForms___Presentation_Layer.frmLicenseDetails;

namespace DVLDWinForms___Presentation_Layer
{
    public partial class frmLicenseDetails : Form
    {
        public delegate void RefreshDataEventHandler(object sender, DataTable dtLicensesInfo);

        public event RefreshDataEventHandler RefreshData;

        public event Action<int> OnSwapToNextPage;
        public frmLicenseDetails()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            InitializeComponent();
            _Mode = enMode.Add;
            _LicenseId = 0;
        }

        public frmLicenseDetails(enMode Mode, int LocalLicense)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            InitializeComponent();
            _Mode = Mode;
            _LicenseId = LocalLicense;
        }

        public enum enMode { Add = 1, Show = 2, Update = 3 }
        public static enMode _Mode;
        private int _LicenseId = 0;
        private int _PersonID = 0;
        private bool _PersonNotFound { set; get; }
        private bool _AddPerson = false;
        private bool _UpdatePerson = false;
        private bool _SavedLicenseInfo { set; get; }
        private ucAddNewLocalLicense _AddNewLicense = null;
        private ucShowDrivingLicenseInfoCard _ShowLicenseInfoCard = null;


        private void GetThePanelMode()
        {
            if (DesignMode) return;

            switch (_Mode)
            {
                case enMode.Add:
                    AddNewLicenseScreen();
                    break;
                case enMode.Show:
                    _PersonID =GetExistLicenseInfo(_LicenseId);
                    ShowLicenseInfoScreen(_PersonID);
                    break;
                case enMode.Update:
                    _PersonID = GetExistLicenseInfo(_LicenseId);
                    UpdateLicenseInfoScreen();
                    break;
                default:
                    return;
            }

        }



        private int GetExistLicenseInfo(int _LicenseId)
        {
            _ShowLicenseInfoCard = new ucShowDrivingLicenseInfoCard();
            _ShowLicenseInfoCard.LoadLicense(_LicenseId);
            return _ShowLicenseInfoCard.GetLicensePersonID();
        }

        private void AddNewLicenseScreen()
        {

            _AddPerson = true;
            _UpdatePerson = false;
            pnlLicenseControlContainer.Controls.Clear();
            btnEditPerson.Visible = false;
            btnAddPerson.Visible = true;
            //pbModeIcon.Image = Resources.add_License__2_;
            lblModeName.Text = "Add New License";
            lblPersonID.Text = "N/A";
            lblPersonID.ForeColor = Color.FromArgb(64, 64, 64);
            var uc = new ucShowPersonInfoCard();
            pnlLicenseControlContainer.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;

        }

        private void ShowLicenseInfoScreen(int PersonId)
        {


            btnAddPerson.Visible = true;


            var uc = new ucShowPersonInfoCard();

            uc.IsNotFound += ucShowPersonInfoCard_PersonNotFound;

            uc.LoadPerson(PersonId);

            if (_PersonNotFound)
            {
                return;
            }

            if (!_AddPerson || !_UpdatePerson)
            {
                //pbModeIcon.Image = Resources.information__1_;
                lblModeName.Text = "Show License Info";
                ucPeopleSearch1.Visible = false;
                btnAddPerson.Visible = false;
            }
            _AddPerson = false;
            _UpdatePerson = false;
            lblPersonID.Text = PersonId.ToString();
            lblPersonID.ForeColor = Color.Red;
            pnlLicenseControlContainer.Controls.Clear();
            pnlLicenseControlContainer.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            btnNextPage.Enabled = true;
        }

        private void UpdateLicenseInfoScreen()
        {
            btnAddPerson.Visible = false;
            btnEditPerson.Visible = true;
            btnNextPage.Enabled = true;
            ShowLicenseInfoScreen(_PersonID);
            _UpdatePerson = true;
            _AddPerson = false;
            //pbModeIcon.Image = Resources.License_edit;
            lblModeName.Text = "Update License Info";
            lblPersonID.Text = _PersonID.ToString();
            lblPersonID.ForeColor = Color.Red;
        }

        private void UpdateLicenseInfoNextPage()
        {
            if (_AddNewLicense == null)
            {
                _AddNewLicense = new ucAddNewLocalLicense();
            }
            SendPersonIDToNextPage(_AddNewLicense);
            _AddNewLicense.LoadLicenseForUpdate(_LicenseId);
            pnlLicenseControlContainer.Controls.Clear();
            pnlLicenseControlContainer.Controls.Add(_AddNewLicense);
            _AddNewLicense.Dock = DockStyle.Fill;

        }
        private void ucShowPersonInfoCard_PersonNotFound(object sender, bool PersonNotFound)
        {
            _PersonNotFound = PersonNotFound;
            if (_PersonNotFound)
            {
                MessageBox.Show("Person Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private async void frmLicenseDetails_Load(object sender, EventArgs e)
        {
            pnlLoading.BringToFront();
            pnlLoading.Visible = true;
            pnlMain.Visible = false;

            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(500);
            });

            pnlLoading.Visible = false;
            pnlMain.Visible = true;
            GetThePanelMode();
        }

        private void ucPeopleSearch1_SearchComplete(object sender, int PersonID)
        {
            _AddPerson = true;
            ShowLicenseInfoScreen(PersonID);
            _AddPerson = true;
        }

        private void AddNewLicenseNextPage()
        {
            if (_AddNewLicense == null)
            {
               _AddNewLicense = new ucAddNewLocalLicense();
            }

            pnlLicenseControlContainer.Controls.Clear();
            pnlLicenseControlContainer.Controls.Add(_AddNewLicense);
            _AddNewLicense.Dock = DockStyle.Fill;
            SendPersonIDToNextPage(_AddNewLicense);
            _SavedLicenseInfo = false;
        }

        private void SendPersonIDToNextPage(ucAddNewLocalLicense _AddNewLicesne)
        {
            int PersonId = int.Parse(lblPersonID.Text);
            _AddNewLicense.GetPersonID(PersonId);
        }
        private void ShowLicenseInfoNextPage()
        {
            pnlLicenseControlContainer.Controls.Clear();
            pnlLicenseControlContainer.Controls.Add(_ShowLicenseInfoCard);
            _ShowLicenseInfoCard.Dock = DockStyle.Fill;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            btnPerviousPage.Visible = true;
            btnAddPerson.Visible = false;
            btnNextPage.Visible = false;
            btnEditPerson.Visible = false;
            ucPeopleSearch1.Visible = false;


            if (_AddPerson)
            {
                AddNewLicenseNextPage();
            }
            else if (_UpdatePerson)
            {
                UpdateLicenseInfoNextPage();
            }
            else
            {
                ShowLicenseInfoNextPage();
            }
        }

        private void btnPerviousPage_Click(object sender, EventArgs e)
        {
            if (_AddPerson)
            {
                btnAddPerson.Visible = true;
                ucPeopleSearch1.Visible = true;
            }
            if (_UpdatePerson)
            {
                btnEditPerson.Visible = true;
            }
            btnPerviousPage.Visible = false;
            btnNextPage.Visible = true;
            _SavedLicenseInfo = true;

            var uc = new ucShowPersonInfoCard();

            int PersonId = int.Parse(lblPersonID.Text);
            uc.LoadPerson(PersonId);

            pnlLicenseControlContainer.Controls.Clear();
            pnlLicenseControlContainer.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(frmPersonDetails.enPersonMode.Add, -1);
            frm.ShowDialog();

            _PersonID = frm.GetNewPersonID();

            if (_PersonID > 0)
            {
                _AddPerson = true;
                ShowLicenseInfoScreen(_PersonID);
            }

        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(frmPersonDetails.enPersonMode.Update, _PersonID);
            frm.ShowDialog();

            _AddPerson = false;
            if (_PersonID > 0)
            {

                UpdateLicenseInfoScreen();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataTable dt = clsLocalDrivingLicenseApplications_View.GetAllLocalDrivingLicenseApplications_View();

            RefreshData?.Invoke(this, dt);
            this.Close();
        }
    }

}
