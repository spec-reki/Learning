using System;

namespace Program23{
    class Program{
        static void Main(string[] args){
            
            MeetAlien();

            Console.ReadKey();
        }

        static void MeetAlien(){
            Random numberGen = new Random();

            string name = "x-" + numberGen.Next(10,99999);
            int age = numberGen.Next(10,500);

            Console.WriteLine("Hi, I'm {0}", name);
            Console.WriteLine("I'm {0} years old", age);
            Console.WriteLine("Oh, and I'm an alien");
        }

    }
}