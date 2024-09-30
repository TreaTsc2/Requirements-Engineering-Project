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
    public partial class frmDeleteItem : Form
    {
        frmManageItems parent;
        public frmDeleteItem()
        {
            InitializeComponent();
        }
        public frmDeleteItem(frmManageItems Parent)
        {
            InitializeComponent();
            parent = Parent;
        }


        private void mnuBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }



        private void frmDeleteItem_Load(object sender, EventArgs e)
        {
            UserSession session = UserSession.Instance;
            int userID = session.GetUserID();
            Console.WriteLine("The current user ID is :" + userID);//For testing

            try
            {
                DataSet UserFoodItems = Utility.LoadUserFoodItems(userID);

                cboSelectItem.DisplayMember = "FoodName";
                cboSelectItem.ValueMember = "FoodItemID";
                cboSelectItem.DataSource = UserFoodItems.Tables["FoodItems"];
                cboSelectItem.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during loading activity levels
                MessageBox.Show("An error occurred while loading user food items: " + ex.Message);
            }

  
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int foodItemID = 0;
            if (cboSelectItem.SelectedValue == null)
            {
                MessageBox.Show("You have not selected an item.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool getFoodID = int.TryParse(cboSelectItem.SelectedValue.ToString(), out foodItemID);
                if (getFoodID)
                {
                    Console.WriteLine("Selected food item ID is : " + foodItemID);
                }
                else
                {
                    MessageBox.Show("Sorry an error occured", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            UserSession session = UserSession.Instance;
            int userID = session.GetUserID();
            string foodName = cboSelectItem.GetItemText(cboSelectItem.SelectedItem);

            DialogResult userChoice = MessageBox.Show("Are you sure you want to delete this item?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (userChoice == DialogResult.Yes)
            {

                Console.WriteLine(userID + foodName);
                Boolean deleted = FoodItem.DeleteFoodItem(foodItemID);

                if (deleted)
                {
                    MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Refresh the combo box so deleted item no longer appears
                    DataSet UserFoodItems = Utility.LoadUserFoodItems(userID);
                    cboSelectItem.DisplayMember = "FoodName";
                    cboSelectItem.ValueMember = "FoodItemID";
                    cboSelectItem.DataSource = UserFoodItems.Tables["FoodItems"];
                    cboSelectItem.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("An error occured during deletion.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
            

            
        

       

        private void mnuBackToManageItems_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboSelectItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
