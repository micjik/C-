using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
     class Program
    {
        static void Main(string[] args)
        {
            //Create two List with integer data types, one for even numbers while the other for odd
            //Loop from 0 to 20
            //if number is even, add to even number
            // if number is odd, add to off number
            //print even list
            //print odd list
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for(int i = 0; i <= 20; i++)
            {
                if(i % 2 == 0)
                {
                    even.Add(i);
                }
                else if(i % 2 == 1)
                {
                    odd.Add(i);
                }    
            }

            Console.WriteLine("Printing even numbers");

            foreach(var item in even)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine(Environment.NewLine + "printing odd numbers");
            foreach (var item in odd)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
