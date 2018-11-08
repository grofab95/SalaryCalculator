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
        private string _MonthConfigFilePath = "MonthConfig.json";
        private string _MonthConfigLastGoodConfigurationFilePath = "MonthConfigLastGoodConfiguration.json";  

        public MonthConfigEditorWindow(MonthsWorkingHours monthsWorkingHours, int status)
        {
            _monthsWorkingHours = monthsWorkingHours;
            InitializeComponent();
            WriteMonthConfigFileToTextBox();
            RunSelectedMethodBasedOnStatusFromMainWindow(status);
        }              

        private void RunSelectedMethodBasedOnStatusFromMainWindow(int status)
        {
            switch (status)
            {
                case 0:
                    RestoreLastGoodConfigurationOfMonthConfig();
                    break;
                case 1:
                    SaveNewValueToMonthConfig();
                    break;
                default:
                    break;
            }
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

        private void CheckCorrectMonthConfigInMainWindow()
        {
            WriteTextBoxToMonthConfigFile(_MonthConfigFilePath);
            TestNewMonthConfiginInMainWindow?.Invoke(this);
        }

        private void SaveNewValueToMonthConfig()
        {
            WriteTextBoxToMonthConfigFile(_MonthConfigLastGoodConfigurationFilePath);
            WriteMonthConfigFileToTextBox();
            MessageBox.Show("Zmiany zostały zapisane!", "Info");
        }

        private void Save_StripMenu_Click(object sender, EventArgs e)
        {           
            if (CheckIfChangesHaveBeenMadeInTextBox())
            {
                CheckCorrectMonthConfigInMainWindow();
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
