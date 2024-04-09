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

namespace FashionIsU_FormsApp_.UI
{
    public partial class SignInUI : Form
    {
        public SignInUI()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form form = new SignUpUI();
            form.ShowDialog();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new MainUI();
            form.ShowDialog();
        }

        private void SignInbtn_Click(object sender, EventArgs e)
        {
            if(!ValidateRole())
            { return; }
            if(!ValidateUsername())
            { return; }
            if(!ValidatePassword())
            { return; }

            UserBL u = GiveUser();

            if (ObjectHandler.GetUserDL().FindUser(u) != null && RoleCombo.Text == "Customer")
            {
                CustomerBL customer = ObjectHandler.GetUserDL().FindUser(u) as CustomerBL;
                if(customer != null)
                {
                    this.Hide();
                    Form form = new CustomerMenuUI(customer);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Customer not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ObjectHandler.GetUserDL().FindUser(u) != null && RoleCombo.Text == "Employee")
            {
                EmployeeBL employee = ObjectHandler.GetUserDL().FindUser(u) as EmployeeBL;
                if(employee != null)
                {
                    this.Hide();
                    Form form = new EmployeeMenuUI(employee);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Employee not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private UserBL GiveUser()
        {
            if (RoleCombo.Text == "Customer")
            {
                CustomerBL customer = new CustomerBL(username.Text, password.Text);
                return customer;
            }
            else
            {
                EmployeeBL employee = new EmployeeBL(username.Text, password.Text);
                return employee;
            }
        }

        private void SignInUI_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateRole()
        {
            if(!UtilityClass.ValidateRole(RoleCombo.Text.ToLower()))
            {
                errorProvider1.SetError(RoleCombo, "Select a Role.");
                return false;
            }
            else
            {
                errorProvider1.SetError(RoleCombo, string.Empty);
                return true;
            }
        }

        private bool ValidateUsername()
        {
            if (UtilityClass.CheckforEmpty(username.Text) || UtilityClass.CheckingForSpace(username.Text))
            {
                errorProvider2.SetError(username, "It Must Not Be Empty or Contain Space");
                return false;
            }
            else
            {
                errorProvider2.SetError(username, string.Empty);
                return true;
            }
        }

        private bool ValidatePassword()
        {
            if (UtilityClass.CheckforEmpty(password.Text) || UtilityClass.CheckingForSpace(password.Text) || !UtilityClass.CheckingPasswordLength(password.Text) || !UtilityClass.CheckingforInteger(password.Text))
            {
                errorProvider3.SetError(password, "It Must Not Be Empty and Be 6-Digits");
                return false;
            }
            else
            {
                errorProvider3.SetError(password, string.Empty);
                return true;
            }
        }
    }
}
