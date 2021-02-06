using System;
using System.Collections.Generic;
using System.Text;

namespace Bit_Converter
{
    public class BinaryNumber : INumber
    { 
        public int System { get; } = 2;
        public string WholePart { get; } 

        public BinaryNumber(string wholePart )
        {
            WholePart = wholePart; 
        }

        public override string ToString()
        {
            return WholePart ;
        }
    }
}
