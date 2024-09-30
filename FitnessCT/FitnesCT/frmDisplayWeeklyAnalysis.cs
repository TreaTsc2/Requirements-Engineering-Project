using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCT
{
    public partial class frmDisplayWeeklyAnalysis : Form
    {
        UserSession session = UserSession.Instance;
        public frmDisplayWeeklyAnalysis()
        {
            InitializeComponent();
        }


        private void frmDisplauWeeklyAnalysis_Load(object sender, EventArgs e)
        {
            int userID = session.GetUserID();
            Console.WriteLine("Analysis for userID is : " + userID);
            int[] results = Utility.GetCalorieAnalysis(userID, 1);

            string average = Convert.ToString(results[0]);
            lblWeeklyAverageDailyIntake.Text = average;

            string lowest = Convert.ToString(results[1]);
            lblWeeklyLowestIntake.Text = lowest;

            string highest = Convert.ToString(results[2]);
            lblWeeklyHighestIntake.Text = highest;
        }

        private void btnCloseAnalysis_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
