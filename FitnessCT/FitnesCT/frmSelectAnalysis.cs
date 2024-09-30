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
    public partial class frmSelectAnalysis : Form
    {
        frmDisplayMainMenu parent;

        public frmSelectAnalysis()
        {
            InitializeComponent();
        }

        public frmSelectAnalysis(frmDisplayMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnWeeklyAnalysis_Click(object sender, EventArgs e)
        {
            frmDisplayWeeklyAnalysis weeklyAnalysisMenu = new frmDisplayWeeklyAnalysis();
            weeklyAnalysisMenu.Show();
        }

        private void btnMonthlyAnalysis_Click(object sender, EventArgs e)
        {
            frmDisplayMonthlyAnalysis monthlyAnalysisMenu = new frmDisplayMonthlyAnalysis();
            monthlyAnalysisMenu.Show();
        }

        private void btnAllTimeAnalysis_Click(object sender, EventArgs e)
        {
            frmDisplayAllTimeAnalysis AllTimeAnalysis = new frmDisplayAllTimeAnalysis();
            AllTimeAnalysis.Show();
        }
    }
}
