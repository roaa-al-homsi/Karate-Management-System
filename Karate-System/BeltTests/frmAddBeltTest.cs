using KarateBusiness;
using System;
using System.Windows.Forms;

namespace KarateSystem.BeltTests
{
    public partial class frmAddBeltTest : Form
    {

        private int _beltTestId;
        private BeltTest _beltTest;

        private int _memberSelectedId = -1;

        public frmAddBeltTest()
        {
            InitializeComponent();

        }
        private void _ResetDefaultValue()
        {
            this.Text = "Add New Belt Test";
            labTitle.Text = "Add New Belt Test";
            uc_MemberInfoWithFilter1.FilterEnabled = true;
            uc_InstructorInfoWithFilter1.FilterEnabled = true;
            tpInstructor.Enabled = false;
            _beltTest = new BeltTest();
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
