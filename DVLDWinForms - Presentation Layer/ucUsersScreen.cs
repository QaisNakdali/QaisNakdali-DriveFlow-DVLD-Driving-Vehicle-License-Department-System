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
    public partial class ucUsersScreen : UserControl
    {
        public ucUsersScreen()
        {
            InitializeComponent();
        }

        private DataTable _UsersTable;
        private bool IsActive;
        private async Task LoadData()
        {
            lblLoading.Visible = true;

            _UsersTable = await Task.Run(() => clsUsers.GetAllUsers());


            AddFullNameColumn();
            PopulateFullNameColumn();
            dgvUsersInformation.DataSource = _UsersTable;
            HideUnwatedColumns();

            lblNumberOfUsers.Text = dgvUsersInformation.RowCount.ToString();

            lblLoading.Visible = false;
        }

        private async void ucUsersScreen_Load(object sender, EventArgs e)
        {
            await LoadData();
            cbUsersSearchFilter.SelectedIndex = 0;
            cbIsActive.SelectedIndex = 0;
        }

        private void HideUnwatedColumns()
        {
            dgvUsersInformation.Columns["Password"].Visible = false;
        }

        private void AddFullNameColumn()
        {
            _UsersTable.Columns.Add("FullName", typeof(string));
            _UsersTable.Columns["FullName"].SetOrdinal(2);
        }

        private void PopulateFullNameColumn()
        {
            int countrer = 0;
            foreach (DataRow row in _UsersTable.Rows)
            {
                clsPerson Person = clsPerson.FindbyID(Convert.ToInt32(_UsersTable.Rows[countrer]["PersonID"]));
                row["FullName"] = Person.FullName();
                countrer++;
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbUsersSearchFilter.Text == "User ID" || cbUsersSearchFilter.Text == "User ID")
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void RunSearch()
        {
            if (_UsersTable == null || cbUsersSearchFilter.SelectedIndex == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(tbSearch.Text) && cbUsersSearchFilter.SelectedIndex != 5)
            {
                dgvUsersInformation.DataSource = _UsersTable;
                HideUnwatedColumns();
                return;
            }

            DataRow[] dr;

            if (cbUsersSearchFilter.SelectedIndex != 5)
            {
                dr = UtilityClass.FilterUsersDataTableByCondition(_UsersTable, cbUsersSearchFilter.Text, tbSearch.Text);
            }
            else
            {
                dr = UtilityClass.FilterUsersDataTableByCondition(_UsersTable, cbUsersSearchFilter.Text, IsActive.ToString());
            }

            dgvUsersInformation.DataSource = (dr != null && dr.Length > 0) ? dr.CopyToDataTable() : _UsersTable;
        }


        private void cbUsersSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUsersSearchFilter.SelectedIndex == 0)
            {
                tbSearch.Visible = false;
                cbIsActive.Visible = false;
            }
            else if (cbUsersSearchFilter.SelectedIndex == 5)
            {
                tbSearch.Visible = false;
                cbIsActive.Visible = true;
            }
            else
            {
                tbSearch.Visible = true;
                cbIsActive.Visible = false;
                tbSearch.Clear();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            RunSearch();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsActive.SelectedIndex == 1)
            {
                IsActive = true;
            }
            else if (cbIsActive.SelectedIndex == 2)
            {
                IsActive = false;
            }
            else
            {
                refreshToolStripMenuItem_Click(sender, e);
                return;
            }

            RunSearch();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUser = new frmUserDetails(frmUserDetails.enMode.Add,-1);

            frmUser.RefreshData += frmUserDetails_RefreshData;

            frmUser.ShowDialog();
        }

        private void frmUserDetails_RefreshData(object sender, DataTable dtUsersInfo)
        {
            dgvUsersInformation.DataSource = dtUsersInfo;
            lblNumberOfUsers.Text = dgvUsersInformation.RowCount.ToString();

        }
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddUser_Click(sender, e);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvUsersInformation.DataSource = clsUsers.GetAllUsers();
            lblNumberOfUsers.Text = dgvUsersInformation.RowCount.ToString();
        }

        private bool TryGetSelectedUserId(out int UserId)
        {
            UserId = 0;

            if (dgvUsersInformation.SelectedRows.Count == 0)
            {
                return false;
            }

            UserId = Convert.ToInt32(
                dgvUsersInformation.SelectedRows[0].Cells["UserId"].Value);

            return true;
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            if (MessageBox.Show("Are you sure you want to delete this User?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (!TryGetSelectedUserId(out int UserId))
                {
                    MessageBox.Show("Please Select a User First!", "Error", MessageBoxButtons.OK);
                    return;
                }

                clsUsers.DeleteUser(UserId);

                refreshToolStripMenuItem_Click(sender, e);
            }
        }

        private void updateUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedUserId(out int PersonId))
            {
                MessageBox.Show("Please Select a User First!", "Error", MessageBoxButtons.OK);
                return;
            }

            frmUserDetails AddNewUserForm = new frmUserDetails(frmUserDetails.enMode.Update, PersonId);

            AddNewUserForm.RefreshData += frmUserDetails_RefreshData;

            AddNewUserForm.ShowDialog();
        }

        private void showUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedUserId(out int UserId))
            {
                MessageBox.Show("Please Select a User First!", "Error", MessageBoxButtons.OK);
                return;
            }

            frmUserDetails ShowUserInfo = new frmUserDetails(frmUserDetails.enMode.Show, UserId);

            ShowUserInfo.ShowDialog();
        }
        private void GetComingSoonMessage()
        {
            MessageBox.Show("This feature is coming soon. Thank you for your patience.", "Coming Soon", MessageBoxButtons.OK);
        }

        private void sendMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetComingSoonMessage();
        }

        private void sentEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetComingSoonMessage();
        }
    }
}
