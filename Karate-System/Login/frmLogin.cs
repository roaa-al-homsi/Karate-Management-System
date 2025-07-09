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

                this.Hide();
                frmMain frm = new frmMain(this);
                frm.ShowDialog();

            }
        }
    }
}
