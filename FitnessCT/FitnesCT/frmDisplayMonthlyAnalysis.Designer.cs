
namespace FitnessCT
{
    partial class frmDisplayMonthlyAnalysis
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCloseAnalysis = new System.Windows.Forms.Button();
            this.grpWeeklyReport = new System.Windows.Forms.GroupBox();
            this.lblMonthlyHighestIntake = new System.Windows.Forms.Label();
            this.lblMonthlyLowestIntake = new System.Windows.Forms.Label();
            this.lblMonthlyAverageDailyIntake = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMonthlyAnalysis = new System.Windows.Forms.Label();
            this.lblMonthlyReportLabel = new System.Windows.Forms.Label();
            this.grpWeeklyReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCloseAnalysis
            // 
            this.btnCloseAnalysis.Location = new System.Drawing.Point(200, 304);
            this.btnCloseAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseAnalysis.Name = "btnCloseAnalysis";
            this.btnCloseAnalysis.Size = new System.Drawing.Size(118, 41);
            this.btnCloseAnalysis.TabIndex = 4;
            this.btnCloseAnalysis.Text = "Close";
            this.btnCloseAnalysis.UseVisualStyleBackColor = true;
            this.btnCloseAnalysis.Click += new System.EventHandler(this.btnCloseAnalysis_Click);
            // 
            // grpWeeklyReport
            // 
            this.grpWeeklyReport.Controls.Add(this.lblMonthlyHighestIntake);
            this.grpWeeklyReport.Controls.Add(this.lblMonthlyLowestIntake);
            this.grpWeeklyReport.Controls.Add(this.lblMonthlyAverageDailyIntake);
            this.grpWeeklyReport.Controls.Add(this.label5);
            this.grpWeeklyReport.Controls.Add(this.label4);
            this.grpWeeklyReport.Controls.Add(this.label3);
            this.grpWeeklyReport.Controls.Add(this.label2);
            this.grpWeeklyReport.Controls.Add(this.lblMonthlyAnalysis);
            this.grpWeeklyReport.Location = new System.Drawing.Point(86, 78);
            this.grpWeeklyReport.Name = "grpWeeklyReport";
            this.grpWeeklyReport.Size = new System.Drawing.Size(352, 199);
            this.grpWeeklyReport.TabIndex = 7;
            this.grpWeeklyReport.TabStop = false;
            this.grpWeeklyReport.Text = "Details";
            // 
            // lblMonthlyHighestIntake
            // 
            this.lblMonthlyHighestIntake.AutoSize = true;
            this.lblMonthlyHighestIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyHighestIntake.Location = new System.Drawing.Point(222, 155);
            this.lblMonthlyHighestIntake.Name = "lblMonthlyHighestIntake";
            this.lblMonthlyHighestIntake.Size = new System.Drawing.Size(16, 18);
            this.lblMonthlyHighestIntake.TabIndex = 7;
            this.lblMonthlyHighestIntake.Text = "0";
            // 
            // lblMonthlyLowestIntake
            // 
            this.lblMonthlyLowestIntake.AutoSize = true;
            this.lblMonthlyLowestIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyLowestIntake.Location = new System.Drawing.Point(222, 125);
            this.lblMonthlyLowestIntake.Name = "lblMonthlyLowestIntake";
            this.lblMonthlyLowestIntake.Size = new System.Drawing.Size(16, 18);
            this.lblMonthlyLowestIntake.TabIndex = 6;
            this.lblMonthlyLowestIntake.Text = "0";
            // 
            // lblMonthlyAverageDailyIntake
            // 
            this.lblMonthlyAverageDailyIntake.AutoSize = true;
            this.lblMonthlyAverageDailyIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyAverageDailyIntake.Location = new System.Drawing.Point(222, 59);
            this.lblMonthlyAverageDailyIntake.Name = "lblMonthlyAverageDailyIntake";
            this.lblMonthlyAverageDailyIntake.Size = new System.Drawing.Size(16, 18);
            this.lblMonthlyAverageDailyIntake.TabIndex = 5;
            this.lblMonthlyAverageDailyIntake.Text = "0";
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
            // lblMonthlyAnalysis
            // 
            this.lblMonthlyAnalysis.AutoSize = true;
            this.lblMonthlyAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyAnalysis.Location = new System.Drawing.Point(6, 28);
            this.lblMonthlyAnalysis.Name = "lblMonthlyAnalysis";
            this.lblMonthlyAnalysis.Size = new System.Drawing.Size(118, 18);
            this.lblMonthlyAnalysis.TabIndex = 0;
            this.lblMonthlyAnalysis.Text = "Monthly Analysis";
            // 
            // lblMonthlyReportLabel
            // 
            this.lblMonthlyReportLabel.AutoSize = true;
            this.lblMonthlyReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyReportLabel.Location = new System.Drawing.Point(148, 26);
            this.lblMonthlyReportLabel.Name = "lblMonthlyReportLabel";
            this.lblMonthlyReportLabel.Size = new System.Drawing.Size(212, 31);
            this.lblMonthlyReportLabel.TabIndex = 6;
            this.lblMonthlyReportLabel.Text = "Monthly Report";
            // 
            // frmDisplayMonthlyAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 389);
            this.Controls.Add(this.grpWeeklyReport);
            this.Controls.Add(this.lblMonthlyReportLabel);
            this.Controls.Add(this.btnCloseAnalysis);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDisplayMonthlyAnalysis";
            this.Text = "monthlyAnalysisMenu";
            this.Load += new System.EventHandler(this.frmDisplayMonthlyAnalysis_Load);
            this.grpWeeklyReport.ResumeLayout(false);
            this.grpWeeklyReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnCloseAnalysis;
        private System.Windows.Forms.GroupBox grpWeeklyReport;
        private System.Windows.Forms.Label lblMonthlyHighestIntake;
        private System.Windows.Forms.Label lblMonthlyLowestIntake;
        private System.Windows.Forms.Label lblMonthlyAverageDailyIntake;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMonthlyAnalysis;
        private System.Windows.Forms.Label lblMonthlyReportLabel;
    }
}