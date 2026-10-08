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
    public partial class ucManageApplicationsScreen : UserControl
    {


        public event EventHandler<string> MenuItemClicked;
        public ucManageApplicationsScreen()
        {
            InitializeComponent();
        }

        private void btnLocalLicense_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "Local Licenses");
        }

        private void btnBackToPreviousPage_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "Back To Previous Page");
        }
    }
}
