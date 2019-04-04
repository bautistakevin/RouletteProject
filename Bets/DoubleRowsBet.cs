using System;

namespace Roulette
{
    internal class DoubleRowsBet : IBet
    {
        public string startingNumber;

        public DoubleRowsBet(string _DoubleRows)
        {
            this.startingNumber = _DoubleRows;
        }

        public bool DidWin(Number WinningNumber)
        {
            int winningNumber = int.Parse(WinningNumber.Value);
            bool winningRows = DoubleRowChecker(winningNumber, startingNumber);
            if (winningRows == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DoubleRowChecker(int winningNumber, string startingNumber)
        {
            bool winningRows = false;
            //creating the players chosen rows
            int startNumber = int.Parse(startingNumber);
            int[] chosenRows = new int[6];
            for (int i = 0; i < chosenRows.Length; i++)
            {
                chosenRows[i] = startNumber + i;
            }

            //checking to see if the winning number is in the chosen rows
            for (int i = 0; i < chosenRows.Length; i++)
            {
                if(chosenRows[i] == winningNumber)
                {
                    return winningRows = true;
                }               
            }
            return winningRows;
        }
    }
}