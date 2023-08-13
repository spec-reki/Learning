using System;

namespace Program27
{
    class Wizard{
        public string name;
        public string favouriteSpell;
        public int spellSlots;
        public float experience;

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
            Wizard wizard01 = new Wizard();
            wizard01.name = "Damn shaggy";
            wizard01.favouriteSpell = "Kamehameha";
            wizard01.spellSlots = 2;
            wizard01.experience = 0f;

            
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