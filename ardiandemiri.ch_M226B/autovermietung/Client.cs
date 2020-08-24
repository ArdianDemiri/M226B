using System;
using System.Collections.Generic;

namespace autovermietung
{
    public class Client
    {
        protected List<Rental> _rentals = new List<Rental>();

        protected int _clientID;
        protected string _name;
        protected string _surname;
        protected string _phoneNumber;

        protected string _street;
        protected string _city;
        protected int _zipCode;
        protected string _country;

        public Client(int ID, string Name, string Surname, string PhoneNumber,
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
    }
}
