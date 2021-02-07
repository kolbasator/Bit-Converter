using System;
using System.Collections.Generic;
using System.Text;

namespace Bit_Converter
{
    public class TripleNumber : INumber
    {
        public int System { get; } = 3; 
        public string WholePart { get; }
        public string FloatPart { get; }

        public TripleNumber(string wholePart, string floatPart)
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
