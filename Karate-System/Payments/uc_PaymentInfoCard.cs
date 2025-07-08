using KarateBusiness;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KarateSystem.Payments
{
    public partial class uc_PaymentInfoCard : UserControl
    {
        private int _paymentId = -1;
        private Payment _payment;
        public uc_PaymentInfoCard()
        {
            InitializeComponent();

        }

        public void LoadPaymentInfo(int paymentId)
        {
            _payment = Payment.Find(paymentId);
            if (_payment == null)
            {
                return;
            }
            labFees.Text = _payment.amount.ToString();
            labGender.Text = _payment.memberInfo.personInfo.gender == Person.enGender.Female ? "Female" : "Male";
            labMemberId.Text = _payment.memberId.ToString();
            labNameMember.Text = _payment.memberInfo.personInfo.FullName;
            labPaymentId.Text = _payment.id.ToString();
            dtpDate.Value = _payment.date;

            if (string.IsNullOrWhiteSpace(_payment.memberInfo.personInfo.imagePath))
            {
                if (_payment.memberInfo.personInfo.gender == 0)
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
                picMember.ImageLocation = _payment.memberInfo.personInfo.imagePath;
            }

        }






    }
}
