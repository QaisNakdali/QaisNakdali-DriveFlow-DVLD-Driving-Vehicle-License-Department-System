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
    public partial class ucApplications : UserControl
    {

        public event EventHandler<string>MenuItemClicked;
        public ucApplications()
        {
            InitializeComponent();
        }

        private void btnManageApplicationsTypes_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "Manage Applications Types");
        }

        private void btnDrivingLicensesServices_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "Driving Licenses Services");
        }

        private void btnManageApplications_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "Manage Applications");
        }

        private void btnDetainLicenses_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "Detain Licenses");
        }

        private void btnManageTestTypes_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "Manage Tests Types");
        }
    }
}
