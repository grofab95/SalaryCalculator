namespace SalaryCalculator.Dekstop
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
            this.HourlyFee_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MonthSelect_ComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WorkedHours_TextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.About_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MonthConfig_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MonthConfigV2_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.Calculate_Button.Location = new System.Drawing.Point(275, 202);
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.Size = new System.Drawing.Size(200, 50);
            this.Calculate_Button.TabIndex = 4;
            this.Calculate_Button.Text = "OBLICZ\r\n";
            this.Calculate_Button.UseVisualStyleBackColor = true;
            this.Calculate_Button.Click += new System.EventHandler(this.Calculate_Button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HourlyFee_TextBox);
            this.groupBox3.Location = new System.Drawing.Point(501, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wpisz stawkę godzinową";
            // 
            // HourlyFee_TextBox
            // 
            this.HourlyFee_TextBox.Location = new System.Drawing.Point(29, 44);
            this.HourlyFee_TextBox.Name = "HourlyFee_TextBox";
            this.HourlyFee_TextBox.Size = new System.Drawing.Size(100, 20);
            this.HourlyFee_TextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MonthSelect_ComboBox);
            this.groupBox2.Location = new System.Drawing.Point(52, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wybierz miesiąc";
            // 
            // MonthSelect_ComboBox
            // 
            this.MonthSelect_ComboBox.AllowDrop = true;
            this.MonthSelect_ComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.MonthSelect_ComboBox.CausesValidation = false;
            this.MonthSelect_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthSelect_ComboBox.FormattingEnabled = true;
            this.MonthSelect_ComboBox.Items.AddRange(new object[] {
            "Styczeń",
            "Luty",
            "Marzec",
            "Kwiecień",
            "Maj",
            "Czerwiec",
            "Lipiec",
            "Sierpień",
            "Wrzesień",
            "Październik",
            "Listopad",
            "Grudzień"});
            this.MonthSelect_ComboBox.Location = new System.Drawing.Point(17, 42);
            this.MonthSelect_ComboBox.Name = "MonthSelect_ComboBox";
            this.MonthSelect_ComboBox.Size = new System.Drawing.Size(166, 21);
            this.MonthSelect_ComboBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WorkedHours_TextBox);
            this.groupBox1.Location = new System.Drawing.Point(275, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wpisz liczbę godzin";
            // 
            // WorkedHours_TextBox
            // 
            this.WorkedHours_TextBox.Location = new System.Drawing.Point(35, 43);
            this.WorkedHours_TextBox.Name = "WorkedHours_TextBox";
            this.WorkedHours_TextBox.Size = new System.Drawing.Size(100, 20);
            this.WorkedHours_TextBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_MenuStrip,
            this.MonthConfig_StripMenu,
            this.MonthConfigV2_StripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_MenuStrip
            // 
            this.Menu_MenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About_StripMenu,
            this.Exit_StripMenu});
            this.Menu_MenuStrip.Name = "Menu_MenuStrip";
            this.Menu_MenuStrip.Size = new System.Drawing.Size(50, 20);
            this.Menu_MenuStrip.Text = "Menu";
            // 
            // About_StripMenu
            // 
            this.About_StripMenu.Name = "About_StripMenu";
            this.About_StripMenu.Size = new System.Drawing.Size(141, 22);
            this.About_StripMenu.Text = "O programie";
            this.About_StripMenu.Click += new System.EventHandler(this.About_StripMenu_Click);
            // 
            // Exit_StripMenu
            // 
            this.Exit_StripMenu.Name = "Exit_StripMenu";
            this.Exit_StripMenu.Size = new System.Drawing.Size(141, 22);
            this.Exit_StripMenu.Text = "Wyjdź";
            this.Exit_StripMenu.Click += new System.EventHandler(this.Exit_StripMenu_Click);
            // 
            // MonthConfig_StripMenu
            // 
            this.MonthConfig_StripMenu.Name = "MonthConfig_StripMenu";
            this.MonthConfig_StripMenu.Size = new System.Drawing.Size(94, 20);
            this.MonthConfig_StripMenu.Text = "Month Config";
            this.MonthConfig_StripMenu.Click += new System.EventHandler(this.MonthConfig_StripMenu_Click);
            // 
            // MonthConfigV2_StripMenu
            // 
            this.MonthConfigV2_StripMenu.Name = "MonthConfigV2_StripMenu";
            this.MonthConfigV2_StripMenu.Size = new System.Drawing.Size(110, 20);
            this.MonthConfigV2_StripMenu.Text = "Month Config V2";
            this.MonthConfigV2_StripMenu.Click += new System.EventHandler(this.MonthConfigV2_StripMenu_Click);
            // 
            // contextMenuStrip1
            // 
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox HourlyFee_TextBox;
        private System.Windows.Forms.ComboBox MonthSelect_ComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Calculate_Button;
        private System.Windows.Forms.TextBox WorkedHours_TextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem About_StripMenu;
        private System.Windows.Forms.ToolStripMenuItem Exit_StripMenu;
        private System.Windows.Forms.ToolStripMenuItem MonthConfig_StripMenu;
        private System.Windows.Forms.ToolStripMenuItem MonthConfigV2_StripMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

