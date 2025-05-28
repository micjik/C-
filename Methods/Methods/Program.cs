using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Main method belongs to a class named Program  
            //void means it does not return any value
            //static means it can be called without creating an instance of the class
        }

        private static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        private static void PrintMessage(string message, int repeatCount)
        {
            for (int i = 0; i < repeatCount; i++)
            {
                Console.WriteLine(message);
            }
        }
        private static void PrintMessage(string message, int repeatCount, bool toUpperCase)
        {
            if (toUpperCase)
            {
                message = message.ToUpper();
            }
            for (int i = 0; i < repeatCount; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
