using System;
using System.Collections.Generic;
using System.Text;

namespace Bit_Converter
{
    public class ConverterAlgoritms
    {

        public static INumber ConvertToDecimal(INumber number,int oldSystem)
        {
            if (number.System == 10)
                return number;
            double result = 0;
            string wholePart =number.WholePart;
            foreach (char num in wholePart)
                result = result * oldSystem + Char.GetNumericValue(num);
            return new DecimalNumber(Convert.ToString(result));
        }
        public static INumber ConvertTo(INumber numberForChange,int system)
        {
            if (numberForChange.System == system)
                return numberForChange;
            INumber number = ConvertToDecimal(numberForChange, numberForChange.System); 
            string wholePart = "";
            int wholePartNumber = Convert.ToInt32(number.WholePart);
            while (wholePartNumber > 0)
            {
                wholePart = Convert.ToString(wholePartNumber % system) + wholePart;
                wholePartNumber = wholePartNumber / system;
            }
            INumber result = number;
            switch (system)
            {
                case 2:
                    result = new BinaryNumber(wholePart);
                    break;
                case 3:
                    result = new TripleNumber(wholePart);
                    break;
                case 5:
                    result = new FiveFoldNumber(wholePart);
                    break;
                case 8:
                    result = new OctalNumber(wholePart);
                    break;
                case 12:
                    result = new TwelveDigitNumber(wholePart);
                    break;
            }
            return result;

        }
    }
}
