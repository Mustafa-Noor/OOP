using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FashionIsU;

namespace FashionIsU_FormsApp_.UI
{
    public partial class EmployeeMenuUI : Form
    {
        private EmployeeBL employee;
        public EmployeeMenuUI(EmployeeBL employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm) // functionality for the child forms
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Clear(); // Clear any existing controls in the panel
            panelChild.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelChild_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SidemenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddItemMenuBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new AddClothUI());
        }

        private void UpdateItemBtn_Click(object sender, EventArgs e) // opens update items page
        {
            if(ObjectHandler.GetClothesDL().CheckClothes())
            {
                openChildForm(new UpdateClothUI());
            }
            else
            {
                MessageBox.Show("There Are No Clothes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DeleteItemBtn_Click(object sender, EventArgs e) // opens delete items page
        {
            if (ObjectHandler.GetClothesDL().CheckClothes())
            {
                openChildForm(new DeleteClothUI());
            }
            else
            {
                MessageBox.Show("There Are No Clothes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCustomersBtn_Click(object sender, EventArgs e) // open display customers page
        {
            if(ObjectHandler.GetCustomerDL().CheckCustomersCount())
            {
                openChildForm(new DisplayCustomersUI());
            }
            else
            {
                MessageBox.Show("There Are No Customers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReviewPageBtn_Click(object sender, EventArgs e) // opens order of customers view page
        {
            if (ObjectHandler.GetCustomerDL().CheckCustomersCount())
            {
                openChildForm(new DisplayOrderOfCustomerUI());
            }
            else
            {
                MessageBox.Show("There Are No Customers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayReviewsBTn_Click(object sender, EventArgs e) // display reviews of an item page
        {
            if (ObjectHandler.GetClothesDL().CheckClothes())
            {
                openChildForm(new DisplayReviewsUI());
            }
            else
            {
                MessageBox.Show("There Are No Clothes !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e) // opens update profile page
        {
            openChildForm(new UpdateProfileEmployeeUI(employee));
        }

        private void ExitBtn_Click(object sender, EventArgs e) // exits the employee menu
        {
            this.Hide();
            Form form = new MainUI();
            form.ShowDialog();
        }
    }
}
