using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool looping = true;

            //System.FormatException
            //System.OverflowException

            while (looping)
            {
                try
                {

                    Console.WriteLine("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please enter a number less than 2 billion");
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong");
                }
            }
           
        }
    }
}
