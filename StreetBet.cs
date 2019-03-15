namespace Roulette
{
    internal class StreetBet : IBet
    {
        string street;
        string firstRow = "first row";
        string secondRow = "second row";
        string thirdRow = "third row";
        string fourthRow = "fourth row";
        string fifthRow = "fifth row";
        string sixthRow = "sixth row";
        string seventhRow = "seventh row";
        string eigthRow = "eigth row";
        string ninthRow = "ninth row";
        string tenthRow = "tenth row";
        string eleventhRow = "eleventh row";
        string twelfthRow = "twelfth row";

        public StreetBet(string _street)
        {
            this.street= _street;
        }

        public bool DidWin(Number WinningNumber)
        {
            int number = int.Parse(WinningNumber.Value);
            string winningLane = StreetChecker(number);
            if (winningLane.Equals(street))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string StreetChecker(int number)
        {
            int[] Row1  = { 1,  2,  3 };
            int[] Row2  = { 4,  5,  6 };
            int[] Row3  = { 7,  8,  9 };
            int[] Row4  = { 10, 11, 12 };
            int[] Row5  = { 13, 14, 15 };
            int[] Row6  = { 16, 17, 18 };
            int[] Row7  = { 19, 20, 21 };
            int[] Row8  = { 22, 23, 24 };
            int[] Row9  = { 25, 26, 27 };
            int[] Row10 = { 28, 29, 30 };
            int[] Row11 = { 31, 32, 33 };
            int[] Row12 = { 34, 35, 36 };

            string winningLane = "";

            for (int i = 0; i < 2; i++)
            {
                int first = Row1[i];
                if (first == number)
                {
                    return winningLane = firstRow;
                }

                int second = Row2[i];
                if (second == number)
                {
                    return winningLane = secondRow;
                }

                int third = Row3[i];
                if (third == number)
                {
                    return winningLane = thirdRow;
                }

                int fourth = Row4[i];
                if (fourth == number)
                {
                    return winningLane = fourthRow;
                }

                int fifth = Row5[i];
                if (fifth == number)
                {
                    return winningLane = fifthRow;
                }

                int sixth = Row6[i];
                if (sixth == number)
                {
                    return winningLane = sixthRow;
                }

                int seventh = Row7[i];
                if (seventh == number)
                {
                    return winningLane = seventhRow;
                }

                int eigth = Row8[i];
                if (eigth == number)
                {
                    return winningLane = eigthRow;
                }

                int ninth = Row9[i];
                if (ninth == number)
                {
                    return winningLane = ninthRow;
                }

                int tenth = Row10[i];
                if (tenth == number)
                {
                    return winningLane = tenthRow;
                }

                int eleventh = Row11[i];
                if (eleventh == number)
                {
                    return winningLane = eleventhRow;
                }

                int twelfth = Row12[i];
                if (twelfth == number)
                {
                    return winningLane = twelfthRow;
                }
            }
            return winningLane;
        }
    }
}