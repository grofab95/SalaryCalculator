using SalaryCalculator.SalaryReport;
using System;
using Xunit;

namespace SalaryCalculator.Tests
{
    public class CalculationsSummaryTests
    {
        private readonly CalculationsSummary _calculationsSummary;
        public CalculationsSummaryTests()
        {
            _calculationsSummary = new CalculationsSummary();
        }

        [Fact]
        public void Prop_OverHoursAmount_For_AccessModifiers_Equal_Double()
        {
            var actual = _calculationsSummary.OverHoursAmount.GetType();
            var expected = typeof(double);
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Prop_OverHoursGrossIncome_For_AccessModifiers_Equal_Double()
        {
            var actual = _calculationsSummary.OverHoursGrossIncome.GetType();
            var expected = typeof(double);
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Prop_OverHoursNetIncome_For_AccessModifiers_Equal_Double()
        {
            var actual = _calculationsSummary.OverHoursNetIncome.GetType();
            var expected = typeof(double);
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Prop_TotalGrossIncome_For_AccessModifiers_Equal_Double()
        {
            var actual = _calculationsSummary.TotalGrossIncome.GetType();
            var expected = typeof(double);
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Prop_TotalNetIncome_For_AccessModifiers_Equal_Double()
        {
            var actual = _calculationsSummary.TotalNetIncome.GetType();
            var expected = typeof(double);
            Assert.Equal(actual, expected);
        }
    }
}
