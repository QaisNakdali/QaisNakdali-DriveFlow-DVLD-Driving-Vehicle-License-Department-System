using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DVLDWinFormsBusinessLayer;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLDWinForms___Presentation_Layer
{
    public partial class ucAddNewPersonCard : UserControl
    {
        public event Action<int> OnSaveComplete;

        protected virtual void SaveCompleted(int PesonID)
        {
            Action<int> handler = OnSaveComplete;
            if (handler != null)
            {
                handler(PesonID);
            }
        }

        public ucAddNewPersonCard()
        {
            InitializeComponent();

            pbProfilePicture.Mode = ucCircularPictureBox.PictureMode.Large;
            GetCountries();
            NoUnder18YearsPeople();
            SetUpToolTip();
            _NationalNoPrefixLength = PrefixNationalNo("N", tbNationalNo);
            _PhoneNumberPrefixLength = PrefixNationalNo("+", tbPhoneNumber);

            tbFirstName.Validating += ValidateRequiredFields;
            tbSecondName.Validating += ValidateRequiredFields;
            tbLastName.Validating += ValidateRequiredFields;
            tbNationalNo.Validating += ValidateRequiredFields;
            tbPhoneNumber.Validating += ValidateRequiredFields;
            tbAddress.Validating += ValidateRequiredFields;


        }

        private int _NationalNoPrefixLength = 0;
        private int _PhoneNumberPrefixLength = 0;
        private bool _HasErrors = false;
        private string _CurrentImagePath = string.Empty;
        private int _PersonID = 0;
        private bool _IsUpdateMode = false;
        private string _OldImagePath = string.Empty;

        private string GetCountryName(int CountryId)
        {
            clsCountries Country = clsCountries.FindByCountryID(CountryId);

            return Country.CountryName;
        }

        public void LoadPersonForUpdate(int PersonId)
        {
            _PersonID = PersonId;
            _IsUpdateMode = true;
            FillPersonInfo();

        }

        private void FillPersonInfo()
        {
            clsPerson Person = clsPerson.FindbyID(_PersonID);

            tbFirstName.Text = Person.FirstName;
            tbSecondName.Text = Person.SecondName;
            tbThirdName.Text = Person.ThirdName;
            tbLastName.Text = Person.LastName;
            tbNationalNo.Text = Person.NationalNo;
            tbEmail.Text = Person.Email;
            tbPhoneNumber.Text = Person.Phone;
            tbAddress.Text = Person.Address;
            if (Person.Gender == "Male")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            dtpDateOfBirth.Text = Person.DateOfBirth.ToShortDateString();
            cbCountry.Text = GetCountryName(Person.NationalityCountryID);
            if (!string.IsNullOrEmpty(Person.ImagePath))
            {
                pbProfilePicture.SetCustomProfilePicture(Person.ImagePath);
                btnReomvePicture.Visible = true;
                _OldImagePath = Person.ImagePath;
            }



        }
        private void SetUpToolTip()
        {
            System.Windows.Forms.ToolTip tooltip1 = new System.Windows.Forms.ToolTip();

            tooltip1.AutoPopDelay = 5000;
            tooltip1.InitialDelay = 500;
            tooltip1.ReshowDelay = 200;
            tooltip1.ShowAlways = true;

            tooltip1.SetToolTip(btnTooltTip, "Date Of Birth");
        }

        private void NoUnder18YearsPeople()
        {
            dtpDateOfBirth.Value = DateTime.Today.AddYears(-18);
            dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
        }

        private void GetCountries()
        {
            cbCountry.DataSource = clsCountries.GetAllCountries();
            cbCountry.DisplayMember = "CountryName";
            cbCountry.SelectedIndex = 149;
        }

        private string GetGender()
        {
            if (rbMale.Checked)
            {
                return "Male";
            }
            else
            {
                return "Female";
            }
        }

        private bool IsThereEmptySlots()
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                return true;
            }
            if (string.IsNullOrWhiteSpace(tbSecondName.Text))
            {
                return true;
            }
            if (string.IsNullOrEmpty(tbLastName.Text))
            {
                return true;
            }
            if (string.IsNullOrEmpty(tbNationalNo.Text) || tbNationalNo.Text == "N")
            {
                return true;
            }
            if (string.IsNullOrEmpty(tbPhoneNumber.Text) || tbPhoneNumber.Text == "+")
            {
                return true;
            }
            if (string.IsNullOrEmpty(tbAddress.Text))
            {
                return true;
            }

            return false;
        }
        private int PrefixNationalNo(string Prefix, KryptonTextBox tb)
        {
            tb.Text = Prefix;
            tb.SelectionStart = tb.Text.Length;
            return Prefix.Length;
        }

        private void NotDeletingPrefix(KryptonTextBox tb, int PrefixLength, KeyEventArgs e)
        {
            if (tb.SelectionStart <= PrefixLength && e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private bool IsEmailValid()
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                return true;
            }

            if (!tbEmail.Text.Contains("@") || !tbEmail.Text.Contains("."))
            {
                return false;
            }

            return true;
              
        }
        private void ValidateRequiredFields(object sender, CancelEventArgs e)
        {
            KryptonTextBox tb = sender as KryptonTextBox;

            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                errorProvider1.SetError(tb, "This Field Is Required!");
                _HasErrors = true;
            }
            else
            {
                errorProvider1.SetError(tb, "");
                _HasErrors = false;
            }
            errorProvider1.SetIconPadding(tb, 5);
        }

        private void DeleteOldImage(string ImagePath)
        {
            if (!string.IsNullOrWhiteSpace(ImagePath) && File.Exists(ImagePath))
            {
                File.Delete(ImagePath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (_HasErrors || IsThereEmptySlots())
            {
                MessageBox.Show("Please complete all required fields!","Save Failed",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsPerson Person1;

            if (_IsUpdateMode)
            {
                 Person1 = clsPerson.FindbyID(_PersonID);

            }
            else
            {
                 Person1 = new clsPerson();
            }

            Person1.FirstName = tbFirstName.Text;
            Person1.SecondName = tbSecondName.Text;
            Person1.ThirdName = tbThirdName.Text;
            Person1.LastName = tbLastName.Text;
            Person1.NationalNo = tbNationalNo.Text;
            Person1.Gender = GetGender();
            Person1.Email = tbEmail.Text;
            Person1.Phone = tbPhoneNumber.Text;
            Person1.Address = tbAddress.Text;
            Person1.DateOfBirth = dtpDateOfBirth.Value;
            Person1.NationalityCountryID = cbCountry.SelectedIndex + 1;

            SaveNewPictureInFile();
          
            if (!string.IsNullOrWhiteSpace(_CurrentImagePath))
            {
                Person1.ImagePath = _CurrentImagePath;
            }
            else
            {
                Person1.ImagePath = "";
            }

            

            if (Person1.Save())
            {
                
                MessageBox.Show("Person Added Successfully!","Add New Person",MessageBoxButtons.OK,MessageBoxIcon.Information);
                _PersonID = Person1.PersonID;

                if (_IsUpdateMode && _OldImagePath != _CurrentImagePath)
                {
                    DeleteOldImage(_OldImagePath);
                }

                if (OnSaveComplete != null)
                    SaveCompleted(_PersonID);
            }
            else
            {
                MessageBox.Show("Something went wrong..\nTry Again!", "Add New Person", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbMale.Checked)
                return;

  
            pbProfilePicture.SetDefualtProfilePicture(false);
            btnReomvePicture.Visible = false;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbFemale.Checked)
                return;

            
            pbProfilePicture.SetDefualtProfilePicture(true);
            btnReomvePicture.Visible = false;
        }

        private void OnlyLetters(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void OnlyDigits(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyLetters(sender, e);
        }

        private void tbSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyLetters(sender, e);
        }

        private void tbThirdName_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyLetters(sender, e);
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyLetters(sender, e);
        }

        private void tbNationalNo_KeyDown(object sender, KeyEventArgs e)
        {
            NotDeletingPrefix(tbNationalNo, _NationalNoPrefixLength, e);
        }

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigits(sender, e);
        }

        private void tbNationalNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigits(sender, e);
        }

        private void tbPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            NotDeletingPrefix(tbPhoneNumber, _PhoneNumberPrefixLength, e);
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!IsEmailValid())
            {
                errorProvider1.SetError(tbEmail, "Invalid email format");
                _HasErrors = true;
            }
            else
            {
                errorProvider1.SetError(tbEmail, "");
                _HasErrors = false;
            }
        }

        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (clsPerson.IsPersonExist(tbNationalNo.Text))
            {
                errorProvider1.SetError(tbNationalNo, "National No Is Already Exists!");
                _HasErrors = true;
            }
            else
            {
                errorProvider1.SetError(tbNationalNo, "");
                _HasErrors = false;
            }
        }

        private void btnChangePicture_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_CurrentImagePath))
            _OldImagePath = _CurrentImagePath;


            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp;*.gif;";
            ofd.Title = "Select Profile Picture";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbProfilePicture.SetCustomProfilePicture(ofd.FileName);
                _CurrentImagePath = ofd.FileName;
                btnReomvePicture.Visible = true;
            }
        }

        private void SaveNewPictureInFile()
        {

            if (!string.IsNullOrWhiteSpace(_CurrentImagePath))
            {
                string Folder = @"C:\DVLD - PEOPLE - IMAGES";
                Directory.CreateDirectory(Folder);

                string NewPath = Path.Combine(Folder, Guid.NewGuid().ToString() + Path.GetExtension(_CurrentImagePath));
                File.Copy(_CurrentImagePath, NewPath, true);

                _CurrentImagePath = NewPath;
            }
        }

        private void btnReomvePicture_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_CurrentImagePath))
                _OldImagePath = _CurrentImagePath;

            switch (GetGender())
            {
                case "Female":
                    pbProfilePicture.SetDefualtProfilePicture(true);
                    break;
                default:
                    pbProfilePicture.SetDefualtProfilePicture(false);
                    break;

            }
            btnReomvePicture.Visible=false;
   
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            tbFirstName.Clear();
            tbSecondName.Clear();
            tbThirdName.Clear();
            tbLastName.Clear();
            tbNationalNo.Clear();
            NoUnder18YearsPeople();
            rbMale.Select();
            cbCountry.SelectedIndex = 169;
            tbEmail.Clear();
            tbPhoneNumber.Clear();
            tbAddress.Clear();
            btnReomvePicture_Click(sender, e);
            _NationalNoPrefixLength = PrefixNationalNo("N", tbNationalNo);
            _PhoneNumberPrefixLength = PrefixNationalNo("+", tbPhoneNumber);
        }
    }
}
