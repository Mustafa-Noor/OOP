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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void ClearDataFromForm()
        {
            SignInUserNametxt.Clear();
            passwordtxt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = SignInUserNametxt.Text;
            string password = passwordtxt.Text;
            MUserBL user = new MUserBL(username, password);
            MUserBL validU = MUserDL.SignIn(user);
            if (validU != null)
            {
                MessageBox.Show("User is Valid");
            }
            else
            {
                MessageBox.Show("User is Invalid");
            }

            ClearDataFromForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
