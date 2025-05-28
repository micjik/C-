using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  string name = "Ayo";
            //  int age = 40;

            //  Console.WriteLine("My name is "  + name + " And my age is " + age);
            //   Console.ReadLine();
            Console.WriteLine("Please enter your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Please enter your age?");
            int inputAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("My name is {0} and my age is {1}", inputName, inputAge);
            Console.WriteLine($"My name is {inputName} and my age is {inputAge}");
            Console.ReadLine();

        }
    }
}
