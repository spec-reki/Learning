using System;

namespace Episode_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] games = {"Minecraft" , "Mario" , "Red dead Redemption 2" , "Terraria"};

            for (int i = 0; i < games.Length; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank + ". " + games[i] );
            }
            Console.ReadKey();
        }
    }
}