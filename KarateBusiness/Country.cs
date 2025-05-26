using KarateDataAccess;
using System.Data;

namespace KarateBusiness
{
    public class Country
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        public int id { get; set; }
        public string name { get; set; }

        public Country()
        {
            this.id = 0;
            this.name = string.Empty;

            _mode = Mode.Add;
        }
        private Country(int id, string name)
        {
            this.id = id;
            this.name = name;


            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.id =
                        CountryData.Add(this.name);
            return (this.id != -1);
        }

        private bool _Update()
        {
            return CountryData.Update(this.id, this.name);
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
                        else
                        {
                            return false;
                        }
                    }
                case Mode.Update: return _Update();
            }
            return false;
        }
        public static bool Exist(int id)
        {
            return CountryData.Exist(id);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            else { return CountryData.Delete(id); }
        }
        public static DataTable All()
        {
            return CountryData.All();
        }
        public static Country Find(int id)
        {
            string name = string.Empty;

            if (CountryData.Get(id, ref name))
            {
                return new Country(id, name);
            }
            return null;
        }

        public static int GetIdCountryByName(string name)
        {
            return CountryData.GetCountryIdByName(name);
        }
    }


}
