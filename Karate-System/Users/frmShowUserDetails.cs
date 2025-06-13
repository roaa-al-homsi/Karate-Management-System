using System;
using System.Windows.Forms;

namespace KarateSystem.Users
{
    public partial class frmShowUserDetails : Form
    {
        private int _userId = -1;
        public frmShowUserDetails(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void frmShowUserDetails_Load(object sender, EventArgs e)
        {
            uc_UserInfoCard1.LoadUserInfoById(_userId);
        }
    }
}
