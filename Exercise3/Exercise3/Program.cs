using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // password checker
            Console.WriteLine("Please enter password");
            string password = Console.ReadLine();

            Console.WriteLine("Please enter the password again");
            string confirmedPassword = Console.ReadLine();

            if (!password.Equals(string.Empty))
            {

                if (!confirmedPassword.Equals(string.Empty))
                {
                    if (password.Length > 6 && confirmedPassword.Length > 6)
                    {
                        if (password.Equals(confirmedPassword))
                        {
                            Console.WriteLine("The password match");
                        }
                        else
                        {
                            Console.WriteLine("The password do not match");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ensure password is greater than 6 characters");
                    }
                }
                else
                {
                    Console.WriteLine("Ensure the confirmed password is not empty");
                }
            }else
            {
                Console.WriteLine("Ensure the password is not empty");
            }
        }
    }
}
