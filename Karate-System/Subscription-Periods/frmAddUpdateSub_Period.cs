using KarateBusiness;
using System;
using System.Windows.Forms;

namespace KarateSystem.Subscription_Periods
{
    public partial class frmAddUpdateSub_Period : Form
    {
        private enum mode { add = 0, update = 1 }
        private mode _mode;
        private int _subPeriodId;
        private SubscriptionPeriod _subscriptionPeriod;
        private Payment _payment;
        public frmAddUpdateSub_Period()
        {
            InitializeComponent();
            _mode = mode.add;
        }
        public frmAddUpdateSub_Period(int subPeriodId)
        {
            InitializeComponent();
            _subPeriodId = subPeriodId;
            _mode = mode.update;
        }
        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFees_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "This Field Is Required!!");
            }
        }

        private void _LoadPeriodDataToForm()
        {
            _subscriptionPeriod = SubscriptionPeriod.Find(_subPeriodId);

            if (_subscriptionPeriod == null)
            {
                return;
            }
            uc_MemberInfoWithFilter1.LoadMemberInfo(_subscriptionPeriod.memberId);
            txtFees.Text = _subscriptionPeriod.fees.ToString();
            dtpStartDate.Value = _subscriptionPeriod.startDate;
            dtpEndDate.Value = _subscriptionPeriod.endDate;
            labPaymentId.Text = _subscriptionPeriod.paymentId.ToString();
            labMemberId.Text = _subscriptionPeriod.memberId.ToString();
            LabPeriodId.Text = _subscriptionPeriod.id.ToString();

            _payment = Payment.Find(Convert.ToInt16(labPaymentId.Text));
        }
        private void _ResetDefaultValueToForm()
        {
            if (_mode == mode.add)
            {
                this.Text = "Add New Subscription Period";
                labTitleForm.Text = "Add New Subscription Period";
                dtpStartDate.MinDate = DateTime.Today;
                dtpEndDate.MinDate = (dtpStartDate.MinDate).AddMonths(1);
                uc_MemberInfoWithFilter1.FilterEnabled = true;
                _subscriptionPeriod = new SubscriptionPeriod();
                _payment = new Payment();
                return;
            }


            this.Text = "Update Subscription Period";
            labTitleForm.Text = "Update Subscription Period";
            _LoadPeriodDataToForm();
        }
        private void frmAddUpdateSub_Period_Load(object sender, System.EventArgs e)
        {
            _ResetDefaultValueToForm();

        }
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = (dtpStartDate.Value).AddMonths(1);
        }
        private void _AddPaymentForSubscriptionPeriod()
        {
            _payment.amount = _subscriptionPeriod.fees;
            _payment.date = DateTime.Now;
            _payment.memberId = _subscriptionPeriod.memberId;

        }
        private void _FillPeriodDataToSave()
        {
            _subscriptionPeriod.memberId = uc_MemberInfoWithFilter1.MemberId;
            _subscriptionPeriod.startDate = dtpStartDate.Value;
            _subscriptionPeriod.endDate = dtpEndDate.Value;
            _subscriptionPeriod.fees = Convert.ToDecimal(txtFees.Text);
            _subscriptionPeriod.paymentId = Convert.ToInt16(_payment.id);



        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Field are not valid ,Put the mouse over the red icon!!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (uc_MemberInfoWithFilter1.MemberId == -1)
            {
                MessageBox.Show("You can't add a subscription period without choose a member first!!.., Please choose a member.");
                uc_MemberInfoWithFilter1.FilterFocus();
                return;
            }
            //if (_mode == mode.add)
            //{
            //    if (!_AddPaymentForSubscriptionPeriod())
            //    {
            //        MessageBox.Show("There is a problem in make a payment..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    labPaymentId.Text = _payment.id.ToString();
            //}
            _AddPaymentForSubscriptionPeriod();
            if (_payment.Save())
            {
                labMemberId.Text = uc_MemberInfoWithFilter1.MemberId.ToString();
                labPaymentId.Text = _payment.id.ToString();
                _FillPeriodDataToSave();
                if (_subscriptionPeriod.Save())
                {
                    LabPeriodId.Text = _subscriptionPeriod.id.ToString();
                    this.Text = "Update Subscription Period";
                    labTitleForm.Text = "Update Subscription Period";
                    _mode = mode.update;
                    MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Data Failed Saved ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There is a problem in make a payment..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
