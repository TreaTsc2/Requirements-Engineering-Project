
namespace FitnessCT
{
    partial class frmRecordIntake
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
            this.cboSelectFood = new System.Windows.Forms.ComboBox();
            this.lblSelectFood = new System.Windows.Forms.Label();
            this.lblPortion = new System.Windows.Forms.Label();
            this.txtPortionSize = new System.Windows.Forms.TextBox();
            this.lblCaloriesPerPortion = new System.Windows.Forms.Label();
            this.lbltotalCalories = new System.Windows.Forms.Label();
            this.mnuRecordIntake = new System.Windows.Forms.MenuStrip();
            this.mnuBackToManageItems = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackToManageIntake = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackToMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddIntake = new System.Windows.Forms.Button();
            this.cboMealType = new System.Windows.Forms.ComboBox();
            this.lblMealType = new System.Windows.Forms.Label();
            this.grpRecordIntakeDetails = new System.Windows.Forms.GroupBox();
            this.lblPortionName = new System.Windows.Forms.Label();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecordIntake.SuspendLayout();
            this.grpRecordIntakeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSelectFood
            // 
            this.cboSelectFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectFood.FormattingEnabled = true;
            this.cboSelectFood.Items.AddRange(new object[] {
            "White Bread",
            "Medium Red Apple",
            "Apple Juice",
            "Medium Banana"});
            this.cboSelectFood.Location = new System.Drawing.Point(28, 63);
            this.cboSelectFood.Margin = new System.Windows.Forms.Padding(2);
            this.cboSelectFood.Name = "cboSelectFood";
            this.cboSelectFood.Size = new System.Drawing.Size(170, 21);
            this.cboSelectFood.TabIndex = 1;
            this.cboSelectFood.SelectedIndexChanged += new System.EventHandler(this.cboSelectFood_SelectedIndexChanged);
            // 
            // lblSelectFood
            // 
            this.lblSelectFood.AutoSize = true;
            this.lblSelectFood.Location = new System.Drawing.Point(25, 43);
            this.lblSelectFood.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectFood.Name = "lblSelectFood";
            this.lblSelectFood.Size = new System.Drawing.Size(64, 13);
            this.lblSelectFood.TabIndex = 18;
            this.lblSelectFood.Text = "Select food:";
            // 
            // lblPortion
            // 
            this.lblPortion.AutoSize = true;
            this.lblPortion.Location = new System.Drawing.Point(7, 61);
            this.lblPortion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPortion.Name = "lblPortion";
            this.lblPortion.Size = new System.Drawing.Size(60, 13);
            this.lblPortion.TabIndex = 19;
            this.lblPortion.Text = "Portion(s) : ";
            // 
            // txtPortionSize
            // 
            this.txtPortionSize.Location = new System.Drawing.Point(77, 58);
            this.txtPortionSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtPortionSize.MaxLength = 4;
            this.txtPortionSize.Name = "txtPortionSize";
            this.txtPortionSize.Size = new System.Drawing.Size(66, 20);
            this.txtPortionSize.TabIndex = 3;
            this.txtPortionSize.TextChanged += new System.EventHandler(this.txtPortionSize_TextChanged);
            // 
            // lblCaloriesPerPortion
            // 
            this.lblCaloriesPerPortion.AutoSize = true;
            this.lblCaloriesPerPortion.Location = new System.Drawing.Point(52, 90);
            this.lblCaloriesPerPortion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaloriesPerPortion.Name = "lblCaloriesPerPortion";
            this.lblCaloriesPerPortion.Size = new System.Drawing.Size(100, 13);
            this.lblCaloriesPerPortion.TabIndex = 21;
            this.lblCaloriesPerPortion.Text = "Calories per portion:";
            // 
            // lbltotalCalories
            // 
            this.lbltotalCalories.AutoSize = true;
            this.lbltotalCalories.Location = new System.Drawing.Point(213, 90);
            this.lbltotalCalories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotalCalories.Name = "lbltotalCalories";
            this.lbltotalCalories.Size = new System.Drawing.Size(65, 13);
            this.lbltotalCalories.TabIndex = 22;
            this.lbltotalCalories.Text = "Cals total : 0";
            // 
            // mnuRecordIntake
            // 
            this.mnuRecordIntake.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mnuRecordIntake.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuRecordIntake.Location = new System.Drawing.Point(0, 0);
            this.mnuRecordIntake.Name = "mnuRecordIntake";
            this.mnuRecordIntake.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.mnuRecordIntake.Size = new System.Drawing.Size(504, 24);
            this.mnuRecordIntake.TabIndex = 23;
            this.mnuRecordIntake.Text = "menuStrip1";
            // 
            // mnuBackToManageItems
            // 
            this.mnuBackToManageItems.Name = "mnuBackToManageItems";
            this.mnuBackToManageItems.Size = new System.Drawing.Size(44, 22);
            this.mnuBackToManageItems.Text = "Back";
            // 
            // mnuBackToManageIntake
            // 
            this.mnuBackToManageIntake.Name = "mnuBackToManageIntake";
            this.mnuBackToManageIntake.Size = new System.Drawing.Size(44, 22);
            this.mnuBackToManageIntake.Text = "Back";
            // 
            // mnuBackToMenu
            // 
            this.mnuBackToMenu.Name = "mnuBackToMenu";
            this.mnuBackToMenu.Size = new System.Drawing.Size(44, 22);
            this.mnuBackToMenu.Text = "back";
            // 
            // btnAddIntake
            // 
            this.btnAddIntake.Location = new System.Drawing.Point(150, 134);
            this.btnAddIntake.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddIntake.Name = "btnAddIntake";
            this.btnAddIntake.Size = new System.Drawing.Size(90, 27);
            this.btnAddIntake.TabIndex = 4;
            this.btnAddIntake.Text = "Add";
            this.btnAddIntake.UseVisualStyleBackColor = true;
            this.btnAddIntake.Click += new System.EventHandler(this.btnAddIntake_Click);
            // 
            // cboMealType
            // 
            this.cboMealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMealType.FormattingEnabled = true;
            this.cboMealType.Location = new System.Drawing.Point(80, 18);
            this.cboMealType.Margin = new System.Windows.Forms.Padding(2);
            this.cboMealType.Name = "cboMealType";
            this.cboMealType.Size = new System.Drawing.Size(170, 21);
            this.cboMealType.TabIndex = 2;
            this.cboMealType.SelectedIndexChanged += new System.EventHandler(this.cboMealType_SelectedIndexChanged);
            // 
            // lblMealType
            // 
            this.lblMealType.AutoSize = true;
            this.lblMealType.Location = new System.Drawing.Point(5, 21);
            this.lblMealType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMealType.Name = "lblMealType";
            this.lblMealType.Size = new System.Drawing.Size(60, 13);
            this.lblMealType.TabIndex = 26;
            this.lblMealType.Text = "Meal Type:";
            // 
            // grpRecordIntakeDetails
            // 
            this.grpRecordIntakeDetails.Controls.Add(this.lblPortionName);
            this.grpRecordIntakeDetails.Controls.Add(this.cboMealType);
            this.grpRecordIntakeDetails.Controls.Add(this.lblCaloriesPerPortion);
            this.grpRecordIntakeDetails.Controls.Add(this.lblMealType);
            this.grpRecordIntakeDetails.Controls.Add(this.lblPortion);
            this.grpRecordIntakeDetails.Controls.Add(this.btnAddIntake);
            this.grpRecordIntakeDetails.Controls.Add(this.lbltotalCalories);
            this.grpRecordIntakeDetails.Controls.Add(this.txtPortionSize);
            this.grpRecordIntakeDetails.Location = new System.Drawing.Point(28, 105);
            this.grpRecordIntakeDetails.Name = "grpRecordIntakeDetails";
            this.grpRecordIntakeDetails.Size = new System.Drawing.Size(398, 166);
            this.grpRecordIntakeDetails.TabIndex = 27;
            this.grpRecordIntakeDetails.TabStop = false;
            this.grpRecordIntakeDetails.Text = "Details";
            // 
            // lblPortionName
            // 
            this.lblPortionName.AutoSize = true;
            this.lblPortionName.Location = new System.Drawing.Point(148, 65);
            this.lblPortionName.Name = "lblPortionName";
            this.lblPortionName.Size = new System.Drawing.Size(10, 13);
            this.lblPortionName.TabIndex = 27;
            this.lblPortionName.Text = ".";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // frmRecordIntake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 283);
            this.Controls.Add(this.grpRecordIntakeDetails);
            this.Controls.Add(this.lblSelectFood);
            this.Controls.Add(this.cboSelectFood);
            this.Controls.Add(this.mnuRecordIntake);
            this.MainMenuStrip = this.mnuRecordIntake;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRecordIntake";
            this.Text = "Record Intake";
            this.Load += new System.EventHandler(this.frmRecordIntake_Load);
            this.mnuRecordIntake.ResumeLayout(false);
            this.mnuRecordIntake.PerformLayout();
            this.grpRecordIntakeDetails.ResumeLayout(false);
            this.grpRecordIntakeDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelectFood;
        private System.Windows.Forms.Label lblSelectFood;
        private System.Windows.Forms.Label lblPortion;
        private System.Windows.Forms.TextBox txtPortionSize;
        private System.Windows.Forms.Label lblCaloriesPerPortion;
        private System.Windows.Forms.Label lbltotalCalories;
        private System.Windows.Forms.MenuStrip mnuRecordIntake;
        private System.Windows.Forms.Button btnAddIntake;
        private System.Windows.Forms.ToolStripMenuItem mnuBackToMenu;
        private System.Windows.Forms.ComboBox cboMealType;
        private System.Windows.Forms.Label lblMealType;
        private System.Windows.Forms.ToolStripMenuItem mnuBackToManageIntake;
        private System.Windows.Forms.GroupBox grpRecordIntakeDetails;
        private System.Windows.Forms.ToolStripMenuItem mnuBackToManageItems;
        private System.Windows.Forms.Label lblPortionName;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}