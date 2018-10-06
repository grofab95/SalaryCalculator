using System;

namespace SalaryCalculator
{
    public class Calculator
    {
        private readonly MonthsWorkingHours _monthsWorkingHours;

        public Calculator(MonthsWorkingHours monthsWorkingHours)
        {
            _monthsWorkingHours = monthsWorkingHours;
        }

        public double CalculateOverhoursAmount(int workedMonth, double workedHours)
        {
            InputValidations.ValidateMonth(workedMonth);
            InputValidations.ValidateWorkedHours(workedHours);
            return _monthsWorkingHours[workedMonth] < workedHours
                ? workedHours - _monthsWorkingHours[workedMonth]
                : 0;
        }

        public double CalculateTotalNetIncome(double totalGrossIncome) =>
            Math.Round(totalGrossIncome * Multipliers.NetToGrossIncomeFactor, 2);

        public double CalculateTotalGrossIncome(
         double workedHours,
         double hourlyFee,
         double overHoursGrossIncome) =>
         Math.Round(workedHours * hourlyFee + overHoursGrossIncome, 2);

        public double CalculateOverHoursNetIncome(double overHoursGrossIncome) =>
            Math.Round(overHoursGrossIncome * Multipliers.NetToGrossIncomeFactor, 2);

        public double CalculateOverHoursGrossIncome(double overHoursAmount, double hourlyFee)
        {
            InputValidations.ValidateHourlyFee(hourlyFee);
            return Math.Round(hourlyFee * overHoursAmount * Multipliers.OverHoursMultiplayer, 2);
        }
    }
}
