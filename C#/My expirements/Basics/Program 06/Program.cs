using System;

namespace Program{
    class Program{
        static void Main(string[] args){
            
            int num01;
            int num02;

            Console.Write("Write a first number: ");
            num01 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write a second number: ");
            num02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe sum of {0} and {1} is: {2}", num01, num02, num01 + num02);

            Console.ReadKey();
        }
    }
}