using KarateDataAccess;
using System;
using System.Data;

namespace KarateBusiness
{
    public class SubscriptionPeriod
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        public enum IssueReason { FirstTime = 1, Renew = 2 }
        public int id { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public decimal fees { get; set; }
        public int memberId { get; set; }
        public int paymentId { get; set; }
        public IssueReason issueReason { get; set; }

        public string textIssueReason
        {
            get
            {
                switch (issueReason)
                {
                    case IssueReason.FirstTime:
                        return "First Time";
                    case IssueReason.Renew:
                        return "Renew";
                    default: return "FirstTime";
                }
            }
        }
        public Member memberInfo { get; set; }
        public Payment paymentInfo { get; set; }
        public SubscriptionPeriod()
        {
            this.id = 0;
            this.startDate = DateTime.MinValue;
            this.endDate = DateTime.MinValue;
            this.fees = 0;
            this.memberId = -1;
            this.paymentId = -1;
            this.issueReason = IssueReason.FirstTime;
            this.memberInfo = new Member();
            this.paymentInfo = new Payment();

            _mode = Mode.Add;
        }
        private SubscriptionPeriod(int id, DateTime startDate, DateTime endDate, decimal fees, int memberId, int paymentId, IssueReason issueReason)
        {
            this.id = id;
            this.startDate = startDate;
            this.endDate = endDate;
            this.fees = fees;
            this.memberId = memberId;
            this.paymentId = paymentId;
            this.issueReason = issueReason;
            this.memberInfo = Member.Find(memberId);
            this.paymentInfo = Payment.Find(paymentId);

            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.id = SubscriptionPeriodData.Add(this.startDate, this.endDate, this.fees, this.memberId, this.paymentId, (byte)this.issueReason);
            return (this.id != -1);
        }

        private bool _Update()
        {
            return SubscriptionPeriodData.Update(this.id, this.startDate, this.endDate, this.fees, this.memberId, this.paymentId, (byte)this.issueReason);
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
            return SubscriptionPeriodData.Exist(id);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            else { return SubscriptionPeriodData.Delete(id); }
        }
        public static DataTable All()
        {
            return SubscriptionPeriodData.All();
        }
        public static SubscriptionPeriod Find(int id)
        {
            DateTime startDate = DateTime.MinValue;
            DateTime endDate = DateTime.MinValue;
            decimal fees = 0;
            int memberId = -1;
            int paymentId = -1;
            byte issueReason = 1;

            if (SubscriptionPeriodData.Get(id, ref startDate, ref endDate, ref fees, ref memberId, ref paymentId, ref issueReason))
            {
                return new SubscriptionPeriod(id, startDate, endDate, fees, memberId, paymentId, (IssueReason)issueReason);
            }
            return null;
        }
    }


}
