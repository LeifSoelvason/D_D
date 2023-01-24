using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D
{
    class Stats
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        private Dice _dice;
        public Stats()
        {
            _dice = new Dice();
            Strength = _dice.Roll(3, 6);
            Dexterity = _dice.Roll(3, 6);
            Constitution = _dice.Roll(3, 6);
            Intelligence = _dice.Roll(3, 6);
            Wisdom = _dice.Roll(3, 6);
            Charisma = _dice.Roll(3, 6);
        }
    }

}
