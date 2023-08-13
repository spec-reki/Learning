using System;
using System.Data;

namespace Program27
{
    class Wizard{
        public string name;
        public string favouriteSpell;
        public int spellSlots;
        public float experience;

        public Wizard(string _name, string _favouriteSpell){
            name = _name;
            favouriteSpell = _favouriteSpell;
            spellSlots = 2;
            experience = 0f;
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
            wizard01.CastSpell();
            wizard01.CastSpell();

            wizard01.Meditate();

            wizard01.CastSpell();
            wizard01.CastSpell();

            Console.WriteLine("Experience: " + wizard01.experience);

            Console.ReadKey();
        }
    }
}