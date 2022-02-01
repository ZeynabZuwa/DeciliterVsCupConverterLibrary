using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeciliterVsCupConverterLibrary
{
    public class Factory
    {
        public IMeasurment GetMeasurment(string mesasrumentName)
        {
            switch (mesasrumentName)
            {
                case "Deciliter":
                    return new Deciliter();
                case "Cup":
                    return new Cup();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
