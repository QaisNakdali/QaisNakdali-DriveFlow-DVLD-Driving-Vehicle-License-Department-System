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
    public partial class ucShowUserInfoCard : UserControl
    {
        public ucShowUserInfoCard()
        {
            InitializeComponent();
        }

         private clsUsers _User;
        public void LoadUser(int UserId)
        {
            _UserID = UserId;
            FillUserInfoCard();
        }

        public int GetUserPersonID()
        {
            return _User.PersonID;
        }

        private int _UserID;
        private clsUsers GetUserInfo()
        {
            clsUsers User = clsUsers.FindByUserID(_UserID);
            return User;
        }
        private void FillUserInfoCard()
        {
            _User = GetUserInfo();

            if (_User == null)
            {
                MessageBox.Show("User is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            lblUserID.Text = _User.UserID.ToString();
            lblPersonID.Text = _User.PersonID.ToString();
            lblUsername.Text = _User.UserName.ToString();
            lblActive.Text = _User.IsActive.ToString();
        }
    }
}
