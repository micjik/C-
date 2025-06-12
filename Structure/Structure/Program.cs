using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
     class Program
    {
        struct Person
        {
            public string name;
            public int age;
            public int birthMonth;
            public int number;

            public Person(string name, int age, int birthMonth, int number)
            {
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;
                this.number = number;
            }
        }
        static void Main(string[] args)
        {
            string name = "Ayo";
            int age = 22;
            int birthMonth = 10;
            int number = 20;

            StringBuilder sb = new StringBuilder();
             new Person(name, age, birthMonth, number);

            Person person = ReturnPerson();
            Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth} - {person.number}");
            

        }

        static Person ReturnPerson()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter your birthMonth");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your number");
            int number = Convert.ToInt32(Console.ReadLine());

            return new Person(name, age, birthMonth, number);
        }
    }
}
