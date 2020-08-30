using System;
namespace autovermietung
{
    public class PrivateClient : Client
    {
        protected string _randomText;

        public PrivateClient(int ID, string Name, string Surname, string PhoneNumber,
            string Street, string City, int ZipCode, string Country, string RandomText)
            : base(ID, Name, Surname, PhoneNumber, Street, City, ZipCode, Country)
        {
            _clientID = ID;
            _name = Name;
            _surname = Surname;
            _phoneNumber = PhoneNumber;
            _street = Street;
            _city = City;
            _zipCode = ZipCode;
            _country = Country;
            _randomText = RandomText;
        }

        public PrivateClient() { }

        //_randomText
        public string RandomText
        {
            get { return _randomText; }
            set
            {
                if (RandomText != null)
                {
                    _randomText = RandomText;
                }
            }
        }
    }
}
