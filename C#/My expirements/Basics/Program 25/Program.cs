using System;
using System.Collections.Generic;

namespace Program25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the number that u want to power");
            int result = Multiply(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("--------------------");
            

            if (result % 2 == 0)
            {
                Console.WriteLine("Power of your number is: {0}",result);
                Console.WriteLine("{0} is an even number!",result);
            } else {
                Console.WriteLine("Power of your number is: {0}",result);
                Console.WriteLine("{0} is an uneven number!",result);
            }


            Console.ReadKey();

        }

        static int Multiply(int number01, int number02){
            int result = number01 * number02;
            return result;
        }
    }
}