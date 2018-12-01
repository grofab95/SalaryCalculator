using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Console;
using FileTranslator;
using SalaryCalculator.SalaryReport;

namespace SalaryCalculator.Dekstop
{
    public enum ConfigurationWindowMode
    {
        ActualConfiguration,
        FixInvalidConfiguration,
        EditConfiguration,
    }

    public enum MonthConfigPaths
    {
        MonthConfig,
        MonthConfigLastGoodConfiguration,

    }

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
                           = JsonFileTranslator.ReadFrom<Dictionary<int, int>>("MonthConfig.json");
            _monthsWorkingHours = new MonthsWorkingHours(monthsWorkingHoursConfiguration);
        }

        private void RefreshMonthSelect_ComboBox()
        {
            MonthSelect_ComboBox.Items.Clear();
            System.Object[] ItemObject = new System.Object[12];
            for (int i = 0; i <= 11; i++)
            {
                ItemObject[i] = $"{Month.NumberToName(i+1)}  ({_monthsWorkingHours[i+1]} h)";
            }
            MonthSelect_ComboBox.Items.AddRange(ItemObject);
            MonthSelect_ComboBox.Refresh();
            MonthSelect_ComboBox.SelectedIndex = 0;
        }

        private bool CheckIfChangesHaveBeenMadeInTextBoxes()
        {
            if(WorkedHours_TextBox.Text == "" || HourlyFee_TextBox.Text == "")
            {
                MessageBox.Show("Nie uzupełniono wszystkich pól!", "Uwaga!");
                return false;
            }
            return true;
        }

        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            if (CheckIfChangesHaveBeenMadeInTextBoxes())
            {
                try
                {
                    var factors = new Factors
                    {
                        WorkedHours = Parser.ParseStringToDouble(WorkedHours_TextBox.Text),
                        HourlyFee = Parser.ParseStringToDouble(HourlyFee_TextBox.Text),
                        WorkedMonth = MonthSelect_ComboBox.SelectedIndex + 1
                    };
                    var summary = new CalculateSummary();
                    var monthSalaryReport = new MonthSalaryReport(_monthsWorkingHours, factors, summary);
                    var textReport = new SimpleTextReportBuilder()
                        .BuildMontlhyReport(_monthsWorkingHours, factors, summary);
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

        private void RunMonthConfigEditorWindow(ConfigurationWindowMode status)
        {
            var monthConfigEditorWindow = new MonthConfigEditorWindow(_monthsWorkingHours, status);
            monthConfigEditorWindow.TestNewMonthConfiginInMainWindow
                += new MonthConfigEditorWindow.methodHandler(TestNewMonthConfiginInMainWindow);
            monthConfigEditorWindow.ShowDialog();
        }

        private void RunMonthConfigEditorV2Window(ConfigurationWindowMode status)
        {
            var monthConfigEditorV2Window = new MonthConfigEditorV2Window(_monthsWorkingHours, status);
            monthConfigEditorV2Window.RestartMonthConfigEditorV2Window
                += new MonthConfigEditorV2Window.methodHandler(RestartMonthConfigEditorV2Window);
            monthConfigEditorV2Window.ShowDialog();
        }

        private void RestartMonthConfigEditorV2Window(MonthConfigEditorV2Window obj)
        {
            obj.Close();
            LoadMonthConfig();
            RefreshMonthSelect_ComboBox();
            RunMonthConfigEditorV2Window(ConfigurationWindowMode.EditConfiguration);
        }        
        
        private void TestNewMonthConfiginInMainWindow(MonthConfigEditorWindow obj)
        {
            var isConfigurationValid = true;
            obj.Close();
            try
            {
                LoadMonthConfig();
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}", "Uwaga!");
                RunMonthConfigEditorWindow(ConfigurationWindowMode.FixInvalidConfiguration);
                isConfigurationValid = false;
            }
            if (isConfigurationValid)
            {
                RefreshMonthSelect_ComboBox();
                RunMonthConfigEditorWindow(ConfigurationWindowMode.EditConfiguration);
            }
        }

        private void MonthConfig_StripMenu_Click(object sender, EventArgs e)
        {
            RunMonthConfigEditorWindow(ConfigurationWindowMode.ActualConfiguration);
        }

        private void MonthConfigV2_StripMenu_Click(object sender, EventArgs e)
        {
            RunMonthConfigEditorV2Window(ConfigurationWindowMode.ActualConfiguration);      
        }
    }       
}
