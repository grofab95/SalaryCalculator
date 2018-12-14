using System;
using System.Collections.Generic;
using Xunit;

namespace Parsers.Tests
{
    public class UserInputConsoleReaderTests
    {
        [Theory]
        [InlineData("?")]
        [InlineData("oneHundredFiftySeven")]
        [InlineData("strytdfy")]
        public void ValidateReadWorkedHours_For_InvalidUserInput_Throws_InvalidOperationException(string userInput)
        {
            Assert.Throws<FormatException> (() => StringParser.StringToDouble(userInput));
        }
        [Theory]
        [InlineData("@")]
        [InlineData("twentyTwo")]
        [InlineData("gifgker")]
        public void ValidateReadHourlyFee_For_InvalidUserInput_Throws_InvalidOperationException(string userInput)
        {
            Assert.Throws<FormatException>(() => StringParser.StringToDouble(userInput));
        }
        [Theory]
        [InlineData("%")]
        [InlineData("eleven")]
        [InlineData("tingnfs")]
        public void ValidateReadMonth_For_InvalidUserInput_Throws_InvalidOperationException(string userInput)
        {
            Assert.Throws<FormatException>(() => StringParser.StringToInt(userInput));
        }
    }
}
