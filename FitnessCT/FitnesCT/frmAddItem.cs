using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FitnessCT
{
    public partial class frmAddItem : Form
    {
        frmManageItems parent;
        public frmAddItem()
        {
            InitializeComponent();
        }

        public frmAddItem(frmManageItems Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int testInt = 0;

            if (txtFoodName.Text.Equals(""))
            {
                MessageBox.Show("Please enter the food's name!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFoodName.Focus();
                return;
            }

            else if (txtPortion.Text.Equals(""))
            {
                MessageBox.Show("Please enter the portion name!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPortion.Focus();
                return;
            }

            else if (txtCaloriesPerPortion.Text.Equals(""))
            {
                MessageBox.Show("Please enter the calories per portion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCaloriesPerPortion.Focus();
                return;
            }

            else if (!int.TryParse(txtCaloriesPerPortion.Text, out testInt) || testInt <= 0)
            {
                MessageBox.Show("Calories per portion must be a positive whole number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCaloriesPerPortion.Focus();
                return;
            }
            else if (testInt <= 0 && testInt > 3000)
            {
                MessageBox.Show("Calories per portion must be between 1 and 3000!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCaloriesPerPortion.Focus();
                return;
            }



            //Initializes session of currently logged in user
            UserSession session = UserSession.Instance;
            int userID = session.GetUserID();

            if (Utility.ValidateIfFoodItemAlreadyExists(userID, txtFoodName.Text) != "-1")  {
                MessageBox.Show("You already added a food item with same name. \n Please enter a different name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int FoodItemID = FoodItem.GetNextFoodItemID();
            FoodItem aFoodItem = new FoodItem(FoodItemID,txtFoodName.Text,txtPortion.Text, Convert.ToInt32(txtCaloriesPerPortion.Text),userID,1);
            aFoodItem.AddFoodItem();

            MessageBox.Show("New food item successfully added", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCaloriesPerPortion.Text = "";
            txtFoodName.Text = "";
            txtPortion.Text = "";

        }

        private void mnuBackToItemMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
