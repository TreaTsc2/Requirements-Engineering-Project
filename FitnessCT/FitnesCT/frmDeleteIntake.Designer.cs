
namespace FitnessCT
{
    partial class frmDeleteIntake
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBackToMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteIntake = new System.Windows.Forms.Button();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.cboDeleteItem = new System.Windows.Forms.ComboBox();
            this.lblU = new System.Windows.Forms.Label();
            this.grpDeleteFoodItem = new System.Windows.Forms.GroupBox();
            this.dtpIntakeDate = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.mnuDeleteItem.SuspendLayout();
            this.grpDeleteFoodItem.SuspendLayout();
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
            // mnuDeleteItem
            // 
            this.mnuDeleteItem.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mnuDeleteItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuDeleteItem.Name = "mnuDeleteItem";
            this.mnuDeleteItem.Size = new System.Drawing.Size(100, 26);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // btnDeleteIntake
            // 
            this.btnDeleteIntake.Location = new System.Drawing.Point(142, 72);
            this.btnDeleteIntake.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteIntake.Name = "btnDeleteIntake";
            this.btnDeleteIntake.Size = new System.Drawing.Size(95, 35);
            this.btnDeleteIntake.TabIndex = 3;
            this.btnDeleteIntake.Text = "Delete";
            this.btnDeleteIntake.UseVisualStyleBackColor = true;
            this.btnDeleteIntake.Click += new System.EventHandler(this.btnDeleteIntake_Click);
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(46, 61);
            this.lblSelectDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(115, 20);
            this.lblSelectDate.TabIndex = 40;
            this.lblSelectDate.Text = "Date of Intake:";
            // 
            // cboDeleteItem
            // 
            this.cboDeleteItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeleteItem.FormattingEnabled = true;
            this.cboDeleteItem.Location = new System.Drawing.Point(132, 38);
            this.cboDeleteItem.Margin = new System.Windows.Forms.Padding(2);
            this.cboDeleteItem.Name = "cboDeleteItem";
            this.cboDeleteItem.Size = new System.Drawing.Size(131, 21);
            this.cboDeleteItem.TabIndex = 2;
            this.cboDeleteItem.SelectedIndexChanged += new System.EventHandler(this.cboDeleteItem_SelectedIndexChanged);
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblU.Location = new System.Drawing.Point(34, 36);
            this.lblU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(94, 20);
            this.lblU.TabIndex = 38;
            this.lblU.Text = "Select Item:";
            this.lblU.Click += new System.EventHandler(this.lblU_Click);
            // 
            // grpDeleteFoodItem
            // 
            this.grpDeleteFoodItem.Controls.Add(this.btnDeleteIntake);
            this.grpDeleteFoodItem.Controls.Add(this.lblU);
            this.grpDeleteFoodItem.Controls.Add(this.cboDeleteItem);
            this.grpDeleteFoodItem.Location = new System.Drawing.Point(44, 99);
            this.grpDeleteFoodItem.Name = "grpDeleteFoodItem";
            this.grpDeleteFoodItem.Size = new System.Drawing.Size(316, 115);
            this.grpDeleteFoodItem.TabIndex = 48;
            this.grpDeleteFoodItem.TabStop = false;
            this.grpDeleteFoodItem.Text = "Delete Item:";
            // 
            // dtpIntakeDate
            // 
            this.dtpIntakeDate.Location = new System.Drawing.Point(176, 61);
            this.dtpIntakeDate.Name = "dtpIntakeDate";
            this.dtpIntakeDate.Size = new System.Drawing.Size(157, 20);
            this.dtpIntakeDate.TabIndex = 1;
            this.dtpIntakeDate.ValueChanged += new System.EventHandler(this.dtpIntakeDate_ValueChanged);
            // 
            // frmDeleteIntake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 244);
            this.Controls.Add(this.dtpIntakeDate);
            this.Controls.Add(this.grpDeleteFoodItem);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDeleteIntake";
            this.Text = "deleteIntakeMenu";
            this.Load += new System.EventHandler(this.frmdeleteIntake_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mnuDeleteItem.ResumeLayout(false);
            this.grpDeleteFoodItem.ResumeLayout(false);
            this.grpDeleteFoodItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBackToMenu;
        private System.Windows.Forms.ContextMenuStrip mnuDeleteItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Button btnDeleteIntake;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.ComboBox cboDeleteItem;
        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.GroupBox grpDeleteFoodItem;
        private System.Windows.Forms.DateTimePicker dtpIntakeDate;
    }
}