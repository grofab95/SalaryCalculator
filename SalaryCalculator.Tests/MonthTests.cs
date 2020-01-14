using Xunit;

namespace SalaryCalculator.Tests
{
    public class MonthTests
    {
        [Fact]
        public void NumberToName_For_MonthNumber_Expected_MonthName()
        {
            var actual = Month.NumberToName(2);
            var expected = "Luty";
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void NameToNumber_For_MonthName_Expected_MonthNumber()
        {
            var actual = Month.NameToNumber("Luty");
            var expected = 1;
            Assert.Equal(actual, expected);
        }

    }
}
