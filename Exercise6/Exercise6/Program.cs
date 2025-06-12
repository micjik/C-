using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Program

    //create and initialize int array of numbers
    //create function SumOfNumbers with int return type
    //int array param
    //function should return total of all numbers
    //call in main and output total
    // extra check array length
    //return -1 if array Empty
    //check return in main and output message
    //do we need to return -1, how else can we make this
    {
        static void Main(string[] args)
        {
            

            int[] numbers = new int[]
            {
                0, 13, 5, 6, 9, 10
            };
            Console.WriteLine($"The sum of the total numbers is {SumOfNumbers(numbers)}");

            int result = SumOfNumbers( numbers );

            if (result > -1)
            {
                Console.WriteLine($"{result}");
            }
            else
            {
                Console.WriteLine("could not add up empty array");
            }

            if(SumOfNumbers(numbers, out int total))
            {
                Console.WriteLine($"{result}");
            }
            else
            {
                Console.WriteLine("could not add up empty array");
            }

            

        }
         static int SumOfNumbers(int[] numbers)

        {
            if(numbers.Length > 0 )
            {
                int total = 0;
                foreach (var item in numbers)
                {
                    total += item;

                }
                return total;
            }

            return -1;
        }

        static bool SumOfNumbers(int[] numbers, out int total)

        {
            total = 0;
            if (numbers.Length > 0)
            {
                 
                foreach (var item in numbers)
                {
                    total += item;

                }
                return true;
            }

            return false;
        }
    }
}
