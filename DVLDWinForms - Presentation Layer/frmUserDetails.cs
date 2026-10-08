using DVLDWinForms___Presentation_Layer.Properties;
using DVLDWinFormsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForms___Presentation_Layer
{


    public partial class frmUserDetails : Form
    {

        public delegate void RefreshDataEventHandler(object sender, DataTable dtUsersInfo);

        public event RefreshDataEventHandler RefreshData;

        public event Action<int> OnSwapToNextPage;
        public frmUserDetails()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            InitializeComponent();
            _Mode = enMode.Add;
            _UserId = 0;
        }

        public frmUserDetails(enMode Mode, int UserId)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            this.SuspendLayout();
            InitializeComponent();
            _Mode = Mode;
            _UserId = UserId;
            this.ResumeLayout();
        }

        public enum enMode { Add = 1, Show = 2, Update = 3 }
        public static enMode _Mode;
        private int _UserId = 0;
        private int _PersonID = 0;
        private bool _PersonNotFound { set; get;  }
        private bool _AddPerson = false;
        private bool _UpdatePerson = false;
        private bool _SavedUserInfo { set; get; }
        private ucAddNewUser _AddNewUser = null;
        private ucShowUserInfoCard _ShowUserInfoCard = null;

        private void GetThePanelMode()
        {
            if (DesignMode) return;
    
            switch (_Mode)
            {
                case enMode.Add:
                    AddNewUserScreen();
                    break;
                case enMode.Show:
                    _PersonID = GetExistUserInfo(_UserId);
                   ShowUserInfoScreen(_PersonID);
                    break;
                case enMode.Update:
                    _PersonID = GetExistUserInfo(_UserId);
                    UpdateUserInfoScreen();
                    break;
                default:
                    return;
            }
        }

        private int GetExistUserInfo(int UserId)
        {
            _ShowUserInfoCard = new ucShowUserInfoCard();
            _ShowUserInfoCard.LoadUser(_UserId);
            return _ShowUserInfoCard.GetUserPersonID();
        }

        private void AddNewUserScreen()
        {
       
            _AddPerson = true;
            _UpdatePerson = false;
            pnlUserControlContainer.Controls.Clear();
            btnEditPerson.Visible = false;
            btnAddPerson.Visible = true;
            pbModeIcon.Image = Resources.add_user__2_;
            lblModeName.Text = "Add New User";
            lblPersonID.Text = "N/A";
            lblPersonID.ForeColor = Color.FromArgb(64, 64, 64);
            var uc = new ucShowPersonInfoCard();
            pnlUserControlContainer.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
                  
        }

        private void ShowUserInfoScreen(int PersonId)
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
                pbModeIcon.Image = Resources.information__1_;
                lblModeName.Text = "Show User Info";
                ucPeopleSearch1.Visible = false;
                btnAddPerson.Visible = false;
            }
            _AddPerson = false;
            _UpdatePerson = false;
            lblPersonID.Text = PersonId.ToString();
            lblPersonID.ForeColor = Color.Red;
            pnlUserControlContainer.Controls.Clear();
            pnlUserControlContainer.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            btnNextPage.Enabled = true;
        }

        private void UpdateUserInfoScreen()
        {
            btnAddPerson.Visible = false;
            btnEditPerson.Visible = true;
            btnNextPage.Enabled = true;
            ShowUserInfoScreen(_PersonID);
            _UpdatePerson = true;
            _AddPerson = false;
            pbModeIcon.Image = Resources.user_edit;
            lblModeName.Text = "Update User Info";
            lblPersonID.Text = _PersonID.ToString();
            lblPersonID.ForeColor = Color.Red;
        }

        private void UpdateUserInfoNextPage()
        {
            ucAddNewUser uc = new ucAddNewUser();
            uc.LoadUserForUpdate(_UserId);
            pnlUserControlContainer.Controls.Clear();
            pnlUserControlContainer.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataTable dtUsersInfo = clsUsers.GetAllUsers();

            RefreshData?.Invoke(this, dtUsersInfo);
            this.Close();
        }

        private async void frmUserDetails_Load(object sender, EventArgs e)
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

            ShowUserInfoScreen(PersonID);
            _AddPerson = true;
        }

        private void ucShowPersonInfoCard_PersonNotFound(object sender, bool PersonNotFound)
        {
            _PersonNotFound = PersonNotFound;
             if (_PersonNotFound)
            {
                MessageBox.Show("Person Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void AddNewUserNextPage()
        {
            if (_AddNewUser == null)
            {
                _AddNewUser = new ucAddNewUser();
                _AddNewUser.ConnectToFormUserDetails(this);
            }

            pnlUserControlContainer.Controls.Clear();
            pnlUserControlContainer.Controls.Add(_AddNewUser);
            _AddNewUser.Dock = DockStyle.Fill;

            int PersonId = int.Parse(lblPersonID.Text);
            if (_SavedUserInfo)
            {
                OnSwapToNextPage?.Invoke(PersonId);
            }
            _SavedUserInfo = false;
        }

        private void ShowUserInfoNextPage()
        {
            pnlUserControlContainer.Controls.Clear();
            pnlUserControlContainer.Controls.Add(_ShowUserInfoCard);
            _ShowUserInfoCard.Dock = DockStyle.Fill;
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
                AddNewUserNextPage();
            }
           else if (_UpdatePerson)
            {
                UpdateUserInfoNextPage();
            }
           else
            {
                ShowUserInfoNextPage();
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
                btnEditPerson.Visible= true;
            }
            btnPerviousPage.Visible = false;
            btnNextPage.Visible = true;
            _SavedUserInfo = true;

            var uc = new ucShowPersonInfoCard();
           
            int PersonId = int.Parse(lblPersonID.Text);
            uc.LoadPerson(PersonId);

            pnlUserControlContainer.Controls.Clear();
            pnlUserControlContainer.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(frmPersonDetails.enPersonMode.Add, -1);
            frm.ShowDialog();
           
            _PersonID = frm.GetNewPersonID();
           
            if (_PersonID >0)
            {
                _AddPerson = true;
                ShowUserInfoScreen(_PersonID);
            }
          
            
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(frmPersonDetails.enPersonMode.Update, _PersonID);
            frm.ShowDialog();

            _AddPerson = false;
            if (_PersonID > 0)
            {

                UpdateUserInfoScreen();
            }
        }
    }
}
