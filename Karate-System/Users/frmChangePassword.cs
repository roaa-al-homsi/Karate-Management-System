using System.ComponentModel;
using System.Windows.Forms;

namespace KarateSystem.Users
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword(int userId)
        {
            InitializeComponent();
            uc_UserInfoCard1.LoadUserInfoById(userId);
        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "This Password Doesn't Match With New Password!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }
        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtCurrentPassword.Text != uc_UserInfoCard1.SelectedUser.password)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Current Password Is Wrong!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCurrentPassword, null);
            }
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Field are not valid ,Put the mouse over the red icon!!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            uc_UserInfoCard1.SelectedUser.password = txtNewPassword.Text;
            if (uc_UserInfoCard1.SelectedUser.ChangePassword())
            {
                MessageBox.Show("Password Changed Successfully..", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password Doesn't Changed..", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
