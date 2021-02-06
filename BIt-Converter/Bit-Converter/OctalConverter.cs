using System;
using System.Collections.Generic;
using System.Text;

namespace Bit_Converter
{
    public class OctalConverter : IConverter
    {
        private const int _system = 8;
        public INumber ConvertNumber(INumber number)
        {
            INumber decimalNumber = ConverterAlgoritms.ConvertToDecimal(number, number.System);
            var result = ConverterAlgoritms.ConvertTo(decimalNumber, _system);
            return result;

        }
    }
}
