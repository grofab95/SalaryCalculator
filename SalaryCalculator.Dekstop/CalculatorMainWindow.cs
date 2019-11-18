using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Parsers;
using SalaryCalculator.Desktop.Ressources;
using SalaryCalculator.Desktop.Ressources.Errors;
using SalaryCalculator.SalaryReport;

namespace SalaryCalculator.Desktop
{
    public partial class CalculatorMainWindow : Form
    {
        private MonthsWorkingHours _monthsWorkingHours;
        public CalculatorMainWindow()
        {
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.CurrentCulture;
            InitializeComponent();
            _monthsWorkingHours = LoadMonthsWorkingHoursFromConfiguration();
            FillMonthsList(_monthsWorkingHours);
            ConfigureMonthsDropDownMember();
            this.Localize();
        }

        private MonthsWorkingHours LoadMonthsWorkingHoursFromConfiguration()
        {
            var monthsWorkingHoursConfiguration =
                JsonFileConverter.JsonFileConverter.ConvertFromFile<Dictionary<int, int>>
                    ("MonthConfig.json");
            return new MonthsWorkingHours(monthsWorkingHoursConfiguration);
        }

        private void FillMonthsList(MonthsWorkingHours monthsWorkingHoursConfiguration)
        {
            MonthsDropDown.DataSource = Enumerable.Range(1, 12).Select(monthNo =>
            {
                var monthWorkingHours = monthsWorkingHoursConfiguration[monthNo];
                return new MonthsDropDownItem
                {
                    MonthName = $"{CultureInfo.DefaultThreadCurrentUICulture.DateTimeFormat.GetMonthName(monthNo)} ({monthWorkingHours} h)",
                    Hours = monthsWorkingHoursConfiguration[monthNo]
                };
            }).ToList();
        }

        private void ConfigureMonthsDropDownMember()
        {
            MonthsDropDownItem monthsDropDownItem;
            MonthsDropDown.DisplayMember = nameof(monthsDropDownItem.MonthName);
            MonthsDropDown.ValueMember = nameof(monthsDropDownItem.Hours);
        }

        private void CalculateAndShowSalaryReport(object sender, EventArgs e)
        {
            try
            {
                var factors = new Factors
                {
                    WorkedHours = StringParser.StringToDouble(
                        string.IsNullOrEmpty(WorkedHours.Text)
                            ? throw new ArgumentException(ErrorMessages.MissingWorkedHours)
                            : WorkedHours.Text),
                    HourlyFee = StringParser.StringToDouble(
                        string.IsNullOrEmpty(HourlyFee.Text)
                            ? throw new ArgumentException(ErrorMessages.MissingHourlyFee)
                            : HourlyFee.Text),
                    WorkedMonth = MonthsDropDown.SelectedIndex + 1
                };
                var monthSalaryReport = new MonthSalaryReport(_monthsWorkingHours, factors);
                var textReport = new SimpleTextReportBuilder()
                    .BuildMonthlyReport(monthSalaryReport);
                new CalculatorReportWindow(textReport).ShowDialog();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Uwaga");
            }
        }

        private void ShowAboutWindow(object sender, EventArgs e) =>
            MessageBox.Show($"{TextualRessources.Author}: Fabian Grochla, {TextualRessources.Version}: {Assembly.GetExecutingAssembly().GetName().Version}");

        private void ShowConfigurationWindow(object sender, EventArgs e)
        {
            var configurationWindow = new MonthConfigEditorWindow();
            configurationWindow.ConfigurationSavedEvent += ConfigurationWindow_ConfigurationSavedEvent;
            configurationWindow.ShowDialog();
        }

        private void ConfigurationWindow_ConfigurationSavedEvent()
        {
            _monthsWorkingHours = LoadMonthsWorkingHoursFromConfiguration();
            FillMonthsList(_monthsWorkingHours);
        }

        private void Exit(object sender, EventArgs e) => 
            System.Windows.Forms.Application.Exit();

        public void SetPolishLanguage_Click(object sender, EventArgs e)
        {
            if (SetPolishLanguage.Checked)
            {
                return;
            }
            LanguageSwitch.ToPolish();
            this.Localize();
            FillMonthsList(_monthsWorkingHours);
            SetEnglishLanguage.Checked = false;
            SetPolishLanguage.Checked = true;
        }

        public void SetEnglishLanguage_Click(object sender, EventArgs e)
        {
            if (SetEnglishLanguage.Checked)
            {
                return;
            }
            LanguageSwitch.ToEnglish();
            this.Localize();
            FillMonthsList(_monthsWorkingHours);
            SetEnglishLanguage.Checked = true;
            SetPolishLanguage.Checked = false;
        }
    }
}
