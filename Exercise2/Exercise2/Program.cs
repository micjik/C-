using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user to input message
            // print in order
            // print reverse

            Console.WriteLine("Please Enter a Text Message");
            string textMessages = Console.ReadLine();
            

            for(int i = 0; i <textMessages.Length; i++)
            {
                Console.Write(textMessages[i]);
            }
            Console.WriteLine();

            for(int i = textMessages.Length -1; i >= 0; i--)
            {
                Console.Write(textMessages[i]);
            }
            
        }
    }
}
