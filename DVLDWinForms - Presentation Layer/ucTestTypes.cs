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
    public partial class ucTestTypes : UserControl
    {

        public event EventHandler<string> MenuItemClicked;
        public ucTestTypes()
        {
            InitializeComponent();
        }


        private DataTable _TestsTypesDataTable;
        private async Task LoadData()
        {
            lblLoading.Visible = true;

            _TestsTypesDataTable = await Task.Run(() => clsTestType.GetAllTestsTypes());


            dgvTestsTypesInformation.DataSource = _TestsTypesDataTable;

            lblNumberOfTests.Text = dgvTestsTypesInformation.RowCount.ToString();

            lblLoading.Visible = false;
        }

        async private void ucTestTypes_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void btnBackToApplicationsScreen_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "Back To Previous Page");
        }
    }
}
