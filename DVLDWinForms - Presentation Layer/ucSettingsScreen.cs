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
    public partial class ucSettingsScreen : UserControl
    {
        public ucSettingsScreen()
        {
            InitializeComponent();
        }

        async private void LoadingScreen()
        {
            pnlLoading.BringToFront();
            pnlLoading.Visible = true;
            pnlMain.Visible = false;
            lblLoading.Visible = true;

            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(1500);
            });

            lblLoading.Visible = false;
            pnlLoading.Visible = false;
            pnlMain.Visible = true;

        }
        private void btnUserInformation_Click(object sender, EventArgs e)
        {
            LoadingScreen();
            lblPageName.Text = "User Information";
            var ucPersonInfo = new ucShowPersonInfoCard();

            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ucPersonInfo);

            //----

            pnlSub.Visible = true;
            pnlScreensContainer.AutoScroll = true;

            var ucUserInfo = new ucShowUserInfoCard();

            pnlSub.Controls.Clear();
            pnlSub.Controls.Add(ucUserInfo);
        }

        private void GetComingSoonMessage()
        {
            MessageBox.Show("This feature is coming soon. Thank you for your patience.", "Coming Soon", MessageBoxButtons.OK);
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            GetComingSoonMessage();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            LoadingScreen();
            pnlSub.Visible = false;
            AutoScroll = false;

            lblPageName.Text = "Change Password";

            var uc = new ucChangePassword();

            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }
    }
}
