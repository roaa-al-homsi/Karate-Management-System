using KarateDataAccess;
using System;
using System.Data;
namespace KarateBusiness
{
    public class BeltTest
    {

        private enum Mode { Add, Update }
        private Mode _mode;
        public int id { get; set; }
        public int rankId { get; set; }
        public int memberId { get; set; }
        public bool result { get; set; }
        public DateTime date { get; set; }
        public int testedByInstructorID { get; set; }
        public int paymentId { get; set; }

        public BeltRank beltRankInfo { get; private set; }
        public Member memberInfo { get; private set; }
        public Instructor instructorInfo { get; private set; }
        public Payment paymentInfo { get; private set; }

        public BeltTest()
        {
            this.id = 0;
            this.rankId = -1;
            this.memberId = -1;
            this.result = false;
            this.date = DateTime.MinValue;
            this.testedByInstructorID = 0;
            this.paymentId = -1;

            this.beltRankInfo = new BeltRank();//
            this.memberInfo = new Member();
            this.instructorInfo = new Instructor();
            this.paymentInfo = new Payment();


            _mode = Mode.Add;
        }
        private BeltTest(int id, int rankId, int memberId, bool result, DateTime date, int testedByInstructorID, int paymentId)
        {
            this.id = id;
            this.rankId = rankId;
            this.memberId = memberId;
            this.result = result;
            this.date = date;
            this.testedByInstructorID = testedByInstructorID;
            this.paymentId = paymentId;

            this.beltRankInfo = BeltRank.Find(rankId);
            this.memberInfo = Member.Find(memberId);
            this.instructorInfo = Instructor.Find(testedByInstructorID);
            this.paymentInfo = Payment.Find(paymentId);


            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.id =
                        BeltTestData.Add(this.rankId, this.memberId, this.result, this.date, this.testedByInstructorID, this.paymentId);
            return (this.id != -1);
        }

        private bool _Update()
        {
            return BeltTestData.Update(this.id, this.rankId, this.memberId, this.result, this.date, this.testedByInstructorID, this.paymentId);
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
            return BeltTestData.Exist(id);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            else { return BeltTestData.Delete(id); }
        }
        public static DataTable All()
        {
            return BeltTestData.All();
        }
        public static BeltTest Find(int id)
        {
            int rankId = -1;
            int memberId = -1;
            bool result = false;
            DateTime date = DateTime.MinValue;
            int testedByInstructorID = -1;
            int paymentId = -1;

            if (BeltTestData.Get(id, ref rankId, ref memberId, ref result, ref date, ref testedByInstructorID, ref paymentId))
            {
                return new BeltTest(id, rankId, memberId, result, date, testedByInstructorID, paymentId);
            }
            return null;
        }

        public static int GetBeltTestCount()
        {
            return BeltTestData.GetBeltTestsCount();
        }

    }

}




