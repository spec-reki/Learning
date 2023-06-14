using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 16;
            float height = 1.8f;
            string name = "Jotaro";
            bool isMarried = false;

            Console.WriteLine("Name of mine is "+name+", I am "+age+" years old, I am "+height+"meters tall and I am not married");
            Console.ReadKey();
        }
    }
}