using KarateBusiness;
using System.Data;
using System.Windows.Forms;

namespace KarateSystem.Subscription_Periods
{
    public partial class frmManageSubscriptionPeriods : Form
    {
        private frmMain _frmMain;
        private DataTable _dtAllPeriods;
        public frmManageSubscriptionPeriods(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }
        private void _ChangeDesignDgvAllMembersInstructors()
        {
            if (dgvAllPeriods.Rows.Count > 0)
            {
                dgvAllPeriods.Columns[0].Width = 110;
                dgvAllPeriods.Columns[1].Width = 190;
                dgvAllPeriods.Columns[2].Width = 110;
                dgvAllPeriods.Columns[3].Width = 150;
                dgvAllPeriods.Columns[4].Width = 140;
                dgvAllPeriods.Columns[5].Width = 110;
                dgvAllPeriods.Columns[6].Width = 110;
            }
        }
        private void _LoadDataToForm()
        {
            _dtAllPeriods = SubscriptionPeriod.All();
            dgvAllPeriods.DataSource = _dtAllPeriods;
            labCountRecords.Text = dgvAllPeriods.RowCount.ToString();
        }
        private void _FillCmbFilterBy()
        {
            foreach (DataColumn column in _dtAllPeriods.Columns)
            {
                if (column.ColumnName == "Start Date" || column.ColumnName == "End Date" || column.ColumnName == "Is Active" || column.ColumnName == "Fees")
                {
                    continue;
                }
                cmbFilterBy.Items.Add(column.ColumnName);
            }
        }
        private void frmManageSubscriptionPeriods_Load(object sender, System.EventArgs e)
        {
            _LoadDataToForm();
            _FillCmbFilterBy();
            cmbFilterBy.SelectedIndex = 0;
            txtFilterBy.Visible = false;
            _ChangeDesignDgvAllMembersInstructors();
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
                _dtAllPeriods.DefaultView.RowFilter = string.Empty;

                labCountRecords.Text = dgvAllPeriods.RowCount.ToString();
                return;
            }

            switch (cmbFilterBy.Text)
            {
                case "Period Id":
                case "Member Id":
                case "Id":
                case "Payment Id":
                    _dtAllPeriods.DefaultView.RowFilter = string.Format("[{0}]={1}", cmbFilterBy.Text, txtFilterBy.Text.Trim());
                    break;
                default:
                    _dtAllPeriods.DefaultView.RowFilter = string.Format("[{0}]Like '{1}%'", cmbFilterBy.Text, txtFilterBy.Text.Trim());
                    break;

            }
            labCountRecords.Text = dgvAllPeriods.RowCount.ToString();
        }
        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cmbFilterBy.Text)
            {
                case "Period Id":
                case "Member Id":
                case "Id":
                case "Payment Id":
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

        private void btnAddSubscriptionPeriod_Click(object sender, System.EventArgs e)
        {
            frmAddUpdateSub_Period frmAddUpdateSub_Period = new frmAddUpdateSub_Period();
            frmAddUpdateSub_Period.ShowDialog();
            frmManageSubscriptionPeriods_Load(null, null);
        }

        private void updateToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmAddUpdateSub_Period frmAddUpdateSub_Period = new frmAddUpdateSub_Period((int)dgvAllPeriods.CurrentRow.Cells[0].Value);
            frmAddUpdateSub_Period.ShowDialog();
            frmManageSubscriptionPeriods_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmShowPeriodHistoryForSpecificMember frmShowPeriodHistoryForSpecificMember = new frmShowPeriodHistoryForSpecificMember((int)dgvAllPeriods.CurrentRow.Cells[2].Value);
            frmShowPeriodHistoryForSpecificMember.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmShowSubscriptionPeriodInfo frmShowSubscriptionPeriodInfo = new frmShowSubscriptionPeriodInfo((int)dgvAllPeriods.CurrentRow.Cells[0].Value);
            frmShowSubscriptionPeriodInfo.ShowDialog();
        }

        private void addNewPeriodToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmAddUpdateSub_Period frmAddUpdateSub_Period = new frmAddUpdateSub_Period();
            frmAddUpdateSub_Period.ShowDialog();
            frmManageSubscriptionPeriods_Load(null, null);
        }

        private void cmsManagePeriods_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            renewSubscriptionToolStripMenuItem.Enabled = !(bool)dgvAllPeriods.CurrentRow.Cells[7].Value;
        }
    }
}
