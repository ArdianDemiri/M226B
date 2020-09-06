using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace autovermietung
{
    class MainClass
    {
        static string fileName = "carsFile.bin";
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new PKW(5, Guid.NewGuid(), "Mercedes", "CLS", "ZH-9879"));
            cars.Add(new PKW(5, Guid.NewGuid(), "AUDI", "RS6", "ZH-934879"));

            Console.WriteLine("New Cars:\n");
            foreach(Car car in cars)
            {
                Console.WriteLine("Brand: {0}\nModel: {1}\n\n", car.Model, car.Brand);
            }

            Console.WriteLine("-----------------------");

            FileStream fs = new FileStream(fileName, FileMode.Create);
            IFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, fileName);
            fs.Position = 0;
            Console.WriteLine("Old Cars:\n");

            List<Car> cars2 = (List<Car>)bf.Deserialize(fs);

            foreach (Car car2 in cars2)
            {
                Console.WriteLine("Brand: {0}\nModel: {1}\n\n", car2.Model, car2.Brand);
            }

            fs.Close();
        }

    }
}