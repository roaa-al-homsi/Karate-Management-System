using KarateBusiness;
using System.Windows.Forms;

namespace KarateSystem.BeltTests
{
    public partial class frmAddUpdateBeltTest : Form
    {
        private enum mode { add = 1, update = 2 }
        private mode _mode;

        private int _beltTestId;
        private BeltTest _beltTest;

        public frmAddUpdateBeltTest()
        {
            InitializeComponent();
            _mode = mode.add;

        }
        public frmAddUpdateBeltTest(int beltTestId)
        {
            InitializeComponent();
            _beltTestId = beltTestId;
            _mode = mode.update;
        }
        private void _LoadBeltTestDataToForm()
        {
            _beltTest = BeltTest.Find(_beltTestId);
            if (_beltTest == null)
            {
                MessageBox.Show($"There is not belt test with this Id:{_beltTestId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            uc_MemberInfoWithFilter1.FilterEnabled = false;
            uc_InstructorInfoWithFilter1.FilterEnabled = false;
            uc_MemberInfoWithFilter1.LoadMemberInfo(_beltTest.memberId);
            uc_InstructorInfoWithFilter1.LoadInstructorData(_beltTest.testedByInstructorID);

            labBeltRankId.Text = _beltTest.rankId.ToString();
            labBeltRankName.Text = _beltTest.beltRankInfo.name;
            labFeesTest.Text = _beltTest.beltRankInfo.testFees.ToString();
            labPaymentId.Text = _beltTest.paymentId.ToString();
            LabTestId.Text = _beltTest.id.ToString();
            dtpAssignDate.Value = _beltTest.date;
            if (_beltTest.result)
            {
                rdPass.Checked = true;
            }
            else
            {
                rdFail.Checked = true;
            }
        }
        private void _ResetDefaultValue()
        {
            if (_mode == mode.add)
            {
                this.Text = "Add New Belt Test";
                labTitle.Text = "Add New Belt Test";
                _beltTest = new BeltTest();
                return;
            }
            this.Text = "Update Belt Test";
            labTitle.Text = "Update Belt Test";
            _LoadBeltTestDataToForm();
        }

        private void frmAddUpdateBeltTest_Load(object sender, System.EventArgs e)
        {
            _ResetDefaultValue();
        }
    }
}
