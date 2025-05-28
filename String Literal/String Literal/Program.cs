using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Literal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string speech = "He said \"Something\" ";
            string path = "C:\\coffeNcode\\Desktop\\C# Course";
            Console.WriteLine(speech);
            Console.WriteLine(path);

            string name = "Hello \"Someone\" ";
            Console.WriteLine(name);
            name = @"Hello ""Someone"" ";
            Console.WriteLine(name);
            name = @"Hello 'Someone' ";

            // String Formatting
            string myName = "Jesse";
            int myAge = 3;
            Console.WriteLine("Name :" + myName);
            Console.WriteLine("Age :" + myAge);
            Console.WriteLine("Name : " + myName + "\n Age :" + myAge);
        }
    }
}
