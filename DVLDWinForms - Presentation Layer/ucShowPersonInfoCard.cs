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
    public partial class ucShowPersonInfoCard : UserControl
    {
        public ucShowPersonInfoCard(int PersonId)
        {
            InitializeComponent();
            pbProfilePicture.Mode = ucCircularPictureBox.PictureMode.Large;
            SetUpToolTip();
            _PersonID = PersonId;
            FillPersonInfoCard();
        }

        private int _PersonID;
        private void SetUpToolTip()
        {
            ToolTip tooltip1 = new ToolTip();

            tooltip1.AutoPopDelay = 5000;
            tooltip1.InitialDelay = 500;
            tooltip1.ReshowDelay = 200;
            tooltip1.ShowAlways = true;

            tooltip1.SetToolTip(btnTooltTip, "Date Of Birth");
        }
        private clsPerson GetPersonInfo()
        {
            clsPerson Person = clsPerson.FindbyID(_PersonID);
            if (Person == null) throw new Exception("Person Is Not Found!");
            return Person;
        }

        private string GetCountryName(int CountryId)
        {
           clsCountries Country = clsCountries.FindByCountryID(CountryId);

            return Country.CountryName;
        }

        private void FillPersonInfoCard()
        {
            clsPerson Person = GetPersonInfo();

            lblName.Text = Person.FullName();
            lblNationalNo.Text = Person.NationalNo;
            lblGender.Text = Person.Gender;
            lblEmail.Text = Person.Email;
            lblPhoneNumber.Text = Person.Phone;
            lblAddress.Text = Person.Address;
            lblDateOfBirth.Text = Person.DateOfBirth.ToShortDateString();
            if (Person.Gender == "Male")
            {
                pbProfilePicture.SetDefualtProfilePicture(false);
            }
            else
            {
                pbProfilePicture.SetDefualtProfilePicture(true);
            }
            lblCountry.Text = GetCountryName(Person.NationalityCountryID);
            if (!string.IsNullOrEmpty(Person.ImagePath))
               pbProfilePicture.SetCustomProfilePicture(Person.ImagePath);
        }
    }
}
