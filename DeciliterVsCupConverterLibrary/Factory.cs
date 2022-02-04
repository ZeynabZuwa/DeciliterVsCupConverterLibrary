using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeciliterVsCupConverterLibrary
{
    public class Factory
    {
        public IMeasurement GetMeasurement(string measurementName, double amount=0)
        {
            switch (measurementName)
            {
                case "Deciliter":
                    return new Deciliter(amount);
                case "Cup":
                    return new Cup(amount);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
