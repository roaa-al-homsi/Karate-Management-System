using Guna.UI2.WinForms;
using KarateBusiness;
using KarateSystem.GlobalClasses;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KarateSystem.People
{
    public partial class frmAddUpdatePerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int personId);

        public event DataBackEventHandler DataBack;
        public enum Mode { Add = 1, Update = 2 }
        private Mode _mode;

        private int _personId;
        private Person _person;

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _mode = Mode.Add;
        }
        public frmAddUpdatePerson(int personId)
        {
            InitializeComponent();
            _personId = personId;
            _mode = Mode.Update;


        }
        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValuesToForm();
            if (_mode == Mode.Update)
            {
                _LoadDataFromPersonToForm();
            }
        }
        private void _ResetDefaultValuesToForm()
        {
            _FillCmbCountry();
            cmbCountry.StartIndex = cmbCountry.FindString("Syria");
            if (_mode == Mode.Add)
            {
                _person = new Person();
                labTitleForm.Text = "Add New A Person";
                this.Text = "Add New a Person";
            }
            else
            {
                this.Text = "Update a Person";
                labTitleForm.Text = "Update a Person";
            }

            if (radioBtnFemale.Checked)
            {
                using (MemoryStream ms = new MemoryStream(Properties.Resources.Female_512))
                {
                    pbPersonImage.Image = Image.FromStream(ms);
                }
            }
            else
            {
                using (MemoryStream ms = new MemoryStream(Properties.Resources.Male_512))
                {
                    pbPersonImage.Image = Image.FromStream(ms);
                }
            }
            linkLabRemoveImage.Visible = !string.IsNullOrEmpty(pbPersonImage.ImageLocation);

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            cmbCountry.SelectedIndex = cmbCountry.FindString("Syria");
            labPersonId.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtSecondName.Text = string.Empty;
            txtThirdName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtNationalNo.Text = string.Empty;
            dtpDateOfBirth.Text = string.Empty;
            radioBtnMale.Checked = true;
        }
        private void _LoadDataFromPersonToForm()
        {
            _person = Person.Find(_personId);
            if (_person == null)
            {
                MessageBox.Show($"There is no person with Id {_personId} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            labPersonId.Text = _person.id.ToString();
            txtFirstName.Text = _person.firstName;
            txtSecondName.Text = _person.secondName;
            txtLastName.Text = _person.lastName;
            txtThirdName.Text = _person.thirdName;//nullable
            txtEmail.Text = _person.email;//nullable
            txtNationalNo.Text = _person.nationalNumber;
            txtAddress.Text = _person.address;
            txtPhone.Text = _person.phone;
            if (_person.gender == Person.enGender.Female)
            {
                radioBtnFemale.Checked = true;
            }
            else
            {
                radioBtnMale.Checked = true;
            }
            pbPersonImage.ImageLocation = !string.IsNullOrWhiteSpace(_person.imagePath) ? _person.imagePath : null;
            linkLabRemoveImage.Visible = !string.IsNullOrWhiteSpace(_person.imagePath);
            cmbCountry.SelectedIndex = cmbCountry.FindString(_person.CountryInfo.name);
            dtpDateOfBirth.Value = _person.dateOfBirth;
        }
        private void _FillPersonData()
        {
            _person.firstName = txtFirstName.Text;
            _person.secondName = txtSecondName.Text;
            _person.lastName = txtLastName.Text;
            _person.thirdName = txtThirdName.Text;//nullable
            _person.address = txtAddress.Text;
            _person.nationalNumber = txtNationalNo.Text;
            _person.phone = txtPhone.Text;
            _person.email = txtEmail.Text;
            _person.dateOfBirth = dtpDateOfBirth.Value;
            _person.gender = radioBtnFemale.Checked ? Person.enGender.Female : Person.enGender.Male;
            _person.imagePath = string.IsNullOrEmpty(pbPersonImage.ImageLocation) ? null : pbPersonImage.ImageLocation;
            _person.countryId = Country.GetIdCountryByName(cmbCountry.Text);

        }
        private void _FillCmbCountry()
        {
            DataTable dt = Country.All();
            foreach (DataRow dr in dt.Rows)
            {
                cmbCountry.Items.Add(dr["name"]);
            }
        }

        #region ImageHandel
        private void linkLabSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);
                pbPersonImage.ImageLocation = selectedFilePath;
                linkLabRemoveImage.Visible = true;
            }
        }
        private void linkLabRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;
            if (radioBtnFemale.Checked)
            {
                using (MemoryStream ms = new MemoryStream(Properties.Resources.Female_512))
                {
                    pbPersonImage.Image = Image.FromStream(ms);
                }
            }
            else
            {
                using (MemoryStream ms = new MemoryStream(Properties.Resources.Male_512))
                {
                    pbPersonImage.Image = Image.FromStream(ms);
                }
            }
            linkLabRemoveImage.Visible = false;
        }
        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_person.imagePath != pbPersonImage.ImageLocation)
            {
                if (_person.imagePath != string.Empty)
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_person.imagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (Util.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }
        #endregion

        #region Validation
        private void _ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(textBox, null);
            }
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                return;

            }
            if (!Validation.ValidateEmail(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }
        private void txtBoxLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBoxNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] allowedChars = { '@', '.', '-', '_', '+' };
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !allowedChars.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion


        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not validate ,but the mouse over red icon");
                return;
            }
            if (!_HandlePersonImage())
            {
                return;
            }
            _FillPersonData();
            if (_person.Save())
            {
                labPersonId.Text = _person.id.ToString();
                _mode = Mode.Update;
                labTitleForm.Text = "Update A Person";
                this.Text = "Update A Person";
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _person.id);
            }
            else
            {
                MessageBox.Show("Data Failed Saved ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void radioBtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            // Convert the byte[] resource to an Image
            using (MemoryStream ms = new MemoryStream(Properties.Resources.Female_512))
            {
                pbPersonImage.Image = Image.FromStream(ms);
            }
        }
        private void radioBtnMale_CheckedChanged(object sender, EventArgs e)
        {
            // Convert the byte[] resource to an Image
            using (MemoryStream ms = new MemoryStream(Properties.Resources.Male_512))
            {
                pbPersonImage.Image = Image.FromStream(ms);
            }
        }
    }
}
