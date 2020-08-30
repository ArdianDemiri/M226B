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

        //_clientID
        public int ClientID
        {
            get { return _clientID; }
            set
            {
                if (ClientID >= 0)
                {
                    _clientID = ClientID;
                }
            }
        }

        //_location
        public Location Location_P
        {
            get { return _location; }
            set
            {
                if (Location_P != null)
                {
                    _location = Location_P;
                }
            }
        }

        //_name
        public string Name
        {
            get { return _name; }
            set
            {
                if (Name != null)
                {
                    _name =Name;
                }
            }
        }

        //_surname
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (Surname != null)
                {
                    _surname = Surname;
                }
            }
        }

        //_phoneNumber
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (PhoneNumber != null)
                {
                    _phoneNumber = PhoneNumber;
                }
            }
        }
    }
}
