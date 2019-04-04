namespace Roulette
{
    internal class ColumnBet : IBet
    {
        string column;
        string firstColumn = "first column";
        string secondColumn = "second column";
        string thirdColumn = "third column";

        public ColumnBet(string _column)
        {
            this.column = _column;
        }

        public bool DidWin(Number WinningNumber)
        {

            int number = int.Parse(WinningNumber.Value);
            string winningLane = ColumnChecker(number);
            if(winningLane.Equals(column))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public string ColumnChecker(int number)
        {
            int[] firstRow = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] secondRow = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] thirdRow = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            string winningLane = "";
            for (int i=0; i < 12; i++)
            {
                int firstColumnSearchVal = firstRow[i];
                if(firstColumnSearchVal==number)
                {
                    return winningLane = firstColumn;
                }

                int secondColumnSearchVal = secondRow[i];
                if(secondColumnSearchVal == number)
                {
                    return winningLane = secondColumn;
                }

                int thirdColumnSearchVal = thirdRow[i];
                if(thirdColumnSearchVal == number)
                {
                    return  winningLane = thirdColumn;
                }
            }
            return winningLane;
        }
    }
}