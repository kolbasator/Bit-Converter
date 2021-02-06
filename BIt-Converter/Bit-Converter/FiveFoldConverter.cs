using System;
using System.Collections.Generic;
using System.Text;

namespace Bit_Converter
{
    public class FiveFoldConverter : IConverter
    {
        private const int _system = 5;
        public INumber ConvertNumber(INumber number)
        {
            INumber decimalNumber = ConverterAlgoritms.ConvertToDecimal(number, number.System);
            var result = ConverterAlgoritms.ConvertTo(decimalNumber, _system);
            return result;

        }
    }
}
