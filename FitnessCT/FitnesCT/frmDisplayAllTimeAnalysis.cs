using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace FitnessCT
{
    public partial class frmDisplayAllTimeAnalysis : Form
    {
        UserSession session = UserSession.Instance;
        public frmDisplayAllTimeAnalysis()
        {
            InitializeComponent();
        }

        private void btnCloseAnalysis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDisplayAllTimeAnalysis_Load(object sender, EventArgs e)
        {

            int userID = session.GetUserID();
            Console.WriteLine("Analysis for userID is : " + userID);
            int[] results = Utility.GetAllTimeCalorieAnalysis(userID);

            string average = Convert.ToString(results[0]);
            lblAllTimeAverageDailyIntake.Text = average;

            string lowest = Convert.ToString(results[1]);
            lblAllTimeLowestIntake.Text = lowest;

            string highest = Convert.ToString(results[2]);
            lblAllTimeHighestIntake.Text = highest;

        }
    }
}
