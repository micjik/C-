using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // void means it returns nothing

            //bool success = int.TryParse("123", out int result);
           // Console.WriteLine(success);
           // Console.ReadLine();

           // string test = "Hello";
          //  test.Replace();
            StringBuilder sb = new StringBuilder();

            static void CreateAndPrintArray()
            {
                int[] numbers = new int[3] 
                {1, 2, 3 };

                foreach (var item in numbers)
                {
                    Console.WriteLine($"{item}");
                }
            }
        }
    }
}
