using Guna.UI2.WinForms;
using KarateBusiness;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateSystem.Belt_Ranks
{
    public partial class frmAddUpdateBeltRank : Form
    {
        private enum mode { Add = 0, Update = 1 }
        private mode _mode;
        private int _beltId;
        private BeltRank _beltRank;
        public frmAddUpdateBeltRank()
        {
            InitializeComponent();
            _mode = mode.Add;
        }
        public frmAddUpdateBeltRank(int beltId)
        {
            InitializeComponent();
            _beltId = beltId;
            _mode = mode.Update;
        }
        private void _ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(textBox, null);
            }
        }

        private void txtTestFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void _LoadBeltDataToForm()
        {
            _beltRank = BeltRank.Find(_beltId);
            if (_beltRank == null)
            {
                MessageBox.Show("There is no belt rank with this Id:{_beltId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LabBeltId.Text = _beltId.ToString();
            txtNameBelt.Text = _beltRank.name;
            txtTestFees.Text = _beltRank.testFees.ToString();
        }
        private void _RestDefaultValues()
        {
            if (_mode == mode.Add)
            {
                _beltRank = new BeltRank();
                this.Text = "Add Belt Rank";
                labTitleForm.Text = "Add Belt Rank";
                return;
            }
            this.Text = "Update a Belt Rank";
            labTitleForm.Text = "Update a Belt Rank";
            _LoadBeltDataToForm();
        }
        private void frmAddUpdateBeltRank_Load(object sender, System.EventArgs e)
        {
            _RestDefaultValues();
        }

        private void _FillDataToBeltRank()
        {
            _beltRank.testFees = Convert.ToDecimal(txtTestFees.Text);
            _beltRank.name = txtNameBelt.Text;

        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not validate ,but the mouse over red icon");
                return;

            }
            _FillDataToBeltRank();
            if (_beltRank.Save())
            {
                LabBeltId.Text = _beltRank.id.ToString();
                _mode = mode.Update;
                this.Text = "Update a Belt Rank";
                labTitleForm.Text = "Update a Belt Rank";
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Data Failed Saved ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
