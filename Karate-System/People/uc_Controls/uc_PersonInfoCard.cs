using KarateBusiness;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KarateSystem.People.uc_Controls
{
    public partial class uc_PersonInfoCard : UserControl
    {
        private int _personId = -1;
        private Person _person;

        public int PersonId
        {
            get { return _personId; }
        }
        public Person SelectedPersonInfo
        {
            get { return _person; }
        }
        public uc_PersonInfoCard()
        {
            InitializeComponent();
        }
        private void _LoadImagePerson()
        {
            //picPerson.ImageLocation = string.IsNullOrWhiteSpace(_Person.ImagePath) ?
            //    (_Person.enGender == 1) ? Properties.Resources.Female_512 : Properties.Resources.Male_512 :
            //    _Person.ImagePath;
            if (!string.IsNullOrWhiteSpace(_person.imagePath))
            {
                if (File.Exists(_person.imagePath))
                {
                    picPerson.ImageLocation = _person.imagePath;
                }
                else
                {
                    MessageBox.Show($"There is no image with this path : {_person.imagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            if (_person.gender == 0)
            {
                using (MemoryStream ms = new MemoryStream(Properties.Resources.Male_512))
                {
                    picPerson.Image = Image.FromStream(ms);
                }
            }
            else
            {
                using (MemoryStream ms = new MemoryStream(Properties.Resources.Female_512))
                {
                    picPerson.Image = Image.FromStream(ms);
                }
            }


        }
        private void _FillPersonInfoDataToForm()
        {
            LabPersonId.Text = _personId.ToString();
            txtAddress.Text = _person.address;
            txtEmail.Text = _person.email;
            txtPhone.Text = _person.phone;
            txtNationalNo.Text = _person.nationalNumber;
            txtGender.Text = _person.GenderText;
            txtName.Text = _person.FullName;
            txtBirth.Text = _person.dateOfBirth.ToString();
            txtCountry.Text = Person.GetNameCountryById(_person.countryId);
            linkLabEdit.Enabled = true;
            _LoadImagePerson();
        }
        public void LoadPersonInfo(int personId)
        {
            _person = Person.Find(personId);
            if (_person == null)
            {
                MessageBox.Show($"There is no person with this Id {personId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfoDataToForm();

        }
        public void LoadPersonInfo(string nationalNum)
        {
            _person = Person.FindByNationalNo(nationalNum);
            if (_person == null)
            {
                MessageBox.Show($"There is no person with this national number {nationalNum}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfoDataToForm();

        }

        private void linkLabEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
