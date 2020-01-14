using SalaryCalculator.SalaryReport;
using Xunit;

namespace SalaryCalculator.Tests
{
    public class FactorsTests
    {
        private readonly Factors _factors;

        public FactorsTests()
        {
            _factors = new Factors();
        }

        [Fact]
        public void Prop_WorkedMonth_For_Type_Equal_Int()
        {
            var actual = _factors.WorkedMonth.GetType();
            var expected = typeof(int);
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Prop_WorkedHours_For_Type_Equal_Double()
        {
            var actual = _factors.WorkedHours.GetType();
            var expected = typeof(double);
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Prop_HourlyFee_For_Type_Equal_Double()
        {
            var actual = _factors.HourlyFee.GetType();
            var expected = typeof(double);
            Assert.Equal(actual, expected);
        }
    }
}
