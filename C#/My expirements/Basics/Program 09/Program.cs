using System;

namespace Program09{
    class Program{
        static void Main(string[] args){
            
            Console.WriteLine("Yooo! Welcome to billionaire club!\nIf u want to join us, please enter how mach money do u have: ");
            int money = Convert.ToInt32(Console.ReadLine());

            if (money >= 1000000000){
                Console.WriteLine("Congrats! U are a billionaire!");
            }
            else{
                Console.WriteLine("Sorry, u are not a billionaire! Go away!");
            }            
            
            Console.ReadKey();

        }
    }
}