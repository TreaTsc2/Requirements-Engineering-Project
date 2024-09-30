using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FitnessCT
{
    public partial class frmRegisterUser : Form
    {
        public frmRegisterUser()
        {
            InitializeComponent();
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            double testWeight;
            int testHeight;
            Boolean isValid = true;

           
            


            if (txtRegisterForename.Text.Equals(""))
            {
                MessageBox.Show("Forename must be entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterForename.Focus();
                return;
            }
            else if (txtRegisterForename.Text.Length > 15) 
            {
                MessageBox.Show("Forename cannot be longer then 15 characters!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterForename.Focus();
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtRegisterForename.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Forename must be alphabetic characters only!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterForename.Focus();
                return;
            }
            else if (txtRegisterSurname.Text.Equals(""))
            {
                MessageBox.Show("Surname must be entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterSurname.Focus();
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtRegisterSurname.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Forename must be alphabetic characters only!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterSurname.Focus();
                return;
            }
            else if (txtRegisterSurname.Text.Length > 15)
            {
                MessageBox.Show("Surname cannot be longer then 15 characters!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterSurname.Focus();
                return;
            }
            else if (txtRegisterEmail.Text.Equals(""))
            {
                MessageBox.Show("Email must be entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterEmail.Focus();
                return;
            }
            else if (txtRegisterEmail.Text.Length > 30 || txtRegisterEmail.Text.Length < 5)
            {
                MessageBox.Show("Email must be between 5 and 30 characters long!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterEmail.Focus();
                return;
            }

            else if (txtRegisterPassword.Text.Equals(""))
            {
                MessageBox.Show("Password must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterPassword.Focus();
                return;
            }

            else if (txtRegisterPassword.Text.Length > 16 || txtRegisterPassword.Text.Length < 5)
            {
                MessageBox.Show("Password must be between 5 to 16 characters long.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterPassword.Focus();
                return;
            }

            if (txtRegisterHeight.Text.Equals(""))
            {
                MessageBox.Show("Height must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterHeight.Focus();
                return;
            }
            else if (!int.TryParse(txtRegisterHeight.Text, out testHeight) || testHeight <= 50 || testHeight > 350)
            {
                MessageBox.Show("Height must be between 50 and 350 centimeters", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterHeight.Focus();
                return;
            }

            if (!double.TryParse(txtRegisterWeight.Text, out testWeight) || testWeight <= 30 || testWeight > 600)
            {
                MessageBox.Show("Weight must be a positive value between 30 and 600kg.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterWeight.Focus();
                return;
            }


            // Gender and Activity Level validation
            if (cboRegisterGender.Text.Equals(""))
            {
                MessageBox.Show("Gender must be selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRegisterGender.Focus();
                return;
            }

            if (cboRegisterActivityLevel.Text.Equals(""))
            {
                MessageBox.Show("Activity level must be selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRegisterActivityLevel.Focus();
                return;
            }

            else if (txtRegisterWeight.Text.Equals(""))
            {
                MessageBox.Show("Weight must be entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterWeight.Focus();
                return;
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtRegisterHeight.Text, @"^\d{2,3}$"))
            {
                MessageBox.Show("Height must be either 2 or 3 digits long and contain no decimals!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegisterHeight.Focus();
                return;
            }

            else if (cboRegisterGender.Text.Equals(""))
            {
                MessageBox.Show("Gender must be selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRegisterGender.Focus();
                return;
            }
            else if (cboRegisterActivityLevel.Text.Equals(""))
            {
                MessageBox.Show("Activity level must be selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRegisterActivityLevel.Focus();
                return;
            }


            //Check if email is already registereed
            else if(!(Utility.FindEmail(txtRegisterEmail.Text)).Equals("-1") ) //FindEmail returns -1 if no email found
            {
                MessageBox.Show("The email address you entered is already registered. \n" +
                    "Please use a different email address.","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            if (isValid)
            {

                int userID = Account.getNextUserID();

                Account aUser = new Account(userID, txtRegisterForename.Text, txtRegisterSurname.Text,
                                txtRegisterEmail.Text, txtRegisterPassword.Text, dtpDOB.Value, Convert.ToDecimal(txtRegisterHeight.Text), Convert.ToDecimal(txtRegisterWeight.Text),
                                cboRegisterGender.Text, Utility.GetActivityLevelIdByName(cboRegisterActivityLevel.Text),
                               0) ;

  
                aUser.CalculateDailyCalorieGoal();


                aUser.RegisterUser();

             
                MessageBox.Show("Registration Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserSession.Instance.Login((Utility.GetIdFromEmail(txtRegisterEmail.Text)), Utility.GetDailyCalorieGoalFromUserID(Utility.GetIdFromEmail(txtRegisterEmail.Text)));

                frmDisplayMainMenu mainMenu = new frmDisplayMainMenu();
                this.Hide();
                mainMenu.Show();
            }

            else
            {
                // Handle invalid input, show an error message or highlight the invalid fields
                MessageBox.Show("Registration Failed. Please check the input fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Register the user in the database

        }

        private void frmRegisterUser_Load(object sender, EventArgs e)
        {
            //Max/Min Dates
            dtpDOB.MaxDate = DateTime.Today.AddYears(-16);
            dtpDOB.MinDate = DateTime.Today.AddYears(-100);

            // Load activity levels into the ComboBox
            try
            {
                DataSet activityLevelsDataSet = Utility.LoadActivityLevels();

                cboRegisterActivityLevel.DisplayMember = "LevelName";
                cboRegisterActivityLevel.ValueMember = "ActivityLevelID";
                cboRegisterActivityLevel.DataSource = activityLevelsDataSet.Tables["ActivityLevels"];
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during loading activity levels
                MessageBox.Show("An error occurred while loading activity levels: " + ex.Message);
            }
        }

        private void btnEnterLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginUser loginForm = new frmLoginUser();
            loginForm.Show();
        }

        private void cboRegisterActivityLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRegisterEmail_TextChanged(object sender, EventArgs e) //Changes the Email to Lowercase
        {

                TextBox textBox = sender as TextBox;
                if (textBox != null)
                {
                    int cursorPosition = textBox.SelectionStart;
                    textBox.Text = textBox.Text.ToLower();
                    textBox.SelectionStart = cursorPosition;
                }
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
