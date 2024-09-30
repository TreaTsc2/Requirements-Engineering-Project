
namespace FitnessCT
{
    partial class frmManageIntake
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
            this.btnAddIntake = new System.Windows.Forms.Button();
            this.btnUpdateIntake = new System.Windows.Forms.Button();
            this.btnDeleteIntake = new System.Windows.Forms.Button();
            this.mnuIntakeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIntakeMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddIntake
            // 
            this.btnAddIntake.Location = new System.Drawing.Point(147, 41);
            this.btnAddIntake.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddIntake.Name = "btnAddIntake";
            this.btnAddIntake.Size = new System.Drawing.Size(109, 44);
            this.btnAddIntake.TabIndex = 1;
            this.btnAddIntake.Text = "Record Intake";
            this.btnAddIntake.UseVisualStyleBackColor = true;
            this.btnAddIntake.Click += new System.EventHandler(this.btnAddIntake_Click);
            // 
            // btnUpdateIntake
            // 
            this.btnUpdateIntake.Location = new System.Drawing.Point(147, 108);
            this.btnUpdateIntake.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateIntake.Name = "btnUpdateIntake";
            this.btnUpdateIntake.Size = new System.Drawing.Size(109, 44);
            this.btnUpdateIntake.TabIndex = 2;
            this.btnUpdateIntake.Text = "Update Intake";
            this.btnUpdateIntake.UseVisualStyleBackColor = true;
            this.btnUpdateIntake.Click += new System.EventHandler(this.btnUpdateIntake_Click);
            // 
            // btnDeleteIntake
            // 
            this.btnDeleteIntake.Location = new System.Drawing.Point(147, 177);
            this.btnDeleteIntake.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteIntake.Name = "btnDeleteIntake";
            this.btnDeleteIntake.Size = new System.Drawing.Size(109, 44);
            this.btnDeleteIntake.TabIndex = 3;
            this.btnDeleteIntake.Text = "Delete Intake";
            this.btnDeleteIntake.UseVisualStyleBackColor = true;
            this.btnDeleteIntake.Click += new System.EventHandler(this.btnDeleteIntake_Click);
            // 
            // mnuIntakeMenuStrip
            // 
            this.mnuIntakeMenuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mnuIntakeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu});
            this.mnuIntakeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuIntakeMenuStrip.Name = "mnuIntakeMenuStrip";
            this.mnuIntakeMenuStrip.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.mnuIntakeMenuStrip.Size = new System.Drawing.Size(436, 24);
            this.mnuIntakeMenuStrip.TabIndex = 3;
            this.mnuIntakeMenuStrip.Text = "menuStrip1";
            // 
            // mnu
            // 
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(44, 22);
            this.mnu.Text = "Back";
            this.mnu.Click += new System.EventHandler(this.mnu_Click);
            // 
            // frmManageIntake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 244);
            this.Controls.Add(this.btnDeleteIntake);
            this.Controls.Add(this.btnUpdateIntake);
            this.Controls.Add(this.btnAddIntake);
            this.Controls.Add(this.mnuIntakeMenuStrip);
            this.MainMenuStrip = this.mnuIntakeMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmManageIntake";
            this.Text = "intakeMenu";
            this.Load += new System.EventHandler(this.frmManageIntake_Load);
            this.mnuIntakeMenuStrip.ResumeLayout(false);
            this.mnuIntakeMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddIntake;
        private System.Windows.Forms.Button btnUpdateIntake;
        private System.Windows.Forms.Button btnDeleteIntake;
        private System.Windows.Forms.MenuStrip mnuIntakeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnu;
    }
}