using KarateBusiness;
using System.Windows.Forms;

namespace KarateSystem.Members.uc
{
    public partial class uc_MemberInfoCard : UserControl
    {
        private int _memberId = -1;
        public int MemberId
        {
            get { return _memberId; }
            set { _memberId = value; }
        }

        private Member _member;
        public Member SelectedMember
        {
            get { return _member; }
        }
        public uc_MemberInfoCard()
        {
            InitializeComponent();
        }
        private void _LoadMemberDataToForm()
        {
            txtContactInfo.Text = _member.emergencyContactInfo;
            txtLastBeltRank.Text = _member.lastBeltRank.ToString();
            txtMemberId.Text = _member.id.ToString();
            txtIsActive.Text = _member.isActive ? "Yes" : "No";
        }
        private void _LoadDataToForm()
        {
            uc_PersonInfoCard1.LoadPersonInfo(_member.personId);
            _LoadMemberDataToForm();
        }
        public void LoadMemberInfo(int memberId)
        {
            _member = Member.Find(memberId);
            if (_member == null)
            {
                MessageBox.Show($"There is no a member with this Id:[{memberId}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _memberId = memberId;
            _LoadDataToForm();
        }

    }
}
