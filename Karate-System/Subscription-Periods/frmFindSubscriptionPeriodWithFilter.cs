using System.Windows.Forms;

namespace KarateSystem.Subscription_Periods
{
    public partial class frmFindSubscriptionPeriodWithFilter : Form
    {
        public frmFindSubscriptionPeriodWithFilter()
        {
            InitializeComponent();
            uc_SubscriptionPeriodWithFilter1.FilterEnabled = true;
        }
        public frmFindSubscriptionPeriodWithFilter(int periodId)
        {
            InitializeComponent();
            uc_SubscriptionPeriodWithFilter1.LoadPeriodData(periodId);
        }



    }
}
