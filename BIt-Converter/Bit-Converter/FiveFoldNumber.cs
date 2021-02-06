using System;
using System.Collections.Generic;
using System.Text;

namespace Bit_Converter
{
    public class FiveFoldNumber : INumber
    {
        public int System { get; } = 5;
        public string WholePart { get; }

        public FiveFoldNumber(string wholePart)
        {
            WholePart = wholePart;
        }

        public override string ToString()
        {
            return WholePart;
        }
    }
}
