using System;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int age;
            int height;

            Console.Write("Please, input your age in here: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please, input your height in here (cm): ");
            height = Convert.ToInt32(Console.ReadLine());

            if(age >=18 && height >= 140) {
                Console.WriteLine("You can't enter to my basement!");
            }  else {
                Console.WriteLine("You can see my kitties, welcome in my basement, kiddo!");
            }

            Console.ReadKey();
        }
    }
}

//&& = and
//  || = or