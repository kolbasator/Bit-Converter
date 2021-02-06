using System;
using System.Collections.Generic;
using System.Text;

namespace Bit_Converter
{
    public  class TwelveDigitNumber : INumber
    {
        public int System { get; } = 12;
        public string WholePart { get; }

        public TwelveDigitNumber(string wholePart)
        {
            WholePart = wholePart;
        }

        public override string ToString()
        {
            return WholePart;
        }
    }
}
