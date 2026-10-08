using DVLDWinForms___Presentation_Layer.Properties;
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
    public partial class frmPersonDetails : Form
    {

        public delegate void RefreshDataEventHandler(object sender, DataTable dtPeopleInfo);

        public event RefreshDataEventHandler RefreshData;

        public frmPersonDetails(enPersonMode Mode, int PersonId)
        {
            this.SuspendLayout();
            InitializeComponent();
            _Mode = Mode;
            _PersonID = PersonId;
            this.ResumeLayout();
            
        }

        public enum enPersonMode { Add = 1, Show = 2, Update = 3 }
        private static enPersonMode _Mode;
        private int _PersonID = 0;
        private int _NewPersonID = 0;

        private void GetThePanelMode()
        {
            if (DesignMode) return;


            switch (_Mode)
            {
                case enPersonMode.Add:
                    AddNewPersonScreen();
                    break;
                case enPersonMode.Show:
                    ShowPersonInfoScreen();
                    break;
                case enPersonMode.Update:
                    UpdatePersonInfoScreen();
                    break;
                default:
                    return;
            }
        }

        private void AddNewPersonScreen()
        {

            pnlUserControlContainer.Controls.Clear();

            btnEditPerson.Visible = false;
            pbModeIcon.Image = Resources.add_user__2_;
            lblModeName.Text = "Add New Person";
            lblPersonID.Text = "N/A";
            lblPersonID.ForeColor = Color.FromArgb(64, 64, 64);
            var uc = new ucAddNewPersonCard();
            uc.OnSaveComplete += ucAddNewPersonCard2_OnSaveComplete;


            pnlUserControlContainer.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void ShowPersonInfoScreen()
        {
            pnlUserControlContainer.Controls.Clear();

            btnEditPerson.Visible = true;
            pbModeIcon.Image = Resources.information__1_;
            lblModeName.Text = "Show Person Info";
            lblPersonID.Text = _PersonID.ToString();
            lblPersonID.ForeColor = Color.Red;
            var uc = new ucShowPersonInfoCard();
            uc.LoadPerson(_PersonID);
            pnlUserControlContainer.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void UpdatePersonInfoScreen()
        {

            pnlUserControlContainer.Controls.Clear();

            btnEditPerson.Visible = false;
            pbModeIcon.Image = Resources.user_edit;
            lblModeName.Text = "Update Person Info";
            lblPersonID.Text = _PersonID.ToString();
            lblPersonID.ForeColor = Color.Red;
            var uc = new ucAddNewPersonCard();
            uc.LoadPersonForUpdate(_PersonID);
            pnlUserControlContainer.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataTable dtPeopleInfo = clsPerson.GetAllPeople();

            RefreshData?.Invoke(this, dtPeopleInfo);
            DialogResult = DialogResult.OK;

            this.Close();
        }
        private void ucAddNewPersonCard2_OnSaveComplete(int obj)
        {
           _NewPersonID = obj;
            lblPersonID.Text = _NewPersonID.ToString();
            lblPersonID.ForeColor = Color.Red;
        }

        

        private async void frmPersonDetails_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;


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

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            UpdatePersonInfoScreen();
        }
        
        public int GetNewPersonID()
        {
            return _NewPersonID;
        }
    }
}
