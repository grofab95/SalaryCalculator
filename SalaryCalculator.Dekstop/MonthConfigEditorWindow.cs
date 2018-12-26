using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using SalaryCalculator.Desktop.Properties;

namespace SalaryCalculator.Desktop
{
    public partial class MonthConfigEditorWindow : Form
    {
        public event Action ConfigurationSavedEvent;
        public MonthConfigEditorWindow()
        {
            InitializeComponent();
            WriteMonthConfigFileToTextBox();
        }

        private void WriteMonthConfigFileToTextBox() => MonthConfiguration.Text = ReadConfiguration();

        private string ReadConfiguration() => File.ReadAllText(Settings.Default.MonthConfigurationFile);

        private bool IsMonthConfigTextBoxChanged() => ReadConfiguration() != MonthConfiguration.Text;

        private void SaveConfiguration()
        {
            ValidateConfiguration();
            File.WriteAllText(Settings.Default.MonthConfigurationFile, MonthConfiguration.Text);
            MessageBox.Show("Zapisano zmiany.");
            ConfigurationSavedEvent?.Invoke();
        }

        private void ValidateConfiguration() => new MonthsWorkingHours(
            JsonConvert.DeserializeObject<Dictionary<int, int>>(MonthConfiguration.Text));

        private void Save_StripMenu_Click(object sender, EventArgs e) => SaveConfiguration();

        private void Exit_StripMenu_Click(object sender, EventArgs e)
        {
            if (IsMonthConfigTextBoxChanged())
            {
                if (MessageBox.Show("Wprowadzono zmiany, czy chcesz je zapisać?", "Uwaga!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveConfiguration();
                }
            }
            Close();
        }
    }
}