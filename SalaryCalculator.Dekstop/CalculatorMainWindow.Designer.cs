namespace SalaryCalculator.Desktop
{
    partial class CalculatorMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorMainWindow));
            this.panel3 = new System.Windows.Forms.Panel();
            this.Calculate_Button = new System.Windows.Forms.Button();
            this.HourlyFeeInput_TextBox = new System.Windows.Forms.GroupBox();
            this.HourlyFee = new System.Windows.Forms.TextBox();
            this.MonthSelect_TextBox = new System.Windows.Forms.GroupBox();
            this.MonthsDropDown = new System.Windows.Forms.ComboBox();
            this.monthsWorkingHoursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HourInput_TextBox = new System.Windows.Forms.GroupBox();
            this.WorkedHours = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Application = new System.Windows.Forms.ToolStripMenuItem();
            this.About_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MonthConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.Language = new System.Windows.Forms.ToolStripMenuItem();
            this.SetPolishLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.SetEnglishLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel3.SuspendLayout();
            this.HourlyFeeInput_TextBox.SuspendLayout();
            this.MonthSelect_TextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthsWorkingHoursBindingSource)).BeginInit();
            this.HourInput_TextBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Calculate_Button);
            this.panel3.Controls.Add(this.HourlyFeeInput_TextBox);
            this.panel3.Controls.Add(this.MonthSelect_TextBox);
            this.panel3.Controls.Add(this.HourInput_TextBox);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // Calculate_Button
            // 
            resources.ApplyResources(this.Calculate_Button, "Calculate_Button");
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.UseVisualStyleBackColor = true;
            this.Calculate_Button.Click += new System.EventHandler(this.CalculateAndShowSalaryReport);
            // 
            // HourlyFeeInput_TextBox
            // 
            this.HourlyFeeInput_TextBox.Controls.Add(this.HourlyFee);
            resources.ApplyResources(this.HourlyFeeInput_TextBox, "HourlyFeeInput_TextBox");
            this.HourlyFeeInput_TextBox.Name = "HourlyFeeInput_TextBox";
            this.HourlyFeeInput_TextBox.TabStop = false;
            // 
            // HourlyFee
            // 
            resources.ApplyResources(this.HourlyFee, "HourlyFee");
            this.HourlyFee.Name = "HourlyFee";
            // 
            // MonthSelect_TextBox
            // 
            this.MonthSelect_TextBox.Controls.Add(this.MonthsDropDown);
            resources.ApplyResources(this.MonthSelect_TextBox, "MonthSelect_TextBox");
            this.MonthSelect_TextBox.Name = "MonthSelect_TextBox";
            this.MonthSelect_TextBox.TabStop = false;
            // 
            // MonthsDropDown
            // 
            this.MonthsDropDown.DataSource = this.monthsWorkingHoursBindingSource;
            this.MonthsDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthsDropDown.FormattingEnabled = true;
            resources.ApplyResources(this.MonthsDropDown, "MonthsDropDown");
            this.MonthsDropDown.Name = "MonthsDropDown";
            // 
            // monthsWorkingHoursBindingSource
            // 
            this.monthsWorkingHoursBindingSource.DataSource = typeof(SalaryCalculator.MonthsWorkingHours);
            // 
            // HourInput_TextBox
            // 
            this.HourInput_TextBox.Controls.Add(this.WorkedHours);
            resources.ApplyResources(this.HourInput_TextBox, "HourInput_TextBox");
            this.HourInput_TextBox.Name = "HourInput_TextBox";
            this.HourInput_TextBox.TabStop = false;
            // 
            // WorkedHours
            // 
            resources.ApplyResources(this.WorkedHours, "WorkedHours");
            this.WorkedHours.Name = "WorkedHours";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Application,
            this.MonthConfiguration,
            this.Language});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // Application
            // 
            this.Application.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About_StripMenu,
            this.Exit_StripMenu});
            this.Application.Name = "Application";
            resources.ApplyResources(this.Application, "Application");
            // 
            // About_StripMenu
            // 
            this.About_StripMenu.Name = "About_StripMenu";
            resources.ApplyResources(this.About_StripMenu, "About_StripMenu");
            this.About_StripMenu.Click += new System.EventHandler(this.ShowAboutWindow);
            // 
            // Exit_StripMenu
            // 
            this.Exit_StripMenu.Name = "Exit_StripMenu";
            resources.ApplyResources(this.Exit_StripMenu, "Exit_StripMenu");
            this.Exit_StripMenu.Click += new System.EventHandler(this.Exit);
            // 
            // MonthConfiguration
            // 
            this.MonthConfiguration.Name = "MonthConfiguration";
            resources.ApplyResources(this.MonthConfiguration, "MonthConfiguration");
            this.MonthConfiguration.Click += new System.EventHandler(this.ShowConfigurationWindow);
            // 
            // Language
            // 
            this.Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetPolishLanguage,
            this.SetEnglishLanguage});
            this.Language.Name = "Language";
            resources.ApplyResources(this.Language, "Language");
            // 
            // SetPolishLanguage
            // 
            this.SetPolishLanguage.Name = "SetPolishLanguage";
            resources.ApplyResources(this.SetPolishLanguage, "SetPolishLanguage");
            this.SetPolishLanguage.Click += new System.EventHandler(this.SetPolishLanguage_Click);
            // 
            // SetEnglishLanguage
            // 
            this.SetEnglishLanguage.Name = "SetEnglishLanguage";
            resources.ApplyResources(this.SetEnglishLanguage, "SetEnglishLanguage");
            this.SetEnglishLanguage.Click += new System.EventHandler(this.SetEnglishLanguage_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // CalculatorMainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CalculatorMainWindow";
            this.panel3.ResumeLayout(false);
            this.HourlyFeeInput_TextBox.ResumeLayout(false);
            this.HourlyFeeInput_TextBox.PerformLayout();
            this.MonthSelect_TextBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthsWorkingHoursBindingSource)).EndInit();
            this.HourInput_TextBox.ResumeLayout(false);
            this.HourInput_TextBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        protected internal System.Windows.Forms.Panel panel3;
        protected internal System.Windows.Forms.TextBox HourlyFee;
        protected internal System.Windows.Forms.GroupBox HourlyFeeInput_TextBox;
        protected internal System.Windows.Forms.GroupBox MonthSelect_TextBox;
        protected internal System.Windows.Forms.GroupBox HourInput_TextBox;
        protected internal System.Windows.Forms.Button Calculate_Button;
        protected internal System.Windows.Forms.TextBox WorkedHours;
        protected internal System.Windows.Forms.MenuStrip menuStrip1;
        protected internal System.Windows.Forms.ToolStripMenuItem Application;
        protected internal System.Windows.Forms.ToolStripMenuItem About_StripMenu;
        protected internal System.Windows.Forms.ToolStripMenuItem Exit_StripMenu;
        protected internal System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        protected internal System.Windows.Forms.ComboBox MonthsDropDown;
        protected internal System.Windows.Forms.BindingSource monthsWorkingHoursBindingSource;
        protected internal System.Windows.Forms.ToolStripMenuItem Language;
        protected internal System.Windows.Forms.ToolStripMenuItem SetPolishLanguage;
        protected internal System.Windows.Forms.ToolStripMenuItem SetEnglishLanguage;
        protected internal System.Windows.Forms.ToolStripMenuItem MonthConfiguration;
    }
}

