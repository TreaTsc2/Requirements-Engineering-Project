﻿
namespace FitnessCT
{
    partial class frmDeleteItem
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
            this.mnuDeleteItem = new System.Windows.Forms.MenuStrip();
            this.mnuBackToManageItems = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackToMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cboSelectItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.mnuDeleteItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuDeleteItem
            // 
            this.mnuDeleteItem.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mnuDeleteItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackToManageItems});
            this.mnuDeleteItem.Location = new System.Drawing.Point(0, 0);
            this.mnuDeleteItem.Name = "mnuDeleteItem";
            this.mnuDeleteItem.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.mnuDeleteItem.Size = new System.Drawing.Size(436, 24);
            this.mnuDeleteItem.TabIndex = 0;
            this.mnuDeleteItem.Text = "menuStrip1";
            // 
            // mnuBackToManageItems
            // 
            this.mnuBackToManageItems.Name = "mnuBackToManageItems";
            this.mnuBackToManageItems.Size = new System.Drawing.Size(44, 22);
            this.mnuBackToManageItems.Text = "Back";
            this.mnuBackToManageItems.Click += new System.EventHandler(this.mnuBackToManageItems_Click);
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
            // cboSelectItem
            // 
            this.cboSelectItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectItem.FormattingEnabled = true;
            this.cboSelectItem.Location = new System.Drawing.Point(155, 69);
            this.cboSelectItem.Margin = new System.Windows.Forms.Padding(2);
            this.cboSelectItem.Name = "cboSelectItem";
            this.cboSelectItem.Size = new System.Drawing.Size(131, 21);
            this.cboSelectItem.TabIndex = 1;
            this.cboSelectItem.SelectedIndexChanged += new System.EventHandler(this.cboSelectItem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Select Item:";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(151, 133);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(146, 43);
            this.btnDeleteItem.TabIndex = 30;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // frmDeleteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 244);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.cboSelectItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuDeleteItem);
            this.MainMenuStrip = this.mnuDeleteItem;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDeleteItem";
            this.Text = "deleteItemMenu";
            this.Load += new System.EventHandler(this.frmDeleteItem_Load);
            this.mnuDeleteItem.ResumeLayout(false);
            this.mnuDeleteItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuDeleteItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBackToMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cboSelectItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBackToManageItems;
    }
}