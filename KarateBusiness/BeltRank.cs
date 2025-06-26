using KarateDataAccess;
using System.Data;

namespace KarateBusiness
{
    public class BeltRank
    {
        public enum TypeBeltRank
        {
            WhiteBelt = 1
          , YellowBelt = 2
          , OrangeBelt = 3
          , GreenBelt = 4
          , BlueBelt = 5
          , PurpleBelt = 6
          , BrownBelt = 7
          , BlackBelt1stDan = 8
          , BlackBelt2ndDan = 9
          , BlackBelt3rdDan = 10
          , BlackBelt4thDan = 11
          , BlackBelt5thDan = 12
          , BlackBelt6thDan = 13
          , BlackBelt7thDan = 14
          , BlackBelt8thDan = 15
          , BlackBelt9thDan = 16
          , BlackBelt10thDan = 17

        }
        private enum Mode { Add, Update }
        private Mode _mode;
        public int id { get; set; }
        public string name { get; set; }
        public decimal testFees { get; set; }

        public BeltRank()
        {
            this.id = 0;
            this.name = string.Empty;
            this.testFees = 0;

            _mode = Mode.Add;
        }
        private BeltRank(int id, string name, decimal testFees)
        {
            this.id = id;
            this.name = name;
            this.testFees = testFees;


            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.id =
                        BeltRankData.Add(this.name, this.testFees);
            return (this.id != -1);
        }

        private bool _Update()
        {
            return BeltRankData.Update(this.id, this.name, this.testFees);
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
            return BeltRankData.Exist(id);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            else { return BeltRankData.Delete(id); }
        }
        public static DataTable All()
        {
            return BeltRankData.All();
        }
        public static DataTable AllNames()
        {
            return BeltRankData.AllNames();
        }
        public static BeltRank Find(int id)
        {
            string name = string.Empty;
            decimal testFees = 0;

            if (BeltRankData.Get(id, ref name, ref testFees))
            {
                return new BeltRank(id, name, testFees);
            }
            return null;
        }

        public static string GetNameById(int beltId)
        {
            return BeltRankData.GetNameById(beltId);
        }
        public static int GetIdByName(string nameBelt)
        {
            return BeltRankData.GetIdByName(nameBelt);

        }
    }


}

