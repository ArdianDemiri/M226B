using System;
namespace autovermietung
{
    public class Client
    {
        private int _clientID;
        private string _name;
        private string _surname;
        private string _phoneNumber;

        private string _street;
        private string _city;
        private string _zipCode;
        private string _country;

        public Client(int ID, string Name, string Surname, string PhoneNumber,
            string Street, string City, string ZipCode, string Country)
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
    }
}
