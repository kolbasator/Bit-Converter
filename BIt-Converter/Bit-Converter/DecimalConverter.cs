using System;
using System.Collections.Generic;
using System.Text;

namespace Bit_Converter
{
    public class DecimalConverter : IConverter
    {
        private const int _system = 10;
        public INumber ConvertNumber(INumber number)
        {
            INumber decimalNumber = ConverterAlgoritms.ConvertToDecimal(number, number.System); 
            return decimalNumber;

        }
    }
}
