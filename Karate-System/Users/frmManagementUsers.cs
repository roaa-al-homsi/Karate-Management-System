using KarateBusiness;
using KarateSystem.People;
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
            _ChangeFormatDgvAllPeople();
        }
        private void frmManagementUsers_Load(object sender, EventArgs e)
        {
            ResetDefaultValueToForm();
        }

        private void _ChangeFormatDgvAllPeople()
        {
            if (dgvAllUsers.Rows.Count > 0)
            {
                //"Id";
                dgvAllUsers.Columns[0].Width = 110;

                //FullName
                dgvAllUsers.Columns[0].Width = 150;

                //username
                dgvAllUsers.Columns[0].Width = 120;

                //IsActive
                dgvAllUsers.Columns[0].Width = 110;

            }
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

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAddUpdatePerson = new frmAddUpdatePerson((int)dgvAllUsers.CurrentRow.Cells[2].Value);
            frmAddUpdatePerson.ShowDialog();
            frmManagementUsers_Load(null, null);

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frmShowPersonInfo = new frmShowPersonInfo((int)dgvAllUsers.CurrentRow.Cells[2].Value);
            frmShowPersonInfo.ShowDialog();
            frmManagementUsers_Load(null, null);


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this user?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (User.Delete(Convert.ToInt32(dgvAllUsers.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmManagementUsers_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
