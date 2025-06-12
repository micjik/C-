using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Remoting.Channels;

namespace Empty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string inputName = Console.ReadLine();

            //if (inputName != "")
            //if (inputName != String.Empty)
            //if (inputName !== "")
            if(!inputName.Equals(""))
            {
                Console.WriteLine("Your name is " + inputName);
            }else
            {
                Console.WriteLine("Your name is Empty");
            }
            // String Equals Function
            string message = "Hello";
            string compare = "Hello";

            //if( message == compare )
            if(message.Equals(compare))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }
            // A string is an array of characters
            string myCourse = "C# is Awesome";
            // char[]
            Console.WriteLine(myCourse[0]);
            Console.WriteLine(myCourse[1]);
            Console.WriteLine(myCourse[2]);
            Console.WriteLine(myCourse[3]);
            Console.WriteLine(myCourse[4]);
            Console.WriteLine(myCourse[5]);
            Console.WriteLine(myCourse[6]);
            Console.WriteLine(myCourse[7]);
            Console.WriteLine(myCourse[8]);
            Console.WriteLine(myCourse[9]);
            Console.WriteLine(myCourse[10]);


            Console.WriteLine();

            Console.WriteLine(myCourse.Contains("C"));

            Console.WriteLine();

            for (int i = 0; i < myCourse.Length; i++)
            {
                Console.Write(myCourse[i]);
                Thread.Sleep(100);
            }

        }
    }
}
