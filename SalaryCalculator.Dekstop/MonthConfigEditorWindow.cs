using FileTranslator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SalaryCalculator.Dekstop
{
    public partial class MonthConfigEditorWindow : Form
    {
        public delegate void methodHandler(MonthConfigEditorWindow obj);
        public methodHandler TestNewMonthConfiginInMainWindow;
        private MonthsWorkingHours _monthsWorkingHours;

        public MonthConfigEditorWindow(MonthsWorkingHours monthsWorkingHours, ConfigurationEditMode status)
        {
            _monthsWorkingHours = monthsWorkingHours;
            InitializeComponent();
            WriteMonthConfigFileToTextBox();
            RunSelectedMethodBasedOnStatusFromMainWindow(status);
        }

        private void RunSelectedMethodBasedOnStatusFromMainWindow(ConfigurationEditMode status)
        {
            switch (status)
            {
                case ConfigurationEditMode.FixInvalid:
                    RestoreLastGoodConfigurationOfMonthConfig();
                    break;
                case ConfigurationEditMode.Edit:
                    SaveNewValueToMonthConfig();
                    break;
                default:
                    break;
            }
        }

        private void WriteMonthConfigFileToTextBox()
        {
            MonthConfigFile_TextBox.Text = ReadSelectedFile($"{MonthConfigPaths.MonthConfig.ToString()}.json");
        }

        private void WriteTextBoxToMonthConfigFile(string monthConfigFilePath)
        {
            using (StreamWriter newTask = new StreamWriter(monthConfigFilePath, false))
            {
                newTask.WriteLine(MonthConfigFile_TextBox.Text);
            }
        }

        private string ReadSelectedFile(string FilePathToRead)
        {
            var file = new StreamReader(FilePathToRead);
            var fileValue = file.ReadToEnd();
            file.Close();
            return fileValue;
        }
        private void RestoreLastGoodConfigurationOfMonthConfig()
        {
            using (StreamWriter newTask = new StreamWriter($"{MonthConfigPaths.MonthConfig.ToString()}.json", false))
            {
                newTask.WriteLine(ReadSelectedFile($"{MonthConfigPaths.MonthConfigLastGoodConfiguration.ToString()}.json"));
            }
            WriteMonthConfigFileToTextBox();
        }

        private bool IsMonthConfigTextBoxChanged()
        {
            var monthConfigFileValue = ReadSelectedFile($"{MonthConfigPaths.MonthConfig.ToString()}.json");
            return monthConfigFileValue != MonthConfigFile_TextBox.Text ? true : false;
        }

        private void CheckCorrectMonthConfigInMainWindow()
        {
            WriteTextBoxToMonthConfigFile($"{MonthConfigPaths.MonthConfig.ToString()}.json");
            TestNewMonthConfiginInMainWindow?.Invoke(this);
        }

        private void SaveNewValueToMonthConfig()
        {
            WriteTextBoxToMonthConfigFile($"{MonthConfigPaths.MonthConfigLastGoodConfiguration.ToString()}.json");
            WriteMonthConfigFileToTextBox();
            MessageBox.Show($"{Properties.Resources.succesfullSave_message}", "Info");
        }

        private void Save_StripMenu_Click(object sender, EventArgs e)
        {
            if (IsMonthConfigTextBoxChanged())
            {
                CheckCorrectMonthConfigInMainWindow();
            }
            else
            {
                MessageBox.Show($"{Properties.Resources.noChangesMade_message}", "Info");
            }
        }

        private void Exit_StripMenu_Click(object sender, EventArgs e)
        {
            if (IsMonthConfigTextBoxChanged())
            {
                if (MessageBox.Show("Wprowadzono zmiany, czy chcesz je zapisać?", "Uwaga!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CheckCorrectMonthConfigInMainWindow();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
