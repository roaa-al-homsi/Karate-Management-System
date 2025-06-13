using KarateDataAccess;
using System.Data;

namespace KarateBusiness
{
    public class User
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        public int id { get; set; }
        public int personId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool isActive { get; set; }
        public Person personInfo { get; private set; }

        public User()
        {
            this.id = 0;
            this.personId = -1;
            this.username = string.Empty;
            this.password = string.Empty;
            this.isActive = false;
            this.personInfo = new Person();
            _mode = Mode.Add;
        }
        private User(int id, int personId, string username, string password, bool isActive)
        {
            this.id = id;
            this.personId = personId;
            this.username = username;
            this.password = password;
            this.isActive = isActive;
            this.personInfo = Person.Find(personId);

            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.id = UserData.Add(this.personId, this.username, this.password, this.isActive);
            return (this.id != -1);
        }

        private bool _Update()
        {
            return UserData.Update(this.id, this.personId, this.username, this.password, this.isActive);
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
            return UserData.Exist(id);
        }

        public static bool ExistByPersonId(int personId)
        {
            return UserData.ExistByPersonId(personId);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            else { return UserData.Delete(id); }
        }
        public static DataTable All()
        {
            return UserData.All();
        }
        public static User Find(int id)
        {
            int personId = -1;
            string username = string.Empty;
            string password = string.Empty;
            bool isActive = false;

            if (UserData.Get(id, ref personId, ref username, ref password, ref isActive))
            {
                return new User(id, personId, username, password, isActive);
            }
            return null;
        }
    }


}
