using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FashionIsU;

namespace FashionIsU_FormsApp_.UI
{
    public partial class UpdateEmployeeUI : Form
    {
        public UpdateEmployeeUI()
        {
            InitializeComponent();
            ObjectHandler.GetAdmin().ClearEmployees();
            ObjectHandler.GetEmployeeDL().RetrieveEmployees(ObjectHandler.GetAdmin());
        }

        private void UpdateEmployeeUI_Load(object sender, EventArgs e)
        {
            MakeColumns();
            DisplayEmployees();
        }

        DataTable dataTable = new DataTable();

        private void MakeColumns() // makes columm for the grid
        {
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("Password", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("ContactNo", typeof(string));
            dataTable.Columns.Add("Position", typeof(string));
        }

        private void DisplayEmployees() // display eployee
        {
            List<EmployeeBL> AllEmployees = ObjectHandler.GetAdmin().GetAllEmployees();
            foreach (EmployeeBL emp in AllEmployees)
            {
                dataTable.Rows.Add(emp.GetUsername(), emp.GetPassword(), emp.GetEmail(), emp.GetFirstName(), emp.GetLastName(), emp.GetPhoneNumber(), emp.GetPosition());
            }

            EmployeeGrid.DataSource = dataTable;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (!ValidateUsername()) { return; } // validation for the text boxes
            if (!ValidatePassword()) { return; }
            if (!ValidateEmail()) { return; }
            if (!ValidateFirstName()) { return; }
            if (!ValidateLastName()) { return; }
            if (!ValidateContact()) { return; }
            if (!ValidatePostion()) { return; }
            EmployeeBL emp = ObjectHandler.GetAdmin().FindEmployee(username.Text);
            if (emp != null)
            {
                // functionality for updation of the employee
                EmployeeBL employeeUpdate = new EmployeeBL(emp.GetUsername(), password.Text, emailBox.Text, fname.Text, lname.Text, contact.Text, emp.GetRole(), PositionBox.Text);
                emp.UpdateProfile(employeeUpdate);
                ObjectHandler.GetEmployeeDL().UpdateProfile(emp);
                ObjectHandler.GetAdmin().ClearEmployees();
                ObjectHandler.GetEmployeeDL().RetrieveEmployees(ObjectHandler.GetAdmin());
                MessageBox.Show("Employee Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataTable.Rows.Clear();
                DisplayEmployees();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Employee Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidateUsername() // validaiton for the username textbox
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

        private bool ValidatePassword() // validaiton for tpassword text box
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
        private bool ValidateEmail() // validaiotn for the email text box
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

        private bool ValidateFirstName() // validation for the firstname
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

        private bool ValidateLastName() // validaiont for the lastname
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

        private bool ValidateContact() //validation for the contact box
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

        private bool ValidatePostion() // validation for the position comvo box
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

        private void ClearTextBoxes() // clearts all the text boxes
        {
            username.Clear();
            password.Clear();
            emailBox.Clear();
            fname.Clear();
            lname.Clear();
            contact.Clear();
        }
    }
}
