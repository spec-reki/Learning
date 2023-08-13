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
                experience += 0.5f;
            }
            else
            {
                Console.WriteLine(name + " is out of spell slots.");
            }
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

            Console.WriteLine("Spell slots: " + wizard01.spellSlots);
            wizard01.CastSpell();
            Console.WriteLine("Spell slots: " + wizard01.spellSlots);

            Console.ReadKey();
        }
    }
}