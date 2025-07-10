using KarateSystem.GlobalClasses;
using KarateSystem.Users;
using System;
using System.Windows.Forms;

namespace KarateSystem.Account_Setting
{
    public partial class frmAccountSettingcs : Form
    {
        public frmAccountSettingcs()
        {
            InitializeComponent();
        }

        private void btnCurrentUserInfo_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frmShowUserDetails = new frmShowUserDetails(LoginUser.CurrentUser.id);
            frmShowUserDetails.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(LoginUser.CurrentUser.id);
            frmChangePassword.ShowDialog();
        }
    }
}
