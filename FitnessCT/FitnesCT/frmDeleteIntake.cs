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
    public partial class frmDeleteIntake : Form
    {
        frmManageIntake parent;
        UserSession session = UserSession.Instance;
        

        public frmDeleteIntake()
        {
            InitializeComponent();


            
        }
        public frmDeleteIntake(frmManageIntake Parent)
        {
            InitializeComponent();
            parent = Parent;
        }


        private void mnuBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnDeleteIntake_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this intake?", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
               
                int intakeID = Convert.ToInt32(cboDeleteItem.SelectedValue);
                int userID = session.GetUserID();
                if (FoodIntake.DeleteFoodIntake(intakeID)) {
                    MessageBox.Show("Item has been deleted", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //Refresh Delete Item Combo box.
                    try
                    {
                        DataSet UserFoodIntakes = Utility.LoadSelectedFoodIntake(userID, dtpIntakeDate.Value);

                        cboDeleteItem.DisplayMember = "FoodName";
                        cboDeleteItem.ValueMember = "IntakeID";
                        cboDeleteItem.DataSource = UserFoodIntakes.Tables["FoodIntake"];

                        if (UserFoodIntakes.Tables["FoodIntake"].Rows.Count > 0)
                        {
                            grpDeleteFoodItem.Visible = true;
                        }
                        else
                        {
                            grpDeleteFoodItem.Visible = false;
                        }

                    }
                    catch (Exception ex)
                    {
                        // Handle any errors that occur during loading activity levels
                        MessageBox.Show("An error occurred while loading user foodIntake: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("An error occured while deleting the item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            else
            {
                return;
            }

        }

        private void frmdeleteIntake_Load(object sender, EventArgs e)
        {
            
            grpDeleteFoodItem.Visible = false;
            dtpIntakeDate.MaxDate = DateTime.Today;


        }

        private void lblU_Click(object sender, EventArgs e)
        {

        }

        private void dtpIntakeDate_ValueChanged(object sender, EventArgs e)
        {

            int userID = session.GetUserID();
            Console.WriteLine("User ID is : " + userID + "\nDate is : " + dtpIntakeDate.Value);
            try
            {
                DataSet UserFoodIntakes = Utility.LoadSelectedFoodIntake(userID,dtpIntakeDate.Value);

                cboDeleteItem.DisplayMember = "FoodName";
                cboDeleteItem.ValueMember = "IntakeID";
                cboDeleteItem.DataSource = UserFoodIntakes.Tables["FoodIntake"];

                if (UserFoodIntakes.Tables["FoodIntake"].Rows.Count > 0)
                            {
                                grpDeleteFoodItem.Visible = true;
                            }
                else
                {
                    grpDeleteFoodItem.Visible = false;
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during loading activity levels
                MessageBox.Show("An error occurred while loading user foodIntake: " + ex.Message);
            }
            

        }

        private void cboDeleteItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
