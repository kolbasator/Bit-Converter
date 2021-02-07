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
            double wholePartNumber = 0;
            double floatPartNumber = 0;
            string wholePart =number.WholePart;
            string floatPart =number.FloatPart;
            foreach (char num in wholePart)
                wholePartNumber = wholePartNumber * oldSystem + Char.GetNumericValue(num); 
            foreach (char num in floatPart)
                floatPartNumber = floatPartNumber * oldSystem + Char.GetNumericValue(num);
            return new DecimalNumber(Convert.ToString(wholePartNumber),Convert.ToString(floatPartNumber));
        }
        public static INumber ConvertTo(INumber numberForChange,int system)
        {
            if (numberForChange.System == system)
                return numberForChange;
            INumber number = ConvertToDecimal(numberForChange, numberForChange.System); 
            string wholePart = "";
            int wholePartNumber = Convert.ToInt32(number.WholePart); 
            string floatPart = "";
            int floatPartNumber = Convert.ToInt32(number.FloatPart);
            while (wholePartNumber > 0)
            {
                wholePart = Convert.ToString(wholePartNumber % system) + wholePart;
                wholePartNumber = wholePartNumber / system;
            }
            while (floatPartNumber > 0)
            {
                floatPart = Convert.ToString(floatPartNumber % system) + floatPart;
                floatPartNumber = floatPartNumber / system;
            }
            INumber result = number;
            switch (system)
            {
                case 2:
                    result = new BinaryNumber(wholePart, floatPart);
                    break;
                case 3:
                    result = new TripleNumber(wholePart, floatPart);
                    break;
                case 5:
                    result = new FiveFoldNumber(wholePart, floatPart);
                    break;
                case 8:
                    result = new OctalNumber(wholePart, floatPart);
                    break; 
            }
            return result;

        }
    }
}
