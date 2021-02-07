using System;
using System.Collections.Generic;
using System.Text;

namespace Bit_Converter
{
    public class BinaryNumber : INumber
    { 
        public int System { get; } = 2;
        public string WholePart { get; }
        public string FloatPart { get; }

        public BinaryNumber(string wholePart, string floatPart)
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
