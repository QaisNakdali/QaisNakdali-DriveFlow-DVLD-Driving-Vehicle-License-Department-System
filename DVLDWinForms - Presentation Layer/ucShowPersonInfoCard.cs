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
        public delegate void PersonNotFoundEventHandler(object sender, bool IsNotFound = true);

        public event PersonNotFoundEventHandler IsNotFound;

        public ucShowPersonInfoCard()
        {
            InitializeComponent();
            //pbProfilePicture.Mode = ucCircularPictureBox.PictureMode.Large;
            SetUpToolTip();
        }

        public void LoadPerson(int PersonId)
        {
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
            return Person;
        }

        private string GetCountryName(int CountryId)
        {
           clsCountries Country = clsCountries.FindByCountryID(CountryId);

            return Country.CountryName;
        }

        //private void FillPersonNotFoundCard()
        //{
        //    lblName.Text = "[???]";
        //    lblNationalNo.Text = "[???]";
        //    lblGender.Text = "[???]";
        //    lblEmail.Text = "[???]";
        //    lblPhoneNumber.Text = "[???]";
        //    lblAddress.Text = "[???]";
        //    lblDateOfBirth.Text = "[???]";
        //    //pbProfilePicture.SetDefualtProfilePicture(false);
        //    lblCountry.Text = "[???]";
        //}
        private void FillPersonInfoCard()
        {
            clsPerson Person = GetPersonInfo();

            if (Person == null)
            {
                IsNotFound?.Invoke(this, true);
                return;
            }


            lblName.Text = Person.FullName();
            lblNationalNo.Text = Person.NationalNo;
            lblGender.Text = Person.Gender;
            lblEmail.Text = Person.Email;
            lblPhoneNumber.Text = Person.Phone;
            lblAddress.Text = Person.Address;
            lblDateOfBirth.Text = Person.DateOfBirth.ToShortDateString();
            if (Person.Gender == "Male")
            {
                //pbProfilePicture.SetDefualtProfilePicture(false);
            }
            else
            {
                //pbProfilePicture.SetDefualtProfilePicture(true);
            }
            lblCountry.Text = GetCountryName(Person.NationalityCountryID);
            //if (!string.IsNullOrEmpty(Person.ImagePath))
            //pbProfilePicture.SetCustomProfilePicture(Person.ImagePath);
            IsNotFound?.Invoke(this, false);
        }
    }
}
