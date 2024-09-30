
namespace FitnessCT
{
    partial class frmManageItems
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
            this.btnAddFoodItem = new System.Windows.Forms.Button();
            this.btnUpdateFoodItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBackToMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddFoodItem
            // 
            this.btnAddFoodItem.Location = new System.Drawing.Point(65, 67);
            this.btnAddFoodItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFoodItem.Name = "btnAddFoodItem";
            this.btnAddFoodItem.Size = new System.Drawing.Size(135, 49);
            this.btnAddFoodItem.TabIndex = 1;
            this.btnAddFoodItem.Text = "Add new item";
            this.btnAddFoodItem.UseVisualStyleBackColor = true;
            this.btnAddFoodItem.Click += new System.EventHandler(this.btnAddIntake_Click);
            // 
            // btnUpdateFoodItem
            // 
            this.btnUpdateFoodItem.Location = new System.Drawing.Point(65, 133);
            this.btnUpdateFoodItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateFoodItem.Name = "btnUpdateFoodItem";
            this.btnUpdateFoodItem.Size = new System.Drawing.Size(135, 49);
            this.btnUpdateFoodItem.TabIndex = 2;
            this.btnUpdateFoodItem.Text = "Update item";
            this.btnUpdateFoodItem.UseVisualStyleBackColor = true;
            this.btnUpdateFoodItem.Click += new System.EventHandler(this.btnUpdateFoodItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(65, 206);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(135, 49);
            this.btnDeleteItem.TabIndex = 3;
            this.btnDeleteItem.Text = "Delete item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackToMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBackToMain
            // 
            this.mnuBackToMain.Name = "mnuBackToMain";
            this.mnuBackToMain.Size = new System.Drawing.Size(44, 20);
            this.mnuBackToMain.Text = "Back";
            this.mnuBackToMain.Click += new System.EventHandler(this.mnuBackToMain_Click);
            // 
            // frmManageItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 420);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnUpdateFoodItem);
            this.Controls.Add(this.btnAddFoodItem);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmManageItems";
            this.Text = "addFoodItemMenu";
            this.Load += new System.EventHandler(this.frmManageItems_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFoodItem;
        private System.Windows.Forms.Button btnUpdateFoodItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBackToMain;
    }
}