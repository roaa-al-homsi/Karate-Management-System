using KarateDataAccess;
using System.Data;

namespace KarateBusiness
{
    public class Instructor
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        public int id { get; set; }
        public int personId { get; set; }
        public string qualifications { get; set; }
        public Person personInfo { get; private set; }
        public Instructor()
        {
            this.id = 0;
            this.personId = -1;
            this.qualifications = string.Empty;
            this.personInfo = new Person();
            _mode = Mode.Add;
        }
        private Instructor(int id, int personId, string qualifications)
        {
            this.id = id;
            this.personId = personId;
            this.qualifications = qualifications;
            this.personInfo = Person.Find(personId);

            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.id = InstructorData.Add(this.personId, this.qualifications);

            return (this.id != -1);
        }

        private bool _Update()
        {
            return InstructorData.Update(this.id, this.personId, this.qualifications);
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
            return InstructorData.Exist(id);
        }

        public static bool ExistByPersonId(int personId)
        {
            return InstructorData.ExistByPersonId(personId);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            else { return InstructorData.Delete(id); }
        }
        public static DataTable All()
        {
            return InstructorData.All();
        }
        public static Instructor Find(int id)
        {
            int personId = -1;
            string qualifications = string.Empty;

            if (InstructorData.Get(id, ref personId, ref qualifications))
            {
                return new Instructor(id, personId, qualifications);
            }
            return null;
        }
        public static int GetInstructorsCount()
        {
            return InstructorData.GetInstructorsCount();
        }
    }


}
