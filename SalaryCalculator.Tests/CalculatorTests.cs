using SalaryCalculator.Exceptions;
using System.Collections.Generic;
using Xunit;

namespace SalaryCalculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(3)]
        [InlineData(100)]
        [InlineData(-1)]
        public void CalculateOverhoursAmount_For_InvalidMonth_Throws_InvalidMonth(int workedHours)
        {
            // Arrange
            var sut = new Calculator(GenerateMonthsWorkingHours());
            // Act & Assert
            Assert.Throws<InvalidMonth>(() => sut.CalculateOverhoursAmount(workedHours, 100));
        }

        private MonthsWorkingHours GenerateMonthsWorkingHours() => 
            new MonthsWorkingHours(new Dictionary<int, int> {
                { 1, 200},
                { 2, 150}
            });
    }
}
