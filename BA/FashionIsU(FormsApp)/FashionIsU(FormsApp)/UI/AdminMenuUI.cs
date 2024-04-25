using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionIsU_FormsApp_.UI
{
    public partial class AdminMenuUI : Form
    {
        public AdminMenuUI()
        {
            InitializeComponent();

        }

        private void AdminMenuUI_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        public void openChildForm(Form childForm) // this is for the child panels
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

        private void AddEmpBtn_Click(object sender, EventArgs e)
        {
            if (ObjectHandler.GetAdmin().CheckEmployeesCount()) // checks the number of employees
            {
                openChildForm(new AddEmployeeUI());
            }
            else
            {
                MessageBox.Show("There are no Employees Yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateEmpBtn_Click(object sender, EventArgs e)
        {
            if (ObjectHandler.GetAdmin().CheckEmployeesCount())
            {
                openChildForm(new UpdateEmployeeUI()); // opens update employee
            }
            else
            {
                MessageBox.Show("There are no Employees Yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveEmpBtn_Click(object sender, EventArgs e) // open the remove employee page
        {
            if (ObjectHandler.GetAdmin().CheckEmployeesCount())
            {
                openChildForm(new RemoveEmployeeUI());
            }
            else
            {
                MessageBox.Show("There are no Employees Yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCusBtn_Click(object sender, EventArgs e) // displays customer on pressing of button
        {
            if (ObjectHandler.GetCustomerDL().CheckCustomersCount())
            {
                openChildForm(new DisplayCustomersAdminUI());
            }
            else
            {
                MessageBox.Show("There Are No Customers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e) // exits the program
        {
            this.Hide();
            Form form = new MainUI();
            form.ShowDialog();
        }
    }
}
