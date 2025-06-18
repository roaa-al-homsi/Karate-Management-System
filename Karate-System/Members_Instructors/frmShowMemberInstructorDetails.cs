using System.Windows.Forms;

namespace KarateSystem.Members_Instructors
{
    public partial class frmShowMemberInstructorDetails : Form
    {
        private int _memberInstructorId = -1;

        public frmShowMemberInstructorDetails(int memberInstructorId)
        {
            InitializeComponent();
            _memberInstructorId = memberInstructorId;

        }
        private void
        private void linkLabEditMemberInstructor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateMembersInstructors frmAddUpdateMembersInstructors = new frmAddUpdateMembersInstructors();
            frmAddUpdateMembersInstructors.ShowDialog();
        }
    }
}
