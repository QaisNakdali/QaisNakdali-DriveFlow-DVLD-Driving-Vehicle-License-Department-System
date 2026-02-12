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
    public partial class ucPeopleScreen : UserControl
    {
        public ucPeopleScreen()
        {
            InitializeComponent();
        }

        private DataTable _PeopleTable;
        private async Task LoadData()
        {
            lblLoading.Visible = true;

            _PeopleTable = await Task.Run(() => clsPerson.GetAllPeople());

            dgvPeopleInformation.DataSource = _PeopleTable;
            HideUnwatedColumns();

            lblNumberOfPeople.Text = dgvPeopleInformation.RowCount.ToString();

            lblLoading.Visible = false;
        }

        private async void ucPeopleScreen_Load(object sender, EventArgs e)
        {
            cbPeopleSearchFilter.SelectedIndex = 0;
            await LoadData();
        }

        private void cbPeopleSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbPeopleSearchFilter.SelectedIndex == 0)
            {
                tbSearch.Visible = false;
            }
            else
            {
                tbSearch.Visible = true;
            }
        }

        private void HideUnwatedColumns()
        {
            dgvPeopleInformation.Columns["Address"].Visible = false;
        }
        private void RunSearch()
        {
            if (_PeopleTable == null || cbPeopleSearchFilter.SelectedIndex == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                dgvPeopleInformation.DataSource = _PeopleTable;
                HideUnwatedColumns();
                return;
            }

            DataRow[] dr = UtilityClass.FilterDataTableByCondition(_PeopleTable, cbPeopleSearchFilter.Text, tbSearch.Text);

            dgvPeopleInformation.DataSource = (dr!=null && dr.Length > 0)? dr.CopyToDataTable() : _PeopleTable;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            RunSearch();
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbPeopleSearchFilter.Text == "Person ID" || cbPeopleSearchFilter.Text == "Nationality" || cbPeopleSearchFilter.Text == "Phone")
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmPersonDetails AddNewPersonForm = new frmPersonDetails(frmPersonDetails.enMode.Add, -1);

            AddNewPersonForm.RefreshData += frmPersonDetails_RefreshData;

            AddNewPersonForm.ShowDialog();
        }

        private void frmPersonDetails_RefreshData(object sender,DataTable dtPeopleInfo)
        {
            dgvPeopleInformation.DataSource = dtPeopleInfo;
            lblNumberOfPeople.Text = dgvPeopleInformation.RowCount.ToString();

        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddUser_Click(sender, e);
        }

        private bool TryGetSelectedPersonId(out int PersonId)
        {
            PersonId = 0;

            if (dgvPeopleInformation.SelectedRows.Count == 0)
            {
                return false;
            }

            PersonId = Convert.ToInt32(
                dgvPeopleInformation.SelectedRows[0].Cells["PersonId"].Value);

            return true;
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedPersonId(out int PersonId))
            {
                MessageBox.Show("Please Select a Person First!", "Error",MessageBoxButtons.OK);
                return;
            }

            frmPersonDetails ShowPersonInfo = new frmPersonDetails(frmPersonDetails.enMode.Show, PersonId);

            ShowPersonInfo.ShowDialog();
        }

        private void updatePersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedPersonId(out int PersonId))
            {
                MessageBox.Show("Please Select a Person First!", "Error", MessageBoxButtons.OK);
                return;
            }

            frmPersonDetails AddNewPersonForm = new frmPersonDetails(frmPersonDetails.enMode.Update, PersonId);

            AddNewPersonForm.RefreshData += frmPersonDetails_RefreshData;

            AddNewPersonForm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            if ( MessageBox.Show("Are you sure you want to delete this person?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                if (!TryGetSelectedPersonId(out int PersonId))
            {
                MessageBox.Show("Please Select a Person First!", "Error", MessageBoxButtons.OK);
                return;
            }

            clsPerson.DeletePerson(PersonId);


            dgvPeopleInformation.DataSource = clsPerson.GetAllPeople();
            lblNumberOfPeople.Text = dgvPeopleInformation.RowCount.ToString();

            }
        }

        private void GetComingSoonMessage()
        {
            MessageBox.Show("This feature is coming soon. Thank you for your patience.", "Coming Soon", MessageBoxButtons.OK);
        }
        private void sentEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetComingSoonMessage();
        }

        private void sendMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetComingSoonMessage();

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvPeopleInformation.DataSource = clsPerson.GetAllPeople();
            lblNumberOfPeople.Text = dgvPeopleInformation.RowCount.ToString();
        }
    }
}
