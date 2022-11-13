using System;
using System.Collections.Generic;

namespace Episode_05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();

            shoppingList.Add("Dreams");
            shoppingList.Add("Sex");
            shoppingList.Add("Drugs");
            shoppingList.Add("Anime");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.Remove("Drugs");
            shoppingList.RemoveAt(0);

            Console.WriteLine("---------------------------");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }


            Console.ReadKey();
        }
    }
}