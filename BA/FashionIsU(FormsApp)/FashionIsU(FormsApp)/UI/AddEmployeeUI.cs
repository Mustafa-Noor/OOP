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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FashionIsU_FormsApp_.UI
{
    public partial class AddEmployeeUI : Form
    {
        public AddEmployeeUI()
        {
            InitializeComponent();
            ObjectHandler.GetAdmin().ClearEmployees(); // clears the list of employees
            ObjectHandler.GetEmployeeDL().RetrieveEmployees(ObjectHandler.GetAdmin()); // loads employees in admin

        }

        private void AddEmployeeUI_Load(object sender, EventArgs e)
        {
            MakeColumns();
            DisplayEmployees();
        }
        DataTable dataTable = new DataTable();

        private void MakeColumns() // makes columns
        {
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("Password", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("ContactNo", typeof(string));
            dataTable.Columns.Add("Position", typeof(string));
        }

        private void DisplayEmployees() // display employees
        {
            List<EmployeeBL> AllEmployees = ObjectHandler.GetAdmin().GetAllEmployees();
            foreach (EmployeeBL emp in AllEmployees)
            {
                dataTable.Rows.Add(emp.GetUsername(), emp.GetPassword(), emp.GetEmail(), emp.GetFirstName(), emp.GetLastName(), emp.GetPhoneNumber(), emp.GetPosition());
            }

            EmployeeGrid.DataSource = dataTable;
        }

        private bool ValidateUsername() // validation for username
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

        private bool ValidatePassword() // validation for password 
        {
            if (UtilityClass.CheckforEmpty(password.Text) || UtilityClass.CheckingForSpace(password.Text) || !UtilityClass.CheckingPasswordLength(password.Text) || !UtilityClass.CheckingforInteger(password.Text))
            {
                errorProvider1.SetError(password, "It Must Not Be Empty and Be 6-Digits");
                return false;
            }
            else
            {
                errorProvider1.SetError(password, string.Empty);
                return true;
            }
        }
        private bool ValidateEmail() // validation for email
        {
            if ((UtilityClass.CheckforEmpty(emailBox.Text) || !UtilityClass.ValidateEmailPattern(emailBox.Text)) || UtilityClass.CheckingForcomma(emailBox.Text))
            {
                errorProvider1.SetError(emailBox, "Email is required and in proper format & Not contain Comma");
                return false;
            }
            else
            {
                errorProvider1.SetError(emailBox, string.Empty);
                return true;
            }
        }

        private bool ValidateFirstName() // validation for firstname
        {
            if (UtilityClass.CheckforEmpty(fname.Text) || UtilityClass.CheckingForSpace(fname.Text) || UtilityClass.ContainsInteger(fname.Text) || UtilityClass.CheckingForcomma(fname.Text))
            {
                errorProvider1.SetError(fname, "It Should not Contain space or Contain Number or Comma");
                return false;
            }
            else
            {
                errorProvider1.SetError(fname, string.Empty);
                return true;
            }
        }

        private bool ValidateLastName() // validation for lastname
        {
            if (UtilityClass.CheckforEmpty(lname.Text) || UtilityClass.CheckingForSpace(lname.Text) || UtilityClass.ContainsInteger(lname.Text) || UtilityClass.CheckingForcomma(lname.Text))
            {
                errorProvider1.SetError(lname, "It Should not Contain space or Contain Number or Comma");
                return false;
            }
            else
            {
                errorProvider1.SetError(lname, string.Empty);
                return true;
            }
        }

        private bool ValidateContact() // validation for contact
        {
            if (UtilityClass.CheckforEmpty(contact.Text) || !UtilityClass.ValidateContactPattern(contact.Text))
            {
                errorProvider1.SetError(contact, "Contact is required and in format 1234-5XXXXXX.");
                return false;
            }
            else
            {
                errorProvider1.SetError(contact, string.Empty);
                return true;
            }
        }

        private bool ValidatePostion() // validation for postion
        {
            if (UtilityClass.CheckforEmpty(PositionBox.Text))
            {
                errorProvider1.SetError(PositionBox, "It Is Required");
                return false;
            }
            else
            {
                errorProvider1.SetError(PositionBox, string.Empty);
                return true;

            }
        }

        private EmployeeBL CreateEmployee() // creates an employee object
        {
            return new EmployeeBL(username.Text, password.Text, emailBox.Text, fname.Text, lname.Text, contact.Text, "employee", PositionBox.Text);
        }

        private void ClearTextBoxes() // clears the text boxes
        {
            username.Clear();
            password.Clear();
            emailBox.Clear();
            fname.Clear();
            lname.Clear();
            contact.Clear();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (!ValidateUsername()) {  return; } // Validations for the text boxes
            if (!ValidatePassword()) { return; }
            if (!ValidateEmail()) { return; }
            if (!ValidateFirstName()) { return; }
            if (!ValidateLastName()) { return; }
            if (!ValidateContact()) { return; }
            if (!ValidatePostion()) { return; }

            EmployeeBL employee = CreateEmployee(); // creates employee
            if(ObjectHandler.GetCustomerDL().IsCustomerExists(employee.GetUsername()) || ObjectHandler.GetAdmin().CheckEmployeeExist(employee.GetUsername()))
            {
                MessageBox.Show("User Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ObjectHandler.GetEmployeeDL().AddEmployee(new EmployeeBL(employee)); // adds employee in dl
                ObjectHandler.GetAdmin().ClearEmployees();
                ObjectHandler.GetEmployeeDL().RetrieveEmployees(ObjectHandler.GetAdmin()); // leads employee in admin
                MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataTable.Rows.Clear();
                DisplayEmployees();
                ClearTextBoxes();
            }
        }
    }
}
