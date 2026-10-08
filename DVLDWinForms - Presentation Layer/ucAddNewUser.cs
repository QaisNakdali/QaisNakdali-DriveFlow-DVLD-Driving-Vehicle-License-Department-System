using DVLDWinFormsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForms___Presentation_Layer
{
    public partial class ucAddNewUser : UserControl
    {
        public ucAddNewUser()
        {
            InitializeComponent();
        }

        private bool _HasErrors = false;
        private int _PersonID = -1;
        private int _UserId = -1;
        private string _UserName = "";
        private string _Password = "";
        private string _ConfirmPassword = "";
        bool _IsActive = false;
        bool _IsUpdateMode = false;

        public void LoadUserForUpdate(int UserID)
        {
            _UserId = UserID;
            _IsUpdateMode = true;
            FillUserInfo();

        }
        private void FillUserInfo()
        {
            clsUsers User = clsUsers.FindByUserID(_UserId);

            lblUserID.Text = User.UserID.ToString();
            tbUsername.Text = User.UserName;
            tbPassword.Text = User.Password;
            tbConfirmPassword.Text = User.Password;
            chkIsActive.Checked = User.IsActive;

        }

        private bool IsThereAnyInfoErrors()
        {
            if (!IsUsernameValid() || !IsPasswordValid() || !CheckConfirmPassword())
            {
                return true;
            }
            return false;
        }

        private bool IsUsernameValid()
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                errorProvider1.SetError(tbUsername, "Username cannot be empty.");
                return false;
            }
            else if (clsUsers.IsUserExist(tbUsername.Text))
            {
                errorProvider1.SetError(tbUsername, "Username is already exist.");
                return false;
            }
            else
            {
                errorProvider1.SetError(tbUsername, "");
                return true;
            }
        }

        private bool IsPasswordValid()
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                errorProvider1.SetError(tbPassword, "Password cannot be empty.");
                return false;
            }
            else
            {
                errorProvider1.SetError(tbPassword, "");
            }
            _Password = tbPassword.Text;
            return true;
        }

        private bool CheckConfirmPassword()
        {
            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                errorProvider1.SetError(tbConfirmPassword, "Passwords do not match.");
                return false;
            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, "");
            }
            _ConfirmPassword = tbConfirmPassword.Text;
            return true;
        }
        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            IsUsernameValid();
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            IsPasswordValid();
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
           CheckConfirmPassword();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
            tbConfirmPassword.Clear();
            chkIsActive.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _HasErrors = IsThereAnyInfoErrors();

            if (_HasErrors)
            {
                MessageBox.Show("Please complete all required fields in correct way!", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsUsers User1;

            if (_IsUpdateMode)
            {
                User1 = clsUsers.FindByUserID(_UserId);
                _PersonID = User1.PersonID;

            }
            else
            {
                User1 = new clsUsers();
                User1.PersonID = _PersonID;
            }


            User1.UserName = tbUsername.Text;
            User1.Password = tbPassword.Text;
            User1.IsActive = chkIsActive.Checked;
          



            if (User1.Save())
            {

                if (_IsUpdateMode)
                {
                    MessageBox.Show("User Updated Successfully!", "Update User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User Added Successfully!", "Add New User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                GetUserID(User1.UserID);
            }
            else
            {
                MessageBox.Show("Something went wrong..\nTry Again!", "Add New Person", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GetUserID(int UserID)
        {
            _UserId = UserID;
            lblUserID.Text = _UserId.ToString();
            lblUserID.ForeColor = Color.Red;
        }
        public void ConnectToFormUserDetails(frmUserDetails UserDetails)
        {
            UserDetails.OnSwapToNextPage -= UserDetails_OnSwapToNextPage;
            UserDetails.OnSwapToNextPage += UserDetails_OnSwapToNextPage;
        }


        private void UserDetails_OnSwapToNextPage(int obj)
        {
            int PersonID = obj;
           _PersonID = PersonID;
            
            if (!(string.IsNullOrEmpty(tbUsername.Text)) && !(string.IsNullOrEmpty(_UserName)))
            {
                tbUsername.Text = _UserName;
            }

            if (!(string.IsNullOrEmpty(tbPassword.Text)) && !(string.IsNullOrEmpty(_Password)))
            {
                tbPassword.Text = _Password;
            }

            if (!(string.IsNullOrEmpty(tbConfirmPassword.Text)) && !(string.IsNullOrEmpty(_ConfirmPassword)))
            {
                tbConfirmPassword.Text = _ConfirmPassword;
            }
                chkIsActive.Checked = _IsActive;
        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {
            _IsActive = chkIsActive.Checked;
        }
    }
}
