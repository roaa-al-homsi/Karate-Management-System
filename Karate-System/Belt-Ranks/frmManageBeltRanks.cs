using KarateBusiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace KarateSystem.Belt_Ranks
{
    public partial class frmManageBeltRanks : Form
    {
        private frmMain _frmMain;
        private DataTable _dtAllBeltRanks;

        public frmManageBeltRanks(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }
        private void _ChangeFormatDgvAllPeople()
        {
            if (dgvAllBeltRanks.Rows.Count > 0)
            {
                dgvAllBeltRanks.Columns[0].Width = 110;
                dgvAllBeltRanks.Columns[1].Width = 170;
                dgvAllBeltRanks.Columns[2].HeaderText = "Test Fees";
                dgvAllBeltRanks.Columns[2].Width = 110;
            }
        }
        private void _FillCmbFilterBy()
        {
            DataTable dt = BeltRank.All();
            foreach (DataColumn column in dt.Columns)
            {
                if (column.ColumnName == "TestFees")
                {
                    continue;
                }
                cmbFilterBy.Items.Add(column.ColumnName);
            }
        }
        private void frmManageBeltRanks_Load(object sender, EventArgs e)
        {
            _dtAllBeltRanks = BeltRank.All();
            dgvAllBeltRanks.DataSource = _dtAllBeltRanks;
            _ChangeFormatDgvAllPeople();
            _FillCmbFilterBy();
            cmbFilterBy.SelectedIndex = 0;
            txtFilterBy.Visible = false;
            labCountRecords.Text = dgvAllBeltRanks.Rows.Count.ToString();
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
            if (string.IsNullOrEmpty(txtFilterBy.Text) || cmbFilterBy.Text == "None")
            {
                _dtAllBeltRanks.DefaultView.RowFilter = string.Empty;
                labCountRecords.Text = dgvAllBeltRanks.RowCount.ToString();
                return;
            }

            if (cmbFilterBy.Text == "Id")
            {
                _dtAllBeltRanks.DefaultView.RowFilter = string.Format("[{0}]={1}", cmbFilterBy.Text, txtFilterBy.Text.Trim());
            }
            else
            {
                _dtAllBeltRanks.DefaultView.RowFilter = string.Format("[{0}]Like '{1}%'", cmbFilterBy.Text, txtFilterBy.Text.Trim());

            }
            labCountRecords.Text = dgvAllBeltRanks.RowCount.ToString();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cmbFilterBy.Text)
            {
                case "Belt Id":
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;

                case "Name":
                    if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this Belt?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (BeltRank.Delete(Convert.ToInt32(dgvAllBeltRanks.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmManageBeltRanks_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdateBeltRank frmAddUpdateBeltRank = new frmAddUpdateBeltRank();
            frmAddUpdateBeltRank.ShowDialog();
            frmManageBeltRanks_Load(null, null);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBeltRank frmAddUpdateBeltRank = new frmAddUpdateBeltRank((int)dgvAllBeltRanks.CurrentRow.Cells[0].Value);
            frmAddUpdateBeltRank.ShowDialog();
            frmManageBeltRanks_Load(null, null);
        }
    }
}
