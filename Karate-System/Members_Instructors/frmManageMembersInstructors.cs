using KarateBusiness;
using System.Data;
using System.Windows.Forms;

namespace KarateSystem.Members_Instructors
{
    public partial class frmManageMembersInstructors : Form
    {
        private frmMain _frmMain;
        private DataTable _dtMembersInstructors;
        public frmManageMembersInstructors(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }
        private void _ChangeDesignDgvAllMembersInstructors()
        {
            if (dgvAllMembersInstructors.Rows.Count > 0)
            {
                dgvAllMembersInstructors.Columns[0].Width = 110;
                dgvAllMembersInstructors.Columns[1].Width = 110;
                dgvAllMembersInstructors.Columns[2].Width = 190;
                dgvAllMembersInstructors.Columns[3].Width = 110;
                dgvAllMembersInstructors.Columns[4].Width = 190;
                dgvAllMembersInstructors.Columns[5].Width = 180;
            }
        }
        private void _LoadDataToForm()
        {
            _dtMembersInstructors = MemberInstructor.All();
            dgvAllMembersInstructors.DataSource = _dtMembersInstructors;
            labCountRecords.Text = dgvAllMembersInstructors.RowCount.ToString();
        }
        private void _FillCmbFilterBy()
        {
            foreach (DataColumn column in _dtMembersInstructors.Columns)
            {
                if (column.ColumnName == "Assign Date")
                {
                    continue;
                }
                cmbFilterBy.Items.Add(column.ColumnName);
            }
        }
        private void frmManageMembersInstructors_Load(object sender, System.EventArgs e)
        {
            _LoadDataToForm();
            _FillCmbFilterBy();
            cmbFilterBy.SelectedIndex = 0;
            txtFilterBy.Visible = false;
            _ChangeDesignDgvAllMembersInstructors();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cmbFilterBy.Text)
            {
                case "Instructor Id":
                case "Member Id":
                case "Id":
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

        private void cmbFilterBy_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            txtFilterBy.Visible = (cmbFilterBy.Text != "None");
            if (txtFilterBy.Visible)
            {
                txtFilterBy.Text = string.Empty;
                txtFilterBy.Focus();
            }
        }

        private void txtFilterBy_TextChanged(object sender, System.EventArgs e)
        {
            if (cmbFilterBy.SelectedIndex == 0 || string.IsNullOrEmpty(txtFilterBy.Text))
            {
                _dtMembersInstructors.DefaultView.RowFilter = string.Empty;

                labCountRecords.Text = dgvAllMembersInstructors.RowCount.ToString();
                return;
            }

            switch (cmbFilterBy.Text)
            {
                case "Instructor Id":
                case "Member Id":
                case "Id":
                    _dtMembersInstructors.DefaultView.RowFilter = string.Format("[{0}]={1}", cmbFilterBy.Text, txtFilterBy.Text.Trim());
                    break;
                default:
                    _dtMembersInstructors.DefaultView.RowFilter = string.Format("[{0}]Like '{1}%'", cmbFilterBy.Text, txtFilterBy.Text.Trim());
                    break;

            }
            labCountRecords.Text = dgvAllMembersInstructors.RowCount.ToString();
        }
    }
}
