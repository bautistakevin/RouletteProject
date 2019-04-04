using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            RouletteWheel rw = new RouletteWheel();

            List<IBet> bets = new List<IBet>();

            int val = 0;

            while (val != -1)
            {
                Console.WriteLine("Please select a menu option below or -1 to exit: ");
                Console.WriteLine(" 0) Roll Wheel");
                Console.WriteLine(" 1) Number Bet");
                Console.WriteLine(" 2) Even or Odd Bet");
                Console.WriteLine(" 3) Color Bet");
                Console.WriteLine(" 4) Lows & Highs Bet");
                Console.WriteLine(" 5) Dozens Bet");
                Console.WriteLine(" 6) Columns Bet");
                Console.WriteLine(" 7) Street Bet");
                Console.WriteLine(" 8) 6 Numbers Bet");
                Console.WriteLine(" 9) Split Bet");
                Console.WriteLine("10) Corner Bet");
                val = int.Parse(Console.ReadLine());
                switch (val)
                {
                    case -1:
                        break;
                    case 0:
                        Number winningNumber = rw.RollWheel();
                        Console.WriteLine("The ball landed on: " + winningNumber);
                        foreach (IBet bet in bets)
                        {
                            if (bet.DidWin(winningNumber) == true)
                            {
                                Console.WriteLine("Winner! " + bet);
                            }
                        }
                        bets.Clear();
                        break;
                    case 1:
                        Console.WriteLine("Please enter the value to bet that number:");
                        bets.Add(new NumberBet(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("Please type odd or even to place your bet:");
                        bets.Add(new OddOrEvenBet(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Please enter the color to place the bet:");
                        bets.Add(new ColorBet(Console.ReadLine().ToLower()));
                        break;
                    case 4:
                        Console.WriteLine("Please pick type low or high to place the bet:");
                        bets.Add(new LowsHighBet(Console.ReadLine().ToLower()));
                        break;
                    case 5:
                        Console.WriteLine("Please pick the row: (1 = (1-12), 2 = (13-24), 3 = (25-36))");
                        string methodFeeder = Console.ReadLine();
                        int input = int.Parse(methodFeeder);
                        if (input > 3)
                        {
                            Console.WriteLine("Please enter an appropriate choice");
                            methodFeeder = Console.ReadLine();
                        }
                        bets.Add(new DozensBet(methodFeeder));
                        break;
                    case 6:
                        Console.WriteLine("Please pick the column from the left to right");
                        bets.Add(new ColumnBet(Console.ReadLine()));
                        break;
                    case 7:
                        Console.WriteLine("Please pick the street by spelling out the nth street row");
                        bets.Add(new StreetBet(Console.ReadLine()));
                        break;
                    case 8:
                        Console.WriteLine("Please pick the 6 numbers bet by providing the starting number value");
                        bets.Add(new DoubleRowsBet(Console.ReadLine()));
                        break;
                    case 9:
                        Console.WriteLine("Please pick the lowest number of the split");
                        bets.Add(new SplitBet(Console.ReadLine()));
                        break;
                    case 10:
                        Console.WriteLine("Please enter the numbers of the corner bet separated by commas and no spaces");
                        bets.Add(new CornerBet(Console.ReadLine()));
                        break;
                }


            }
        }
    }
}
