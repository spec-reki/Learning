using System;

namespace Program19
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jojos = new string[4];

            Console.WriteLine("Type in four jojos: ");

            for (int i = 0; i < jojos.Length; i++)
            {
                Console.Write(i+1 + ". ");
                jojos[i] = Console.ReadLine();
            }
            
            Console.WriteLine("\nHere are those mf by alphabetical order: ");

            Array.Sort(jojos);

            for (int i = 0; i < jojos.Length; i++)
            {
                Console.WriteLine(jojos[i]);
            }

            Console.ReadKey();

        }
    }
}