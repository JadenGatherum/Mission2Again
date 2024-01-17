using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Again
{
    internal class RollingtheDice
    {
        public int[] ListofRolls(int userRolls)
        {
            Random rand = new Random();
            int[] diceList = new int[userRolls];

            for (int i = 0; i < userRolls; i++)
            {
                int diceOne = rand.Next(1, 7);
                int diceTwo = rand.Next(1, 7);
                int diceCombo = diceOne + diceTwo;
                diceList[i] = (diceCombo);
            }

            return diceList;
        }
    }
}
