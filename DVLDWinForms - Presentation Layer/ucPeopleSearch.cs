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
    public partial class ucPeopleSearch : UserControl
    {


        public delegate void SearchCompleteEventHandler(object sender, int PersonID);

        public event SearchCompleteEventHandler SearchComplete;

        public ucPeopleSearch()
        {
            InitializeComponent();
            if (DesignMode) return;

            cbPeopleSearchFilter.SelectedIndex = 0;
        }
        public bool IsFound = false;
       
        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            frmPersonDetails frmPerson = new frmPersonDetails(frmPersonDetails.enPersonMode.Add,-1);
            frmPerson.ShowDialog();
        }
        private void cbPeopleSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
                tbSearch.Clear();
        }
        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbPeopleSearchFilter.Text == "Person ID")
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(tbSearch.Text);

            SearchComplete?.Invoke(this, PersonID);
        }
    }
}
