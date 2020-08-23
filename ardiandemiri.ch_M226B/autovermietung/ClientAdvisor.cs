using System;
using System.Collections.Generic;

namespace autovermietung
{
    public class ClientAdvisor : Staff
    {
        protected List<Client> _clients = new List<Client>();

        public ClientAdvisor(List<Client> clients, int ID, Location location,
            string Name, string Surname, string PhoneNumber)
            : base(ID, location, Name, Surname, PhoneNumber)
        {
            _clients = clients;
            _clientID = ID;
            _location = location;
            _name = Name;
            _surname = Surname;
            _phoneNumber = PhoneNumber;
        }

        public ClientAdvisor() { }
    }
}
