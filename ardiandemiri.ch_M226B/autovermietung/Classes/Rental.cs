using System;
namespace autovermietung
{
    public class Rental
    {
        private Guid _rentalID;
        private Client _client;
        private Location _location;
        private Car _car;
        private DateTime _startdate;
        private DateTime _endDate;

        public Rental(Guid RentalID, Client client, Location location, Car car,
            DateTime StartDate, DateTime EndDate)
        {
            _rentalID = RentalID;
            _client = client;
            _location = location;
            _car = car;
            _startdate = StartDate;
            _endDate = EndDate;
        }

        public Rental() { }

        //_guid
        public Guid RentalID
        {
            get { return _rentalID; }
            set
            {
                if (RentalID != null)
                {
                    _rentalID = RentalID;
                }
            }
        }

        //_client
        public Client Client_P
        {
            get { return _client; }
            set
            {
                if (Client_P != null)
                {
                    _client = Client_P;
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

        //_car
        public Car Car_P
        {
            get { return _car; }
            set
            {
                if (Car_P != null)
                {
                    _car = Car_P;
                }
            }
        }

        //_startDate
        public DateTime StarDate
        {
            get { return _startdate; }
            set
            {
                if (StarDate != null)
                {
                    _startdate = StarDate;
                }
            }
        }

        //_endDate
        public DateTime EndDate
        {
            get { return _endDate; }
            set
            {
                if (EndDate != null)
                {
                    _endDate = EndDate;
                }
            }
        }
    }
}
