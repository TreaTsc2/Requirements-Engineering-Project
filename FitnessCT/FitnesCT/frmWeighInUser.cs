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
    public partial class frmWeighInUser : Form
    {
        frmDisplayMainMenu parent;
        UserSession session = UserSession.Instance;
        public frmWeighInUser()
        {
            InitializeComponent();
        }

        public frmWeighInUser(frmDisplayMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }


        private void cboUpdateActivityLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            double test;
            int activityLevelID = 0;
            int userID = session.GetUserID();
            if (cboUpdateActivityLevel.SelectedIndex >= 0)
            {
                int.TryParse(cboUpdateActivityLevel.SelectedValue.ToString(), out activityLevelID);
            }


            if (txtUpdateWeight.Text.Equals("") && cboUpdateActivityLevel.Text.Equals(""))
            {
                MessageBox.Show("Please enter a weight or activity level", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateWeight.Focus();
                return;
            }
            if (!double.TryParse(txtUpdateWeight.Text, out test) || test <= 30 || test > 600)
            {
                MessageBox.Show("Weight must be a positive value between 30 and 600kg.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateWeight.Focus();
                return;
            }

            string[] weightSplit = txtUpdateWeight.Text.Split('.');
            if (weightSplit.Length > 2 || (weightSplit.Length == 2 && weightSplit[1].Length > 1))
            {
                MessageBox.Show("Weight can have at most one decimal place with one number after it.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateWeight.Focus();
                return;
            }

            if (txtUpdateWeight.Text.Length < 2 || txtUpdateWeight.Text.Length > 5)
            {
                MessageBox.Show("Weight must be between 2 to 5 characters long including the decimal point!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateWeight.Focus();
                return;
            }

            Console.WriteLine("activityLevelBeing passed to update weight details is : " + activityLevelID);
            if (Account.UpdateWeightDetails(userID, Convert.ToDouble(txtUpdateWeight.Text), activityLevelID))
            {
                MessageBox.Show("Weigh In updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error occured while updating", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void frmWeighInUser_Load(object sender, EventArgs e)
        {
            DataSet activityLevelsDataSet = Utility.LoadActivityLevels();

            cboUpdateActivityLevel.DisplayMember = "LevelName";
            cboUpdateActivityLevel.ValueMember = "ActivityLevelID";
            cboUpdateActivityLevel.DataSource = activityLevelsDataSet.Tables["ActivityLevels"];

            cboUpdateActivityLevel.SelectedIndex = -1;
        }

        private void mnuBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void mnuBackToManageItems_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void mnuBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
