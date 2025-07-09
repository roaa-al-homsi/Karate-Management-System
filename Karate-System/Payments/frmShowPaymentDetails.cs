using System.Windows.Forms;

namespace KarateSystem.Payments
{
    public partial class frmShowPaymentDetails : Form
    {
        public frmShowPaymentDetails(int paymentId)
        {
            InitializeComponent();
            uc_PaymentInfoCard1.LoadPaymentInfo(paymentId);
        }
    }
}
