using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForms___Presentation_Layer
{
    public static class clsNavigationService
    {
        private static Panel _MainPanel;

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
        }

        private static void _UpperBar_MenuItemClicked(object sender,string Screen)
        {
            if (string.IsNullOrWhiteSpace(Screen))
            {
                return;
            }

            UserControl control = _CreateScreen(Screen);

            if (control != null)
            {
                _LoadScreen(control);
            }
            else
            {
                _ShowNotFoundScreen(Screen);
            }
        }

        private static UserControl _CreateScreen(string Screen) 
        {
            switch(Screen)
            {
                case "Home":
                    return new ucComingSoon();
                case "People":
                    return new ucPeopleScreen();
                case "Users":
                    return new ucComingSoon();
                case "Applications":
                    return new ucComingSoon();
                case "Drivers":
                    return new ucComingSoon();
                case "Settings":
                    MessageBox.Show("This feature is coming soon. Thank you for your patience.", "Coming Soon", MessageBoxButtons.OK);
                    break;
                case "Logout":
                    MessageBox.Show("This feature is coming soon. Thank you for your patience.", "Coming Soon", MessageBoxButtons.OK);
                    break;
                default:
                    return null;
                    
            }
            return null;
        }
        private static void _LoadScreen(UserControl control) 
        {
           _MainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            _MainPanel.Controls.Add(control);
        }

        private static void _ShowNotFoundScreen(string Screen)
        {
            if (Screen == "Settings" || Screen == "Logout")
                return;


            MessageBox.Show($"Screen '{Screen}' Not Found!", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
