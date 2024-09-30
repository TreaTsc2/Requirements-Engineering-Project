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
    public partial class frmManageItems : Form
    {
        frmDisplayMainMenu parent;

        public frmManageItems()
        {
            InitializeComponent();
        }

        public frmManageItems(frmDisplayMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBackToMain_Click(object sender, EventArgs e)
            {
                this.Close();
                parent.Visible = true;
            }

        private void btnAddIntake_Click(object sender, EventArgs e)
        {
            {
                frmAddItem addItemMenu = new frmAddItem(this);
                this.Hide();
                addItemMenu.Show();
            }
        }

       

        private void btnUpdateFoodItem_Click(object sender, EventArgs e)
        {
            frmUpdateItem updateItemMenu = new frmUpdateItem(this);
            this.Hide();
            updateItemMenu.Show();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            frmDeleteItem deleteItemMenu = new frmDeleteItem(this);
            this.Hide();
            deleteItemMenu.Show();
        }



       

        private void frmManageItems_Load(object sender, EventArgs e)
        {

        }
    }
}
