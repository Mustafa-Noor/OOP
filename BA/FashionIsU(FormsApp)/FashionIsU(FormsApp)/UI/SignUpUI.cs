using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FashionIsU;
using FashionIsUlLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FashionIsU_FormsApp_.UI
{
    public partial class SignUpUI : Form
    {
        public SignUpUI()
        {
            InitializeComponent();
            ObjectHandler.GetAdmin().ClearEmployees();
            ObjectHandler.GetEmployeeDL().RetrieveEmployees(ObjectHandler.GetAdmin());
        }

        private void SignInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form form = new SignInUI();
            form.ShowDialog();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new MainUI();
            form.ShowDialog();
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            if(!ValidateUsername()){ return; }
            if(!ValidatePassword()) { return; }
            if(!ValidateEmail()) { return; }
            if(!ValidateFirstName()) { return; }
            if(!ValidateLastName()) { return; }
            if (!ValidateContact()) {  return; }

            CustomerBL cus = CreateCustomer();
            if (ObjectHandler.GetCustomerDL().IsCustomerExists(cus.GetUsername()) || ObjectHandler.GetAdmin().CheckEmployeeExist(cus.GetUsername()))
            {
                MessageBox.Show("User Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ObjectHandler.GetCustomerDL().AddCustomer(cus))
                {
                    MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                }

            }
            
        }

        private CustomerBL CreateCustomer()
        {
            return new CustomerBL(username.Text, password.Text, email.Text, firstName.Text, lastName.Text, contact.Text, "customer");
        }

        private void SignUpUI_Load(object sender, EventArgs e)
        {

        }
        private bool ValidateUsername()
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
                errorProvider1.SetError(email, "Email is required and in proper format & Not contain Comma");
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
            if(UtilityClass.CheckforEmpty(contact.Text) || !UtilityClass.ValidateContactPattern(contact.Text))
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
            username.Clear();
            password.Clear();
            email.Clear();
            firstName.Clear();
            lastName.Clear();
            contact.Clear();
        }

    }
}
