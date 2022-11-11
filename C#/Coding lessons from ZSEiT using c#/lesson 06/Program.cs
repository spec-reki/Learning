using System;



namespace Program
{
    class Trojkat
    {
        public int a;
        public int b;
        public int c;

        public Trojkat(int _a, int _b, int _c)
        {
            a = _a;
            b = _b;
            c = _c;
        }

        public void Inicjalizator()
        {
            Trojkat trojkat01 = new Trojkat( a, b, c);
            
            Console.Write("Podaj długość boku a:");
            a=Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj długość boku b:");
            b=Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj długość boku c:");
            c=Convert.ToInt32(Console.ReadLine());

            if(a + b > c)
            {
                Console.WriteLine("Z odcinków można zbudować trójkąt!");
            }

        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Trojkat.Inicjalizator();

            Console.ReadKey();
        }
    }
}

