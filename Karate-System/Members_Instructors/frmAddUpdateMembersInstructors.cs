using KarateBusiness;
using System;
using System.Windows.Forms;

namespace KarateSystem.Members_Instructors
{
    public partial class frmAddUpdateMembersInstructors : Form
    {
        private enum mode { Add = 0, Update = 1 }
        private mode _mode;
        private int _recordMembersInstructorId = -1;
        private MemberInstructor _memberInstructor;
        public frmAddUpdateMembersInstructors()
        {
            InitializeComponent();
            _mode = mode.Add;
        }
        public frmAddUpdateMembersInstructors(int recordMembersInstructorId)
        {
            InitializeComponent();
            _recordMembersInstructorId = recordMembersInstructorId;
            _mode = mode.Update;
        }
        private void _LoadMembersInstructorDataToForm()
        {
            _memberInstructor = MemberInstructor.Find(_recordMembersInstructorId);
            if (_memberInstructor == null)
            {
                MessageBox.Show("");
                uc_MemberInfoWithFilter1.FilterFocus();
            }
            else
            {
                uc_MemberInfoWithFilter1.LoadMemberInfo(_memberInstructor.memberId);
                uc_InstructorInfoWithFilter1.LoadInstructorData(_memberInstructor.instructorId);
                txtMemberInstructorId.Text = _memberInstructor.id.ToString();
                dtpAssignDate.Value = _memberInstructor.assignDate;
            }
        }
        private void _ResetDefaultValueToForm()
        {
            if (_mode == mode.Add)
            {
                _memberInstructor = new MemberInstructor();
                this.Text = "Add New Member-Instructor";
                labTitle.Text = "Add New Member-Instructor";
                tpInstructor.Enabled = false;

                uc_InstructorInfoWithFilter1.FilterEnabled = true;
                uc_MemberInfoWithFilter1.FilterEnabled = true;
                return;
            }
            this.Text = "Update Member-Instructor";
            labTitle.Text = "Update Member-Instructor";
            uc_InstructorInfoWithFilter1.FilterEnabled = false;
            uc_MemberInfoWithFilter1.FilterEnabled = false;
            _LoadMembersInstructorDataToForm();
        }
        private void frmAddUpdateMembersInstructors_Load(object sender, EventArgs e)
        {
            _ResetDefaultValueToForm();
        }

        private void _FillMemberInstructorDataToObject()
        {
            _memberInstructor.assignDate = dtpAssignDate.Value;
            _memberInstructor.instructorId = uc_InstructorInfoWithFilter1.InstructorId;
            _memberInstructor.memberId = uc_MemberInfoWithFilter1.MemberId;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Field are not valid ,Put the mouse over the red icon!!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillMemberInstructorDataToObject();
            if (_memberInstructor.Save())
            {
                txtMemberInstructorId.Text = _memberInstructor.id.ToString();
                _mode = mode.Update;
                this.Text = "Update Member-Instructor";
                labTitle.Text = "Update Member-Instructor";
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //maybe delegate here 
            }
            else
            {
                MessageBox.Show("Data Failed Saved ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (uc_MemberInfoWithFilter1.MemberId == -1)
            {
                MessageBox.Show("You can't add a instructor without choose a member first!!.., Please choose a member.");
                uc_MemberInfoWithFilter1.FilterFocus();
                return;
            }
            tpInstructor.Enabled = true;
            tcMemberInstructor.SelectedTab = tcMemberInstructor.TabPages["tpInstructor"];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
