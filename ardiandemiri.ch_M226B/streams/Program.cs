using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace streams
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // define path and file name
            string fileName = @"/Users/ardiandemiri/Desktop/byteArray3.text";
            // define and initialize arrays
            byte[] byteArrayWrite = { 1, 2, 3, 4, 5, 6, 7 };
            byte[] byteArrayRead = new byte[byteArrayWrite.Length];
            //create file stream
            FileStream fs = new FileStream(fileName, FileMode.Create);
            // write array to file
            fs.Write(byteArrayWrite, 0, byteArrayWrite.Length); // array name,
                                                                // start index,
                                                                // length of array
                                                                //read from file
            fs.Position = 0; // set start position
            fs.Read(byteArrayRead, 0, byteArrayRead.Length); // read file values
                                                             // output: values of byte array
            for (int count = 0; count < byteArrayRead.Length; count++)
            {
                Console.Write(byteArrayRead[count] + ", ");
            }
            fs.Close();

            string fileName2 = @"/Users/ardiandemiri/Projects/M226B/ardiandemiri.ch_M226B/autovermietung/byteArray2.bin";
            byte[] byteArrayContent = { 8, 9, 10, 11, 12, 13 };
            byte[] byteArrayLength = new byte[byteArrayContent.Length];
            FileStream fs2 = new FileStream(fileName2, FileMode.Create);
            fs2.Write(byteArrayContent, 0, byteArrayContent.Length);

            for (int count2 = 1; count2 < byteArrayLength.Length; count2++)
            {
                Console.Write(byteArrayLength[count2] + ", ");
            }

            fs2.Close();
            File.Delete(fileName2);
            // close filestream
            
        }
    }
}
