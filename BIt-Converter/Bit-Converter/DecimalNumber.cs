using System;
using System.Collections.Generic;
using System.Text;

namespace Bit_Converter
{
    public class DecimalNumber : INumber
    {
        public int System { get; } = 10;
        public string WholePart { get; }
        public string FloatPart { get; }

        public DecimalNumber(string wholePart, string floatPart)
        {
            WholePart = wholePart;
            FloatPart = floatPart;
        }

        public override string ToString()
        {
            return $"{WholePart}.{FloatPart}";
        }
    }
}
