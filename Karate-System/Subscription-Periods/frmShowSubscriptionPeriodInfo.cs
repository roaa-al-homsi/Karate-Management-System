using System.Windows.Forms;

namespace KarateSystem.Subscription_Periods
{
    public partial class frmShowSubscriptionPeriodInfo : Form
    {
        public frmShowSubscriptionPeriodInfo(int periodId)
        {
            InitializeComponent();
            uc_SubscriptionPeriodInfoCard1.LoadPeriodInfo(periodId);
        }


    }
}
