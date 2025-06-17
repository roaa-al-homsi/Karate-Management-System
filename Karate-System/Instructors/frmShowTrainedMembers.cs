using System.Windows.Forms;

namespace KarateSystem.Instructors
{
    public partial class frmShowTrainedMembers : Form
    {
        private int _instructorId = -1;

        public frmShowTrainedMembers(int instructorId)
        {
            InitializeComponent();
            uc_InstructorInfoCard1.LoadInstructorInfo(instructorId);
            _instructorId = instructorId;
        }

        private void frmShowTrainedMembers_Load(object sender, System.EventArgs e)
        {

        }
    }
}
