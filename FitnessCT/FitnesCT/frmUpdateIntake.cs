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
    public partial class frmUpdateIntake : Form
    { 
        frmManageIntake parent;
        UserSession session = UserSession.Instance;
        public frmUpdateIntake()
        {
            InitializeComponent();
        }
        public frmUpdateIntake(frmManageIntake Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void mnuBackToMenu_Click(object sender, EventArgs e)
        {

            this.Close();
            parent.Visible = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCaloriesPerPortion_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateIntake_Click(object sender, EventArgs e)
        {
            double portionSize;
            int mealTypeID;
            string mealType = cboMealType.GetItemText(cboMealType.SelectedItem);
            bool dotFound = false;
            bool numberAfterDotFound = false;
            int valuesEnteredForUpdate = 0; // Checks if any values have been entered to be updated.
            if (String.IsNullOrEmpty(mealType))
            {
                mealTypeID = 0;
                
            }
            else
            {
                valuesEnteredForUpdate++;
            }
            if (String.IsNullOrEmpty(txtPortionSize.Text))
            {
                portionSize = 0;
                
            }
            else {
                    valuesEnteredForUpdate++;
                if (double.TryParse(txtPortionSize.Text, out portionSize))
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


            }

            if (valuesEnteredForUpdate == 0)
                {
                    MessageBox.Show("You need to enter at least one value to update", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            

            DialogResult userChoice = MessageBox.Show("Are you sure you want to update this item?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (userChoice == DialogResult.Yes)
            {
                int intakeID;
                bool getIntakeID = int.TryParse(cboSelectIntake.SelectedValue.ToString(), out intakeID);

                
                bool getMealTypeID = int.TryParse(cboMealType.SelectedValue.ToString(), out mealTypeID);



                
                
               
                
                int calories =  Convert.ToInt32(Utility.getCaloriesPerUnitFromIntake(intakeID) * portionSize);
                Console.WriteLine("New Calories in intake are : " + calories);


                bool updated = FoodIntake.updateIntakeDetails(intakeID, Convert.ToDecimal(portionSize), mealTypeID,calories);

                if (updated)
                {
                    

                    //Refresh the combo box so the updated intake appears.
                    int userID = session.GetUserID();
                    DataSet UserFoodIntake = Utility.LoadSelectedFoodIntake(userID, dtpUpdateIntakeDate.Value);

                    cboSelectIntake.DisplayMember = "FoodName";
                    cboSelectIntake.ValueMember = "IntakeID";
                    cboSelectIntake.DataSource = UserFoodIntake.Tables["FoodIntake"];
                    cboSelectIntake.SelectedIndex = -1;

                    MessageBox.Show("Intake updated successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grpUpdateIntakeDetails.Visible = false;
                }


                else
                {
                    MessageBox.Show("An error occured during deletion.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
               

                
            }


            
        }

        private void frmUpdateIntake_Load(object sender, EventArgs e)
        {
            grpUpdateIntakeDetails.Visible = false;
            dtpUpdateIntakeDate.MaxDate = DateTime.Today;
        }

        private void dtpUpdateIntakeDate_ValueChanged(object sender, EventArgs e)
        {
            int userID = session.GetUserID();
            Console.WriteLine("User ID is : " + userID + "\nDate is : " + dtpUpdateIntakeDate.Value);
            try
            {
                
                DataSet UserFoodIntake = Utility.LoadSelectedFoodIntake(userID, dtpUpdateIntakeDate.Value);
                if (UserFoodIntake != null)
                {
                    cboSelectIntake.DisplayMember = "FoodName";
                    cboSelectIntake.ValueMember = "IntakeID";
                    cboSelectIntake.DataSource = UserFoodIntake.Tables["FoodIntake"];
                    cboSelectIntake.SelectedIndex = -1;

                    DataSet MealTypes = Utility.LoadMealTypes();

                    cboMealType.DisplayMember = "MealTypeName";
                    cboMealType.ValueMember = "MealTypeID";
                    cboMealType.DataSource = MealTypes.Tables["MealType"];
                    cboMealType.SelectedIndex = -1;
                    if (UserFoodIntake.Tables["FoodIntake"].Rows.Count > 0)
                    {
                        grpUpdateIntakeDetails.Visible = true;
                    }
                }
                

            }
            catch (Exception ex)
            {
                // Handle any errors that occur during loading activity levels
                MessageBox.Show("An error occurred while loading user foodIntake: " + ex.Message);
            }

            
            
            
        }

        private void txtPortionSize_TextChanged(object sender, EventArgs e)
        {

            
            
            double portionSize ;

            int intakeID;
            bool getIntakeID = int.TryParse(cboSelectIntake.SelectedValue.ToString(), out intakeID);
            int caloriesPerPortion = Utility.getCaloriesPerUnitFromIntake(intakeID);
            //bool getFoodItemID = int.TryParse(cboSelectIntake.SelectedValue.ToString(), out foodItemID);

            bool isConversionSuccessful = double.TryParse(txtPortionSize.Text, out portionSize);

            if (isConversionSuccessful)
            {
                double totalCalories = caloriesPerPortion * portionSize;
                lbltotalCalories.Text = "Cals total: " + Convert.ToInt32(totalCalories).ToString();
            }
            else
            {
                
                lbltotalCalories.Text = "Enter valid Portion.";
            }
        }

        private void grpUpdateIntakeDetails_Enter(object sender, EventArgs e)
        {

        }


        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboSelectIntake_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            if (grpUpdateIntakeDetails.Visible == true && cboSelectIntake.SelectedIndex != -1)
            {
                int intakeID;
                bool getIntakeID = int.TryParse(cboSelectIntake.SelectedValue.ToString(), out intakeID);
                int caloriesPerPortion = Utility.getCaloriesPerUnitFromIntake(intakeID);
                int foodintakeID = FoodIntake.GetFoodItemFromIntake(intakeID);
                String PortionName = FoodItem.GetPortionNameFromFoodItem(foodintakeID);
                lblCaloriesPerPortion.Text = "Calories per portion: " + Convert.ToString(caloriesPerPortion);
                lblPortionName.Text = PortionName;
            }
        }
    }
}
