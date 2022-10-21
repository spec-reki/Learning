using System;

namespace Something
{
    class Employee
    {
        public string name;
        public string lastname;
        public string email;
        public int salary;
        public static int Count;

        public Employee(string _name, string _lastname, string _email, int _salary)
        {
            name = _name;
            lastname = _lastname;
            email = _email;
            salary = _salary;

            Count++;
        }

        public void GetAnnualSallary()
        {
            Console.WriteLine("Roczne wynagrodzenie + " + salary*12);
        }

        public void ShowEmployeeInformation()
        {
            Console.WriteLine("Employee: " + name + "e-mail: " + email + "month salary: " + salary);
        }

    }
    
    class Program
    {
        static void Main (string[] args)
        {
            
        }
    }
}