using KarateBusiness;
using System.Windows.Forms;

namespace KarateSystem.Instructors.uc
{
    public partial class uc_InstructorInfoCard : UserControl
    {
        private int _instructorId;

        public int InstructorId
        {
            get
            {
                return _instructorId;
            }
            set
            {
                _instructorId = value;
            }
        }

        private Instructor _instructor;
        public Instructor InstructorSelected
        {
            get { return _instructor; }
        }
        public uc_InstructorInfoCard()
        {
            InitializeComponent();
        }
        private void _LoadDataToForm()
        {
            uc_PersonInfoCard1.LoadPersonInfo(_instructor.personId);
            txtInstructorId.Text = _instructorId.ToString();
            txtQualifications.Text = _instructor.qualifications;
        }
        public void LoadInstructorInfo(int instructorId)
        {
            _instructor = Instructor.Find(instructorId);
            if (_instructor == null)
            {
                MessageBox.Show($"There isn't instructor with this Id:{instructorId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _instructorId = instructorId;
            _LoadDataToForm();
        }

        private void txtInstructorId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtQualifications_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void linkLabEditInstructor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateInstructor frmAddUpdateInstructor = new frmAddUpdateInstructor(_instructorId);
            frmAddUpdateInstructor.ShowDialog();

        }
    }
}
