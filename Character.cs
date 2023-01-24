using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D
{
    internal class Character
    {

        //Because the method that uses this array is static, we also make the array static.
        private static string[] characterClass = { "Warrior", "Wizard", "Priest", "Rouge", "Summoner", "Druid", "Ranger" }; 

        private static Random random = new Random();

        public string Name { get; set; }
   
       public string CharacterClass { get; set; }

        public string Race { get; set; }

        public int Level { get; set; }

        public DateTime Birthday { get; set; }

        public Stats Stats { get; set; }

        public Character()
        {
            Stats = new Stats();
            Name = RandomNameGenerator(3, 8);
            GetRandomBirthday();
            CharacterClass = GetCharacterClassRandomly();
        }

        private string RandomNameGenerator(int v1, int v2)
        {
            //0-5:vowels and 6-end: consonant. 
            char[] letters = { 'a', 'e', 'i', '0', 'u', 'y', 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p','q','r','s','t','v','w','x','z' };

            int lenght = random.Next(v1, v2+1);
            int StartLetter = random.Next(0, letters.Length);
            bool isVowel = StartLetter < 6 ? true : false;
            string name = letters[StartLetter].ToString().ToUpper();
            for (int i = 0; i < lenght; i++)
            {
                if (isVowel)
                {
                    name += letters[random.Next(0, letters.Length)];
                    isVowel = false;
                }
                else
                {
                    name += letters[random.Next(0, 6)];
                    isVowel = true;
                }
            }

            return name;
        }


        private void GetRandomBirthday()
        {
            Random random = new Random();
            DateTime start = new DateTime(1020, 1, 1);
            DateTime end = new DateTime(1120, 1, 1);
            int range = (end - start).Days;
            int days = random.Next(range);
            Birthday = start.AddDays(days);
        }

        //Static method runs on class and not on object
        public static string GetCharacterClassRandomly()
        {
            Random random = new Random();
            int r = random.Next(characterClass.Length);
            string cc = characterClass[r];
            return cc;

            //return characterClass[new Random().Next(characterClass.Length)];
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
