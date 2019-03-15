using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Number
    {
        public string Value { get; set; }
        public string Color { get; set; }

        public Number(string _number, string _color)
        {
            this.Value = _number;
            this.Color = _color;
        }
        public override string ToString()
        {
            return this.Value + " " + this.Color;
        }

    }
}
