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
    public partial class frmVisionTestAppointments : Form
    {
        public frmVisionTestAppointments(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        private int _TestAppointmentID = -1;
        private async Task LoadData()
        {
            lblLoading.Visible = true;

            _TestAppointmentsTable = await Task.Run(() => clsTestAppointments_View.GetAllTestAppointmentsForOnePerson(_LicenseID));


            dgvAppointments.DataSource = _TestAppointmentsTable;
            if (dgvAppointments.RowCount > 0)
            {
                HideUnwatedColumns();
            }
            if ((bool)dgvAppointments.CurrentRow.Cells["IsLocked"].Value)
            {
                TakeTest.Enabled = false;
                UpdateTest.Enabled = false;
            }
            else
            {
                TakeTest.Enabled = true;
                UpdateTest.Enabled = true;
            }
            lblNumberOfAppointments.Text = dgvAppointments.RowCount.ToString();

            lblLoading.Visible = false;
        }

        private void HideUnwatedColumns()
        {
            dgvAppointments.Columns["TestTypeTitle"].Visible = false;
            dgvAppointments.Columns["LocalDrivingLicenseApplicationID"].Visible = false;
            dgvAppointments.Columns["ClassName"].Visible = false;
            dgvAppointments.Columns["FullName"].Visible = false;
        }
        private int _LicenseID = 0;
        private DataTable _TestAppointmentsTable;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int GetApplicationID()
        {
            clsLocalLicense localLicense = clsLocalLicense.FindbyID(_LicenseID);

            return localLicense.ApplicationID;
        }

        private async void frmVisionTestAppointments_Load(object sender, EventArgs e)
        {
            ucDrivingLicenseInfoShort1.LoadLicense(_LicenseID);

            ucApplicationsInfoShort1.LoadApplication(GetApplicationID(),_LicenseID);

            await LoadData();


        }

        private void lblNewTest_Click(object sender, EventArgs e)
        {
            frmNewTestAppointment frm = new frmNewTestAppointment();
            frm.LoadData(_LicenseID, (byte)(dgvAppointments.RowCount + 1),frmNewTestAppointment.enMode.Add, -1, false);

            frm.RefreshData += frmNewTestAppointment_RefreshData;

            frm.ShowDialog();
        }

        private void frmNewTestAppointment_RefreshData(object sender, DataTable dtTestAppointments)
        {
            dgvAppointments.DataSource = clsTestAppointments_View.GetAllTestAppointmentsForOnePerson(_LicenseID);
        }

        private void TakeTest_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = Convert.ToInt32(dgvAppointments.CurrentRow.Cells["TestAppointmentID"].Value);
            frmNewTestAppointment frm = new frmNewTestAppointment();
            frm.LoadData(_LicenseID, (byte)(dgvAppointments.RowCount + 1), frmNewTestAppointment.enMode.Update, TestAppointmentID, true);
            frm.RefreshData += frmNewTestAppointment_RefreshData;
            frm.ShowDialog();
        }

        private void UpdateTest_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = Convert.ToInt32(dgvAppointments.CurrentRow.Cells["TestAppointmentID"].Value);
            frmNewTestAppointment frm = new frmNewTestAppointment();
            frm.LoadData(_LicenseID, (byte)(dgvAppointments.RowCount + 1), frmNewTestAppointment.enMode.Update, TestAppointmentID, false);
            frm.RefreshData += frmNewTestAppointment_RefreshData;
            frm.ShowDialog();
        }
    }
}
