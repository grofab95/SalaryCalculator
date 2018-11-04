using FileTranslator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SalaryCalculator.Dekstop
{
    public partial class MonthConfigEditorWindow : Form
    {
        private MonthsWorkingHours _monthsWorkingHours;

        private string _MonthConfigFilePath = "MonthConfig.json";
        private string _MonthConfigLastGoodConfigurationFilePath = "MonthConfigLastGoodConfiguration.json";

        public MonthConfigEditorWindow()
        {            
            TryLoadMonthsWorkingHoursConfiguration();            
            InitializeComponent();
            WriteMonthConfigFileToTextBox();
        }

        private bool TryLoadMonthsWorkingHoursConfiguration()
        {
            try
            {
                var monthsWorkingHoursConfiguration
                                   = JsonFileTranslator<Dictionary<int, int>>.Translate(_MonthConfigFilePath);
                _monthsWorkingHours = new MonthsWorkingHours(monthsWorkingHoursConfiguration);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}", "UWAGA!");
                RestoreLastGoodConfigurationOfMonthConfig();
                return false;
            }
            return true;
        }

        private void WriteMonthConfigFileToTextBox()
        {
            MonthConfigFile_TextBox.Text = ReadSelectedFile(_MonthConfigFilePath);
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
            using (StreamWriter newTask = new StreamWriter(_MonthConfigFilePath, false))
            {
                newTask.WriteLine(ReadSelectedFile(_MonthConfigLastGoodConfigurationFilePath));
            }
            WriteMonthConfigFileToTextBox();
        }
        
        private bool CheckIfChangesHaveBeenMadeInTextBox()
        {
            var monthConfigFileValue = ReadSelectedFile(_MonthConfigFilePath);
            return monthConfigFileValue != MonthConfigFile_TextBox.Text ? true : false;
        }

        private void SaveNewValueToMonthConfigs()
        {
            WriteTextBoxToMonthConfigFile(_MonthConfigFilePath);
            if (TryLoadMonthsWorkingHoursConfiguration())
            {
                WriteTextBoxToMonthConfigFile(_MonthConfigFilePath);
                WriteTextBoxToMonthConfigFile(_MonthConfigLastGoodConfigurationFilePath);
                WriteMonthConfigFileToTextBox();
                MessageBox.Show("Zmiany zostały zapisane!\n\nNastąpi restart programu.", "Info");
                Application.Restart();
            }
        }
        private void Save_StripMenu_Click(object sender, EventArgs e)
        {             
            
            if (CheckIfChangesHaveBeenMadeInTextBox())
            {
                SaveNewValueToMonthConfigs();
            }
            else
            {
                MessageBox.Show("Nie wprowadzono żadnych zmian.", "Info");
            }           
        }

        private void Exit_StripMenu_Click(object sender, EventArgs e)
        {
            if (CheckIfChangesHaveBeenMadeInTextBox())
            {
                if (MessageBox.Show("Wprowadzono zmiany, czy chcesz je zapisać?", "Uwaga!", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveNewValueToMonthConfigs();
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
