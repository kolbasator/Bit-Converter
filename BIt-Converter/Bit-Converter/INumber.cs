using System;
using System.Collections.Generic;
using System.Text;

namespace Bit_Converter
{
    public interface INumber
    {
        int System { get; } 
        string WholePart { get; } 
        string FloatPart { get; }
        string ToString();
    }
}
