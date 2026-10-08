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
    public partial class ucDrivingLicensesServicesScreen : UserControl
    {
        public event EventHandler<string> MenuItemClicked;
        public ucDrivingLicensesServicesScreen()
        {
            InitializeComponent();
        }

        private void btnNewDrivingLicenses_Click(object sender, EventArgs e)
        {
            frmLicenseDetails frmLicenseDetails = new frmLicenseDetails();
            frmLicenseDetails.ShowDialog();
        }

        private void btnBackToPreviousPage_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "Back To Previous Page");
        }
    }
}
