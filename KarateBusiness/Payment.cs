using KarateDataAccess;
using System;
using System.Data;

namespace KarateBusiness
{
    public class Payment
    {
        public enum enPaymentReason { BeltTest = 1, SubscriptionPeriod = 2 }
        private enum Mode { Add, Update }
        private Mode _mode;

        public int id { get; set; }
        public decimal amount { get; set; }
        public DateTime date { get; set; }
        public int memberId { get; set; }
        public enPaymentReason PaymentReason { get; set; }
        public Member memberInfo { get; private set; }

        public string PaymentReasonText
        {
            get
            {
                switch (PaymentReason)
                {
                    case enPaymentReason.BeltTest:
                        return "Belt Test";
                    case enPaymentReason.SubscriptionPeriod:
                        return "Subscription Period";
                    default: return "Subscription Period";
                }
            }
        }

        public Payment()
        {
            this.id = 0;
            this.amount = 0;
            this.date = DateTime.MinValue;
            this.memberId = -1;
            this.PaymentReason = enPaymentReason.SubscriptionPeriod;

            _mode = Mode.Add;
        }
        private Payment(int id, decimal amount, DateTime date, int memberId, enPaymentReason paymentReason)
        {
            this.id = id;
            this.amount = amount;
            this.date = date;
            this.memberId = memberId;
            this.PaymentReason = paymentReason;

            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.id = PaymentData.Add(this.amount, this.date, this.memberId, (byte)this.PaymentReason);

            return (this.id != -1);
        }

        private bool _Update()
        {
            return PaymentData.Update(this.id, this.amount, this.date, this.memberId, (byte)this.PaymentReason);
        }
        public bool Save()
        {

            switch (_mode)
            {
                case Mode.Add:
                    {
                        if (_Add())
                        {
                            _mode = Mode.Update;
                            return true;
                        }
                        return false;
                    }
                case Mode.Update: return _Update();
            }
            return false;
        }
        public static bool Exist(int id)
        {
            return PaymentData.Exist(id);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            else { return PaymentData.Delete(id); }
        }
        public static DataTable All()
        {
            return PaymentData.All();
        }
        public static Payment Find(int id)
        {
            decimal amount = 0;
            DateTime date = DateTime.MinValue;
            int memberId = -1;
            byte paymentReason = (byte)enPaymentReason.SubscriptionPeriod;

            if (PaymentData.Get(id, ref amount, ref date, ref memberId, ref paymentReason))
            {
                return new Payment(id, amount, date, memberId, (enPaymentReason)paymentReason);
            }
            return null;
        }
    }


}
