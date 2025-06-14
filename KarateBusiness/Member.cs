using KarateDataAccess;
using System.Data;

namespace KarateBusiness
{
    public class Member
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        public int id { get; set; }
        public int personId { get; set; }
        public string emergencyContactInfo { get; set; }
        public int lastBeltRank { get; set; }
        public bool isActive { get; set; }
        public Person personInfo { get; private set; }
        public Member()
        {
            this.id = 0;
            this.personId = -1;
            this.emergencyContactInfo = string.Empty;
            this.lastBeltRank = 0;
            this.isActive = false;
            this.personInfo = new Person();
            _mode = Mode.Add;
        }
        private Member(int id, int personId, string emergencyContactInfo, int lastBeltRank, bool isActive)
        {
            this.id = id;
            this.personId = personId;
            this.emergencyContactInfo = emergencyContactInfo;
            this.lastBeltRank = lastBeltRank;
            this.isActive = isActive;
            this.personInfo = Person.Find(personId);

            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.id = MemberData.Add(this.personId, this.emergencyContactInfo, this.lastBeltRank, this.isActive);

            return (this.id != -1);
        }

        private bool _Update()
        {
            return MemberData.Update(this.id, this.personId, this.emergencyContactInfo, this.lastBeltRank, this.isActive);
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
            return MemberData.Exist(id);
        }
        public static bool ExistByPersonId(int personId)
        {
            return MemberData.ExistByPersonId(personId);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            else { return MemberData.Delete(id); }
        }
        public static DataTable All()
        {
            return MemberData.All();
        }
        public static Member Find(int id)
        {
            int personId = -1;
            string emergencyContactInfo = string.Empty;
            int lastBeltRank = 0;
            bool isActive = false;

            if (MemberData.Get(id, ref personId, ref emergencyContactInfo, ref lastBeltRank, ref isActive))
            {
                return new Member(id, personId, emergencyContactInfo, lastBeltRank, isActive);
            }
            return null;
        }




    }


}
