using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDWinForms___Presentation_Layer
{
    public static class clsNavigationService
    {
        private static Panel _MainPanel;
        private static ucApplications _ucApplicationsSecreens = new ucApplications();
        private static ucApplicationsTypes _ucManageApplicationsTypes = new ucApplicationsTypes();
        private static ucDrivingLicensesServicesScreen _ucDrivingLicensesServicesScreen = new ucDrivingLicensesServicesScreen();
        private static ucManageApplicationsScreen _ucManageApplicationsScreen = new ucManageApplicationsScreen();
        private static ucLocalLicensesManagement _ucLocalLicensesManagement = new ucLocalLicensesManagement();
        private static ucTestTypes _ucTestTypesScreen = new ucTestTypes();
        public static void Initialize(Panel MainPanel, ucUpperBar upperBar)
        {
            if (MainPanel == null)
            {
                throw new ArgumentNullException(nameof(MainPanel));
            }
            if (upperBar == null)
            {
                throw new ArgumentNullException(nameof(upperBar));
            }


            _MainPanel = MainPanel;

            upperBar.MenuItemClicked += _UpperBar_MenuItemClicked;



            _ucApplicationsSecreens.MenuItemClicked += _ApplicationsMenueItemClicked;
            _ucDrivingLicensesServicesScreen.MenuItemClicked += _DrivingLicnesesServicesItemClicked;
            _ucManageApplicationsTypes.MenuItemClicked += _ManageApplicationsTypesItemClicked;
            _ucManageApplicationsScreen.MenuItemClicked += _ManageApplicationsItemClicked;
            _ucLocalLicensesManagement.MenuItemClicked += _ManageLocalLicensesItemClicked;
            _ucTestTypesScreen.MenuItemClicked += _ManageTestsTypesItemClicked;

        }

        private static void _UpperBar_MenuItemClicked(object sender,string Screen)
        {
            if (string.IsNullOrWhiteSpace(Screen))
            {
                return;
            }

            UserControl control = _CreateUpperBarScreen(Screen);

            if (control != null)
            {
                _LoadScreen(control);
            }
            else
            {
                _ShowNotFoundScreen(Screen);
            }
        }

        private static void _ApplicationsMenueItemClicked(object sender,string Screen)
        {
            if (string.IsNullOrWhiteSpace(Screen))
            {
                return;
            }

            UserControl control = _CreateApplicationsScreen(Screen);

            if (control != null)
            {
                _LoadScreen(control);
            }
            else
            {
                _ShowNotFoundScreen(Screen);
            }
        }

        private static void _DrivingLicnesesServicesItemClicked(object sender, string Screen)
        {
            if (string.IsNullOrWhiteSpace(Screen))
            {
                return;
            }

            UserControl control = _CreateDrivingLicensesServicesScreen(Screen);

            if (control != null)
            {
                _LoadScreen(control);
            }
            else
            {
                _ShowNotFoundScreen(Screen);
            }
        }


        private static void _ManageApplicationsItemClicked(object sender, string Screen)
        {
            if (string.IsNullOrWhiteSpace(Screen))
            {
                return;
            }

            UserControl control = _CreateManageApplicationsScreen(Screen);

            if (control != null)
            {
                _LoadScreen(control);
            }
            else
            {
                _ShowNotFoundScreen(Screen);
            }
        }

        private static void _ManageApplicationsTypesItemClicked(object sender, string Screen)
        {
            if (string.IsNullOrWhiteSpace(Screen))
            {
                return;
            }

            UserControl control = _CreateManageApplicationsTypesScreen(Screen);

            if (control != null)
            {
                _LoadScreen(control);
            }
            else
            {
                _ShowNotFoundScreen(Screen);
            }
        }

        private static void _ManageTestsTypesItemClicked(object sender, string Screen)
        {
            if (string.IsNullOrWhiteSpace(Screen))
            {
                return;
            }

            UserControl control = _CreateTestTypesScreen(Screen);

            if (control != null)
            {
                _LoadScreen(control);
            }
            else
            {
                _ShowNotFoundScreen(Screen);
            }
        }

        private static void _ManageLocalLicensesItemClicked(object sender, string Screen)
        {
            if (string.IsNullOrWhiteSpace(Screen))
            {
                return;
            }

            UserControl control = _CreateManageLocalLicensesScreen(Screen);

            if (control != null)
            {
                _LoadScreen(control);
            }
            else
            {
                _ShowNotFoundScreen(Screen);
            }
        }

        private static UserControl _CreateUpperBarScreen(string Screen)
        {
            switch (Screen)
            {
                case "Home":
                    return new ucHomeScreen();
                case "People":
                    return new ucPeopleScreen();
                case "Users":
                    return new ucUsersScreen();
                case "Applications":
                    return _ucApplicationsSecreens;
                case "Drivers":
                    return new ucComingSoon();
                case "Settings":
                    return new ucSettingsScreen();
                case "Logout":
                    MessageBox.Show("This feature is coming soon. Thank you for your patience.", "Coming Soon", MessageBoxButtons.OK);
                    break;
                default:
                    return null;

            }
            return null;
        }
        private static UserControl _CreateApplicationsScreen(string Screen) 
        {
            switch(Screen)
            {
                case "Driving Licenses Services":
                    return _ucDrivingLicensesServicesScreen;
                case "Manage Applications":
                    return _ucManageApplicationsScreen;
                case "Detain Licesnes":
                    return new ucComingSoon();
                case "Manage Applications Types":
                    return _ucManageApplicationsTypes;
                case "Manage Tests Types":
                    return _ucTestTypesScreen;
                case "Logout":
                    MessageBox.Show("This feature is coming soon. Thank you for your patience.", "Coming Soon", MessageBoxButtons.OK);
                    break;
                default:
                    return null;
                    
            }
            return null;
        }

        private static UserControl _CreateDrivingLicensesServicesScreen(string Screen)
        {
            switch (Screen)
            {
                case "Back To Previous Page":
                    return _ucApplicationsSecreens;
                default:
                    return null;

            }
        }
        private static UserControl _CreateManageApplicationsScreen(string Screen)
        {
            switch (Screen)
            {
                case "Back To Previous Page":
                    return _ucApplicationsSecreens;
                case "Local Licenses":
                    return _ucLocalLicensesManagement;

                default:
                    return null;

            }
        }

        private static UserControl _CreateManageApplicationsTypesScreen(string Screen)
        {
            switch (Screen)
            {
                case "Back To Previous Page":
                    return _ucApplicationsSecreens;
                default:
                    return null;

            }
        
        }

        private static UserControl _CreateTestTypesScreen(string Screen)
        {
            switch (Screen)
            {
                case "Back To Previous Page":
                    return _ucApplicationsSecreens;
                default:
                    return null;

            }

        }

        private static UserControl _CreateManageLocalLicensesScreen(string Screen)
        {
            switch (Screen)
            {
                case "Back To Previous Page":
                    return _ucManageApplicationsScreen;
                default:
                    return null;

            }
           
        }
        private static void _LoadScreen(UserControl control) 
        {
           _MainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            _MainPanel.Controls.Add(control);
        }

        private static void _ShowNotFoundScreen(string Screen)
        {
            if (Screen == "Logout")
                return;


            MessageBox.Show($"Screen '{Screen}' Not Found!", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
