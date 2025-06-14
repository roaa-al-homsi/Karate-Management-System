using System.Windows.Forms;

namespace KarateSystem.Members
{
    public partial class frmShowMemberDetails : Form
    {
        public frmShowMemberDetails(int memberId)
        {
            InitializeComponent();
            uc_MemberInfoCard1.LoadMemberInfo(memberId);
        }
    }
}
