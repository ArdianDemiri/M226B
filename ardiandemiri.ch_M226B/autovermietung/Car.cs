using System;
using System.Collections.Generic;

namespace autovermietung
{
    public class Car
    {
        protected int _carId;
        protected string _brand;
        protected string _model;
        protected string _licensePlate;

        protected List<Rental> _rentals = new List<Rental>();

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
