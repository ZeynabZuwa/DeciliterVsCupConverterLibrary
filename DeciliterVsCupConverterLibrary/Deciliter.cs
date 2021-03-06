using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeciliterVsCupConverterLibrary
{
    public struct Deciliter:IMeasurement
    {
        public double Dl;

        public Deciliter(double dl)
        {
            this.Dl = dl;
        }

        public static implicit operator Deciliter(double deciliter)
        {
            return new Deciliter(deciliter);
        }

        public static implicit operator double(Deciliter deciliter)
        {
            return deciliter.Dl;
        }

        public static implicit operator Deciliter(Cup cup)
        {
            double conversionResult = cup / 2.4;

            Deciliter temp = new Deciliter(conversionResult);
            return temp;
        }

        public override string ToString()
        {
            return Dl + " Deciliter";
        }
    }
}
