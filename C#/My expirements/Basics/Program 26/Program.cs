using System;

namespace Program26{

    class Cat{
        public string name;
        public int age;

        public void Meow(){
            Console.WriteLine(name + " says meow!");
        }
    }
    class Program{
        static void Main(string[] args)
        {
            Cat cat01 = new Cat();

            cat01.name = "Cat Zyzz";
            cat01.age = 1;

            cat01.Meow();

            Console.ReadKey();
        }
    }
}