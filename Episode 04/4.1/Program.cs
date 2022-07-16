using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many cool numbers do u want: ");

            int count = Convert.ToInt32(Console.ReadLine());

           for (double i = 1; i <= count; i++)
           {
               double result = Math.Pow(2, i);
               Console.WriteLine(result);
           }


            Console.ReadKey();
        }
    }
}