using System.Windows.Forms;

namespace KarateSystem.Instructors
{
    public partial class frmShowInstructorDetails : Form
    {
        public frmShowInstructorDetails(int instructorId)
        {
            InitializeComponent();
            uc_InstructorInfoCard1.LoadInstructorInfo(instructorId);
        }
    }
}
