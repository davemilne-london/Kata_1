using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Kata_1_Code;

namespace Kata_1_Tests
{
    public class Test
    {

        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(13, "XIII")]
        [InlineData(14, "XIV")]
        [InlineData(27, "XXVII")]
        [InlineData(31, "XXXI")]
        [InlineData(39, "XXXIX")]
        [InlineData(40, "XL")]
        [InlineData(45, "XLV")]
        [InlineData(49, "XLIX")]
        [InlineData(50, "L")]
        [InlineData(66, "LXVI")]
        [InlineData(84, "LXXXIV")]
        [InlineData(90, "XC")]
        [InlineData(97, "XCVII")]
        [InlineData(100, "C")]
        [InlineData(174, "CLXXIV")]
        [InlineData(259, "CCLIX")]
        [InlineData(347, "CCCXLVII")]
        [InlineData(399, "CCCXCIX")]
        public void Return_RomanNumeral(uint input, string exp)
        {

            //Act
            var actual = Program.TranslateToRoman(input);

            //Assert
            Assert.Equal(exp, actual);

        }

    }
}
