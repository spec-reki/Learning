using System;

namespace program{
    class program{
        static void Main(string[] args){

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "difference between two points";            

            int a = 10;
            int b = 20;
            int c = a - b;

            Console.WriteLine("The difference of {0} and {1} is {2}", a, b, c);

            Console.ReadKey();
        }
    }
}