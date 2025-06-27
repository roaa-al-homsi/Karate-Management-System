using KarateBusiness;
using System.Windows.Forms;

namespace KarateSystem.BeltTests.uc
{
    public partial class uc_BeltTestDetailsCard : UserControl
    {
        private int _beltTestId = -1;
        public int BeltTestId
        {
            get { return _beltTestId; }
            set { _beltTestId = value; }
        }

        private BeltTest _beltTest;
        public BeltTest BeltTest
        {
            get { return _beltTest; }
        }
        public uc_BeltTestDetailsCard()
        {
            InitializeComponent();
        }

        private void _LoadDataBeltTestToForm()
        {
            LabTestId.Text = _beltTestId.ToString();
            labBeltRankId.Text = _beltTest.rankId.ToString();
            labBeltRankName.Text = _beltTest.beltRankInfo.name;
            labFeesTest.Text = _beltTest.beltRankInfo.testFees.ToString();
            labPaymentId.Text = _beltTest.paymentId.ToString();
            labResult.Text = _beltTest.result ? "Pass" : "Fail";
            dtpAssignDate.Value = _beltTest.date;
            labMemberName.Text = _beltTest.memberInfo.personInfo.FullName;
            labInstructorName.Text = _beltTest.instructorInfo.personInfo.FullName;
        }
        public void LoadBeltTestData(int beltTestId)
        {
            _beltTest = BeltTest.Find(BeltTestId);
            if (_beltTest == null)
            {
                MessageBox.Show($"There is not belt test with this Id:{beltTestId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _beltTestId = beltTestId;
            _LoadDataBeltTestToForm();
        }
    }
}
