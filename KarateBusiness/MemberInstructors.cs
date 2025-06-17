using KarateDataAccess;
using System;
using System.Data;

namespace KarateBusiness
{
    public class MemberInstructor
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        public int id { get; set; }
        public int memberId { get; set; }
        public int instructorId { get; set; }
        public DateTime assignDate { get; set; }
        public Member memberInfo { get; private set; }
        public Instructor instructorInfo { get; private set; }


        public MemberInstructor()
        {
            this.id = 0;
            this.memberId = -1;
            this.instructorId = -1;
            this.assignDate = DateTime.MinValue;
            this.memberInfo = new Member();
            this.instructorInfo = new Instructor();
            _mode = Mode.Add;
        }
        private MemberInstructor(int id, int memberId, int instructorId, DateTime assignDate)
        {
            this.id = id;
            this.memberId = memberId;
            this.instructorId = instructorId;
            this.assignDate = assignDate;
            this.memberInfo = Member.Find(memberId);
            this.instructorInfo = Instructor.Find(instructorId);

            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.id = MemberInstructorsData.Add(this.memberId, this.instructorId, this.assignDate);

            return (this.id != -1);
        }

        private bool _Update()
        {
            return MemberInstructorsData.Update(this.id, this.memberId, this.instructorId, this.assignDate);
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
            return MemberInstructorsData.Exist(id);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            else { return MemberInstructorsData.Delete(id); }
        }
        public static DataTable All()
        {
            return MemberInstructorsData.All();
        }
        public static MemberInstructor Find(int id)
        {
            int memberId = -1;
            int instructorId = -1;
            DateTime assignDate = DateTime.MinValue;

            if (MemberInstructorsData.Get(id, ref memberId, ref instructorId, ref assignDate))
            {
                return new MemberInstructor(id, memberId, instructorId, assignDate);
            }
            return null;
        }
    }


}
