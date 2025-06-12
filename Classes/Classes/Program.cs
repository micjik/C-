using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program

    {
        /* struct Person 
         * struct are to be used as extension to data type
          { public string name;
              public int age;

              public Person(string name, int age)
              { this.name = name; this.age = age; }

          }*/
        class Person
        {
            public string name;
            public int age;

            public Person()
            {

            }
            public Person(string name)
            {
                this.name = name;
                this.age = 1;
            }

            public Person(int age)
            {
                this.age = age;
                this.name = "Jesse";
            }

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person("dara", 8);

            //  Console.WriteLine(p.name);
            //  Console.WriteLine(p.age);
            Console.WriteLine(ReturnedDetails(p.name, p.age));
        }

        static string ReturnedDetails(string name, int age)
        {
            return $"Name: {name}\nAge: {age}";
            }

    }
}
