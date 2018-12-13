using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Parsers;
using SalaryCalculator.SalaryReport;

namespace SalaryCalculator.Dekstop
{
    public partial class CalculatorMainWindow : Form
    {
        private MonthsWorkingHours _monthsWorkingHours;
        public CalculatorMainWindow()
        {
            LoadMonthConfig();
            InitializeComponent();
            RefreshMonthSelect_ComboBox();
        }

        private void LoadMonthConfig()
        {
            var monthsWorkingHoursConfiguration
                           = JsonFileConverter.JsonFileConverter.ConvertFromFile<Dictionary<int, int>>($"{MonthConfigPaths.MonthConfig}.json");
            _monthsWorkingHours = new MonthsWorkingHours(monthsWorkingHoursConfiguration);
        }

        private void RefreshMonthSelect_ComboBox()
        {
            MonthSelect_ComboBox.Items.Clear();
            var comboBoxItemWithMonth = new System.Object[12];
            for (int i = 0; i <= 11; i++)
            {
                comboBoxItemWithMonth[i] = $"{Month.NumberToName(i + 1)}  ({_monthsWorkingHours[i + 1]} h)";
            }
            MonthSelect_ComboBox.Items.AddRange(comboBoxItemWithMonth);
            MonthSelect_ComboBox.Refresh();
            MonthSelect_ComboBox.SelectedIndex = 0;
        }

        private bool IsWorkedHoursAndHourlyFeeTextBoxesFilled()
        {
            if (WorkedHours_TextBox.Text == "" || HourlyFee_TextBox.Text == "")
            {
                MessageBox.Show("Nie uzupełniono wszystkich pól!", "Uwaga!");
                return false;
            }
            return true;
        }

        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            if (IsWorkedHoursAndHourlyFeeTextBoxesFilled())
            {
                try
                {
                    var factors = new Factors
                    {
                        WorkedHours = StringParser.StringToDouble(WorkedHours_TextBox.Text),
                        HourlyFee = StringParser.StringToDouble(HourlyFee_TextBox.Text),
                        WorkedMonth = MonthSelect_ComboBox.SelectedIndex + 1
                    };
                    var monthSalaryReport = new MonthSalaryReport(_monthsWorkingHours, factors);
                    var textReport = new SimpleTextReportBuilder()
                        .BuildMontlhyReport(monthSalaryReport);
                    new CalculatorReportWindow(textReport).ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "BŁĄD!!!");
                }
            }
        }

        private void About_StripMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Fabian Grochla \n" +
                            "Wersja: 1.3");
        }

        private void Exit_StripMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RunMonthConfigEditorWindow(ConfigurationEditMode status)
        {
            var monthConfigEditorWindow = new MonthConfigEditorWindow(_monthsWorkingHours, status);
            monthConfigEditorWindow.TestNewMonthConfiginInMainWindow
                += TestNewMonthConfiginInMainWindow;
            monthConfigEditorWindow.ShowDialog();
        }

        private void RunMonthConfigEditorV2Window(ConfigurationEditMode status)
        {
            var monthConfigEditorV2Window = new MonthConfigEditorV2Window(_monthsWorkingHours, status);
            monthConfigEditorV2Window.RestartMonthConfigEditorV2Window
                += RestartMonthConfigEditorV2Window;
            monthConfigEditorV2Window.ShowDialog();
        }

        private void RestartMonthConfigEditorV2Window(MonthConfigEditorV2Window monthConfigEditorV2Window)
        {
            monthConfigEditorV2Window.Close();
            LoadMonthConfig();
            RefreshMonthSelect_ComboBox();
            RunMonthConfigEditorV2Window(ConfigurationEditMode.Edit);
        }

        private void TestNewMonthConfiginInMainWindow(MonthConfigEditorWindow monthConfigEditorWindow)
        {
            var isConfigurationValid = true;
            monthConfigEditorWindow.Close();
            try
            {
                LoadMonthConfig();
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}", "Uwaga!");
                RunMonthConfigEditorWindow(ConfigurationEditMode.FixInvalid);
                isConfigurationValid = false;
            }
            if (isConfigurationValid)
            {
                RefreshMonthSelect_ComboBox();
                RunMonthConfigEditorWindow(ConfigurationEditMode.Edit);
            }
        }

        private void MonthConfig_StripMenu_Click(object sender, EventArgs e)
        {
            RunMonthConfigEditorWindow(ConfigurationEditMode.Normal);
        }

        private void MonthConfigV2_StripMenu_Click(object sender, EventArgs e)
        {
            RunMonthConfigEditorV2Window(ConfigurationEditMode.Normal);
        }
    }
}
