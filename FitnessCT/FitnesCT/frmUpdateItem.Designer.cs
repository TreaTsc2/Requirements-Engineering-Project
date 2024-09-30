
namespace FitnessCT
{
    partial class frmUpdateItem
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
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.btnSaveItemUpdate = new System.Windows.Forms.Button();
            this.txtCaloriesPerPortion = new System.Windows.Forms.TextBox();
            this.txtPortion = new System.Windows.Forms.TextBox();
            this.lblCaloriesPerPortion = new System.Windows.Forms.Label();
            this.lblPortion = new System.Windows.Forms.Label();
            this.lblChangeName = new System.Windows.Forms.Label();
            this.mnuUpdateIntake = new System.Windows.Forms.MenuStrip();
            this.mnuBackToMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSelectFood = new System.Windows.Forms.Label();
            this.cboSelectFood = new System.Windows.Forms.ComboBox();
            this.grpUpdateItemDetails = new System.Windows.Forms.GroupBox();
            this.mnuUpdateIntake.SuspendLayout();
            this.grpUpdateItemDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(163, 16);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFoodName.MaxLength = 30;
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(134, 20);
            this.txtFoodName.TabIndex = 2;
            // 
            // btnSaveItemUpdate
            // 
            this.btnSaveItemUpdate.Location = new System.Drawing.Point(127, 115);
            this.btnSaveItemUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveItemUpdate.Name = "btnSaveItemUpdate";
            this.btnSaveItemUpdate.Size = new System.Drawing.Size(133, 34);
            this.btnSaveItemUpdate.TabIndex = 5;
            this.btnSaveItemUpdate.Text = "Save Changes";
            this.btnSaveItemUpdate.UseVisualStyleBackColor = true;
            this.btnSaveItemUpdate.Click += new System.EventHandler(this.btnSaveItemUpdate_Click);
            // 
            // txtCaloriesPerPortion
            // 
            this.txtCaloriesPerPortion.Location = new System.Drawing.Point(163, 83);
            this.txtCaloriesPerPortion.Margin = new System.Windows.Forms.Padding(2);
            this.txtCaloriesPerPortion.MaxLength = 5;
            this.txtCaloriesPerPortion.Name = "txtCaloriesPerPortion";
            this.txtCaloriesPerPortion.Size = new System.Drawing.Size(134, 20);
            this.txtCaloriesPerPortion.TabIndex = 4;
            // 
            // txtPortion
            // 
            this.txtPortion.Location = new System.Drawing.Point(163, 45);
            this.txtPortion.Margin = new System.Windows.Forms.Padding(2);
            this.txtPortion.MaxLength = 20;
            this.txtPortion.Name = "txtPortion";
            this.txtPortion.Size = new System.Drawing.Size(134, 20);
            this.txtPortion.TabIndex = 3;
            // 
            // lblCaloriesPerPortion
            // 
            this.lblCaloriesPerPortion.AutoSize = true;
            this.lblCaloriesPerPortion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaloriesPerPortion.Location = new System.Drawing.Point(31, 83);
            this.lblCaloriesPerPortion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaloriesPerPortion.Name = "lblCaloriesPerPortion";
            this.lblCaloriesPerPortion.Size = new System.Drawing.Size(128, 20);
            this.lblCaloriesPerPortion.TabIndex = 21;
            this.lblCaloriesPerPortion.Text = "Cals per portion :";
            // 
            // lblPortion
            // 
            this.lblPortion.AutoSize = true;
            this.lblPortion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortion.Location = new System.Drawing.Point(48, 45);
            this.lblPortion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPortion.Name = "lblPortion";
            this.lblPortion.Size = new System.Drawing.Size(111, 20);
            this.lblPortion.TabIndex = 20;
            this.lblPortion.Text = "Portion name :";
            // 
            // lblChangeName
            // 
            this.lblChangeName.AutoSize = true;
            this.lblChangeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeName.Location = new System.Drawing.Point(61, 16);
            this.lblChangeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangeName.Name = "lblChangeName";
            this.lblChangeName.Size = new System.Drawing.Size(98, 20);
            this.lblChangeName.TabIndex = 19;
            this.lblChangeName.Text = "Food name :";
            // 
            // mnuUpdateIntake
            // 
            this.mnuUpdateIntake.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mnuUpdateIntake.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackToMenu});
            this.mnuUpdateIntake.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateIntake.Name = "mnuUpdateIntake";
            this.mnuUpdateIntake.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.mnuUpdateIntake.Size = new System.Drawing.Size(436, 24);
            this.mnuUpdateIntake.TabIndex = 28;
            this.mnuUpdateIntake.Text = "menuStrip1";
            // 
            // mnuBackToMenu
            // 
            this.mnuBackToMenu.Name = "mnuBackToMenu";
            this.mnuBackToMenu.Size = new System.Drawing.Size(44, 22);
            this.mnuBackToMenu.Text = "Back";
            this.mnuBackToMenu.Click += new System.EventHandler(this.mnuBackToMenu_Click);
            // 
            // lblSelectFood
            // 
            this.lblSelectFood.AutoSize = true;
            this.lblSelectFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectFood.Location = new System.Drawing.Point(55, 45);
            this.lblSelectFood.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectFood.Name = "lblSelectFood";
            this.lblSelectFood.Size = new System.Drawing.Size(94, 20);
            this.lblSelectFood.TabIndex = 30;
            this.lblSelectFood.Text = "Select food:";
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
            this.cboSelectFood.Location = new System.Drawing.Point(164, 45);
            this.cboSelectFood.Margin = new System.Windows.Forms.Padding(2);
            this.cboSelectFood.Name = "cboSelectFood";
            this.cboSelectFood.Size = new System.Drawing.Size(170, 21);
            this.cboSelectFood.TabIndex = 1;
            this.cboSelectFood.SelectedIndexChanged += new System.EventHandler(this.cboSelectFood_SelectedIndexChanged);
            // 
            // grpUpdateItemDetails
            // 
            this.grpUpdateItemDetails.Controls.Add(this.txtFoodName);
            this.grpUpdateItemDetails.Controls.Add(this.btnSaveItemUpdate);
            this.grpUpdateItemDetails.Controls.Add(this.txtCaloriesPerPortion);
            this.grpUpdateItemDetails.Controls.Add(this.txtPortion);
            this.grpUpdateItemDetails.Controls.Add(this.lblCaloriesPerPortion);
            this.grpUpdateItemDetails.Controls.Add(this.lblPortion);
            this.grpUpdateItemDetails.Controls.Add(this.lblChangeName);
            this.grpUpdateItemDetails.Location = new System.Drawing.Point(37, 78);
            this.grpUpdateItemDetails.Name = "grpUpdateItemDetails";
            this.grpUpdateItemDetails.Size = new System.Drawing.Size(346, 154);
            this.grpUpdateItemDetails.TabIndex = 31;
            this.grpUpdateItemDetails.TabStop = false;
            this.grpUpdateItemDetails.Text = "Item Details - Enter only the values you want to update";
            // 
            // frmUpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 244);
            this.Controls.Add(this.grpUpdateItemDetails);
            this.Controls.Add(this.lblSelectFood);
            this.Controls.Add(this.cboSelectFood);
            this.Controls.Add(this.mnuUpdateIntake);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUpdateItem";
            this.Text = "Update Item";
            this.Load += new System.EventHandler(this.frmUpdateItem_Load);
            this.mnuUpdateIntake.ResumeLayout(false);
            this.mnuUpdateIntake.PerformLayout();
            this.grpUpdateItemDetails.ResumeLayout(false);
            this.grpUpdateItemDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Button btnSaveItemUpdate;
        private System.Windows.Forms.TextBox txtCaloriesPerPortion;
        private System.Windows.Forms.TextBox txtPortion;
        private System.Windows.Forms.Label lblCaloriesPerPortion;
        private System.Windows.Forms.Label lblPortion;
        private System.Windows.Forms.Label lblChangeName;
        private System.Windows.Forms.MenuStrip mnuUpdateIntake;
        private System.Windows.Forms.ToolStripMenuItem mnuBackToMenu;
        private System.Windows.Forms.Label lblSelectFood;
        private System.Windows.Forms.ComboBox cboSelectFood;
        private System.Windows.Forms.GroupBox grpUpdateItemDetails;
    }
}