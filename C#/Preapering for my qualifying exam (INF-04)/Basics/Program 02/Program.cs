using System;

namespace program_S02
{
    class Program
    {
        static void Main(string [] args)
        {
            string name;

            Console.WriteLine("Yo man, what's your name?");

            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Hello " + name + "!");

            Console.ReadLine();

        }
    }
}