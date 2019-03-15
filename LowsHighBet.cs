namespace Roulette
{
    internal class LowsHighBet : IBet
    {
        string lowsHigh;

        public LowsHighBet(string _lowsHigh)
        {
            this.lowsHigh = _lowsHigh;
        }

        public bool DidWin(Number WinningNumber)
        {
            string low = "low";
            string high = "high";
            int number = int.Parse(WinningNumber.Value);

            if (number <= 18)
                WinningNumber.Value = low;
            else
                WinningNumber.Value = high;

            if (WinningNumber.Value.Equals(lowsHigh))
                return true;
            else
                return false;
        }
    }
}