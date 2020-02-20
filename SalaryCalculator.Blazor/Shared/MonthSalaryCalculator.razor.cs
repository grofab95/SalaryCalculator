using Microsoft.AspNetCore.Components;
using Parsers;
using SalaryCalculator.Blazor.Helpers;
using SalaryCalculator.SalaryReport;
using System;
using System.Collections.Generic;

namespace SalaryCalculator.Blazor.Shared
{
    public partial class MonthSalaryCalculator
    {
        [Inject] MonthsWorkingHours MonthsWorkingHours { get; set; }
        [Inject] Calculator Calc { get; set; }
        private CalculationsSummary _summary { get; set; }
        private Factors _factors = new Factors();
        private MonthSalaryReport _monthSalaryReport;
        private string _errorMessage;
        private Dictionary<int, MonthsDropDownItem> _dataToSelect;

        protected override void OnInitialized()
        {
            _dataToSelect = GenerateDataToSelect();
        }

        private Dictionary<int, MonthsDropDownItem> GenerateDataToSelect()
        {
            var data = new Dictionary<int, MonthsDropDownItem>();
            for (int i = 1; i < 13; i++)
            {
                data.Add(i,
                    new MonthsDropDownItem { MonthName = Month.NumberToName(i), WorkingHours = MonthsWorkingHours[i] });
            }
            return data;
        }

        private void Calculate()
        {
            _summary = new CalculationsSummary();
            try
            {
                StringParser.StringToDouble(_factors.WorkedMonth.ToString());
                StringParser.StringToDouble(_factors.HourlyFee.ToString());
                _summary.OverHoursAmount = Calc.CalculateOverhoursAmount(_factors.WorkedMonth, _factors.WorkedHours);
                _summary.OverHoursGrossIncome = Calc.CalculateOverHoursGrossIncome(_summary.OverHoursAmount, _factors.HourlyFee);
                _summary.OverHoursNetIncome = Calc.CalculateOverHoursNetIncome(_summary.OverHoursGrossIncome);
                _summary.TotalGrossIncome = Calc.CalculateTotalGrossIncome(
                    _factors.WorkedHours, _factors.HourlyFee, _summary.OverHoursGrossIncome);
                _summary.TotalNetIncome = Calc.CalculateTotalNetIncome(_summary.TotalGrossIncome);
                _monthSalaryReport = new MonthSalaryReport(MonthsWorkingHours, _factors);
            }
            catch (Exception excteption)
            {
                _errorMessage = excteption.Message;
            }
        }
    }
}
