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
    public partial class frmDisplayMainMenu : Form
    {
        UserSession session = UserSession.Instance;
        public frmDisplayMainMenu()
        {
            InitializeComponent();
            this.VisibleChanged += frmDisplayMainMenu_Activated;
        }




        private void bntProfile_Click(object sender, EventArgs e)
        {
            frmWeighInUser weighInMenu = new frmWeighInUser(this);
            this.Hide();
            weighInMenu.Show();
        }

        private void mnuLogOut_Click(object sender, EventArgs e)
        {

            frmManageItems foodItemMenu = new frmManageItems(this);
            this.Hide();
            foodItemMenu.Show();
        }

        private void mnuLogOut_Click_1(object sender, EventArgs e)
        {

            frmLoginUser loginForm = new frmLoginUser();
            this.Hide();
            loginForm.Show();
        }

        private void btnAddIntake_Click(object sender, EventArgs e)
        {
            frmManageIntake intakeMenu = new frmManageIntake(this);
            this.Hide();
            intakeMenu.Show();
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            frmSelectAnalysis analysisMenu = new frmSelectAnalysis(this);
            this.Hide();
            analysisMenu.Show();
        }

        private void frmDisplayMainMenu_Activated(object sender, EventArgs e)
        {
            UpdateIntakeData(DateTime.Today);

        }


        private void frmDisplayMainMenu_Load(object sender, EventArgs e)
        {
            dtpIntakeDate.MaxDate = DateTime.Today;
            dtpIntakeDate.Value = DateTime.Today;
            UpdateIntakeData(DateTime.Today);
        }

        private void UpdateIntakeData(DateTime date)
        {
            //GET ALL FOODS EATEN FOR THE DATE SPECIFIED
            dtpIntakeDate.MaxDate = DateTime.Today.AddDays(1);
            DataSet dsIntake = FoodIntake.getDailyIntake(session.GetUserID(), date);
            if (dsIntake != null && dsIntake.Tables.Count > 0)
            {
                grdIntake.DataSource = dsIntake.Tables["FoodIntake"];
            }
            else
            {
                MessageBox.Show("No data found for the selected date.");
            }
            int totalCalories = FoodIntake.GetTotalCaloriesForDay(session.GetUserID(), date);
            int calorieGoal = Account.GetCalorieGoal(session.GetUserID());
            lblTotalCaloriesFromIntake.Text = "Total Calories : " + Convert.ToString(totalCalories);
            lblCalorieGoal.Text = "Calorie Goal   : " + Convert.ToString((int)calorieGoal);
            lblCaloriesRemaining.Text = "Calories Remaining : " + Convert.ToString(calorieGoal - totalCalories);


        }
        private void dtpIntakeDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpIntakeDate.Value;
            UpdateIntakeData(selectedDate);

        }


    }

}
