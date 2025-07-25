﻿using KarateBusiness;
using System.Windows.Forms;

namespace KarateSystem.Members_Instructors.uc
{
    public partial class uc_MemberInstructorInfoCard : UserControl
    {
        private int _memberInstructorId = -1;
        public int MemberInstructorId
        {
            get { return _memberInstructorId; }
            set { _memberInstructorId = value; }
        }

        private int _memberId = -1;
        public int MemberId
        {
            get { return uc_MemberInfoCard1.MemberId; }
        }

        private int _instructorId = -1;
        public int InstructorId
        {
            get { return uc_InstructorInfoCard1.InstructorId; }
        }

        private MemberInstructor _memberInstructor;
        public MemberInstructor MemberInstructor
        {
            get { return _memberInstructor; }
        }
        public uc_MemberInstructorInfoCard()
        {
            InitializeComponent();
        }
        private void _LoadDataToForm()
        {
            uc_MemberInfoCard1.LoadMemberInfo(_memberInstructor.memberId);
            uc_InstructorInfoCard1.LoadInstructorInfo(_memberInstructor.instructorId);
            txtMemberInstructorId.Text = _memberInstructor.id.ToString();
            dtpAssignDate.Value = _memberInstructor.assignDate;
            _memberId = uc_MemberInfoCard1.MemberId;
            _instructorId = uc_InstructorInfoCard1.InstructorId;
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

        private void linkLabEditMemberInstructor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateMembersInstructors frmAddUpdateMembersInstructors = new frmAddUpdateMembersInstructors(MemberInstructorId);
            frmAddUpdateMembersInstructors.ShowDialog();
        }
    }
}
