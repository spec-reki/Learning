using System;

namespace Episode
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Give me a first number to mulltiply here: ");
            int num01 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Give me a seckond number to mulltiply here: ");
            int num02 = Convert.ToInt16(Console.ReadLine());
            
            int result = Multiply(num01, num02);

            Console.WriteLine("The result is: " + result);

            if (result % 2 == 0)
            {
                Console.WriteLine(result + " is an even number!");
            }
            else
            {
                Console.WriteLine(result + " is an uneven number!");
            }
            
            // Wait before closing
            Console.ReadKey();
        }

        static int Multiply( int num01, int num02)
        {
            int result = num01 * num02;
            return result;

        }

    }
}