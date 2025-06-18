using KarateBusiness;
using System;
using System.Windows.Forms;

namespace KarateSystem.Instructors.uc
{
    public partial class uc_InstructorInfoWithFilter : UserControl
    {
        private int _instructorId;
        public int InstructorId
        {
            get { return uc_InstructorInfoCard1.InstructorId; }

        }
        public Instructor InstructorSelected
        {
            get { return uc_InstructorInfoCard1.InstructorSelected; }

        }
        private bool _filterEnabled;
        public bool FilterEnabled
        {
            get { return _filterEnabled; }
            set { gbFilter.Enabled = value; }
        }
        private bool _showAddInstructor;
        public bool ShowAddInstructor
        {
            get { return _showAddInstructor; }
            set { _showAddInstructor = value; }
        }

        public uc_InstructorInfoWithFilter()
        {
            InitializeComponent();
        }


        public void LoadInstructorData(int instructorId)
        {
            txtFilterValue.Text = instructorId.ToString();
            FilterEnabled = false;
            ShowAddInstructor = false;
            uc_InstructorInfoCard1.LoadInstructorInfo(instructorId);

        }

        private void btnFind_Click(object sender, System.EventArgs e)
        {
            uc_InstructorInfoCard1.LoadInstructorInfo(Convert.ToInt32(txtFilterValue.Text));
            _instructorId = uc_InstructorInfoCard1.InstructorId;
        }

        private void uc_InstructorInfoWithFilter_Load(object sender, EventArgs e)
        {
            txtFilterValue.Focus();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateInstructor frmAddUpdateInstructor = new frmAddUpdateInstructor();
            frmAddUpdateInstructor.DataBackInstructor += _DataBackInstructor;
            frmAddUpdateInstructor.ShowDialog();

        }
        private void _DataBackInstructor(object sender, int instructorId)
        {
            txtFilterValue.Text = instructorId.ToString();
            uc_InstructorInfoCard1.LoadInstructorInfo(instructorId);
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
