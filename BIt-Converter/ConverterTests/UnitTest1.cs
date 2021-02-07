using NUnit.Framework;
using Bit_Converter;

namespace ConverterTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BinaryToDecimalTest()
        {
            INumber decimalNumber = new DecimalNumber("10","10");
            IConverter bc = new BinaryConverter();
            IConverter decimalConverter = new DecimalConverter();
            INumber binaryNumber = bc.ConvertNumber(decimalNumber);
            Assert.AreEqual("1010.1010", binaryNumber.ToString());
            binaryNumber = decimalConverter.ConvertNumber(binaryNumber);
            Assert.AreEqual("10.10", binaryNumber.ToString());  
        }
        [Test]
        public void TripleToDecimalTest()
        {
            INumber decimalNumber = new DecimalNumber("10", "10");
            IConverter tc = new TripleNumberConverter();
            IConverter decimalConverter = new DecimalConverter();
            INumber tripleNumber = tc.ConvertNumber(decimalNumber);
            Assert.AreEqual("101.101", tripleNumber.ToString());
            tripleNumber = decimalConverter.ConvertNumber(tripleNumber);
            Assert.AreEqual("10.10",tripleNumber.ToString());
        }

        [Test]
        public void FiveFoldToDecimalTest()
        {
            INumber decimalNumber = new DecimalNumber("10", "10");
            IConverter fc = new FiveFoldConverter();
            IConverter decimalConverter = new DecimalConverter();
            INumber fivefoldNumber = fc.ConvertNumber(decimalNumber);
            Assert.AreEqual("20.20", fivefoldNumber.ToString());
            fivefoldNumber = decimalConverter.ConvertNumber(fivefoldNumber);
            Assert.AreEqual("10.10", fivefoldNumber.ToString());
        }
        [Test]
        public void OctalToDecimalTest()
        {
            INumber decimalNumber = new DecimalNumber("10", "10");
            IConverter oc = new OctalConverter();
            IConverter decimalConverter = new DecimalConverter();
            INumber octalNumber = oc.ConvertNumber(decimalNumber);
            Assert.AreEqual("12.12", octalNumber.ToString());
            octalNumber = decimalConverter.ConvertNumber(octalNumber);
            Assert.AreEqual("10.10", octalNumber.ToString());
        }
        [Test]
         
    }
}