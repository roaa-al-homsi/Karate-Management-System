using KarateBusiness;
using KarateSystem.Members;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KarateSystem.Subscription_Periods.uc
{
    public partial class uc_SubscriptionPeriodInfoCard : UserControl
    {
        private int _periodId;
        public int PeriodId
        {
            get { return _periodId; }
            set { _periodId = value; }
        }
        private SubscriptionPeriod _subscriptionPeriod;
        public SubscriptionPeriod SubscriptionPeriod
        {
            get { return _subscriptionPeriod; }
            set { _subscriptionPeriod = value; }
        }

        public uc_SubscriptionPeriodInfoCard()
        {
            InitializeComponent();
        }
        private void _LoadPeriodDataToForm()
        {
            LabPeriodId.Text = _subscriptionPeriod.id.ToString();
            labMemberId.Text = _subscriptionPeriod.memberId.ToString();
            labPaymentId.Text = _subscriptionPeriod.paymentId.ToString();
            labNameMember.Text = _subscriptionPeriod.memberInfo.personInfo.FullName;
            labLastBeltRank.Text = _subscriptionPeriod.memberInfo.beltRankInfo.name;
            labGender.Text = _subscriptionPeriod.memberInfo.personInfo.GenderText;
            labIssueReason.Text = _subscriptionPeriod.textIssueReason;
            labFees.Text = _subscriptionPeriod.fees.ToString();
            labIsActive.Text = _subscriptionPeriod.isActivePeriod ? "Yes" : "No";
            dtpStartDate.Value = _subscriptionPeriod.startDate;
            dtpEndDate.Value = _subscriptionPeriod.endDate;
            //   labPaymentReason.text =


            if (string.IsNullOrWhiteSpace(_subscriptionPeriod.memberInfo.personInfo.imagePath))
            {
                if (_subscriptionPeriod.memberInfo.personInfo.gender == 0)
                {
                    using (MemoryStream ms = new MemoryStream(Properties.Resources.Male_512))
                    {
                        picMember.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream(Properties.Resources.Female_512))
                    {
                        picMember.Image = Image.FromStream(ms);
                    }
                }
            }
            else
            {
                picMember.ImageLocation = _subscriptionPeriod.memberInfo.personInfo.imagePath;
            }

        }
        public void LoadPeriodInfo(int periodId)
        {
            _subscriptionPeriod = SubscriptionPeriod.Find(periodId);
            if (_subscriptionPeriod == null)
            {
                MessageBox.Show($"There is not a subscription period with this Id:{periodId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadPeriodDataToForm();
        }

        private void linkLabMemberInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowMemberDetails frmShowMemberDetails = new frmShowMemberDetails(_subscriptionPeriod.memberId);
            frmShowMemberDetails.ShowDialog();
        }
    }
}
