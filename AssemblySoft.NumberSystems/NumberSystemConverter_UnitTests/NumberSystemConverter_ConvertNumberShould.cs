using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSystemConverter;

namespace NumberSystemConverter_UnitTests
{
    [TestClass]
    public class NumberSystemConverter_ConvertNumberShould
    {
        #region RomanNumerals
        // [TestMethod]
        // public void ThrowIndexOutOfRangeWhenInputGreaterThan3000()
        // {
        //     var converter = new RomanNumeralsConverter();

        //     Assert.ThrowsException<IndexOutOfRangeException>(() => converter.ConvertNumber(3001));
        // }

        // [TestMethod]
        // public void ThrowIndexOutOfRangeWhenInputLessThan1()
        // {
        //     var converter = new RomanNumeralsConverter();

        //     Assert.ThrowsException<IndexOutOfRangeException>(() => converter.ConvertNumber(0));
        // }

        // [TestMethod]
        // public void ReturnIWhenInputIs1()
        // {
        //     var converter = new RomanNumeralsConverter();

        //     Assert.AreEqual("I", converter.ConvertNumber(1));
        // }


        // [TestMethod]
        // public void ReturnMMMVWhenInputIs3000()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     var result = converter.ConvertNumber(3000);

        //     Assert.AreEqual(result, "MMM");
        // }
        // [TestMethod]
        // public void ReturnIVWhenInputIs4()
        // {
        //     var converter = new RomanNumeralsConverter();

        //     Assert.AreEqual("IV", converter.ConvertNumber(4));
        // }

        // [TestMethod]
        // public void ReturnMMXIIIWhenInputIs2013()
        // {
        //     var converter = new RomanNumeralsConverter();

        //     Assert.AreEqual("MMXIII", converter.ConvertNumber(2013));
        // }


        // [TestMethod]
        // public void ReturnIIWhenInputIs2()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("II", converter.ConvertNumber(2));
        // }

        // [TestMethod]
        // public void ReturnIIIWhenInputIs3()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("III", converter.ConvertNumber(3));
        // }

        // [TestMethod]
        // public void ReturnVWhenInputIs5()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("V", converter.ConvertNumber(5));
        // }

        // [TestMethod]
        // public void ReturnVIWhenInputIs6()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("VI", converter.ConvertNumber(6));
        // }

        // [TestMethod]
        // public void ReturnVIIWhenInputIs7()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("VII", converter.ConvertNumber(7));
        // }

        // [TestMethod]
        // public void ReturnVIIIWhenInputIs8()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("VIII", converter.ConvertNumber(8));
        // }

        // [TestMethod]
        // public void ReturnIXWhenInputIs9()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("IX", converter.ConvertNumber(9));
        // }

        // [TestMethod]
        // public void ReturnXWhenInputIs10()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("X", converter.ConvertNumber(10));
        // }

        // [TestMethod]
        // public void ReturnXXWhenInputIs20()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("XX", converter.ConvertNumber(20));
        // }

        // [TestMethod]
        // public void ReturnXXXWhenInputIs30()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("XXX", converter.ConvertNumber(30));
        // }

        // [TestMethod]
        // public void ReturnXLWhenInputIs40()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("XL", converter.ConvertNumber(40));
        // }

        // [TestMethod]
        // public void ReturnLWhenInputIs50()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("L", converter.ConvertNumber(50));
        // }

        // [TestMethod]
        // public void ReturnLXWhenInputIs60()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("LX", converter.ConvertNumber(60));
        // }

        // [TestMethod]
        // public void ReturnLXXWhenInputIs70()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("LXX", converter.ConvertNumber(70));
        // }

        // [TestMethod]
        // public void ReturnLXXXWhenInputIs80()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("LXXX", converter.ConvertNumber(80));
        // }

        // [TestMethod]
        // public void ReturnXCWhenInputIs90()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("XC", converter.ConvertNumber(90));
        // }

        // [TestMethod]
        // public void ReturnCWhenInputIs100()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("C", converter.ConvertNumber(100));
        // }

        // [TestMethod]
        // public void ReturnCCWhenInputIs200()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("CC", converter.ConvertNumber(200));
        // }

        // [TestMethod]
        // public void ReturnCCCWhenInputIs300()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("CCC", converter.ConvertNumber(300));
        // }

        // [TestMethod]
        // public void ReturnCDWhenInputIs400()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("CD", converter.ConvertNumber(400));
        // }

        // [TestMethod]
        // public void ReturnDWhenInputIs500()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("D", converter.ConvertNumber(500));
        // }

        // [TestMethod]
        // public void ReturnDCWhenInputIs600()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("DC", converter.ConvertNumber(600));
        // }

        // [TestMethod]
        // public void ReturnDCCWhenInputIs700()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("DCC", converter.ConvertNumber(700));
        // }

        // [TestMethod]
        // public void ReturnDCCCWhenInputIs800()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("DCCC", converter.ConvertNumber(800));
        // }

        // [TestMethod]
        // public void ReturnCMWhenInputIs900()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("CM", converter.ConvertNumber(900));
        // }

        // [TestMethod]
        // public void ReturnMWhenInputIs1000()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("M", converter.ConvertNumber(1000));
        // }

        // [TestMethod]
        // public void ReturnMMWhenInputIs2000()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("MM", converter.ConvertNumber(2000));
        // }

        // [TestMethod]
        // public void ReturnMMMWhenInputIs3000()
        // {
        //     var converter = new RomanNumeralsConverter();
        //     Assert.AreEqual("MMM", converter.ConvertNumber(3000));
        // }
        #endregion

        #region ArabicNumerals

        [TestMethod]
        public void ThrowIndexOutOfRangeWhenInputNotIVXLCDM()
        {
            var converter = new ArabicNumberConverter();

            Assert.ThrowsException<IndexOutOfRangeException>(() => converter.ConvertNumber("W"));
        }
        [TestMethod]

        public void OutputEquals1IfInputEqualsI()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(1, converter.ConvertNumber("I"));
        }

        [TestMethod]

        public void OutputEquals5IfInputEqualsV()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(5, converter.ConvertNumber("V"));
        }

        [TestMethod]

        public void OutputEquals4IfInputEqualsIV()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(4, converter.ConvertNumber("IV"));
        }

        [TestMethod]

        public void OutputEquals9IfInputEqualsIX()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(9, converter.ConvertNumber("IX"));
        }

        // 10 to 90

        [TestMethod]

        public void OutputEquals10IfInputEqualsX()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(10, converter.ConvertNumber("X"));
        }

        [TestMethod]

        public void OutputEquals40IfInputEqualsXL()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(40, converter.ConvertNumber("XL"));
        }

        [TestMethod]

        public void OutputEquals50IfInputEqualsL()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(50, converter.ConvertNumber("L"));
        }

        [TestMethod]

        public void OutputEquals90IfInputEqualsXC()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(90, converter.ConvertNumber("XC"));
        }

        // 100 to 900
        [TestMethod]

        public void OutputEquals100IfInputEqualsC()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(100, converter.ConvertNumber("C"));
        }

        [TestMethod]

        public void OutputEquals400IfInputEqualsCD()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(400, converter.ConvertNumber("CD"));
        }

        [TestMethod]

        public void OutputEquals500IfInputEqualsD()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(500, converter.ConvertNumber("D"));
        }

        [TestMethod]

        public void OutputEquals900IfInputEqualsCM()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(900, converter.ConvertNumber("CM"));
        }

        // 1000 to 2000
        [TestMethod]

        public void OutputEquals1000IfInputEqualsM()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(1000, converter.ConvertNumber("M"));
        }

        [TestMethod]

        public void OutputEquals2000IfInputEqualsMM()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(2000, converter.ConvertNumber("MM"));
        }

        // Other tests
        [TestMethod]

        public void OutputEquals3000IfInputEqualsMMM()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(3000, converter.ConvertNumber("MMM"));
        }

        [TestMethod]

        public void OutputEquals55IfInputEqualsLV()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(55, converter.ConvertNumber("LV"));
        }

        [TestMethod]

        public void OutputEquals511IfInputEqualsDXI()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(511, converter.ConvertNumber("DXI"));
        }

        [TestMethod]

        public void OutputEquals102IfInputEqualsCII()
        {
            var converter = new ArabicNumberConverter();

            Assert.AreEqual(102, converter.ConvertNumber("CII"));
        }
        #endregion
    }
}