namespace Roulette
{
    internal class DozensBet : IBet
    {
        string dozen;

        public DozensBet(string _dozen)
        {
            this.dozen = _dozen;

        }
        
        public bool DidWin(Number WinningNumber)
        {
            string firstRow = "first Row";
            string secondRow = "second Row";
            string thirdRow = "third Row";
            int number = int.Parse(WinningNumber.Value);
            int playerChoice = int.Parse(dozen);
            if (playerChoice == 1)
            {
                dozen = firstRow;
            }
            if (playerChoice == 2)
            {
                dozen = secondRow;
            }
            if(playerChoice == 3)
            {
                dozen = thirdRow;
            }
            if(number <= 12)
            {
                WinningNumber.Value = firstRow;
            }
            else if (number >= 13 && number <= 24)
            {
                WinningNumber.Value = secondRow;
            }
            else if (number >=25)
            {
                WinningNumber.Value = thirdRow;
            }
            if (WinningNumber.Value.Equals(dozen))
                return true;
            else
                return false;
        }
    }
}