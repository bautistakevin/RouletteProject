using System;

namespace Roulette
{
    internal class CornerBet : IBet
    {
        //"1,2,4,5"
        string corner;

        public CornerBet(string _corner)
        {
            this.corner = _corner;
        }

        public bool DidWin(Number WinningNumber)
        {
            int winningNumber = int.Parse(WinningNumber.Value);
            bool winningCorner = CornerChecker(winningNumber, corner);
            if(winningCorner == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CornerChecker(int winningNumber, string corner)
        {
            bool DidWinCorner = false;

            //split up our string into substrings and removed the commas
            string[] userinput = corner.Split(',');

            //made an int array to store our corner numbers
            int[] cornerArray = new int[4];

            //transferred our numbers from our string[] to our int[]
            for (int i = 0; i < cornerArray.Length; i++)
            {
                cornerArray[i] = int.Parse(userinput[i]);
            }

            //check to see if winningNumber is inside our corner array
            for (int i = 0; i < cornerArray.Length; i++)
            {
                if(cornerArray[i] == winningNumber)
                {
                    return DidWinCorner = true;
                }
            }
            return DidWinCorner;
        }
    }
}