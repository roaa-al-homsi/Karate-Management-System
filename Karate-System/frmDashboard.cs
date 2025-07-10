using KarateBusiness;
using System;
using System.Windows.Forms;
namespace KarateSystem
{
    public partial class frmDashboard : Form
    {
        private frmMain _frmMain;
        public frmDashboard(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            labBeltTest.Text = BeltTest.GetBeltTestCount().ToString();
            labInstructors.Text = Instructor.GetInstructorsCount().ToString();
            labPayments.Text = Payment.GetPaymentCount().ToString();
            labSubscriptions.Text = SubscriptionPeriod.GetSubscriptionPeriodsCount().ToString();
            labUsers.Text = User.GetUsersCount().ToString();
            labMembers.Text = Member.GetMembersCount().ToString();

        }
    }
}
