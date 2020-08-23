using System;
namespace autovermietung
{
    public class Staff
    {
        protected int _clientID;
        protected Location _location;
        protected string _name;
        protected string _surname;
        protected string _phoneNumber;

        public Staff(int ID, Location location, string Name, string Surname, string PhoneNumber)
        {
            _clientID = ID;
            _location = location;
            _name = Name;
            _surname = Surname;
            _phoneNumber = PhoneNumber;
        }

        public Staff() { }
    }
}
