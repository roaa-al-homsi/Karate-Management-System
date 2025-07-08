using KarateBusiness;
using System;
using System.Windows.Forms;

namespace KarateSystem.Subscription_Periods
{
    public partial class frmRenewSubscriptionPeriod : Form
    {

        private int _periodId = -1;
        private int _OldPeriodId = -1;
        private SubscriptionPeriod _oldSubscriptionPeriod;
        private SubscriptionPeriod _NewSubscriptionPeriod;
        private Payment _newPayment = new Payment();

        public frmRenewSubscriptionPeriod()
        {
            InitializeComponent();
            uc_SubscriptionPeriodWithFilter1.FilterEnabled = true;
        }
        public frmRenewSubscriptionPeriod(int oldPeriodId)
        {
            InitializeComponent();
            uc_SubscriptionPeriodWithFilter1.FilterEnabled = false;
            _OldPeriodId = oldPeriodId;

            uc_SubscriptionPeriodWithFilter1.LoadPeriodData(oldPeriodId);
        }
        private void uc_SubscriptionPeriodWithFilter1_OnePeriodSelected(int obj)
        {
            int periodId = obj;
            if (uc_SubscriptionPeriodWithFilter1.SubscriptionPeriod.isActivePeriod)
            {
                MessageBox.Show("You can't renew this period because is still active..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uc_SubscriptionPeriodWithFilter1.FilterFocus();
                btnRenew.Enabled = false;
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
        private bool _AddPaymentForNewPeriod()
        {

            _newPayment.memberId = _oldSubscriptionPeriod.memberId;
            _newPayment.amount = _oldSubscriptionPeriod.fees;
            _newPayment.date = DateTime.Now;
            return (_newPayment.Save());

        }
        private void _FillPeriodObjectBeforeSave()
        {
            if (_OldPeriodId == -1)
            { _OldPeriodId = uc_SubscriptionPeriodWithFilter1.PeriodId; }

            _oldSubscriptionPeriod = SubscriptionPeriod.Find(_OldPeriodId);
            if (_oldSubscriptionPeriod == null)
            {
                MessageBox.Show($"There is not subscription period with this Id : {_OldPeriodId} ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _NewSubscriptionPeriod = new SubscriptionPeriod();
            _NewSubscriptionPeriod.fees = Convert.ToDecimal(txtFees.Text);
            _NewSubscriptionPeriod.startDate = dtpStartDate.Value;
            _NewSubscriptionPeriod.endDate = dtpEndDate.Value;
            _NewSubscriptionPeriod.memberId = Convert.ToInt16(labMemberId.Text);
            _NewSubscriptionPeriod.issueReason = SubscriptionPeriod.IssueReason.Renew;
            if (_AddPaymentForNewPeriod())
            {
                labPaymentId.Text = _newPayment.id.ToString();
                _NewSubscriptionPeriod.paymentId = _newPayment.id;
            }
            else
            {
                MessageBox.Show("There is problem in creating new payment, You can not renew period.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnRenew_Click(object sender, System.EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Field are not valid ,Put the mouse over the red icon!!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPeriodObjectBeforeSave();
            if (_NewSubscriptionPeriod.Save())
            {
                LabPeriodId.Text = _NewSubscriptionPeriod.id.ToString();
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Failed Saved ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFees_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "This field is required...");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
