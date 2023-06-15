using System;

namespace Program{
    class Program{
        static void Main(string[] args){
            
            double a;
            double b;
            double c;

            Console.WriteLine("Enter the first number: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The average of those three numbers is: " + (a + b + c) / 3);
            
            Console.ReadKey();
        }
    }
}