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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HourlyFee = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MonthsDropDown = new System.Windows.Forms.ComboBox();
            this.monthsWorkingHoursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthsWorkingHoursBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Calculate_Button);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(12, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(728, 290);
            this.panel3.TabIndex = 0;
            // 
            // Calculate_Button
            // 
            this.Calculate_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Calculate_Button.Location = new System.Drawing.Point(275, 202);
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.Size = new System.Drawing.Size(200, 50);
            this.Calculate_Button.TabIndex = 4;
            this.Calculate_Button.Text = "OBLICZ\r\n";
            this.Calculate_Button.UseVisualStyleBackColor = true;
            this.Calculate_Button.Click += new System.EventHandler(this.CalculateAndShowSalaryReport);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HourlyFee);
            this.groupBox3.Location = new System.Drawing.Point(501, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wpisz stawkę godzinową";
            // 
            // HourlyFee
            // 
            this.HourlyFee.Location = new System.Drawing.Point(29, 44);
            this.HourlyFee.Name = "HourlyFee";
            this.HourlyFee.Size = new System.Drawing.Size(100, 22);
            this.HourlyFee.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MonthsDropDown);
            this.groupBox2.Location = new System.Drawing.Point(52, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wybierz miesiąc";
            // 
            // MonthsDropDown
            // 
            this.MonthsDropDown.DataSource = this.monthsWorkingHoursBindingSource;
            this.MonthsDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthsDropDown.FormattingEnabled = true;
            this.MonthsDropDown.Location = new System.Drawing.Point(25, 44);
            this.MonthsDropDown.Name = "MonthsDropDown";
            this.MonthsDropDown.Size = new System.Drawing.Size(134, 24);
            this.MonthsDropDown.TabIndex = 0;
            // 
            // monthsWorkingHoursBindingSource
            // 
            this.monthsWorkingHoursBindingSource.DataSource = typeof(SalaryCalculator.MonthsWorkingHours);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WorkedHours);
            this.groupBox1.Location = new System.Drawing.Point(275, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wpisz liczbę godzin";
            // 
            // WorkedHours
            // 
            this.WorkedHours.Location = new System.Drawing.Point(35, 43);
            this.WorkedHours.Name = "WorkedHours";
            this.WorkedHours.Size = new System.Drawing.Size(100, 22);
            this.WorkedHours.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Application,
            this.MonthConfiguration,
            this.Language});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Application
            // 
            this.Application.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About_StripMenu,
            this.Exit_StripMenu});
            this.Application.Name = "Application";
            this.Application.Size = new System.Drawing.Size(78, 24);
            this.Application.Text = "Program";
            // 
            // About_StripMenu
            // 
            this.About_StripMenu.Name = "About_StripMenu";
            this.About_StripMenu.Size = new System.Drawing.Size(216, 26);
            this.About_StripMenu.Text = "O programie";
            this.About_StripMenu.Click += new System.EventHandler(this.ShowAboutWindow);
            // 
            // Exit_StripMenu
            // 
            this.Exit_StripMenu.Name = "Exit_StripMenu";
            this.Exit_StripMenu.Size = new System.Drawing.Size(216, 26);
            this.Exit_StripMenu.Text = "Wyjdź";
            this.Exit_StripMenu.Click += new System.EventHandler(this.Exit);
            // 
            // MonthConfiguration
            // 
            this.MonthConfiguration.Name = "MonthConfiguration";
            this.MonthConfiguration.Size = new System.Drawing.Size(182, 24);
            this.MonthConfiguration.Text = "Konfiguracja Miesięczna";
            this.MonthConfiguration.Click += new System.EventHandler(this.ShowConfigurationWindow);
            // 
            // Language
            // 
            this.Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetPolishLanguage,
            this.SetEnglishLanguage});
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(55, 24);
            this.Language.Text = "Język";
            // 
            // SetPolishLanguage
            // 
            this.SetPolishLanguage.Name = "SetPolishLanguage";
            this.SetPolishLanguage.Size = new System.Drawing.Size(131, 26);
            this.SetPolishLanguage.Text = "Polish";
            this.SetPolishLanguage.Click += new System.EventHandler(this.SetPolishLanguage_Click);
            // 
            // SetEnglishLanguage
            // 
            this.SetEnglishLanguage.Name = "SetEnglishLanguage";
            this.SetEnglishLanguage.Size = new System.Drawing.Size(131, 26);
            this.SetEnglishLanguage.Text = "English";
            this.SetEnglishLanguage.Click += new System.EventHandler(this.SetEnglishLanguage_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CalculatorMainWindow
            // 
            this.ClientSize = new System.Drawing.Size(752, 358);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatorMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROGRAM DO OBLICZANIA WYNAGRODZENIA ZA NADGODZINY (DODATEK 50%)";
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthsWorkingHoursBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        protected internal System.Windows.Forms.Panel panel3;
        protected internal System.Windows.Forms.TextBox HourlyFee;
        protected internal System.Windows.Forms.GroupBox groupBox3;
        protected internal System.Windows.Forms.GroupBox groupBox2;
        protected internal System.Windows.Forms.GroupBox groupBox1;
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

