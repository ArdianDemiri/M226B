using System;
namespace autovermietung
{
    public class Rental
    {
        private Client _client;
        private Location _location;
        private Car _car;
        private DateTime _startdate;
        private DateTime _endDate;

        public Rental(Client client, Location location, Car car,
            DateTime StartDate, DateTime EndDate)
        {
            _client = client;
            _location = location;
            _car = car;
            _startdate = StartDate;
            _endDate = EndDate;
        }

        public Rental() { }
    }
}
