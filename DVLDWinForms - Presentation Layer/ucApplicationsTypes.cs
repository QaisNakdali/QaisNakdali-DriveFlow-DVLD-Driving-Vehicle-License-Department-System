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
    public partial class ucApplicationsTypes : UserControl
    {
        public event EventHandler<string> MenuItemClicked;
        public ucApplicationsTypes()
        {
            InitializeComponent();
        }



        private DataTable _ApplicationsTypesDataTable;
        private async Task LoadData()
        {
            lblLoading.Visible = true;

            _ApplicationsTypesDataTable = await Task.Run(() => clsApplicationType.GetAllApplicationsTypes());


            dgvApplicationsTypesInformation.DataSource = _ApplicationsTypesDataTable;

            lblNumberOfApplications.Text = dgvApplicationsTypesInformation.RowCount.ToString();

            lblLoading.Visible = false;
        }

        async private void ucApplicationsTypes_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void btnBackToPreviousPage_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "Back To Previous Page");
        }
    }
}
