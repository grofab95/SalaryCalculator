namespace SalaryCalculator.Exceptions
{
    public class InvalidHourlyFee : SalaryCalculatorException
    {
        private static string exceptionMessage =
            "Niepoprawna stawka godzinowa.";

        public InvalidHourlyFee() : base(exceptionMessage)
        { }
    }
}
