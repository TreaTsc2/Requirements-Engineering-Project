
namespace FitnessCT
{
    partial class frmUpdateIntake
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
            this.mnuUpdateIntake = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackToMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cboSelectIntake = new System.Windows.Forms.ComboBox();
            this.lblIntakeToUpdate = new System.Windows.Forms.Label();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.lblMealType = new System.Windows.Forms.Label();
            this.cboMealType = new System.Windows.Forms.ComboBox();
            this.lbltotalCalories = new System.Windows.Forms.Label();
            this.txtPortionSize = new System.Windows.Forms.TextBox();
            this.lblPortion = new System.Windows.Forms.Label();
            this.btnUpdateIntake = new System.Windows.Forms.Button();
            this.dtpUpdateIntakeDate = new System.Windows.Forms.DateTimePicker();
            this.grpUpdateIntakeDetails = new System.Windows.Forms.GroupBox();
            this.lblPortionName = new System.Windows.Forms.Label();
            this.lblCaloriesPerPortion = new System.Windows.Forms.Label();
            this.mnuUpdateIntake.SuspendLayout();
            this.grpUpdateIntakeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUpdateIntake
            // 
            this.mnuUpdateIntake.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mnuUpdateIntake.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuUpdateIntake.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateIntake.Name = "mnuUpdateIntake";
            this.mnuUpdateIntake.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.mnuUpdateIntake.Size = new System.Drawing.Size(436, 24);
            this.mnuUpdateIntake.TabIndex = 0;
            this.mnuUpdateIntake.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // mnuBackToMenu
            // 
            this.mnuBackToMenu.Name = "mnuBackToMenu";
            this.mnuBackToMenu.Size = new System.Drawing.Size(44, 22);
            this.mnuBackToMenu.Text = "Back";
            this.mnuBackToMenu.Click += new System.EventHandler(this.mnuBackToMenu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cboSelectIntake
            // 
            this.cboSelectIntake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectIntake.FormattingEnabled = true;
            this.cboSelectIntake.Items.AddRange(new object[] {
            "White Bread",
            "Medium Red Apple",
            "Medium Banana"});
            this.cboSelectIntake.Location = new System.Drawing.Point(129, 25);
            this.cboSelectIntake.Margin = new System.Windows.Forms.Padding(2);
            this.cboSelectIntake.Name = "cboSelectIntake";
            this.cboSelectIntake.Size = new System.Drawing.Size(131, 21);
            this.cboSelectIntake.TabIndex = 2;
            this.cboSelectIntake.SelectedIndexChanged += new System.EventHandler(this.cboSelectIntake_SelectedIndexChanged);
            // 
            // lblIntakeToUpdate
            // 
            this.lblIntakeToUpdate.AutoSize = true;
            this.lblIntakeToUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntakeToUpdate.Location = new System.Drawing.Point(18, 26);
            this.lblIntakeToUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIntakeToUpdate.Name = "lblIntakeToUpdate";
            this.lblIntakeToUpdate.Size = new System.Drawing.Size(107, 20);
            this.lblIntakeToUpdate.TabIndex = 28;
            this.lblIntakeToUpdate.Text = "Select Intake:";
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(33, 51);
            this.lblSelectDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(115, 20);
            this.lblSelectDate.TabIndex = 30;
            this.lblSelectDate.Text = "Date of Intake:";
            // 
            // lblMealType
            // 
            this.lblMealType.AutoSize = true;
            this.lblMealType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMealType.Location = new System.Drawing.Point(19, 51);
            this.lblMealType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMealType.Name = "lblMealType";
            this.lblMealType.Size = new System.Drawing.Size(85, 20);
            this.lblMealType.TabIndex = 36;
            this.lblMealType.Text = "Meal Type:";
            // 
            // cboMealType
            // 
            this.cboMealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMealType.FormattingEnabled = true;
            this.cboMealType.Location = new System.Drawing.Point(107, 51);
            this.cboMealType.Margin = new System.Windows.Forms.Padding(2);
            this.cboMealType.Name = "cboMealType";
            this.cboMealType.Size = new System.Drawing.Size(151, 21);
            this.cboMealType.TabIndex = 3;
            // 
            // lbltotalCalories
            // 
            this.lbltotalCalories.AutoSize = true;
            this.lbltotalCalories.Location = new System.Drawing.Point(239, 100);
            this.lbltotalCalories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotalCalories.Name = "lbltotalCalories";
            this.lbltotalCalories.Size = new System.Drawing.Size(53, 13);
            this.lbltotalCalories.TabIndex = 34;
            this.lbltotalCalories.Text = "Cals total:";
            // 
            // txtPortionSize
            // 
            this.txtPortionSize.Location = new System.Drawing.Point(107, 76);
            this.txtPortionSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtPortionSize.MaxLength = 4;
            this.txtPortionSize.Name = "txtPortionSize";
            this.txtPortionSize.Size = new System.Drawing.Size(42, 20);
            this.txtPortionSize.TabIndex = 4;
            this.txtPortionSize.TextChanged += new System.EventHandler(this.txtPortionSize_TextChanged);
            // 
            // lblPortion
            // 
            this.lblPortion.AutoSize = true;
            this.lblPortion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPortion.Location = new System.Drawing.Point(21, 74);
            this.lblPortion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPortion.Name = "lblPortion";
            this.lblPortion.Size = new System.Drawing.Size(81, 20);
            this.lblPortion.TabIndex = 32;
            this.lblPortion.Text = "Portion(s):";
            // 
            // btnUpdateIntake
            // 
            this.btnUpdateIntake.Location = new System.Drawing.Point(158, 115);
            this.btnUpdateIntake.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateIntake.Name = "btnUpdateIntake";
            this.btnUpdateIntake.Size = new System.Drawing.Size(95, 35);
            this.btnUpdateIntake.TabIndex = 5;
            this.btnUpdateIntake.Text = "Update";
            this.btnUpdateIntake.UseVisualStyleBackColor = true;
            this.btnUpdateIntake.Click += new System.EventHandler(this.btnUpdateIntake_Click);
            // 
            // dtpUpdateIntakeDate
            // 
            this.dtpUpdateIntakeDate.Location = new System.Drawing.Point(170, 51);
            this.dtpUpdateIntakeDate.MaxDate = new System.DateTime(2024, 5, 25, 0, 0, 0, 0);
            this.dtpUpdateIntakeDate.Name = "dtpUpdateIntakeDate";
            this.dtpUpdateIntakeDate.Size = new System.Drawing.Size(157, 20);
            this.dtpUpdateIntakeDate.TabIndex = 1;
            this.dtpUpdateIntakeDate.Value = new System.DateTime(2024, 3, 25, 0, 0, 0, 0);
            this.dtpUpdateIntakeDate.ValueChanged += new System.EventHandler(this.dtpUpdateIntakeDate_ValueChanged);
            // 
            // grpUpdateIntakeDetails
            // 
            this.grpUpdateIntakeDetails.Controls.Add(this.lblPortionName);
            this.grpUpdateIntakeDetails.Controls.Add(this.lblCaloriesPerPortion);
            this.grpUpdateIntakeDetails.Controls.Add(this.lblIntakeToUpdate);
            this.grpUpdateIntakeDetails.Controls.Add(this.cboSelectIntake);
            this.grpUpdateIntakeDetails.Controls.Add(this.lblMealType);
            this.grpUpdateIntakeDetails.Controls.Add(this.btnUpdateIntake);
            this.grpUpdateIntakeDetails.Controls.Add(this.cboMealType);
            this.grpUpdateIntakeDetails.Controls.Add(this.lbltotalCalories);
            this.grpUpdateIntakeDetails.Controls.Add(this.lblPortion);
            this.grpUpdateIntakeDetails.Controls.Add(this.txtPortionSize);
            this.grpUpdateIntakeDetails.Location = new System.Drawing.Point(12, 77);
            this.grpUpdateIntakeDetails.Name = "grpUpdateIntakeDetails";
            this.grpUpdateIntakeDetails.Size = new System.Drawing.Size(412, 155);
            this.grpUpdateIntakeDetails.TabIndex = 51;
            this.grpUpdateIntakeDetails.TabStop = false;
            this.grpUpdateIntakeDetails.Text = "Update Details";
            this.grpUpdateIntakeDetails.Enter += new System.EventHandler(this.grpUpdateIntakeDetails_Enter);
            // 
            // lblPortionName
            // 
            this.lblPortionName.AutoSize = true;
            this.lblPortionName.Location = new System.Drawing.Point(155, 83);
            this.lblPortionName.Name = "lblPortionName";
            this.lblPortionName.Size = new System.Drawing.Size(10, 13);
            this.lblPortionName.TabIndex = 39;
            this.lblPortionName.Text = ".";
            // 
            // lblCaloriesPerPortion
            // 
            this.lblCaloriesPerPortion.AutoSize = true;
            this.lblCaloriesPerPortion.Location = new System.Drawing.Point(87, 100);
            this.lblCaloriesPerPortion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaloriesPerPortion.Name = "lblCaloriesPerPortion";
            this.lblCaloriesPerPortion.Size = new System.Drawing.Size(105, 13);
            this.lblCaloriesPerPortion.TabIndex = 38;
            this.lblCaloriesPerPortion.Text = "Calories Per Portion: ";
            // 
            // frmUpdateIntake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 244);
            this.Controls.Add(this.grpUpdateIntakeDetails);
            this.Controls.Add(this.dtpUpdateIntakeDate);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.mnuUpdateIntake);
            this.MainMenuStrip = this.mnuUpdateIntake;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUpdateIntake";
            this.Text = "updateIntakeMenu";
            this.Load += new System.EventHandler(this.frmUpdateIntake_Load);
            this.mnuUpdateIntake.ResumeLayout(false);
            this.mnuUpdateIntake.PerformLayout();
            this.grpUpdateIntakeDetails.ResumeLayout(false);
            this.grpUpdateIntakeDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateIntake;
        private System.Windows.Forms.ToolStripMenuItem mnuBackToMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cboSelectIntake;
        private System.Windows.Forms.Label lblIntakeToUpdate;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Label lblMealType;
        private System.Windows.Forms.ComboBox cboMealType;
        private System.Windows.Forms.Label lbltotalCalories;
        private System.Windows.Forms.TextBox txtPortionSize;
        private System.Windows.Forms.Label lblPortion;
        private System.Windows.Forms.Button btnUpdateIntake;
        private System.Windows.Forms.DateTimePicker dtpUpdateIntakeDate;
        private System.Windows.Forms.GroupBox grpUpdateIntakeDetails;
        private System.Windows.Forms.Label lblCaloriesPerPortion;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label lblPortionName;
    }
}