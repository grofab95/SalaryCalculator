using System;
using System.Collections.Generic;

namespace KalkulatorWynagrodzen
{
    public class FeCalculator
    {
        private readonly Dictionary<int, int> MonthsWorkingHours;
         FeCalculator()
        {
            MonthsWorkingHours = new ConfigurationFileInterpreter<Dictionary<int, int>>("MonthConfig.json")
                .InterpretConfiguration();
        }
        public double CalculateOverhoursAmount(int workedMonth, double workedHours) =>
            MonthsWorkingHours[workedMonth] < workedHours
                ? workedHours - MonthsWorkingHours[workedMonth]
                : 0;

        public double CalculateTotalNetIncome(double totalGrossIncome) =>
                 Math.Round(totalGrossIncome * Multipliers.NetToGrossIncomeFactor, 2);

        public double CalculateTotalGrossIncome(
            double workedHours,
            double hourlyFee,
            double overHoursGrossIncome) =>
            Math.Round(workedHours * hourlyFee + overHoursGrossIncome, 2);

        public double CalculateOverHoursNetIncome(double overHoursGrossIncome) =>
            Math.Round(overHoursGrossIncome * Multipliers.NetToGrossIncomeFactor, 2);

        public double CalculateOverHoursGrossIncome(double overHoursAmount, double hourlyFee) =>
            Math.Round(hourlyFee * overHoursAmount * Multipliers.OverHoursMultiplayer, 2);
    }
}
