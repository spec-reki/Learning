using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            double num01;
            double num02;
            double num03;

            Console.Write("Input a number: ");

            num01= Convert.ToDouble( Console.ReadLine() );

            Console.Write("Input a seckond number: ");

            num02=Convert.ToDouble( Console.ReadLine());

            Console.Write("Input third number: ");

            num03=Convert.ToDouble(Console.ReadLine());

            double result = (num01 + num02 + num03)  / 3 ;

            Console.WriteLine("The result is "+ result);

            Console.ReadKey();
        }
    }
}
//datatypes:
//int = Whole number 5 or -5
//float = Decimal number 2,13 or -2,13; float = up to 7 digits after "," 2,1372137
//double = up to 16 digits
//string = text (letters and numbers)
//bool = (true or not)