using System;
using System.Collections.Generic;

namespace autovermietung
{
    public class Car
    {
        //guid
        protected Guid _carId;
        protected string _brand;
        protected string _model;
        protected string _licensePlate;

        protected List<Rental> _rentals = new List<Rental>();

        public Car(Guid ID, string Brand, string Model, string LicensePlate)
        {
            _carId = ID;
            _brand = Brand;
            _model = Model;
            _licensePlate = LicensePlate;
        }

        public Car() { }

        //_carID
        public Guid CarID
        {
            get { return _carId; }
            set
            {
                if (CarID != null)
                {
                    _carId = CarID;
                }
            }
        }

        //_brand
        public string Brand
        {
            get { return _brand; }
            set
            {
                if (Brand != null)
                {
                    _brand = Brand;
                }
            }
        }

        //_model
        public string Model
        {
            get { return _model; }
            set
            {
                if (Model != null)
                {
                    _model = Model;
                }
            }
        }

        //_licensePlate
        public string LicensePlate
        {
            get { return _licensePlate; }
            set
            {
                if (LicensePlate != null)
                {
                    _licensePlate = LicensePlate;
                }
            }
        }
    }
}
