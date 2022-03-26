using System;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1;

            Console.WriteLine("10 * 2 + 3 = ");
            result1 = Convert.ToInt32(Console.ReadLine());
            
            if(result1 == 23){
                Console.WriteLine("CORRECT!");
            } else {
                Console.WriteLine("You are just stupid son of a bitch!");
            }
            
            Console.ReadKey();
        }
    }
}
