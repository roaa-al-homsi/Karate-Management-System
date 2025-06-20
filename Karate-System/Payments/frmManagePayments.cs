using KarateBusiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace KarateSystem.Payments
{
    public partial class frmManagePayments : Form
    {
        private frmMain _frmMain;
        private DataTable _dtAllPayments;
        public frmManagePayments(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }
        private void _ChangeFormatDgvAllPayments()
        {
            if (dgvAllPayments.Rows.Count > 0)
            {
                dgvAllPayments.Columns[0].Width = 100;
                dgvAllPayments.Columns[1].Width = 100;
                dgvAllPayments.Columns[2].Width = 110;
                dgvAllPayments.Columns[3].Width = 110;
                dgvAllPayments.Columns[4].Width = 210;
            }
        }
        private void _FillCmbFilterBy()
        {
            DataTable dt = Payment.All();
            foreach (DataColumn column in dt.Columns)
            {
                if (column.ColumnName == "Amount" || column.ColumnName == "Date")
                {
                    continue;
                }
                cmbFilterBy.Items.Add(column.ColumnName);
            }
        }

        private void frmManagePayments_Load(object sender, EventArgs e)
        {
            _dtAllPayments = Payment.All();
            dgvAllPayments.DataSource = _dtAllPayments;
            _ChangeFormatDgvAllPayments();
            _FillCmbFilterBy();
            cmbFilterBy.SelectedIndex = 0;
            txtFilterBy.Visible = false;
            labCountRecords.Text = dgvAllPayments.Rows.Count.ToString();
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
                _dtAllPayments.DefaultView.RowFilter = string.Empty;
                labCountRecords.Text = dgvAllPayments.RowCount.ToString();
                return;
            }
            switch (cmbFilterBy.Text)
            {
                case "Id":
                case "Payment Id":
                case "Member Id":
                    _dtAllPayments.DefaultView.RowFilter = string.Format("[{0}]={1}", cmbFilterBy.Text, txtFilterBy.Text.Trim());
                    break;
                default:
                    _dtAllPayments.DefaultView.RowFilter = string.Format("[{0}]Like '{1}%'", cmbFilterBy.Text, txtFilterBy.Text.Trim());
                    break;
            }
            labCountRecords.Text = dgvAllPayments.RowCount.ToString();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cmbFilterBy.Text)
            {
                case "Id":
                case "Payment Id":
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
    }
}
