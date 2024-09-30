using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FitnessCT
{
    public partial class frmUpdateItem : Form
    {
        frmManageItems parent;

        public frmUpdateItem()
        {

            InitializeComponent();
        }
        public frmUpdateItem(frmManageItems Parent)
        {
            InitializeComponent();
            parent = Parent;

        }


     

        private void btnSaveItemUpdate_Click(object sender, EventArgs e)
        {


            UserSession session = UserSession.Instance;
            int userID = session.GetUserID();
            int caloriesPerPortionUpdate;
            string nameUpdate = txtFoodName.Text;
            int test;
            int foodItemID = 0;

            string portionUpdate = txtPortion.Text;
            string foodName = cboSelectFood.GetItemText(cboSelectFood.SelectedItem);

            if (txtFoodName.Text == "" && txtCaloriesPerPortion.Text == "" && txtPortion.Text == "") {
                MessageBox.Show("Please enter at least one new value to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Utility.ValidateIfFoodItemAlreadyExists(userID, txtFoodName.Text) != "-1" && txtFoodName.Text != foodName.ToString())
            {
                MessageBox.Show("You already added a food item with same name. \n Please enter a different name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtCaloriesPerPortion.Text == "")
            {
                caloriesPerPortionUpdate = 0;
            }

            else {

                if (!int.TryParse(txtCaloriesPerPortion.Text, out test) || test <= 0 || test> 3000) {
                    {
                        MessageBox.Show("Calories must be a whole number between 1 and 3000 calories", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCaloriesPerPortion.Focus();
                        return;
                        }
                  }
                caloriesPerPortionUpdate = Convert.ToInt32(txtCaloriesPerPortion.Text);
            }

            if (cboSelectFood.SelectedValue != null)
            {
                bool getFoodID = int.TryParse(cboSelectFood.SelectedValue.ToString(), out foodItemID);
                if (getFoodID)
                {
                    Console.WriteLine("Selected food item ID is : " + foodItemID);
                }
                else
                {
                    Console.WriteLine("Couldn't get food item ID");
                    return;
                }
            }

            Console.WriteLine("FoodItemID Being entered is : " + foodItemID +
                              "\nnameUpdate Being entered is : " + nameUpdate +
                              "\ncaloriesPerPortionUpdate Being entered is : " + caloriesPerPortionUpdate + 
                              "\nportionUpdate Being entered is : " + portionUpdate); //testing
            if (FoodItem.UpdateItemDetails(foodItemID ,nameUpdate, caloriesPerPortionUpdate, portionUpdate))
            {
                MessageBox.Show("Item Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPortion.Text = "";
                txtFoodName.Text = "";
                txtCaloriesPerPortion.Text = "";


                DataSet UserFoodItems = Utility.LoadUserFoodItems(userID);

                cboSelectFood.DisplayMember = "FoodName";
                cboSelectFood.ValueMember = "FoodItemID";
                cboSelectFood.DataSource = UserFoodItems.Tables["FoodItems"];

                cboSelectFood.SelectedIndex = -1; //stops a food item being selected immediately after the form loads up
                grpUpdateItemDetails.Visible = false; // FoodItem Details appear after food item is selecterd
            }
            else {
                MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cboSelectFood_SelectedIndexChanged(object sender, EventArgs e)
        {

            

            string foodName = cboSelectFood.GetItemText(cboSelectFood.SelectedItem);
            
            Console.WriteLine("Selected value length is : " + foodName.Length);

            

            if (foodName.Length > 1 && grpUpdateItemDetails.Visible == false)
            {
               grpUpdateItemDetails.Visible = true; // FoodItem Details appear after food item is selected
               
           }
        }

        private void frmUpdateItem_Load(object sender, EventArgs e)
        {
                grpUpdateItemDetails.Visible = false;
                UserSession session = UserSession.Instance;
                int userID = session.GetUserID();
                Console.WriteLine("The current user ID is :" + userID);//For testing

                try
                {
                    DataSet UserFoodItems = Utility.LoadUserFoodItems(userID);

                    cboSelectFood.DisplayMember = "FoodName";
                    cboSelectFood.ValueMember = "FoodItemID";
                    cboSelectFood.DataSource = UserFoodItems.Tables["FoodItems"];

                    cboSelectFood.SelectedIndex = -1; //stops a food item being selected immediately after the form loads up
                    grpUpdateItemDetails.Visible = false; // FoodItem Details appear after food item is selecterd
            }
                catch (Exception ex)
                {
                    // Handle any errors that occur during loading activity levels
                    MessageBox.Show("An error occurred while loading user food items: " + ex.Message);
                }


            
        }
        private void mnuBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
