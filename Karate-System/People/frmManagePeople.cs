using KarateBusiness;
using System.Data;
using System.Windows.Forms;

namespace KarateSystem.People
{
    public partial class frmManagePeople : Form
    {
        private frmMain _frmMain;
        private DataTable _dtPeople = Person.AllPersonInfoInView();
        public frmManagePeople(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }
        private void _ChangeFormatDgvAllPeople()
        {
            if (dgvAllPeople.Rows.Count > 0)
            {
                dgvAllPeople.Columns[0].HeaderText = "Person Id";
                dgvAllPeople.Columns[0].Width = 110;

                //dgvAllPeople.Columns[1].HeaderText = "National No";
                dgvAllPeople.Columns[1].Width = 170;

                // dgvAllPeople.Columns[2].HeaderText = "First Name";
                dgvAllPeople.Columns[2].Width = 110;

                // dgvAllPeople.Columns[3].HeaderText = "Second Name";
                dgvAllPeople.Columns[3].Width = 120;

                // dgvAllPeople.Columns[4].HeaderText = "Third Name";
                dgvAllPeople.Columns[4].Width = 110;

                // dgvAllPeople.Columns[5].HeaderText = "Last Name";
                dgvAllPeople.Columns[5].Width = 110;

                //width Email
                dgvAllPeople.Columns[6].Width = 170;

                //width address
                dgvAllPeople.Columns[7].Width = 110;

                //width phone
                dgvAllPeople.Columns[8].Width = 120;

                // dgvAllPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvAllPeople.Columns[9].Width = 120;

                //width gender
                dgvAllPeople.Columns[9].Width = 110;

                //width nationality
                dgvAllPeople.Columns[9].Width = 120;

            }
        }
        private void _FillCmbFilterBy()
        {
            DataTable dt = Person.AllPersonInfoInView();
            foreach (DataColumn column in dt.Columns)
            {
                if (column.ColumnName == "Date Of Birth" || column.ColumnName == "Email" || column.ColumnName == "Address" || column.ColumnName == "Phone")
                {
                    continue;
                }
                cmbFilterBy.Items.Add(column.ColumnName);
            }
        }

        private void frmManagePeople_Load(object sender, System.EventArgs e)
        {
            dgvAllPeople.DataSource = _dtPeople;
            _ChangeFormatDgvAllPeople();
            _FillCmbFilterBy();
            cmbFilterBy.SelectedIndex = 0;
            txtFilterBy.Visible = false;
            labCountRecords.Text = dgvAllPeople.Rows.Count.ToString();
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
                _dtPeople.DefaultView.RowFilter = string.Empty;
                labCountRecords.Text = dgvAllPeople.RowCount.ToString();
                return;
            }

            if (cmbFilterBy.Text == "Id")
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}]={1}", cmbFilterBy.Text, txtFilterBy.Text.Trim());
            }
            else
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}]Like '{1}%'", cmbFilterBy.Text, txtFilterBy.Text.Trim());

            }
            labCountRecords.Text = dgvAllPeople.RowCount.ToString();

        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cmbFilterBy.Text)
            {
                case "Id":
                case "National Number":
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;

                case "First Name":
                case "Second Name":
                case "Third Name":
                case "Last Name":
                    if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }
    }
}
