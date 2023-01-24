using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                Character myCharacter = new Character();
                myCharacter.Name = "Slayer";
                myCharacter.CharacterClass = "Wizard";
                myCharacter.Race = "Elf";
                myCharacter.Level = 99;
                myCharacter.Birthday = new DateTime(290, 4, 3);

                myCharacter.ShowCharacter();
                Console.WriteLine("Age: " + myCharacter.CalculateAge());
                Console.ReadLine();           

        }
    }
}
