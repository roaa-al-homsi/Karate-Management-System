using KarateBusiness;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KarateSystem.Users
{
    public partial class frmAddUpdateUser : Form
    {
        public enum Mode { Add = 0, Update = 1 };
        private Mode _mode;

        private int _userId = -1;
        private User _userSelected;

        public frmAddUpdateUser()
        {
            InitializeComponent();
            _mode = Mode.Add;
        }
        public frmAddUpdateUser(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _mode = Mode.Update;


        }
        private void _LoadDataToForm()
        {
            _userSelected = User.Find(_userId);
            uc_PersonInfoWithFilter1.FilterEnable = false;
            if (_userSelected == null)
            {
                MessageBox.Show($"There is no user with this Id: {_userId}", "Error", MessageBoxButtons.OK);
                return;
            }
            uc_PersonInfoWithFilter1.LoadPersonInfo(_userSelected.personId);
            txtUserName.Text = _userSelected.username;
            txtPassword.Text = _userSelected.password;
            txtConfirmPassword.Text = _userSelected.password;
            chkIsActive.Checked = _userSelected.isActive;
            labUserId.Text = _userSelected.id.ToString();
            if (string.IsNullOrEmpty(_userSelected.personInfo.imagePath))
            {
                if (_userSelected.personInfo.gender == 0)
                {
                    using (MemoryStream ms = new MemoryStream(Properties.Resources.Male_512))
                    {
                        picUser.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream(Properties.Resources.Female_512))
                    {
                        picUser.Image = Image.FromStream(ms);
                    }
                }
            }
            else
            {
                picUser.ImageLocation = _userSelected.personInfo.imagePath;
            }
        }
        private void _ResetDefaultValues()
        {
            if (_mode == Mode.Add)
            {
                _userSelected = new User();
                this.Text = "Add New A User";
                tpUserInfo.Enabled = false;
                uc_PersonInfoWithFilter1.FilterFocus();
                return;
            }
            this.Text = "Update a User";
            tpUserInfo.Enabled = true;
            btnSave.Enabled = true;

        }
        private void frmAddUpdateUser_Load(object sender, System.EventArgs e)
        {
            _ResetDefaultValues();
            if (_mode == Mode.Update)
            {
                _LoadDataToForm();
            }
        }
        private void _FillUserWithData()
        {
            _userSelected.username = txtUserName.Text;
            _userSelected.password = txtPassword.Text;
            _userSelected.isActive = chkIsActive.Checked;
            _userSelected.personId = uc_PersonInfoWithFilter1.PersonId;
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Field are not valid ,Put the mouse over the red icon!!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillUserWithData();

            if (_userSelected.Save())
            {
                labUserId.Text = _userSelected.id.ToString();
                _mode = Mode.Update;
                this.Text = "Update A Person";
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Failed Saved ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            if (_mode == Mode.Update)
            {
                btnSave.Enabled = true;
                tpUserInfo.Enabled = true;
                tcAddUser.SelectedTab = tcAddUser.TabPages["tpUserInfo"];
                return;
            }

            if (uc_PersonInfoWithFilter1.PersonId != -1)
            {
                if (User.ExistByPersonId(uc_PersonInfoWithFilter1.PersonId))
                {
                    MessageBox.Show("Selected person already has a user, Please choose another person..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    uc_PersonInfoWithFilter1.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tpUserInfo.Enabled = true;
                    tcAddUser.SelectedTab = tcAddUser.TabPages["tpUserInfo"];
                }

            }
            else
            {
                MessageBox.Show("Please, select a person so you can add a new user..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uc_PersonInfoWithFilter1.FilterFocus();
            }
        }

        private void txtConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation Doesn't Match Password!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void txtUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "This Field Is Required!!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
