using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeciliterVsCupConverterLibrary
{
    public struct Cup:IMeasurment
    {
        public double cup;

        public Cup(double c)
        {
            this.cup = c;
        }

        public static implicit operator Cup(double cup)
        {
            return new Cup(cup);
        }

        public static implicit operator double(Cup cup)
        {
            return cup.cup;
        }

        public static implicit operator Cup(Deciliter dl)
        {
            double conversionResult = 0.4 * dl;

            Cup temp = new Cup(conversionResult);
            return temp;
        }

        public override string ToString()
        {
            return cup + " Cup" ;
        }

    }
}
