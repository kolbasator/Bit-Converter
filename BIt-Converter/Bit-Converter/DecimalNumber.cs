using System;
using System.Collections.Generic;
using System.Text;

namespace Bit_Converter
{
    public class DecimalNumber : INumber
    {
        public int System { get; } = 10;
        public string WholePart { get; } 

        public DecimalNumber(string number)
        {
            string[] parts = number.Split('.');
            WholePart = parts[0]; 
        }

        public override string ToString()
        {
            return WholePart;
        }
    }
}
