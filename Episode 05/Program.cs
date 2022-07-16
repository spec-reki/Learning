using System;

namespace Episode_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] games = new string[4];

            Console.WriteLine("Type in four movies:  ");

            for (int i = 0; i < games.Length; i++)
            {
                games[i] = Console.ReadLine();
            }

            Console.WriteLine("\nHere they are alphabetically: ");

            Array.Sort(games);

            for (int i = 0; i < games.Length; i++)
            {
                Console.WriteLine(games[i]);
            }

            Console.ReadKey();
        }
    }
}