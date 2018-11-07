using SalaryCalculator.Exceptions;

namespace SalaryCalculator
{
    public static class InputValidations
    {
        public static void ValidateHourlyFee(double hourlyFee)
        {
            if(hourlyFee < 1 || hourlyFee > 1000)
            {
                throw new InvalidHourlyFee();
            }
        }

        public static void ValidateMonth(int monthNumber)
        {
            if(monthNumber < 1 || monthNumber > 12)
            {
                throw new InvalidMonth();
            }
        }

        public static void ValidateWorkedHours(double workedHours)
        {
            if (workedHours < 0 || workedHours > 300)
            {
                throw new InvalidWorkedHours();
            }
        }
    }
}
