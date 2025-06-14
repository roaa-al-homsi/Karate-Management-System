using KarateBusiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace KarateSystem.Members
{
    public partial class frmManageMembers : Form
    {
        private DataTable _dtAllMembers;
        private frmMain _frmMain;
        public frmManageMembers(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }
        private void _ChangeDesignDgvMembers()
        {
            if (dgvAllMembers.Rows.Count > 0)
            {
                //Member Id
                dgvAllMembers.Columns[0].Width = 110;
                //person Id
                dgvAllMembers.Columns[1].Width = 110;
                //FullName
                dgvAllMembers.Columns[2].Width = 190;

                dgvAllMembers.Columns[3].Width = 110;
                //contact
                dgvAllMembers.Columns[4].Width = 180;
                //Country
                dgvAllMembers.Columns[5].Width = 140;
                //Member Id
                dgvAllMembers.Columns[6].Width = 180;
            }
        }
        private void _FillCmbFilterBy()
        {
            DataTable dtMembers = _dtAllMembers;
            foreach (DataColumn column in dtMembers.Columns)
            {
                if (column.ColumnName == "Is Active" || column.ColumnName == "Emergency Contact Info")
                {
                    continue;
                }
                cmbFilterBy.Items.Add(column.ColumnName);

            }
        }
        private void frmManageMembers_Load(object sender, EventArgs e)
        {
            _dtAllMembers = Member.All();
            dgvAllMembers.DataSource = _dtAllMembers;
            _ChangeDesignDgvMembers();
            _FillCmbFilterBy();
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Visible = (cmbFilterBy.Text != "None");
            if (txtFilterBy.Visible)
            {
                txtFilterBy.Text = string.Empty;
                txtFilterBy.Focus();
            }
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cmbFilterBy.Text)
            {
                case "Person Id":
                case "Member Id":
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;
                default:
                    if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (cmbFilterBy.SelectedIndex == 0 || string.IsNullOrEmpty(txtFilterBy.Text))
            {
                _dtAllMembers.DefaultView.RowFilter = string.Empty;

                labCountRecords.Text = dgvAllMembers.RowCount.ToString();
                return;
            }

            switch (cmbFilterBy.Text)
            {
                case "Person Id":
                case "Member Id":
                    _dtAllMembers.DefaultView.RowFilter = string.Format("[{0}]={1}", cmbFilterBy.Text, txtFilterBy.Text.Trim());
                    break;
                default:
                    _dtAllMembers.DefaultView.RowFilter = string.Format("[{0}]Like '{1}%'", cmbFilterBy.Text, txtFilterBy.Text.Trim());
                    break;

            }
            labCountRecords.Text = dgvAllMembers.RowCount.ToString();
        }
    }
}
