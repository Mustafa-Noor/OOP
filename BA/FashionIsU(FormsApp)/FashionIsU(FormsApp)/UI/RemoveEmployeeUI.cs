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
    public partial class RemoveEmployeeUI : Form
    {
        public RemoveEmployeeUI()
        {
            InitializeComponent();
            ObjectHandler.GetAdmin().ClearEmployees();
            ObjectHandler.GetEmployeeDL().RetrieveEmployees(ObjectHandler.GetAdmin());
        }

        private void RemoveEmployeeUI_Load(object sender, EventArgs e)
        {
            MakeColumns();
            DisplayEmployees();
        }

        DataTable dataTable = new DataTable();

        private void MakeColumns()
        {
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("Password", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("ContactNo", typeof(string));
            dataTable.Columns.Add("Position", typeof(string));
        }

        private void DisplayEmployees()
        {
            List<EmployeeBL> AllEmployees = ObjectHandler.GetAdmin().GetAllEmployees();
            foreach (EmployeeBL emp in AllEmployees)
            {
                dataTable.Rows.Add(emp.GetUsername(), emp.GetPassword(), emp.GetEmail(), emp.GetFirstName(), emp.GetLastName(), emp.GetPhoneNumber(), emp.GetPosition());
            }

            EmployeeGrid.DataSource = dataTable;
        }

        private bool ValidateUsername() // validates the username text box
        {
            if (UtilityClass.CheckforEmpty(username.Text) || UtilityClass.CheckingForSpace(username.Text) || UtilityClass.CheckingForcomma(username.Text))
            {
                errorProvider1.SetError(username, "It Must Not Be Empty or Contain Space or Comma");
                return false;
            }
            else
            {
                errorProvider1.SetError(username, string.Empty);
                return true;
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (!ValidateUsername()) { return; } // validation for username 
            EmployeeBL emp = ObjectHandler.GetAdmin().FindEmployee(username.Text);
            if (emp != null)
            {
                // funcitonalitty for deleting an employee
                ObjectHandler.GetEmployeeDL().DeleteEmployee(emp);
                ObjectHandler.GetAdmin().ClearEmployees();
                ObjectHandler.GetEmployeeDL().RetrieveEmployees(ObjectHandler.GetAdmin());
                MessageBox.Show("Employee Removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataTable.Rows.Clear();
                DisplayEmployees();
                username.Clear();
            }
            else
            {
                MessageBox.Show("Employee Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
