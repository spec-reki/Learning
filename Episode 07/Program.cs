using System;

namespace Episode_07
{
    class Wizard
    {
        public string name;
        public string favouriteSpell;
        public int spellSlots;
        public float experience;
    }
    
    class Program
    {
        static void Main (string[] args)
        {
            Wizard wizard01 = new Wizard();
            wizard01.name = "Gandalf";
            wizard01.favouriteSpell = "U shall not pass";
            wizard01.spellSlots = 2;
            wizard01.experience = 0;

            Console.ReadKey();
        }
    }
}