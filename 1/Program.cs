using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nice, potrafimy komentować, wypisywać i edytować wygląd terminalu

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "We need to refresh skills";
            Console.WindowHeight = 40;

            Console.WriteLine("Welcome! What's up?");
            Console.ReadLine();// U can put here word - zajebiście - for no reason ;)
            Console.WriteLine("That's cool!");



            Console.ReadKey();
        }
    }
}
