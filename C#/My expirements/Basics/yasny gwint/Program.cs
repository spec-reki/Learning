using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the fourth number: ");
        int num4 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2 + num3 + num4;

        Console.WriteLine("The sum of the four numbers is: " + sum);

        Console.ReadKey();
    }
}