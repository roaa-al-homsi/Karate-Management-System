using System.Windows.Forms;

namespace KarateSystem.BeltTests
{
    public partial class frmShowTestDetails : Form
    {
        public frmShowTestDetails(int testId)
        {
            InitializeComponent();
            uc_BeltTestDetailsCard1.LoadBeltTestData(testId);
        }
    }
}
