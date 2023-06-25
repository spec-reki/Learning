using System;

namespace Program10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yooo! Welcome to our cinema! \nTickets for new SPIDER-MAN are 10$. \nHow many tickets do you need? ");
            int tickets = Convert.ToInt32(Console.ReadLine());
            int price = tickets * 10;

            Console.WriteLine("Okey! You need to pay {0} dollars.", price);
            int money = Convert.ToInt32(Console.ReadLine());

            if (money < price)
            {
                Console.WriteLine("It's not enough.");
            } else if (money == price){
                Console.WriteLine("Here are your tickets.");
            }else{
                int change = money -price;
                Console.WriteLine("Here is your ticket and {0} dollars of change.", change);
            }

            Console.ReadKey();

        }
    }
}