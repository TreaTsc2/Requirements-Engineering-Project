
namespace FitnessCT
{
    partial class frmDisplayWeeklyAnalysis
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
            this.btnCloseAnalysis = new System.Windows.Forms.Button();
            this.lblWeeklyReportLabel = new System.Windows.Forms.Label();
            this.grpWeeklyReport = new System.Windows.Forms.GroupBox();
            this.lblWeeklyHighestIntake = new System.Windows.Forms.Label();
            this.lblWeeklyLowestIntake = new System.Windows.Forms.Label();
            this.lblWeeklyAverageDailyIntake = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpWeeklyReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseAnalysis
            // 
            this.btnCloseAnalysis.Location = new System.Drawing.Point(191, 301);
            this.btnCloseAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseAnalysis.Name = "btnCloseAnalysis";
            this.btnCloseAnalysis.Size = new System.Drawing.Size(118, 41);
            this.btnCloseAnalysis.TabIndex = 3;
            this.btnCloseAnalysis.Text = "Close";
            this.btnCloseAnalysis.UseVisualStyleBackColor = true;
            this.btnCloseAnalysis.Click += new System.EventHandler(this.btnCloseAnalysis_Click);
            // 
            // lblWeeklyReportLabel
            // 
            this.lblWeeklyReportLabel.AutoSize = true;
            this.lblWeeklyReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyReportLabel.Location = new System.Drawing.Point(137, 37);
            this.lblWeeklyReportLabel.Name = "lblWeeklyReportLabel";
            this.lblWeeklyReportLabel.Size = new System.Drawing.Size(205, 31);
            this.lblWeeklyReportLabel.TabIndex = 4;
            this.lblWeeklyReportLabel.Text = "Weekly Report";
            // 
            // grpWeeklyReport
            // 
            this.grpWeeklyReport.Controls.Add(this.lblWeeklyHighestIntake);
            this.grpWeeklyReport.Controls.Add(this.lblWeeklyLowestIntake);
            this.grpWeeklyReport.Controls.Add(this.lblWeeklyAverageDailyIntake);
            this.grpWeeklyReport.Controls.Add(this.label5);
            this.grpWeeklyReport.Controls.Add(this.label4);
            this.grpWeeklyReport.Controls.Add(this.label3);
            this.grpWeeklyReport.Controls.Add(this.label2);
            this.grpWeeklyReport.Controls.Add(this.label1);
            this.grpWeeklyReport.Location = new System.Drawing.Point(68, 83);
            this.grpWeeklyReport.Name = "grpWeeklyReport";
            this.grpWeeklyReport.Size = new System.Drawing.Size(352, 199);
            this.grpWeeklyReport.TabIndex = 5;
            this.grpWeeklyReport.TabStop = false;
            this.grpWeeklyReport.Text = "Details";
            // 
            // lblWeeklyHighestIntake
            // 
            this.lblWeeklyHighestIntake.AutoSize = true;
            this.lblWeeklyHighestIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyHighestIntake.Location = new System.Drawing.Point(222, 155);
            this.lblWeeklyHighestIntake.Name = "lblWeeklyHighestIntake";
            this.lblWeeklyHighestIntake.Size = new System.Drawing.Size(16, 18);
            this.lblWeeklyHighestIntake.TabIndex = 7;
            this.lblWeeklyHighestIntake.Text = "0";
            // 
            // lblWeeklyLowestIntake
            // 
            this.lblWeeklyLowestIntake.AutoSize = true;
            this.lblWeeklyLowestIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyLowestIntake.Location = new System.Drawing.Point(222, 125);
            this.lblWeeklyLowestIntake.Name = "lblWeeklyLowestIntake";
            this.lblWeeklyLowestIntake.Size = new System.Drawing.Size(16, 18);
            this.lblWeeklyLowestIntake.TabIndex = 6;
            this.lblWeeklyLowestIntake.Text = "0";
            // 
            // lblWeeklyAverageDailyIntake
            // 
            this.lblWeeklyAverageDailyIntake.AutoSize = true;
            this.lblWeeklyAverageDailyIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyAverageDailyIntake.Location = new System.Drawing.Point(222, 59);
            this.lblWeeklyAverageDailyIntake.Name = "lblWeeklyAverageDailyIntake";
            this.lblWeeklyAverageDailyIntake.Size = new System.Drawing.Size(16, 18);
            this.lblWeeklyAverageDailyIntake.TabIndex = 5;
            this.lblWeeklyAverageDailyIntake.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(222, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kcals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Highest intake in a day:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lowest intake in a day:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average daily intake";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weekly Analysis";
            // 
            // frmDisplayWeeklyAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 389);
            this.Controls.Add(this.grpWeeklyReport);
            this.Controls.Add(this.lblWeeklyReportLabel);
            this.Controls.Add(this.btnCloseAnalysis);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDisplayWeeklyAnalysis";
            this.Text = "Weekly Analysis";
            this.Load += new System.EventHandler(this.frmDisplauWeeklyAnalysis_Load);
            this.grpWeeklyReport.ResumeLayout(false);
            this.grpWeeklyReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCloseAnalysis;
        private System.Windows.Forms.Label lblWeeklyReportLabel;
        private System.Windows.Forms.GroupBox grpWeeklyReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWeeklyHighestIntake;
        private System.Windows.Forms.Label lblWeeklyLowestIntake;
        private System.Windows.Forms.Label lblWeeklyAverageDailyIntake;
        private System.Windows.Forms.Label label5;
    }
}