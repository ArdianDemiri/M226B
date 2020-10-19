using System;
using System.Collections.Generic;

namespace autovermietung.Interface
{
    public interface ITestInterface
    {
        // Just a small Test
        int ID { get; }
        string Name { get; }

        void RentCar();
    }
}
