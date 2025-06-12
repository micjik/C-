using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 3, 8, 6, 2 };

            Array.Sort(numbers);

            Array.Reverse(numbers);

            Array.Resize(ref numbers, 3);

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
