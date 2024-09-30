
namespace FitnessCT
{
    partial class frmWeighInUser
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
            this.lblWeighIn = new System.Windows.Forms.Label();
            this.cboUpdateActivityLevel = new System.Windows.Forms.ComboBox();
            this.lblUpdateActivityLevel = new System.Windows.Forms.Label();
            this.txtUpdateWeight = new System.Windows.Forms.TextBox();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBackToMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackToMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackToMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWeighIn
            // 
            this.lblWeighIn.AutoSize = true;
            this.lblWeighIn.Location = new System.Drawing.Point(90, 59);
            this.lblWeighIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeighIn.Name = "lblWeighIn";
            this.lblWeighIn.Size = new System.Drawing.Size(47, 13);
            this.lblWeighIn.TabIndex = 0;
            this.lblWeighIn.Text = "Weight: ";
            // 
            // cboUpdateActivityLevel
            // 
            this.cboUpdateActivityLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateActivityLevel.FormattingEnabled = true;
            this.cboUpdateActivityLevel.Location = new System.Drawing.Point(190, 96);
            this.cboUpdateActivityLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cboUpdateActivityLevel.Name = "cboUpdateActivityLevel";
            this.cboUpdateActivityLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboUpdateActivityLevel.Size = new System.Drawing.Size(147, 21);
            this.cboUpdateActivityLevel.TabIndex = 21;
            this.cboUpdateActivityLevel.SelectedIndexChanged += new System.EventHandler(this.cboUpdateActivityLevel_SelectedIndexChanged);
            // 
            // lblUpdateActivityLevel
            // 
            this.lblUpdateActivityLevel.AutoSize = true;
            this.lblUpdateActivityLevel.Location = new System.Drawing.Point(27, 99);
            this.lblUpdateActivityLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateActivityLevel.Name = "lblUpdateActivityLevel";
            this.lblUpdateActivityLevel.Size = new System.Drawing.Size(159, 13);
            this.lblUpdateActivityLevel.TabIndex = 19;
            this.lblUpdateActivityLevel.Text = "Update Activity Level (Optional):";
            // 
            // txtUpdateWeight
            // 
            this.txtUpdateWeight.Location = new System.Drawing.Point(146, 59);
            this.txtUpdateWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateWeight.MaxLength = 5;
            this.txtUpdateWeight.Name = "txtUpdateWeight";
            this.txtUpdateWeight.Size = new System.Drawing.Size(56, 20);
            this.txtUpdateWeight.TabIndex = 20;
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.Location = new System.Drawing.Point(146, 140);
            this.btnUpdateDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(112, 36);
            this.btnUpdateDetails.TabIndex = 22;
            this.btnUpdateDetails.Text = "Weigh In / Update";
            this.btnUpdateDetails.UseVisualStyleBackColor = true;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackToMainMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(436, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBackToMainMenu
            // 
            this.mnuBackToMainMenu.Name = "mnuBackToMainMenu";
            this.mnuBackToMainMenu.Size = new System.Drawing.Size(44, 22);
            this.mnuBackToMainMenu.Text = "Back";
            this.mnuBackToMainMenu.Click += new System.EventHandler(this.mnuBackToMainMenu_Click);
            // 
            // mnuBackToMenu
            // 
            this.mnuBackToMenu.Name = "mnuBackToMenu";
            this.mnuBackToMenu.Size = new System.Drawing.Size(44, 22);
            this.mnuBackToMenu.Text = "Back";
            this.mnuBackToMenu.Click += new System.EventHandler(this.mnuBackToMenu_Click);
            // 
            // mnuBackToMain
            // 
            this.mnuBackToMain.Name = "mnuBackToMain";
            this.mnuBackToMain.Size = new System.Drawing.Size(44, 22);
            this.mnuBackToMain.Text = "Back";
            // 
            // frmWeighInUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 244);
            this.Controls.Add(this.btnUpdateDetails);
            this.Controls.Add(this.txtUpdateWeight);
            this.Controls.Add(this.lblUpdateActivityLevel);
            this.Controls.Add(this.cboUpdateActivityLevel);
            this.Controls.Add(this.lblWeighIn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmWeighInUser";
            this.Text = "weighInMenu";
            this.Load += new System.EventHandler(this.frmWeighInUser_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeighIn;
        private System.Windows.Forms.ComboBox cboUpdateActivityLevel;
        private System.Windows.Forms.Label lblUpdateActivityLevel;
        private System.Windows.Forms.TextBox txtUpdateWeight;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBackToMain;
        private System.Windows.Forms.ToolStripMenuItem mnuBackToMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuBackToMainMenu;
    }
}