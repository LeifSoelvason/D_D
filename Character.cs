using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D
{
    class Character
    {
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public string Race { get; set; }
        public int Level { get; set; }
        public DateTime Birthday { get; set; }
        public Stats Stats { get; set; }

        public Character()
        {
            Stats = new Stats();
        }

        public void ShowCharacter()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Class: " + CharacterClass);
            Console.WriteLine("Race: " + Race);
            Console.WriteLine("Level: " + Level);
            Console.WriteLine("Birthday: " + Birthday.ToShortDateString());
            Console.WriteLine("Stats: ");
            Console.WriteLine("\tStrength: " + Stats.Strength);
            Console.WriteLine("\tDexterity: " + Stats.Dexterity);
            Console.WriteLine("\tConstitution: " + Stats.Constitution);
            Console.WriteLine("\tIntelligence: " + Stats.Intelligence);
            Console.WriteLine("\tWisdom: " + Stats.Wisdom);
            Console.WriteLine("\tCharisma: " + Stats.Charisma);
        }

        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - Birthday.Year;
            if (Birthday > today.AddYears(-age)) age--;
            return age;
        }
    }

}
