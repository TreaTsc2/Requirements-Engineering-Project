namespace FitnessCT
{
    partial class frmDisplayAllTimeAnalysis
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
            this.grpWeeklyReport = new System.Windows.Forms.GroupBox();
            this.lblAllTimeHighestIntake = new System.Windows.Forms.Label();
            this.lblAllTimeLowestIntake = new System.Windows.Forms.Label();
            this.lblAllTimeAverageDailyIntake = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAllTimeAnalysis = new System.Windows.Forms.Label();
            this.lblAllTimeReportLabel = new System.Windows.Forms.Label();
            this.btnCloseAnalysis = new System.Windows.Forms.Button();
            this.grpWeeklyReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWeeklyReport
            // 
            this.grpWeeklyReport.Controls.Add(this.lblAllTimeHighestIntake);
            this.grpWeeklyReport.Controls.Add(this.lblAllTimeLowestIntake);
            this.grpWeeklyReport.Controls.Add(this.lblAllTimeAverageDailyIntake);
            this.grpWeeklyReport.Controls.Add(this.label5);
            this.grpWeeklyReport.Controls.Add(this.label4);
            this.grpWeeklyReport.Controls.Add(this.label3);
            this.grpWeeklyReport.Controls.Add(this.label2);
            this.grpWeeklyReport.Controls.Add(this.lblAllTimeAnalysis);
            this.grpWeeklyReport.Location = new System.Drawing.Point(67, 101);
            this.grpWeeklyReport.Name = "grpWeeklyReport";
            this.grpWeeklyReport.Size = new System.Drawing.Size(352, 199);
            this.grpWeeklyReport.TabIndex = 10;
            this.grpWeeklyReport.TabStop = false;
            this.grpWeeklyReport.Text = "Details";
            // 
            // lblAllTimeHighestIntake
            // 
            this.lblAllTimeHighestIntake.AutoSize = true;
            this.lblAllTimeHighestIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTimeHighestIntake.Location = new System.Drawing.Point(222, 155);
            this.lblAllTimeHighestIntake.Name = "lblAllTimeHighestIntake";
            this.lblAllTimeHighestIntake.Size = new System.Drawing.Size(16, 18);
            this.lblAllTimeHighestIntake.TabIndex = 7;
            this.lblAllTimeHighestIntake.Text = "0";
            // 
            // lblAllTimeLowestIntake
            // 
            this.lblAllTimeLowestIntake.AutoSize = true;
            this.lblAllTimeLowestIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTimeLowestIntake.Location = new System.Drawing.Point(222, 125);
            this.lblAllTimeLowestIntake.Name = "lblAllTimeLowestIntake";
            this.lblAllTimeLowestIntake.Size = new System.Drawing.Size(16, 18);
            this.lblAllTimeLowestIntake.TabIndex = 6;
            this.lblAllTimeLowestIntake.Text = "0";
            // 
            // lblAllTimeAverageDailyIntake
            // 
            this.lblAllTimeAverageDailyIntake.AutoSize = true;
            this.lblAllTimeAverageDailyIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTimeAverageDailyIntake.Location = new System.Drawing.Point(222, 59);
            this.lblAllTimeAverageDailyIntake.Name = "lblAllTimeAverageDailyIntake";
            this.lblAllTimeAverageDailyIntake.Size = new System.Drawing.Size(16, 18);
            this.lblAllTimeAverageDailyIntake.TabIndex = 5;
            this.lblAllTimeAverageDailyIntake.Text = "0";
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
            // lblAllTimeAnalysis
            // 
            this.lblAllTimeAnalysis.AutoSize = true;
            this.lblAllTimeAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTimeAnalysis.Location = new System.Drawing.Point(6, 28);
            this.lblAllTimeAnalysis.Name = "lblAllTimeAnalysis";
            this.lblAllTimeAnalysis.Size = new System.Drawing.Size(118, 18);
            this.lblAllTimeAnalysis.TabIndex = 0;
            this.lblAllTimeAnalysis.Text = "All TIme Analysis";
            // 
            // lblAllTimeReportLabel
            // 
            this.lblAllTimeReportLabel.AutoSize = true;
            this.lblAllTimeReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTimeReportLabel.Location = new System.Drawing.Point(129, 49);
            this.lblAllTimeReportLabel.Name = "lblAllTimeReportLabel";
            this.lblAllTimeReportLabel.Size = new System.Drawing.Size(215, 31);
            this.lblAllTimeReportLabel.TabIndex = 9;
            this.lblAllTimeReportLabel.Text = "All Time Report";
            // 
            // btnCloseAnalysis
            // 
            this.btnCloseAnalysis.Location = new System.Drawing.Point(181, 327);
            this.btnCloseAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseAnalysis.Name = "btnCloseAnalysis";
            this.btnCloseAnalysis.Size = new System.Drawing.Size(118, 41);
            this.btnCloseAnalysis.TabIndex = 8;
            this.btnCloseAnalysis.Text = "Close";
            this.btnCloseAnalysis.UseVisualStyleBackColor = true;
            this.btnCloseAnalysis.Click += new System.EventHandler(this.btnCloseAnalysis_Click);
            // 
            // frmDisplayAllTimeAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 389);
            this.Controls.Add(this.grpWeeklyReport);
            this.Controls.Add(this.lblAllTimeReportLabel);
            this.Controls.Add(this.btnCloseAnalysis);
            this.Name = "frmDisplayAllTimeAnalysis";
            this.Text = "frmDisplayAllTimeAnalysis";
            this.Load += new System.EventHandler(this.frmDisplayAllTimeAnalysis_Load);
            this.grpWeeklyReport.ResumeLayout(false);
            this.grpWeeklyReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWeeklyReport;
        private System.Windows.Forms.Label lblAllTimeHighestIntake;
        private System.Windows.Forms.Label lblAllTimeLowestIntake;
        private System.Windows.Forms.Label lblAllTimeAverageDailyIntake;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAllTimeAnalysis;
        private System.Windows.Forms.Label lblAllTimeReportLabel;
        private System.Windows.Forms.Button btnCloseAnalysis;
    }
}