using KarateBusiness;
using KarateSystem.GlobalClasses;
using System;
using System.Windows.Forms;

namespace KarateSystem.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser.CurrentUser = User.FindByUsernameAndPassword(txtUsername.Text, txtPassword.Text);
            if (LoginUser.CurrentUser == null)
            {
                txtUsername.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (chkRememberMe.Checked)
                {
                    LoginUser.RememberUsernameAndPassword(txtUsername.Text, txtPassword.Text);
                }
                else
                {
                    //store empty username and password
                    LoginUser.RememberUsernameAndPassword("", "");
                }

                //encase the user is not active
                if (!LoginUser.CurrentUser.isActive)
                {
                    txtUsername.Focus();
                    MessageBox.Show("Your account is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.Hide();
                frmMain frm = new frmMain(this);
                frm.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string username = string.Empty;
            string password = string.Empty;

            if (LoginUser.GetStoredCredential(ref username, ref password))
            {
                txtUsername.Text = username;
                txtPassword.Text = password;
                chkRememberMe.Checked = true;
            }
            else
            {
                chkRememberMe.Checked = false;
            }

        }
    }
}
