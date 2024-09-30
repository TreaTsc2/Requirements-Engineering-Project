
namespace FitnessCT
{
    partial class frmAddItem
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
            this.mnuAddItem = new System.Windows.Forms.MenuStrip();
            this.mnuBackToFoodItemsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackToManageItems = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackToFoodItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lblPortion = new System.Windows.Forms.Label();
            this.lblCaloriesPerPortion = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtPortion = new System.Windows.Forms.TextBox();
            this.txtCaloriesPerPortion = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.mnuBackToItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAddItem
            // 
            this.mnuAddItem.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mnuAddItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackToItemMenu});
            this.mnuAddItem.Location = new System.Drawing.Point(0, 0);
            this.mnuAddItem.Name = "mnuAddItem";
            this.mnuAddItem.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.mnuAddItem.Size = new System.Drawing.Size(548, 24);
            this.mnuAddItem.TabIndex = 0;
            this.mnuAddItem.Text = "menuStrip1";
            // 
            // mnuBackToFoodItemsMenu
            // 
            this.mnuBackToFoodItemsMenu.Name = "mnuBackToFoodItemsMenu";
            this.mnuBackToFoodItemsMenu.Size = new System.Drawing.Size(44, 22);
            this.mnuBackToFoodItemsMenu.Text = "Back";
            // 
            // mnuBackToManageItems
            // 
            this.mnuBackToManageItems.Name = "mnuBackToManageItems";
            this.mnuBackToManageItems.Size = new System.Drawing.Size(44, 22);
            this.mnuBackToManageItems.Text = "Back";
            // 
            // mnuBackToFoodItemMenu
            // 
            this.mnuBackToFoodItemMenu.Name = "mnuBackToFoodItemMenu";
            this.mnuBackToFoodItemMenu.Size = new System.Drawing.Size(44, 22);
            this.mnuBackToFoodItemMenu.Text = "Back";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.Location = new System.Drawing.Point(64, 48);
            this.lblFoodName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(94, 20);
            this.lblFoodName.TabIndex = 2;
            this.lblFoodName.Text = "Food name:";
            // 
            // lblPortion
            // 
            this.lblPortion.AutoSize = true;
            this.lblPortion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortion.Location = new System.Drawing.Point(92, 79);
            this.lblPortion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPortion.Name = "lblPortion";
            this.lblPortion.Size = new System.Drawing.Size(63, 20);
            this.lblPortion.TabIndex = 3;
            this.lblPortion.Text = "Portion:";
            // 
            // lblCaloriesPerPortion
            // 
            this.lblCaloriesPerPortion.AutoSize = true;
            this.lblCaloriesPerPortion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaloriesPerPortion.Location = new System.Drawing.Point(7, 113);
            this.lblCaloriesPerPortion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaloriesPerPortion.Name = "lblCaloriesPerPortion";
            this.lblCaloriesPerPortion.Size = new System.Drawing.Size(150, 20);
            this.lblCaloriesPerPortion.TabIndex = 4;
            this.lblCaloriesPerPortion.Text = "Calories per portion:";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(158, 50);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFoodName.MaxLength = 30;
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(134, 20);
            this.txtFoodName.TabIndex = 1;
            // 
            // txtPortion
            // 
            this.txtPortion.Location = new System.Drawing.Point(158, 81);
            this.txtPortion.Margin = new System.Windows.Forms.Padding(2);
            this.txtPortion.MaxLength = 20;
            this.txtPortion.Name = "txtPortion";
            this.txtPortion.Size = new System.Drawing.Size(134, 20);
            this.txtPortion.TabIndex = 2;
            // 
            // txtCaloriesPerPortion
            // 
            this.txtCaloriesPerPortion.Location = new System.Drawing.Point(158, 115);
            this.txtCaloriesPerPortion.Margin = new System.Windows.Forms.Padding(2);
            this.txtCaloriesPerPortion.MaxLength = 4;
            this.txtCaloriesPerPortion.Name = "txtCaloriesPerPortion";
            this.txtCaloriesPerPortion.Size = new System.Drawing.Size(58, 20);
            this.txtCaloriesPerPortion.TabIndex = 3;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(158, 155);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(141, 40);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // mnuBackToItemMenu
            // 
            this.mnuBackToItemMenu.Name = "mnuBackToItemMenu";
            this.mnuBackToItemMenu.Size = new System.Drawing.Size(44, 22);
            this.mnuBackToItemMenu.Text = "Back";
            this.mnuBackToItemMenu.Click += new System.EventHandler(this.mnuBackToItemMenu_Click);
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 281);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtCaloriesPerPortion);
            this.Controls.Add(this.txtPortion);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.lblCaloriesPerPortion);
            this.Controls.Add(this.lblPortion);
            this.Controls.Add(this.lblFoodName);
            this.Controls.Add(this.mnuAddItem);
            this.MainMenuStrip = this.mnuAddItem;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddItem";
            this.Text = "Add Item";
            this.mnuAddItem.ResumeLayout(false);
            this.mnuAddItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAddItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBackToFoodItemMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lblPortion;
        private System.Windows.Forms.Label lblCaloriesPerPortion;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtPortion;
        private System.Windows.Forms.TextBox txtCaloriesPerPortion;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBackToManageItems;
        private System.Windows.Forms.ToolStripMenuItem mnuBackToFoodItemsMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuBackToItemMenu;
    }
}