using System;

namespace Conditions_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Pam:\n   Hi, I'm Pam. Do you remember me?\nNvm.\nIf u want to work here, \nYou must give 5$ for Michael.");

            int cash = Convert.ToInt32(Console.ReadLine());
            if (cash < 5)
            {
                Console.WriteLine("Michael:\n   That's not enough money, you poor bitch!!!");
            }
            else if (cash == 5)
            {
                Console.WriteLine("Michael:\n   Cool, Thank's.\nYou can be my little bitch now.\nGo to work my friend.");
            }
            else
            {
                int moneyformyboi = cash -5;
                Console.WriteLine("Michae:\n    Oh, that's nice,\n but I cant take more than 5$\n" + moneyformyboi + "$is your's\n Pls, take that money away of me");
            }





            //wait before closing
            Console.ReadKey();
        }
    }
}
