using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>()
            { "Milk", "Coffe"};
            Console.WriteLine(shoppingList.IndexOf("Milk"));
            //Console.WriteLine(FindInList("Coffe", shoppingList, out int index));
            // Console.WriteLine(index);
            Console.Write("Enter an item to search:");
            string search = Console.ReadLine();

            if (FindInList("coffe", shoppingList, out int index))
            {
                Console.WriteLine($"Found coffe at index {index}");
            }else
            {
                Console.WriteLine("Not found");
            }

                /*
                int index = -1;
                for(int i =0;  i < shoppingList.Count; i++)
                {
                    if(shoppingList[i].ToLower().Equals("coffee"))
                    {
                        index = 1;
                    }
                    else
                    {
                        index = -1;
                    }
                    bool found = index > -1;
                    Console.WriteLine(found ? "Found": "Notfound");

                    Console.ReadLine();
                }*/

                static bool FindInList(string s, List<string> list, out int index)
                {
                    index = -1;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].ToLower().Equals(s.ToLower()))
                        {
                            index = 1;
                        }
                    }

                    bool found = index > -1;




                }
        }
    }
}
