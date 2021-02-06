using System;
using System.Collections.Generic;
using System.Text;

namespace Bit_Converter
{
    public class OctalNumber : INumber 
    {
        public int System { get; } = 8;
        public string WholePart { get; }

        public OctalNumber(string wholePart)
        {
            WholePart = wholePart;
        }

        public override string ToString()
        {
            return WholePart;
        }
    }
}
