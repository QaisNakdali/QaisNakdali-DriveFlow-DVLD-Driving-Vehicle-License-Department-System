using DVLDWinFormsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForms___Presentation_Layer
{
    public partial class ucLocalLicensesManagement : UserControl
    {

        public event EventHandler<string> MenuItemClicked;
        public ucLocalLicensesManagement()
        {
            InitializeComponent();
        }

        private DataTable _LocalLicensesDataTable;
        private async Task LoadData()
        {
            lblLoading.Visible = true;

            _LocalLicensesDataTable = await Task.Run(() => clsLocalDrivingLicenseApplications_View.GetAllLocalDrivingLicenseApplications_View());


            dgvLocalLicensesManagement.DataSource = _LocalLicensesDataTable;

            lblNumberOfLocalLicenses.Text = dgvLocalLicensesManagement.RowCount.ToString();

            lblLoading.Visible = false;
        }

        private async void ucLocalLicensesManagement_Load(object sender, EventArgs e)
        {
            cbLocalLicensesSearchFilter.SelectedIndex = 0;
            await LoadData();
        }

        private void btnBackToPreviousPage_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "Back To Previous Page");
        }

        private void cbLocalLicensesSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocalLicensesSearchFilter.SelectedIndex == 0)
            {
                tbSearch.Visible = false;
            }
            else
            {
                tbSearch.Visible = true;
                tbSearch.Clear();
            }
        }

        private void RunSearch()
        {
            if (_LocalLicensesDataTable == null || cbLocalLicensesSearchFilter.SelectedIndex == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                dgvLocalLicensesManagement.DataSource = _LocalLicensesDataTable;
                return;
            }

            DataRow[] dr = UtilityClass.FilterLocalLicensesDataTableByCondition(_LocalLicensesDataTable, cbLocalLicensesSearchFilter.Text, tbSearch.Text);

            dgvLocalLicensesManagement.DataSource = (dr != null && dr.Length > 0) ? dr.CopyToDataTable() : _LocalLicensesDataTable;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            RunSearch();
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbLocalLicensesSearchFilter.Text == "Local License ID")
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void GetComingSoonMessage()
        {
            MessageBox.Show("This feature is coming soon. Thank you for your patience.", "Coming Soon", MessageBoxButtons.OK);
        }

        private void frmLicenseDetails_RefreshData(object sender, DataTable dtLicesneInfo)
        {
            dgvLocalLicensesManagement.DataSource = dtLicesneInfo;
            lblNumberOfLocalLicenses.Text = dgvLocalLicensesManagement.RowCount.ToString();

        }

        private void btnAddLicense_Click(object sender, EventArgs e)
        {
            frmLicenseDetails frmLicenseDetails = new frmLicenseDetails();
            frmLicenseDetails.RefreshData += frmLicenseDetails_RefreshData;
            frmLicenseDetails.ShowDialog();

        }

        private void addDrivingLicense_Click(object sender, EventArgs e)
        {
            btnAddLicense_Click(sender, e);
        }

        private bool TryGetSelectedLicenseId(out int LicenseId)
        {
            LicenseId = 0;

            if (dgvLocalLicensesManagement.SelectedRows.Count == 0)
            {
                return false;
            }

            LicenseId = Convert.ToInt32(
                dgvLocalLicensesManagement.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value);

            return true;
        }

        private void showDrivingLicenseInfo_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedLicenseId(out int LicenseID))
            {
                MessageBox.Show("Please Select a License First!", "Error", MessageBoxButtons.OK);
                return;
            }

            frmLicenseDetails showLicenseInfo = new frmLicenseDetails(frmLicenseDetails.enMode.Show, LicenseID);


            showLicenseInfo.RefreshData += frmLicenseDetails_RefreshData;

            showLicenseInfo.ShowDialog();
        }

        private void updateDrivnigLicenseInfo_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedLicenseId(out int LicenseID))
            {
                MessageBox.Show("Please Select a License First!", "Error", MessageBoxButtons.OK);
                return;
            }

            frmLicenseDetails AddNewLicenseForm = new frmLicenseDetails(frmLicenseDetails.enMode.Update, LicenseID);

            AddNewLicenseForm.RefreshData += frmLicenseDetails_RefreshData;

            AddNewLicenseForm.ShowDialog();
        }

        private void deleteDrivingLicense_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            if (MessageBox.Show("Are you sure you want to delete this License?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (!TryGetSelectedLicenseId(out int LicenseID))
                {
                    MessageBox.Show("Please Select a License First!", "Error", MessageBoxButtons.OK);
                    return;
                }

                clsLocalLicense.DeleteLocalLicense(LicenseID);
                clsApplication.DeleteApplication(GetApplicationID(LicenseID));


                Refresh_Click(sender, EventArgs.Empty);

            }
        }

        private int GetApplicationID(int LicenseID)
        {
            clsLocalLicense license = clsLocalLicense.FindbyID(LicenseID);
            return license.ApplicationID;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            dgvLocalLicensesManagement.DataSource = clsLocalDrivingLicenseApplications_View.GetAllLocalDrivingLicenseApplications_View();
            lblNumberOfLocalLicenses.Text = dgvLocalLicensesManagement.RowCount.ToString();
        }

        private void CancelDrivingLicesne_Click(object sender, EventArgs e)
        {

            if (!TryGetSelectedLicenseId(out int LicenseID))
            {
                MessageBox.Show("Please Select a License First!", "Error", MessageBoxButtons.OK);
                return;
            }

            clsLocalLicense localLicense = clsLocalLicense.FindbyID(LicenseID);

            clsApplication application = clsApplication.FindbyID(localLicense.ApplicationID);

            clsApplication.CancelApplication(application.ApplicationID);

            Refresh_Click(sender, EventArgs.Empty);
        }

        private void scaduleVisonTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!TryGetSelectedLicenseId(out int LicenseID))
            {
                MessageBox.Show("Please Select a License First!", "Error", MessageBoxButtons.OK);
                return;
            }

            frmVisionTestAppointments frm = new frmVisionTestAppointments(LicenseID);
            frm.ShowDialog();
        }
    }
    }
