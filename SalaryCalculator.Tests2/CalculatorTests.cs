
using SalaryCalculator.Exceptions;
using System;
using System.Collections.Generic;
using Xunit;

namespace SalaryCalculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(13)]
        [InlineData(3000)]
        [InlineData(-1)]
        // Co_Warunki_Wynik
        public void CalculateOverhoursAmount_For_InvalidMonth_Throws_InvalidMonth(int workedHours)
        {
            // Arrange
            var sut = new Calculator(GenerateMonthsWorkingHours());
            // Act & Assert
            Assert.Throws<InvalidMonth>(() => sut.CalculateOverhoursAmount(workedHours, 100));
        }

        [Theory]
        [InlineData(1800)]
        [InlineData(2200)]
        [InlineData(2800)]
        public void CalculateTotalNetIncome_For_MathTotalGrossIncome_Equal_MathTotalGrossIncome(double totalGrossIncome)
        {            
            var calculator = new Calculator(GenerateMonthsWorkingHours());
            var actual = calculator.CalculateTotalNetIncome(totalGrossIncome);
            var expected = Math.Round(totalGrossIncome * Multipliers.NetToGrossIncomeFactor, 2);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(180,25,20)]
        [InlineData(210,15,20)]
        public void CalculateTotalGrossIncome_For_MathTotalNetIncome_Equal_MathTotalNetIncome(
         double workedHours,
         double hourlyFee,
         double overHoursGrossIncome)
        {
            var calculator = new Calculator(GenerateMonthsWorkingHours());
            var actual = calculator.CalculateTotalGrossIncome(workedHours, hourlyFee, overHoursGrossIncome);
            var expected = Math.Round(workedHours * hourlyFee + overHoursGrossIncome, 2);
            Assert.Equal(actual, expected);
        }

        private MonthsWorkingHours GenerateMonthsWorkingHours() =>
            new MonthsWorkingHours(new Dictionary<int, int> {
                { 1, 200},
                { 2, 150}
            });
    }
}
