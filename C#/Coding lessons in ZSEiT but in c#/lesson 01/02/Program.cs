using System;

namespace two
{
    
    class Person
    {
        public string name;
        public Person(string _name)
        {
            name = _name;
        }
        public void TellName()
        {
            Console.WriteLine("My name is " + name);
        }
    }
  

    class Program
    {
        static void Main(string[] args)
        {
            Person person01 = new Person("Maks");

            person01.TellName();

            Console.ReadKey();
        }
    }
}