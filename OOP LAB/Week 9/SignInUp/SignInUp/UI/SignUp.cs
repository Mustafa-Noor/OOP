using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignInUp.BL;
using SignInUp.DL;

namespace SignInUp.UI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void ClearDataFromForm()
        {
            username.Text = "";
            password.Text = "";
            role.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = username.Text;
            string pass = password.Text;
            string role1 =  role.Text;
            string path = "data.txt";
            MUserBL user = new MUserBL(userName, pass, role1);
            MUserDL.AddUserIntoList(user);
            MessageBox.Show("User Added Successfully");
            ClearDataFromForm();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
