using System;
namespace autovermietung
{
    public class Staff
    {
        protected Guid _staffID;
        protected Location _location;
        protected string _name;
        protected string _surname;
        protected string _phoneNumber;

        public Staff(Guid ID, Location location, string Name, string Surname, string PhoneNumber)
        {
            _staffID = ID;
            _location = location;
            _name = Name;
            _surname = Surname;
            _phoneNumber = PhoneNumber;
        }

        public Staff() { }

        //_clientID
        public Guid ClientID
        {
            get { return _staffID; }
            set
            {
                if (ClientID != null)
                {
                    _staffID = ClientID;
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
