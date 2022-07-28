using System;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yo man! I can sell u some lolipops. One is 4$. Give me some money my man.");

            int cash = Convert.ToInt32(Console.ReadLine());

            if(cash < 4)
            {
                    Console.WriteLine("That's not enough my n-word.");
            }
            else if (cash == 4)
            {
                Console.WriteLine("Here is your lolipop");
            }
            else
            {
                int change = cash - 4;
                Console.WriteLine("Here is your lolipop bruh, I've got u some chenge. \nYou just earned " + change + "$");
            }

            Console.ReadKey();
        }
    }
}

//      == is equal to
//      !=  is not equall to
//      >greater than / <less than
//      >= greather than or equal to
//      <= less than or equal to
