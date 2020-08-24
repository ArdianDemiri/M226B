using System;
namespace autovermietung
{
    public class LKW : Car
    {
        private string _lkwType;

        public LKW(int ID, string Brand, string Model, string LicensePlate, string LKWType)
            : base(ID, Brand, Model, LicensePlate)
        {
            _carId = ID;
            _brand = Brand;
            _model = Model;
            _licensePlate = LicensePlate;
            _lkwType = LKWType;
        }
    }
}
