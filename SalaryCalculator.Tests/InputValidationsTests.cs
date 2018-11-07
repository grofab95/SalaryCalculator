using SalaryCalculator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SalaryCalculator.Tests2
{
    public class InputValidationsTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-10)]
        [InlineData(1050)]
        public void ValidateHourlyFee_For_InvalidHourlyFee_Throws_InvalidHourlyFee(double hourlyFee)
        {
            Assert.Throws<InvalidHourlyFee>(() => InputValidations.ValidateHourlyFee(hourlyFee));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(13)]
        public void ValidateMonth_For_InvalidMonth_Throws_InvalidMonth(int monthNumber)
        {
            Assert.Throws<InvalidMonth>(() => InputValidations.ValidateMonth(monthNumber));
        }
        [Theory]
        [InlineData(-10)]
        [InlineData(301)]
        public void ValidateWorkedHours_For_InvalidWorkedHours_Throws_InvalidWorkedHours(double workedHours)
        {
            Assert.Throws<InvalidWorkedHours>(() => InputValidations.ValidateWorkedHours(workedHours));
        }
    }

}
