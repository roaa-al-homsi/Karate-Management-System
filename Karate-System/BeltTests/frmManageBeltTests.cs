using KarateBusiness;
using System.Data;
using System.Windows.Forms;

namespace KarateSystem.BeltTests
{
    public partial class frmManageBeltTests : Form
    {//view_BeltTests_Info
        private DataTable _dtAllBeltTests;
        private frmMain _frmMain;
        public frmManageBeltTests(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }
        private void _ChangeFormatDgvAllBeltTests()
        {
            if (dgvAllBeltTests.Rows.Count > 0)
            {
                dgvAllBeltTests.Columns[0].Width = 100;
                dgvAllBeltTests.Columns[1].Width = 110;

                dgvAllBeltTests.Columns[2].Width = 110;
                dgvAllBeltTests.Columns[3].Width = 110;
                dgvAllBeltTests.Columns[4].Width = 190;
                dgvAllBeltTests.Columns[5].Width = 160;
                dgvAllBeltTests.Columns[6].Width = 190;
                dgvAllBeltTests.Columns[7].Width = 120;
                dgvAllBeltTests.Columns[8].Width = 110;
            }
        }
        private void _FillCmbFilterBy()
        {
            DataTable dt = BeltTest.All();
            foreach (DataColumn column in dt.Columns)
            {
                if (column.ColumnName == "Date" || column.ColumnName == "Result")
                {
                    continue;
                }
                cmbFilterBy.Items.Add(column.ColumnName);
            }
        }

        private void frmManageBeltTests_Load(object sender, System.EventArgs e)
        {
            _dtAllBeltTests = BeltTest.All();
            dgvAllBeltTests.DataSource = _dtAllBeltTests;
            _ChangeFormatDgvAllBeltTests();
            _FillCmbFilterBy();
            cmbFilterBy.SelectedIndex = 0;
            txtFilterBy.Visible = false;
            labCountRecords.Text = dgvAllBeltTests.Rows.Count.ToString();
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            txtFilterBy.Visible = cmbFilterBy.SelectedIndex != 0;
            if (txtFilterBy.Visible)
            {
                txtFilterBy.Text = string.Empty;
                txtFilterBy.Focus();
            }
        }

        private void txtFilterBy_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterBy.Text) || cmbFilterBy.Text == "None")
            {
                _dtAllBeltTests.DefaultView.RowFilter = string.Empty;
                labCountRecords.Text = dgvAllBeltTests.RowCount.ToString();
                return;
            }
            switch (cmbFilterBy.Text)
            {
                case "Test Id":
                case "Payment Id":
                case "Member Id":
                case "Belt Rank Id":
                case "Test By Instructor Id":
                    _dtAllBeltTests.DefaultView.RowFilter = string.Format("[{0}]={1}", cmbFilterBy.Text, txtFilterBy.Text.Trim());
                    break;
                default:
                    _dtAllBeltTests.DefaultView.RowFilter = string.Format("[{0}]Like '{1}%'", cmbFilterBy.Text, txtFilterBy.Text.Trim());
                    break;
            }
            labCountRecords.Text = dgvAllBeltTests.RowCount.ToString();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cmbFilterBy.Text)
            {
                case "Test Id":
                case "Payment Id":
                case "Member Id":
                case "Belt Rank Id":
                case "Test By Instructor Id":
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

        private void btnAddTest_Click(object sender, System.EventArgs e)
        {
            frmAddUpdateBeltTest frmAddUpdateBeltTest = new frmAddUpdateBeltTest();
            frmAddUpdateBeltTest.ShowDialog();
            frmManageBeltTests_Load(null, null);
        }

        private void updateToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmAddUpdateBeltTest frmAddUpdateBeltTest = new frmAddUpdateBeltTest((int)dgvAllBeltTests.CurrentRow.Cells[0].Value);
            frmAddUpdateBeltTest.ShowDialog();
            frmManageBeltTests_Load(null, null);
        }
    }
}
