using KarateDataAccess;
using System;
using System.Data;

namespace KarateBusiness
{
    public class Person
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        public enum enGender { Male = 0, Female = 1 }
        public string GenderText
        {
            get
            {
                switch (gender)
                {
                    case enGender.Male:
                        return "Male";

                    case enGender.Female:
                        return "Female";
                    default:
                        return "Male";
                }
            }
        }
        public int id { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string thirdName { get; set; }
        public string lastName { get; set; }
        public string nationalNumber { get; set; }
        public int countryId { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public enGender gender { get; set; }
        public string imagePath { get; set; }

        public string FullName
        {
            get
            {
                return string.IsNullOrEmpty(this.thirdName) ? $"{this.firstName} {this.secondName} {this.lastName}" : $"{this.firstName} {this.secondName} {this.thirdName} {this.lastName}";
            }
        }

        public Person()
        {
            this.id = 0;
            this.firstName = string.Empty;
            this.secondName = string.Empty;
            this.thirdName = string.Empty;
            this.lastName = string.Empty;
            this.nationalNumber = string.Empty;
            this.countryId = -1;
            this.dateOfBirth = DateTime.MinValue;
            this.email = string.Empty;
            this.address = string.Empty;
            this.phone = string.Empty;
            this.gender = 0;
            this.imagePath = string.Empty;

            _mode = Mode.Add;
        }
        private Person(int id, string firstName, string secondName, string thirdName, string lastName, string nationalNumber, int countryId, DateTime dateOfBirth, string email, string address, string phone, byte gender, string imagePath)
        {
            this.id = id;
            this.firstName = firstName;
            this.secondName = secondName;
            this.thirdName = thirdName;
            this.lastName = lastName;
            this.nationalNumber = nationalNumber;
            this.countryId = countryId;
            this.dateOfBirth = dateOfBirth;
            this.email = email;
            this.address = address;
            this.phone = phone;
            this.gender = gender;
            this.imagePath = imagePath;


            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.id = PersonData.Add(this.firstName, this.secondName, this.thirdName, this.lastName, this.nationalNumber, this.countryId, this.dateOfBirth, this.email, this.address, this.phone, this.gender, this.imagePath);

            return (this.id != -1);
        }

        private bool _Update()
        {
            return PersonData.Update(this.id, this.firstName, this.secondName, this.thirdName, this.lastName, this.nationalNumber, this.countryId, this.dateOfBirth, this.email, this.address, this.phone, this.gender, this.imagePath);
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
            return PersonData.Exist(id);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            else { return PersonData.Delete(id); }
        }
        public static DataTable All()
        {
            return PersonData.All();
        }
        public static Person Find(int id)
        {
            string firstName = string.Empty;
            string secondName = string.Empty;
            string thirdName = string.Empty;
            string lastName = string.Empty;
            string nationalNumber = string.Empty;
            int countryId = -1;
            DateTime dateOfBirth = DateTime.MinValue;
            string email = string.Empty;
            string address = string.Empty;
            string phone = string.Empty;
            byte gender = 0;
            string imagePath = string.Empty;

            if (PersonData.Get(id, ref firstName, ref secondName, ref thirdName, ref lastName, ref nationalNumber, ref countryId, ref dateOfBirth, ref email, ref address, ref phone, ref gender, ref imagePath))
            {
                return new Person(id, firstName, secondName, thirdName, lastName, nationalNumber, countryId, dateOfBirth, email, address, phone, gender, imagePath);
            }
            return null;
        }

        public static Person FindByNationalNo(string nationalNo)
        {
            int PersonId = -1;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gender = 0;
            string Address = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            int NationalityCountryID = -1;
            string ImagePath = string.Empty;

            if (PersonData.Get(nationalNo, ref PersonId, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new Person(PersonId, nationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, (enGender)Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            return null;
        }
        public static string GetNameCountryById(int id)
        {
            return PersonData.GetNameCountryById(id);
        }







    }


}
