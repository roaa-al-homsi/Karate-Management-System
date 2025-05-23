using System.Windows.Forms;

namespace KarateSystem.People
{
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(int personId)
        {
            InitializeComponent();
            uc_PersonInfoCard1.LoadPersonInfo(personId);
        }
        public frmShowPersonInfo(string nationalNum)
        {
            InitializeComponent();
            uc_PersonInfoCard1.LoadPersonInfo(nationalNum);
        }
    }
}
