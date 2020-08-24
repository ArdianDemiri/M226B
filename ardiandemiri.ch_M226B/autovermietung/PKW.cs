using System;
namespace autovermietung
{
    public class PKW : Car
    {
        private int _countSeats;

        public PKW(int CountSeats, int ID, string Brand, string Model, string LicensePlate)
            : base(ID, Brand, Model, LicensePlate)
        {
            _carId = ID;
            _brand = Brand;
            _model = Model;
            _licensePlate = LicensePlate;
            _countSeats = CountSeats;
        }

        public PKW() { }
    }
}
