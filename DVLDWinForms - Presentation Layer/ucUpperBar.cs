using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForms___Presentation_Layer
{
    public partial class ucUpperBar : UserControl
    {
        public ucUpperBar()
        {
            InitializeComponent();
            ucCircularPictureBox1.Mode = ucCircularPictureBox.PictureMode.Small;
        }

        private bool Expand = false;

        public event EventHandler<string> MenuItemClicked;

        private void _ClearingEffectsFromAllButtons()
        {
            clsUpperBarSettings.ClearingEffectsFromOneButton(btnHome);
            clsUpperBarSettings.ClearingEffectsFromOneButton(btnApplications);
            clsUpperBarSettings.ClearingEffectsFromOneButton(btnDrivers);
            clsUpperBarSettings.ClearingEffectsFromOneButton(btnPeople);
            clsUpperBarSettings.ClearingEffectsFromOneButton(btnUsers);
            clsUpperBarSettings.ClearingEffectsFromOneButton(btnSettings);
            clsUpperBarSettings.ClearingEffectsFromOneButton(btnLogOut);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "Home");
            _ClearingEffectsFromAllButtons();
            clsUpperBarSettings.ClickPageEffect(btnHome);
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "Applications");
            _ClearingEffectsFromAllButtons();
            clsUpperBarSettings.ClickPageEffect(btnApplications);
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "People");
            _ClearingEffectsFromAllButtons();
            clsUpperBarSettings.ClickPageEffect(btnPeople);
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "Drivers");
            _ClearingEffectsFromAllButtons();
            clsUpperBarSettings.ClickPageEffect(btnDrivers);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "Users");
            _ClearingEffectsFromAllButtons();
            clsUpperBarSettings.ClickPageEffect(btnUsers);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "Settings");
            _ClearingEffectsFromAllButtons();
            clsUpperBarSettings.ClickPageEffect(btnSettings);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, "Logout");
            _ClearingEffectsFromAllButtons();
            clsUpperBarSettings.ClickPageEffect(btnLogOut);
        }

        private void lblAdditionalMenu_Click(object sender, EventArgs e)
        {
            if (!Expand)
            {
                lblAdditionalMenu.Text = "-";
                
                lblAdditionalMenu.Location = new Point(2447, 25);
                ucCircularPictureBox1.Location = new Point(2284, 14);
                btnLogOut.Visible = true;
                btnSettings.Visible = true;
                Expand = true;
            }
            else
            {
                lblAdditionalMenu.Text = "...";
                lblAdditionalMenu.Location = new Point(2456, 17);
                ucCircularPictureBox1.Location = new Point(2393, 14);
                btnLogOut.Visible = false;
                btnSettings.Visible = false;
                Expand = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ucUpperBar_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                btnHome.PerformClick();
            }
        }
    }
}
