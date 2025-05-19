using KarateDataAccess;
using System;
using System.Data;

namespace KarateBusiness
{
    public class SubscriptionPeriod
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        public int id { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public decimal fees { get; set; }
        public int memberId { get; set; }
        public int paymentId { get; set; }

        public SubscriptionPeriod()
        {
            this.id = 0;
            this.startDate = DateTime.MinValue;
            this.endDate = DateTime.MinValue;
            this.fees = 0;
            this.memberId = -1;
            this.paymentId = -1;

            _mode = Mode.Add;
        }
        private SubscriptionPeriod(int id, DateTime startDate, DateTime endDate, decimal fees, int memberId, int paymentId)
        {
            this.id = id;
            this.startDate = startDate;
            this.endDate = endDate;
            this.fees = fees;
            this.memberId = memberId;
            this.paymentId = paymentId;


            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.id = SubscriptionPeriodData.Add(this.startDate, this.endDate, this.fees, this.memberId, this.paymentId);
            return (this.id != -1);
        }

        private bool _Update()
        {
            return SubscriptionPeriodData.Update(this.id, this.startDate, this.endDate, this.fees, this.memberId, this.paymentId);
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

            if (SubscriptionPeriodData.Get(id, ref startDate, ref endDate, ref fees, ref memberId, ref paymentId))
            {
                return new SubscriptionPeriod(id, startDate, endDate, fees, memberId, paymentId);
            }
            return null;
        }
    }


}
