using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using SalaryCalculator.Desktop.Properties;
using SalaryCalculator.Desktop.Ressources;

namespace SalaryCalculator.Desktop
{
    public partial class MonthConfigEditorWindow : Form
    {
        public event Action ConfigurationSavedEvent;
        public MonthConfigEditorWindow()
        {
            InitializeComponent();
            WriteMonthConfigFileToTextBox();
            this.Localize();
        }

        private void WriteMonthConfigFileToTextBox()
        {
            MonthConfiguration.Text = ReadConfiguration();
        }

        private string ReadConfiguration()
        {
            return File.ReadAllText(Settings.Default.MonthConfigurationFile);
        }

        private bool IsMonthConfigTextBoxChanged()
        {
            return ReadConfiguration() != MonthConfiguration.Text;
        }

        private void SaveConfiguration()
        {
            ValidateConfiguration();
            File.WriteAllText(Settings.Default.MonthConfigurationFile, MonthConfiguration.Text);
            MessageBox.Show($"{TextualRessources.ChangesWasSave}", "Info");
            ConfigurationSavedEvent?.Invoke();
        }

        private void ValidateConfiguration()
        {
            new MonthsWorkingHours(
            JsonConvert.DeserializeObject<Dictionary<int, int>>(MonthConfiguration.Text));
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (IsMonthConfigTextBoxChanged())
            {
                SaveConfiguration();
            } else
            {
                MessageBox.Show($"{TextualRessources.NoChangesMade}", "Info");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (IsMonthConfigTextBoxChanged())
            {
                if (MessageBox.Show($"{TextualRessources.UnsavedChangesWhileExit}", $"{TextualRessources.Attention}",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveConfiguration();
                }
            }
            Close();
        }
    }
}