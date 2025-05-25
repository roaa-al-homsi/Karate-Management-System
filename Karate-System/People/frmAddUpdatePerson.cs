using Guna.UI2.WinForms;
using KarateBusiness;
using KarateSystem.GlobalClasses;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KarateSystem.People
{
    public partial class frmAddUpdatePerson : Form
    {
        public enum Mode { Add = 1, Update = 2 }
        private Mode _mode;

        private Person _person;

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _mode = Mode.Add;
        }
        public frmAddUpdatePerson(int personId)
        {
            InitializeComponent();
            _mode = Mode.Update;
            _person = Person.Find(personId);
            if (_person != null)
            {
            }
        }
        private void _FillDataFromPersonToForm()
        {
            txtFirstName.Text = _person.firstName;
            txtSecondName.Text = _person.secondName;
            txtLastName.Text = _person.lastName;
            txtThirdName.Text = _person.thirdName;//nullable
            txtEmail.Text = _person.email;//nullable
            txtNationalNo.Text = _person.nationalNumber;
            txtAddress.Text = _person.address;
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
            //cmbCountry.SelectedIndex = cmbCountry.FindString(_person.);
        }



        #region Image
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
    }
}
