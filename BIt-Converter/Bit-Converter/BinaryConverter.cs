using System;
namespace Bit_Converter
{
    public class BinaryConverter : IConverter
    {
        private const int _system = 2;
        public INumber ConvertNumber(INumber number)
        {
            INumber decimalNumber = ConverterAlgoritms.ConvertToDecimal(number,number.System);
            var result = ConverterAlgoritms.ConvertTo(decimalNumber, _system);
            return result;

        }
    }
}
