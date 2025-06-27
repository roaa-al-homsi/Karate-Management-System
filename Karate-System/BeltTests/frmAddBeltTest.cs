using KarateBusiness;
using System;
using System.Windows.Forms;

namespace KarateSystem.BeltTests
{
    public partial class frmAddBeltTest : Form
    {
        public enum CreationMode { firstTime = 1, retake = 2, takeNextTest = 3 }
        private CreationMode _creationMode = CreationMode.firstTime;

        private int _beltTestId;
        private BeltTest _beltTest = new BeltTest();

        private int _oldTestId = -1;
        private int _memberSelectedId = -1;

        public frmAddBeltTest()
        {
            InitializeComponent();
            _creationMode = CreationMode.firstTime;
            uc_MemberInfoWithFilter1.FilterEnabled = true;
            uc_InstructorInfoWithFilter1.FilterEnabled = true;
        }
        public frmAddBeltTest(int memberId, int instructorId)
        {
            InitializeComponent();
            _creationMode = CreationMode.takeNextTest;
            uc_MemberInfoWithFilter1.LoadMemberInfo(memberId);
            uc_InstructorInfoWithFilter1.LoadInstructorData(instructorId);

        }

        public frmAddBeltTest(int oldTestId)
        {
            InitializeComponent();
            _creationMode = CreationMode.retake;
            _oldTestId = oldTestId;
        }
        private void _LoadDataToFormInModeRetakeTest()
        {
            BeltTest oldBeltTest = BeltTest.Find(_oldTestId);
            if (oldBeltTest == null)
            {
                MessageBox.Show($"There is not blet test with this Id:{_beltTestId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            uc_MemberInfoWithFilter1.LoadMemberInfo(oldBeltTest.memberId);
            uc_MemberInfoWithFilter1.FilterEnabled = false;

            uc_InstructorInfoWithFilter1.LoadInstructorData(oldBeltTest.testedByInstructorID);
            uc_InstructorInfoWithFilter1.FilterEnabled = true;

            labBeltRankId.Text = oldBeltTest.rankId.ToString();
            labBeltRankName.Text = oldBeltTest.beltRankInfo.name;
            labFeesTest.Text = oldBeltTest.beltRankInfo.testFees.ToString();
            dtpAssignDate.Value = DateTime.Now;
            rdFail.Checked = true;

        }
        private void _ResetDefaultValue()
        {
            switch (_creationMode)
            {
                case CreationMode.firstTime:
                    this.Text = "Take Belt Test";
                    labTitle.Text = "Take Belt Test";
                    tpInstructor.Enabled = false;
                    _beltTest = new BeltTest();
                    return;
                case CreationMode.takeNextTest:
                    this.Text = "Take Next Belt Test";
                    labTitle.Text = "Take Next Belt Test";
                    tpInstructor.Enabled = false;
                    _beltTest = new BeltTest();

                    uc_InstructorInfoWithFilter1.FilterEnabled = true;
                    uc_MemberInfoWithFilter1.FilterEnabled = false;
                    return;

                case CreationMode.retake:
                    labTitle.Text = "Retake Test";
                    _LoadDataToFormInModeRetakeTest();
                    return;

            }
        }

        private void frmAddUpdateBeltTest_Load(object sender, System.EventArgs e)
        {
            _ResetDefaultValue();
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {

            if (uc_MemberInfoWithFilter1.MemberId == -1)
            {
                MessageBox.Show($"Choose a member firstly...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uc_MemberInfoWithFilter1.FilterFocus();
                return;
            }
            tpInstructor.Enabled = true;
            tcMemberInstructor.SelectedTab = tcMemberInstructor.TabPages["tpInstructor"];

        }

        private void _FillBeltTestToSave()
        {
            _beltTest.memberId = uc_MemberInfoWithFilter1.MemberId;
            _beltTest.testedByInstructorID = uc_InstructorInfoWithFilter1.InstructorId;
            _beltTest.date = dtpAssignDate.Value;
            _beltTest.result = rdPass.Checked;
            _beltTest.rankId = Convert.ToInt16(labBeltRankId.Text);
        }
        private int _AddingNewPayment()
        {
            Payment payment = new Payment();
            payment.amount = Convert.ToDecimal(labFeesTest.Text);
            payment.date = dtpAssignDate.Value;
            payment.memberId = _memberSelectedId;
            payment.Save();
            return payment.id;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Field are not valid ,Put the mouse over the red icon!!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int newPaymentId = _AddingNewPayment();
            if (newPaymentId == -1)
            {
                MessageBox.Show("Payment Failed Created.. ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            labPaymentId.Text = newPaymentId.ToString();
            _beltTest.paymentId = newPaymentId;

            _FillBeltTestToSave();  //mode update
            if (_beltTest.Save())
            {
                LabTestId.Text = _beltTest.id.ToString();
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                if (_beltTest.result)
                {
                    uc_MemberInfoWithFilter1.MemberSelected.lastBeltRankId = _beltTest.rankId;
                    if (!uc_MemberInfoWithFilter1.MemberSelected.Save())
                    {
                        MessageBox.Show("There is a problem,member don't update.. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Data Failed Saved ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uc_MemberInfoWithFilter1_OneMemberSelected(int obj)
        {
            _memberSelectedId = obj;
            labBeltRankId.Text = (uc_MemberInfoWithFilter1.MemberSelected.lastBeltRankId + 1).ToString();
            labBeltRankName.Text = BeltRank.GetNameById(Convert.ToInt32(labBeltRankId.Text));
            labFeesTest.Text = BeltRank.GetFeesById(Convert.ToInt32(labBeltRankId.Text)).ToString();
            dtpAssignDate.Value = DateTime.Now;
            rdFail.Checked = true;

        }
    }
}
