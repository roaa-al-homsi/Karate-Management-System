using Guna.UI2.WinForms;
using KarateSystem.Belt_Ranks;
using KarateSystem.BeltTests;
using KarateSystem.Instructors;
using KarateSystem.Login;
using KarateSystem.Members;
using KarateSystem.Members_Instructors;
using KarateSystem.Payments;
using KarateSystem.People;
using KarateSystem.Subscription_Periods;
using KarateSystem.Users;
using System.Drawing;
using System.Windows.Forms;

namespace KarateSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(frmLogin frmLogin)
        {
            InitializeComponent();

        }
        private Guna2Button _currentButton;
        private Form _activeForm;

        #region Design
        private void _ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != null)
                {
                    _currentButton.BackColor = Color.FromArgb(175, 238, 238);
                    _currentButton.ForeColor = Color.White;
                    _currentButton.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }

                _currentButton = (Guna2Button)btnSender;
                _currentButton.BackColor = Color.White;
                _currentButton.ForeColor = Color.FromArgb(175, 238, 238);
                _currentButton.Font = new System.Drawing.Font("Comic Sans MS", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        public void OpenChildFormAsync(Form childForm, object btnSender)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            _ActivateButton(btnSender);
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainMenu.Controls.Add(childForm);
            panelMainMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            if (childForm.Tag != null)
            {
                btnTitle.Text = childForm.Tag.ToString();
            }
            else
            {
                btnTitle.Text = childForm.Text;
            }
        }
        public void OpenChildFormAsync(Form childForm)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainMenu.Controls.Add(childForm);
            panelMainMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            if (childForm.Tag != null)
            {
                btnTitle.Text = childForm.Tag.ToString();
            }
            else
            {
                btnTitle.Text = childForm.Text;
            }
        }
        #endregion


        private void btnManagePeople_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnManagePeople.Image;
            OpenChildFormAsync(new frmManagePeople(this), sender);
        }

        private void btnUsers_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnManageUsers.Image;
            OpenChildFormAsync(new frmManagementUsers(this), sender);
        }

        private void btnMembers_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnMembers.Image;
            OpenChildFormAsync(new frmManageMembers(this), sender);
        }

        private void btnInstructors_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnInstructors.Image;
            OpenChildFormAsync(new frmManageInstructors(this), sender);
        }

        private void btnMembersInstructors_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnMembersInstructors.Image;
            OpenChildFormAsync(new frmManageMembersInstructors(this), sender);
        }

        private void btnBeltRanks_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnBeltRanks.Image;
            OpenChildFormAsync(new frmManageBeltRanks(this), sender);
        }

        private void btnSubscriptionPeriods_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnSubscriptionPeriods.Image;
            OpenChildFormAsync(new frmManageSubscriptionPeriods(this), sender);
        }

        private void btnBeltTests_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnBeltTests.Image;
            OpenChildFormAsync(new frmManageBeltTests(this), sender);
        }

        private void btnPayments_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnPayments.Image;
            OpenChildFormAsync(new frmManagePayments(this), sender);
        }

        private void btnAllBooks_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnDashboard.Image;
            OpenChildFormAsync(new frmDashboard(this), sender);
        }

        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }
    }
}
