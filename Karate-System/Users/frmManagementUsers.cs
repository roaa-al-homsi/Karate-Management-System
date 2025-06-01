using KarateBusiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace KarateSystem.Users
{
    public partial class frmManagementUsers : Form
    {
        private frmMain _frmMain;
        private DataTable _dtAllUsers;
        public frmManagementUsers(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }

        private void ResetDefaultValueToForm()
        {
            _dtAllUsers = User.All();
            dgvAllUsers.DataSource = _dtAllUsers;
            cmbFilterBy.SelectedIndex = 0;
            txtFilterBy.Visible = cmbFilterBy.SelectedIndex != 0;
        }
        private void frmManagementUsers_Load(object sender, EventArgs e)
        {
            ResetDefaultValueToForm();
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Visible = cmbFilterBy.SelectedIndex != 0;
            if (txtFilterBy.Visible)
            {
                txtFilterBy.Text = string.Empty;
                txtFilterBy.Focus();
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (cmbFilterBy.SelectedIndex == 0 || string.IsNullOrEmpty(txtFilterBy.Text))
            {
                _dtAllUsers.DefaultView.RowFilter = string.Empty;
                labCountRecords.Text = dgvAllUsers.RowCount.ToString();
                return;
            }
            if (cmbFilterBy.Text == "Id" || cmbFilterBy.Text == "Person Id")
            {
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}]={1}", cmbFilterBy.Text, txtFilterBy.Text.Trim());
            }
            else
            {
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}]Like '{1}%'", cmbFilterBy.Text, txtFilterBy.Text.Trim());

            }
            labCountRecords.Text = dgvAllUsers.RowCount.ToString();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cmbFilterBy.Text)
            {
                case "Id":
                case "Person Id":
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;

                case "Username":
                    if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }
    }
}
