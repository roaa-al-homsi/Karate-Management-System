using KarateBusiness;
using System;
using System.Windows.Forms;

namespace KarateSystem.People.uc_Controls
{
    public partial class uc_PersonInfoWithFilter : UserControl
    {

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get { return _ShowAddPerson; }
            set
            {
                _ShowAddPerson = value;
                btnAdd.Visible = _ShowAddPerson;
            }
        }

        private bool _FilterEnable = true;
        public bool FilterEnable
        {
            get { return _FilterEnable; }
            set
            {
                _FilterEnable = value;
                gbFilter.Enabled = _FilterEnable;
            }
        }

        private int _PersonId = -1;
        public int PersonId
        {
            get { return uc_PersonInfoCard1.PersonId; }
        }
        public Person PersonInfoSelected
        {
            get
            {
                return uc_PersonInfoCard1.SelectedPersonInfo;
            }
        }


        public uc_PersonInfoWithFilter()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int personId)
        {
            cmbFilterBy.SelectedIndex = 0;
            txtFilterValue.Text = personId.ToString();
            FilterEnable = false;
            _PersonId = personId;
            FindPerson();
        }
        public void LoadPersonInfo(string nationalNum)
        {
            cmbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = nationalNum;
            FilterEnable = false;
            FindPerson();
        }
        private void FindPerson()
        {
            switch (cmbFilterBy.Text)
            {
                case "Id":
                    uc_PersonInfoCard1.LoadPersonInfo(Convert.ToInt16(txtFilterValue.Text));
                    return;
                case "National Number":
                    uc_PersonInfoCard1.LoadPersonInfo(txtFilterValue.Text);
                    return;
            }

            //raise for event ....
        }

        private void btnFind_Click(object sender, System.EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some Fields are not valid , put mouse on red icons to read requirement..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FindPerson();
        }

        private void uc_PersonInfoWithFilter_Load(object sender, System.EventArgs e)
        {
            cmbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            frmAddUpdatePerson frmAddUpdatePerson = new frmAddUpdatePerson();
            frmAddUpdatePerson.DataBack += _DataBackMethod;
            frmAddUpdatePerson.ShowDialog();
        }
        private void _DataBackMethod(object sender, int personId)
        {
            cmbFilterBy.SelectedIndex = 0;
            txtFilterValue.Text = personId.ToString();
            uc_PersonInfoCard1.LoadPersonInfo(personId);
            FilterEnable = false;
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check if the pressed key is Enter (character code is 13)
            if (e.KeyChar == (char)13)
            {
                btnFind.PerformLayout();
            }

            //This allows only digit..
            if (cmbFilterBy.Text == "Id")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            txtFilterValue.Text = string.Empty;
            txtFilterValue.Focus();
        }
        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }
    }
}
