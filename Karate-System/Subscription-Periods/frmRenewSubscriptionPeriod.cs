using KarateBusiness;
using System;
using System.Windows.Forms;

namespace KarateSystem.Subscription_Periods
{
    public partial class frmRenewSubscriptionPeriod : Form
    {

        private int _periodId = -1;
        private int _OldPeriodId = -1;
        private SubscriptionPeriod _subscriptionPeriod;

        public frmRenewSubscriptionPeriod()
        {
            InitializeComponent();
            uc_SubscriptionPeriodWithFilter1.FilterEnabled = true;
        }
        public frmRenewSubscriptionPeriod(int oldPeriodId)
        {
            InitializeComponent();
            uc_SubscriptionPeriodWithFilter1.FilterEnabled = true;
            _OldPeriodId = oldPeriodId;
        }
        private void uc_SubscriptionPeriodWithFilter1_OnePeriodSelected(int obj)
        {
            int periodId = obj;
            if (uc_SubscriptionPeriodWithFilter1.SubscriptionPeriod.isActivePeriod)
            {
                MessageBox.Show("You can't renew this period because is still active..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uc_SubscriptionPeriodWithFilter1.FilterFocus();
                btnRenew.Enabled = false;
                btnSave.Enabled = false;
            }
            dtpStartDate.MinDate = uc_SubscriptionPeriodWithFilter1.SubscriptionPeriod.endDate;
            dtpStartDate.Value = uc_SubscriptionPeriodWithFilter1.SubscriptionPeriod.endDate;

            dtpEndDate.MinDate = dtpStartDate.Value.AddMonths(1);
            dtpEndDate.Value = dtpStartDate.Value.AddMonths(1);

            labMemberId.Text = uc_SubscriptionPeriodWithFilter1.SubscriptionPeriod.memberId.ToString();
        }
        private void _ResetDefaultValue()
        {



        }
        private void frmRenewSubscriptionPeriod_Load(object sender, System.EventArgs e)
        {
            _ResetDefaultValue();
        }
        private void _FillPeriodObjectBeforeSave()
        {
            _subscriptionPeriod.fees = Convert.ToDecimal(txtFees.Text);
            _subscriptionPeriod.startDate = dtpStartDate.Value;
            _subscriptionPeriod.endDate = dtpEndDate.Value;
            _subscriptionPeriod.memberId = labMemberId.Text;


        }
        private void btnRenew_Click(object sender, System.EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Field are not valid ,Put the mouse over the red icon!!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPeriodObjectBeforeSave();




        }

        private void txtFees_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "This field is required...");
            }
        }
    }
}
