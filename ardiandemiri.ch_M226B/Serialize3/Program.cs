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

namespace Serialize3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string filePath = "objects.save";
            bool booler = true;
            Datalizer DT = new Datalizer();
            while(booler)
            {
                Console.WriteLine("Personenverwaltung\n");
                Console.WriteLine("-----------------------");
                Console.WriteLine("choose your option:");
                Console.WriteLine("Print [1] : Create [2]");
                int input;
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {
                            //List<test> myDeserializedObjList = (List<test>)Newtonsoft.Json.JsonConvert.DeserializeObject(Request["jsonString"], typeof(List<test>));
                            List<Person> persons = (List<Person>)JsonConvert.DeserializeObject(filePath);
                            foreach(Person person in persons)
                            {
                                Console.WriteLine("\nPrint all persons:");
                                Console.WriteLine("Name: {0}  Surname: {1}", person.FirstName, person.LastName);
                            }
                            break;
                        }
                    case 2:
                        {
                            //List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(filePath);

                            List<Person> persons = new List<Person>();
                            bool personAdder = true;
                            while(personAdder)
                            {
                                Console.Write("First Name : ");
                                string firstName = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Last Name : ");
                                string lastName = Console.ReadLine();
                                Person person = new Person { FirstName = firstName, LastName = lastName };
                                persons.Add(person);

                                Console.WriteLine("\n\nDo you wanna quit? [Y] | [N]");
                                string choicce = Console.ReadLine();
                                if (choicce == "Y")
                                {
                                    personAdder = false;
                                }
                            }
                            DT.JSONserialize(persons, filePath);
                            break;
                        }
                }

                Console.WriteLine("\n\nDo you wanna quit? [Y] | [N]");
                string choice = Console.ReadLine();
                if(choice == "Y")
                {
                    booler = false;
                }
            }
        }
    }

    public class Datalizer
    {
        public void JSONserialize(object obj, string filePath)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            //if (File.Exists(filePath)) File.Delete(filePath);
            StreamWriter sw = new StreamWriter(filePath);
            JsonWriter json = new JsonTextWriter(sw);
            jsonSerializer.Serialize(json, obj);
            json.Close();
            sw.Close();
        }

        public Object JSONDeserializer(Type dataType, string filePath)
        {
            JObject obj = null;

            JsonSerializer jsonSerializer = new JsonSerializer();
            if(File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                JsonReader jsonReader = new JsonTextReader(sr);
                obj = jsonSerializer.Deserialize(jsonReader) as JObject;
                sr.Close();
            }

            return obj.ToObject(dataType);
        }
    }

    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}
