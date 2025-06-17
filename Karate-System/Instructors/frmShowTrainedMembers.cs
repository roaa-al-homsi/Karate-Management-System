using KarateBusiness;
using KarateSystem.Members;
using System.Data;
using System.Windows.Forms;

namespace KarateSystem.Instructors
{
    public partial class frmShowTrainedMembers : Form
    {
        private int _instructorId = -1;

        private DataTable _dtMembersByInstructorId;
        public frmShowTrainedMembers(int instructorId)
        {
            InitializeComponent();
            uc_InstructorInfoCard1.LoadInstructorInfo(instructorId);
            _instructorId = instructorId;
        }
        private void _ChangeDesignDgvMembers()
        {
            if (dgvMembers.Rows.Count > 0)
            {

                dgvMembers.Columns[0].Width = 110;

                dgvMembers.Columns[1].Width = 190;

                dgvMembers.Columns[2].Width = 190;

                dgvMembers.Columns[3].Width = 170;
            }
        }
        private void frmShowTrainedMembers_Load(object sender, System.EventArgs e)
        {
            _dtMembersByInstructorId = MemberInstructor.GetAllMembersBySpecificInstructor(_instructorId);
            dgvMembers.DataSource = _dtMembersByInstructorId;
            _ChangeDesignDgvMembers();
            labCountRecords.Text = dgvMembers.RowCount.ToString();
        }

        private void toolStripMenuMemberDetails_Click(object sender, System.EventArgs e)
        {
            frmShowMemberDetails frmShowMemberDetails = new frmShowMemberDetails((int)dgvMembers.CurrentRow.Cells[0].Value);
            frmShowMemberDetails.ShowDialog();
            frmShowTrainedMembers_Load(null, null);
        }

        private void updateMemberToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmAddUpdateMember frmAddUpdateMember = new frmAddUpdateMember((int)dgvMembers.CurrentRow.Cells[0].Value);
            frmAddUpdateMember.ShowDialog();
            frmShowTrainedMembers_Load(null, null);

        }
    }
}
