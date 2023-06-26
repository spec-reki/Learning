using System;

namespace Program10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yooo! Welcome to our cinema! You can watch one of four films today!");
            int miliseconds = 2000;
            Thread.Sleep(miliseconds);
            Console.WriteLine("\nChoose wisely:\n1.SPIDER MAN\n2.Baby Driver\n3.STAR WARS\n4.Puss in boots");
            
            int SPIDER = 1;
            int Baby = 2;
            int STAR = 3;
            int Puss = 4;

            int film = Convert.ToInt32(Console.ReadLine());
            if( film == SPIDER ){
                Console.WriteLine("Good choice! One ticket for new Spider man is cost of 10 dollars");
                int price = 10;

                Console.WriteLine("Tickets for your film are 10$. \nHow many tickets do you need?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            int cash = price * tickets;
            

            Console.WriteLine("Okey! You need to pay {0} dollars.", cash);
            int money = Convert.ToInt32(Console.ReadLine());

            if (money < cash)
            {
                Console.WriteLine("It's not enough.");
            } else if (money == cash){
                Console.WriteLine("Here are your tickets.");
            }else{
                int change = money -cash;
                Console.WriteLine("Here is your ticket and {0} dollars of change.", change);
            }

            Console.ReadKey();

            } else if ( film == Baby ){
                Console.WriteLine("Good choice! One ticket for Baby Driver is cost of 12 dollars");
                int price = 12;
                Console.WriteLine("Tickets for your film are 10$. \nHow many tickets do you need? ");
            int tickets = Convert.ToInt32(Console.ReadLine());
            int cash = price * tickets;
            

            Console.WriteLine("Okey! You need to pay {0} dollars.", cash);
            int money = Convert.ToInt32(Console.ReadLine());

            if (money < cash)
            {
                Console.WriteLine("It's not enough.");
            } else if (money == cash){
                Console.WriteLine("Here are your tickets.");
            }else{
                int change = money -cash;
                Console.WriteLine("Here is your ticket and {0} dollars of change.", change);
            }

            Console.ReadKey();


            } else if ( film == STAR ){
                Console.WriteLine("Good choice! One ticket for new STAR WARS is cost of 9 dollars");
                int price = 9;
                Console.WriteLine("Tickets for your film are 10$. \nHow many tickets do you need? ");
            int tickets = Convert.ToInt32(Console.ReadLine());
            int cash = price * tickets;
            

            Console.WriteLine("Okey! You need to pay {0} dollars.", cash);
            int money = Convert.ToInt32(Console.ReadLine());

            if (money < cash)
            {
                Console.WriteLine("It's not enough.");
            } else if (money == cash){
                Console.WriteLine("Here are your tickets.");
            }else{
                int change = money -cash;
                Console.WriteLine("Here is your ticket and {0} dollars of change.", change);
            }

            Console.ReadKey();

            } else if ( film == Puss ){
                Console.WriteLine("Good choice! One ticket for new Puss in boots is cost of 8 dollars");
                int price = 8;
                Console.WriteLine("Tickets for your film are 10$. \nHow many tickets do you need? ");
            int tickets = Convert.ToInt32(Console.ReadLine());
            int cash = price * tickets;
            

            Console.WriteLine("Okey! You need to pay {0} dollars.", cash);
            int money = Convert.ToInt32(Console.ReadLine());

            if (money < cash)
            {
                Console.WriteLine("It's not enough.");
            } else if (money == cash){
                Console.WriteLine("Here are your tickets.");
            }else{
                int change = money -cash;
                Console.WriteLine("Here is your ticket and {0} dollars of change.", change);
            }

            Console.ReadKey();

            } else {
                Console.WriteLine("You choosed none of films I proposed to you.\n Try again!");
            

            

        }
    }
}
}