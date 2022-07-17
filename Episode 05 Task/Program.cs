using System;

namespace Episode_05_Task
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Write("How many students are in your class: ");


            int studentCount = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please input the names of the students: ");


            string[] students = new string[studentCount];


            for (int i = 0; i < studentCount; i++)
            {
                students[i] = Console.ReadLine();
            }

            Console.WriteLine("--------------");

            Array.Sort(students);

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(students[i]);
            }


            // Wait before closing
            Console.ReadKey();
        }
    }
}