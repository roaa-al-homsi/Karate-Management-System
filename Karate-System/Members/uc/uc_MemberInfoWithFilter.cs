using KarateBusiness;
using System;
using System.Windows.Forms;

namespace KarateSystem.Members.uc
{
    public partial class uc_MemberInfoWithFilter : UserControl
    {
        public event Action<int> OneMemberSelected;


        private int _memberId = -1;
        public int MemberId
        {
            get { return uc_MemberInfoCard1.MemberId; }

        }

        private bool _filterEnabled;
        public bool FilterEnabled
        {
            get { return _filterEnabled; }
            set { gbFilter.Enabled = value; }
        }

        private bool _showAddPerson = true;
        public bool ShowAddPerson
        {
            get { return _showAddPerson; }
            set
            {
                _showAddPerson = value;
                btnAdd.Visible = _showAddPerson;
            }
        }

        private Member _member;
        public Member MemberSelected
        {
            get { return uc_MemberInfoCard1.SelectedMember; }
        }


        public uc_MemberInfoWithFilter()
        {
            InitializeComponent();
        }
        public void LoadMemberInfo(int memberId)
        {
            _memberId = memberId;
            txtFilterValue.Text = memberId.ToString();
            uc_MemberInfoCard1.LoadMemberInfo(memberId);
            FilterEnabled = false;
            if (OneMemberSelected != null)
            {
                OneMemberSelected(uc_MemberInfoCard1.MemberId);
            }

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnFind_Click(object sender, System.EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some Fields are not valid , put mouse on red icons to read requirement..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            uc_MemberInfoCard1.LoadMemberInfo(Convert.ToInt32(txtFilterValue.Text));
            _memberId = uc_MemberInfoCard1.MemberId;
            if (OneMemberSelected != null)
            {
                OneMemberSelected.Invoke(_memberId);
            }
        }

        private void uc_MemberInfoWithFilter_Load(object sender, EventArgs e)
        {
            txtFilterValue.Focus();
        }
        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateMember frmAddUpdateMember = new frmAddUpdateMember();
            frmAddUpdateMember.DataBackMember += _DataBackMethod;
            frmAddUpdateMember.ShowDialog();

        }
        private void _DataBackMethod(object sender, int memberId)
        {
            txtFilterValue.Text = memberId.ToString();
            uc_MemberInfoCard1.LoadMemberInfo(memberId);
            FilterEnabled = false;
        }

        private void txtFilterValue_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!!");
            }
        }
    }
}
