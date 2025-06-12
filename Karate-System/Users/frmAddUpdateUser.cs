using KarateBusiness;
using KarateSystem.People.uc_Controls;
using System.Windows.Forms;

namespace KarateSystem.Users
{
    public partial class frmAddUpdateUser : Form
    {
        public enum Mode { Add = 0, Update = 1 };
        private Mode _mode = Mode.Add;

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
            _userSelected = User.Find(_userId);
            if (_userSelected == null)
            {
                return;
            }

        }
        private void ResetDataToForm()
        {
            if (_mode == Mode.Add)
            {
                _userSelected = new User();
                this.Text = "Add New A User";
                return;
            }
            this.Text = "Update a User";
            uc_PersonInfoCard

        }
        private void frmAddUpdateUser_Load(object sender, System.EventArgs e)
        {

        }
    }
}
