using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D
{
    class Dice
    {
        private Random random = new Random();

        public int Roll(int numberOfDice, int numberOfSides)
        {
            int total = 0;
            for (int i = 0; i < numberOfDice; i++)
            {
                total += random.Next(1, numberOfSides + 1);
            }
            return total;
        }
    }

}
