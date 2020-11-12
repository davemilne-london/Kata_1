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
        public void Return_RomanNumeral(string exp, uint input)
        {

            //Act
            var actual = Program.TranslateToRoman(input);

            //Assert
            Assert.Equal(exp, actual);

        }

    }
}
