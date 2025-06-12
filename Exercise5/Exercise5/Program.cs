using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        { /* Ask user for width and height, store them
           * Create function to calculate the area
           * Function should calculate the area using: (Width * height)/2
           * call in main and print out the area of the triangle
           */
            int width = ReadInt("Enter width: ");
            int height = ReadInt("Enter height: ");

            int result = CalcArea(width, height);

            Console.WriteLine($"The area is {result}");

            Console.WriteLine(width);
            Console.WriteLine(height);

            Console.ReadLine();
        }
          static int CalcArea(int width, int height)
        {
            return (width * height)/2;
        }

        static int ReadInt(string message)
        {
            Console.WriteLine("Enter message: ");
            return  Convert.ToInt32(Console.ReadLine());
        }
    }
}
