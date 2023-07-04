using System;
using System.Collections.Generic;

namespace Program19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();
            
            shoppingList.Add("Star Platinium");
            shoppingList.Add("The World");
            shoppingList.Add("Crazy Diamond");
            shoppingList.Add("The Hand");
            
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.Remove("The World");
            shoppingList.RemoveAt(2);

            Console.WriteLine("-------------------------------");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            Console.ReadKey();

        }
    }
}