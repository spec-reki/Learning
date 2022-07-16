
//Just really like this one, it's first thing that i wrote in c-sharp

using System;



namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //change of apperance of console
            Console.Title = "Learning basics";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowWidth =37;
            Console.WindowHeight = 21;
            

            //conversation
            Console.WriteLine("What's your name?");

            Console.ReadLine();

            Console.WriteLine("Cool name!");
            Console.WriteLine("My name is Pam!\nI'll Show you our office \nAt first, we'll go to the boss.\nDo you know his name?");

            Console.ReadLine();

            Console.WriteLine("Oh, there he is!!!");

            Console.ReadKey();
        }
    }
}



