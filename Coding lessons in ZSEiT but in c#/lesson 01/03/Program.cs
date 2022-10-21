using System;

namespace two
{
    
    class Person
    {
        public string name;
        public string lastname;
        public int age;
        public string profession;
        public Person(string _name, string _lastname, int _age, string _profession )
        {
            name = _name;
            lastname = _lastname;
            age = _age;
            profession = _profession;
        }
        public void TellName()
        {
            Console.WriteLine(name + lastname + age + profession);
        }
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            Person person01 = new Person("Maks" , "Pokrzywnicki " , 17 , " Grafik");
            Person person02 = new Person("Bogdan " , "Boner " , 56 , " Egzorcysta");
            Person person03 = new Person("Krystian " , "Malinowy " , 87 , " Elektryk");

            person02.TellName();

            Console.ReadKey();
        }
    }
}