
namespace FitnessCT
{
    partial class frmSelectAnalysis
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBackToMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWeeklyAnalysis = new System.Windows.Forms.Button();
            this.btnMonthlyAnalysis = new System.Windows.Forms.Button();
            this.btnAllTimeAnalysis = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackToMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(436, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBackToMenu
            // 
            this.mnuBackToMenu.Name = "mnuBackToMenu";
            this.mnuBackToMenu.Size = new System.Drawing.Size(44, 22);
            this.mnuBackToMenu.Text = "Back";
            this.mnuBackToMenu.Click += new System.EventHandler(this.mnuBackToMenu_Click);
            // 
            // btnWeeklyAnalysis
            // 
            this.btnWeeklyAnalysis.Location = new System.Drawing.Point(149, 42);
            this.btnWeeklyAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.btnWeeklyAnalysis.Name = "btnWeeklyAnalysis";
            this.btnWeeklyAnalysis.Size = new System.Drawing.Size(110, 38);
            this.btnWeeklyAnalysis.TabIndex = 1;
            this.btnWeeklyAnalysis.Text = "Weekly Analysis";
            this.btnWeeklyAnalysis.UseVisualStyleBackColor = true;
            this.btnWeeklyAnalysis.Click += new System.EventHandler(this.btnWeeklyAnalysis_Click);
            // 
            // btnMonthlyAnalysis
            // 
            this.btnMonthlyAnalysis.Location = new System.Drawing.Point(149, 102);
            this.btnMonthlyAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.btnMonthlyAnalysis.Name = "btnMonthlyAnalysis";
            this.btnMonthlyAnalysis.Size = new System.Drawing.Size(110, 38);
            this.btnMonthlyAnalysis.TabIndex = 2;
            this.btnMonthlyAnalysis.Text = "Monthly Analysis";
            this.btnMonthlyAnalysis.UseVisualStyleBackColor = true;
            this.btnMonthlyAnalysis.Click += new System.EventHandler(this.btnMonthlyAnalysis_Click);
            // 
            // btnAllTimeAnalysis
            // 
            this.btnAllTimeAnalysis.Location = new System.Drawing.Point(149, 164);
            this.btnAllTimeAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.btnAllTimeAnalysis.Name = "btnAllTimeAnalysis";
            this.btnAllTimeAnalysis.Size = new System.Drawing.Size(110, 38);
            this.btnAllTimeAnalysis.TabIndex = 3;
            this.btnAllTimeAnalysis.Text = "All Time Analysis";
            this.btnAllTimeAnalysis.UseVisualStyleBackColor = true;
            this.btnAllTimeAnalysis.Click += new System.EventHandler(this.btnAllTimeAnalysis_Click);
            // 
            // frmSelectAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 244);
            this.Controls.Add(this.btnAllTimeAnalysis);
            this.Controls.Add(this.btnMonthlyAnalysis);
            this.Controls.Add(this.btnWeeklyAnalysis);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSelectAnalysis";
            this.Text = "Analysis Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBackToMenu;
        private System.Windows.Forms.Button btnWeeklyAnalysis;
        private System.Windows.Forms.Button btnMonthlyAnalysis;
        private System.Windows.Forms.Button btnAllTimeAnalysis;
    }
}