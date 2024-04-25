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
    public partial class UpdateProfileEmployeeUI : Form
    {
        private EmployeeBL employee;
        public UpdateProfileEmployeeUI(EmployeeBL employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void UpdateProfileEmployee_Load(object sender, EventArgs e)
        {
            SetUsernameLabel();
        }

        private void SetUsernameLabel()
        {
            UsernameLabel.Text = "Your Username is : " + employee.GetUsername();
        }

        // validaion for the input boxes
        private bool ValidatePassword()
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
        private bool ValidateEmail()
        {
            if ((UtilityClass.CheckforEmpty(email.Text) || !UtilityClass.ValidateEmailPattern(email.Text)) || UtilityClass.CheckingForcomma(email.Text))
            {
                errorProvider1.SetError(email, "Email is required and in proper format & Not Contain Comma");
                return false;
            }
            else
            {
                errorProvider1.SetError(email, string.Empty);
                return true;
            }
        }

        private bool ValidateFirstName()
        {
            if (UtilityClass.CheckforEmpty(firstName.Text) || UtilityClass.CheckingForSpace(firstName.Text) || UtilityClass.ContainsInteger(firstName.Text) || UtilityClass.CheckingForcomma(firstName.Text))
            {
                errorProvider1.SetError(firstName, "It Should not Contain space or Contain Number or Comma");
                return false;
            }
            else
            {
                errorProvider1.SetError(firstName, string.Empty);
                return true;
            }
        }

        private bool ValidateLastName()
        {
            if (UtilityClass.CheckforEmpty(lastName.Text) || UtilityClass.CheckingForSpace(lastName.Text) || UtilityClass.ContainsInteger(lastName.Text) || UtilityClass.CheckingForcomma(lastName.Text))
            {
                errorProvider1.SetError(lastName, "It Should not Contain space or Contain Number or Comma");
                return false;
            }
            else
            {
                errorProvider1.SetError(lastName, string.Empty);
                return true;
            }
        }

        private bool ValidateContact()
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

        private void ClearTextBoxes() // clears all the text boxes
        {

            password.Clear();
            email.Clear();
            firstName.Clear();
            lastName.Clear();
            contact.Clear();
        }

        private void UpdateProfileBtn_Click(object sender, EventArgs e) // updates the profile of an customer
        {
            if (!ValidatePassword()) { return; } /// validation for the text boxes
            if (!ValidateEmail()) { return; }
            if (!ValidateFirstName()) { return; }
            if (!ValidateLastName()) { return; }
            if (!ValidateContact()) { return; }
            employee.UpdateProfile(password.Text, email.Text, firstName.Text, lastName.Text, contact.Text);
            ObjectHandler.GetEmployeeDL().UpdateProfile(employee);
            MessageBox.Show("Successfully Update Profile", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
        }
    }
}
