using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arraya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            Console.WriteLine($"The numbers are {numbers[0]}, {numbers[1]}, {numbers[2]}");

            int[] myNumbers = new int[4];

            Console.WriteLine("Enter the num1");
                myNumbers[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the num2");
            myNumbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the num3");
            myNumbers[2] = Convert.ToInt32(Console.ReadLine());

            //  Console.WriteLine($"These are the numbers entered {myNumbers[0]}, {myNumbers[1]}, {myNumbers[2]} ");

            int[] numbers2 = new int[5];
            
            

            for(int i  = 0; i < numbers2.Length; i++) {
                Console.WriteLine("Enter a digit");
                numbers2[i] = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i< myNumbers.Length - 1; i++)
            {
                Console.Write($" {myNumbers[i]} " );
            }


        }

       
    }
}
