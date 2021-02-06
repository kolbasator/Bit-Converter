using System;
using System.Collections.Generic;
using System.Text;

namespace Bit_Converter
{
    public class TripleNumber : INumber
    {
        public int System { get; } = 3;
        public string WholePart { get; }

        public TripleNumber(string wholePart)
        {
            WholePart = wholePart;
        }

        public override string ToString()
        {
            return WholePart;
        }
    }
}
