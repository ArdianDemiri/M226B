using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

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

            dataSerializer.BinarySerialize(person, filePath);

            person2 = dataSerializer.BinaryDeserialize(filePath) as Person;

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
    } 

    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
