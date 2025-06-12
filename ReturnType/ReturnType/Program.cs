using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = $"{ReturnName()} - {ReturnAge()}";
              PrintIntroduction();

            int[] numbers = new int[3]
                for(int i = 0; i< numbers.Length; i++)
            {
                numbers[i] = ReadNumberFromConsole()
            }
                foreach(var item  in numbers)
            {
                Console.WriteLine(item);
            }
                static int CreateRandomArray()
            {
                //return new int[3] {1, 2, 3};
            }
                 static int ReadNumberFromConsole()
            {
                Console.WriteLine("Enter a number");
                return Convert.ToInt32(Console.ReadLine());
            }
            int[] newNumbers = new int[3];
              
            foreach(var item in newNumbers)
            {
                Console.WriteLine($"{item}");
            }

                static string ReturnName()
            {
                return "Ayo";
            }
               static int ReturnAge()
            {
                return 40;
            }
             static void PrintIntroduction()
            {
                string name = ReturnName();
                int age = ReturnAge();
                string output = $"Hello my name {name} and my age is {age}";
                Console.WriteLine(output);
            }
        }
    }
}
