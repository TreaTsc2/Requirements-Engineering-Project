using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace FitnessCT
{
    public partial class frmRecordIntake : Form
    {

        frmManageIntake parent;
        UserSession session = UserSession.Instance;
        public frmRecordIntake()
        {
            InitializeComponent();
        }

        public frmRecordIntake(frmManageIntake Parent)
        {
            
            InitializeComponent();
            parent = Parent;
        }

     

        private void changePortionLabel(object sender, EventArgs e)
        {
            string selectedFood = cboSelectFood.SelectedItem.ToString();

            if (selectedFood == "White Bread")
            {
                lblPortion.Text = "Portions (one slice):";
                lblCaloriesPerPortion.Text = "Calories per portion: 79";
            }

            else if (selectedFood == "Medium Red Apple")
            {
                lblPortion.Text = "Portions (Whole Apple approx 70g):";
                lblCaloriesPerPortion.Text = "Calories per portion: 95";
            }

            else if (selectedFood == "Apple Juice")
            {
                lblPortion.Text = "Portions (100ml):";
                lblCaloriesPerPortion.Text = "Calories per portion: 41";
            }

            else if (selectedFood == "Medium Banana")
            {
                lblPortion.Text = "Portions (Whole Banana approx 118g):";
                lblCaloriesPerPortion.Text = "Calories per portion: 105";
            }

        }


        
        private void btnAddIntake_Click(object sender, EventArgs e)
        {
            string mealType = cboMealType.GetItemText(cboMealType.SelectedItem);
            bool dotFound = false;
            bool numberAfterDotFound = false;
            if (String.IsNullOrEmpty(mealType))
            {
                MessageBox.Show("Please select a meal type", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMealType.Focus();
                return;
            }
            else if (txtPortionSize.Text.Length <= 0)
            {
                MessageBox.Show("Please select enter the portion size!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            if (double.TryParse(txtPortionSize.Text, out double portionSize))
            {
                if (portionSize <= 99.9)
                {
                    for (int i = 0; i < txtPortionSize.Text.Length; i++)
                    {

                        if (!char.IsDigit(txtPortionSize.Text[i]) && txtPortionSize.Text[i] != '.')
                        {
                            MessageBox.Show("Invalid portion size. \n Portion must be a 3 digit number with a maximum of 1 number after decimal point", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        else if (txtPortionSize.Text[i] == '.')
                        {
                            if (!dotFound)
                            {
                                dotFound = true;

                            }
                            else
                            {
                                MessageBox.Show("Invalid portion size. Only 1 decimal point followed by 1 number is allowed", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else if (char.IsDigit(txtPortionSize.Text[i]) && dotFound)
                        {

                            if (!numberAfterDotFound) { numberAfterDotFound = true; }
                            else
                            {
                                MessageBox.Show("Invalid portion size.Only 1 digit is allowed after the decimal point.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPortionSize.Focus();
                                return;
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Portion size is too large!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid portion entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPortionSize.Focus();
                return;
            }

            



            int userID = session.GetUserID();
            int mealTypeID;
            bool getMealTypeID = int.TryParse(cboMealType.SelectedValue.ToString(), out mealTypeID);
            if (getMealTypeID)
            {
                Console.WriteLine("Selected mealTypeID is : " + mealTypeID);
            }
            else
            {
                Console.WriteLine("Couldn't get mealTypeID");
            }

            int foodItemID;
            bool getFoodItemID = int.TryParse(cboSelectFood.SelectedValue.ToString(), out foodItemID);
            if (getFoodItemID)
            {
                Console.WriteLine("Selected getFoodItemID is : " + foodItemID);
            }
            else
            {
                Console.WriteLine("Couldn't get getFoodItemID");
            }

            portionSize = Convert.ToDouble(txtPortionSize.Text);
            int totalCalories = FoodIntake.GetCalories(Convert.ToDecimal(portionSize), Utility.GetFoodItemCaloriesPerUnit(foodItemID));
            if (totalCalories > 9999) {
                MessageBox.Show("Total Calories cannot exceed 9999", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int intakeID = FoodIntake.GetNextIntakeID();
            FoodIntake aFoodIntake = new FoodIntake(intakeID, DateTime.Today, mealTypeID, Convert.ToDecimal(txtPortionSize.Text), userID, foodItemID, totalCalories);

            aFoodIntake.AddFoodIntake();

            MessageBox.Show("Intake Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void cboMealType_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void frmRecordIntake_Load(object sender, EventArgs e)
        {
            UserSession session = UserSession.Instance;
            int userID = session.GetUserID();
            try
            {
                DataSet UserFoodItems = Utility.LoadAllFoodItems(userID);

                cboSelectFood.DisplayMember = "FoodName";
                cboSelectFood.ValueMember = "FoodItemID";
                cboSelectFood.DataSource = UserFoodItems.Tables["FoodItems"];

                DataSet MealTypes = Utility.LoadMealTypes();

                cboMealType.DisplayMember = "MealTypeName";
                cboMealType.ValueMember = "MealTypeID";
                cboMealType.DataSource = MealTypes.Tables["MealType"];

                cboSelectFood.SelectedIndex = -1; //stops a food item being selected immediately after the form loads up
                grpRecordIntakeDetails.Visible = false;
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during loading activity levels
                MessageBox.Show("An error occurred while loading user food items: " + ex.Message);
            }

        }
        int caloriesPerUnit;
        private void cboSelectFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            int foodItemID;



            
            string foodName = cboSelectFood.GetItemText(cboSelectFood.SelectedItem);

            if (foodName.Length > 1 && grpRecordIntakeDetails.Visible == false)
            {
                grpRecordIntakeDetails.Visible = true; // FoodItem Details appear after food item is selected
            }


            if (foodName.Length > 1 && grpRecordIntakeDetails.Visible == true)
            {
            bool getFoodID = int.TryParse(cboSelectFood.SelectedValue.ToString(), out foodItemID);
                 if (getFoodID)
                    {
                       Console.WriteLine("Selected food item ID is : " + foodItemID);
                 }
                 else
                 {
                     Console.WriteLine("Couldn't get food item ID");
                 }
                 UserSession session = UserSession.Instance;
                 int userID = session.GetUserID();
                 caloriesPerUnit = Utility.GetFoodItemCaloriesPerUnit(foodItemID);
                 Console.WriteLine("Calories of item : " + caloriesPerUnit.ToString());

                lblCaloriesPerPortion.Text = "Calories Per Portion : " + caloriesPerUnit.ToString();
                String portionName = FoodItem.GetPortionNameFromFoodItem(foodItemID);
                lblPortionName.Text = portionName;

            }

        }

       
        private void txtPortionSize_TextChanged(object sender, EventArgs e)
        {
            
            double caloriesTotal;
            double portionSize;

            bool isConversionSuccessful = double.TryParse(txtPortionSize.Text, out portionSize);
            
            if (isConversionSuccessful)
            {
                // If the conversion is successful, you can use portionSize
                caloriesTotal = caloriesPerUnit * portionSize;
                lbltotalCalories.Text = "Cals total: " + caloriesTotal.ToString();
            }
            else
            {
                // If the conversion fails, you can alert the user and handle accordingly
                lbltotalCalories.Text = "Enter valid Portion.";
            }

        }
       


        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
