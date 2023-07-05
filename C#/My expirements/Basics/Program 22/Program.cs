using System;
using System.Collections.Generic;

namespace Program22
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("How many students are in your class:");

            int classSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me names of your students:");

            string[] klasa = new string[classSize];
            
            for (int i = 0; i < classSize; i++)
            {
                klasa[i] = Console.ReadLine();
            }

            Console.WriteLine("------------------------------\nHere is your class in correct order:");
            Array.Sort(klasa);

            for (int i = 0; i < classSize; i++)
            {
                Console.Write(i+1 + ". ");
                Console.WriteLine(klasa[i]);
            }

            Console.ReadKey();

        }
    }
}