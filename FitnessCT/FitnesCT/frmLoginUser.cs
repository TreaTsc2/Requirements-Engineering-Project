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
    public partial class frmLoginUser : Form
    {
        public frmLoginUser()
        {
            InitializeComponent();
        }

        private void btnLogin(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals("")) 
            {
                MessageBox.Show("Email must be entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else if (txtEmail.Text.Length > 30 || txtEmail.Text.Length < 3)
            {
                MessageBox.Show("Email must be between 3 and 30 characters long!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Password must be entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else if ((Utility.FindEmail(txtEmail.Text)).Equals("-1")) //FindEmail returns -1 if no email found
            {
                MessageBox.Show("No account with the email entered exists.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else if ( (Utility.VerifyLoginInformation(    Utility.FindEmail(txtEmail.Text),txtPassword.Text   )) == false)
            {
                MessageBox.Show("Password entered is incorrect!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            

            UserSession.Instance.Login( Utility.GetIdFromEmail(txtEmail.Text) , Utility.GetDailyCalorieGoalFromUserID(Utility.GetIdFromEmail(txtEmail.Text)) );
            Console.WriteLine(" Login ::: Int from id :" + Convert.ToString(Utility.GetIdFromEmail(txtEmail.Text))  + "Calorie Goal from Email:  " + Utility.GetDailyCalorieGoalFromUserID(Utility.GetIdFromEmail(txtEmail.Text) ) );

            MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmDisplayMainMenu mainMenu = new frmDisplayMainMenu();
            this.Hide();
            mainMenu.Show();
        }



        private void btnRegisteryFromLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterUser registerMenu = new frmRegisterUser();
            registerMenu.Show();
        }

        private void frmLoginUser_Load(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)//Changes the Email to lowercase
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int cursorPosition = textBox.SelectionStart;
                textBox.Text = textBox.Text.ToLower();
                textBox.SelectionStart = cursorPosition;
            }
        }
    }
}
