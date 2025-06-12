using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
             7, 16, 23, 36, 42, 56, 63, 71, 88, 99
            };
            Console.WriteLine("Enter a number");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            // int position = Array.IndexOf(numbers, searchNumber);

            //  if (position > 0)
            //{
            //   Console.WriteLine($"The number {searchNumber} is at position {position}");
            //  }
            //  else
            // {
            //      Console.WriteLine($"The number {searchNumber} could not be found.");
            // }
            int position = -1;
            for(int i =0; i < numbers.Length; i++)
            {
                if(numbers[i] == searchNumber)
                {
                    position = i;
                }
            }
            if(position > -1)
            {
                Console.WriteLine("number could not be found");
            }
        }
    }
}
