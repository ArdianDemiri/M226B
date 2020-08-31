using System;
namespace autovermietung
{
    public class BusinessClient : Client
    {
        private string _businessName;

        public BusinessClient(Guid ID, string Name, string Surname, string PhoneNumber,
            string Street, string City, int ZipCode, string Country, string BusinessName)
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
            _businessName = BusinessName;
        }

        public BusinessClient() { }

        //_businessName
        public string BusinessName
        {
            get { return _businessName; }
            set
            {
                if (BusinessName != null)
                {
                    _businessName = BusinessName;
                }
            }
        }
    }
}
