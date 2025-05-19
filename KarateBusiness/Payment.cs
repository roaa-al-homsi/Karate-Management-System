using KarateDataAccess;
using System;
using System.Data;

namespace KarateBusiness
{
    public class Payment
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        public int id { get; set; }
        public decimal amount { get; set; }
        public DateTime date { get; set; }
        public int memberId { get; set; }

        public Payment()
        {
            this.id = 0;
            this.amount = 0;
            this.date = DateTime.MinValue;
            this.memberId = -1;

            _mode = Mode.Add;
        }
        private Payment(int id, decimal amount, DateTime date, int memberId)
        {
            this.id = id;
            this.amount = amount;
            this.date = date;
            this.memberId = memberId;


            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.id = PaymentData.Add(this.amount, this.date, this.memberId);

            return (this.id != -1);
        }

        private bool _Update()
        {
            return PaymentData.Update(this.id, this.amount, this.date, this.memberId);
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

            if (PaymentData.Get(id, ref amount, ref date, ref memberId))
            {
                return new Payment(id, amount, date, memberId);
            }
            return null;
        }
    }


}
