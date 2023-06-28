using System;

namespace Program14{
    class Program    {
        static void Main(string[] args){

            Random numberGen = new Random();

            numberGen.Next(0,10);

            int roll = 0;
            int attempts = 0;

            Console.WriteLine("Press space to roll d10.");

            while(roll != 10){
                Console.ReadKey();

                roll = numberGen.Next(1, 11);
                Console.WriteLine("You rolled {0}", roll);
                attempts++;
            }

            Console.WriteLine("It took you {0} attemps to roll a ten.", attempts);

            Console.ReadKey();

        }            
    }
}