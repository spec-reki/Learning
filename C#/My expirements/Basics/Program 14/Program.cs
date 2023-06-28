using System;

namespace Program14{
    class Program    {
        static void Main(string[] args){

            for (int i = 1; i <= 10; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }

            Console.ReadKey();

        }            
    }
}