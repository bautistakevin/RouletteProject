namespace Roulette
{
    internal class OddOrEvenBet : IBet
    {
        string oddOrEven;

        public OddOrEvenBet(string _oddOrEven)
        {
            this.oddOrEven = _oddOrEven;
        }

        public bool DidWin(Number WinningNumber)
        {
            string odd = "odd";
            string even = "even";
            int number = int.Parse(WinningNumber.Value);

            if (number % 2 != 0)
                WinningNumber.Value = odd;
            else
                WinningNumber.Value = even;

            if (WinningNumber.Value.Equals(oddOrEven))
                return true;
            else
                return false;
        }
    }
}