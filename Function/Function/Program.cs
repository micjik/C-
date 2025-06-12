using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Test
    {
        public static void Something()
        {
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // static means you do not have to create an instance

            // if you do not use static, you have to say this

           // Test test = new Test();
          //  test.Something();
            WelcomeMessage();

            Test.Something();

            Console.ReadLine();
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Learning C# program");
        }
    }
}
