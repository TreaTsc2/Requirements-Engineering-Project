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
    public partial class frmManageIntake : Form
    {

        frmDisplayMainMenu parent;

        public frmManageIntake()
        {
            InitializeComponent();

        }

        public frmManageIntake(frmDisplayMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        private void btnAddIntake_Click(object sender, EventArgs e)
        {   
            frmRecordIntake recordIntakeMenu = new frmRecordIntake(this);
            this.Hide();
            recordIntakeMenu.Show();
        }

        private void btnUpdateIntake_Click(object sender, EventArgs e)
        {
            frmUpdateIntake updateIntakeMenu = new frmUpdateIntake(this);
            this.Hide();
            updateIntakeMenu.Show();
        }

        private void btnDeleteIntake_Click(object sender, EventArgs e)
        {
            frmDeleteIntake deleteIntakeMenu = new frmDeleteIntake(this);
            this.Hide();
            deleteIntakeMenu.Show();
        }

        private void mnu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmManageIntake_Load(object sender, EventArgs e)
        {

        }
    }
}
