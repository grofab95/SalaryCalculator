namespace SalaryCalculator.Desktop
{
    partial class MonthConfigEditorWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthConfigEditorWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Save_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MonthConfiguration = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_StripMenu,
            this.Exit_StripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(216, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Save_StripMenu
            // 
            this.Save_StripMenu.Name = "Save_StripMenu";
            this.Save_StripMenu.Size = new System.Drawing.Size(64, 24);
            this.Save_StripMenu.Text = "Zapisz";
            this.Save_StripMenu.Click += new System.EventHandler(this.Save_StripMenu_Click);
            // 
            // Exit_StripMenu
            // 
            this.Exit_StripMenu.Name = "Exit_StripMenu";
            this.Exit_StripMenu.Size = new System.Drawing.Size(74, 24);
            this.Exit_StripMenu.Text = "Zamknij";
            this.Exit_StripMenu.Click += new System.EventHandler(this.Exit_StripMenu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MonthConfigFile_TextBox
            // 
            this.MonthConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MonthConfiguration.Location = new System.Drawing.Point(8, 33);
            this.MonthConfiguration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MonthConfiguration.Multiline = true;
            this.MonthConfiguration.Name = "MonthConfiguration";
            this.MonthConfiguration.Size = new System.Drawing.Size(197, 354);
            this.MonthConfiguration.TabIndex = 0;
            // 
            // MonthConfigEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 399);
            this.ControlBox = false;
            this.Controls.Add(this.MonthConfiguration);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MonthConfigEditorWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edytor pliku MonthConfig";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox MonthConfiguration;
        private System.Windows.Forms.ToolStripMenuItem Save_StripMenu;
        private System.Windows.Forms.ToolStripMenuItem Exit_StripMenu;
    }
}