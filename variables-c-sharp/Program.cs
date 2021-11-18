using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            //simple calculator, first time using variables
            Console.ForegroundColor = ConsoleColor.Green;
            
            double number1;
            double number2;


            Console.Write("Input a first number: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Input a second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            double result = number1 * number2;
            Console.WriteLine("The result of multiplication is " + result);
            Console.WriteLine("How calculations looks: " + number1 + "x" + number2 + "=" + result + "\n");
            
            double result2 = number1 / number2;
            Console.WriteLine("The result of dividing is " + result2);
            Console.WriteLine("How calculations looks:  " + number1 + ":" + number2 + "=" + result2 + "\n");

            double result3 = number1 + number2;
            Console.WriteLine("The result of addition is " + result3);
            Console.WriteLine("How calculations looks: " + number1 + "+" + number2 + "=" + result3 + "\n");

            double result4 = number1 - number2;
            Console.WriteLine("The result of substraction is " + result4);
            Console.WriteLine("How calculations looks: " + number1 + "-" + number2 + "=" + result4 +"\n");


            // wait before closing
            Console.ReadKey();
        
        }
    }
}