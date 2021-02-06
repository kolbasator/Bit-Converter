using System;

namespace Bit_Converter
{
    class Program
    {
        static void Main(string[] args)
        { 
            INumber number = new DecimalNumber("123.456");
            IConverter converter = new BinaryConverter();
            Console.WriteLine(converter.ConvertNumber(number).ToString());
            Console.ReadLine();
        }
    } 
}
