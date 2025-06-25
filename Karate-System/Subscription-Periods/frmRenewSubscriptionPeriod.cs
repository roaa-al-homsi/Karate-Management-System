using System.Windows.Forms;

namespace KarateSystem.Subscription_Periods
{
    public partial class frmRenewSubscriptionPeriod : Form
    {
        private int _periodId = -1;
        public frmRenewSubscriptionPeriod()

        {
            InitializeComponent();
            uc_SubscriptionPeriodWithFilter1.FilterEnabled = true;


        }
        private void uc_SubscriptionPeriodWithFilter1_OnePeriodSelected(int obj)
        {
            int periodId = obj;
            if (uc_SubscriptionPeriodWithFilter1.SubscriptionPeriod.isActivePeriod)
            {
                MessageBox.Show("You can't renew this period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uc_SubscriptionPeriodWithFilter1.FilterFocus();
            }
        }
    }
}
