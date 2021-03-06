﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace streams
{
    class MainClass
    {
        static string fileName = "clientfile.bin";

        static void Main(string[] args)
        {
            List<Client> list1 = new List<Client>();
            list1.Add(new Client(1, "Joe", "Hanson", 1.234, 6300));
            list1.Add(new Client(2, "Tina", "Turner", 4.5, 8300));
            Console.WriteLine("Safed Client;\n");
            foreach (Client count in list1)
            {
                count.printClient();
                Console.WriteLine();
            }
            FileStream fs = new FileStream(fileName, FileMode.Create);
            IFormatter bf = new BinaryFormatter();
            // Writes a list of objects to a binary file
            bf.Serialize(fs, list1);
            fs.Position = 0;
            Console.WriteLine("\n\nReconstructed Clients:\n");
            // Reads a list of objects from a binary file
            List<Client> recList = (List<Client>)bf.Deserialize(fs);
            foreach (Client count in recList)
            {
                count.printClient();
                Console.WriteLine();
            }
            fs.Close();

        }
    }

    [Serializable]
    class Client
    {
        private int clientNumber;
        private string firstName;
        private string surName;
        private double factor;
        [NonSerialized]
        int regionNumber;
        public Client(int pClientNumber, string pFirstName, string pSurName,
        double pFactor, int pRegionNumber)
        {
            clientNumber = pClientNumber;
            firstName = pFirstName;
            surName = pSurName;
            factor = pFactor;
            regionNumber = pRegionNumber;
        }
        public void printClient()
        {
            Console.WriteLine("Client number: " + clientNumber);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Surname: " + surName);
            Console.WriteLine("Factor: " + factor);
            Console.WriteLine("Region number: " + regionNumber);
        }
    }
}
