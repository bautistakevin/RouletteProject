using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{

    class NumberBet : IBet
    {
        string number;

        public NumberBet(string num)
        {
            this.number = num;
        }

        public bool DidWin(Number num)
        {
            if (this.number.Equals(num.Value))
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return "Number bet: " + number;
        }
    }
 
}
