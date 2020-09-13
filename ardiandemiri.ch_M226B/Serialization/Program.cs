using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Serialization
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Ardian";
            person.LastName = "Demiri";

            string filePath = "data.save";

            DataSerializer dataSerializer = new DataSerializer();

            Person person2 = new Person();

            //dataSerializer.BinarySerialize(person, filePath);

            //person2 = dataSerializer.BinaryDeserialize(filePath) as Person;

            dataSerializer.XmlSerialize(typeof(Person), person, filePath);

            person2 = dataSerializer.XmlDeserialize(typeof(Person), filePath) as Person;


            Console.WriteLine(person2.FirstName);
            Console.WriteLine(person2.LastName);



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
            if(File.Exists(filePath))
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

    } 

    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
