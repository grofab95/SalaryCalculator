using SalaryCalculator.Exceptions;

namespace SalaryCalculator
{
    public class InvalidMonthWorkingHoursConfiguration : SalaryCalculatorException
    {
        private static string exceptionMessage = 
            "Invalid month working hours configuration.";

        public InvalidMonthWorkingHoursConfiguration() : base(exceptionMessage)
        {}
    }
}
