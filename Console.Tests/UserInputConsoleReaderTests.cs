using System;
using System.Collections.Generic;
using Xunit;

namespace Console.Tests
{
    public class UserInputConsoleReaderTests
    {
        [Theory]
        [InlineData("?")]
        [InlineData("oneHundredFiftySeven")]
        [InlineData("strytdfy")]
        public void ValidateReadWorkedHours_For_InvalidUserInput_Throws_InvalidOperationException(string userInput)
        {
            var exception = Record.Exception(() => StringParser.ParseToDoubleReadWorkedHours(userInput));
            Assert.NotNull(exception);
            Assert.IsType<FormatException>(exception);
        }
        [Theory]
        [InlineData("@")]
        [InlineData("twentyTwo")]
        [InlineData("gifgker")]
        public void ValidateReadHourlyFee_For_InvalidUserInput_Throws_InvalidOperationException(string userInput)
        {
            var exception = Record.Exception(() => StringParser.ParseToDoubleReadHourlyFee(userInput));
            Assert.NotNull(exception);
            Assert.IsType<FormatException>(exception);
        }
        [Theory]
        [InlineData("%")]
        [InlineData("eleven")]
        [InlineData("tingnfs")]
        public void ValidateReadMonth_For_InvalidUserInput_Throws_InvalidOperationException(string userInput)
        {
            var exception = Record.Exception(() => StringParser.ParseToIntReadMonth(userInput));
            Assert.NotNull(exception);
            Assert.IsType<FormatException>(exception);
        }
    }
}
