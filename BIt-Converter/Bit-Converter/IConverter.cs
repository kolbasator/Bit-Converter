using System;
using System.Collections.Generic;
using System.Text;

namespace Bit_Converter
{
    public interface IConverter
    {
        INumber ConvertNumber(INumber number);
    }
}
