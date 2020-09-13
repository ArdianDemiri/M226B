using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace autovermietung
{
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            string filePath = "cars.save";
            PKW pkw1 = new PKW(5, Guid.NewGuid(), "Mercedes", "CL500", "ZH90223");
            PKW pkw2 = new PKW();
            DataSerializer dataSerializer = new DataSerializer();
            dataSerializer.JSonSerializing(pkw1, filePath);
            pkw2 = dataSerializer.JsonDesirialize(typeof(PKW), filePath) as PKW;

            Console.WriteLine("Seats: {0}\nID: {1}\nBrand: {2}\nModel: {3}\nPlate Number: {4}\n",
                pkw2.CountSeats, pkw2.CarID, pkw2.Brand, pkw2.Model, pkw2.LicensePlate);
            #region
            /*
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

            bf.Serialize(fs, cars);
            fs.Position = 0;
            Console.WriteLine("Old Cars:\n");

            List<Car> cars2 = (List<Car>)bf.Deserialize(fs);

            foreach (Car car2 in cars2)
            {
                Console.WriteLine("Brand: {0}\nModel: {1}\n\n", car2.Model, car2.Brand);
            }

            fs.Close();
            */
            #endregion
        }

    }

    class DataSerializer
    {
        public void BinarySerialize(object data, string filepath)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filepath)) File.Delete(filepath);
            fileStream = File.Create(filepath);
            bf.Serialize(fileStream, data);
            fileStream.Close();
        }

        public object BinaryDeserialize(string filePath)
        {
            object obj = null;

            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                obj = bf.Deserialize(fileStream);
                fileStream.Close();
            }
            return obj;
        }

        public void XmlSerialize(Type datatype, object data, string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(datatype);
            if (File.Exists(filePath)) File.Delete(filePath);
            TextWriter writer = new StreamWriter(filePath);
            xmlSerializer.Serialize(writer, data);
            writer.Close();
        }

        public object XmlDeserialize(Type dataType, string filePath)
        {
            object obj = null;
            XmlSerializer xmlSerializier = new XmlSerializer(dataType);
            if (File.Exists(filePath))
            {
                TextReader textReader = new StreamReader(filePath);
                obj = xmlSerializier.Deserialize(textReader);
                textReader.Close();
            }
            return obj;
        }

        public void JSonSerializing(object data, string filePath)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(filePath)) File.Delete(filePath);
            StreamWriter sw = new StreamWriter(filePath);
            JsonWriter jsonWriter = new JsonTextWriter(sw);

            jsonSerializer.Serialize(jsonWriter, data);
            jsonWriter.Close();
            sw.Close();
        }

        public Object JsonDesirialize(Type dataType, string filePath)
        {
            JObject obj = null;
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                JsonReader jsonReader = new JsonTextReader(sr);
                obj = jsonSerializer.Deserialize(jsonReader) as JObject;
                jsonReader.Close();
                sr.Close();
            }

            return obj.ToObject(dataType);
        }
    }
}