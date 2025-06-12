using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  int num = 10;
              string name = "jesse";
              Assign(ref num, ref name);
              Console.WriteLine(num);
              Console.WriteLine(name);
              Console.ReadLine();*/

            string name = "Jesse";

            Console.WriteLine("Enter your new name:");
            string newName = Console.ReadLine();
           if (ChangeName(ref name, newName))
            {
                Console.WriteLine($"Your new name is {name}");
            }
           else
            {
                Console.WriteLine("New name cannot be empty or null");
            }

                Console.WriteLine($"your new name is {name}");
        }

        static bool ChangeName(string name, ref string newName)
        {
            if(!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }
            return false;
        }
      /*  static void Assign(ref int num, ref string name)
        {
            name = "Ayo";
            num = 20;
        }*/
    }
}
