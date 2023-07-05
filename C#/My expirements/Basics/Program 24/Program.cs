using System;
using System.Collections.Generic;

namespace Program24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the number that u want to power");
            int result = Square(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("--------------------");
            Console.WriteLine("Power of your number is: {0}",result);

            Console.ReadKey();

        }

        static int Square(int number){
            int result = number * number;
            return result;
        }
    }
}