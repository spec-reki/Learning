using System;

namespace Program19
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jojos = new string[4];

            Console.WriteLine("Type in four jojos: ");

            for (int i = 0; i < 4; i++)
            {
                Console.Write(i+1 + ". ");
                jojos[i] = Console.ReadLine();
            }
            
            Console.WriteLine("Bro.{0}; Bruh.{1}", jojos[0], jojos[1]);

            Console.ReadKey();

        }
    }
}