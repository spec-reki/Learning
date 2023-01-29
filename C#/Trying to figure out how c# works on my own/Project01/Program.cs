using System;

namespace Program
{
    class WhoUR
    {
        public string name;
        public Person(string _name)
            {
                name = _name;
            }

        public void Introducing()
        {
            Console.Write("Sup bro, what's your name?");
            Console.ReadLine()

            Console.ReadKey();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "ReallyCoolTitle";
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowWidth =40;
            Console.WindowHeight = 25;

            

            

        }
    }
}


