using System;

namespace Program15{
    class Program    {
        static void Main(string[] args){

            Random numberGen = new Random();

            numberGen.Next(0,7);

            int roll01 = 0;
            int roll02 = 1;
            int attempts = 0;

            Console.WriteLine("Press space to roll d10.");

            while(roll01 != roll02){
                Console.ReadKey();

                roll01 = numberGen.Next(1, 8);
                Console.WriteLine("You rolled {0}", roll01);

                roll02 = numberGen.Next(1, 8);
                Console.WriteLine("You rolled {0}", roll02);

                attempts++; 
            }

            Console.WriteLine("It took you {0} attemps to roll two the same numbers.", attempts);

            Console.ReadKey();

        }            
    }
}