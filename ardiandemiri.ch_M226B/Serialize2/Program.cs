using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
namespace Serialize2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Ardian";
            person1.LastName = "Demiri";
            Person person2 = new Person();

            DataTransfer DT = new DataTransfer();
            string filePath = "objFile.save";
            DT.Serialize(person1, filePath);
            person2 = DT.Deserialize(filePath) as Person;
            Console.WriteLine("My Name ist {0} {1}", person2.FirstName, person2.LastName);
        }
    }

    public class DataTransfer
    {
        public void Serialize(object obj, string filePath)
        {
            FileStream fs;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath)) File.Delete(filePath);
            fs = File.Create(filePath);
            bf.Serialize(fs, obj);
            fs.Close();
        }

        public Object Deserialize(string filePath)
        {
            Object obj = null;

            FileStream fs;
            BinaryFormatter bf = new BinaryFormatter();

            if(File.Exists(filePath))
            {
                fs = File.OpenRead(filePath);
                obj = bf.Deserialize(fs);
                fs.Close();
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
