
namespace FitnessCT
{
    partial class frmDisplayMainMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.bntWeightIn = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.bntFoodItems = new System.Windows.Forms.Button();
            this.btnIntake = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblviewCalories = new System.Windows.Forms.Label();
            this.dtpIntakeDate = new System.Windows.Forms.DateTimePicker();
            this.grdIntake = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpIntakeDetails = new System.Windows.Forms.GroupBox();
            this.lblCaloriesRemaining = new System.Windows.Forms.Label();
            this.lblCalorieGoal = new System.Windows.Forms.Label();
            this.lblTotalCaloriesFromIntake = new System.Windows.Forms.Label();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIntake)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpIntakeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mnuMainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogOut});
            this.mnuMainMenu.Location = new System.Drawing.Point(556, 8);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuMainMenu.Size = new System.Drawing.Size(66, 24);
            this.mnuMainMenu.TabIndex = 0;
            // 
            // mnuLogOut
            // 
            this.mnuLogOut.AccessibleName = "mnuLogOut";
            this.mnuLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuLogOut.Name = "mnuLogOut";
            this.mnuLogOut.Size = new System.Drawing.Size(60, 20);
            this.mnuLogOut.Text = "Log out";
            this.mnuLogOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mnuLogOut.Click += new System.EventHandler(this.mnuLogOut_Click_1);
            // 
            // bntWeightIn
            // 
            this.bntWeightIn.Location = new System.Drawing.Point(21, 254);
            this.bntWeightIn.Margin = new System.Windows.Forms.Padding(2);
            this.bntWeightIn.Name = "bntWeightIn";
            this.bntWeightIn.Size = new System.Drawing.Size(135, 49);
            this.bntWeightIn.TabIndex = 4;
            this.bntWeightIn.Text = "Weigh In";
            this.bntWeightIn.UseVisualStyleBackColor = true;
            this.bntWeightIn.Click += new System.EventHandler(this.bntProfile_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(21, 192);
            this.btnAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(135, 49);
            this.btnAnalysis.TabIndex = 3;
            this.btnAnalysis.Text = "Analysis";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // bntFoodItems
            // 
            this.bntFoodItems.Location = new System.Drawing.Point(21, 123);
            this.bntFoodItems.Margin = new System.Windows.Forms.Padding(2);
            this.bntFoodItems.Name = "bntFoodItems";
            this.bntFoodItems.Size = new System.Drawing.Size(135, 49);
            this.bntFoodItems.TabIndex = 2;
            this.bntFoodItems.Text = "Food Items";
            this.bntFoodItems.UseVisualStyleBackColor = true;
            this.bntFoodItems.Click += new System.EventHandler(this.mnuLogOut_Click);
            // 
            // btnIntake
            // 
            this.btnIntake.Location = new System.Drawing.Point(21, 59);
            this.btnIntake.Margin = new System.Windows.Forms.Padding(2);
            this.btnIntake.Name = "btnIntake";
            this.btnIntake.Size = new System.Drawing.Size(135, 49);
            this.btnIntake.TabIndex = 1;
            this.btnIntake.Text = "Food Intake";
            this.btnIntake.UseVisualStyleBackColor = true;
            this.btnIntake.Click += new System.EventHandler(this.btnAddIntake_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblviewCalories
            // 
            this.lblviewCalories.AutoSize = true;
            this.lblviewCalories.Location = new System.Drawing.Point(177, 16);
            this.lblviewCalories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblviewCalories.Name = "lblviewCalories";
            this.lblviewCalories.Size = new System.Drawing.Size(141, 13);
            this.lblviewCalories.TabIndex = 6;
            this.lblviewCalories.Text = "View Intake Breakdown for :";
            // 
            // dtpIntakeDate
            // 
            this.dtpIntakeDate.Location = new System.Drawing.Point(323, 12);
            this.dtpIntakeDate.MaxDate = new System.DateTime(2051, 7, 21, 0, 0, 0, 0);
            this.dtpIntakeDate.Name = "dtpIntakeDate";
            this.dtpIntakeDate.Size = new System.Drawing.Size(182, 20);
            this.dtpIntakeDate.TabIndex = 5;
            this.dtpIntakeDate.Value = new System.DateTime(2024, 4, 12, 0, 0, 0, 0);
            this.dtpIntakeDate.ValueChanged += new System.EventHandler(this.dtpIntakeDate_ValueChanged);
            // 
            // grdIntake
            // 
            this.grdIntake.AllowUserToAddRows = false;
            this.grdIntake.AllowUserToDeleteRows = false;
            this.grdIntake.AllowUserToResizeColumns = false;
            this.grdIntake.AllowUserToResizeRows = false;
            this.grdIntake.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdIntake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdIntake.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdIntake.Location = new System.Drawing.Point(2, 2);
            this.grdIntake.Margin = new System.Windows.Forms.Padding(2, 2, 1, 2);
            this.grdIntake.Name = "grdIntake";
            this.grdIntake.ReadOnly = true;
            this.grdIntake.RowHeadersVisible = false;
            this.grdIntake.RowHeadersWidth = 15;
            this.grdIntake.Size = new System.Drawing.Size(414, 240);
            this.grdIntake.TabIndex = 100;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.32098F));
            this.tableLayoutPanel1.Controls.Add(this.grdIntake, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(180, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.09859F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 265);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // grpIntakeDetails
            // 
            this.grpIntakeDetails.Controls.Add(this.lblCaloriesRemaining);
            this.grpIntakeDetails.Controls.Add(this.lblCalorieGoal);
            this.grpIntakeDetails.Controls.Add(this.lblTotalCaloriesFromIntake);
            this.grpIntakeDetails.Location = new System.Drawing.Point(180, 285);
            this.grpIntakeDetails.Name = "grpIntakeDetails";
            this.grpIntakeDetails.Size = new System.Drawing.Size(420, 70);
            this.grpIntakeDetails.TabIndex = 9;
            this.grpIntakeDetails.TabStop = false;
            this.grpIntakeDetails.Text = "Totals";
            // 
            // lblCaloriesRemaining
            // 
            this.lblCaloriesRemaining.AutoSize = true;
            this.lblCaloriesRemaining.Location = new System.Drawing.Point(261, 54);
            this.lblCaloriesRemaining.Name = "lblCaloriesRemaining";
            this.lblCaloriesRemaining.Size = new System.Drawing.Size(112, 13);
            this.lblCaloriesRemaining.TabIndex = 2;
            this.lblCaloriesRemaining.Text = "Calories Remaining : 0";
            // 
            // lblCalorieGoal
            // 
            this.lblCalorieGoal.AutoSize = true;
            this.lblCalorieGoal.Location = new System.Drawing.Point(288, 29);
            this.lblCalorieGoal.Name = "lblCalorieGoal";
            this.lblCalorieGoal.Size = new System.Drawing.Size(85, 13);
            this.lblCalorieGoal.TabIndex = 1;
            this.lblCalorieGoal.Text = "Calorie Goal   : 0";
            // 
            // lblTotalCaloriesFromIntake
            // 
            this.lblTotalCaloriesFromIntake.AutoSize = true;
            this.lblTotalCaloriesFromIntake.Location = new System.Drawing.Point(288, 16);
            this.lblTotalCaloriesFromIntake.Name = "lblTotalCaloriesFromIntake";
            this.lblTotalCaloriesFromIntake.Size = new System.Drawing.Size(86, 13);
            this.lblTotalCaloriesFromIntake.TabIndex = 0;
            this.lblTotalCaloriesFromIntake.Text = "Total Calories : 0";
            // 
            // frmDisplayMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 366);
            this.Controls.Add(this.grpIntakeDetails);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dtpIntakeDate);
            this.Controls.Add(this.lblviewCalories);
            this.Controls.Add(this.btnIntake);
            this.Controls.Add(this.bntFoodItems);
            this.Controls.Add(this.btnAnalysis);
            this.Controls.Add(this.bntWeightIn);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDisplayMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmDisplayMainMenu_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIntake)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpIntakeDetails.ResumeLayout(false);
            this.grpIntakeDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuLogOut;
        private System.Windows.Forms.Button bntWeightIn;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button bntFoodItems;
        private System.Windows.Forms.Button btnIntake;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblviewCalories;
        private System.Windows.Forms.DateTimePicker dtpIntakeDate;
        private System.Windows.Forms.DataGridView grdIntake;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpIntakeDetails;
        private System.Windows.Forms.Label lblTotalCaloriesFromIntake;
        private System.Windows.Forms.Label lblCalorieGoal;
        private System.Windows.Forms.Label lblCaloriesRemaining;
    }
}