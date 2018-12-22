using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Parsers;
using SalaryCalculator.SalaryReport;

namespace SalaryCalculator.Desktop
{
    public partial class CalculatorMainWindow : Form
    {
        private MonthsWorkingHours _monthsWorkingHours;
        public CalculatorMainWindow()
        {
            LoadMonthConfig();
            InitializeComponent();
            FillMonthsList(_monthsWorkingHours);       
        }

        private void FillMonthsList(MonthsWorkingHours monthsWorkingHoursConfiguration)
        {
            MonthsDropDown.DataSource = Enumerable.Range(1, 12).Select(monthNo =>
            {
                var monthWorkingHours = monthsWorkingHoursConfiguration[monthNo];
                return new
                {
                    MonthName = $"{Month.NumberToName(monthNo)} ({monthWorkingHours}h)",
                    Hours = monthsWorkingHoursConfiguration[monthNo]
                };
            }).ToList();
            MonthsDropDown.DisplayMember = "MonthName";
            MonthsDropDown.ValueMember = "Hours";
        }

        private void LoadMonthConfig()
        {
            var monthsWorkingHoursConfiguration =
                JsonFileConverter.JsonFileConverter.ConvertFromFile<Dictionary<int, int>>
                    ($"{MonthConfigPaths.MonthConfig}.json");
            _monthsWorkingHours = new MonthsWorkingHours(monthsWorkingHoursConfiguration);
        }

        private void CalculateAndShowSalaryReport(object sender, EventArgs e)
        {
            var factors = new Factors
            {
                WorkedHours = StringParser.StringToDouble(
                    string.IsNullOrEmpty(WorkedHours.Text) ? throw new Exception() : WorkedHours.Text),
                HourlyFee = StringParser.StringToDouble(HourlyFee.Text
                                                        ?? throw new ArgumentNullException(nameof(HourlyFee))),
                WorkedMonth = MonthsDropDown.SelectedIndex + 1
            };
            var monthSalaryReport = new MonthSalaryReport(_monthsWorkingHours, factors);
            var textReport = new SimpleTextReportBuilder()
                .BuildMontlhyReport(monthSalaryReport);
            new CalculatorReportWindow(textReport).ShowDialog();
        }

        private void ShowAboutWindow(object sender, EventArgs e) =>
            MessageBox.Show($"{TextualRessources.Author}: Fabian Grochla, {TextualRessources.Version}: {Assembly.GetExecutingAssembly().GetName().Version}");

        private void Exit(object sender, EventArgs e) => Application.Exit();

        private void ShowConfigurationWindow(object sender, EventArgs e) =>
            new MonthConfigEditorWindow(_monthsWorkingHours).ShowDialog();
    }
}
