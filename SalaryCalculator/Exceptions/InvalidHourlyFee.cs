namespace SalaryCalculator.Exceptions
{
    public class InvalidHourlyFee : SalaryCalculatorException
    {
        private static string exceptionMessage =
            "Invalid hourly rate.";

        public InvalidHourlyFee() : base(exceptionMessage)
        { }
    }
}
