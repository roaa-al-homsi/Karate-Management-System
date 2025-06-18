using KarateBusiness;
using System.Windows.Forms;

namespace KarateSystem.Members_Instructors.uc
{
    public partial class MemberInstructorInfoCard : UserControl
    {
        private int _memberInstructorId = -1;
        public int MemberInstructorId
        {
            get { return _memberInstructorId; }
            set { _memberInstructorId = value; }
        }
        private MemberInstructor _memberInstructor;
        public MemberInstructor MemberInstructor
        {
            get { return _memberInstructor; }
        }
        public MemberInstructorInfoCard()
        {
            InitializeComponent();
        }
        private void _LoadDataToForm()
        {
            uc_MemberInfoCard1.LoadMemberInfo(_memberInstructor.memberId);
            uc_InstructorInfoCard1.LoadInstructorInfo(_memberInstructor.instructorId);
        }
        public void LoadMemberInstructorInfo(int memberInstructorId)
        {
            _memberInstructor = MemberInstructor.Find(memberInstructorId);
            if (_memberInstructor == null)
            {
                MessageBox.Show($"There is not member instructor record with this Id:{memberInstructorId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _memberInstructorId = memberInstructorId;
            _LoadDataToForm();
        }
    }
}
