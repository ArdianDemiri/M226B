using System;
using System.Collections.Generic;

namespace autovermietung
{
    public class Client
    {
        protected List<Rental> _rentals = new List<Rental>();

        protected Guid _clientID;
        protected string _name;
        protected string _surname;
        protected string _phoneNumber;

        protected string _street;
        protected string _city;
        protected int _zipCode;
        protected string _country;

        public Client(Guid ID, string Name, string Surname, string PhoneNumber,
            string Street, string City, int ZipCode, string Country)
        {
            _clientID = ID;
            _name = Name;
            _surname = Surname;
            _phoneNumber = PhoneNumber;
            _street = Street;
            _city = City;
            _zipCode = ZipCode;
            _country = Country;
        }

        public Client() { }

        //_clientID
        public Guid ClientID
        {
            get { return _clientID; }
            set
            {
                if (ClientID != null)
                {
                    _clientID = ClientID;
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
                    _name = Name;
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

        //_street
        public string Street
        {
            get { return _street; }
            set
            {
                if (Street != null)
                {
                    _street = Street;
                }
            }
        }

        //_city
        public string City
        {
            get { return _city; }
            set
            {
                if (City != null)
                {
                    _city = City;
                }
            }
        }

        //_zipCode
        public int ZipCode
        {
            get { return _zipCode; }
            set
            {
                if (ZipCode >= 0)
                {
                    _zipCode = ZipCode;
                }
            }
        }

        //_phoneNumber
        public string Country
        {
            get { return _country; }
            set
            {
                if (Country != null)
                {
                    _country = Country;
                }
            }
        }
    }
}
