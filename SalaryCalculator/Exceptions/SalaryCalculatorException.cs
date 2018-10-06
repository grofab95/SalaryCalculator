using System;

namespace SalaryCalculator.Exceptions
{
    public class SalaryCalculatorException: Exception
    {
        public SalaryCalculatorException(string exceptionMessage) : base(exceptionMessage)
        {
        }
    }
}
