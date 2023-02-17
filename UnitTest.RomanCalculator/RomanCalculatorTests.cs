using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest.Calculator
{
    [TestClass]
    public class RomanCalculatorTests
    {
        private RomanCalculator _cut;

        [TestInitialize]
        public void Initialize()
        {
            _cut = new RomanCalculator();
        }

        [TestMethod]
        public void IntToRoman_ShouldReturnI_WhenInputIs1()
        {
            // Arrange
            var expected = "I";
            var input = 1;

            // Act
            var actual = _cut.IntToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_ShouldReturnIV_WhenInputIs4()
        {
            // Arrange
            var expected = "IV";
            var input = 4;

            // Act
            var actual = _cut.IntToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_ShouldReturnV_WhenInputIs5()
        {
            // Arrange
            var expected = "V";
            var input = 5;

            // Act
            var actual = _cut.IntToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_ShouldReturnIX_WhenInputIs9()
        {
            // Arrange
            var expected = "IX";
            var input = 9;

            // Act
            var actual = _cut.IntToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_ShouldReturnX_WhenInputIs10()
        {
            // Arrange
            var expected = "X";
            var input = 10;

            // Act
            var actual = _cut.IntToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_ShouldReturnXL_WhenInputIs40()
        {
            // Arrange
            var expected = "XL";
            var input = 40;

            // Act
            var actual = _cut.IntToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_ShouldReturnL_WhenInputIs50()
        {
            // Arrange
            var expected = "L";
            var input = 50;

            // Act
            var actual = _cut.IntToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_ShouldReturnXC_WhenInputIs90()
        {
            // Arrange
            var expected = "XC";
            var input = 90;

            // Act
            var actual = _cut.IntToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_ShouldReturnC_WhenInputIs100()
        {
            // Arrange
            var expected = "C";
            var input = 100;

            // Act
            var actual = _cut.IntToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_ShouldReturnCD_WhenInputIs400()
        {
            // Arrange
            var expected = "CD";
            var input = 400;

            // Act
            var actual = _cut.IntToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_ShouldReturnD_WhenInputIs500()
        {
            // Arrange
            var expected = "D";
            var input = 500;

            // Act
            var actual = _cut.IntToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_ShouldReturnCM_WhenInputIs900()
        {
            // Arrange
            var expected = "CM";
            var input = 900;

            // Act
            var actual = _cut.IntToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_ShouldReturnM_WhenInputIs1000()
        {
            // Arrange
            var expected = "M";
            var input = 1000;

            // Act
            var actual = _cut.IntToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_ShouldReturnMCMXCIX_WhenInputIs1999()
        {
            // Arrange
            var expected = "MCMXCIX";
            var input = 1999;

            // Act
            var actual = _cut.IntToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_ShouldReturnMMCDXLIV_WhenInputIs2444()
        {
            // Arrange
            var expected = "MMCDXLIV";
            var input = 2444;

            // Act
            var actual = _cut.IntToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_ShouldReturnMMMXMXCIX_WhenInputIs3999()
        {
            // Arrange
            var expected = "MMMCMXCIX";
            var input = 3999;

            // Act
            var actual = _cut.IntToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntToRoman_ShouldThrowNotImplementedException_WhenInputIs4000()
        {
            // Arrange
            var input = 4000;

            // Act & Assert
            Assert.ThrowsException<NotImplementedException>(() => _cut.IntToRoman(input));
        }

        [TestMethod]
        public void IntToRoman_ShouldThrowArgumentException_WhenInputIs0()
        {
            // Arrange
            var input = 0;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _cut.IntToRoman(input));
        }

        [TestMethod]
        public void IntToRoman_ShouldThrowArgumentException_WhenInputIsNegative()
        {
            // Arrange
            var input = -1;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _cut.IntToRoman(input));
        }

        [TestMethod]
        public void DecimalToRoman_ShouldReturnX_WhenInputIsNinePointFive()
        {
            // Arrange
            var expected = "X";
            var input = 9.5;

            // Act
            var actual = _cut.DecimalToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DecimalToRoman_ShouldReturnX_WhenInputIsThenPointFourNine()
        {
            // Arrange
            var expected = "X";
            var input = 10.49;

            // Act
            var actual = _cut.DecimalToRoman(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RomanToInt_ShouldReturn1_WhenInputIs1()
        {
            // Arrange
            var expected = 1;
            var input = "I";

            // Act
            var actual = _cut.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RomanToInt_ShouldReturn4_WhenInputIsIV()
        {
            // Arrange
            var expected = 4;
            var input = "IV";

            // Act
            var actual = _cut.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RomanToInt_ShouldReturn5_WhenInputIsV()
        {
            // Arrange
            var expected = 5;
            var input = "V";

            // Act
            var actual = _cut.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RomanToInt_ShouldReturn9_WhenInputIsIX()
        {
            // Arrange
            var expected = 9;
            var input = "IX";

            // Act
            var actual = _cut.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RomanToInt_ShouldReturn10_WhenInputIsX()
        {
            // Arrange
            var expected = 10;
            var input = "X";

            // Act
            var actual = _cut.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RomanToInt_ShouldReturn40_WhenInputIsXL()
        {
            // Arrange
            var expected = 40;
            var input = "XL";

            // Act
            var actual = _cut.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RomanToInt_ShouldReturn50_WhenInputIsL()
        {
            // Arrange
            var expected = 50;
            var input = "L";

            // Act
            var actual = _cut.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RomanToInt_ShouldReturn90_WhenInputIsXC()
        {
            // Arrange
            var expected = 90;
            var input = "XC";

            // Act
            var actual = _cut.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RomanToInt_ShouldReturn100_WhenInputIsC()
        {
            // Arrange
            var expected = 100;
            var input = "C";

            // Act
            var actual = _cut.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RomanToInt_ShouldReturn400_WhenInputIsCD()
        {
            // Arrange
            var expected = 400;
            var input = "CD";

            // Act
            var actual = _cut.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RomanToInt_ShouldReturn500_WhenInputIsD()
        {
            // Arrange
            var expected = 500;
            var input = "D";

            // Act
            var actual = _cut.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RomanToInt_ShouldReturn900_WhenInputIsCM()
        {
            // Arrange
            var expected = 900;
            var input = "CM";

            // Act
            var actual = _cut.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RomanToInt_ShouldReturn1000_WhenInputIsM()
        {
            // Arrange
            var expected = 1000;
            var input = "M";

            // Act
            var actual = _cut.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RomanToInt_ShouldReturn1999_WhenInputIsMCMXCIX()
        {
            // Arrange
            var expected = 1999;
            var input = "MCMXCIX";

            // Act
            var actual = _cut.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RomanToInt_ShouldReturn2444_WhenInputIsMMCDXLIV()
        {
            // Arrange
            var expected = 2444;
            var input = "MMCDXLIV";

            // Act
            var actual = _cut.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RomanToInt_ShouldReturn3999_WhenInputIsMMMXMXCIX()
        {
            // Arrange
            var expected = 3999;
            var input = "MMMCMXCIX";

            // Act
            var actual = _cut.RomanToInt(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RomanToInt_ShouldThrowArgumentException_WhenInputIsNull()
        {
            // Arrange, Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _cut.RomanToInt(null));
        }

        [TestMethod]
        public void RomanToInt_ShouldThrowArgumentException_WhenInputIsWhiteSpace()
        {
            // Arrange
            var input = " ";

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _cut.RomanToInt(input));
        }

        [TestMethod]
        public void RomanToInt_ShouldThrowArgumentException_WhenInputIsIIII()
        {
            // Arrange
            var input = "IIII";

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _cut.RomanToInt(input));
        }

        [TestMethod]
        public void RomanToInt_ShouldThrowArgumentException_WhenInputIsXXXX()
        {
            // Arrange
            var input = "XXXX";

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _cut.RomanToInt(input));
        }

        [TestMethod]
        public void RomanToInt_ShouldThrowArgumentException_WhenInputIsCCCC()
        {
            // Arrange
            var input = "CCCC";

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _cut.RomanToInt(input));
        }

        [TestMethod]
        public void RomanToInt_ShouldThrowArgumentException_WhenInputIsVV()
        {
            // Arrange
            var input = "VV";

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _cut.RomanToInt(input));
        }

        [TestMethod]
        public void RomanToInt_ShouldThrowArgumentException_WhenInputIsLL()
        {
            // Arrange
            var input = "LL";

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _cut.RomanToInt(input));
        }

        [TestMethod]
        public void RomanToInt_ShouldThrowArgumentException_WhenInputIsDD()
        {
            // Arrange
            var input = "DD";

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _cut.RomanToInt(input));
        }
    }
}