using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNullorEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string inputName = Console.ReadLine();
            Console.WriteLine(inputName);

            if(inputName != "")
            {
                Console.WriteLine("A");
            }
            if(!inputName.Equals(""))
            {
                Console.WriteLine("B");
            } 
            if(!string.IsNullOrEmpty(inputName))
            {
                Console.WriteLine("C");
            }
        }
    }
}
