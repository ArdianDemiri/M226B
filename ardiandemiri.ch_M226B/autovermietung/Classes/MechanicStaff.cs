using System;
namespace autovermietung
{
    public class MechanicStaff : Staff
    {
        private string _random;

        public MechanicStaff(string Random, Guid ID, Location location,
            string Name, string Surname, string PhoneNumber)
            : base(ID, location, Name, Surname, PhoneNumber)
        {
            _staffID = ID;
            _location = location;
            _name = Name;
            _surname = Surname;
            _phoneNumber = PhoneNumber;
        }

        public MechanicStaff() { }

        //_phoneNumber
        public string Random
        {
            get { return _random; }
            set
            {
                if (Random != null)
                {
                    _random = value;
                }
            }
        }
    }
}
