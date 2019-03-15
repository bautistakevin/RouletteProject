namespace Roulette
{
    internal class SplitBet : IBet
    {
        string split;

        public SplitBet(string _split)
        {
            this.split = _split;
        }

        public bool DidWin(Number WinningNumber)
        {
            int winningNumber = int.Parse(WinningNumber.Value);
            bool winningSplit = SplitChecker(winningNumber, split);
            if(winningSplit==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SplitChecker(int winningNumber, string startingNumber)
        {
            bool winningSplit = false;
            //creating the players chosen rows
            int startNumber = int.Parse(startingNumber);
            int[] chosenRows = new int[2];
            for (int i = 0; i < chosenRows.Length; i++)
            {
                chosenRows[i] = startNumber + i;
            }

            //checking to see if the winning number is in the chosen rows
            for (int i = 0; i < chosenRows.Length; i++)
            {
                if (chosenRows[i] == winningNumber)
                {
                    return winningSplit = true;
                }
            }
            return winningSplit;
        }
    }
}