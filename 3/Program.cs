using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num01;

            Console.Title =("PP measure");
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("What's up? We are here to let u know how big your pp is.");

            Console.Write("Input a number: ");

            num01 = Convert.ToDouble(Console.ReadLine());
            
            if( num01 > 10)
            {
                Console.WriteLine("WOW, THIS IS A PREATY HUGE CANON");
            }
            else
            {
                Console.WriteLine("Oh, it's preatty small pp :(");
            }
            
            Console.ReadKey();
        }
    }
}