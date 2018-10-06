using SalaryCalculator.Exceptions;

namespace SalaryCalculator
{
    public class InvalidMonthWorkingHoursConfiguration : SalaryCalculatorException
    {
        private static string exceptionMessage = 
            "Niepoprawna konfiguracja roboczogodzin na miesiąc.";

        public InvalidMonthWorkingHoursConfiguration() : base(exceptionMessage)
        {}
    }
}
