using System.Collections.Generic;
using Xunit;

namespace SalaryCalculator.Tests
{
    public class MonthsWorkingHoursTests
    {
        [Theory]
        [InlineData(99)]
        [InlineData(201)]
        public void ValidateWorkingHoursRange_For_WorkingHours_Throws_InvalidMonthWorkingHoursConfiguration(int workingHours)
        {
            Assert.Throws<InvalidMonthWorkingHoursConfiguration>(() => new MonthsWorkingHours(new Dictionary<int, int> { { 1, workingHours } }));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(13)]
        public void ValidateMonthNumberRange_For_MonthNumber_Throws_InvalidMonthWorkingHoursConfiguration(int monthNumber)
        {
            Assert.Throws<InvalidMonthWorkingHoursConfiguration>(() => new MonthsWorkingHours(new Dictionary<int, int> { { monthNumber, 150 } }));
        }
    }
}
