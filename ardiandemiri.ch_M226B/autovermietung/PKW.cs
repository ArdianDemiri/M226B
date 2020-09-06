using System;
namespace autovermietung
{
    [Serializable]
    public class PKW : Car
    {
        
        private int _countSeats;

        public PKW(int CountSeats, Guid ID, string Brand, string Model, string LicensePlate)
            : base(ID, Brand, Model, LicensePlate)
        {
            _carId = ID;
            _brand = Brand;
            _model = Model;
            _licensePlate = LicensePlate;
            _countSeats = CountSeats;
        }

        public PKW() { }

        //_countSeats
        public int CountSeats
        {
            get { return _countSeats; }
            set
            {
                if (CountSeats >= 0)
                {
                    _countSeats = CountSeats;
                }
            }
        }
    }
}
