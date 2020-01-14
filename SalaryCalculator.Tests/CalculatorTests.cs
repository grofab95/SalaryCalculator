using SalaryCalculator.Exceptions;
using System;
using System.Collections.Generic;
using Xunit;

namespace SalaryCalculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;        

        public CalculatorTests()
        {
            _calculator = new Calculator(GenerateMonthsWorkingHours());
        }

        private static MonthsWorkingHours GenerateMonthsWorkingHours() =>
           new MonthsWorkingHours(new Dictionary<int, int> {
                { 1, 200},
                { 2, 150}
           });

        [Theory]
        [InlineData(0)]
        [InlineData(13)]
        public void CalculateOverhoursAmount_For_WorkedMonth_Throws_InvalidMonth(int workedMonth)
        {
            Assert.Throws<InvalidMonth>(() => _calculator.CalculateOverhoursAmount(workedMonth, 100));
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(301)]
        public void CalculateOverhoursAmount_For_WorkedHours_Throws_InvalidWorkedHours(double workedHours)
        {
            Assert.Throws<InvalidWorkedHours>(() => _calculator.CalculateOverhoursAmount(7, workedHours));
        }

        [Fact]
        public void CalculateOverhoursAmount_For_ReturnedDateWhenOverHoursExist_Equal_OverHouseAmount()
        {
            var hoursInMonth = GenerateMonthsWorkingHours();
            var workedHours = 220;
            var actual = _calculator.CalculateOverhoursAmount(1, workedHours);
            var expected = workedHours - hoursInMonth[1];
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void CalculateOverhoursAmount_For_ReturnedDateWhenOverHoursNotExist_Equal_Zero()
        {
            var workedHours = 150;
            var actual = _calculator.CalculateOverhoursAmount(1, workedHours);
            var expected = 0;
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(1800)]
        [InlineData(2200)]
        [InlineData(2800)]
        public void CalculateTotalNetIncome_For_MathTotalGrossIncome_Equal_MathTotalGrossIncome(double totalGrossIncome)
        {
            var actual = _calculator.CalculateTotalNetIncome(totalGrossIncome);
            var expected = Math.Round(totalGrossIncome * Multipliers.NetToGrossIncomeFactor, 2);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(180, 25, 20)]
        [InlineData(210, 15, 20)]
        public void CalculateTotalGrossIncome_For_MathTotalNetIncome_Equal_MathTotalNetIncome(
         double workedHours,
         double hourlyFee,
         double overHoursGrossIncome)
        {
            var actual = _calculator.CalculateTotalGrossIncome(workedHours, hourlyFee, overHoursGrossIncome);
            var expected = Math.Round(workedHours * hourlyFee + overHoursGrossIncome, 2);
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void CalculateOverHoursNetIncome_For_MathOverHoursNetIncome_Equal_MathOverHoursNetIncome()
        {
            var actual = _calculator.CalculateOverHoursNetIncome(3000);
            var expected = Math.Round(3000 * Multipliers.NetToGrossIncomeFactor, 2);
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void CalculateOverHoursGrosstIncome_For_MathOverHoursGrossIncome_Equal_MathOverHoursGrossIncome()
        {
            var salaryFactors = new { overHoursAmount = 30, hourlyFee = 25 };
            var actual = _calculator.CalculateOverHoursGrossIncome(salaryFactors.overHoursAmount, salaryFactors.hourlyFee);
            var expected = Math.Round(salaryFactors.overHoursAmount * salaryFactors.hourlyFee * Multipliers.OverHoursMultiplayer, 2);
            Assert.Equal(actual, expected);
        }
    }
}
