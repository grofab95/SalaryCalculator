using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Console;
using FileTranslator;

namespace SalaryCalculator.Dekstop
{
    public partial class CalculatorMainWindow : Form
    {        
        private MonthsWorkingHours _monthsWorkingHours;
        public CalculatorMainWindow()
        {
            LoadMonthConfig();
            InitializeComponent();
            MonthSelect_ComboBox.SelectedIndex = 0;
        }     
        
        private void LoadMonthConfig()
        {
            var monthsWorkingHoursConfiguration
                           = JsonFileTranslator<Dictionary<int, int>>.Translate("MonthConfig.json");
            _monthsWorkingHours = new MonthsWorkingHours(monthsWorkingHoursConfiguration);
        }

        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var workedHours = Parser.ParseStringToDouble(WorkedHours_TextBox.Text);
                var hourlyFee = Parser.ParseStringToDouble(HourlyFee_TextBox.Text);
                var workedMonth = MonthSelect_ComboBox.SelectedIndex;
                workedMonth += 1;
                var calculator = new Calculator(_monthsWorkingHours);
                var overHoursAmount = calculator.CalculateOverhoursAmount(workedMonth, workedHours);
                var overHoursGrossIncome = calculator.CalculateOverHoursGrossIncome(overHoursAmount, hourlyFee);
                var overHoursNetIncome = calculator.CalculateOverHoursNetIncome(overHoursGrossIncome);
                var totalGrossIncome = calculator.CalculateTotalGrossIncome(workedHours, hourlyFee, overHoursGrossIncome);
                var totalNetIncome = calculator.CalculateTotalNetIncome(totalGrossIncome);
                var reportBuilder = new ReportBuilder(_monthsWorkingHours);
                var report = reportBuilder.BuildIncomeMonthlyReport(
                        workedHours,
                        workedMonth,
                        hourlyFee,
                        overHoursAmount,
                        overHoursGrossIncome,
                        overHoursNetIncome,
                        totalGrossIncome,
                        totalNetIncome
                    );
                var calculatorReportWindow = new CalculatorReportWindow(report);
                calculatorReportWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "BŁĄD!!!");
            }
        }

        private void About_StripMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Fabian Grochla \n" +
                            "Wersja: 1.2");
        }

        private void Exit_StripMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RunMonthConfigEditorWindow(string status)
        {
            var monthConfigEditorWindow = new MonthConfigEditorWindow(_monthsWorkingHours, status);
            monthConfigEditorWindow.TestNewMonthConfiginInMainWindow
                += new MonthConfigEditorWindow.methodHandler(TestNewMonthConfiginInMainWindow);
            monthConfigEditorWindow.ShowDialog();
        }

        private void MonthConfig_StripMenu_Click(object sender, EventArgs e)
        {
            RunMonthConfigEditorWindow("normal_start");
        }

        private void TestNewMonthConfiginInMainWindow(MonthConfigEditorWindow obj)
        {
            var ValidConfiguration = 1;
            obj.Close();
            try
            {
                LoadMonthConfig();
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}", "Uwaga!");
                RunMonthConfigEditorWindow("bad_MonthConfig");
                ValidConfiguration = 0;
            }
            if (ValidConfiguration == 1)
            {
                RunMonthConfigEditorWindow("good_MonthConfig");
            }
        }


        private void MonthConfigV2_StripMenu_Click(object sender, EventArgs e)
        {
            var monthConfigEditorV2Window = new MonthConfigEditorV2Window(_monthsWorkingHours);
            monthConfigEditorV2Window.ShowDialog();        
        }
    }       
}
