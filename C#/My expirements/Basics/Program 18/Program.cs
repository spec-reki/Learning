using System;

namespace Program17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's work on indexes!!\n");

            string[] jojos = {
                "Jonathan",
                "Joseph",
                "Jotaro",
                "Josuke",
                "Giorno"
            };

            for (int i = 0; i < jojos.Length; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank + ". " +jojos[i]);  
            }
            

            Console.ReadKey();

        }
    }
}