using KarateSystem.Instructors;
using System.Windows.Forms;

namespace KarateSystem.Members_Instructors
{
    public partial class frmShowMemberInstructorDetails : Form
    {

        public frmShowMemberInstructorDetails(int memberInstructorId)
        {
            InitializeComponent();

            uc_MemberInstructorInfoCard1.LoadMemberInstructorInfo(memberInstructorId);
        }

        private void linkLabEditMemberInstructor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateMembersInstructors frmAddUpdateMembersInstructors = new frmAddUpdateMembersInstructors(uc_MemberInstructorInfoCard1.MemberInstructorId);
            frmAddUpdateMembersInstructors.ShowDialog();
        }

        private void linkLabShowTrainedMembers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowTrainedMembers frmTrainedMembers = new frmShowTrainedMembers(uc_MemberInstructorInfoCard1.InstructorId);
            frmTrainedMembers.ShowDialog();

        }
    }
}
