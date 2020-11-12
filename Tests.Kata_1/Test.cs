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
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("VII", 7)]
        [InlineData("VIII", 8)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        public void Return_RomanNumeral(string exp, uint input)
        {

            //Act
            var actual = Program.TranslateToRoman(input);

            //Assert
            Assert.Equal(exp, actual);

        }

    }
}
