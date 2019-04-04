namespace Roulette
{
    internal class ColorBet : IBet
    {
        string Color;

        public ColorBet(string _color)
        {
            this.Color = _color;
        }

        public bool DidWin(Number WinningNumber)
        {
            if(this.Color.Equals(WinningNumber.Color))
                return true;
            else
                return false;    
        }
        public override string ToString()
        {
            return "Color bet: " + Color;
        }
    }
}