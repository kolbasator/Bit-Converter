using System;
using System.Collections.Generic;
using System.Text;

namespace Bit_Converter
{
    public class FiveFoldNumber : INumber
    {
        public int System { get; } = 5;
        public string WholePart { get; }
        public string FloatPart { get; }

        public FiveFoldNumber(string wholePart,string floatPart)
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
