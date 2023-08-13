using System;
using System.Data;

namespace Program27
{
    class Wizard{
        public string name;
        public string favouriteSpell;
        private int spellSlots;
        private float experience;
        
        public static int Count;
        public Wizard(string _name, string _favouriteSpell){
            name = _name;
            favouriteSpell = _favouriteSpell;
            spellSlots = 2;
            experience = 0f;

            Count++;
        }

        public void CastSpell()
        {
            if (spellSlots > 0)
            {
                Console.WriteLine(name + " casts " + favouriteSpell);
                spellSlots--;
                experience += 0.8f;
            }
            else
            {
                Console.WriteLine(name + " is out of spell slots.");
            }
        }

        public void Meditate(){
            Console.WriteLine("{0} meditates to regain spell slpts.", name);
            spellSlots = 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard("Damn Shaggy", "kamehameha");
            
            wizard01.CastSpell();
            
            Wizard wizard02 = new Wizard("Jake Peralta", "Doug Judy");

            wizard02.CastSpell();

            Console.WriteLine(Wizard.Count);

            Console.ReadKey();
        }
    }
}