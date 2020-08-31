using System;
namespace autovermietung
{
    public class CleaningStaff : Staff
    {
        private string _random;

        public CleaningStaff(string RandomString, Guid ID, Location location,
            string Name, string Surname, string PhoneNumber)
            : base(ID, location, Name, Surname, PhoneNumber)
        {
            _random = RandomString;
            _staffID = ID;
            _location = location;
            _name = Name;
            _surname = Surname;
            _phoneNumber = PhoneNumber;
        }

        public CleaningStaff() { }

        //_cleaningID
        public string RandomString
        {
            get { return _random; }
            set
            {
                if (RandomString != null)
                {
                    _random = RandomString;
                }
            }
        }
    }
}
