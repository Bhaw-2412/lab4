using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace DelegateExample
{
    public delegate void ProcessData(string data);

    class Program3
    {
        public static void DisplayData(string data)
        {
            Console.WriteLine("Displaying: " + data);
        }

        public static void LogData(string data)
        {
            string filePath = "log.txt";
            File.AppendAllText(filePath, data + Environment.NewLine);
            Console.WriteLine($"Data logged to {filePath}");
        }

        static void Main(string[] args)
        {
                      ProcessData process = DisplayData;  
            process += LogData;                 

          
            process("Hello, Delegate World!");

            Console.WriteLine("Both methods executed successfully.");
        }
    }
}

