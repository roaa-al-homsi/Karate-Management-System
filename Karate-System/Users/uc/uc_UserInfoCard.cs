using KarateBusiness;
using System.Windows.Forms;


namespace KarateSystem.Users
{
    public partial class uc_UserInfoCard : UserControl
    {
        private int _userId = -1;
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        private User _user;
        public User SelectedUser
        {
            get { return _user; }
        }
        public uc_UserInfoCard()
        {
            InitializeComponent();
        }

        private void _LoadUserDataToControl()
        {
            uc_PersonInfoCard1.LoadPersonInfo(_user.personId);
            txtUserId.Text = _userId.ToString();
            txtUsername.Text = _user.username;
            txtIsActive.Text = _user.isActive ? "Yes" : "No";
        }
        public void LoadUserInfoById(int userId)
        {
            _user = User.Find(userId);
            if (_user == null)
            {
                MessageBox.Show($"There is no user with this Id {_userId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _userId = userId;

            _LoadUserDataToControl();
        }

    }
}
