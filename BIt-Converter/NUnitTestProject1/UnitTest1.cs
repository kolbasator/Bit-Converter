using NUnit.Framework; 
using Bit_Converter;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BinaryConverterTest()
        { 
            INumber number = new DecimalNumber("123");
            IConverter converter = new BinaryConverter();
            Assert.AreEqual(converter.ConvertNumber(number).ToString(), "1111011.011101001");
        }
    }
}