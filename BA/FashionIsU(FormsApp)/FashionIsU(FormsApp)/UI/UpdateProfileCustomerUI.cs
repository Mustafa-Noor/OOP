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
using FashionIsUlLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FashionIsU_FormsApp_.UI
{
    public partial class UpdateProfileCustomerUI : Form
    {
        private CustomerBL customer;
        public UpdateProfileCustomerUI(CustomerBL customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void UpdateProfileUI_Load(object sender, EventArgs e)
        {
            SetUsernameLabel();
        }

        private void SetUsernameLabel()
        {
            UsernameLabel.Text = "Your Username is : " + customer.GetUsername();
        }

        private void UpdateProfileBtn_Click(object sender, EventArgs e)
        {
            
            if (!ValidatePassword()) { return; } // validations for the text boxes
            if (!ValidateEmail()) { return; }
            if (!ValidateFirstName()) { return; }
            if (!ValidateLastName()) { return; }
            if (!ValidateContact()) { return; }
            customer.UpdateProfile(password.Text, email.Text, firstName.Text, lastName.Text, contact.Text);
            ObjectHandler.GetCustomerDL().UpdateProfile(customer);
            MessageBox.Show("Successfully Update Profile", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();

        }
        // functions for the validaiotn of input boxes
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
                errorProvider1.SetError(email, "Email is required and in proper format  & not contain Comma");
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

        private void ClearTextBoxes()
        {
            
            password.Clear();
            email.Clear();
            firstName.Clear();
            lastName.Clear();
            contact.Clear();
        }
    }
}
