using KarateBusiness;
using System;
using System.Windows.Forms;

namespace KarateSystem.Subscription_Periods.uc
{
    public partial class uc_SubscriptionPeriodWithFilter : UserControl
    {
        private int _periodId = -1;
        public int PeriodId
        {
            get { return _periodId; }
            set { _periodId = value; }
        }

        private bool _filterEnabled = false;

        private SubscriptionPeriod _subscriptionPeriod;
        public SubscriptionPeriod SubscriptionPeriod
        {
            get { return uc_SubscriptionPeriodInfoCard1.SubscriptionPeriod; }
        }
        public bool FilterEnabled
        {
            get { return _filterEnabled; }
            set { gbFilter.Enabled = value; }
        }
        public uc_SubscriptionPeriodWithFilter()
        {
            InitializeComponent();
        }

        private void uc_SubscriptionPeriodWithFilter_Load(object sender, EventArgs e)
        {

        }

        private void FilterFocus()
        {
            txtFilterValue.Focus();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void _ShowDataPeriodToForm()
        {
            _periodId = Convert.ToInt32(txtFilterValue.Text);
            uc_SubscriptionPeriodInfoCard1.LoadPeriodInfo(_periodId);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {

            _subscriptionPeriod = SubscriptionPeriod.Find(Convert.ToInt32(txtFilterValue.Text));
            if (_subscriptionPeriod == null)
            {
                MessageBox.Show($"There is not period with this Id:{Convert.ToInt32(txtFilterValue.Text)}...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FilterFocus();
                return;
            }

            _ShowDataPeriodToForm();
        }
        public void LoadPeriodData(int periodId)
        {
            txtFilterValue.Text = periodId.ToString();
            _ShowDataPeriodToForm();
            FilterEnabled = false;

        }
    }
}
