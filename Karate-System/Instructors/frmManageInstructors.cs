using KarateBusiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace KarateSystem.Instructors
{
    public partial class frmManageInstructors : Form
    {
        private DataTable _dtAllInstructors;
        private frmMain _frmMain;
        public frmManageInstructors(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }
        private void _ChangeDesignDgvMembers()
        {
            if (dgvAllInstructor.Rows.Count > 0)
            {
                //Instructor Id
                dgvAllInstructor.Columns[0].Width = 110;

                //FullName
                dgvAllInstructor.Columns[1].Width = 190;
                //gender
                dgvAllInstructor.Columns[2].Width = 110;
                //birth
                dgvAllInstructor.Columns[3].Width = 192;
                //Country
                dgvAllInstructor.Columns[4].Width = 140;
                //Member Id
                dgvAllInstructor.Columns[6].Width = 180;
            }
        }
        private void _FillCmbFilterBy()
        {
            foreach (DataColumn column in _dtAllInstructors.Columns)
            {
                if (column.ColumnName == "Date Of Birth" || column.ColumnName == "Phone")
                {
                    continue;
                }
                cmbFilterBy.Items.Add(column.ColumnName);
            }
        }
        private void _ResetDefaultValuesToForm()
        {
            _dtAllInstructors = Instructor.All();
            dgvAllInstructor.DataSource = _dtAllInstructors;
            _FillCmbFilterBy();
            _ChangeDesignDgvMembers();
            cmbFilterBy.SelectedIndex = 0;
            labCountRecords.Text = dgvAllInstructor.RowCount.ToString();
        }
        private void frmManageInstructors_Load(object sender, EventArgs e)
        {
            _ResetDefaultValuesToForm();
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
            if (string.IsNullOrEmpty(txtFilterBy.Text))
            {
                _dtAllInstructors.DefaultView.RowFilter = string.Empty;
                labCountRecords.Text = dgvAllInstructor.RowCount.ToString();
                return;
            }
            switch (cmbFilterBy.Text)
            {
                case "None":
                    _dtAllInstructors.DefaultView.RowFilter = string.Empty;
                    break;
                case "Instructor Id":
                    _dtAllInstructors.DefaultView.RowFilter = string.Format("[{0}]={1}", cmbFilterBy.Text, txtFilterBy.Text.Trim());
                    break;
                default:
                    _dtAllInstructors.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", cmbFilterBy.Text, txtFilterBy.Text.Trim());
                    break;

            }
            labCountRecords.Text = dgvAllInstructor.RowCount.ToString();
        }
        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cmbFilterBy.Text)
            {
                case "Instructor Id":
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

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            frmAddUpdateInstructor frmAddUpdateInstructor = new frmAddUpdateInstructor();
            frmAddUpdateInstructor.ShowDialog();
            frmManageInstructors_Load(null, null);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateInstructor frmAddUpdateInstructor = new frmAddUpdateInstructor((int)dgvAllInstructor.CurrentRow.Cells[0].Value);
            frmAddUpdateInstructor.ShowDialog();
            frmManageInstructors_Load(null, null);
        }
    }
}
