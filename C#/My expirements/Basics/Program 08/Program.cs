using System;

namespace Program08{
    class Program{
        static void Main(string[] args){

            int a;

            Console.WriteLine("What is 2 + 3?");
            a = Convert.ToInt32(Console.ReadLine());

             if (a == 5){
                Console.WriteLine("Correct! Good job!");
             } else {
                Console.WriteLine("Incorrect! You are dumb!");
             }
            
            Console.ReadKey();
        }
    }
}