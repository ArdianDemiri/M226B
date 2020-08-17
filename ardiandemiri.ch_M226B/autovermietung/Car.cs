using System;
namespace autovermietung
{
    public class Car
    {
        private int _carId;
        private string _brand;
        private string _model;
        private string _licensePlate;


        public Car(int ID, string Brand, string Model, string LicensePlate)
        {
            _carId = ID;
            _brand = Brand;
            _model = Model;
            _licensePlate = LicensePlate;
        }

        public Car() { }
    }
}
